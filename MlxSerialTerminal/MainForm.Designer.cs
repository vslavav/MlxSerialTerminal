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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ts_Top = new System.Windows.Forms.ToolStrip();
            this.ts_CommPorts = new System.Windows.Forms.ToolStripComboBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.tb_Output = new System.Windows.Forms.RichTextBox();
            this.btn_Filter = new System.Windows.Forms.Button();
            this.btn_OpenClosePort = new System.Windows.Forms.Button();
            this.btn_Copy2Clipboard = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_StopStart = new System.Windows.Forms.Button();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.tb_Input = new System.Windows.Forms.TextBox();
            this.btn_Hit = new System.Windows.Forms.Button();
            this.timer2SerialRead = new System.Windows.Forms.Timer(this.components);
            this.timer_ports = new System.Windows.Forms.Timer(this.components);
            this.timer_setFocus = new System.Windows.Forms.Timer(this.components);
            this.ts_Top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.SuspendLayout();
            // 
            // ts_Top
            // 
            this.ts_Top.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ts_CommPorts});
            this.ts_Top.Location = new System.Drawing.Point(0, 0);
            this.ts_Top.Name = "ts_Top";
            this.ts_Top.Size = new System.Drawing.Size(1152, 25);
            this.ts_Top.TabIndex = 0;
            this.ts_Top.Text = "toolStrip1";
            // 
            // ts_CommPorts
            // 
            this.ts_CommPorts.Name = "ts_CommPorts";
            this.ts_CommPorts.Size = new System.Drawing.Size(121, 25);
            this.ts_CommPorts.SelectedIndexChanged += new System.EventHandler(this.ts_CommPorts_SelectedIndexChanged);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 25);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer1.Size = new System.Drawing.Size(1152, 525);
            this.splitContainer1.SplitterDistance = 474;
            this.splitContainer1.SplitterWidth = 2;
            this.splitContainer1.TabIndex = 1;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.tb_Output);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.btn_Filter);
            this.splitContainer2.Panel2.Controls.Add(this.btn_OpenClosePort);
            this.splitContainer2.Panel2.Controls.Add(this.btn_Copy2Clipboard);
            this.splitContainer2.Panel2.Controls.Add(this.btn_Clear);
            this.splitContainer2.Panel2.Controls.Add(this.btn_StopStart);
            this.splitContainer2.Size = new System.Drawing.Size(1152, 474);
            this.splitContainer2.SplitterDistance = 1051;
            this.splitContainer2.TabIndex = 0;
            // 
            // tb_Output
            // 
            this.tb_Output.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Output.HideSelection = false;
            this.tb_Output.Location = new System.Drawing.Point(3, 3);
            this.tb_Output.Name = "tb_Output";
            this.tb_Output.Size = new System.Drawing.Size(1048, 467);
            this.tb_Output.TabIndex = 0;
            this.tb_Output.Text = "";
            // 
            // btn_Filter
            // 
            this.btn_Filter.Location = new System.Drawing.Point(7, 137);
            this.btn_Filter.Name = "btn_Filter";
            this.btn_Filter.Size = new System.Drawing.Size(75, 23);
            this.btn_Filter.TabIndex = 4;
            this.btn_Filter.Text = "FilterOn";
            this.btn_Filter.UseVisualStyleBackColor = true;
            this.btn_Filter.Click += new System.EventHandler(this.btn_Filter_Click);
            // 
            // btn_OpenClosePort
            // 
            this.btn_OpenClosePort.Location = new System.Drawing.Point(7, 108);
            this.btn_OpenClosePort.Name = "btn_OpenClosePort";
            this.btn_OpenClosePort.Size = new System.Drawing.Size(75, 23);
            this.btn_OpenClosePort.TabIndex = 3;
            this.btn_OpenClosePort.Text = "Close Port";
            this.btn_OpenClosePort.UseVisualStyleBackColor = true;
            this.btn_OpenClosePort.Click += new System.EventHandler(this.btn_OpenClosePort_Click);
            // 
            // btn_Copy2Clipboard
            // 
            this.btn_Copy2Clipboard.Location = new System.Drawing.Point(7, 79);
            this.btn_Copy2Clipboard.Name = "btn_Copy2Clipboard";
            this.btn_Copy2Clipboard.Size = new System.Drawing.Size(75, 23);
            this.btn_Copy2Clipboard.TabIndex = 2;
            this.btn_Copy2Clipboard.Text = "Copy2Clip";
            this.btn_Copy2Clipboard.UseVisualStyleBackColor = true;
            this.btn_Copy2Clipboard.Click += new System.EventHandler(this.btn_Copy2Clipboard_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(7, 50);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(75, 23);
            this.btn_Clear.TabIndex = 1;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_StopStart
            // 
            this.btn_StopStart.Location = new System.Drawing.Point(7, 21);
            this.btn_StopStart.Name = "btn_StopStart";
            this.btn_StopStart.Size = new System.Drawing.Size(75, 23);
            this.btn_StopStart.TabIndex = 0;
            this.btn_StopStart.Text = "Stop";
            this.btn_StopStart.UseVisualStyleBackColor = true;
            this.btn_StopStart.Click += new System.EventHandler(this.btn_StopStart_Click);
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.tb_Input);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.btn_Hit);
            this.splitContainer3.Size = new System.Drawing.Size(1152, 49);
            this.splitContainer3.SplitterDistance = 1051;
            this.splitContainer3.TabIndex = 0;
            // 
            // tb_Input
            // 
            this.tb_Input.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Input.Location = new System.Drawing.Point(3, 23);
            this.tb_Input.Name = "tb_Input";
            this.tb_Input.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_Input.Size = new System.Drawing.Size(1048, 23);
            this.tb_Input.TabIndex = 0;
            this.tb_Input.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Input_KeyPress);
            // 
            // btn_Hit
            // 
            this.btn_Hit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Hit.Location = new System.Drawing.Point(7, 22);
            this.btn_Hit.Name = "btn_Hit";
            this.btn_Hit.Size = new System.Drawing.Size(75, 23);
            this.btn_Hit.TabIndex = 0;
            this.btn_Hit.Text = "HitOn";
            this.btn_Hit.UseVisualStyleBackColor = true;
            this.btn_Hit.Click += new System.EventHandler(this.btn_Hit_Click);
            // 
            // timer2SerialRead
            // 
            this.timer2SerialRead.Tick += new System.EventHandler(this.timer2SerialRead_Tick);
            // 
            // timer_ports
            // 
            this.timer_ports.Interval = 5000;
            this.timer_ports.Tick += new System.EventHandler(this.timer_ports_Tick);
            // 
            // timer_setFocus
            // 
            this.timer_setFocus.Enabled = true;
            this.timer_setFocus.Tick += new System.EventHandler(this.timer_setFocus_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 550);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.ts_Top);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "MlxSerialTerminal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.ts_Top.ResumeLayout(false);
            this.ts_Top.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}
