using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace NET.Internal
{
	// Token: 0x0200000E RID: 14
	[DesignerGenerated]
	internal partial class Prototype : Form
	{
		// Token: 0x06000031 RID: 49 RVA: 0x00003A94 File Offset: 0x00001C94
		public Prototype()
		{
			base.FormClosing += this.IncludeSingleton;
			this.ListSingleton();
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00003B00 File Offset: 0x00001D00
		private void ListSingleton()
		{
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Prototype));
			this.g1 = new Label();
			base.SuspendLayout();
			this.g1.Dock = DockStyle.Fill;
			this.g1.Font = new Font("Lucida Console", 48f, FontStyle.Regular, GraphicsUnit.Point, 204);
			this.g1.ForeColor = Color.White;
			this.g1.Location = new Point(0, 0);
			this.g1.Name = "g1";
			this.g1.Size = new Size(874, 408);
			this.g1.TabIndex = 1;
			this.g1.Text = ":(";
			this.g1.TextAlign = ContentAlignment.MiddleCenter;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.Black;
			base.ClientSize = new Size(874, 408);
			base.Controls.Add(this.g1);
			base.FormBorderStyle = FormBorderStyle.None;
			base.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "empty";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = FormStartPosition.CenterScreen;
			base.TopMost = true;
			base.WindowState = FormWindowState.Maximized;
			base.ResumeLayout(false);
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000034 RID: 52 RVA: 0x00002323 File Offset: 0x00000523
		// (set) Token: 0x06000035 RID: 53 RVA: 0x00003C84 File Offset: 0x00001E84
		internal virtual Label g1 { get; set; }

		// Token: 0x06000036 RID: 54 RVA: 0x00003C98 File Offset: 0x00001E98
		private void IncludeSingleton(object sender, FormClosingEventArgs e)
		{
			e.Cancel = true;
		}

		// Token: 0x04000011 RID: 17
		[System.Runtime.CompilerServices.CompilerGenerated]
		[System.Runtime.CompilerServices.AccessedThroughProperty("g1")]
		private Label test;
	}
}
