using BPUtil;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClipboardToWebserver
{
	public class Settings : BPUtil.SerializableObjectJson
	{
		public int webServerPort = 21496;
		public bool localhostOnly = true;
		public int maxTextLength = 65535;

		protected override SerializableObjectJson DeserializeFromJson(string str)
		{
			return JsonConvert.DeserializeObject<Settings>(str);
		}

		protected override string SerializeToJson(object obj)
		{
			return JsonConvert.SerializeObject(obj);
		}
	}
}
