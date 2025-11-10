namespace NET.Internal
{
	// Token: 0x0200000E RID: 14
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	internal partial class Prototype : global::System.Windows.Forms.Form
	{
		// Token: 0x06000032 RID: 50 RVA: 0x00003AC0 File Offset: 0x00001CC0
		protected override void Dispose(bool isreference)
		{
			try
			{
				if (isreference && this.m_Authentication != null)
				{
					this.m_Authentication.Dispose();
				}
			}
			finally
			{
				base.Dispose(isreference);
			}
		}

		// Token: 0x04000010 RID: 16
		private global::System.IDisposable m_Authentication;
	}
}
