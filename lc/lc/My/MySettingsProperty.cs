using System;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace NET.My
{
	// Token: 0x0200000B RID: 11
	[System.Runtime.CompilerServices.CompilerGenerated]
	[StandardModule]
	[HideModuleName]
	[System.Diagnostics.DebuggerNonUserCode]
	internal sealed class MySettingsProperty
	{
		// Token: 0x1700000C RID: 12
		// (get) Token: 0x0600002C RID: 44 RVA: 0x0000231C File Offset: 0x0000051C
		[HelpKeyword("My.Settings")]
		internal static MySettings Settings
		{
			get
			{
				return MySettings.Default;
			}
		}
	}
}
