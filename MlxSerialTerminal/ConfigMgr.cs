using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace MlxSerialTerminal
{
    internal class ConfigMgr : IDisposable
    {
        public class ConfigDetail
        {
            public ConfigDetail()
            {
                sPortName = "";
            }
            public string sPortName { get; set; }
           
        }

        public ConfigDetail _configDetail = new ConfigDetail();



        public ConfigMgr()
        {
            _configDetail.sPortName = "COM4";
            getFromFile();
        }

        ~ConfigMgr()
        {
           
        }


        public void Dispose()
        {
            saveToFile();
        }


        private void saveToFile()
        {
            string jsonString = JsonConvert.SerializeObject(_configDetail);
            File.WriteAllText("MicroPtnHlp.json", jsonString);
        }

        private void getFromFile()
        {
            try
            {
                if (File.Exists("MicroPtnHlp.json"))
                {
                    var jsonString = File.ReadAllText("MicroPtnHlp.json");
                    _configDetail = JsonConvert.DeserializeObject<ConfigDetail>(jsonString);
                }


            }
            catch (System.IO.FileLoadException ex)
            {

            }

            finally { }
        }


    }
}

