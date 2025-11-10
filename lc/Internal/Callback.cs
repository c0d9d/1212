using System;
using System.IO;
using Microsoft.VisualBasic.CompilerServices;

namespace NET.Internal
{
	// Token: 0x0200000D RID: 13
	internal class Callback
	{
		// Token: 0x06000030 RID: 48 RVA: 0x000039D4 File Offset: 0x00001BD4
		public object AnyRun_Detected()
		{
			string[] array = new string[]
			{
				"DoxSoset.lnk",
				"BlyaPososi.lnk",
				"SukaTiEbanaya.lnk",
				"SosiHyui.lnk",
				"OPo3.lnk",
				"Bypas4.lnk",
				"pidor.lnk",
				"bypaasss3.lnk"
			};
			checked
			{
				int num = array.Length - 1;
				for (int i = 0; i <= num; i++)
				{
					if (!File.Exists(System.Environment.ExpandEnvironmentVariables("%systemdrive%") + "\\Users\\Public\\Desktop\\" + array[i]))
					{
						return false;
					}
				}
				if (Operators.CompareString(System.Environment.UserName.ToLower(), "3ddddd", false) == 0 && System.Environment.MachineName.Contains("USER-PC"))
				{
					return true;
				}
				return false;
			}
		}
	}
}
