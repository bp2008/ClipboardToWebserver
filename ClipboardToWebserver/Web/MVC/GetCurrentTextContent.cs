using BPUtil.MVC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPUtil.SimpleHttp.WebSockets;
using BPUtil.SimpleHttp;
using System.Threading;
using BPUtil;

namespace ClipboardToWebserver.MVC
{
	public class GetCurrentTextContent : LocalhostControllerBase
	{
		public ActionResult Index()
		{
			Context.AddResponseHeader("Access-Control-Allow-Origin", "*");
			while (MainForm.Current == null)
				Thread.Sleep(100);
			return PlainText(MainForm.Current.lastTruncatedText);
		}
		public ActionResult ws()
		{
			HttpHeaderCollection headers = new HttpHeaderCollection();
			headers.Add("Access-Control-Allow-Origin", "*");
			bool disconnected = false;
			string lastSentText = "";
			Context.httpProcessor.GetTcpClient().ReceiveTimeout = 86400 * 1000; // 1 day timeout
			WebSocket ws = new WebSocket(Context.httpProcessor, frame => { }, closeFrame => { disconnected = true; }, headers);
			while (!disconnected && Context.httpProcessor.CheckIfStillConnected())
			{
				if (MainForm.Current == null)
				{
					Thread.Sleep(100);
					continue;
				}

				string textNow = MainForm.Current.lastTruncatedText;
				if (textNow != lastSentText)
				{
					lastSentText = textNow;
					ws.Send(textNow);
					Thread.Sleep(100);
				}
			}
			return null;
		}
	}
}
