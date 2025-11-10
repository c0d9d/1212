using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;

namespace NET.Internal
{
	// Token: 0x02000003 RID: 3
	[System.CodeDom.Compiler.GeneratedCode("MyTemplate", "11.0.0.0")]
	[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
	internal class Singleton : WindowsFormsApplicationBase
	{
		// Token: 0x06000005 RID: 5 RVA: 0x000034C8 File Offset: 0x000016C8
		[System.STAThread]
		[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		internal static void PublishSingleton(string[] args)
		{
			Application.SetCompatibleTextRenderingDefault(WindowsFormsApplicationBase.UseCompatibleTextRendering);
			Advisor.ReflectSingleton.Run(args);
		}

		// Token: 0x06000006 RID: 6 RVA: 0x000034EC File Offset: 0x000016EC
		public Singleton() : base(AuthenticationMode.Windows)
		{
			base.IsSingleInstance = true;
			base.EnableVisualStyles = false;
			base.SaveMySettingsOnExit = false;
			base.ShutdownStyle = ShutdownMode.AfterMainFormCloses;
		}

		// Token: 0x06000007 RID: 7 RVA: 0x0000351C File Offset: 0x0000171C
		protected override void OnCreateMainForm()
		{
			base.MainForm = Advisor.MapSingleton.loader;
		}
	}
}
