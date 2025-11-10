using System;
using System.Runtime.InteropServices;

namespace NET.Internal
{
	// Token: 0x02000010 RID: 16
	internal sealed class Proxy
	{
		// Token: 0x06000041 RID: 65
		[System.Runtime.InteropServices.DllImport("kernel32.dll")]
		private static extern System.IntPtr GetModuleHandle(string asset);

		// Token: 0x06000042 RID: 66 RVA: 0x00004728 File Offset: 0x00002928
		public object SandBox_Detected()
		{
			string[] array = new string[]
			{
				"Pa3Hoc.dll",
				"Test.dll",
				"Standi3ot.dll",
				"PoshelNaxyuDox.dll",
				"DoxSossetXyu.dll"
			};
			checked
			{
				int num = array.Length - 1;
				for (int i = 0; i <= num; i++)
				{
					if (Proxy.GetModuleHandle(array[i]).ToInt32() != 0)
					{
						return true;
					}
				}
				return false;
			}
		}
	}
}
