namespace ClipboardToWebserver
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.cbLocalhostOnly = new System.Windows.Forms.CheckBox();
			this.lblWebPort = new System.Windows.Forms.Label();
			this.linkLabel = new System.Windows.Forms.LinkLabel();
			this.nudWebPort = new System.Windows.Forms.NumericUpDown();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.nudMaxTextLength = new System.Windows.Forms.NumericUpDown();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.linkLabel_websocket = new System.Windows.Forms.LinkLabel();
			((System.ComponentModel.ISupportInitialize)(this.nudWebPort)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudMaxTextLength)).BeginInit();
			this.SuspendLayout();
			// 
			// cbLocalhostOnly
			// 
			this.cbLocalhostOnly.AutoSize = true;
			this.cbLocalhostOnly.Location = new System.Drawing.Point(12, 12);
			this.cbLocalhostOnly.Name = "cbLocalhostOnly";
			this.cbLocalhostOnly.Size = new System.Drawing.Size(179, 17);
			this.cbLocalhostOnly.TabIndex = 0;
			this.cbLocalhostOnly.Text = "Restrict web access to localhost";
			this.cbLocalhostOnly.UseVisualStyleBackColor = true;
			this.cbLocalhostOnly.CheckedChanged += new System.EventHandler(this.cbLocalhostOnly_CheckedChanged);
			// 
			// lblWebPort
			// 
			this.lblWebPort.AutoSize = true;
			this.lblWebPort.Location = new System.Drawing.Point(12, 37);
			this.lblWebPort.Name = "lblWebPort";
			this.lblWebPort.Size = new System.Drawing.Size(55, 13);
			this.lblWebPort.TabIndex = 1;
			this.lblWebPort.Text = "Web Port:";
			// 
			// linkLabel
			// 
			this.linkLabel.AutoSize = true;
			this.linkLabel.Location = new System.Drawing.Point(12, 108);
			this.linkLabel.Name = "linkLabel";
			this.linkLabel.Size = new System.Drawing.Size(16, 13);
			this.linkLabel.TabIndex = 10;
			this.linkLabel.TabStop = true;
			this.linkLabel.Text = "...";
			this.linkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_LinkClicked);
			// 
			// nudWebPort
			// 
			this.nudWebPort.Location = new System.Drawing.Point(73, 35);
			this.nudWebPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
			this.nudWebPort.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.nudWebPort.Name = "nudWebPort";
			this.nudWebPort.Size = new System.Drawing.Size(72, 20);
			this.nudWebPort.TabIndex = 3;
			this.nudWebPort.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.nudWebPort.ValueChanged += new System.EventHandler(this.nudWebPort_ValueChanged);
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// nudMaxTextLength
			// 
			this.nudMaxTextLength.Location = new System.Drawing.Point(108, 61);
			this.nudMaxTextLength.Maximum = new decimal(new int[] {
            2000000,
            0,
            0,
            0});
			this.nudMaxTextLength.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.nudMaxTextLength.Name = "nudMaxTextLength";
			this.nudMaxTextLength.Size = new System.Drawing.Size(97, 20);
			this.nudMaxTextLength.TabIndex = 12;
			this.toolTip1.SetToolTip(this.nudMaxTextLength, "If the clipboard text is longer than this many characters,\r\nit will be truncated " +
        "when being sent out via the web server.");
			this.nudMaxTextLength.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.nudMaxTextLength.ValueChanged += new System.EventHandler(this.nudMaxTextLength_ValueChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 63);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(90, 13);
			this.label1.TabIndex = 11;
			this.label1.Text = "Max Text Length:";
			this.toolTip1.SetToolTip(this.label1, "If the clipboard text is longer than this many characters,\r\nit will be truncated " +
        "when being sent out via the web server.");
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(211, 63);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(33, 13);
			this.label2.TabIndex = 13;
			this.label2.Text = "chars";
			this.toolTip1.SetToolTip(this.label2, "If the clipboard text is longer than this many characters,\r\nit will be truncated " +
        "when being sent out via the web server.");
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 92);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(158, 13);
			this.label3.TabIndex = 14;
			this.label3.Text = "Retrieve clipboard text via URL:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 134);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(244, 13);
			this.label4.TabIndex = 16;
			this.label4.Text = "(Advanced) Stream clipboard text via WebSocket:";
			// 
			// linkLabel_websocket
			// 
			this.linkLabel_websocket.AutoSize = true;
			this.linkLabel_websocket.Location = new System.Drawing.Point(12, 150);
			this.linkLabel_websocket.Name = "linkLabel_websocket";
			this.linkLabel_websocket.Size = new System.Drawing.Size(16, 13);
			this.linkLabel_websocket.TabIndex = 15;
			this.linkLabel_websocket.TabStop = true;
			this.linkLabel_websocket.Text = "...";
			this.linkLabel_websocket.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_websocket_LinkClicked);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(359, 188);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.linkLabel_websocket);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.nudMaxTextLength);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.nudWebPort);
			this.Controls.Add(this.linkLabel);
			this.Controls.Add(this.lblWebPort);
			this.Controls.Add(this.cbLocalhostOnly);
			this.Name = "MainForm";
			this.Text = "Clipboard To Webserver";
			((System.ComponentModel.ISupportInitialize)(this.nudWebPort)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudMaxTextLength)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.CheckBox cbLocalhostOnly;
		private System.Windows.Forms.Label lblWebPort;
		private System.Windows.Forms.LinkLabel linkLabel;
		private System.Windows.Forms.NumericUpDown nudWebPort;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.NumericUpDown nudMaxTextLength;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.LinkLabel linkLabel_websocket;
	}
}

