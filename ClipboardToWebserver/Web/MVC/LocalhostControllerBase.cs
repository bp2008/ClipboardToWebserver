using BPUtil.MVC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClipboardToWebserver.MVC
{
	public class LocalhostControllerBase : Controller
	{
		public override ActionResult OnAuthorization()
		{
			return !Program.settings.localhostOnly || Context.httpProcessor.IsLocalConnection ? null : StatusCode("403 localhost only");
		}
	}
}
