using BPUtil;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClipboardToWebserver
{
	public partial class MainForm : Form
	{
		string lastText = "";
		public string lastTruncatedText { get; private set; } = "";
		int lastPort = 0;
		int msBetweenLookups = 200;
		Stopwatch stopwatch = Stopwatch.StartNew();

		/// <summary>
		/// A static reference to the current MainForm instance.
		/// </summary>
		public static MainForm Current = null;

		public MainForm()
		{
			Current = this;

			InitializeComponent();
			this.Text = this.Text + " " + Assembly.GetExecutingAssembly().GetName().Version.ToString();

			cbLocalhostOnly.Checked = Program.settings.localhostOnly;
			nudWebPort.Value = Program.settings.webServerPort;
			nudMaxTextLength.Value = Program.settings.maxTextLength;
		}

		private void cbLocalhostOnly_CheckedChanged(object sender, EventArgs e)
		{
			if (Program.settings.localhostOnly != cbLocalhostOnly.Checked)
			{
				Program.settings.localhostOnly = cbLocalhostOnly.Checked;
				Program.settings.Save();
			}
		}

		private void nudWebPort_ValueChanged(object sender, EventArgs e)
		{
			if (Program.settings.webServerPort != (int)nudWebPort.Value)
			{
				Program.settings.webServerPort = (int)nudWebPort.Value;
				Program.settings.Save();

				linkLabel.Text = "Web server is starting...";
				linkLabel_websocket.Text = "Web server is starting...";
				lastPort = 0;
				Program.webServer.SetBindings(Program.settings.webServerPort, Program.settings.webServerPort);
			}
		}

		private void nudMaxTextLength_ValueChanged(object sender, EventArgs e)
		{
			if (Program.settings.maxTextLength != (int)nudMaxTextLength.Value)
			{
				Program.settings.maxTextLength = (int)nudMaxTextLength.Value;
				Program.settings.Save();
				lastText = "";
			}
		}

		private void linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			if (linkLabel.Text.StartsWith("http"))
				Process.Start(linkLabel.Text);
		}

		private void linkLabel_websocket_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			if (linkLabel_websocket.Text.StartsWith("ws"))
				Process.Start(linkLabel_websocket.Text);
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			try
			{
				long remainingMs = msBetweenLookups - stopwatch.ElapsedMilliseconds;
				if (remainingMs < 20)
				{
					stopwatch.Restart();

					BPUtil.SimpleHttp.HttpServerBase.Binding[] bindings = Program.webServer.GetBindings();
					if (bindings.Length > 0 && bindings[0].Endpoint.Port != 0 && bindings[0].Endpoint.Port != lastPort)
					{
						lastPort = bindings[0].Endpoint.Port;
						linkLabel.Text = "http://localhost:" + lastPort + "/GetCurrentTextContent";
						linkLabel_websocket.Text = "ws://localhost:" + lastPort + "/GetCurrentTextContent/ws";
					}

					if (Clipboard.ContainsText())
					{
						string text = Clipboard.GetText();
						if (text != lastText)
						{
							lastText = text;

							if (Program.settings.maxTextLength < text.Length)
								lastTruncatedText = text.Substring(0, Program.settings.maxTextLength);
							else
								lastTruncatedText = text;

							if (text.Length > 500000)
								msBetweenLookups = 4000;
							else if (text.Length > 100000)
								msBetweenLookups = 2000;
							else if (text.Length > 32000)
								msBetweenLookups = 1000;
							else
								msBetweenLookups = 200;
						}
					}
					else
						msBetweenLookups = 1000;
				}
			}
			catch (Exception ex)
			{
				Logger.Debug(ex);
			}
		}
	}
}
