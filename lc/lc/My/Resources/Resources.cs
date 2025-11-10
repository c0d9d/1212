using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace NET.My.Resources
{
	// Token: 0x02000009 RID: 9
	[System.Runtime.CompilerServices.CompilerGenerated]
	[HideModuleName]
	[StandardModule]
	[System.CodeDom.Compiler.GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
	[System.Diagnostics.DebuggerNonUserCode]
	internal sealed class Resources
	{
		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000025 RID: 37 RVA: 0x000037AC File Offset: 0x000019AC
		[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		internal static System.Resources.ResourceManager ResourceManager
		{
			get
			{
				if (object.ReferenceEquals(Resources._Writer, null))
				{
					Resources._Writer = new System.Resources.ResourceManager("NET.Resources", typeof(Resources).Assembly);
				}
				return Resources._Writer;
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000026 RID: 38 RVA: 0x00002305 File Offset: 0x00000505
		// (set) Token: 0x06000027 RID: 39 RVA: 0x0000230C File Offset: 0x0000050C
		[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		internal static System.Globalization.CultureInfo Culture
		{
			get
			{
				return Resources._Service;
			}
			set
			{
				Resources._Service = value;
			}
		}

		// Token: 0x0400000B RID: 11
		private static System.Resources.ResourceManager _Writer;

		// Token: 0x0400000C RID: 12
		private static System.Globalization.CultureInfo _Service;
	}
}
