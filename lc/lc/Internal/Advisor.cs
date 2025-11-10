using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;

namespace NET.Internal
{
	// Token: 0x02000005 RID: 5
	[StandardModule]
	[HideModuleName]
	[System.CodeDom.Compiler.GeneratedCode("MyTemplate", "11.0.0.0")]
	internal sealed class Advisor
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x0600000A RID: 10 RVA: 0x00002250 File Offset: 0x00000450
		[HelpKeyword("My.Computer")]
		internal static Utils SetSingleton
		{
			get
			{
				return Advisor.@ref.RemoveSingleton();
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600000B RID: 11 RVA: 0x0000225C File Offset: 0x0000045C
		[HelpKeyword("My.Application")]
		internal static Singleton ReflectSingleton
		{
			get
			{
				return Advisor._Parameter.RemoveSingleton();
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600000C RID: 12 RVA: 0x00002268 File Offset: 0x00000468
		[HelpKeyword("My.User")]
		internal static User CloneSingleton
		{
			get
			{
				return Advisor.m_Database.RemoveSingleton();
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600000D RID: 13 RVA: 0x00002274 File Offset: 0x00000474
		[HelpKeyword("My.Forms")]
		internal static Advisor.Visitor MapSingleton
		{
			get
			{
				return Advisor._Publisher.RemoveSingleton();
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600000E RID: 14 RVA: 0x00002280 File Offset: 0x00000480
		[HelpKeyword("My.WebServices")]
		internal static Advisor.Resolver ChangeSingleton
		{
			get
			{
				return Advisor.m_Params.RemoveSingleton();
			}
		}

		// Token: 0x04000001 RID: 1
		private static readonly Advisor.Adapter<Utils> @ref = new Advisor.Adapter<Utils>();

		// Token: 0x04000002 RID: 2
		private static readonly Advisor.Adapter<Singleton> _Parameter = new Advisor.Adapter<Singleton>();

		// Token: 0x04000003 RID: 3
		private static readonly Advisor.Adapter<User> m_Database = new Advisor.Adapter<User>();

		// Token: 0x04000004 RID: 4
		private static Advisor.Adapter<Advisor.Visitor> _Publisher = new Advisor.Adapter<Advisor.Visitor>();

		// Token: 0x04000005 RID: 5
		private static readonly Advisor.Adapter<Advisor.Resolver> m_Params = new Advisor.Adapter<Advisor.Resolver>();

		// Token: 0x02000006 RID: 6
		[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
		[MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
		internal sealed class Visitor
		{
			// Token: 0x0600000F RID: 15 RVA: 0x0000357C File Offset: 0x0000177C
			private static T FillSingleton<T>(T param) where T : Form, new()
			{
				T result;
				if (param != null && !param.IsDisposed)
				{
					result = param;
				}
				else
				{
					if (Advisor.Visitor.m_Invocation != null)
					{
						if (Advisor.Visitor.m_Invocation.ContainsKey(typeof(T)))
						{
							throw new System.InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate", new string[0]));
						}
					}
					else
					{
						Advisor.Visitor.m_Invocation = new System.Collections.Hashtable();
					}
					Advisor.Visitor.m_Invocation.Add(typeof(T), null);
					try
					{
						result = System.Activator.CreateInstance<T>();
					}
					catch (System.Reflection.TargetInvocationException ex) when (ex.InnerException != null)
					{
						throw new System.InvalidOperationException(Utils.GetResourceString("WinForms_SeeInnerException", new string[]
						{
							ex.InnerException.Message
						}), ex.InnerException);
					}
					finally
					{
						Advisor.Visitor.m_Invocation.Remove(typeof(T));
					}
				}
				return result;
			}

			// Token: 0x06000010 RID: 16 RVA: 0x0000228C File Offset: 0x0000048C
			private void QuerySingleton<T>(ref T config) where T : Form
			{
				config.Dispose();
				config = default(T);
			}

			// Token: 0x06000011 RID: 17 RVA: 0x000022A1 File Offset: 0x000004A1
			[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
			public Visitor()
			{
			}

			// Token: 0x06000012 RID: 18 RVA: 0x000022A9 File Offset: 0x000004A9
			[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
			public override bool Equals(object instance)
			{
				return base.Equals(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(instance));
			}

			// Token: 0x06000013 RID: 19 RVA: 0x000022B7 File Offset: 0x000004B7
			[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
			public override int GetHashCode()
			{
				return base.GetHashCode();
			}

			// Token: 0x06000014 RID: 20 RVA: 0x000022BF File Offset: 0x000004BF
			[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
			internal System.Type StopSingleton()
			{
				return typeof(Advisor.Visitor);
			}

			// Token: 0x06000015 RID: 21 RVA: 0x000022CB File Offset: 0x000004CB
			[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
			public override string ToString()
			{
				return base.ToString();
			}

			// Token: 0x17000006 RID: 6
			// (get) Token: 0x06000016 RID: 22 RVA: 0x00003684 File Offset: 0x00001884
			// (set) Token: 0x06000019 RID: 25 RVA: 0x000036F0 File Offset: 0x000018F0
			public Worker _o_program
			{
				get
				{
					this._Dispatcher = Advisor.Visitor.FillSingleton<Worker>(this._Dispatcher);
					return this._Dispatcher;
				}
				set
				{
					if (value != this._Dispatcher)
					{
						if (value != null)
						{
							throw new System.ArgumentException("Property can only be set to Nothing");
						}
						this.QuerySingleton<Worker>(ref this._Dispatcher);
					}
				}
			}

			// Token: 0x17000007 RID: 7
			// (get) Token: 0x06000017 RID: 23 RVA: 0x000036A8 File Offset: 0x000018A8
			// (set) Token: 0x0600001A RID: 26 RVA: 0x00003724 File Offset: 0x00001924
			public Prototype empty
			{
				get
				{
					this.m_Importer = Advisor.Visitor.FillSingleton<Prototype>(this.m_Importer);
					return this.m_Importer;
				}
				set
				{
					if (value != this.m_Importer)
					{
						if (value != null)
						{
							throw new System.ArgumentException("Property can only be set to Nothing");
						}
						this.QuerySingleton<Prototype>(ref this.m_Importer);
					}
				}
			}

			// Token: 0x17000008 RID: 8
			// (get) Token: 0x06000018 RID: 24 RVA: 0x000036CC File Offset: 0x000018CC
			// (set) Token: 0x0600001B RID: 27 RVA: 0x00003758 File Offset: 0x00001958
			public Bridge loader
			{
				get
				{
					this._Serializer = Advisor.Visitor.FillSingleton<Bridge>(this._Serializer);
					return this._Serializer;
				}
				set
				{
					if (value != this._Serializer)
					{
						if (value != null)
						{
							throw new System.ArgumentException("Property can only be set to Nothing");
						}
						this.QuerySingleton<Bridge>(ref this._Serializer);
					}
				}
			}

			// Token: 0x04000006 RID: 6
			[System.ThreadStatic]
			private static System.Collections.Hashtable m_Invocation;

			// Token: 0x04000007 RID: 7
			[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
			public Worker _Dispatcher;

			// Token: 0x04000008 RID: 8
			[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
			public Prototype m_Importer;

			// Token: 0x04000009 RID: 9
			[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
			public Bridge _Serializer;
		}

		// Token: 0x02000007 RID: 7
		[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
		[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
		internal sealed class Resolver
		{
			// Token: 0x0600001C RID: 28 RVA: 0x000022A9 File Offset: 0x000004A9
			[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
			public override bool Equals(object item)
			{
				return base.Equals(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(item));
			}

			// Token: 0x0600001D RID: 29 RVA: 0x000022B7 File Offset: 0x000004B7
			[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
			public override int GetHashCode()
			{
				return base.GetHashCode();
			}

			// Token: 0x0600001E RID: 30 RVA: 0x000022D3 File Offset: 0x000004D3
			[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
			internal System.Type AssetSingleton()
			{
				return typeof(Advisor.Resolver);
			}

			// Token: 0x0600001F RID: 31 RVA: 0x000022CB File Offset: 0x000004CB
			[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
			public override string ToString()
			{
				return base.ToString();
			}

			// Token: 0x06000020 RID: 32 RVA: 0x0000378C File Offset: 0x0000198C
			private static T NewSingleton<T>(T config) where T : new()
			{
				T result;
				if (config == null)
				{
					result = System.Activator.CreateInstance<T>();
				}
				else
				{
					result = config;
				}
				return result;
			}

			// Token: 0x06000021 RID: 33 RVA: 0x000022DF File Offset: 0x000004DF
			private void SelectSingleton<T>(ref T init)
			{
				init = default(T);
			}

			// Token: 0x06000022 RID: 34 RVA: 0x000022A1 File Offset: 0x000004A1
			[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
			public Resolver()
			{
			}
		}

		// Token: 0x02000008 RID: 8
		[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
		[System.Runtime.InteropServices.ComVisible(false)]
		internal sealed class Adapter<T> where T : new()
		{
			// Token: 0x06000023 RID: 35 RVA: 0x000022E8 File Offset: 0x000004E8
			internal T RemoveSingleton()
			{
				if (Advisor.Adapter<T>.mapper == null)
				{
					Advisor.Adapter<T>.mapper = System.Activator.CreateInstance<T>();
				}
				return Advisor.Adapter<T>.mapper;
			}

			// Token: 0x06000024 RID: 36 RVA: 0x000022A1 File Offset: 0x000004A1
			[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
			public Adapter()
			{
			}

			// Token: 0x0400000A RID: 10
			[System.ThreadStatic]
			[System.Runtime.CompilerServices.CompilerGenerated]
			private static T mapper;
		}
	}
}
