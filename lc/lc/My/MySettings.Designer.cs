using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;
using NET.Internal;

namespace NET.My
{
	// Token: 0x0200000A RID: 10
	[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
	[System.Runtime.CompilerServices.CompilerGenerated]
	[System.CodeDom.Compiler.GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.2.0.0")]
	internal sealed partial class MySettings : ApplicationSettingsBase
	{
		// Token: 0x0600002A RID: 42 RVA: 0x00003820 File Offset: 0x00001A20
		[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		private static void AutoSaveSettings(object sender, System.EventArgs e)
		{
			if (Advisor.ReflectSingleton.SaveMySettingsOnExit)
			{
				MySettingsProperty.Settings.Save();
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x0600002B RID: 43 RVA: 0x00003844 File Offset: 0x00001A44
		public static MySettings Default
		{
			get
			{
				if (!MySettings.addedHandler)
				{
					object obj = MySettings.addedHandlerLockObject;
					ObjectFlowControl.CheckForSyncLockOnValueType(obj);
					lock (obj)
					{
						if (!MySettings.addedHandler)
						{
							Advisor.ReflectSingleton.Shutdown += MySettings.AutoSaveSettings;
							MySettings.addedHandler = true;
						}
					}
				}
				return MySettings.defaultInstance;
			}
		}

		// Token: 0x0400000D RID: 13
		private static MySettings defaultInstance = (MySettings)SettingsBase.Synchronized(new MySettings());

		// Token: 0x0400000E RID: 14
		private static bool addedHandler;

		// Token: 0x0400000F RID: 15
		private static object addedHandlerLockObject = System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(new object());
	}
}
