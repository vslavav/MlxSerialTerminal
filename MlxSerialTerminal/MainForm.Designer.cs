namespace MlxSerialTerminal
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            ts_Top = new System.Windows.Forms.ToolStrip();
            ts_CommPorts = new System.Windows.Forms.ToolStripComboBox();
            splitContainer1 = new System.Windows.Forms.SplitContainer();
            splitContainer2 = new System.Windows.Forms.SplitContainer();
            tb_Output = new System.Windows.Forms.RichTextBox();
            label1 = new System.Windows.Forms.Label();
            tb_lines = new System.Windows.Forms.TextBox();
            btn_Filter = new System.Windows.Forms.Button();
            btn_OpenClosePort = new System.Windows.Forms.Button();
            btn_Copy2Clipboard = new System.Windows.Forms.Button();
            btn_Clear = new System.Windows.Forms.Button();
            btn_StopStart = new System.Windows.Forms.Button();
            splitContainer3 = new System.Windows.Forms.SplitContainer();
            tb_Input = new System.Windows.Forms.TextBox();
            btn_Hit = new System.Windows.Forms.Button();
            timer2SerialRead = new System.Windows.Forms.Timer(components);
            timer_ports = new System.Windows.Forms.Timer(components);
            timer_setFocus = new System.Windows.Forms.Timer(components);
            ts_Top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer3).BeginInit();
            splitContainer3.Panel1.SuspendLayout();
            splitContainer3.Panel2.SuspendLayout();
            splitContainer3.SuspendLayout();
            SuspendLayout();
            // 
            // ts_Top
            // 
            ts_Top.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { ts_CommPorts });
            ts_Top.Location = new System.Drawing.Point(0, 0);
            ts_Top.Name = "ts_Top";
            ts_Top.Size = new System.Drawing.Size(1152, 25);
            ts_Top.TabIndex = 0;
            ts_Top.Text = "toolStrip1";
            // 
            // ts_CommPorts
            // 
            ts_CommPorts.Name = "ts_CommPorts";
            ts_CommPorts.Size = new System.Drawing.Size(121, 25);
            ts_CommPorts.DropDown += ts_CommPorts_DropDown;
            ts_CommPorts.SelectedIndexChanged += ts_CommPorts_SelectedIndexChanged;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            splitContainer1.Location = new System.Drawing.Point(0, 25);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(splitContainer3);
            splitContainer1.Size = new System.Drawing.Size(1152, 525);
            splitContainer1.SplitterDistance = 474;
            splitContainer1.SplitterWidth = 2;
            splitContainer1.TabIndex = 1;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            splitContainer2.Location = new System.Drawing.Point(0, 0);
            splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(tb_Output);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(label1);
            splitContainer2.Panel2.Controls.Add(tb_lines);
            splitContainer2.Panel2.Controls.Add(btn_Filter);
            splitContainer2.Panel2.Controls.Add(btn_OpenClosePort);
            splitContainer2.Panel2.Controls.Add(btn_Copy2Clipboard);
            splitContainer2.Panel2.Controls.Add(btn_Clear);
            splitContainer2.Panel2.Controls.Add(btn_StopStart);
            splitContainer2.Size = new System.Drawing.Size(1152, 474);
            splitContainer2.SplitterDistance = 1051;
            splitContainer2.TabIndex = 0;
            // 
            // tb_Output
            // 
            tb_Output.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tb_Output.HideSelection = false;
            tb_Output.Location = new System.Drawing.Point(3, 3);
            tb_Output.Name = "tb_Output";
            tb_Output.Size = new System.Drawing.Size(1048, 467);
            tb_Output.TabIndex = 0;
            tb_Output.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(10, 426);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(34, 15);
            label1.TabIndex = 6;
            label1.Text = "lines:";
            // 
            // tb_lines
            // 
            tb_lines.Location = new System.Drawing.Point(7, 445);
            tb_lines.Name = "tb_lines";
            tb_lines.Size = new System.Drawing.Size(78, 23);
            tb_lines.TabIndex = 5;
            // 
            // btn_Filter
            // 
            btn_Filter.Location = new System.Drawing.Point(7, 137);
            btn_Filter.Name = "btn_Filter";
            btn_Filter.Size = new System.Drawing.Size(75, 23);
            btn_Filter.TabIndex = 4;
            btn_Filter.Text = "FilterOn";
            btn_Filter.UseVisualStyleBackColor = true;
            btn_Filter.Click += btn_Filter_Click;
            // 
            // btn_OpenClosePort
            // 
            btn_OpenClosePort.Location = new System.Drawing.Point(7, 108);
            btn_OpenClosePort.Name = "btn_OpenClosePort";
            btn_OpenClosePort.Size = new System.Drawing.Size(75, 23);
            btn_OpenClosePort.TabIndex = 3;
            btn_OpenClosePort.Text = "Close Port";
            btn_OpenClosePort.UseVisualStyleBackColor = true;
            btn_OpenClosePort.Click += btn_OpenClosePort_Click;
            // 
            // btn_Copy2Clipboard
            // 
            btn_Copy2Clipboard.Location = new System.Drawing.Point(7, 79);
            btn_Copy2Clipboard.Name = "btn_Copy2Clipboard";
            btn_Copy2Clipboard.Size = new System.Drawing.Size(75, 23);
            btn_Copy2Clipboard.TabIndex = 2;
            btn_Copy2Clipboard.Text = "Copy2Clip";
            btn_Copy2Clipboard.UseVisualStyleBackColor = true;
            btn_Copy2Clipboard.Click += btn_Copy2Clipboard_Click;
            // 
            // btn_Clear
            // 
            btn_Clear.Location = new System.Drawing.Point(7, 50);
            btn_Clear.Name = "btn_Clear";
            btn_Clear.Size = new System.Drawing.Size(75, 23);
            btn_Clear.TabIndex = 1;
            btn_Clear.Text = "Clear";
            btn_Clear.UseVisualStyleBackColor = true;
            btn_Clear.Click += btn_Clear_Click;
            // 
            // btn_StopStart
            // 
            btn_StopStart.Location = new System.Drawing.Point(7, 21);
            btn_StopStart.Name = "btn_StopStart";
            btn_StopStart.Size = new System.Drawing.Size(75, 23);
            btn_StopStart.TabIndex = 0;
            btn_StopStart.Text = "Stop";
            btn_StopStart.UseVisualStyleBackColor = true;
            btn_StopStart.Click += btn_StopStart_Click;
            // 
            // splitContainer3
            // 
            splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            splitContainer3.Location = new System.Drawing.Point(0, 0);
            splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            splitContainer3.Panel1.Controls.Add(tb_Input);
            // 
            // splitContainer3.Panel2
            // 
            splitContainer3.Panel2.Controls.Add(btn_Hit);
            splitContainer3.Size = new System.Drawing.Size(1152, 49);
            splitContainer3.SplitterDistance = 1051;
            splitContainer3.TabIndex = 0;
            // 
            // tb_Input
            // 
            tb_Input.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tb_Input.Location = new System.Drawing.Point(3, 23);
            tb_Input.Name = "tb_Input";
            tb_Input.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            tb_Input.Size = new System.Drawing.Size(1048, 23);
            tb_Input.TabIndex = 0;
            tb_Input.KeyPress += tb_Input_KeyPress;
            // 
            // btn_Hit
            // 
            btn_Hit.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            btn_Hit.Location = new System.Drawing.Point(7, 22);
            btn_Hit.Name = "btn_Hit";
            btn_Hit.Size = new System.Drawing.Size(75, 23);
            btn_Hit.TabIndex = 0;
            btn_Hit.Text = "HitOn";
            btn_Hit.UseVisualStyleBackColor = true;
            btn_Hit.Click += btn_Hit_Click;
            // 
            // timer2SerialRead
            // 
            timer2SerialRead.Tick += timer2SerialRead_Tick;
            // 
            // timer_ports
            // 
            timer_ports.Interval = 5000;
            timer_ports.Tick += timer_ports_Tick;
            // 
            // timer_setFocus
            // 
            timer_setFocus.Enabled = true;
            timer_setFocus.Tick += timer_setFocus_Tick;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1152, 550);
            Controls.Add(splitContainer1);
            Controls.Add(ts_Top);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            Text = "MlxSerialTerminal";
            FormClosing += MainForm_FormClosing;
            ts_Top.ResumeLayout(false);
            ts_Top.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            splitContainer3.Panel1.ResumeLayout(false);
            splitContainer3.Panel1.PerformLayout();
            splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer3).EndInit();
            splitContainer3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ToolStrip ts_Top;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TextBox tb_Input;
        private System.Windows.Forms.Button btn_OpenClosePort;
        private System.Windows.Forms.Button btn_Copy2Clipboard;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_StopStart;
        private System.Windows.Forms.Timer timer2SerialRead;
        private System.Windows.Forms.Timer timer_ports;
        private System.Windows.Forms.ToolStripComboBox ts_CommPorts;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.Timer timer_setFocus;
        private System.Windows.Forms.Button btn_Filter;
        private System.Windows.Forms.Button btn_Hit;
        private System.Windows.Forms.RichTextBox tb_Output;
        private System.Windows.Forms.TextBox tb_lines;
        private System.Windows.Forms.Label label1;
    }
}
