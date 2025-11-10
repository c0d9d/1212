namespace NET.Internal
{
	// Token: 0x02000011 RID: 17
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	internal partial class Worker : global::System.Windows.Forms.Form
	{
		// Token: 0x06000057 RID: 87 RVA: 0x000057F0 File Offset: 0x000039F0
		protected override void Dispose(bool injectspec)
		{
			try
			{
				if (injectspec && this.list != null)
				{
					((global::System.IDisposable)this.list).Dispose();
				}
			}
			finally
			{
				base.Dispose(injectspec);
			}
		}

		// Token: 0x0400001F RID: 31
		private global::System.ComponentModel.Container list;
	}
}
