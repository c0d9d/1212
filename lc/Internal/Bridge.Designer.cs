namespace NET.Internal
{
	// Token: 0x0200000F RID: 15
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	internal partial class Bridge : global::System.Windows.Forms.Form
	{
		// Token: 0x06000038 RID: 56 RVA: 0x00003ECC File Offset: 0x000020CC
		protected override void Dispose(bool rejectitem)
		{
			try
			{
				if (rejectitem && this.predicate != null)
				{
					this.predicate.Dispose();
				}
			}
			finally
			{
				base.Dispose(rejectitem);
			}
		}

		// Token: 0x04000012 RID: 18
		private global::System.IDisposable predicate;
	}
}
