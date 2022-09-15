using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.InteropServices;
using System.Reflection;
using uint8_t = System.Byte;
using uint16_t = System.UInt16;
using uint32_t = System.UInt32;
using int32_t = System.Int32;

namespace MlxSerialTerminal
{
    public partial class MainForm : Form
    {
        private SerialPortMgr _serialPortMgr = new SerialPortMgr();
        private ConfigMgr _configMgr = null;
        private FilterMgr _filterMgr = new FilterMgr();
        private bool _IsHitOn = false;
        private string _sDebugHlp = "";



        public MainForm()
        {
            InitializeComponent();
            Init();
        }




        void Init()
        {

            _serialPortMgr.SetPortName("COM4");

            _configMgr = new ConfigMgr();

            manageCommPort();
        }

        void addDataToFromSerial(string sInData, Color? color = null)
        {
            Color clr = color ?? Color.Black;
            string sText = sInData;
            if (btn_StopStart.Text == "Stop")
            {
                ApplyHitOn(sText);

                if (_filterMgr.GetEnabled() == true)
                {
                    sText = _filterMgr.ApplyFilters(sText);
                }

                sText = sText.Replace("\r\r\n", "\r\n");
                tb_Output.Select(tb_Output.TextLength, 0);
                tb_Output.SelectionColor = clr;
                tb_Output.AppendText(sText);
            }
        }

        private void ApplyHitOn(string sText)
        {
            string sStopWord = "Zynq>";
            if (_IsHitOn == true)
            {
                if (sText.Length != 0)
                {
                    if (sText.IndexOf(sStopWord) != -1)
                    {
                        _IsHitOn = false;
                        btn_Hit.Text = "HitOn";

                    }
                    else
                    {
                        _serialPortMgr.Write("\n");
                    }
                }
            }
        }

        private void btn_StopStart_Click(object sender, EventArgs e)
        {
            if (btn_StopStart.Text == "Stop")
            {
                btn_StopStart.Text = "Start";
            }
            else
            { btn_StopStart.Text = "Stop"; }
        }

        private void btn_OpenClosePort_Click(object sender, EventArgs e)
        {
            if (btn_OpenClosePort.Text == "Open Port")
            {
                btn_OpenClosePort.Text = "Close Port";
            }
            else
            {
                btn_OpenClosePort.Text = "Open Port";
            }
            manageCommPort();

        }

        private void manageCommPort()
        {
            //string[] sNames = SerialPort.GetPortNames();


            if (_serialPortMgr.IsOpen() == false)
            {
                _serialPortMgr.SetPortName(_configMgr._configDetail.sPortName);
                addDataToFromSerial("using serial port:" + _serialPortMgr.GetPortName() + "\r\n");
                this.Text = "MlxSerialTerminal" + " " + _serialPortMgr.GetPortName();

                try
                {
                    _serialPortMgr.Open();
                    timer2SerialRead.Start();
                    timer_ports.Stop();
                }
                catch (UnauthorizedAccessException e)
                {
                    addDataToFromSerial(e.Message + "\r\n");
                    string[] sNames = SerialPort.GetPortNames();
                    ts_CommPorts.Items.Clear();
                    foreach (string sName in sNames)
                    {
                        ts_CommPorts.Items.Add(sName);
                    }
                    timer_ports.Start();

                }
                catch (IOException e)
                {
                    addDataToFromSerial(e.Message + "\r\n");
                    string[] sNames = SerialPort.GetPortNames();
                    ts_CommPorts.Items.Clear();
                    foreach (string sName in sNames)
                    {
                        ts_CommPorts.Items.Add(sName);
                    }
                    timer_ports.Start();

                }
            }
            else
            {
                _serialPortMgr.Close();
                timer2SerialRead.Stop();
                addDataToFromSerial("port:" + _serialPortMgr.GetPortName() + " is closed" + "\r\n");
                //timer_ports.Start();
            }


        }

        private void timer2SerialRead_Tick(object sender, EventArgs e)
        {
            if (_serialPortMgr.IsOpen() == false)
            {
                timer2SerialRead.Stop();
                timer_ports.Start();
                return;
            }

            if (_serialPortMgr.Byte2Read() > 0)
            {
                string inData = _serialPortMgr.ReadExisting();
                addDataToFromSerial(inData);
                _sDebugHlp += inData;
                while (_sDebugHlp.Length > 20)
                {
                    debug_process();
                }

            }
        }

        private void debug_process()
        {
            string sTypeName = "typeName=";
            int nStartPos = _sDebugHlp.IndexOf(sTypeName);
            if (nStartPos == -1)
            {
                _sDebugHlp = "";
                return;
            }
            int nStopPos = _sDebugHlp.IndexOf(";", nStartPos);
            if (nStopPos == -1)
            {
                _sDebugHlp = "";
                return;
            }
            sTypeName = _sDebugHlp.Substring(nStartPos, nStopPos - nStartPos).Trim();
            sTypeName = sTypeName.Split("=")[1];
            string sStartDebug = "printd start:";
            string sStopDebug = "printd end:";
            nStartPos = _sDebugHlp.IndexOf(sStartDebug);
            nStopPos = _sDebugHlp.IndexOf(sStopDebug);
            if (nStartPos == -1 || nStopPos == -1)
            {
                _sDebugHlp = "";
                return;
            }
            byte[] sTempBytes;
            if (nStopPos <= nStartPos)
            {
                _sDebugHlp = "";
                return;
            }
            if (nStartPos >= 0 && nStopPos > 0)
            {
                nStartPos += sStartDebug.Length;
                nStopPos -= 1;
                string sDebugLine = _sDebugHlp.Substring(nStartPos, nStopPos - nStartPos);
                _sDebugHlp = _sDebugHlp.Substring(nStopPos + sStopDebug.Length);
                string[] sTemp = sDebugLine.Split(" ");
                sTempBytes = new byte[sTemp.Length];
                int i = 0;
                foreach (string sByte in sTemp)
                {
                    sTempBytes[i++] = (byte)Int32.Parse(sByte.Replace("0x", ""), System.Globalization.NumberStyles.HexNumber);
                }
                debug_cast2struct(sTypeName, sTempBytes);

            }


        }


        struct TLV_CMD_HEADER
        {
            //https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/integral-numeric-types
            uint8_t u8_req;
            uint8_t u8_subtype;
            uint16_t u16_command;
            uint32_t u32_lenght;
        }



        struct NAB_CMD_HEADER
        {
            uint32_t u32_command_hex;
            uint16_t u16_transaction;
            uint16_t u16_instance;
            uint16_t u16_size;
            uint16_t u16_version;
        }

        struct NAB_CMD_RES_HEADER
        {
            uint32_t u32_command_hex;
            uint16_t u16_transaction;
            uint16_t u16_instance;
            uint16_t u16_size;
            uint16_t u16_version;
            int32_t s32_result;
        }

        private void debug_cast2struct(string sTypeName, byte[] bytes)
        {
            if (sTypeName.Length == 0)
            {
                UInt32 nCommand = BitConverter.ToUInt32(bytes, 0);
                if (nCommand == 0x500120A0)
                {
                    sTypeName = "transfer_mode_req";
                }
                else if (nCommand == 0x5001A0A0)
                {
                    sTypeName = "transfer_mode_res";
                }
                else if (nCommand == 0x50010002)
                {
                    sTypeName = "file_write_req";
                }
                else if (nCommand == 0x50018002)
                {
                    sTypeName = "file_write_res";
                }
                else if (nCommand == 0x500120A1)
                {
                    sTypeName = "transfer_valid_req";
                }
                else if (nCommand == 0x5001A0A1)
                {
                    sTypeName = "transfer_valid_res";
                }
                else if (nCommand == 0x500120A2)
                {
                    sTypeName = "transfer_apply_req";
                }
                else if (nCommand == 0x5001A0A2)
                {
                    sTypeName = "transfer_apply_res";
                }

            }

            if (sTypeName.IndexOf("req") != -1)
            {
                addDataToFromSerial(sTypeName + ":\r\n", Color.Red);

                NAB_CMD_HEADER tlv = Deserialize<NAB_CMD_HEADER>(bytes);

                foreach (var field in typeof(NAB_CMD_HEADER).GetFields(BindingFlags.Instance |
                                                                 BindingFlags.NonPublic |
                                                                 BindingFlags.Public))
                {
                    printLine(field.Name, field.GetValue(tlv), Color.Red);

                }
            }
            else if (sTypeName.IndexOf("res") != -1)
            {
                addDataToFromSerial(sTypeName + ":\r\n", Color.Red);

                NAB_CMD_RES_HEADER tlv = Deserialize<NAB_CMD_RES_HEADER>(bytes);

                foreach (var field in typeof(NAB_CMD_RES_HEADER).GetFields(BindingFlags.Instance |
                                                                 BindingFlags.NonPublic |
                                                                 BindingFlags.Public))
                {
                    printLine(field.Name, field.GetValue(tlv), Color.Red);

                }
            }
            else if (sTypeName == "tlv_cmd_header")
            {
                TLV_CMD_HEADER tlv = Deserialize<TLV_CMD_HEADER>(bytes);

                addDataToFromSerial(sTypeName + ":\r\n", Color.Red);
                foreach (var field in typeof(TLV_CMD_HEADER).GetFields(BindingFlags.Instance |
                                                                 BindingFlags.NonPublic |
                                                                 BindingFlags.Public))
                {
                    printLine(field.Name, field.GetValue(tlv), Color.Red);

                }
            }
            else
            {
                addDataToFromSerial("debug_cast2struct typeName unknown \r\n");
            }
        }

        void printLine(object name, object? value, Color clr)
        {
            string sLine;
            if (name.ToString().IndexOf("hex") != -1)
            {
                sLine = string.Format("{0} = {1:X} \r\n", name, value);
            }
            else
            {
                sLine = string.Format("{0} = {1} \r\n", name, value);
            }

            addDataToFromSerial(sLine, Color.Red);
        }




        //https://www.genericgamedev.com/general/converting-between-structs-and-byte-arrays/
        public static T Deserialize<T>(byte[] array)
            where T : struct
        {
            var size = Marshal.SizeOf(typeof(T));
            var ptr = Marshal.AllocHGlobal(size);
            Marshal.Copy(array, 0, ptr, size);
            var s = (T)Marshal.PtrToStructure(ptr, typeof(T));
            Marshal.FreeHGlobal(ptr);
            return s;
        }



        private void timer_ports_Tick(object sender, EventArgs e)
        {
            manageCommPort();
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            tb_Output.Text = "";
            _sDebugHlp = "";
        }

        private void btn_Copy2Clipboard_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(tb_Output.Text);
        }

        enum KbMode
        {
            KbMode_perChar,
            KbMode_perString
        }
        KbMode _KbMode = KbMode.KbMode_perString;
        private string _sKbString;
        private void tb_Input_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (_KbMode == KbMode.KbMode_perChar)
            {
                string sText = e.KeyChar.ToString();
                if (_serialPortMgr.IsOpen() == true)
                {
                    _serialPortMgr.Write(sText);
                }
            }
            else if (_KbMode == KbMode.KbMode_perString)
            {

                _sKbString += e.KeyChar.ToString();
                if (e.KeyChar == '\r')
                {
                    if (_serialPortMgr.IsOpen() == true)
                    {
                        if (tb_Input.Text.Length != 0)
                        {
                            string sTemp = tb_Input.Text;
                            sTemp += '\n';
                            _serialPortMgr.Write(sTemp);

                        }
                        else
                        {
                            _serialPortMgr.Write("\r");
                        }

                    }

                    //tb_Input.SelectionStart = 0;
                    //tb_Input.SelectionLength = 0;

                    //tb_Input.Clear();
                    //tb_Input.Select(0, 0);
                    tb_Input.Text = "";
                }
            }
        }

        private void timer_setFocus_Tick(object sender, EventArgs e)
        {
            if (tb_Input.Focused == false)
            {
                //tb_Input.Focus();
            }

        }

        private void btn_Hit_Click(object sender, EventArgs e)
        {
            if (btn_Hit.Text == "HitOn")
            {
                btn_Hit.Text = "HitOff";
                _IsHitOn = true;


            }
            else
            {
                btn_Hit.Text = "HitOn";
                _IsHitOn = false;
            }
        }


        private void btn_Filter_Click(object sender, EventArgs e)
        {
            if (btn_Filter.Text == "FilterOn")
            {
                btn_Filter.Text = "FilterOff";
                btn_Filter.BackColor = Color.LightGreen;
                _filterMgr.SetEnaible(true);

            }
            else
            {
                btn_Filter.Text = "FilterOn";
                btn_Filter.BackColor = SystemColors.Control;
                _filterMgr.SetEnaible(false);
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _serialPortMgr.Close();
            _configMgr.Dispose();
        }

        private void ts_CommPorts_SelectedIndexChanged(object sender, EventArgs e)
        {
            _configMgr._configDetail.sPortName = ts_CommPorts.Text;
        }
    }
}
