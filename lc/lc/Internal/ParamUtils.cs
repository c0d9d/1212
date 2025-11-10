using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace NET.Internal
{
	// Token: 0x02000027 RID: 39
	internal class ParamUtils
	{
		// Token: 0x0600017F RID: 383 RVA: 0x00002B3E File Offset: 0x00000D3E
		internal static object[] SelectUtils()
		{
			return new object[1];
		}

		// Token: 0x06000180 RID: 384 RVA: 0x0000A740 File Offset: 0x00008940
		internal static object[] RemoveUtils<T>(int index_param, object attr, object pool, ref T map2)
		{
			object templateUtils = ParamUtils.m_TemplateUtils;
			lock (templateUtils)
			{
				if (!ParamUtils.m_ItemUtils)
				{
					ParamUtils.m_ItemUtils = true;
					ParamUtils.ValidateUtils();
				}
			}
			ParamUtils.FacadeUtils facadeUtils = null;
			if (ParamUtils._MockUtils[index_param] != null)
			{
				facadeUtils = ParamUtils._MockUtils[index_param];
			}
			else
			{
				ParamUtils.m_StrategyUtils.BaseStream.Position = (long)ParamUtils.m_ExpressionUtils[index_param];
				facadeUtils = new ParamUtils.FacadeUtils();
				System.Reflection.Module module = typeof(ParamUtils).Module;
				int metadataToken = ParamUtils.CompareUtils(ParamUtils.m_StrategyUtils);
				int num = ParamUtils.CompareUtils(ParamUtils.m_StrategyUtils);
				int num2 = ParamUtils.CompareUtils(ParamUtils.m_StrategyUtils);
				int num3 = ParamUtils.CompareUtils(ParamUtils.m_StrategyUtils);
				facadeUtils.managerUtils = module.ResolveMethod(metadataToken);
				System.Reflection.ParameterInfo[] parameters = facadeUtils.managerUtils.GetParameters();
				facadeUtils.m_RecordUtils = new ParamUtils.RuleUtils[parameters.Length];
				for (int i = 0; i < parameters.Length; i++)
				{
					System.Type type = parameters[i].ParameterType;
					ParamUtils.RuleUtils ruleUtils = new ParamUtils.RuleUtils();
					ruleUtils._RegUtils = type.IsByRef;
					ruleUtils._StateUtils = i;
					facadeUtils.m_RecordUtils[i] = ruleUtils;
					if (type.IsByRef)
					{
						type = type.GetElementType();
					}
					ParamUtils.ProcessUtils repositoryUtils;
					if (type == typeof(string))
					{
						repositoryUtils = (ParamUtils.ProcessUtils)14;
					}
					else if (type == typeof(byte))
					{
						repositoryUtils = (ParamUtils.ProcessUtils)2;
					}
					else if (type == typeof(sbyte))
					{
						repositoryUtils = (ParamUtils.ProcessUtils)1;
					}
					else if (type == typeof(short))
					{
						repositoryUtils = (ParamUtils.ProcessUtils)3;
					}
					else if (type == typeof(ushort))
					{
						repositoryUtils = (ParamUtils.ProcessUtils)4;
					}
					else if (type == typeof(int))
					{
						repositoryUtils = (ParamUtils.ProcessUtils)5;
					}
					else if (type == typeof(uint))
					{
						repositoryUtils = (ParamUtils.ProcessUtils)6;
					}
					else if (type == typeof(long))
					{
						repositoryUtils = (ParamUtils.ProcessUtils)7;
					}
					else if (type == typeof(ulong))
					{
						repositoryUtils = (ParamUtils.ProcessUtils)8;
					}
					else if (type == typeof(float))
					{
						repositoryUtils = (ParamUtils.ProcessUtils)9;
					}
					else if (type == typeof(double))
					{
						repositoryUtils = (ParamUtils.ProcessUtils)10;
					}
					else if (type == typeof(bool))
					{
						repositoryUtils = (ParamUtils.ProcessUtils)11;
					}
					else if (type == typeof(System.IntPtr))
					{
						repositoryUtils = (ParamUtils.ProcessUtils)12;
					}
					else if (type == typeof(System.UIntPtr))
					{
						repositoryUtils = (ParamUtils.ProcessUtils)13;
					}
					else if (type == typeof(char))
					{
						repositoryUtils = (ParamUtils.ProcessUtils)15;
					}
					else
					{
						repositoryUtils = (ParamUtils.ProcessUtils)0;
					}
					ruleUtils.m_RepositoryUtils = repositoryUtils;
				}
				facadeUtils._PoolUtils = new System.Collections.Generic.List<ParamUtils.StructUtils>(num);
				for (int j = 0; j < num; j++)
				{
					int num4 = ParamUtils.CompareUtils(ParamUtils.m_StrategyUtils);
					ParamUtils.StructUtils structUtils = new ParamUtils.StructUtils();
					structUtils.m_TagUtils = null;
					if (num4 >= 0 && num4 < 50)
					{
						structUtils._ObjectUtils = (ParamUtils.ProcessUtils)(num4 & 31);
						structUtils.m_ObserverUtils = ((num4 & 32) > 0);
					}
					structUtils.m_AnnotationUtils = j;
					facadeUtils._PoolUtils.Add(structUtils);
				}
				facadeUtils.m_InitializerUtils = new System.Collections.Generic.List<ParamUtils.ReaderUtils>(num2);
				for (int k = 0; k < num2; k++)
				{
					int num5 = ParamUtils.CompareUtils(ParamUtils.m_StrategyUtils);
					int num6 = ParamUtils.CompareUtils(ParamUtils.m_StrategyUtils);
					ParamUtils.ReaderUtils readerUtils = new ParamUtils.ReaderUtils();
					readerUtils._StubUtils = num5;
					readerUtils._PageUtils = num6;
					ParamUtils.QueueUtils queueUtils = new ParamUtils.QueueUtils();
					readerUtils.classUtils = queueUtils;
					num5 = ParamUtils.CompareUtils(ParamUtils.m_StrategyUtils);
					num6 = ParamUtils.CompareUtils(ParamUtils.m_StrategyUtils);
					int num7 = ParamUtils.CompareUtils(ParamUtils.m_StrategyUtils);
					queueUtils._CustomerUtils = num5;
					queueUtils.m_AttributeUtils = num6;
					queueUtils.m_ModelUtils = num7;
					if (num7 == 0)
					{
						queueUtils._TaskUtils = module.ResolveType(ParamUtils.CompareUtils(ParamUtils.m_StrategyUtils));
					}
					else if (num7 == 1)
					{
						queueUtils._IteratorUtils = ParamUtils.CompareUtils(ParamUtils.m_StrategyUtils);
					}
					else
					{
						ParamUtils.CompareUtils(ParamUtils.m_StrategyUtils);
					}
					facadeUtils.m_InitializerUtils.Add(readerUtils);
				}
				facadeUtils.m_InitializerUtils.Sort(new System.Comparison<ParamUtils.ReaderUtils>(ParamUtils.Class1<T>.<>9.method_0));
				facadeUtils.policyUtils = new System.Collections.Generic.List<ParamUtils.ValueUtils>(num3);
				for (int l = 0; l < num3; l++)
				{
					ParamUtils.ValueUtils valueUtils = new ParamUtils.ValueUtils();
					byte b = ParamUtils.m_StrategyUtils.ReadByte();
					valueUtils.m_DicUtils = (ParamUtils.FDESVR)b;
					if (b >= 176)
					{
						throw new System.Exception();
					}
					int num8 = (int)ParamUtils._ListenerUtils[(int)b];
					if (num8 == 0)
					{
						valueUtils._StatusUtils = null;
					}
					else
					{
						object statusUtils;
						switch (num8)
						{
						case 1:
							statusUtils = ParamUtils.CompareUtils(ParamUtils.m_StrategyUtils);
							break;
						case 2:
							statusUtils = ParamUtils.m_StrategyUtils.ReadInt64();
							break;
						case 3:
							statusUtils = ParamUtils.m_StrategyUtils.ReadSingle();
							break;
						case 4:
							statusUtils = ParamUtils.m_StrategyUtils.ReadDouble();
							break;
						case 5:
						{
							int num9 = ParamUtils.CompareUtils(ParamUtils.m_StrategyUtils);
							int[] array = new int[num9];
							for (int m = 0; m < num9; m++)
							{
								array[m] = ParamUtils.CompareUtils(ParamUtils.m_StrategyUtils);
							}
							statusUtils = array;
							break;
						}
						default:
							throw new System.Exception();
						}
						valueUtils._StatusUtils = statusUtils;
					}
					facadeUtils.policyUtils.Add(valueUtils);
				}
				ParamUtils._MockUtils[index_param] = facadeUtils;
			}
			ParamUtils.FactoryUtils factoryUtils = new ParamUtils.FactoryUtils();
			factoryUtils.m_GetterUtils = facadeUtils;
			System.Reflection.ParameterInfo[] parameters2 = facadeUtils.managerUtils.GetParameters();
			bool flag2 = false;
			int num10 = 0;
			if (facadeUtils.managerUtils is System.Reflection.MethodInfo && ((System.Reflection.MethodInfo)facadeUtils.managerUtils).ReturnType != typeof(void))
			{
				flag2 = true;
			}
			if (facadeUtils.managerUtils.IsStatic)
			{
				factoryUtils.m_ProcUtils = new ParamUtils.DescriptorAdvisor[parameters2.Length];
				for (int n = 0; n < parameters2.Length; n++)
				{
					System.Type parameterType = parameters2[n].ParameterType;
					factoryUtils.m_ProcUtils[n] = ParamUtils.DescriptorAdvisor.UpdateParameter(parameterType, attr[n]);
					if (parameterType.IsByRef)
					{
						num10++;
					}
				}
			}
			else
			{
				factoryUtils.m_ProcUtils = new ParamUtils.DescriptorAdvisor[parameters2.Length + 1];
				if (facadeUtils.managerUtils.DeclaringType.IsValueType)
				{
					factoryUtils.m_ProcUtils[0] = new ParamUtils.AttrUtils(new ParamUtils.WorkerAdvisor(pool), facadeUtils.managerUtils.DeclaringType);
				}
				else
				{
					factoryUtils.m_ProcUtils[0] = new ParamUtils.WorkerAdvisor(pool);
				}
				for (int num11 = 0; num11 < parameters2.Length; num11++)
				{
					System.Type parameterType2 = parameters2[num11].ParameterType;
					if (parameterType2.IsByRef)
					{
						factoryUtils.m_ProcUtils[num11 + 1] = ParamUtils.DescriptorAdvisor.UpdateParameter(parameterType2, attr[num11]);
						num10++;
					}
					else
					{
						factoryUtils.m_ProcUtils[num11 + 1] = ParamUtils.DescriptorAdvisor.UpdateParameter(parameterType2, attr[num11]);
					}
				}
			}
			factoryUtils.singletonAdvisor = new ParamUtils.DescriptorAdvisor[facadeUtils._PoolUtils.Count];
			for (int num12 = 0; num12 < facadeUtils._PoolUtils.Count; num12++)
			{
				ParamUtils.StructUtils structUtils2 = facadeUtils._PoolUtils[num12];
				switch (structUtils2._ObjectUtils)
				{
				case (ParamUtils.ProcessUtils)0:
					factoryUtils.singletonAdvisor[num12] = null;
					break;
				case (ParamUtils.ProcessUtils)1:
				case (ParamUtils.ProcessUtils)2:
				case (ParamUtils.ProcessUtils)3:
				case (ParamUtils.ProcessUtils)4:
				case (ParamUtils.ProcessUtils)5:
				case (ParamUtils.ProcessUtils)6:
				case (ParamUtils.ProcessUtils)11:
				case (ParamUtils.ProcessUtils)15:
					factoryUtils.singletonAdvisor[num12] = new ParamUtils.CollectionUtils(0, structUtils2._ObjectUtils);
					break;
				case (ParamUtils.ProcessUtils)7:
				case (ParamUtils.ProcessUtils)8:
					factoryUtils.singletonAdvisor[num12] = new ParamUtils.ReponseUtils(0L, structUtils2._ObjectUtils);
					break;
				case (ParamUtils.ProcessUtils)9:
				case (ParamUtils.ProcessUtils)10:
					factoryUtils.singletonAdvisor[num12] = new ParamUtils.CreatorUtils(0.0, structUtils2._ObjectUtils);
					break;
				case (ParamUtils.ProcessUtils)12:
					factoryUtils.singletonAdvisor[num12] = new ParamUtils.WrapperUtils(System.IntPtr.Zero);
					break;
				case (ParamUtils.ProcessUtils)13:
					factoryUtils.singletonAdvisor[num12] = new ParamUtils.WrapperUtils(System.UIntPtr.Zero);
					break;
				case (ParamUtils.ProcessUtils)14:
					factoryUtils.singletonAdvisor[num12] = null;
					break;
				case (ParamUtils.ProcessUtils)16:
					factoryUtils.singletonAdvisor[num12] = new ParamUtils.WorkerAdvisor(null);
					break;
				}
			}
			try
			{
				factoryUtils.ReflectAdvisor();
			}
			finally
			{
				factoryUtils.WriteAdvisor();
			}
			int num13 = 0;
			if (flag2)
			{
				num13 = 1;
			}
			num13 += num10;
			object[] array2 = new object[num13];
			if (flag2)
			{
				array2[0] = null;
			}
			if (facadeUtils.managerUtils is System.Reflection.MethodInfo)
			{
				System.Reflection.MethodInfo methodInfo = (System.Reflection.MethodInfo)facadeUtils.managerUtils;
				if (methodInfo.ReturnType != typeof(void) && factoryUtils.advisorAdvisor != null)
				{
					array2[0] = factoryUtils.advisorAdvisor.RateDatabase(methodInfo.ReturnType);
				}
			}
			if (num10 > 0)
			{
				int num14 = 0;
				if (flag2)
				{
					num14++;
				}
				for (int num15 = 0; num15 < parameters2.Length; num15++)
				{
					System.Type type2 = parameters2[num15].ParameterType;
					if (type2.IsByRef)
					{
						type2 = type2.GetElementType();
						if (factoryUtils.m_ProcUtils[num15] != null)
						{
							if (facadeUtils.managerUtils.IsStatic)
							{
								array2[num14] = factoryUtils.m_ProcUtils[num15].RateDatabase(type2);
							}
							else
							{
								array2[num14] = factoryUtils.m_ProcUtils[num15 + 1].RateDatabase(type2);
							}
						}
						else
						{
							array2[num14] = null;
						}
						num14++;
					}
				}
			}
			if (!facadeUtils.managerUtils.IsStatic && facadeUtils.managerUtils.DeclaringType.IsValueType)
			{
				map2 = (T)((object)factoryUtils.m_ProcUtils[0].RateDatabase(facadeUtils.managerUtils.DeclaringType));
			}
			return array2;
		}

		// Token: 0x06000181 RID: 385 RVA: 0x00002B46 File Offset: 0x00000D46
		internal static object[] CustomizeUtils(int ident, object cont, object helper)
		{
			return ParamUtils.RemoveUtils<int>(ident, cont, helper, ref ParamUtils.m_SetterUtils);
		}

		// Token: 0x06000182 RID: 386 RVA: 0x00002B55 File Offset: 0x00000D55
		internal static object[] ConnectUtils<T>(int last_Low, object selection, ref T rule)
		{
			return ParamUtils.RemoveUtils<T>(last_Low, selection, rule, ref rule);
		}

		// Token: 0x06000183 RID: 387 RVA: 0x0000B108 File Offset: 0x00009308
		internal static void ValidateUtils()
		{
			if (ParamUtils.m_ExpressionUtils == null)
			{
				System.IO.BinaryReader binaryReader = new System.IO.BinaryReader(typeof(ParamUtils).Assembly.GetManifestResourceStream("Account.Interpreter"));
				binaryReader.BaseStream.Position = 0L;
				byte[] ident = binaryReader.ReadBytes((int)binaryReader.BaseStream.Length);
				binaryReader.Close();
				ParamUtils.ResetUtils(ident);
			}
		}

		// Token: 0x06000184 RID: 388 RVA: 0x0000B170 File Offset: 0x00009370
		internal static void ResetUtils(byte[] ident)
		{
			ParamUtils.m_StrategyUtils = new System.IO.BinaryReader(new System.IO.MemoryStream(ident));
			ParamUtils._ListenerUtils = new byte[255];
			int num = ParamUtils.CompareUtils(ParamUtils.m_StrategyUtils);
			for (int i = 0; i < num; i++)
			{
				int num2 = (int)ParamUtils.m_StrategyUtils.ReadByte();
				ParamUtils._ListenerUtils[num2] = ParamUtils.m_StrategyUtils.ReadByte();
			}
			num = ParamUtils.CompareUtils(ParamUtils.m_StrategyUtils);
			ParamUtils.helperUtils = new System.Collections.Generic.List<string>(num);
			for (int j = 0; j < num; j++)
			{
				ParamUtils.helperUtils.Add(System.Text.Encoding.Unicode.GetString(ParamUtils.m_StrategyUtils.ReadBytes(ParamUtils.CompareUtils(ParamUtils.m_StrategyUtils))));
			}
			num = ParamUtils.CompareUtils(ParamUtils.m_StrategyUtils);
			ParamUtils._MockUtils = new ParamUtils.FacadeUtils[num];
			ParamUtils.m_ExpressionUtils = new int[num];
			for (int k = 0; k < num; k++)
			{
				ParamUtils._MockUtils[k] = null;
				ParamUtils.m_ExpressionUtils[k] = ParamUtils.CompareUtils(ParamUtils.m_StrategyUtils);
			}
			int num3 = (int)ParamUtils.m_StrategyUtils.BaseStream.Position;
			for (int l = 0; l < num; l++)
			{
				int num4 = ParamUtils.m_ExpressionUtils[l];
				ParamUtils.m_ExpressionUtils[l] = num3;
				num3 += num4;
			}
		}

		// Token: 0x06000185 RID: 389 RVA: 0x0000B2B8 File Offset: 0x000094B8
		internal static int CompareUtils(System.IO.BinaryReader task)
		{
			bool flag = false;
			uint num = (uint)task.ReadByte();
			uint num2 = 0U | (num & 63U);
			if ((num & 64U) != 0U)
			{
				flag = true;
			}
			if (num >= 128U)
			{
				int num3 = 0;
				for (;;)
				{
					uint num4 = (uint)task.ReadByte();
					num2 |= (num4 & 127U) << 7 * num3 + 6;
					if (num4 < 128U)
					{
						break;
					}
					num3++;
				}
				if (!flag)
				{
					return (int)num2;
				}
				return (int)(~(int)num2);
			}
			else
			{
				if (flag)
				{
					return (int)(~(int)num2);
				}
				return (int)num2;
			}
		}

		// Token: 0x04000078 RID: 120
		internal static ParamUtils.FacadeUtils[] _MockUtils = null;

		// Token: 0x04000079 RID: 121
		internal static int[] m_ExpressionUtils = null;

		// Token: 0x0400007A RID: 122
		internal static System.Collections.Generic.List<string> helperUtils;

		// Token: 0x0400007B RID: 123
		private static System.IO.BinaryReader m_StrategyUtils;

		// Token: 0x0400007C RID: 124
		private static byte[] _ListenerUtils;

		// Token: 0x0400007D RID: 125
		private static bool m_ItemUtils = false;

		// Token: 0x0400007E RID: 126
		private static object m_TemplateUtils = 1;

		// Token: 0x0400007F RID: 127
		private static int m_SetterUtils;

		// Token: 0x02000028 RID: 40
		[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Explicit)]
		internal struct ComposerUtils
		{
			// Token: 0x04000080 RID: 128
			[System.Runtime.InteropServices.FieldOffset(0)]
			public byte m_ContainerUtils;

			// Token: 0x04000081 RID: 129
			[System.Runtime.InteropServices.FieldOffset(0)]
			public sbyte m_IdentifierUtils;

			// Token: 0x04000082 RID: 130
			[System.Runtime.InteropServices.FieldOffset(0)]
			public ushort threadUtils;

			// Token: 0x04000083 RID: 131
			[System.Runtime.InteropServices.FieldOffset(0)]
			public short errorUtils;

			// Token: 0x04000084 RID: 132
			[System.Runtime.InteropServices.FieldOffset(0)]
			public uint m_RequestUtils;

			// Token: 0x04000085 RID: 133
			[System.Runtime.InteropServices.FieldOffset(0)]
			public int m_MethodUtils;
		}

		// Token: 0x02000029 RID: 41
		private class CollectionUtils : ParamUtils.ComparatorUtils
		{
			// Token: 0x06000188 RID: 392 RVA: 0x0000B360 File Offset: 0x00009560
			internal override void CompareDatabase(ParamUtils.DescriptorAdvisor last)
			{
				this.messageUtils = ((ParamUtils.CollectionUtils)last).messageUtils;
				this._BroadcasterUtils = ((ParamUtils.CollectionUtils)last)._BroadcasterUtils;
			}

			// Token: 0x06000189 RID: 393 RVA: 0x0000B390 File Offset: 0x00009590
			internal override void PrintDatabase(ParamUtils.DescriptorAdvisor param)
			{
				this.CompareDatabase(param);
			}

			// Token: 0x0600018A RID: 394 RVA: 0x0000B3A4 File Offset: 0x000095A4
			public CollectionUtils(bool isident)
			{
				this._ProxyAdvisor = (ParamUtils.CopyOption)1;
				if (isident)
				{
					this.messageUtils.m_MethodUtils = 1;
				}
				else
				{
					this.messageUtils.m_MethodUtils = 0;
				}
				this._BroadcasterUtils = (ParamUtils.ProcessUtils)11;
			}

			// Token: 0x0600018B RID: 395 RVA: 0x0000B3E4 File Offset: 0x000095E4
			public CollectionUtils(ParamUtils.CollectionUtils param)
			{
				this._ProxyAdvisor = param._ProxyAdvisor;
				this.messageUtils.m_MethodUtils = param.messageUtils.m_MethodUtils;
				this._BroadcasterUtils = param._BroadcasterUtils;
			}

			// Token: 0x0600018C RID: 396 RVA: 0x00002B6A File Offset: 0x00000D6A
			public override ParamUtils.ComparatorUtils PrepareDatabase()
			{
				return new ParamUtils.CollectionUtils(this);
			}

			// Token: 0x0600018D RID: 397 RVA: 0x0000B428 File Offset: 0x00009628
			public CollectionUtils(int flags_config)
			{
				this._ProxyAdvisor = (ParamUtils.CopyOption)1;
				this.messageUtils.m_MethodUtils = flags_config;
				this._BroadcasterUtils = (ParamUtils.ProcessUtils)5;
			}

			// Token: 0x0600018E RID: 398 RVA: 0x0000B458 File Offset: 0x00009658
			public CollectionUtils(uint ident)
			{
				this._ProxyAdvisor = (ParamUtils.CopyOption)1;
				this.messageUtils.m_RequestUtils = ident;
				this._BroadcasterUtils = (ParamUtils.ProcessUtils)6;
			}

			// Token: 0x0600018F RID: 399 RVA: 0x0000B488 File Offset: 0x00009688
			public CollectionUtils(int position_asset, ParamUtils.ProcessUtils reg)
			{
				this._ProxyAdvisor = (ParamUtils.CopyOption)1;
				this.messageUtils.m_MethodUtils = position_asset;
				this._BroadcasterUtils = reg;
			}

			// Token: 0x06000190 RID: 400 RVA: 0x0000B4B8 File Offset: 0x000096B8
			public CollectionUtils(uint res, ParamUtils.ProcessUtils selection)
			{
				this._ProxyAdvisor = (ParamUtils.CopyOption)1;
				this.messageUtils.m_RequestUtils = res;
				this._BroadcasterUtils = selection;
			}

			// Token: 0x06000191 RID: 401 RVA: 0x0000B4E8 File Offset: 0x000096E8
			public override bool LogoutDatabase()
			{
				ParamUtils.ProcessUtils broadcasterUtils = this._BroadcasterUtils;
				switch (broadcasterUtils)
				{
				case (ParamUtils.ProcessUtils)1:
				case (ParamUtils.ProcessUtils)3:
				case (ParamUtils.ProcessUtils)5:
				case (ParamUtils.ProcessUtils)7:
					goto IL_4A;
				case (ParamUtils.ProcessUtils)2:
				case (ParamUtils.ProcessUtils)4:
				case (ParamUtils.ProcessUtils)6:
					break;
				default:
					if (broadcasterUtils == (ParamUtils.ProcessUtils)11)
					{
						goto IL_4A;
					}
					if (broadcasterUtils == (ParamUtils.ProcessUtils)15)
					{
						goto IL_4A;
					}
					break;
				}
				return this.messageUtils.m_RequestUtils == 0U;
				IL_4A:
				return this.messageUtils.m_MethodUtils == 0;
			}

			// Token: 0x06000192 RID: 402 RVA: 0x00002B72 File Offset: 0x00000D72
			public override bool FindDatabase()
			{
				return !this.LogoutDatabase();
			}

			// Token: 0x06000193 RID: 403 RVA: 0x0000B550 File Offset: 0x00009750
			public override ParamUtils.DescriptorAdvisor TestDatabase(ParamUtils.ProcessUtils spec)
			{
				switch (spec)
				{
				case (ParamUtils.ProcessUtils)1:
					return this.InstantiateDatabase();
				case (ParamUtils.ProcessUtils)2:
					return this.OrderDatabase();
				case (ParamUtils.ProcessUtils)3:
					return this.SortDatabase();
				case (ParamUtils.ProcessUtils)4:
					return this.CancelDatabase();
				case (ParamUtils.ProcessUtils)5:
					return this.AddDatabase();
				case (ParamUtils.ProcessUtils)6:
					return this.CheckDatabase();
				case (ParamUtils.ProcessUtils)11:
					return this.RestartDatabase();
				case (ParamUtils.ProcessUtils)15:
					return this.PrepareUtils();
				case (ParamUtils.ProcessUtils)16:
					return this.PrepareDatabase();
				}
				throw new System.Exception(((ParamUtils.CancellationMode)4).ToString());
			}

			// Token: 0x06000194 RID: 404 RVA: 0x0000B5FC File Offset: 0x000097FC
			internal override object RateDatabase(System.Type def)
			{
				if (def != null && def.IsByRef)
				{
					def = def.GetElementType();
				}
				if (def == null || def == typeof(object))
				{
					switch (this._BroadcasterUtils)
					{
					case (ParamUtils.ProcessUtils)1:
						return this.messageUtils.m_IdentifierUtils;
					case (ParamUtils.ProcessUtils)2:
						return this.messageUtils.m_ContainerUtils;
					case (ParamUtils.ProcessUtils)3:
						return this.messageUtils.errorUtils;
					case (ParamUtils.ProcessUtils)4:
						return this.messageUtils.threadUtils;
					case (ParamUtils.ProcessUtils)5:
						return this.messageUtils.m_MethodUtils;
					case (ParamUtils.ProcessUtils)6:
						return this.messageUtils.m_RequestUtils;
					case (ParamUtils.ProcessUtils)7:
						return (long)this.messageUtils.m_MethodUtils;
					case (ParamUtils.ProcessUtils)8:
						return (ulong)this.messageUtils.m_RequestUtils;
					case (ParamUtils.ProcessUtils)11:
						return this.FindDatabase();
					case (ParamUtils.ProcessUtils)15:
						return (char)this.messageUtils.m_MethodUtils;
					}
					return this.messageUtils.m_MethodUtils;
				}
				if (def == typeof(int))
				{
					return this.messageUtils.m_MethodUtils;
				}
				if (def == typeof(uint))
				{
					return this.messageUtils.m_RequestUtils;
				}
				if (def == typeof(short))
				{
					return this.messageUtils.errorUtils;
				}
				if (def == typeof(ushort))
				{
					return this.messageUtils.threadUtils;
				}
				if (def == typeof(byte))
				{
					return this.messageUtils.m_ContainerUtils;
				}
				if (def == typeof(sbyte))
				{
					return this.messageUtils.m_IdentifierUtils;
				}
				if (def == typeof(bool))
				{
					return !this.LogoutDatabase();
				}
				if (def == typeof(long))
				{
					return (long)this.messageUtils.m_MethodUtils;
				}
				if (def == typeof(ulong))
				{
					return (ulong)this.messageUtils.m_RequestUtils;
				}
				if (def == typeof(char))
				{
					return (char)this.messageUtils.m_MethodUtils;
				}
				if (def == typeof(System.IntPtr))
				{
					return new System.IntPtr(this.messageUtils.m_MethodUtils);
				}
				if (def == typeof(System.UIntPtr))
				{
					return new System.UIntPtr(this.messageUtils.m_RequestUtils);
				}
				if (def.IsEnum)
				{
					return this.PrintUtils(def);
				}
				throw new ParamUtils.ExporterUtils();
			}

			// Token: 0x06000195 RID: 405 RVA: 0x0000B91C File Offset: 0x00009B1C
			internal object PrintUtils(System.Type setup)
			{
				System.Type underlyingType = System.Enum.GetUnderlyingType(setup);
				if (underlyingType == typeof(int))
				{
					return System.Enum.ToObject(setup, this.messageUtils.m_MethodUtils);
				}
				if (underlyingType == typeof(uint))
				{
					return System.Enum.ToObject(setup, this.messageUtils.m_RequestUtils);
				}
				if (underlyingType == typeof(short))
				{
					return System.Enum.ToObject(setup, this.messageUtils.errorUtils);
				}
				if (underlyingType == typeof(ushort))
				{
					return System.Enum.ToObject(setup, this.messageUtils.threadUtils);
				}
				if (underlyingType == typeof(byte))
				{
					return System.Enum.ToObject(setup, this.messageUtils.m_ContainerUtils);
				}
				if (underlyingType == typeof(sbyte))
				{
					return System.Enum.ToObject(setup, this.messageUtils.m_IdentifierUtils);
				}
				if (underlyingType == typeof(long))
				{
					return System.Enum.ToObject(setup, (long)this.messageUtils.m_MethodUtils);
				}
				if (underlyingType == typeof(ulong))
				{
					return System.Enum.ToObject(setup, (ulong)this.messageUtils.m_RequestUtils);
				}
				if (underlyingType == typeof(char))
				{
					return System.Enum.ToObject(setup, (ushort)this.messageUtils.m_MethodUtils);
				}
				return System.Enum.ToObject(setup, this.messageUtils.m_MethodUtils);
			}

			// Token: 0x06000196 RID: 406 RVA: 0x0000BA98 File Offset: 0x00009C98
			public override ParamUtils.CollectionUtils RestartDatabase()
			{
				return new ParamUtils.CollectionUtils(this.LogoutDatabase() ? 0 : 1);
			}

			// Token: 0x06000197 RID: 407 RVA: 0x00002B7D File Offset: 0x00000D7D
			internal override bool InsertDatabase()
			{
				return this.FindDatabase();
			}

			// Token: 0x06000198 RID: 408 RVA: 0x00002B85 File Offset: 0x00000D85
			public override ParamUtils.CollectionUtils InstantiateDatabase()
			{
				return new ParamUtils.CollectionUtils((int)this.messageUtils.m_IdentifierUtils, (ParamUtils.ProcessUtils)1);
			}

			// Token: 0x06000199 RID: 409 RVA: 0x00002B98 File Offset: 0x00000D98
			public ParamUtils.CollectionUtils PrepareUtils()
			{
				return new ParamUtils.CollectionUtils(this.messageUtils.m_MethodUtils, (ParamUtils.ProcessUtils)15);
			}

			// Token: 0x0600019A RID: 410 RVA: 0x00002BAC File Offset: 0x00000DAC
			public override ParamUtils.CollectionUtils OrderDatabase()
			{
				return new ParamUtils.CollectionUtils((uint)this.messageUtils.m_ContainerUtils, (ParamUtils.ProcessUtils)2);
			}

			// Token: 0x0600019B RID: 411 RVA: 0x00002BBF File Offset: 0x00000DBF
			public override ParamUtils.CollectionUtils SortDatabase()
			{
				return new ParamUtils.CollectionUtils((int)this.messageUtils.errorUtils, (ParamUtils.ProcessUtils)3);
			}

			// Token: 0x0600019C RID: 412 RVA: 0x00002BD2 File Offset: 0x00000DD2
			public override ParamUtils.CollectionUtils CancelDatabase()
			{
				return new ParamUtils.CollectionUtils((uint)this.messageUtils.threadUtils, (ParamUtils.ProcessUtils)4);
			}

			// Token: 0x0600019D RID: 413 RVA: 0x00002BE5 File Offset: 0x00000DE5
			public override ParamUtils.CollectionUtils AddDatabase()
			{
				return new ParamUtils.CollectionUtils(this.messageUtils.m_MethodUtils, (ParamUtils.ProcessUtils)5);
			}

			// Token: 0x0600019E RID: 414 RVA: 0x00002BF8 File Offset: 0x00000DF8
			public override ParamUtils.CollectionUtils CheckDatabase()
			{
				return new ParamUtils.CollectionUtils(this.messageUtils.m_RequestUtils, (ParamUtils.ProcessUtils)6);
			}

			// Token: 0x0600019F RID: 415 RVA: 0x00002C0B File Offset: 0x00000E0B
			public override ParamUtils.ReponseUtils DefineDatabase()
			{
				return new ParamUtils.ReponseUtils((long)this.messageUtils.m_MethodUtils, (ParamUtils.ProcessUtils)7);
			}

			// Token: 0x060001A0 RID: 416 RVA: 0x00002C1F File Offset: 0x00000E1F
			public override ParamUtils.ReponseUtils ViewDatabase()
			{
				return new ParamUtils.ReponseUtils((ulong)this.messageUtils.m_RequestUtils, (ParamUtils.ProcessUtils)8);
			}

			// Token: 0x060001A1 RID: 417 RVA: 0x00002C33 File Offset: 0x00000E33
			public override ParamUtils.CollectionUtils RevertDatabase()
			{
				return this.InstantiateDatabase();
			}

			// Token: 0x060001A2 RID: 418 RVA: 0x00002C3B File Offset: 0x00000E3B
			public override ParamUtils.CollectionUtils PublishPublisher()
			{
				return this.SortDatabase();
			}

			// Token: 0x060001A3 RID: 419 RVA: 0x00002C43 File Offset: 0x00000E43
			public override ParamUtils.CollectionUtils SetupPublisher()
			{
				return this.AddDatabase();
			}

			// Token: 0x060001A4 RID: 420 RVA: 0x00002C4B File Offset: 0x00000E4B
			public override ParamUtils.ReponseUtils SetPublisher()
			{
				return this.DefineDatabase();
			}

			// Token: 0x060001A5 RID: 421 RVA: 0x00002C53 File Offset: 0x00000E53
			public override ParamUtils.CollectionUtils CountPublisher()
			{
				return this.OrderDatabase();
			}

			// Token: 0x060001A6 RID: 422 RVA: 0x00002C5B File Offset: 0x00000E5B
			public override ParamUtils.CollectionUtils ReflectPublisher()
			{
				return this.CancelDatabase();
			}

			// Token: 0x060001A7 RID: 423 RVA: 0x00002C63 File Offset: 0x00000E63
			public override ParamUtils.CollectionUtils WritePublisher()
			{
				return this.CheckDatabase();
			}

			// Token: 0x060001A8 RID: 424 RVA: 0x00002C6B File Offset: 0x00000E6B
			public override ParamUtils.ReponseUtils ClonePublisher()
			{
				return this.ViewDatabase();
			}

			// Token: 0x060001A9 RID: 425 RVA: 0x00002C73 File Offset: 0x00000E73
			public override ParamUtils.CollectionUtils VisitPublisher()
			{
				return new ParamUtils.CollectionUtils((int)(checked((sbyte)this.messageUtils.m_MethodUtils)), (ParamUtils.ProcessUtils)1);
			}

			// Token: 0x060001AA RID: 426 RVA: 0x00002C87 File Offset: 0x00000E87
			public override ParamUtils.CollectionUtils MapPublisher()
			{
				return new ParamUtils.CollectionUtils((int)(checked((sbyte)this.messageUtils.m_RequestUtils)), (ParamUtils.ProcessUtils)1);
			}

			// Token: 0x060001AB RID: 427 RVA: 0x00002C9B File Offset: 0x00000E9B
			public override ParamUtils.CollectionUtils VerifyPublisher()
			{
				return new ParamUtils.CollectionUtils((int)(checked((short)this.messageUtils.m_MethodUtils)), (ParamUtils.ProcessUtils)3);
			}

			// Token: 0x060001AC RID: 428 RVA: 0x00002CAF File Offset: 0x00000EAF
			public override ParamUtils.CollectionUtils ChangePublisher()
			{
				return new ParamUtils.CollectionUtils((int)(checked((short)this.messageUtils.m_RequestUtils)), (ParamUtils.ProcessUtils)3);
			}

			// Token: 0x060001AD RID: 429 RVA: 0x00002BE5 File Offset: 0x00000DE5
			public override ParamUtils.CollectionUtils ListPublisher()
			{
				return new ParamUtils.CollectionUtils(this.messageUtils.m_MethodUtils, (ParamUtils.ProcessUtils)5);
			}

			// Token: 0x060001AE RID: 430 RVA: 0x00002CC3 File Offset: 0x00000EC3
			public override ParamUtils.CollectionUtils IncludePublisher()
			{
				return new ParamUtils.CollectionUtils(checked((int)this.messageUtils.m_RequestUtils), (ParamUtils.ProcessUtils)5);
			}

			// Token: 0x060001AF RID: 431 RVA: 0x00002C0B File Offset: 0x00000E0B
			public override ParamUtils.ReponseUtils CreatePublisher()
			{
				return new ParamUtils.ReponseUtils((long)this.messageUtils.m_MethodUtils, (ParamUtils.ProcessUtils)7);
			}

			// Token: 0x060001B0 RID: 432 RVA: 0x00002CD7 File Offset: 0x00000ED7
			public override ParamUtils.ReponseUtils EnablePublisher()
			{
				return new ParamUtils.ReponseUtils((long)((ulong)this.messageUtils.m_RequestUtils), (ParamUtils.ProcessUtils)7);
			}

			// Token: 0x060001B1 RID: 433 RVA: 0x00002CEB File Offset: 0x00000EEB
			public override ParamUtils.CollectionUtils PatchPublisher()
			{
				return new ParamUtils.CollectionUtils((int)(checked((byte)this.messageUtils.m_MethodUtils)), (ParamUtils.ProcessUtils)2);
			}

			// Token: 0x060001B2 RID: 434 RVA: 0x00002CFF File Offset: 0x00000EFF
			public override ParamUtils.CollectionUtils ForgotPublisher()
			{
				return new ParamUtils.CollectionUtils((int)(checked((byte)this.messageUtils.m_RequestUtils)), (ParamUtils.ProcessUtils)2);
			}

			// Token: 0x060001B3 RID: 435 RVA: 0x00002D13 File Offset: 0x00000F13
			public override ParamUtils.CollectionUtils InitPublisher()
			{
				return new ParamUtils.CollectionUtils((int)(checked((ushort)this.messageUtils.m_MethodUtils)), (ParamUtils.ProcessUtils)4);
			}

			// Token: 0x060001B4 RID: 436 RVA: 0x00002D27 File Offset: 0x00000F27
			public override ParamUtils.CollectionUtils CollectPublisher()
			{
				return new ParamUtils.CollectionUtils((int)(checked((ushort)this.messageUtils.m_RequestUtils)), (ParamUtils.ProcessUtils)4);
			}

			// Token: 0x060001B5 RID: 437 RVA: 0x00002D3B File Offset: 0x00000F3B
			public override ParamUtils.CollectionUtils ConcatPublisher()
			{
				return new ParamUtils.CollectionUtils(checked((uint)this.messageUtils.m_MethodUtils), (ParamUtils.ProcessUtils)6);
			}

			// Token: 0x060001B6 RID: 438 RVA: 0x00002BF8 File Offset: 0x00000DF8
			public override ParamUtils.CollectionUtils InvokePublisher()
			{
				return new ParamUtils.CollectionUtils(this.messageUtils.m_RequestUtils, (ParamUtils.ProcessUtils)6);
			}

			// Token: 0x060001B7 RID: 439 RVA: 0x00002D4F File Offset: 0x00000F4F
			public override ParamUtils.ReponseUtils AwakePublisher()
			{
				return new ParamUtils.ReponseUtils(checked((ulong)this.messageUtils.m_MethodUtils), (ParamUtils.ProcessUtils)8);
			}

			// Token: 0x060001B8 RID: 440 RVA: 0x00002C1F File Offset: 0x00000E1F
			public override ParamUtils.ReponseUtils FlushPublisher()
			{
				return new ParamUtils.ReponseUtils((ulong)this.messageUtils.m_RequestUtils, (ParamUtils.ProcessUtils)8);
			}

			// Token: 0x060001B9 RID: 441 RVA: 0x00002D63 File Offset: 0x00000F63
			public override ParamUtils.CreatorUtils PopPublisher()
			{
				return new ParamUtils.CreatorUtils((float)this.messageUtils.m_MethodUtils);
			}

			// Token: 0x060001BA RID: 442 RVA: 0x00002D76 File Offset: 0x00000F76
			public override ParamUtils.CreatorUtils RegisterPublisher()
			{
				return new ParamUtils.CreatorUtils((double)this.messageUtils.m_MethodUtils);
			}

			// Token: 0x060001BB RID: 443 RVA: 0x00002D89 File Offset: 0x00000F89
			public override ParamUtils.CreatorUtils CalcPublisher()
			{
				return new ParamUtils.CreatorUtils(this.messageUtils.m_RequestUtils);
			}

			// Token: 0x060001BC RID: 444 RVA: 0x0000BAB8 File Offset: 0x00009CB8
			public override ParamUtils.WrapperUtils DestroyPublisher()
			{
				if (System.IntPtr.Size == 8)
				{
					return new ParamUtils.WrapperUtils(this.SetPublisher().m_ContextUtils.m_ProcessorUtils);
				}
				return new ParamUtils.WrapperUtils((long)this.SetupPublisher().messageUtils.m_MethodUtils);
			}

			// Token: 0x060001BD RID: 445 RVA: 0x0000BAFC File Offset: 0x00009CFC
			public override ParamUtils.WrapperUtils GetPublisher()
			{
				if (System.IntPtr.Size == 8)
				{
					return new ParamUtils.WrapperUtils(this.ClonePublisher().m_ContextUtils.decoratorUtils);
				}
				return new ParamUtils.WrapperUtils((ulong)this.WritePublisher().messageUtils.m_RequestUtils);
			}

			// Token: 0x060001BE RID: 446 RVA: 0x0000BB40 File Offset: 0x00009D40
			public override ParamUtils.WrapperUtils StartPublisher()
			{
				if (System.IntPtr.Size == 8)
				{
					return new ParamUtils.WrapperUtils(this.CreatePublisher().m_ContextUtils.m_ProcessorUtils);
				}
				return new ParamUtils.WrapperUtils((long)this.ListPublisher().messageUtils.m_MethodUtils);
			}

			// Token: 0x060001BF RID: 447 RVA: 0x0000BB84 File Offset: 0x00009D84
			public override ParamUtils.WrapperUtils SearchPublisher()
			{
				if (System.IntPtr.Size == 8)
				{
					return new ParamUtils.WrapperUtils(this.AwakePublisher().m_ContextUtils.decoratorUtils);
				}
				return new ParamUtils.WrapperUtils((ulong)this.ConcatPublisher().messageUtils.m_RequestUtils);
			}

			// Token: 0x060001C0 RID: 448 RVA: 0x0000BBC8 File Offset: 0x00009DC8
			public override ParamUtils.WrapperUtils PushPublisher()
			{
				if (System.IntPtr.Size == 8)
				{
					return new ParamUtils.WrapperUtils(this.EnablePublisher().m_ContextUtils.m_ProcessorUtils);
				}
				return new ParamUtils.WrapperUtils((long)this.IncludePublisher().messageUtils.m_MethodUtils);
			}

			// Token: 0x060001C1 RID: 449 RVA: 0x0000BC0C File Offset: 0x00009E0C
			public override ParamUtils.WrapperUtils ReadPublisher()
			{
				if (System.IntPtr.Size == 8)
				{
					return new ParamUtils.WrapperUtils(this.FlushPublisher().m_ContextUtils.decoratorUtils);
				}
				return new ParamUtils.WrapperUtils((ulong)this.InvokePublisher().messageUtils.m_RequestUtils);
			}

			// Token: 0x060001C2 RID: 450 RVA: 0x0000BC50 File Offset: 0x00009E50
			public override ParamUtils.DescriptorAdvisor ExcludePublisher()
			{
				ParamUtils.ProcessUtils broadcasterUtils = this._BroadcasterUtils;
				switch (broadcasterUtils)
				{
				case (ParamUtils.ProcessUtils)1:
				case (ParamUtils.ProcessUtils)3:
				case (ParamUtils.ProcessUtils)5:
					goto IL_47;
				case (ParamUtils.ProcessUtils)2:
				case (ParamUtils.ProcessUtils)4:
					break;
				default:
					if (broadcasterUtils == (ParamUtils.ProcessUtils)11)
					{
						goto IL_47;
					}
					if (broadcasterUtils == (ParamUtils.ProcessUtils)15)
					{
						goto IL_47;
					}
					break;
				}
				return new ParamUtils.CollectionUtils((int)(-(int)((ulong)this.messageUtils.m_RequestUtils)));
				IL_47:
				return new ParamUtils.CollectionUtils(-this.messageUtils.m_MethodUtils);
			}

			// Token: 0x060001C3 RID: 451 RVA: 0x0000BCB8 File Offset: 0x00009EB8
			public override ParamUtils.DescriptorAdvisor CalculatePublisher(ParamUtils.DescriptorAdvisor last)
			{
				if (last.OrderPublisher())
				{
					last = last.CustomizePublisher();
				}
				if (last.ResolveParameter())
				{
					return new ParamUtils.CollectionUtils(this.messageUtils.m_MethodUtils + ((ParamUtils.CollectionUtils)last).messageUtils.m_MethodUtils);
				}
				if (!last.InterruptParameter())
				{
					throw new ParamUtils.ExporterUtils();
				}
				return ((ParamUtils.WrapperUtils)last).CalculatePublisher(this);
			}

			// Token: 0x060001C4 RID: 452 RVA: 0x0000BD1C File Offset: 0x00009F1C
			public override ParamUtils.DescriptorAdvisor DeletePublisher(ParamUtils.DescriptorAdvisor instance)
			{
				if (instance.OrderPublisher())
				{
					instance = instance.CustomizePublisher();
				}
				if (instance.ResolveParameter())
				{
					return new ParamUtils.CollectionUtils(checked(this.messageUtils.m_MethodUtils + ((ParamUtils.CollectionUtils)instance).messageUtils.m_MethodUtils));
				}
				if (!instance.InterruptParameter())
				{
					throw new ParamUtils.ExporterUtils();
				}
				return ((ParamUtils.WrapperUtils)instance).DeletePublisher(this);
			}

			// Token: 0x060001C5 RID: 453 RVA: 0x0000BD80 File Offset: 0x00009F80
			public override ParamUtils.DescriptorAdvisor RunPublisher(ParamUtils.DescriptorAdvisor asset)
			{
				if (asset.OrderPublisher())
				{
					asset = asset.CustomizePublisher();
				}
				if (asset.ResolveParameter())
				{
					return new ParamUtils.CollectionUtils(checked(this.messageUtils.m_RequestUtils + ((ParamUtils.CollectionUtils)asset).messageUtils.m_RequestUtils));
				}
				if (!asset.InterruptParameter())
				{
					throw new ParamUtils.ExporterUtils();
				}
				return ((ParamUtils.WrapperUtils)asset).RunPublisher(this);
			}

			// Token: 0x060001C6 RID: 454 RVA: 0x0000BDE4 File Offset: 0x00009FE4
			public override ParamUtils.DescriptorAdvisor MovePublisher(ParamUtils.DescriptorAdvisor reference)
			{
				if (reference.OrderPublisher())
				{
					reference = reference.CustomizePublisher();
				}
				if (reference.ResolveParameter())
				{
					return new ParamUtils.CollectionUtils(this.messageUtils.m_MethodUtils - ((ParamUtils.CollectionUtils)reference).messageUtils.m_MethodUtils);
				}
				if (!reference.InterruptParameter())
				{
					throw new ParamUtils.ExporterUtils();
				}
				return ((ParamUtils.WrapperUtils)reference).OrderUtils(this);
			}

			// Token: 0x060001C7 RID: 455 RVA: 0x0000BE48 File Offset: 0x0000A048
			public override ParamUtils.DescriptorAdvisor ResolvePublisher(ParamUtils.DescriptorAdvisor init)
			{
				if (init.OrderPublisher())
				{
					init = init.CustomizePublisher();
				}
				if (init.ResolveParameter())
				{
					return new ParamUtils.CollectionUtils(checked(this.messageUtils.m_MethodUtils - ((ParamUtils.CollectionUtils)init).messageUtils.m_MethodUtils));
				}
				if (init.InterruptParameter())
				{
					return ((ParamUtils.WrapperUtils)init).SortUtils(this);
				}
				throw new ParamUtils.ExporterUtils();
			}

			// Token: 0x060001C8 RID: 456 RVA: 0x0000BEAC File Offset: 0x0000A0AC
			public override ParamUtils.DescriptorAdvisor InterruptPublisher(ParamUtils.DescriptorAdvisor item)
			{
				if (item.OrderPublisher())
				{
					item = item.CustomizePublisher();
				}
				if (item.ResolveParameter())
				{
					return new ParamUtils.CollectionUtils(checked(this.messageUtils.m_RequestUtils - ((ParamUtils.CollectionUtils)item).messageUtils.m_RequestUtils));
				}
				if (!item.InterruptParameter())
				{
					throw new ParamUtils.ExporterUtils();
				}
				return ((ParamUtils.WrapperUtils)item).CancelUtils(this);
			}

			// Token: 0x060001C9 RID: 457 RVA: 0x0000BF10 File Offset: 0x0000A110
			public override ParamUtils.DescriptorAdvisor CallPublisher(ParamUtils.DescriptorAdvisor value)
			{
				if (value.OrderPublisher())
				{
					value = value.CustomizePublisher();
				}
				if (value.ResolveParameter())
				{
					return new ParamUtils.CollectionUtils(this.messageUtils.m_MethodUtils * ((ParamUtils.CollectionUtils)value).messageUtils.m_MethodUtils);
				}
				if (!value.InterruptParameter())
				{
					throw new ParamUtils.ExporterUtils();
				}
				return ((ParamUtils.WrapperUtils)value).CallPublisher(this);
			}

			// Token: 0x060001CA RID: 458 RVA: 0x0000BF74 File Offset: 0x0000A174
			public override ParamUtils.DescriptorAdvisor FillPublisher(ParamUtils.DescriptorAdvisor task)
			{
				if (task.OrderPublisher())
				{
					task = task.CustomizePublisher();
				}
				if (task.ResolveParameter())
				{
					return new ParamUtils.CollectionUtils(checked(this.messageUtils.m_MethodUtils * ((ParamUtils.CollectionUtils)task).messageUtils.m_MethodUtils));
				}
				if (!task.InterruptParameter())
				{
					throw new ParamUtils.ExporterUtils();
				}
				return ((ParamUtils.WrapperUtils)task).FillPublisher(this);
			}

			// Token: 0x060001CB RID: 459 RVA: 0x0000BFD8 File Offset: 0x0000A1D8
			public override ParamUtils.DescriptorAdvisor QueryPublisher(ParamUtils.DescriptorAdvisor info)
			{
				if (info.OrderPublisher())
				{
					info = info.CustomizePublisher();
				}
				if (info.ResolveParameter())
				{
					return new ParamUtils.CollectionUtils(checked(this.messageUtils.m_RequestUtils * ((ParamUtils.CollectionUtils)info).messageUtils.m_RequestUtils));
				}
				if (!info.InterruptParameter())
				{
					throw new ParamUtils.ExporterUtils();
				}
				return ((ParamUtils.WrapperUtils)info).QueryPublisher(this);
			}

			// Token: 0x060001CC RID: 460 RVA: 0x0000C03C File Offset: 0x0000A23C
			public override ParamUtils.DescriptorAdvisor StopPublisher(ParamUtils.DescriptorAdvisor config)
			{
				if (config.OrderPublisher())
				{
					config = config.CustomizePublisher();
				}
				if (config.ResolveParameter())
				{
					return new ParamUtils.CollectionUtils(this.messageUtils.m_MethodUtils / ((ParamUtils.CollectionUtils)config).messageUtils.m_MethodUtils);
				}
				if (config.InterruptParameter())
				{
					return ((ParamUtils.WrapperUtils)config).AddUtils(this);
				}
				throw new ParamUtils.ExporterUtils();
			}

			// Token: 0x060001CD RID: 461 RVA: 0x0000C0A0 File Offset: 0x0000A2A0
			public override ParamUtils.DescriptorAdvisor UpdatePublisher(ParamUtils.DescriptorAdvisor i)
			{
				if (i.OrderPublisher())
				{
					i = i.CustomizePublisher();
				}
				if (i.ResolveParameter())
				{
					return new ParamUtils.CollectionUtils(this.messageUtils.m_RequestUtils / ((ParamUtils.CollectionUtils)i).messageUtils.m_RequestUtils);
				}
				if (i.InterruptParameter())
				{
					return ((ParamUtils.WrapperUtils)i).CheckUtils(this);
				}
				throw new ParamUtils.ExporterUtils();
			}

			// Token: 0x060001CE RID: 462 RVA: 0x0000C104 File Offset: 0x0000A304
			public override ParamUtils.DescriptorAdvisor ManagePublisher(ParamUtils.DescriptorAdvisor asset)
			{
				if (asset.OrderPublisher())
				{
					asset = asset.CustomizePublisher();
				}
				if (asset.ResolveParameter())
				{
					return new ParamUtils.CollectionUtils(this.messageUtils.m_MethodUtils % ((ParamUtils.CollectionUtils)asset).messageUtils.m_MethodUtils);
				}
				if (!asset.InterruptParameter())
				{
					throw new ParamUtils.ExporterUtils();
				}
				return ((ParamUtils.WrapperUtils)asset).DefineUtils(this);
			}

			// Token: 0x060001CF RID: 463 RVA: 0x0000C168 File Offset: 0x0000A368
			public override ParamUtils.DescriptorAdvisor DisablePublisher(ParamUtils.DescriptorAdvisor asset)
			{
				if (asset.OrderPublisher())
				{
					asset = asset.CustomizePublisher();
				}
				if (asset.ResolveParameter())
				{
					return new ParamUtils.CollectionUtils(this.messageUtils.m_RequestUtils % ((ParamUtils.CollectionUtils)asset).messageUtils.m_RequestUtils);
				}
				if (!asset.InterruptParameter())
				{
					throw new ParamUtils.ExporterUtils();
				}
				return ((ParamUtils.WrapperUtils)asset).ViewUtils(this);
			}

			// Token: 0x060001D0 RID: 464 RVA: 0x0000C1CC File Offset: 0x0000A3CC
			public override ParamUtils.DescriptorAdvisor ComputePublisher(ParamUtils.DescriptorAdvisor v)
			{
				if (v.OrderPublisher())
				{
					v = v.CustomizePublisher();
				}
				if (v.ResolveParameter())
				{
					return new ParamUtils.CollectionUtils(this.messageUtils.m_MethodUtils & ((ParamUtils.CollectionUtils)v).messageUtils.m_MethodUtils);
				}
				if (v.InterruptParameter())
				{
					return ((ParamUtils.WrapperUtils)v).ComputePublisher(this);
				}
				throw new ParamUtils.ExporterUtils();
			}

			// Token: 0x060001D1 RID: 465 RVA: 0x0000C230 File Offset: 0x0000A430
			public override ParamUtils.DescriptorAdvisor PostPublisher(ParamUtils.DescriptorAdvisor def)
			{
				if (def.OrderPublisher())
				{
					def = def.CustomizePublisher();
				}
				if (def.ResolveParameter())
				{
					return new ParamUtils.CollectionUtils(this.messageUtils.m_MethodUtils | ((ParamUtils.CollectionUtils)def).messageUtils.m_MethodUtils);
				}
				if (def.InterruptParameter())
				{
					return ((ParamUtils.WrapperUtils)def).PostPublisher(this);
				}
				throw new ParamUtils.ExporterUtils();
			}

			// Token: 0x060001D2 RID: 466 RVA: 0x00002D9D File Offset: 0x00000F9D
			public override ParamUtils.DescriptorAdvisor LoginPublisher()
			{
				return new ParamUtils.CollectionUtils(~this.messageUtils.m_MethodUtils);
			}

			// Token: 0x060001D3 RID: 467 RVA: 0x0000C294 File Offset: 0x0000A494
			public override ParamUtils.DescriptorAdvisor AssetPublisher(ParamUtils.DescriptorAdvisor task)
			{
				if (task.OrderPublisher())
				{
					task = task.CustomizePublisher();
				}
				if (task.ResolveParameter())
				{
					return new ParamUtils.CollectionUtils(this.messageUtils.m_MethodUtils ^ ((ParamUtils.CollectionUtils)task).messageUtils.m_MethodUtils);
				}
				if (!task.InterruptParameter())
				{
					throw new ParamUtils.ExporterUtils();
				}
				return ((ParamUtils.WrapperUtils)task).AssetPublisher(this);
			}

			// Token: 0x060001D4 RID: 468 RVA: 0x0000C2F8 File Offset: 0x0000A4F8
			public override ParamUtils.DescriptorAdvisor NewPublisher(ParamUtils.DescriptorAdvisor i)
			{
				if (i.OrderPublisher())
				{
					i = i.CustomizePublisher();
				}
				if (i.ResolveParameter())
				{
					return new ParamUtils.CollectionUtils(this.messageUtils.m_MethodUtils << ((ParamUtils.CollectionUtils)i).messageUtils.m_MethodUtils);
				}
				if (!i.InterruptParameter())
				{
					throw new ParamUtils.ExporterUtils();
				}
				return ((ParamUtils.WrapperUtils)i).SetupAdvisor(this);
			}

			// Token: 0x060001D5 RID: 469 RVA: 0x0000C35C File Offset: 0x0000A55C
			public override ParamUtils.DescriptorAdvisor SelectPublisher(ParamUtils.DescriptorAdvisor ident)
			{
				if (ident.OrderPublisher())
				{
					ident = ident.CustomizePublisher();
				}
				if (ident.ResolveParameter())
				{
					return new ParamUtils.CollectionUtils(this.messageUtils.m_MethodUtils >> ((ParamUtils.CollectionUtils)ident).messageUtils.m_MethodUtils);
				}
				if (!ident.InterruptParameter())
				{
					throw new ParamUtils.ExporterUtils();
				}
				return ((ParamUtils.WrapperUtils)ident).PublishAdvisor(this);
			}

			// Token: 0x060001D6 RID: 470 RVA: 0x0000C3C0 File Offset: 0x0000A5C0
			public override ParamUtils.DescriptorAdvisor RemovePublisher(ParamUtils.DescriptorAdvisor config)
			{
				if (config.OrderPublisher())
				{
					config = config.CustomizePublisher();
				}
				if (config.ResolveParameter())
				{
					return new ParamUtils.CollectionUtils(this.messageUtils.m_RequestUtils >> ((ParamUtils.CollectionUtils)config).messageUtils.m_MethodUtils);
				}
				if (config.InterruptParameter())
				{
					return ((ParamUtils.WrapperUtils)config).RevertUtils(this);
				}
				throw new ParamUtils.ExporterUtils();
			}

			// Token: 0x060001D7 RID: 471 RVA: 0x0000C424 File Offset: 0x0000A624
			public override string ToString()
			{
				ParamUtils.ProcessUtils broadcasterUtils = this._BroadcasterUtils;
				switch (broadcasterUtils)
				{
				case (ParamUtils.ProcessUtils)1:
				case (ParamUtils.ProcessUtils)3:
				case (ParamUtils.ProcessUtils)5:
					goto IL_3E;
				case (ParamUtils.ProcessUtils)2:
				case (ParamUtils.ProcessUtils)4:
					break;
				default:
					if (broadcasterUtils == (ParamUtils.ProcessUtils)11)
					{
						goto IL_3E;
					}
					break;
				}
				return this.messageUtils.m_RequestUtils.ToString();
				IL_3E:
				return this.messageUtils.m_MethodUtils.ToString();
			}

			// Token: 0x060001D8 RID: 472 RVA: 0x00002DB0 File Offset: 0x00000FB0
			internal override ParamUtils.DescriptorAdvisor CustomizePublisher()
			{
				return this;
			}

			// Token: 0x060001D9 RID: 473 RVA: 0x00002728 File Offset: 0x00000928
			internal override bool ConnectPublisher()
			{
				return true;
			}

			// Token: 0x060001DA RID: 474 RVA: 0x0000C480 File Offset: 0x0000A680
			internal override bool ValidatePublisher(ParamUtils.DescriptorAdvisor value)
			{
				if (value.MoveParameter())
				{
					return ((ParamUtils.WorkerAdvisor)value).ValidatePublisher(this);
				}
				if (value.OrderPublisher())
				{
					return ((ParamUtils.ProducerUtils)value).ValidatePublisher(this);
				}
				ParamUtils.DescriptorAdvisor descriptorAdvisor = value.CustomizePublisher();
				if (!descriptorAdvisor.ConnectPublisher())
				{
					return false;
				}
				if (descriptorAdvisor.CallParameter())
				{
					return false;
				}
				if (!descriptorAdvisor.ResolveParameter())
				{
					return ((ParamUtils.WrapperUtils)descriptorAdvisor).ValidatePublisher(this);
				}
				return this.messageUtils.m_MethodUtils == ((ParamUtils.CollectionUtils)descriptorAdvisor).messageUtils.m_MethodUtils;
			}

			// Token: 0x060001DB RID: 475 RVA: 0x0000C50C File Offset: 0x0000A70C
			private static ParamUtils.ComparatorUtils LogoutUtils(ParamUtils.DescriptorAdvisor v)
			{
				ParamUtils.ComparatorUtils comparatorUtils = v as ParamUtils.ComparatorUtils;
				if (comparatorUtils == null && v.OrderPublisher())
				{
					comparatorUtils = (v.CustomizePublisher() as ParamUtils.ComparatorUtils);
				}
				return comparatorUtils;
			}

			// Token: 0x060001DC RID: 476 RVA: 0x0000C53C File Offset: 0x0000A73C
			internal override bool ResetPublisher(ParamUtils.DescriptorAdvisor key)
			{
				if (key.MoveParameter())
				{
					return false;
				}
				if (key.OrderPublisher())
				{
					return ((ParamUtils.ProducerUtils)key).ResetPublisher(this);
				}
				ParamUtils.DescriptorAdvisor descriptorAdvisor = key.CustomizePublisher();
				if (!descriptorAdvisor.ConnectPublisher())
				{
					return false;
				}
				if (descriptorAdvisor.CallParameter())
				{
					return false;
				}
				if (descriptorAdvisor.ResolveParameter())
				{
					return this.messageUtils.m_RequestUtils != ((ParamUtils.CollectionUtils)descriptorAdvisor).messageUtils.m_RequestUtils;
				}
				return ((ParamUtils.WrapperUtils)descriptorAdvisor).ResetPublisher(this);
			}

			// Token: 0x060001DD RID: 477 RVA: 0x0000C5C0 File Offset: 0x0000A7C0
			public override bool ComparePublisher(ParamUtils.DescriptorAdvisor info)
			{
				if (info.OrderPublisher())
				{
					info = info.CustomizePublisher();
				}
				if (info.ResolveParameter())
				{
					return this.messageUtils.m_MethodUtils >= ((ParamUtils.CollectionUtils)info).messageUtils.m_MethodUtils;
				}
				if (!info.InterruptParameter())
				{
					throw new ParamUtils.ExporterUtils();
				}
				return ((ParamUtils.WrapperUtils)info).FindPublisher(this);
			}

			// Token: 0x060001DE RID: 478 RVA: 0x0000C620 File Offset: 0x0000A820
			public override bool PrintPublisher(ParamUtils.DescriptorAdvisor value)
			{
				if (value.OrderPublisher())
				{
					value = value.CustomizePublisher();
				}
				if (value.ResolveParameter())
				{
					return this.messageUtils.m_RequestUtils >= ((ParamUtils.CollectionUtils)value).messageUtils.m_RequestUtils;
				}
				if (!value.InterruptParameter())
				{
					throw new ParamUtils.ExporterUtils();
				}
				return ((ParamUtils.WrapperUtils)value).TestPublisher(this);
			}

			// Token: 0x060001DF RID: 479 RVA: 0x0000C680 File Offset: 0x0000A880
			public override bool PreparePublisher(ParamUtils.DescriptorAdvisor reference)
			{
				if (reference.OrderPublisher())
				{
					reference = reference.CustomizePublisher();
				}
				if (reference.ResolveParameter())
				{
					return this.messageUtils.m_MethodUtils > ((ParamUtils.CollectionUtils)reference).messageUtils.m_MethodUtils;
				}
				if (!reference.InterruptParameter())
				{
					throw new ParamUtils.ExporterUtils();
				}
				return ((ParamUtils.WrapperUtils)reference).RatePublisher(this);
			}

			// Token: 0x060001E0 RID: 480 RVA: 0x0000C6E0 File Offset: 0x0000A8E0
			public override bool LogoutPublisher(ParamUtils.DescriptorAdvisor ident)
			{
				if (ident.OrderPublisher())
				{
					ident = ident.CustomizePublisher();
				}
				if (ident.ResolveParameter())
				{
					return this.messageUtils.m_RequestUtils > ((ParamUtils.CollectionUtils)ident).messageUtils.m_RequestUtils;
				}
				if (ident.InterruptParameter())
				{
					return ((ParamUtils.WrapperUtils)ident).RestartPublisher(this);
				}
				throw new ParamUtils.ExporterUtils();
			}

			// Token: 0x060001E1 RID: 481 RVA: 0x0000C740 File Offset: 0x0000A940
			public override bool FindPublisher(ParamUtils.DescriptorAdvisor i)
			{
				if (i.OrderPublisher())
				{
					i = i.CustomizePublisher();
				}
				if (i.ResolveParameter())
				{
					return this.messageUtils.m_MethodUtils <= ((ParamUtils.CollectionUtils)i).messageUtils.m_MethodUtils;
				}
				if (!i.InterruptParameter())
				{
					throw new ParamUtils.ExporterUtils();
				}
				return ((ParamUtils.WrapperUtils)i).ComparePublisher(this);
			}

			// Token: 0x060001E2 RID: 482 RVA: 0x0000C7A0 File Offset: 0x0000A9A0
			public override bool TestPublisher(ParamUtils.DescriptorAdvisor spec)
			{
				if (spec.OrderPublisher())
				{
					spec = spec.CustomizePublisher();
				}
				if (spec.ResolveParameter())
				{
					return this.messageUtils.m_RequestUtils <= ((ParamUtils.CollectionUtils)spec).messageUtils.m_RequestUtils;
				}
				if (!spec.InterruptParameter())
				{
					throw new ParamUtils.ExporterUtils();
				}
				return ((ParamUtils.WrapperUtils)spec).PrintPublisher(this);
			}

			// Token: 0x060001E3 RID: 483 RVA: 0x0000C800 File Offset: 0x0000AA00
			public override bool RatePublisher(ParamUtils.DescriptorAdvisor def)
			{
				if (def.OrderPublisher())
				{
					def = def.CustomizePublisher();
				}
				if (def.ResolveParameter())
				{
					return this.messageUtils.m_MethodUtils < ((ParamUtils.CollectionUtils)def).messageUtils.m_MethodUtils;
				}
				if (!def.InterruptParameter())
				{
					throw new ParamUtils.ExporterUtils();
				}
				return ((ParamUtils.WrapperUtils)def).PreparePublisher(this);
			}

			// Token: 0x060001E4 RID: 484 RVA: 0x0000C860 File Offset: 0x0000AA60
			public override bool RestartPublisher(ParamUtils.DescriptorAdvisor instance)
			{
				if (instance.OrderPublisher())
				{
					instance = instance.CustomizePublisher();
				}
				if (instance.ResolveParameter())
				{
					return this.messageUtils.m_RequestUtils < ((ParamUtils.CollectionUtils)instance).messageUtils.m_RequestUtils;
				}
				if (!instance.InterruptParameter())
				{
					throw new ParamUtils.ExporterUtils();
				}
				return ((ParamUtils.WrapperUtils)instance).LogoutPublisher(this);
			}

			// Token: 0x04000086 RID: 134
			public ParamUtils.ComposerUtils messageUtils;

			// Token: 0x04000087 RID: 135
			public ParamUtils.ProcessUtils _BroadcasterUtils;
		}

		// Token: 0x0200002A RID: 42
		[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Explicit)]
		private struct WatcherUtils
		{
			// Token: 0x04000088 RID: 136
			[System.Runtime.InteropServices.FieldOffset(0)]
			public byte infoUtils;

			// Token: 0x04000089 RID: 137
			[System.Runtime.InteropServices.FieldOffset(0)]
			public sbyte _FilterUtils;

			// Token: 0x0400008A RID: 138
			[System.Runtime.InteropServices.FieldOffset(0)]
			public ushort _TestsUtils;

			// Token: 0x0400008B RID: 139
			[System.Runtime.InteropServices.FieldOffset(0)]
			public short m_ServerUtils;

			// Token: 0x0400008C RID: 140
			[System.Runtime.InteropServices.FieldOffset(0)]
			public uint m_IndexerUtils;

			// Token: 0x0400008D RID: 141
			[System.Runtime.InteropServices.FieldOffset(0)]
			public int configurationUtils;

			// Token: 0x0400008E RID: 142
			[System.Runtime.InteropServices.FieldOffset(0)]
			public ulong decoratorUtils;

			// Token: 0x0400008F RID: 143
			[System.Runtime.InteropServices.FieldOffset(0)]
			public long m_ProcessorUtils;
		}

		// Token: 0x0200002B RID: 43
		private class ReponseUtils : ParamUtils.ComparatorUtils
		{
			// Token: 0x060001E5 RID: 485 RVA: 0x0000C8C0 File Offset: 0x0000AAC0
			internal override void CompareDatabase(ParamUtils.DescriptorAdvisor def)
			{
				this.m_ContextUtils = ((ParamUtils.ReponseUtils)def).m_ContextUtils;
				this._ExceptionUtils = ((ParamUtils.ReponseUtils)def)._ExceptionUtils;
			}

			// Token: 0x060001E6 RID: 486 RVA: 0x0000B390 File Offset: 0x00009590
			internal override void PrintDatabase(ParamUtils.DescriptorAdvisor info)
			{
				this.CompareDatabase(info);
			}

			// Token: 0x060001E7 RID: 487 RVA: 0x0000C8F0 File Offset: 0x0000AAF0
			public ReponseUtils(long setup)
			{
				this._ProxyAdvisor = (ParamUtils.CopyOption)2;
				this.m_ContextUtils.m_ProcessorUtils = setup;
				this._ExceptionUtils = (ParamUtils.ProcessUtils)7;
			}

			// Token: 0x060001E8 RID: 488 RVA: 0x0000C920 File Offset: 0x0000AB20
			public ReponseUtils(ParamUtils.ReponseUtils param)
			{
				this._ProxyAdvisor = param._ProxyAdvisor;
				this.m_ContextUtils.m_ProcessorUtils = param.m_ContextUtils.m_ProcessorUtils;
				this._ExceptionUtils = param._ExceptionUtils;
			}

			// Token: 0x060001E9 RID: 489 RVA: 0x00002DB3 File Offset: 0x00000FB3
			public override ParamUtils.ComparatorUtils PrepareDatabase()
			{
				return new ParamUtils.ReponseUtils(this);
			}

			// Token: 0x060001EA RID: 490 RVA: 0x0000C964 File Offset: 0x0000AB64
			public ReponseUtils(long position_item, ParamUtils.ProcessUtils attr)
			{
				this._ProxyAdvisor = (ParamUtils.CopyOption)2;
				this.m_ContextUtils.m_ProcessorUtils = position_item;
				this._ExceptionUtils = attr;
			}

			// Token: 0x060001EB RID: 491 RVA: 0x0000C994 File Offset: 0x0000AB94
			public ReponseUtils(ulong keyID)
			{
				this._ProxyAdvisor = (ParamUtils.CopyOption)2;
				this.m_ContextUtils.decoratorUtils = keyID;
				this._ExceptionUtils = (ParamUtils.ProcessUtils)8;
			}

			// Token: 0x060001EC RID: 492 RVA: 0x0000C9C4 File Offset: 0x0000ABC4
			public ReponseUtils(ulong i_Position, ParamUtils.ProcessUtils ivk)
			{
				this._ProxyAdvisor = (ParamUtils.CopyOption)2;
				this.m_ContextUtils.decoratorUtils = i_Position;
				this._ExceptionUtils = ivk;
			}

			// Token: 0x060001ED RID: 493 RVA: 0x0000C9F4 File Offset: 0x0000ABF4
			public override bool LogoutDatabase()
			{
				if (this._ExceptionUtils == (ParamUtils.ProcessUtils)7)
				{
					return this.m_ContextUtils.m_ProcessorUtils == 0L;
				}
				return this.m_ContextUtils.decoratorUtils == 0UL;
			}

			// Token: 0x060001EE RID: 494 RVA: 0x00002B72 File Offset: 0x00000D72
			public override bool FindDatabase()
			{
				return !this.LogoutDatabase();
			}

			// Token: 0x060001EF RID: 495 RVA: 0x0000CA38 File Offset: 0x0000AC38
			public override ParamUtils.DescriptorAdvisor TestDatabase(ParamUtils.ProcessUtils param)
			{
				switch (param)
				{
				case (ParamUtils.ProcessUtils)1:
					return this.InstantiateDatabase();
				case (ParamUtils.ProcessUtils)2:
					return this.OrderDatabase();
				case (ParamUtils.ProcessUtils)3:
					return this.SortDatabase();
				case (ParamUtils.ProcessUtils)4:
					return this.CancelDatabase();
				case (ParamUtils.ProcessUtils)5:
					return this.AddDatabase();
				case (ParamUtils.ProcessUtils)6:
					return this.CheckDatabase();
				case (ParamUtils.ProcessUtils)7:
					return this.DefineDatabase();
				case (ParamUtils.ProcessUtils)8:
					return this.ViewDatabase();
				case (ParamUtils.ProcessUtils)11:
					return this.RestartDatabase();
				case (ParamUtils.ProcessUtils)15:
					return this.RateUtils();
				case (ParamUtils.ProcessUtils)16:
					return this.PrepareDatabase();
				}
				throw new System.Exception(((ParamUtils.CancellationMode)4).ToString());
			}

			// Token: 0x060001F0 RID: 496 RVA: 0x0000CAF4 File Offset: 0x0000ACF4
			internal override object RateDatabase(System.Type info)
			{
				if (info != null && info.IsByRef)
				{
					info = info.GetElementType();
				}
				if (info == null || info == typeof(object))
				{
					switch (this._ExceptionUtils)
					{
					case (ParamUtils.ProcessUtils)1:
						return this.m_ContextUtils._FilterUtils;
					case (ParamUtils.ProcessUtils)2:
						return this.m_ContextUtils.infoUtils;
					case (ParamUtils.ProcessUtils)3:
						return this.m_ContextUtils.m_ServerUtils;
					case (ParamUtils.ProcessUtils)4:
						return this.m_ContextUtils._TestsUtils;
					case (ParamUtils.ProcessUtils)5:
						return this.m_ContextUtils.configurationUtils;
					case (ParamUtils.ProcessUtils)6:
						return this.m_ContextUtils.m_IndexerUtils;
					case (ParamUtils.ProcessUtils)7:
						return this.m_ContextUtils.m_ProcessorUtils;
					case (ParamUtils.ProcessUtils)8:
						return this.m_ContextUtils.decoratorUtils;
					case (ParamUtils.ProcessUtils)11:
						return this.FindDatabase();
					case (ParamUtils.ProcessUtils)15:
						return (char)this.m_ContextUtils.configurationUtils;
					}
					return this.m_ContextUtils.m_ProcessorUtils;
				}
				if (info == typeof(int))
				{
					return this.m_ContextUtils.configurationUtils;
				}
				if (info == typeof(uint))
				{
					return this.m_ContextUtils.m_IndexerUtils;
				}
				if (info == typeof(short))
				{
					return this.m_ContextUtils.m_ServerUtils;
				}
				if (info == typeof(ushort))
				{
					return this.m_ContextUtils._TestsUtils;
				}
				if (info == typeof(byte))
				{
					return this.m_ContextUtils.infoUtils;
				}
				if (info == typeof(sbyte))
				{
					return this.m_ContextUtils._FilterUtils;
				}
				if (info == typeof(bool))
				{
					return !this.LogoutDatabase();
				}
				if (info == typeof(long))
				{
					return this.m_ContextUtils.m_ProcessorUtils;
				}
				if (info == typeof(ulong))
				{
					return this.m_ContextUtils.decoratorUtils;
				}
				if (info == typeof(char))
				{
					return (char)this.m_ContextUtils.m_ProcessorUtils;
				}
				if (info.IsEnum)
				{
					return this.FindUtils(info);
				}
				throw new ParamUtils.ExporterUtils();
			}

			// Token: 0x060001F1 RID: 497 RVA: 0x0000CDC8 File Offset: 0x0000AFC8
			internal object FindUtils(System.Type reference)
			{
				System.Type underlyingType = System.Enum.GetUnderlyingType(reference);
				if (underlyingType == typeof(int))
				{
					return System.Enum.ToObject(reference, this.m_ContextUtils.configurationUtils);
				}
				if (underlyingType == typeof(uint))
				{
					return System.Enum.ToObject(reference, this.m_ContextUtils.m_IndexerUtils);
				}
				if (underlyingType == typeof(short))
				{
					return System.Enum.ToObject(reference, this.m_ContextUtils.m_ServerUtils);
				}
				if (underlyingType == typeof(ushort))
				{
					return System.Enum.ToObject(reference, this.m_ContextUtils._TestsUtils);
				}
				if (underlyingType == typeof(byte))
				{
					return System.Enum.ToObject(reference, this.m_ContextUtils.infoUtils);
				}
				if (underlyingType == typeof(sbyte))
				{
					return System.Enum.ToObject(reference, this.m_ContextUtils._FilterUtils);
				}
				if (underlyingType == typeof(long))
				{
					return System.Enum.ToObject(reference, this.m_ContextUtils.m_ProcessorUtils);
				}
				if (underlyingType == typeof(ulong))
				{
					return System.Enum.ToObject(reference, this.m_ContextUtils.decoratorUtils);
				}
				if (underlyingType == typeof(char))
				{
					return System.Enum.ToObject(reference, (ushort)this.m_ContextUtils.configurationUtils);
				}
				return System.Enum.ToObject(reference, this.m_ContextUtils.m_ProcessorUtils);
			}

			// Token: 0x060001F2 RID: 498 RVA: 0x0000CF48 File Offset: 0x0000B148
			public override ParamUtils.CollectionUtils RestartDatabase()
			{
				return new ParamUtils.CollectionUtils((!this.LogoutDatabase()) ? 1 : 0);
			}

			// Token: 0x060001F3 RID: 499 RVA: 0x00002B7D File Offset: 0x00000D7D
			internal override bool InsertDatabase()
			{
				return this.FindDatabase();
			}

			// Token: 0x060001F4 RID: 500 RVA: 0x00002DBB File Offset: 0x00000FBB
			public ParamUtils.CollectionUtils RateUtils()
			{
				return new ParamUtils.CollectionUtils((int)this.m_ContextUtils._FilterUtils, (ParamUtils.ProcessUtils)15);
			}

			// Token: 0x060001F5 RID: 501 RVA: 0x00002DCF File Offset: 0x00000FCF
			public override ParamUtils.CollectionUtils InstantiateDatabase()
			{
				return new ParamUtils.CollectionUtils((int)this.m_ContextUtils._FilterUtils, (ParamUtils.ProcessUtils)1);
			}

			// Token: 0x060001F6 RID: 502 RVA: 0x00002DE2 File Offset: 0x00000FE2
			public override ParamUtils.CollectionUtils OrderDatabase()
			{
				return new ParamUtils.CollectionUtils((uint)this.m_ContextUtils.infoUtils, (ParamUtils.ProcessUtils)2);
			}

			// Token: 0x060001F7 RID: 503 RVA: 0x00002DF5 File Offset: 0x00000FF5
			public override ParamUtils.CollectionUtils SortDatabase()
			{
				return new ParamUtils.CollectionUtils((int)this.m_ContextUtils.m_ServerUtils, (ParamUtils.ProcessUtils)3);
			}

			// Token: 0x060001F8 RID: 504 RVA: 0x00002E08 File Offset: 0x00001008
			public override ParamUtils.CollectionUtils CancelDatabase()
			{
				return new ParamUtils.CollectionUtils((uint)this.m_ContextUtils._TestsUtils, (ParamUtils.ProcessUtils)4);
			}

			// Token: 0x060001F9 RID: 505 RVA: 0x00002E1B File Offset: 0x0000101B
			public override ParamUtils.CollectionUtils AddDatabase()
			{
				return new ParamUtils.CollectionUtils(this.m_ContextUtils.configurationUtils, (ParamUtils.ProcessUtils)5);
			}

			// Token: 0x060001FA RID: 506 RVA: 0x00002E2E File Offset: 0x0000102E
			public override ParamUtils.CollectionUtils CheckDatabase()
			{
				return new ParamUtils.CollectionUtils(this.m_ContextUtils.m_IndexerUtils, (ParamUtils.ProcessUtils)6);
			}

			// Token: 0x060001FB RID: 507 RVA: 0x00002E41 File Offset: 0x00001041
			public override ParamUtils.ReponseUtils DefineDatabase()
			{
				return new ParamUtils.ReponseUtils(this.m_ContextUtils.m_ProcessorUtils, (ParamUtils.ProcessUtils)7);
			}

			// Token: 0x060001FC RID: 508 RVA: 0x00002E54 File Offset: 0x00001054
			public override ParamUtils.ReponseUtils ViewDatabase()
			{
				return new ParamUtils.ReponseUtils(this.m_ContextUtils.decoratorUtils, (ParamUtils.ProcessUtils)8);
			}

			// Token: 0x060001FD RID: 509 RVA: 0x00002C33 File Offset: 0x00000E33
			public override ParamUtils.CollectionUtils RevertDatabase()
			{
				return this.InstantiateDatabase();
			}

			// Token: 0x060001FE RID: 510 RVA: 0x00002C3B File Offset: 0x00000E3B
			public override ParamUtils.CollectionUtils PublishPublisher()
			{
				return this.SortDatabase();
			}

			// Token: 0x060001FF RID: 511 RVA: 0x00002C43 File Offset: 0x00000E43
			public override ParamUtils.CollectionUtils SetupPublisher()
			{
				return this.AddDatabase();
			}

			// Token: 0x06000200 RID: 512 RVA: 0x00002C4B File Offset: 0x00000E4B
			public override ParamUtils.ReponseUtils SetPublisher()
			{
				return this.DefineDatabase();
			}

			// Token: 0x06000201 RID: 513 RVA: 0x00002C53 File Offset: 0x00000E53
			public override ParamUtils.CollectionUtils CountPublisher()
			{
				return this.OrderDatabase();
			}

			// Token: 0x06000202 RID: 514 RVA: 0x00002C5B File Offset: 0x00000E5B
			public override ParamUtils.CollectionUtils ReflectPublisher()
			{
				return this.CancelDatabase();
			}

			// Token: 0x06000203 RID: 515 RVA: 0x00002C63 File Offset: 0x00000E63
			public override ParamUtils.CollectionUtils WritePublisher()
			{
				return this.CheckDatabase();
			}

			// Token: 0x06000204 RID: 516 RVA: 0x00002C6B File Offset: 0x00000E6B
			public override ParamUtils.ReponseUtils ClonePublisher()
			{
				return this.ViewDatabase();
			}

			// Token: 0x06000205 RID: 517 RVA: 0x00002E67 File Offset: 0x00001067
			public override ParamUtils.CollectionUtils VisitPublisher()
			{
				return new ParamUtils.CollectionUtils((int)(checked((sbyte)this.m_ContextUtils.m_ProcessorUtils)), (ParamUtils.ProcessUtils)1);
			}

			// Token: 0x06000206 RID: 518 RVA: 0x00002E7B File Offset: 0x0000107B
			public override ParamUtils.CollectionUtils MapPublisher()
			{
				return new ParamUtils.CollectionUtils((int)(checked((sbyte)this.m_ContextUtils.decoratorUtils)), (ParamUtils.ProcessUtils)1);
			}

			// Token: 0x06000207 RID: 519 RVA: 0x00002E8F File Offset: 0x0000108F
			public override ParamUtils.CollectionUtils VerifyPublisher()
			{
				return new ParamUtils.CollectionUtils((int)(checked((short)this.m_ContextUtils.m_ProcessorUtils)), (ParamUtils.ProcessUtils)3);
			}

			// Token: 0x06000208 RID: 520 RVA: 0x00002EA3 File Offset: 0x000010A3
			public override ParamUtils.CollectionUtils ChangePublisher()
			{
				return new ParamUtils.CollectionUtils((int)(checked((short)this.m_ContextUtils.decoratorUtils)), (ParamUtils.ProcessUtils)3);
			}

			// Token: 0x06000209 RID: 521 RVA: 0x00002EB7 File Offset: 0x000010B7
			public override ParamUtils.CollectionUtils ListPublisher()
			{
				return new ParamUtils.CollectionUtils(checked((int)this.m_ContextUtils.m_ProcessorUtils), (ParamUtils.ProcessUtils)5);
			}

			// Token: 0x0600020A RID: 522 RVA: 0x00002ECB File Offset: 0x000010CB
			public override ParamUtils.CollectionUtils IncludePublisher()
			{
				return new ParamUtils.CollectionUtils(checked((int)this.m_ContextUtils.decoratorUtils), (ParamUtils.ProcessUtils)5);
			}

			// Token: 0x0600020B RID: 523 RVA: 0x00002E41 File Offset: 0x00001041
			public override ParamUtils.ReponseUtils CreatePublisher()
			{
				return new ParamUtils.ReponseUtils(this.m_ContextUtils.m_ProcessorUtils, (ParamUtils.ProcessUtils)7);
			}

			// Token: 0x0600020C RID: 524 RVA: 0x00002EDF File Offset: 0x000010DF
			public override ParamUtils.ReponseUtils EnablePublisher()
			{
				return new ParamUtils.ReponseUtils(checked((long)this.m_ContextUtils.decoratorUtils), (ParamUtils.ProcessUtils)7);
			}

			// Token: 0x0600020D RID: 525 RVA: 0x00002EF3 File Offset: 0x000010F3
			public override ParamUtils.CollectionUtils PatchPublisher()
			{
				return new ParamUtils.CollectionUtils((int)(checked((byte)this.m_ContextUtils.m_ProcessorUtils)), (ParamUtils.ProcessUtils)2);
			}

			// Token: 0x0600020E RID: 526 RVA: 0x00002F07 File Offset: 0x00001107
			public override ParamUtils.CollectionUtils ForgotPublisher()
			{
				return new ParamUtils.CollectionUtils((int)(checked((byte)this.m_ContextUtils.decoratorUtils)), (ParamUtils.ProcessUtils)2);
			}

			// Token: 0x0600020F RID: 527 RVA: 0x00002F1B File Offset: 0x0000111B
			public override ParamUtils.CollectionUtils InitPublisher()
			{
				return new ParamUtils.CollectionUtils((int)(checked((ushort)this.m_ContextUtils.m_ProcessorUtils)), (ParamUtils.ProcessUtils)4);
			}

			// Token: 0x06000210 RID: 528 RVA: 0x00002F2F File Offset: 0x0000112F
			public override ParamUtils.CollectionUtils CollectPublisher()
			{
				return new ParamUtils.CollectionUtils((int)(checked((ushort)this.m_ContextUtils.decoratorUtils)), (ParamUtils.ProcessUtils)4);
			}

			// Token: 0x06000211 RID: 529 RVA: 0x00002F43 File Offset: 0x00001143
			public override ParamUtils.CollectionUtils ConcatPublisher()
			{
				return new ParamUtils.CollectionUtils(checked((uint)this.m_ContextUtils.m_ProcessorUtils), (ParamUtils.ProcessUtils)6);
			}

			// Token: 0x06000212 RID: 530 RVA: 0x00002F57 File Offset: 0x00001157
			public override ParamUtils.CollectionUtils InvokePublisher()
			{
				return new ParamUtils.CollectionUtils(checked((uint)this.m_ContextUtils.decoratorUtils), (ParamUtils.ProcessUtils)6);
			}

			// Token: 0x06000213 RID: 531 RVA: 0x00002F6B File Offset: 0x0000116B
			public override ParamUtils.ReponseUtils AwakePublisher()
			{
				return new ParamUtils.ReponseUtils(checked((ulong)this.m_ContextUtils.m_ProcessorUtils), (ParamUtils.ProcessUtils)8);
			}

			// Token: 0x06000214 RID: 532 RVA: 0x00002E54 File Offset: 0x00001054
			public override ParamUtils.ReponseUtils FlushPublisher()
			{
				return new ParamUtils.ReponseUtils(this.m_ContextUtils.decoratorUtils, (ParamUtils.ProcessUtils)8);
			}

			// Token: 0x06000215 RID: 533 RVA: 0x00002F7F File Offset: 0x0000117F
			public override ParamUtils.CreatorUtils PopPublisher()
			{
				return new ParamUtils.CreatorUtils((float)this.m_ContextUtils.m_ProcessorUtils);
			}

			// Token: 0x06000216 RID: 534 RVA: 0x00002F92 File Offset: 0x00001192
			public override ParamUtils.CreatorUtils RegisterPublisher()
			{
				return new ParamUtils.CreatorUtils((double)this.m_ContextUtils.m_ProcessorUtils);
			}

			// Token: 0x06000217 RID: 535 RVA: 0x00002FA5 File Offset: 0x000011A5
			public override ParamUtils.CreatorUtils CalcPublisher()
			{
				return new ParamUtils.CreatorUtils(this.m_ContextUtils.decoratorUtils);
			}

			// Token: 0x06000218 RID: 536 RVA: 0x0000BAB8 File Offset: 0x00009CB8
			public override ParamUtils.WrapperUtils DestroyPublisher()
			{
				if (System.IntPtr.Size == 8)
				{
					return new ParamUtils.WrapperUtils(this.SetPublisher().m_ContextUtils.m_ProcessorUtils);
				}
				return new ParamUtils.WrapperUtils((long)this.SetupPublisher().messageUtils.m_MethodUtils);
			}

			// Token: 0x06000219 RID: 537 RVA: 0x0000BAFC File Offset: 0x00009CFC
			public override ParamUtils.WrapperUtils GetPublisher()
			{
				if (System.IntPtr.Size == 8)
				{
					return new ParamUtils.WrapperUtils(this.ClonePublisher().m_ContextUtils.decoratorUtils);
				}
				return new ParamUtils.WrapperUtils((ulong)this.WritePublisher().messageUtils.m_RequestUtils);
			}

			// Token: 0x0600021A RID: 538 RVA: 0x0000BB40 File Offset: 0x00009D40
			public override ParamUtils.WrapperUtils StartPublisher()
			{
				if (System.IntPtr.Size == 8)
				{
					return new ParamUtils.WrapperUtils(this.CreatePublisher().m_ContextUtils.m_ProcessorUtils);
				}
				return new ParamUtils.WrapperUtils((long)this.ListPublisher().messageUtils.m_MethodUtils);
			}

			// Token: 0x0600021B RID: 539 RVA: 0x0000BB84 File Offset: 0x00009D84
			public override ParamUtils.WrapperUtils SearchPublisher()
			{
				if (System.IntPtr.Size == 8)
				{
					return new ParamUtils.WrapperUtils(this.AwakePublisher().m_ContextUtils.decoratorUtils);
				}
				return new ParamUtils.WrapperUtils((ulong)this.ConcatPublisher().messageUtils.m_RequestUtils);
			}

			// Token: 0x0600021C RID: 540 RVA: 0x0000BBC8 File Offset: 0x00009DC8
			public override ParamUtils.WrapperUtils PushPublisher()
			{
				if (System.IntPtr.Size == 8)
				{
					return new ParamUtils.WrapperUtils(this.EnablePublisher().m_ContextUtils.m_ProcessorUtils);
				}
				return new ParamUtils.WrapperUtils((long)this.IncludePublisher().messageUtils.m_MethodUtils);
			}

			// Token: 0x0600021D RID: 541 RVA: 0x0000CF68 File Offset: 0x0000B168
			public override ParamUtils.WrapperUtils ReadPublisher()
			{
				if (System.IntPtr.Size == 8)
				{
					return new ParamUtils.WrapperUtils(this.m_ContextUtils.decoratorUtils);
				}
				return new ParamUtils.WrapperUtils((ulong)(checked((uint)this.m_ContextUtils.decoratorUtils)));
			}

			// Token: 0x0600021E RID: 542 RVA: 0x00002FB9 File Offset: 0x000011B9
			public override ParamUtils.DescriptorAdvisor ExcludePublisher()
			{
				return new ParamUtils.ReponseUtils(-this.m_ContextUtils.m_ProcessorUtils);
			}

			// Token: 0x0600021F RID: 543 RVA: 0x0000CFA0 File Offset: 0x0000B1A0
			public override ParamUtils.DescriptorAdvisor CalculatePublisher(ParamUtils.DescriptorAdvisor config)
			{
				if (config.OrderPublisher())
				{
					config = config.CustomizePublisher();
				}
				if (!config.CallParameter())
				{
					throw new ParamUtils.ExporterUtils();
				}
				return new ParamUtils.ReponseUtils(this.m_ContextUtils.m_ProcessorUtils + ((ParamUtils.ReponseUtils)config).m_ContextUtils.m_ProcessorUtils);
			}

			// Token: 0x06000220 RID: 544 RVA: 0x0000CFEC File Offset: 0x0000B1EC
			public override ParamUtils.DescriptorAdvisor DeletePublisher(ParamUtils.DescriptorAdvisor item)
			{
				if (item.OrderPublisher())
				{
					item = item.CustomizePublisher();
				}
				if (!item.CallParameter())
				{
					throw new ParamUtils.ExporterUtils();
				}
				return new ParamUtils.ReponseUtils(checked(this.m_ContextUtils.m_ProcessorUtils + ((ParamUtils.ReponseUtils)item).m_ContextUtils.m_ProcessorUtils));
			}

			// Token: 0x06000221 RID: 545 RVA: 0x0000D038 File Offset: 0x0000B238
			public override ParamUtils.DescriptorAdvisor RunPublisher(ParamUtils.DescriptorAdvisor spec)
			{
				if (spec.OrderPublisher())
				{
					spec = spec.CustomizePublisher();
				}
				if (!spec.CallParameter())
				{
					throw new ParamUtils.ExporterUtils();
				}
				return new ParamUtils.ReponseUtils(checked(this.m_ContextUtils.decoratorUtils + ((ParamUtils.ReponseUtils)spec).m_ContextUtils.decoratorUtils));
			}

			// Token: 0x06000222 RID: 546 RVA: 0x0000D084 File Offset: 0x0000B284
			public override ParamUtils.DescriptorAdvisor MovePublisher(ParamUtils.DescriptorAdvisor task)
			{
				if (task.OrderPublisher())
				{
					task = task.CustomizePublisher();
				}
				if (!task.CallParameter())
				{
					throw new ParamUtils.ExporterUtils();
				}
				return new ParamUtils.ReponseUtils(this.m_ContextUtils.m_ProcessorUtils - ((ParamUtils.ReponseUtils)task).m_ContextUtils.m_ProcessorUtils);
			}

			// Token: 0x06000223 RID: 547 RVA: 0x0000D0D0 File Offset: 0x0000B2D0
			public override ParamUtils.DescriptorAdvisor ResolvePublisher(ParamUtils.DescriptorAdvisor init)
			{
				if (init.OrderPublisher())
				{
					init = init.CustomizePublisher();
				}
				if (!init.CallParameter())
				{
					throw new ParamUtils.ExporterUtils();
				}
				return new ParamUtils.ReponseUtils(checked(this.m_ContextUtils.m_ProcessorUtils - ((ParamUtils.ReponseUtils)init).m_ContextUtils.m_ProcessorUtils));
			}

			// Token: 0x06000224 RID: 548 RVA: 0x0000D11C File Offset: 0x0000B31C
			public override ParamUtils.DescriptorAdvisor InterruptPublisher(ParamUtils.DescriptorAdvisor last)
			{
				if (last.OrderPublisher())
				{
					last = last.CustomizePublisher();
				}
				if (!last.CallParameter())
				{
					throw new ParamUtils.ExporterUtils();
				}
				return new ParamUtils.ReponseUtils(checked(this.m_ContextUtils.decoratorUtils - ((ParamUtils.ReponseUtils)last).m_ContextUtils.decoratorUtils));
			}

			// Token: 0x06000225 RID: 549 RVA: 0x0000D168 File Offset: 0x0000B368
			public override ParamUtils.DescriptorAdvisor CallPublisher(ParamUtils.DescriptorAdvisor value)
			{
				if (value.OrderPublisher())
				{
					value = value.CustomizePublisher();
				}
				if (!value.CallParameter())
				{
					throw new ParamUtils.ExporterUtils();
				}
				return new ParamUtils.ReponseUtils(this.m_ContextUtils.m_ProcessorUtils * ((ParamUtils.ReponseUtils)value).m_ContextUtils.m_ProcessorUtils);
			}

			// Token: 0x06000226 RID: 550 RVA: 0x0000D1B4 File Offset: 0x0000B3B4
			public override ParamUtils.DescriptorAdvisor FillPublisher(ParamUtils.DescriptorAdvisor ident)
			{
				if (ident.OrderPublisher())
				{
					ident = ident.CustomizePublisher();
				}
				if (!ident.CallParameter())
				{
					throw new ParamUtils.ExporterUtils();
				}
				return new ParamUtils.ReponseUtils(checked(this.m_ContextUtils.m_ProcessorUtils * ((ParamUtils.ReponseUtils)ident).m_ContextUtils.m_ProcessorUtils));
			}

			// Token: 0x06000227 RID: 551 RVA: 0x0000D200 File Offset: 0x0000B400
			public override ParamUtils.DescriptorAdvisor QueryPublisher(ParamUtils.DescriptorAdvisor param)
			{
				if (param.OrderPublisher())
				{
					param = param.CustomizePublisher();
				}
				if (!param.CallParameter())
				{
					throw new ParamUtils.ExporterUtils();
				}
				return new ParamUtils.ReponseUtils(checked(this.m_ContextUtils.decoratorUtils * ((ParamUtils.ReponseUtils)param).m_ContextUtils.decoratorUtils));
			}

			// Token: 0x06000228 RID: 552 RVA: 0x0000D24C File Offset: 0x0000B44C
			public override ParamUtils.DescriptorAdvisor StopPublisher(ParamUtils.DescriptorAdvisor info)
			{
				if (info.OrderPublisher())
				{
					info = info.CustomizePublisher();
				}
				if (!info.CallParameter())
				{
					throw new ParamUtils.ExporterUtils();
				}
				return new ParamUtils.ReponseUtils(this.m_ContextUtils.m_ProcessorUtils / ((ParamUtils.ReponseUtils)info).m_ContextUtils.m_ProcessorUtils);
			}

			// Token: 0x06000229 RID: 553 RVA: 0x0000D298 File Offset: 0x0000B498
			public override ParamUtils.DescriptorAdvisor UpdatePublisher(ParamUtils.DescriptorAdvisor ident)
			{
				if (ident.OrderPublisher())
				{
					ident = ident.CustomizePublisher();
				}
				if (!ident.CallParameter())
				{
					throw new ParamUtils.ExporterUtils();
				}
				return new ParamUtils.ReponseUtils(this.m_ContextUtils.decoratorUtils / ((ParamUtils.ReponseUtils)ident).m_ContextUtils.decoratorUtils);
			}

			// Token: 0x0600022A RID: 554 RVA: 0x0000D2E4 File Offset: 0x0000B4E4
			public override ParamUtils.DescriptorAdvisor ManagePublisher(ParamUtils.DescriptorAdvisor i)
			{
				if (i.OrderPublisher())
				{
					i = i.CustomizePublisher();
				}
				if (!i.CallParameter())
				{
					throw new ParamUtils.ExporterUtils();
				}
				return new ParamUtils.ReponseUtils(this.m_ContextUtils.m_ProcessorUtils % ((ParamUtils.ReponseUtils)i).m_ContextUtils.m_ProcessorUtils);
			}

			// Token: 0x0600022B RID: 555 RVA: 0x0000D330 File Offset: 0x0000B530
			public override ParamUtils.DescriptorAdvisor DisablePublisher(ParamUtils.DescriptorAdvisor spec)
			{
				if (spec.OrderPublisher())
				{
					spec = spec.CustomizePublisher();
				}
				if (!spec.CallParameter())
				{
					throw new ParamUtils.ExporterUtils();
				}
				return new ParamUtils.ReponseUtils(this.m_ContextUtils.decoratorUtils % ((ParamUtils.ReponseUtils)spec).m_ContextUtils.decoratorUtils);
			}

			// Token: 0x0600022C RID: 556 RVA: 0x0000D37C File Offset: 0x0000B57C
			public override ParamUtils.DescriptorAdvisor ComputePublisher(ParamUtils.DescriptorAdvisor res)
			{
				if (res.OrderPublisher())
				{
					res = res.CustomizePublisher();
				}
				if (!res.CallParameter())
				{
					throw new ParamUtils.ExporterUtils();
				}
				return new ParamUtils.ReponseUtils(this.m_ContextUtils.m_ProcessorUtils & ((ParamUtils.ReponseUtils)res).m_ContextUtils.m_ProcessorUtils);
			}

			// Token: 0x0600022D RID: 557 RVA: 0x0000D3C8 File Offset: 0x0000B5C8
			public override ParamUtils.DescriptorAdvisor PostPublisher(ParamUtils.DescriptorAdvisor info)
			{
				if (info.OrderPublisher())
				{
					info = info.CustomizePublisher();
				}
				if (!info.CallParameter())
				{
					throw new ParamUtils.ExporterUtils();
				}
				return new ParamUtils.ReponseUtils(this.m_ContextUtils.m_ProcessorUtils | ((ParamUtils.ReponseUtils)info).m_ContextUtils.m_ProcessorUtils);
			}

			// Token: 0x0600022E RID: 558 RVA: 0x00002FCC File Offset: 0x000011CC
			public override ParamUtils.DescriptorAdvisor LoginPublisher()
			{
				return new ParamUtils.ReponseUtils(~this.m_ContextUtils.m_ProcessorUtils);
			}

			// Token: 0x0600022F RID: 559 RVA: 0x0000D414 File Offset: 0x0000B614
			public override ParamUtils.DescriptorAdvisor AssetPublisher(ParamUtils.DescriptorAdvisor instance)
			{
				if (instance.OrderPublisher())
				{
					instance = instance.CustomizePublisher();
				}
				if (!instance.CallParameter())
				{
					throw new ParamUtils.ExporterUtils();
				}
				return new ParamUtils.ReponseUtils(this.m_ContextUtils.m_ProcessorUtils ^ ((ParamUtils.ReponseUtils)instance).m_ContextUtils.m_ProcessorUtils);
			}

			// Token: 0x06000230 RID: 560 RVA: 0x0000D460 File Offset: 0x0000B660
			public override ParamUtils.DescriptorAdvisor NewPublisher(ParamUtils.DescriptorAdvisor setup)
			{
				if (setup.OrderPublisher())
				{
					setup = setup.CustomizePublisher();
				}
				if (setup.CallParameter())
				{
					return new ParamUtils.ReponseUtils(this.m_ContextUtils.m_ProcessorUtils << ((ParamUtils.ReponseUtils)setup).m_ContextUtils.configurationUtils);
				}
				if (!setup.InstantiatePublisher())
				{
					throw new ParamUtils.ExporterUtils();
				}
				return new ParamUtils.ReponseUtils(this.m_ContextUtils.m_ProcessorUtils << ((ParamUtils.ComparatorUtils)setup).AddDatabase().messageUtils.m_MethodUtils);
			}

			// Token: 0x06000231 RID: 561 RVA: 0x0000D4E4 File Offset: 0x0000B6E4
			public override ParamUtils.DescriptorAdvisor SelectPublisher(ParamUtils.DescriptorAdvisor task)
			{
				if (task.OrderPublisher())
				{
					task = task.CustomizePublisher();
				}
				if (task.CallParameter())
				{
					return new ParamUtils.ReponseUtils(this.m_ContextUtils.m_ProcessorUtils >> ((ParamUtils.ReponseUtils)task).m_ContextUtils.configurationUtils);
				}
				if (!task.InstantiatePublisher())
				{
					throw new ParamUtils.ExporterUtils();
				}
				return new ParamUtils.ReponseUtils(this.m_ContextUtils.m_ProcessorUtils >> ((ParamUtils.ComparatorUtils)task).AddDatabase().messageUtils.m_MethodUtils);
			}

			// Token: 0x06000232 RID: 562 RVA: 0x0000D568 File Offset: 0x0000B768
			public override ParamUtils.DescriptorAdvisor RemovePublisher(ParamUtils.DescriptorAdvisor param)
			{
				if (param.OrderPublisher())
				{
					param = param.CustomizePublisher();
				}
				if (param.CallParameter())
				{
					return new ParamUtils.ReponseUtils(this.m_ContextUtils.decoratorUtils >> ((ParamUtils.ReponseUtils)param).m_ContextUtils.configurationUtils);
				}
				if (param.InstantiatePublisher())
				{
					return new ParamUtils.ReponseUtils(this.m_ContextUtils.decoratorUtils >> ((ParamUtils.ComparatorUtils)param).AddDatabase().messageUtils.m_MethodUtils);
				}
				throw new ParamUtils.ExporterUtils();
			}

			// Token: 0x06000233 RID: 563 RVA: 0x0000D5EC File Offset: 0x0000B7EC
			public override string ToString()
			{
				if (this._ExceptionUtils == (ParamUtils.ProcessUtils)7)
				{
					return this.m_ContextUtils.m_ProcessorUtils.ToString();
				}
				return this.m_ContextUtils.decoratorUtils.ToString();
			}

			// Token: 0x06000234 RID: 564 RVA: 0x00002DB0 File Offset: 0x00000FB0
			internal override ParamUtils.DescriptorAdvisor CustomizePublisher()
			{
				return this;
			}

			// Token: 0x06000235 RID: 565 RVA: 0x00002728 File Offset: 0x00000928
			internal override bool ConnectPublisher()
			{
				return true;
			}

			// Token: 0x06000236 RID: 566 RVA: 0x0000D624 File Offset: 0x0000B824
			internal override bool ValidatePublisher(ParamUtils.DescriptorAdvisor instance)
			{
				if (instance.MoveParameter())
				{
					return ((ParamUtils.WorkerAdvisor)instance).ValidatePublisher(this);
				}
				if (!instance.OrderPublisher())
				{
					ParamUtils.DescriptorAdvisor descriptorAdvisor = instance.CustomizePublisher();
					return descriptorAdvisor.CallParameter() && this.m_ContextUtils.m_ProcessorUtils == ((ParamUtils.ReponseUtils)descriptorAdvisor).m_ContextUtils.m_ProcessorUtils;
				}
				return ((ParamUtils.ProducerUtils)instance).ValidatePublisher(this);
			}

			// Token: 0x06000237 RID: 567 RVA: 0x0000C50C File Offset: 0x0000A70C
			private static ParamUtils.ComparatorUtils RestartUtils(ParamUtils.DescriptorAdvisor asset)
			{
				ParamUtils.ComparatorUtils comparatorUtils = asset as ParamUtils.ComparatorUtils;
				if (comparatorUtils == null && asset.OrderPublisher())
				{
					comparatorUtils = (asset.CustomizePublisher() as ParamUtils.ComparatorUtils);
				}
				return comparatorUtils;
			}

			// Token: 0x06000238 RID: 568 RVA: 0x0000D68C File Offset: 0x0000B88C
			internal override bool ResetPublisher(ParamUtils.DescriptorAdvisor value)
			{
				if (value.MoveParameter())
				{
					return false;
				}
				if (value.OrderPublisher())
				{
					return ((ParamUtils.ProducerUtils)value).ResetPublisher(this);
				}
				ParamUtils.DescriptorAdvisor descriptorAdvisor = value.CustomizePublisher();
				return descriptorAdvisor.CallParameter() && this.m_ContextUtils.decoratorUtils != ((ParamUtils.ReponseUtils)descriptorAdvisor).m_ContextUtils.decoratorUtils;
			}

			// Token: 0x06000239 RID: 569 RVA: 0x0000D6EC File Offset: 0x0000B8EC
			public override bool ComparePublisher(ParamUtils.DescriptorAdvisor value)
			{
				if (value.OrderPublisher())
				{
					value = value.CustomizePublisher();
				}
				if (!value.CallParameter())
				{
					throw new ParamUtils.ExporterUtils();
				}
				return this.m_ContextUtils.m_ProcessorUtils >= ((ParamUtils.ReponseUtils)value).m_ContextUtils.m_ProcessorUtils;
			}

			// Token: 0x0600023A RID: 570 RVA: 0x0000D738 File Offset: 0x0000B938
			public override bool PrintPublisher(ParamUtils.DescriptorAdvisor setup)
			{
				if (setup.OrderPublisher())
				{
					setup = setup.CustomizePublisher();
				}
				if (!setup.CallParameter())
				{
					throw new ParamUtils.ExporterUtils();
				}
				return this.m_ContextUtils.decoratorUtils >= ((ParamUtils.ReponseUtils)setup).m_ContextUtils.decoratorUtils;
			}

			// Token: 0x0600023B RID: 571 RVA: 0x0000D784 File Offset: 0x0000B984
			public override bool PreparePublisher(ParamUtils.DescriptorAdvisor config)
			{
				if (config.OrderPublisher())
				{
					config = config.CustomizePublisher();
				}
				if (!config.CallParameter())
				{
					throw new ParamUtils.ExporterUtils();
				}
				return this.m_ContextUtils.m_ProcessorUtils > ((ParamUtils.ReponseUtils)config).m_ContextUtils.m_ProcessorUtils;
			}

			// Token: 0x0600023C RID: 572 RVA: 0x0000D7CC File Offset: 0x0000B9CC
			public override bool LogoutPublisher(ParamUtils.DescriptorAdvisor res)
			{
				if (res.OrderPublisher())
				{
					res = res.CustomizePublisher();
				}
				if (!res.CallParameter())
				{
					throw new ParamUtils.ExporterUtils();
				}
				return this.m_ContextUtils.decoratorUtils > ((ParamUtils.ReponseUtils)res).m_ContextUtils.decoratorUtils;
			}

			// Token: 0x0600023D RID: 573 RVA: 0x0000D814 File Offset: 0x0000BA14
			public override bool FindPublisher(ParamUtils.DescriptorAdvisor instance)
			{
				if (instance.OrderPublisher())
				{
					instance = instance.CustomizePublisher();
				}
				if (!instance.CallParameter())
				{
					throw new ParamUtils.ExporterUtils();
				}
				return this.m_ContextUtils.m_ProcessorUtils <= ((ParamUtils.ReponseUtils)instance).m_ContextUtils.m_ProcessorUtils;
			}

			// Token: 0x0600023E RID: 574 RVA: 0x0000D860 File Offset: 0x0000BA60
			public override bool TestPublisher(ParamUtils.DescriptorAdvisor info)
			{
				if (info.OrderPublisher())
				{
					info = info.CustomizePublisher();
				}
				if (!info.CallParameter())
				{
					throw new ParamUtils.ExporterUtils();
				}
				return this.m_ContextUtils.decoratorUtils <= ((ParamUtils.ReponseUtils)info).m_ContextUtils.decoratorUtils;
			}

			// Token: 0x0600023F RID: 575 RVA: 0x0000D8AC File Offset: 0x0000BAAC
			public override bool RatePublisher(ParamUtils.DescriptorAdvisor config)
			{
				if (config.OrderPublisher())
				{
					config = config.CustomizePublisher();
				}
				if (!config.CallParameter())
				{
					throw new ParamUtils.ExporterUtils();
				}
				return this.m_ContextUtils.m_ProcessorUtils < ((ParamUtils.ReponseUtils)config).m_ContextUtils.m_ProcessorUtils;
			}

			// Token: 0x06000240 RID: 576 RVA: 0x0000D8F4 File Offset: 0x0000BAF4
			public override bool RestartPublisher(ParamUtils.DescriptorAdvisor reference)
			{
				if (reference.OrderPublisher())
				{
					reference = reference.CustomizePublisher();
				}
				if (!reference.CallParameter())
				{
					throw new ParamUtils.ExporterUtils();
				}
				return this.m_ContextUtils.decoratorUtils < ((ParamUtils.ReponseUtils)reference).m_ContextUtils.decoratorUtils;
			}

			// Token: 0x04000090 RID: 144
			public ParamUtils.WatcherUtils m_ContextUtils;

			// Token: 0x04000091 RID: 145
			public ParamUtils.ProcessUtils _ExceptionUtils;
		}

		// Token: 0x0200002C RID: 44
		private class WrapperUtils : ParamUtils.ComparatorUtils
		{
			// Token: 0x06000241 RID: 577 RVA: 0x0000D93C File Offset: 0x0000BB3C
			internal void InsertUtils(ParamUtils.DescriptorAdvisor item)
			{
				if (!item.InterruptParameter())
				{
					this.CompareDatabase(item);
					return;
				}
				this.m_RegistryUtils = ((ParamUtils.WrapperUtils)item).m_RegistryUtils;
				this.m_CodeUtils = ((ParamUtils.WrapperUtils)item).m_CodeUtils;
			}

			// Token: 0x06000242 RID: 578 RVA: 0x0000D97C File Offset: 0x0000BB7C
			internal unsafe override void CompareDatabase(ParamUtils.DescriptorAdvisor last)
			{
				if (last.InterruptParameter())
				{
					if (System.IntPtr.Size == 8)
					{
						System.IntPtr value = new System.IntPtr(((ParamUtils.ReponseUtils)this.m_RegistryUtils).m_ContextUtils.m_ProcessorUtils);
						System.IntPtr intPtr = new System.IntPtr(((ParamUtils.ReponseUtils)((ParamUtils.WrapperUtils)last).m_RegistryUtils).m_ContextUtils.m_ProcessorUtils);
						*(long*)((void*)value) = intPtr.ToInt64();
						return;
					}
					System.IntPtr value2 = new System.IntPtr(((ParamUtils.CollectionUtils)this.m_RegistryUtils).messageUtils.m_MethodUtils);
					System.IntPtr intPtr2 = new System.IntPtr(((ParamUtils.CollectionUtils)((ParamUtils.WrapperUtils)last).m_RegistryUtils).messageUtils.m_MethodUtils);
					*(int*)((void*)value2) = intPtr2.ToInt32();
					return;
				}
				else
				{
					object obj = last.RateDatabase(null);
					if (obj == null)
					{
						return;
					}
					System.IntPtr value3;
					if (System.IntPtr.Size == 8)
					{
						value3 = new System.IntPtr(((ParamUtils.ReponseUtils)this.m_RegistryUtils).m_ContextUtils.m_ProcessorUtils);
					}
					else
					{
						value3 = new System.IntPtr(((ParamUtils.CollectionUtils)this.m_RegistryUtils).messageUtils.m_MethodUtils);
					}
					System.Type type = obj.GetType();
					if (type == typeof(string))
					{
						return;
					}
					if (type == typeof(byte))
					{
						*(byte*)((void*)value3) = (byte)obj;
						return;
					}
					if (type == typeof(sbyte))
					{
						*(byte*)((void*)value3) = (byte)((sbyte)obj);
						return;
					}
					if (type == typeof(short))
					{
						*(short*)((void*)value3) = (short)obj;
						return;
					}
					if (type == typeof(ushort))
					{
						*(short*)((void*)value3) = (short)((ushort)obj);
						return;
					}
					if (type == typeof(int))
					{
						*(int*)((void*)value3) = (int)obj;
						return;
					}
					if (type == typeof(uint))
					{
						*(int*)((void*)value3) = (int)((uint)obj);
						return;
					}
					if (type == typeof(long))
					{
						*(long*)((void*)value3) = (long)obj;
						return;
					}
					if (type == typeof(ulong))
					{
						*(long*)((void*)value3) = (long)((ulong)obj);
						return;
					}
					if (type == typeof(float))
					{
						*(float*)((void*)value3) = (float)obj;
						return;
					}
					if (type == typeof(double))
					{
						*(double*)((void*)value3) = (double)obj;
						return;
					}
					if (type == typeof(bool))
					{
						*(byte*)((void*)value3) = (((bool)obj) ? 1 : 0);
						return;
					}
					if (type == typeof(System.IntPtr))
					{
						*(System.IntPtr*)((void*)value3) = (System.IntPtr)obj;
						return;
					}
					if (type == typeof(System.UIntPtr))
					{
						*(System.IntPtr*)((void*)value3) = (System.IntPtr)((System.UIntPtr)obj);
						return;
					}
					if (type == typeof(char))
					{
						*(short*)((void*)value3) = (short)((char)obj);
						return;
					}
					throw new ParamUtils.ExporterUtils();
				}
			}

			// Token: 0x06000243 RID: 579 RVA: 0x0000B390 File Offset: 0x00009590
			internal override void PrintDatabase(ParamUtils.DescriptorAdvisor ident)
			{
				this.CompareDatabase(ident);
			}

			// Token: 0x06000244 RID: 580 RVA: 0x0000DC90 File Offset: 0x0000BE90
			public WrapperUtils(System.IntPtr setup)
			{
				this._ProxyAdvisor = (ParamUtils.CopyOption)3;
				if (System.IntPtr.Size == 8)
				{
					this.m_RegistryUtils = new ParamUtils.ReponseUtils(setup.ToInt64());
					this.m_CodeUtils = (ParamUtils.ProcessUtils)12;
					return;
				}
				this.m_RegistryUtils = new ParamUtils.CollectionUtils(setup.ToInt32());
				this.m_CodeUtils = (ParamUtils.ProcessUtils)12;
			}

			// Token: 0x06000245 RID: 581 RVA: 0x0000DCE8 File Offset: 0x0000BEE8
			public WrapperUtils(System.UIntPtr instance)
			{
				this._ProxyAdvisor = (ParamUtils.CopyOption)3;
				if (System.IntPtr.Size == 8)
				{
					this.m_RegistryUtils = new ParamUtils.ReponseUtils(instance.ToUInt64());
					this.m_CodeUtils = (ParamUtils.ProcessUtils)12;
					return;
				}
				this.m_RegistryUtils = new ParamUtils.CollectionUtils(instance.ToUInt32());
				this.m_CodeUtils = (ParamUtils.ProcessUtils)12;
			}

			// Token: 0x06000246 RID: 582 RVA: 0x0000DD40 File Offset: 0x0000BF40
			public WrapperUtils()
			{
				this._ProxyAdvisor = (ParamUtils.CopyOption)3;
				if (System.IntPtr.Size == 8)
				{
					this.m_RegistryUtils = new ParamUtils.ReponseUtils(0L);
					this.m_CodeUtils = (ParamUtils.ProcessUtils)12;
					return;
				}
				this.m_RegistryUtils = new ParamUtils.CollectionUtils(0);
				this.m_CodeUtils = (ParamUtils.ProcessUtils)12;
			}

			// Token: 0x06000247 RID: 583 RVA: 0x00002FDF File Offset: 0x000011DF
			public override ParamUtils.ComparatorUtils PrepareDatabase()
			{
				return new ParamUtils.WrapperUtils
				{
					m_RegistryUtils = this.m_RegistryUtils.PrepareDatabase(),
					m_CodeUtils = this.m_CodeUtils
				};
			}

			// Token: 0x06000248 RID: 584 RVA: 0x0000DD94 File Offset: 0x0000BF94
			public WrapperUtils(long sizeasset)
			{
				this._ProxyAdvisor = (ParamUtils.CopyOption)3;
				if (System.IntPtr.Size == 8)
				{
					this.m_RegistryUtils = new ParamUtils.ReponseUtils(sizeasset);
					this.m_CodeUtils = (ParamUtils.ProcessUtils)12;
					return;
				}
				this.m_RegistryUtils = new ParamUtils.CollectionUtils((int)sizeasset);
				this.m_CodeUtils = (ParamUtils.ProcessUtils)12;
			}

			// Token: 0x06000249 RID: 585 RVA: 0x0000DDE0 File Offset: 0x0000BFE0
			public WrapperUtils(long key_Z, ParamUtils.ProcessUtils cust)
			{
				this._ProxyAdvisor = (ParamUtils.CopyOption)3;
				if (System.IntPtr.Size == 8)
				{
					this.m_RegistryUtils = new ParamUtils.ReponseUtils(key_Z);
					this.m_CodeUtils = cust;
					return;
				}
				this.m_RegistryUtils = new ParamUtils.CollectionUtils((int)key_Z);
				this.m_CodeUtils = cust;
			}

			// Token: 0x0600024A RID: 586 RVA: 0x0000DE2C File Offset: 0x0000C02C
			public WrapperUtils(ulong versionasset)
			{
				this._ProxyAdvisor = (ParamUtils.CopyOption)4;
				if (System.IntPtr.Size == 8)
				{
					this.m_RegistryUtils = new ParamUtils.ReponseUtils(versionasset);
					this.m_CodeUtils = (ParamUtils.ProcessUtils)13;
					return;
				}
				this.m_RegistryUtils = new ParamUtils.CollectionUtils((uint)versionasset);
				this.m_CodeUtils = (ParamUtils.ProcessUtils)13;
			}

			// Token: 0x0600024B RID: 587 RVA: 0x0000DE78 File Offset: 0x0000C078
			public WrapperUtils(ulong start_config, ParamUtils.ProcessUtils token)
			{
				this._ProxyAdvisor = (ParamUtils.CopyOption)4;
				if (System.IntPtr.Size == 8)
				{
					this.m_RegistryUtils = new ParamUtils.ReponseUtils(start_config);
					this.m_CodeUtils = token;
					return;
				}
				this.m_RegistryUtils = new ParamUtils.CollectionUtils((uint)start_config);
				this.m_CodeUtils = token;
			}

			// Token: 0x0600024C RID: 588 RVA: 0x00003003 File Offset: 0x00001203
			public override bool LogoutDatabase()
			{
				return this.m_RegistryUtils.LogoutDatabase();
			}

			// Token: 0x0600024D RID: 589 RVA: 0x00002B72 File Offset: 0x00000D72
			public override bool FindDatabase()
			{
				return !this.LogoutDatabase();
			}

			// Token: 0x0600024E RID: 590 RVA: 0x00002B7D File Offset: 0x00000D7D
			internal override bool InsertDatabase()
			{
				return this.FindDatabase();
			}

			// Token: 0x0600024F RID: 591 RVA: 0x00002728 File Offset: 0x00000928
			internal override bool InsertPublisher()
			{
				return true;
			}

			// Token: 0x06000250 RID: 592 RVA: 0x0000DEC4 File Offset: 0x0000C0C4
			public override ParamUtils.DescriptorAdvisor TestDatabase(ParamUtils.ProcessUtils value)
			{
				switch (value)
				{
				case (ParamUtils.ProcessUtils)1:
					return this.InstantiateDatabase();
				case (ParamUtils.ProcessUtils)2:
					return this.OrderDatabase();
				case (ParamUtils.ProcessUtils)3:
					return this.SortDatabase();
				case (ParamUtils.ProcessUtils)4:
					return this.CancelDatabase();
				case (ParamUtils.ProcessUtils)5:
					return this.AddDatabase();
				case (ParamUtils.ProcessUtils)6:
					return this.CheckDatabase();
				case (ParamUtils.ProcessUtils)7:
					return this.DefineDatabase();
				case (ParamUtils.ProcessUtils)8:
					return this.ViewDatabase();
				case (ParamUtils.ProcessUtils)11:
					return this.RestartDatabase();
				case (ParamUtils.ProcessUtils)12:
					return this;
				case (ParamUtils.ProcessUtils)13:
					return this;
				case (ParamUtils.ProcessUtils)16:
					return this.PrepareDatabase();
				}
				throw new System.Exception(((ParamUtils.CancellationMode)4).ToString());
			}

			// Token: 0x06000251 RID: 593 RVA: 0x0000DF7C File Offset: 0x0000C17C
			internal System.IntPtr InstantiateUtils()
			{
				if (System.IntPtr.Size == 8)
				{
					return new System.IntPtr(((ParamUtils.ReponseUtils)this.m_RegistryUtils).m_ContextUtils.m_ProcessorUtils);
				}
				return new System.IntPtr(((ParamUtils.CollectionUtils)this.m_RegistryUtils).messageUtils.m_MethodUtils);
			}

			// Token: 0x06000252 RID: 594 RVA: 0x0000DFC8 File Offset: 0x0000C1C8
			internal override object RateDatabase(System.Type def)
			{
				if (def != null && def.IsByRef)
				{
					def = def.GetElementType();
				}
				if (def == typeof(System.IntPtr))
				{
					if (System.IntPtr.Size == 8)
					{
						return new System.IntPtr(((ParamUtils.ReponseUtils)this.m_RegistryUtils).m_ContextUtils.m_ProcessorUtils);
					}
					return new System.IntPtr(((ParamUtils.CollectionUtils)this.m_RegistryUtils).messageUtils.m_MethodUtils);
				}
				else if (!(def == typeof(System.UIntPtr)))
				{
					if (!(def == null) && !(def == typeof(object)))
					{
						throw new ParamUtils.ExporterUtils();
					}
					if (System.IntPtr.Size == 8)
					{
						if (this.m_CodeUtils == (ParamUtils.ProcessUtils)12)
						{
							return new System.IntPtr(((ParamUtils.ReponseUtils)this.m_RegistryUtils).m_ContextUtils.m_ProcessorUtils);
						}
						return new System.UIntPtr(((ParamUtils.ReponseUtils)this.m_RegistryUtils).m_ContextUtils.decoratorUtils);
					}
					else
					{
						if (this.m_CodeUtils == (ParamUtils.ProcessUtils)12)
						{
							return new System.IntPtr(((ParamUtils.ReponseUtils)this.m_RegistryUtils).m_ContextUtils.configurationUtils);
						}
						return new System.UIntPtr(((ParamUtils.CollectionUtils)this.m_RegistryUtils).messageUtils.m_RequestUtils);
					}
				}
				else
				{
					if (System.IntPtr.Size == 8)
					{
						return new System.UIntPtr(((ParamUtils.ReponseUtils)this.m_RegistryUtils).m_ContextUtils.decoratorUtils);
					}
					return new System.UIntPtr(((ParamUtils.CollectionUtils)this.m_RegistryUtils).messageUtils.m_RequestUtils);
				}
			}

			// Token: 0x06000253 RID: 595 RVA: 0x00003010 File Offset: 0x00001210
			public override ParamUtils.CollectionUtils RestartDatabase()
			{
				return this.m_RegistryUtils.RestartDatabase();
			}

			// Token: 0x06000254 RID: 596 RVA: 0x0000301D File Offset: 0x0000121D
			public override ParamUtils.CollectionUtils InstantiateDatabase()
			{
				return this.m_RegistryUtils.InstantiateDatabase();
			}

			// Token: 0x06000255 RID: 597 RVA: 0x0000302A File Offset: 0x0000122A
			public override ParamUtils.CollectionUtils OrderDatabase()
			{
				return this.m_RegistryUtils.OrderDatabase();
			}

			// Token: 0x06000256 RID: 598 RVA: 0x00003037 File Offset: 0x00001237
			public override ParamUtils.CollectionUtils SortDatabase()
			{
				return this.m_RegistryUtils.SortDatabase();
			}

			// Token: 0x06000257 RID: 599 RVA: 0x00003044 File Offset: 0x00001244
			public override ParamUtils.CollectionUtils CancelDatabase()
			{
				return this.m_RegistryUtils.CancelDatabase();
			}

			// Token: 0x06000258 RID: 600 RVA: 0x00003051 File Offset: 0x00001251
			public override ParamUtils.CollectionUtils AddDatabase()
			{
				return this.m_RegistryUtils.AddDatabase();
			}

			// Token: 0x06000259 RID: 601 RVA: 0x0000305E File Offset: 0x0000125E
			public override ParamUtils.CollectionUtils CheckDatabase()
			{
				return this.m_RegistryUtils.CheckDatabase();
			}

			// Token: 0x0600025A RID: 602 RVA: 0x0000306B File Offset: 0x0000126B
			public override ParamUtils.ReponseUtils DefineDatabase()
			{
				return this.m_RegistryUtils.DefineDatabase();
			}

			// Token: 0x0600025B RID: 603 RVA: 0x00003078 File Offset: 0x00001278
			public override ParamUtils.ReponseUtils ViewDatabase()
			{
				return this.m_RegistryUtils.ViewDatabase();
			}

			// Token: 0x0600025C RID: 604 RVA: 0x00002C33 File Offset: 0x00000E33
			public override ParamUtils.CollectionUtils RevertDatabase()
			{
				return this.InstantiateDatabase();
			}

			// Token: 0x0600025D RID: 605 RVA: 0x00002C3B File Offset: 0x00000E3B
			public override ParamUtils.CollectionUtils PublishPublisher()
			{
				return this.SortDatabase();
			}

			// Token: 0x0600025E RID: 606 RVA: 0x00002C43 File Offset: 0x00000E43
			public override ParamUtils.CollectionUtils SetupPublisher()
			{
				return this.AddDatabase();
			}

			// Token: 0x0600025F RID: 607 RVA: 0x00002C4B File Offset: 0x00000E4B
			public override ParamUtils.ReponseUtils SetPublisher()
			{
				return this.DefineDatabase();
			}

			// Token: 0x06000260 RID: 608 RVA: 0x00002C53 File Offset: 0x00000E53
			public override ParamUtils.CollectionUtils CountPublisher()
			{
				return this.OrderDatabase();
			}

			// Token: 0x06000261 RID: 609 RVA: 0x00002C5B File Offset: 0x00000E5B
			public override ParamUtils.CollectionUtils ReflectPublisher()
			{
				return this.CancelDatabase();
			}

			// Token: 0x06000262 RID: 610 RVA: 0x00002C63 File Offset: 0x00000E63
			public override ParamUtils.CollectionUtils WritePublisher()
			{
				return this.CheckDatabase();
			}

			// Token: 0x06000263 RID: 611 RVA: 0x00002C6B File Offset: 0x00000E6B
			public override ParamUtils.ReponseUtils ClonePublisher()
			{
				return this.ViewDatabase();
			}

			// Token: 0x06000264 RID: 612 RVA: 0x00003085 File Offset: 0x00001285
			public override ParamUtils.CollectionUtils VisitPublisher()
			{
				return this.m_RegistryUtils.VisitPublisher();
			}

			// Token: 0x06000265 RID: 613 RVA: 0x00003092 File Offset: 0x00001292
			public override ParamUtils.CollectionUtils MapPublisher()
			{
				return this.m_RegistryUtils.MapPublisher();
			}

			// Token: 0x06000266 RID: 614 RVA: 0x0000309F File Offset: 0x0000129F
			public override ParamUtils.CollectionUtils VerifyPublisher()
			{
				return this.m_RegistryUtils.VerifyPublisher();
			}

			// Token: 0x06000267 RID: 615 RVA: 0x000030AC File Offset: 0x000012AC
			public override ParamUtils.CollectionUtils ChangePublisher()
			{
				return this.m_RegistryUtils.ChangePublisher();
			}

			// Token: 0x06000268 RID: 616 RVA: 0x000030B9 File Offset: 0x000012B9
			public override ParamUtils.CollectionUtils ListPublisher()
			{
				return this.m_RegistryUtils.ListPublisher();
			}

			// Token: 0x06000269 RID: 617 RVA: 0x000030C6 File Offset: 0x000012C6
			public override ParamUtils.CollectionUtils IncludePublisher()
			{
				return this.m_RegistryUtils.IncludePublisher();
			}

			// Token: 0x0600026A RID: 618 RVA: 0x000030D3 File Offset: 0x000012D3
			public override ParamUtils.ReponseUtils CreatePublisher()
			{
				return this.m_RegistryUtils.CreatePublisher();
			}

			// Token: 0x0600026B RID: 619 RVA: 0x000030E0 File Offset: 0x000012E0
			public override ParamUtils.ReponseUtils EnablePublisher()
			{
				return this.m_RegistryUtils.EnablePublisher();
			}

			// Token: 0x0600026C RID: 620 RVA: 0x000030ED File Offset: 0x000012ED
			public override ParamUtils.CollectionUtils PatchPublisher()
			{
				return this.m_RegistryUtils.PatchPublisher();
			}

			// Token: 0x0600026D RID: 621 RVA: 0x000030FA File Offset: 0x000012FA
			public override ParamUtils.CollectionUtils ForgotPublisher()
			{
				return this.m_RegistryUtils.ForgotPublisher();
			}

			// Token: 0x0600026E RID: 622 RVA: 0x00003107 File Offset: 0x00001307
			public override ParamUtils.CollectionUtils InitPublisher()
			{
				return this.m_RegistryUtils.InitPublisher();
			}

			// Token: 0x0600026F RID: 623 RVA: 0x00003114 File Offset: 0x00001314
			public override ParamUtils.CollectionUtils CollectPublisher()
			{
				return this.m_RegistryUtils.CollectPublisher();
			}

			// Token: 0x06000270 RID: 624 RVA: 0x00003121 File Offset: 0x00001321
			public override ParamUtils.CollectionUtils ConcatPublisher()
			{
				return this.m_RegistryUtils.ConcatPublisher();
			}

			// Token: 0x06000271 RID: 625 RVA: 0x0000312E File Offset: 0x0000132E
			public override ParamUtils.CollectionUtils InvokePublisher()
			{
				return this.m_RegistryUtils.InvokePublisher();
			}

			// Token: 0x06000272 RID: 626 RVA: 0x0000313B File Offset: 0x0000133B
			public override ParamUtils.ReponseUtils AwakePublisher()
			{
				return this.m_RegistryUtils.AwakePublisher();
			}

			// Token: 0x06000273 RID: 627 RVA: 0x00003148 File Offset: 0x00001348
			public override ParamUtils.ReponseUtils FlushPublisher()
			{
				return this.m_RegistryUtils.FlushPublisher();
			}

			// Token: 0x06000274 RID: 628 RVA: 0x00003155 File Offset: 0x00001355
			public override ParamUtils.CreatorUtils PopPublisher()
			{
				return this.m_RegistryUtils.PopPublisher();
			}

			// Token: 0x06000275 RID: 629 RVA: 0x00003162 File Offset: 0x00001362
			public override ParamUtils.CreatorUtils RegisterPublisher()
			{
				return this.m_RegistryUtils.RegisterPublisher();
			}

			// Token: 0x06000276 RID: 630 RVA: 0x0000316F File Offset: 0x0000136F
			public override ParamUtils.CreatorUtils CalcPublisher()
			{
				return this.m_RegistryUtils.CalcPublisher();
			}

			// Token: 0x06000277 RID: 631 RVA: 0x0000BAB8 File Offset: 0x00009CB8
			public override ParamUtils.WrapperUtils DestroyPublisher()
			{
				if (System.IntPtr.Size == 8)
				{
					return new ParamUtils.WrapperUtils(this.SetPublisher().m_ContextUtils.m_ProcessorUtils);
				}
				return new ParamUtils.WrapperUtils((long)this.SetupPublisher().messageUtils.m_MethodUtils);
			}

			// Token: 0x06000278 RID: 632 RVA: 0x0000BAFC File Offset: 0x00009CFC
			public override ParamUtils.WrapperUtils GetPublisher()
			{
				if (System.IntPtr.Size == 8)
				{
					return new ParamUtils.WrapperUtils(this.ClonePublisher().m_ContextUtils.decoratorUtils);
				}
				return new ParamUtils.WrapperUtils((ulong)this.WritePublisher().messageUtils.m_RequestUtils);
			}

			// Token: 0x06000279 RID: 633 RVA: 0x0000BB40 File Offset: 0x00009D40
			public override ParamUtils.WrapperUtils StartPublisher()
			{
				if (System.IntPtr.Size == 8)
				{
					return new ParamUtils.WrapperUtils(this.CreatePublisher().m_ContextUtils.m_ProcessorUtils);
				}
				return new ParamUtils.WrapperUtils((long)this.ListPublisher().messageUtils.m_MethodUtils);
			}

			// Token: 0x0600027A RID: 634 RVA: 0x0000BB84 File Offset: 0x00009D84
			public override ParamUtils.WrapperUtils SearchPublisher()
			{
				if (System.IntPtr.Size == 8)
				{
					return new ParamUtils.WrapperUtils(this.AwakePublisher().m_ContextUtils.decoratorUtils);
				}
				return new ParamUtils.WrapperUtils((ulong)this.ConcatPublisher().messageUtils.m_RequestUtils);
			}

			// Token: 0x0600027B RID: 635 RVA: 0x0000BBC8 File Offset: 0x00009DC8
			public override ParamUtils.WrapperUtils PushPublisher()
			{
				if (System.IntPtr.Size == 8)
				{
					return new ParamUtils.WrapperUtils(this.EnablePublisher().m_ContextUtils.m_ProcessorUtils);
				}
				return new ParamUtils.WrapperUtils((long)this.IncludePublisher().messageUtils.m_MethodUtils);
			}

			// Token: 0x0600027C RID: 636 RVA: 0x0000BC0C File Offset: 0x00009E0C
			public override ParamUtils.WrapperUtils ReadPublisher()
			{
				if (System.IntPtr.Size == 8)
				{
					return new ParamUtils.WrapperUtils(this.FlushPublisher().m_ContextUtils.decoratorUtils);
				}
				return new ParamUtils.WrapperUtils((ulong)this.InvokePublisher().messageUtils.m_RequestUtils);
			}

			// Token: 0x0600027D RID: 637 RVA: 0x0000E164 File Offset: 0x0000C364
			public override ParamUtils.DescriptorAdvisor ExcludePublisher()
			{
				if (System.IntPtr.Size == 8)
				{
					return new ParamUtils.WrapperUtils(-((ParamUtils.ReponseUtils)this.m_RegistryUtils).m_ContextUtils.m_ProcessorUtils);
				}
				return new ParamUtils.WrapperUtils((long)(-(long)((ParamUtils.CollectionUtils)this.m_RegistryUtils).messageUtils.m_MethodUtils));
			}

			// Token: 0x0600027E RID: 638 RVA: 0x0000E1B4 File Offset: 0x0000C3B4
			public override ParamUtils.DescriptorAdvisor CalculatePublisher(ParamUtils.DescriptorAdvisor setup)
			{
				if (setup.OrderPublisher())
				{
					setup = setup.CustomizePublisher();
				}
				if (setup.ResolveParameter())
				{
					if (System.IntPtr.Size == 8)
					{
						return new ParamUtils.WrapperUtils(this.DefineDatabase().m_ContextUtils.m_ProcessorUtils + ((ParamUtils.CollectionUtils)setup).DefineDatabase().m_ContextUtils.m_ProcessorUtils);
					}
					return new ParamUtils.WrapperUtils((long)(this.AddDatabase().messageUtils.m_MethodUtils + ((ParamUtils.CollectionUtils)setup).messageUtils.m_MethodUtils));
				}
				else
				{
					if (!setup.InterruptParameter())
					{
						throw new ParamUtils.ExporterUtils();
					}
					if (System.IntPtr.Size == 8)
					{
						return new ParamUtils.WrapperUtils(this.DefineDatabase().m_ContextUtils.m_ProcessorUtils + ((ParamUtils.WrapperUtils)setup).DefineDatabase().m_ContextUtils.m_ProcessorUtils);
					}
					return new ParamUtils.WrapperUtils((long)(this.AddDatabase().messageUtils.m_MethodUtils + ((ParamUtils.WrapperUtils)setup).AddDatabase().messageUtils.m_MethodUtils));
				}
			}

			// Token: 0x0600027F RID: 639 RVA: 0x0000E2A4 File Offset: 0x0000C4A4
			public override ParamUtils.DescriptorAdvisor DeletePublisher(ParamUtils.DescriptorAdvisor first)
			{
				if (first.OrderPublisher())
				{
					first = first.CustomizePublisher();
				}
				if (!first.ResolveParameter())
				{
					if (!first.InterruptParameter())
					{
						throw new ParamUtils.ExporterUtils();
					}
					if (System.IntPtr.Size == 8)
					{
						return new ParamUtils.WrapperUtils(checked(this.DefineDatabase().m_ContextUtils.m_ProcessorUtils + ((ParamUtils.WrapperUtils)first).DefineDatabase().m_ContextUtils.m_ProcessorUtils));
					}
					return new ParamUtils.WrapperUtils((long)(checked(this.AddDatabase().messageUtils.m_MethodUtils + ((ParamUtils.WrapperUtils)first).AddDatabase().messageUtils.m_MethodUtils)));
				}
				else
				{
					if (System.IntPtr.Size == 8)
					{
						return new ParamUtils.WrapperUtils(checked(this.DefineDatabase().m_ContextUtils.m_ProcessorUtils + ((ParamUtils.CollectionUtils)first).DefineDatabase().m_ContextUtils.m_ProcessorUtils));
					}
					return new ParamUtils.WrapperUtils((long)(checked(this.AddDatabase().messageUtils.m_MethodUtils + ((ParamUtils.CollectionUtils)first).messageUtils.m_MethodUtils)));
				}
			}

			// Token: 0x06000280 RID: 640 RVA: 0x0000E394 File Offset: 0x0000C594
			public override ParamUtils.DescriptorAdvisor RunPublisher(ParamUtils.DescriptorAdvisor ident)
			{
				if (ident.OrderPublisher())
				{
					ident = ident.CustomizePublisher();
				}
				if (ident.ResolveParameter())
				{
					if (System.IntPtr.Size == 8)
					{
						return new ParamUtils.WrapperUtils(checked(this.DefineDatabase().m_ContextUtils.decoratorUtils + unchecked((ulong)((ParamUtils.CollectionUtils)ident).messageUtils.m_RequestUtils)));
					}
					return new ParamUtils.WrapperUtils((long)((ulong)(checked(this.AddDatabase().messageUtils.m_RequestUtils + ((ParamUtils.CollectionUtils)ident).messageUtils.m_RequestUtils))));
				}
				else
				{
					if (!ident.InterruptParameter())
					{
						throw new ParamUtils.ExporterUtils();
					}
					if (System.IntPtr.Size == 8)
					{
						return new ParamUtils.WrapperUtils(checked(this.DefineDatabase().m_ContextUtils.decoratorUtils + ((ParamUtils.WrapperUtils)ident).DefineDatabase().m_ContextUtils.decoratorUtils));
					}
					return new ParamUtils.WrapperUtils((ulong)(checked(this.AddDatabase().messageUtils.m_RequestUtils + ((ParamUtils.WrapperUtils)ident).AddDatabase().messageUtils.m_RequestUtils)));
				}
			}

			// Token: 0x06000281 RID: 641 RVA: 0x0000E480 File Offset: 0x0000C680
			public override ParamUtils.DescriptorAdvisor MovePublisher(ParamUtils.DescriptorAdvisor spec)
			{
				if (spec.OrderPublisher())
				{
					spec = spec.CustomizePublisher();
				}
				if (spec.ResolveParameter())
				{
					if (System.IntPtr.Size == 8)
					{
						return new ParamUtils.WrapperUtils(this.DefineDatabase().m_ContextUtils.m_ProcessorUtils - ((ParamUtils.CollectionUtils)spec).DefineDatabase().m_ContextUtils.m_ProcessorUtils);
					}
					return new ParamUtils.WrapperUtils((long)(this.AddDatabase().messageUtils.m_MethodUtils - ((ParamUtils.CollectionUtils)spec).messageUtils.m_MethodUtils));
				}
				else
				{
					if (!spec.InterruptParameter())
					{
						throw new ParamUtils.ExporterUtils();
					}
					if (System.IntPtr.Size == 8)
					{
						return new ParamUtils.WrapperUtils(this.DefineDatabase().m_ContextUtils.m_ProcessorUtils - ((ParamUtils.WrapperUtils)spec).DefineDatabase().m_ContextUtils.m_ProcessorUtils);
					}
					return new ParamUtils.WrapperUtils((long)(this.AddDatabase().messageUtils.m_MethodUtils - ((ParamUtils.WrapperUtils)spec).AddDatabase().messageUtils.m_MethodUtils));
				}
			}

			// Token: 0x06000282 RID: 642 RVA: 0x0000E570 File Offset: 0x0000C770
			public ParamUtils.DescriptorAdvisor OrderUtils(ParamUtils.DescriptorAdvisor task)
			{
				if (task.OrderPublisher())
				{
					task = task.CustomizePublisher();
				}
				if (task.ResolveParameter())
				{
					if (System.IntPtr.Size == 8)
					{
						return new ParamUtils.WrapperUtils(((ParamUtils.CollectionUtils)task).DefineDatabase().m_ContextUtils.m_ProcessorUtils - this.DefineDatabase().m_ContextUtils.m_ProcessorUtils);
					}
					return new ParamUtils.WrapperUtils((long)(((ParamUtils.CollectionUtils)task).messageUtils.m_MethodUtils - this.AddDatabase().messageUtils.m_MethodUtils));
				}
				else
				{
					if (!task.InterruptParameter())
					{
						throw new ParamUtils.ExporterUtils();
					}
					if (System.IntPtr.Size == 8)
					{
						return new ParamUtils.WrapperUtils(((ParamUtils.WrapperUtils)task).DefineDatabase().m_ContextUtils.m_ProcessorUtils - this.DefineDatabase().m_ContextUtils.m_ProcessorUtils);
					}
					return new ParamUtils.WrapperUtils((long)(((ParamUtils.WrapperUtils)task).AddDatabase().messageUtils.m_MethodUtils - this.AddDatabase().messageUtils.m_MethodUtils));
				}
			}

			// Token: 0x06000283 RID: 643 RVA: 0x0000E660 File Offset: 0x0000C860
			public override ParamUtils.DescriptorAdvisor ResolvePublisher(ParamUtils.DescriptorAdvisor res)
			{
				if (res.OrderPublisher())
				{
					res = res.CustomizePublisher();
				}
				if (res.ResolveParameter())
				{
					if (System.IntPtr.Size == 8)
					{
						return new ParamUtils.WrapperUtils(checked(this.DefineDatabase().m_ContextUtils.m_ProcessorUtils - ((ParamUtils.CollectionUtils)res).DefineDatabase().m_ContextUtils.m_ProcessorUtils));
					}
					return new ParamUtils.WrapperUtils((long)(checked(this.AddDatabase().messageUtils.m_MethodUtils - ((ParamUtils.CollectionUtils)res).messageUtils.m_MethodUtils)));
				}
				else
				{
					if (!res.InterruptParameter())
					{
						throw new ParamUtils.ExporterUtils();
					}
					if (System.IntPtr.Size == 8)
					{
						return new ParamUtils.WrapperUtils(checked(this.DefineDatabase().m_ContextUtils.m_ProcessorUtils - ((ParamUtils.WrapperUtils)res).DefineDatabase().m_ContextUtils.m_ProcessorUtils));
					}
					return new ParamUtils.WrapperUtils((long)(checked(this.AddDatabase().messageUtils.m_MethodUtils - ((ParamUtils.WrapperUtils)res).AddDatabase().messageUtils.m_MethodUtils)));
				}
			}

			// Token: 0x06000284 RID: 644 RVA: 0x0000E750 File Offset: 0x0000C950
			public ParamUtils.DescriptorAdvisor SortUtils(ParamUtils.DescriptorAdvisor asset)
			{
				if (asset.OrderPublisher())
				{
					asset = asset.CustomizePublisher();
				}
				if (asset.ResolveParameter())
				{
					if (System.IntPtr.Size == 8)
					{
						return new ParamUtils.WrapperUtils(checked(((ParamUtils.CollectionUtils)asset).DefineDatabase().m_ContextUtils.m_ProcessorUtils - this.DefineDatabase().m_ContextUtils.m_ProcessorUtils));
					}
					return new ParamUtils.WrapperUtils((long)(checked(((ParamUtils.CollectionUtils)asset).messageUtils.m_MethodUtils - this.AddDatabase().messageUtils.m_MethodUtils)));
				}
				else
				{
					if (!asset.InterruptParameter())
					{
						throw new ParamUtils.ExporterUtils();
					}
					if (System.IntPtr.Size == 8)
					{
						return new ParamUtils.WrapperUtils(checked(((ParamUtils.WrapperUtils)asset).DefineDatabase().m_ContextUtils.m_ProcessorUtils - this.DefineDatabase().m_ContextUtils.m_ProcessorUtils));
					}
					return new ParamUtils.WrapperUtils((long)(checked(((ParamUtils.WrapperUtils)asset).AddDatabase().messageUtils.m_MethodUtils - this.AddDatabase().messageUtils.m_MethodUtils)));
				}
			}

			// Token: 0x06000285 RID: 645 RVA: 0x0000E840 File Offset: 0x0000CA40
			public override ParamUtils.DescriptorAdvisor InterruptPublisher(ParamUtils.DescriptorAdvisor first)
			{
				if (first.OrderPublisher())
				{
					first = first.CustomizePublisher();
				}
				if (first.ResolveParameter())
				{
					if (System.IntPtr.Size == 8)
					{
						return new ParamUtils.WrapperUtils(checked(this.DefineDatabase().m_ContextUtils.decoratorUtils - unchecked((ulong)((ParamUtils.CollectionUtils)first).messageUtils.m_RequestUtils)));
					}
					return new ParamUtils.WrapperUtils((long)((ulong)(checked(this.AddDatabase().messageUtils.m_RequestUtils - ((ParamUtils.CollectionUtils)first).messageUtils.m_RequestUtils))));
				}
				else
				{
					if (!first.InterruptParameter())
					{
						throw new ParamUtils.ExporterUtils();
					}
					if (System.IntPtr.Size == 8)
					{
						return new ParamUtils.WrapperUtils(checked(this.DefineDatabase().m_ContextUtils.decoratorUtils - ((ParamUtils.WrapperUtils)first).DefineDatabase().m_ContextUtils.decoratorUtils));
					}
					return new ParamUtils.WrapperUtils((ulong)(checked(this.AddDatabase().messageUtils.m_RequestUtils - ((ParamUtils.WrapperUtils)first).AddDatabase().messageUtils.m_RequestUtils)));
				}
			}

			// Token: 0x06000286 RID: 646 RVA: 0x0000E92C File Offset: 0x0000CB2C
			public ParamUtils.DescriptorAdvisor CancelUtils(ParamUtils.DescriptorAdvisor key)
			{
				if (key.OrderPublisher())
				{
					key = key.CustomizePublisher();
				}
				if (key.ResolveParameter())
				{
					if (System.IntPtr.Size == 8)
					{
						return new ParamUtils.WrapperUtils(checked(unchecked((ulong)((ParamUtils.CollectionUtils)key).messageUtils.m_RequestUtils) - this.DefineDatabase().m_ContextUtils.decoratorUtils));
					}
					return new ParamUtils.WrapperUtils((long)((ulong)(checked(((ParamUtils.CollectionUtils)key).messageUtils.m_RequestUtils - this.AddDatabase().messageUtils.m_RequestUtils))));
				}
				else
				{
					if (!key.InterruptParameter())
					{
						throw new ParamUtils.ExporterUtils();
					}
					if (System.IntPtr.Size == 8)
					{
						return new ParamUtils.WrapperUtils(checked(((ParamUtils.WrapperUtils)key).DefineDatabase().m_ContextUtils.decoratorUtils - this.DefineDatabase().m_ContextUtils.decoratorUtils));
					}
					return new ParamUtils.WrapperUtils((ulong)(checked(((ParamUtils.WrapperUtils)key).AddDatabase().messageUtils.m_RequestUtils - this.AddDatabase().messageUtils.m_RequestUtils)));
				}
			}

			// Token: 0x06000287 RID: 647 RVA: 0x0000EA18 File Offset: 0x0000CC18
			public override ParamUtils.DescriptorAdvisor CallPublisher(ParamUtils.DescriptorAdvisor i)
			{
				if (i.OrderPublisher())
				{
					i = i.CustomizePublisher();
				}
				if (!i.ResolveParameter())
				{
					if (!i.InterruptParameter())
					{
						throw new ParamUtils.ExporterUtils();
					}
					if (System.IntPtr.Size == 8)
					{
						return new ParamUtils.WrapperUtils(this.DefineDatabase().m_ContextUtils.m_ProcessorUtils * ((ParamUtils.WrapperUtils)i).DefineDatabase().m_ContextUtils.m_ProcessorUtils);
					}
					return new ParamUtils.WrapperUtils((long)(this.AddDatabase().messageUtils.m_MethodUtils * ((ParamUtils.WrapperUtils)i).AddDatabase().messageUtils.m_MethodUtils));
				}
				else
				{
					if (System.IntPtr.Size == 8)
					{
						return new ParamUtils.WrapperUtils(this.DefineDatabase().m_ContextUtils.m_ProcessorUtils * ((ParamUtils.CollectionUtils)i).DefineDatabase().m_ContextUtils.m_ProcessorUtils);
					}
					return new ParamUtils.WrapperUtils((long)(this.AddDatabase().messageUtils.m_MethodUtils * ((ParamUtils.CollectionUtils)i).messageUtils.m_MethodUtils));
				}
			}

			// Token: 0x06000288 RID: 648 RVA: 0x0000EB08 File Offset: 0x0000CD08
			public override ParamUtils.DescriptorAdvisor FillPublisher(ParamUtils.DescriptorAdvisor reference)
			{
				if (reference.OrderPublisher())
				{
					reference = reference.CustomizePublisher();
				}
				if (reference.ResolveParameter())
				{
					if (System.IntPtr.Size == 8)
					{
						return new ParamUtils.WrapperUtils(checked(this.DefineDatabase().m_ContextUtils.m_ProcessorUtils * ((ParamUtils.CollectionUtils)reference).DefineDatabase().m_ContextUtils.m_ProcessorUtils));
					}
					return new ParamUtils.WrapperUtils((long)(checked(this.AddDatabase().messageUtils.m_MethodUtils * ((ParamUtils.CollectionUtils)reference).messageUtils.m_MethodUtils)));
				}
				else
				{
					if (!reference.InterruptParameter())
					{
						throw new ParamUtils.ExporterUtils();
					}
					if (System.IntPtr.Size == 8)
					{
						return new ParamUtils.WrapperUtils(checked(this.DefineDatabase().m_ContextUtils.m_ProcessorUtils * ((ParamUtils.WrapperUtils)reference).DefineDatabase().m_ContextUtils.m_ProcessorUtils));
					}
					return new ParamUtils.WrapperUtils((long)(checked(this.AddDatabase().messageUtils.m_MethodUtils * ((ParamUtils.WrapperUtils)reference).AddDatabase().messageUtils.m_MethodUtils)));
				}
			}

			// Token: 0x06000289 RID: 649 RVA: 0x0000EBF8 File Offset: 0x0000CDF8
			public override ParamUtils.DescriptorAdvisor QueryPublisher(ParamUtils.DescriptorAdvisor last)
			{
				if (last.OrderPublisher())
				{
					last = last.CustomizePublisher();
				}
				if (!last.ResolveParameter())
				{
					if (!last.InterruptParameter())
					{
						throw new ParamUtils.ExporterUtils();
					}
					if (System.IntPtr.Size == 8)
					{
						return new ParamUtils.WrapperUtils(checked(this.DefineDatabase().m_ContextUtils.decoratorUtils * ((ParamUtils.WrapperUtils)last).DefineDatabase().m_ContextUtils.decoratorUtils));
					}
					return new ParamUtils.WrapperUtils((ulong)(checked(this.AddDatabase().messageUtils.m_RequestUtils * ((ParamUtils.WrapperUtils)last).AddDatabase().messageUtils.m_RequestUtils)));
				}
				else
				{
					if (System.IntPtr.Size == 8)
					{
						return new ParamUtils.WrapperUtils(checked(this.DefineDatabase().m_ContextUtils.decoratorUtils * unchecked((ulong)((ParamUtils.CollectionUtils)last).messageUtils.m_RequestUtils)));
					}
					return new ParamUtils.WrapperUtils((long)((ulong)(checked(this.AddDatabase().messageUtils.m_RequestUtils * ((ParamUtils.CollectionUtils)last).messageUtils.m_RequestUtils))));
				}
			}

			// Token: 0x0600028A RID: 650 RVA: 0x0000ECE4 File Offset: 0x0000CEE4
			public override ParamUtils.DescriptorAdvisor StopPublisher(ParamUtils.DescriptorAdvisor task)
			{
				if (task.OrderPublisher())
				{
					task = task.CustomizePublisher();
				}
				if (!task.ResolveParameter())
				{
					if (!task.InterruptParameter())
					{
						throw new ParamUtils.ExporterUtils();
					}
					if (System.IntPtr.Size == 8)
					{
						return new ParamUtils.WrapperUtils(this.DefineDatabase().m_ContextUtils.m_ProcessorUtils / ((ParamUtils.WrapperUtils)task).DefineDatabase().m_ContextUtils.m_ProcessorUtils);
					}
					return new ParamUtils.WrapperUtils((long)(this.AddDatabase().messageUtils.m_MethodUtils / ((ParamUtils.WrapperUtils)task).AddDatabase().messageUtils.m_MethodUtils));
				}
				else
				{
					if (System.IntPtr.Size == 8)
					{
						return new ParamUtils.WrapperUtils(this.DefineDatabase().m_ContextUtils.m_ProcessorUtils / ((ParamUtils.CollectionUtils)task).DefineDatabase().m_ContextUtils.m_ProcessorUtils);
					}
					return new ParamUtils.WrapperUtils((long)(this.AddDatabase().messageUtils.m_MethodUtils / ((ParamUtils.CollectionUtils)task).messageUtils.m_MethodUtils));
				}
			}

			// Token: 0x0600028B RID: 651 RVA: 0x0000EDD4 File Offset: 0x0000CFD4
			public ParamUtils.DescriptorAdvisor AddUtils(ParamUtils.DescriptorAdvisor res)
			{
				if (res.OrderPublisher())
				{
					res = res.CustomizePublisher();
				}
				if (res.ResolveParameter())
				{
					if (System.IntPtr.Size == 8)
					{
						return new ParamUtils.WrapperUtils(((ParamUtils.CollectionUtils)res).DefineDatabase().m_ContextUtils.m_ProcessorUtils / this.DefineDatabase().m_ContextUtils.m_ProcessorUtils);
					}
					return new ParamUtils.WrapperUtils((long)(((ParamUtils.CollectionUtils)res).messageUtils.m_MethodUtils / this.AddDatabase().messageUtils.m_MethodUtils));
				}
				else
				{
					if (!res.InterruptParameter())
					{
						throw new ParamUtils.ExporterUtils();
					}
					if (System.IntPtr.Size == 8)
					{
						return new ParamUtils.WrapperUtils(((ParamUtils.WrapperUtils)res).DefineDatabase().m_ContextUtils.m_ProcessorUtils / this.DefineDatabase().m_ContextUtils.m_ProcessorUtils);
					}
					return new ParamUtils.WrapperUtils((long)(((ParamUtils.WrapperUtils)res).AddDatabase().messageUtils.m_MethodUtils / this.AddDatabase().messageUtils.m_MethodUtils));
				}
			}

			// Token: 0x0600028C RID: 652 RVA: 0x0000EEC4 File Offset: 0x0000D0C4
			public override ParamUtils.DescriptorAdvisor UpdatePublisher(ParamUtils.DescriptorAdvisor task)
			{
				if (task.OrderPublisher())
				{
					task = task.CustomizePublisher();
				}
				if (task.ResolveParameter())
				{
					if (System.IntPtr.Size == 8)
					{
						return new ParamUtils.WrapperUtils(this.DefineDatabase().m_ContextUtils.decoratorUtils / ((ParamUtils.CollectionUtils)task).DefineDatabase().m_ContextUtils.decoratorUtils);
					}
					return new ParamUtils.WrapperUtils((long)((ulong)(this.AddDatabase().messageUtils.m_RequestUtils / ((ParamUtils.CollectionUtils)task).messageUtils.m_RequestUtils)));
				}
				else
				{
					if (!task.InterruptParameter())
					{
						throw new ParamUtils.ExporterUtils();
					}
					if (System.IntPtr.Size == 8)
					{
						return new ParamUtils.WrapperUtils(this.DefineDatabase().m_ContextUtils.decoratorUtils / ((ParamUtils.WrapperUtils)task).DefineDatabase().m_ContextUtils.decoratorUtils);
					}
					return new ParamUtils.WrapperUtils((ulong)(this.AddDatabase().messageUtils.m_RequestUtils / ((ParamUtils.WrapperUtils)task).AddDatabase().messageUtils.m_RequestUtils));
				}
			}

			// Token: 0x0600028D RID: 653 RVA: 0x0000EFB4 File Offset: 0x0000D1B4
			public ParamUtils.DescriptorAdvisor CheckUtils(ParamUtils.DescriptorAdvisor setup)
			{
				if (setup.OrderPublisher())
				{
					setup = setup.CustomizePublisher();
				}
				if (setup.ResolveParameter())
				{
					if (System.IntPtr.Size == 8)
					{
						return new ParamUtils.WrapperUtils(((ParamUtils.CollectionUtils)setup).DefineDatabase().m_ContextUtils.decoratorUtils / this.DefineDatabase().m_ContextUtils.decoratorUtils);
					}
					return new ParamUtils.WrapperUtils((long)((ulong)(((ParamUtils.CollectionUtils)setup).messageUtils.m_RequestUtils / this.AddDatabase().messageUtils.m_RequestUtils)));
				}
				else
				{
					if (!setup.InterruptParameter())
					{
						throw new ParamUtils.ExporterUtils();
					}
					if (System.IntPtr.Size == 8)
					{
						return new ParamUtils.WrapperUtils(((ParamUtils.WrapperUtils)setup).DefineDatabase().m_ContextUtils.decoratorUtils / this.DefineDatabase().m_ContextUtils.decoratorUtils);
					}
					return new ParamUtils.WrapperUtils((ulong)(((ParamUtils.WrapperUtils)setup).AddDatabase().messageUtils.m_RequestUtils / this.AddDatabase().messageUtils.m_RequestUtils));
				}
			}

			// Token: 0x0600028E RID: 654 RVA: 0x0000F0A4 File Offset: 0x0000D2A4
			public override ParamUtils.DescriptorAdvisor ManagePublisher(ParamUtils.DescriptorAdvisor key)
			{
				if (key.OrderPublisher())
				{
					key = key.CustomizePublisher();
				}
				if (key.ResolveParameter())
				{
					if (System.IntPtr.Size == 8)
					{
						return new ParamUtils.WrapperUtils(this.DefineDatabase().m_ContextUtils.m_ProcessorUtils % ((ParamUtils.CollectionUtils)key).DefineDatabase().m_ContextUtils.m_ProcessorUtils);
					}
					return new ParamUtils.WrapperUtils((long)(this.AddDatabase().messageUtils.m_MethodUtils % ((ParamUtils.CollectionUtils)key).messageUtils.m_MethodUtils));
				}
				else
				{
					if (!key.InterruptParameter())
					{
						throw new ParamUtils.ExporterUtils();
					}
					if (System.IntPtr.Size == 8)
					{
						return new ParamUtils.WrapperUtils(this.DefineDatabase().m_ContextUtils.m_ProcessorUtils % ((ParamUtils.WrapperUtils)key).DefineDatabase().m_ContextUtils.m_ProcessorUtils);
					}
					return new ParamUtils.WrapperUtils((long)(this.AddDatabase().messageUtils.m_MethodUtils % ((ParamUtils.WrapperUtils)key).AddDatabase().messageUtils.m_MethodUtils));
				}
			}

			// Token: 0x0600028F RID: 655 RVA: 0x0000F194 File Offset: 0x0000D394
			public ParamUtils.DescriptorAdvisor DefineUtils(ParamUtils.DescriptorAdvisor res)
			{
				if (res.OrderPublisher())
				{
					res = res.CustomizePublisher();
				}
				if (!res.ResolveParameter())
				{
					if (!res.InterruptParameter())
					{
						throw new ParamUtils.ExporterUtils();
					}
					if (System.IntPtr.Size == 8)
					{
						return new ParamUtils.WrapperUtils(((ParamUtils.WrapperUtils)res).DefineDatabase().m_ContextUtils.m_ProcessorUtils % this.DefineDatabase().m_ContextUtils.m_ProcessorUtils);
					}
					return new ParamUtils.WrapperUtils((long)(((ParamUtils.WrapperUtils)res).AddDatabase().messageUtils.m_MethodUtils % this.AddDatabase().messageUtils.m_MethodUtils));
				}
				else
				{
					if (System.IntPtr.Size == 8)
					{
						return new ParamUtils.WrapperUtils(((ParamUtils.CollectionUtils)res).DefineDatabase().m_ContextUtils.m_ProcessorUtils % this.DefineDatabase().m_ContextUtils.m_ProcessorUtils);
					}
					return new ParamUtils.WrapperUtils((long)(((ParamUtils.CollectionUtils)res).messageUtils.m_MethodUtils % this.AddDatabase().messageUtils.m_MethodUtils));
				}
			}

			// Token: 0x06000290 RID: 656 RVA: 0x0000F284 File Offset: 0x0000D484
			public override ParamUtils.DescriptorAdvisor DisablePublisher(ParamUtils.DescriptorAdvisor last)
			{
				if (last.OrderPublisher())
				{
					last = last.CustomizePublisher();
				}
				if (last.ResolveParameter())
				{
					if (System.IntPtr.Size == 8)
					{
						return new ParamUtils.WrapperUtils(this.DefineDatabase().m_ContextUtils.decoratorUtils % ((ParamUtils.CollectionUtils)last).DefineDatabase().m_ContextUtils.decoratorUtils);
					}
					return new ParamUtils.WrapperUtils((long)((ulong)(this.AddDatabase().messageUtils.m_RequestUtils % ((ParamUtils.CollectionUtils)last).messageUtils.m_RequestUtils)));
				}
				else
				{
					if (!last.InterruptParameter())
					{
						throw new ParamUtils.ExporterUtils();
					}
					if (System.IntPtr.Size == 8)
					{
						return new ParamUtils.WrapperUtils(this.DefineDatabase().m_ContextUtils.decoratorUtils % ((ParamUtils.WrapperUtils)last).DefineDatabase().m_ContextUtils.decoratorUtils);
					}
					return new ParamUtils.WrapperUtils((ulong)(this.AddDatabase().messageUtils.m_RequestUtils % ((ParamUtils.WrapperUtils)last).AddDatabase().messageUtils.m_RequestUtils));
				}
			}

			// Token: 0x06000291 RID: 657 RVA: 0x0000F374 File Offset: 0x0000D574
			public ParamUtils.DescriptorAdvisor ViewUtils(ParamUtils.DescriptorAdvisor var1)
			{
				if (var1.OrderPublisher())
				{
					var1 = var1.CustomizePublisher();
				}
				if (var1.ResolveParameter())
				{
					if (System.IntPtr.Size == 8)
					{
						return new ParamUtils.WrapperUtils(((ParamUtils.CollectionUtils)var1).DefineDatabase().m_ContextUtils.decoratorUtils % this.DefineDatabase().m_ContextUtils.decoratorUtils);
					}
					return new ParamUtils.WrapperUtils((long)((ulong)(((ParamUtils.CollectionUtils)var1).messageUtils.m_RequestUtils % this.AddDatabase().messageUtils.m_RequestUtils)));
				}
				else
				{
					if (!var1.InterruptParameter())
					{
						throw new ParamUtils.ExporterUtils();
					}
					if (System.IntPtr.Size == 8)
					{
						return new ParamUtils.WrapperUtils(((ParamUtils.WrapperUtils)var1).DefineDatabase().m_ContextUtils.decoratorUtils % this.DefineDatabase().m_ContextUtils.decoratorUtils);
					}
					return new ParamUtils.WrapperUtils((ulong)(((ParamUtils.WrapperUtils)var1).AddDatabase().messageUtils.m_RequestUtils % this.AddDatabase().messageUtils.m_RequestUtils));
				}
			}

			// Token: 0x06000292 RID: 658 RVA: 0x0000F464 File Offset: 0x0000D664
			public override ParamUtils.DescriptorAdvisor ComputePublisher(ParamUtils.DescriptorAdvisor info)
			{
				if (info.OrderPublisher())
				{
					info = info.CustomizePublisher();
				}
				if (!info.ResolveParameter())
				{
					if (!info.InterruptParameter())
					{
						throw new ParamUtils.ExporterUtils();
					}
					if (System.IntPtr.Size == 8)
					{
						return new ParamUtils.WrapperUtils(this.DefineDatabase().m_ContextUtils.m_ProcessorUtils & ((ParamUtils.WrapperUtils)info).DefineDatabase().m_ContextUtils.m_ProcessorUtils);
					}
					return new ParamUtils.WrapperUtils((long)(this.AddDatabase().messageUtils.m_MethodUtils & ((ParamUtils.WrapperUtils)info).AddDatabase().messageUtils.m_MethodUtils));
				}
				else
				{
					if (System.IntPtr.Size == 8)
					{
						return new ParamUtils.WrapperUtils(this.DefineDatabase().m_ContextUtils.m_ProcessorUtils & ((ParamUtils.CollectionUtils)info).DefineDatabase().m_ContextUtils.m_ProcessorUtils);
					}
					return new ParamUtils.WrapperUtils((long)(this.AddDatabase().messageUtils.m_MethodUtils & ((ParamUtils.CollectionUtils)info).messageUtils.m_MethodUtils));
				}
			}

			// Token: 0x06000293 RID: 659 RVA: 0x0000F554 File Offset: 0x0000D754
			public override ParamUtils.DescriptorAdvisor PostPublisher(ParamUtils.DescriptorAdvisor last)
			{
				if (last.OrderPublisher())
				{
					last = last.CustomizePublisher();
				}
				if (!last.ResolveParameter())
				{
					if (!last.InterruptParameter())
					{
						throw new ParamUtils.ExporterUtils();
					}
					if (System.IntPtr.Size == 8)
					{
						return new ParamUtils.WrapperUtils(this.DefineDatabase().m_ContextUtils.m_ProcessorUtils | ((ParamUtils.WrapperUtils)last).DefineDatabase().m_ContextUtils.m_ProcessorUtils);
					}
					return new ParamUtils.WrapperUtils((long)(this.AddDatabase().messageUtils.m_MethodUtils | ((ParamUtils.WrapperUtils)last).AddDatabase().messageUtils.m_MethodUtils));
				}
				else
				{
					if (System.IntPtr.Size == 8)
					{
						return new ParamUtils.WrapperUtils(this.DefineDatabase().m_ContextUtils.m_ProcessorUtils | ((ParamUtils.CollectionUtils)last).DefineDatabase().m_ContextUtils.m_ProcessorUtils);
					}
					return new ParamUtils.WrapperUtils((long)(this.AddDatabase().messageUtils.m_MethodUtils | ((ParamUtils.CollectionUtils)last).messageUtils.m_MethodUtils));
				}
			}

			// Token: 0x06000294 RID: 660 RVA: 0x0000F644 File Offset: 0x0000D844
			public override ParamUtils.DescriptorAdvisor LoginPublisher()
			{
				if (System.IntPtr.Size == 8)
				{
					return new ParamUtils.WrapperUtils(~this.DefineDatabase().m_ContextUtils.m_ProcessorUtils);
				}
				return new ParamUtils.WrapperUtils((long)(~(long)this.AddDatabase().messageUtils.m_MethodUtils));
			}

			// Token: 0x06000295 RID: 661 RVA: 0x0000F688 File Offset: 0x0000D888
			public override ParamUtils.DescriptorAdvisor AssetPublisher(ParamUtils.DescriptorAdvisor setup)
			{
				if (setup.OrderPublisher())
				{
					setup = setup.CustomizePublisher();
				}
				if (setup.ResolveParameter())
				{
					if (System.IntPtr.Size == 8)
					{
						return new ParamUtils.WrapperUtils(this.DefineDatabase().m_ContextUtils.m_ProcessorUtils ^ ((ParamUtils.CollectionUtils)setup).DefineDatabase().m_ContextUtils.m_ProcessorUtils);
					}
					return new ParamUtils.WrapperUtils((long)(this.AddDatabase().messageUtils.m_MethodUtils ^ ((ParamUtils.CollectionUtils)setup).messageUtils.m_MethodUtils));
				}
				else
				{
					if (!setup.InterruptParameter())
					{
						throw new ParamUtils.ExporterUtils();
					}
					if (System.IntPtr.Size == 8)
					{
						return new ParamUtils.WrapperUtils(this.DefineDatabase().m_ContextUtils.m_ProcessorUtils ^ ((ParamUtils.WrapperUtils)setup).DefineDatabase().m_ContextUtils.m_ProcessorUtils);
					}
					return new ParamUtils.WrapperUtils((long)(this.AddDatabase().messageUtils.m_MethodUtils ^ ((ParamUtils.WrapperUtils)setup).AddDatabase().messageUtils.m_MethodUtils));
				}
			}

			// Token: 0x06000296 RID: 662 RVA: 0x0000F778 File Offset: 0x0000D978
			public override ParamUtils.DescriptorAdvisor NewPublisher(ParamUtils.DescriptorAdvisor reference)
			{
				if (reference.OrderPublisher())
				{
					reference = reference.CustomizePublisher();
				}
				if (reference.ResolveParameter())
				{
					if (System.IntPtr.Size == 8)
					{
						return new ParamUtils.WrapperUtils(this.DefineDatabase().m_ContextUtils.m_ProcessorUtils << ((ParamUtils.CollectionUtils)reference).messageUtils.m_MethodUtils);
					}
					return new ParamUtils.WrapperUtils((long)((long)this.AddDatabase().messageUtils.m_MethodUtils << ((ParamUtils.CollectionUtils)reference).messageUtils.m_MethodUtils));
				}
				else
				{
					if (!reference.InterruptParameter())
					{
						throw new ParamUtils.ExporterUtils();
					}
					if (System.IntPtr.Size == 8)
					{
						return new ParamUtils.WrapperUtils(this.DefineDatabase().m_ContextUtils.m_ProcessorUtils << ((ParamUtils.WrapperUtils)reference).DefineDatabase().m_ContextUtils.configurationUtils);
					}
					return new ParamUtils.WrapperUtils((long)((long)this.AddDatabase().messageUtils.m_MethodUtils << ((ParamUtils.WrapperUtils)reference).AddDatabase().messageUtils.m_MethodUtils));
				}
			}

			// Token: 0x06000297 RID: 663 RVA: 0x0000F870 File Offset: 0x0000DA70
			public override ParamUtils.DescriptorAdvisor SelectPublisher(ParamUtils.DescriptorAdvisor value)
			{
				if (value.OrderPublisher())
				{
					value = value.CustomizePublisher();
				}
				if (!value.ResolveParameter())
				{
					if (!value.InterruptParameter())
					{
						throw new ParamUtils.ExporterUtils();
					}
					if (System.IntPtr.Size == 8)
					{
						return new ParamUtils.WrapperUtils(this.DefineDatabase().m_ContextUtils.m_ProcessorUtils >> ((ParamUtils.WrapperUtils)value).DefineDatabase().m_ContextUtils.configurationUtils);
					}
					return new ParamUtils.WrapperUtils((long)(this.AddDatabase().messageUtils.m_MethodUtils >> ((ParamUtils.WrapperUtils)value).AddDatabase().messageUtils.m_MethodUtils));
				}
				else
				{
					if (System.IntPtr.Size == 8)
					{
						return new ParamUtils.WrapperUtils(this.DefineDatabase().m_ContextUtils.m_ProcessorUtils >> ((ParamUtils.CollectionUtils)value).messageUtils.m_MethodUtils);
					}
					return new ParamUtils.WrapperUtils((long)(this.AddDatabase().messageUtils.m_MethodUtils >> ((ParamUtils.CollectionUtils)value).messageUtils.m_MethodUtils));
				}
			}

			// Token: 0x06000298 RID: 664 RVA: 0x0000F968 File Offset: 0x0000DB68
			public override ParamUtils.DescriptorAdvisor RemovePublisher(ParamUtils.DescriptorAdvisor key)
			{
				if (key.OrderPublisher())
				{
					key = key.CustomizePublisher();
				}
				if (key.ResolveParameter())
				{
					if (System.IntPtr.Size == 8)
					{
						return new ParamUtils.WrapperUtils(this.DefineDatabase().m_ContextUtils.decoratorUtils >> ((ParamUtils.CollectionUtils)key).messageUtils.m_MethodUtils);
					}
					return new ParamUtils.WrapperUtils((long)((ulong)(this.AddDatabase().messageUtils.m_RequestUtils >> ((ParamUtils.CollectionUtils)key).messageUtils.m_MethodUtils)));
				}
				else
				{
					if (!key.InterruptParameter())
					{
						throw new ParamUtils.ExporterUtils();
					}
					if (System.IntPtr.Size == 8)
					{
						return new ParamUtils.WrapperUtils(this.DefineDatabase().m_ContextUtils.decoratorUtils >> ((ParamUtils.WrapperUtils)key).DefineDatabase().m_ContextUtils.configurationUtils);
					}
					return new ParamUtils.WrapperUtils((long)((ulong)(this.AddDatabase().messageUtils.m_RequestUtils >> ((ParamUtils.WrapperUtils)key).AddDatabase().messageUtils.m_MethodUtils)));
				}
			}

			// Token: 0x06000299 RID: 665 RVA: 0x0000317C File Offset: 0x0000137C
			public ParamUtils.DescriptorAdvisor RevertUtils(ParamUtils.CollectionUtils ident)
			{
				return new ParamUtils.WrapperUtils((long)((ulong)(ident.messageUtils.m_RequestUtils >> this.AddDatabase().messageUtils.m_MethodUtils)));
			}

			// Token: 0x0600029A RID: 666 RVA: 0x000031A3 File Offset: 0x000013A3
			public ParamUtils.DescriptorAdvisor PublishAdvisor(ParamUtils.CollectionUtils spec)
			{
				return new ParamUtils.WrapperUtils((long)(spec.messageUtils.m_MethodUtils >> this.DefineDatabase().m_ContextUtils.configurationUtils));
			}

			// Token: 0x0600029B RID: 667 RVA: 0x000031CA File Offset: 0x000013CA
			public ParamUtils.DescriptorAdvisor SetupAdvisor(ParamUtils.CollectionUtils init)
			{
				return new ParamUtils.WrapperUtils((long)((long)init.messageUtils.m_MethodUtils << this.DefineDatabase().m_ContextUtils.configurationUtils));
			}

			// Token: 0x0600029C RID: 668 RVA: 0x000031F1 File Offset: 0x000013F1
			public override string ToString()
			{
				return this.m_RegistryUtils.ToString();
			}

			// Token: 0x0600029D RID: 669 RVA: 0x00002DB0 File Offset: 0x00000FB0
			internal override ParamUtils.DescriptorAdvisor CustomizePublisher()
			{
				return this;
			}

			// Token: 0x0600029E RID: 670 RVA: 0x00002728 File Offset: 0x00000928
			internal override bool ConnectPublisher()
			{
				return true;
			}

			// Token: 0x0600029F RID: 671 RVA: 0x0000FA60 File Offset: 0x0000DC60
			internal override bool ValidatePublisher(ParamUtils.DescriptorAdvisor last)
			{
				if (last.MoveParameter())
				{
					return false;
				}
				if (last.OrderPublisher())
				{
					return ((ParamUtils.ProducerUtils)last).ValidatePublisher(this);
				}
				ParamUtils.DescriptorAdvisor descriptorAdvisor = last.CustomizePublisher();
				if (!descriptorAdvisor.ConnectPublisher())
				{
					return false;
				}
				if (descriptorAdvisor.ResolveParameter())
				{
					if (System.IntPtr.Size == 8)
					{
						return this.DefineDatabase().m_ContextUtils.m_ProcessorUtils == ((ParamUtils.CollectionUtils)last).DefineDatabase().m_ContextUtils.m_ProcessorUtils;
					}
					return this.AddDatabase().messageUtils.m_MethodUtils == ((ParamUtils.CollectionUtils)last).messageUtils.m_MethodUtils;
				}
				else
				{
					if (!descriptorAdvisor.InterruptParameter())
					{
						return false;
					}
					int size = System.IntPtr.Size;
					return this.DefineDatabase().m_ContextUtils.m_ProcessorUtils == ((ParamUtils.WrapperUtils)last).DefineDatabase().m_ContextUtils.m_ProcessorUtils;
				}
			}

			// Token: 0x060002A0 RID: 672 RVA: 0x0000FB3C File Offset: 0x0000DD3C
			internal override bool ResetPublisher(ParamUtils.DescriptorAdvisor asset)
			{
				if (asset.MoveParameter())
				{
					return false;
				}
				if (asset.OrderPublisher())
				{
					return ((ParamUtils.ProducerUtils)asset).ResetPublisher(this);
				}
				ParamUtils.DescriptorAdvisor descriptorAdvisor = asset.CustomizePublisher();
				if (!descriptorAdvisor.ConnectPublisher())
				{
					return false;
				}
				if (!descriptorAdvisor.ResolveParameter())
				{
					if (!descriptorAdvisor.InterruptParameter())
					{
						return false;
					}
					int size = System.IntPtr.Size;
					return this.DefineDatabase().m_ContextUtils.decoratorUtils != ((ParamUtils.WrapperUtils)asset).DefineDatabase().m_ContextUtils.decoratorUtils;
				}
				else
				{
					if (System.IntPtr.Size == 8)
					{
						return this.DefineDatabase().m_ContextUtils.decoratorUtils != ((ParamUtils.CollectionUtils)asset).DefineDatabase().m_ContextUtils.decoratorUtils;
					}
					return this.AddDatabase().messageUtils.m_RequestUtils != ((ParamUtils.CollectionUtils)asset).messageUtils.m_RequestUtils;
				}
			}

			// Token: 0x060002A1 RID: 673 RVA: 0x0000FC20 File Offset: 0x0000DE20
			public override bool ComparePublisher(ParamUtils.DescriptorAdvisor last)
			{
				if (last.OrderPublisher())
				{
					last = last.CustomizePublisher();
				}
				if (last.ResolveParameter())
				{
					if (System.IntPtr.Size == 8)
					{
						return this.DefineDatabase().m_ContextUtils.m_ProcessorUtils >= ((ParamUtils.CollectionUtils)last).DefineDatabase().m_ContextUtils.m_ProcessorUtils;
					}
					return this.AddDatabase().messageUtils.m_MethodUtils >= ((ParamUtils.CollectionUtils)last).messageUtils.m_MethodUtils;
				}
				else
				{
					if (!last.InterruptParameter())
					{
						throw new ParamUtils.ExporterUtils();
					}
					if (System.IntPtr.Size == 8)
					{
						return this.DefineDatabase().m_ContextUtils.m_ProcessorUtils >= ((ParamUtils.WrapperUtils)last).DefineDatabase().m_ContextUtils.m_ProcessorUtils;
					}
					return this.AddDatabase().messageUtils.m_MethodUtils >= ((ParamUtils.WrapperUtils)last).AddDatabase().messageUtils.m_MethodUtils;
				}
			}

			// Token: 0x060002A2 RID: 674 RVA: 0x0000FD0C File Offset: 0x0000DF0C
			public override bool PrintPublisher(ParamUtils.DescriptorAdvisor config)
			{
				if (config.OrderPublisher())
				{
					config = config.CustomizePublisher();
				}
				if (!config.ResolveParameter())
				{
					if (!config.InterruptParameter())
					{
						throw new ParamUtils.ExporterUtils();
					}
					if (System.IntPtr.Size == 8)
					{
						return this.DefineDatabase().m_ContextUtils.decoratorUtils >= ((ParamUtils.WrapperUtils)config).DefineDatabase().m_ContextUtils.decoratorUtils;
					}
					return this.AddDatabase().messageUtils.m_RequestUtils >= ((ParamUtils.WrapperUtils)config).AddDatabase().messageUtils.m_RequestUtils;
				}
				else
				{
					if (System.IntPtr.Size == 8)
					{
						return this.DefineDatabase().m_ContextUtils.decoratorUtils >= ((ParamUtils.CollectionUtils)config).DefineDatabase().m_ContextUtils.decoratorUtils;
					}
					return this.AddDatabase().messageUtils.m_RequestUtils >= ((ParamUtils.CollectionUtils)config).messageUtils.m_RequestUtils;
				}
			}

			// Token: 0x060002A3 RID: 675 RVA: 0x0000FDF8 File Offset: 0x0000DFF8
			public override bool PreparePublisher(ParamUtils.DescriptorAdvisor key)
			{
				if (key.OrderPublisher())
				{
					key = key.CustomizePublisher();
				}
				if (key.ResolveParameter())
				{
					if (System.IntPtr.Size == 8)
					{
						return this.DefineDatabase().m_ContextUtils.m_ProcessorUtils > ((ParamUtils.CollectionUtils)key).DefineDatabase().m_ContextUtils.m_ProcessorUtils;
					}
					return this.AddDatabase().messageUtils.m_MethodUtils > ((ParamUtils.CollectionUtils)key).messageUtils.m_MethodUtils;
				}
				else
				{
					if (!key.InterruptParameter())
					{
						throw new ParamUtils.ExporterUtils();
					}
					if (System.IntPtr.Size == 8)
					{
						return this.DefineDatabase().m_ContextUtils.m_ProcessorUtils > ((ParamUtils.WrapperUtils)key).DefineDatabase().m_ContextUtils.m_ProcessorUtils;
					}
					return this.AddDatabase().messageUtils.m_MethodUtils > ((ParamUtils.WrapperUtils)key).AddDatabase().messageUtils.m_MethodUtils;
				}
			}

			// Token: 0x060002A4 RID: 676 RVA: 0x0000FED8 File Offset: 0x0000E0D8
			public override bool LogoutPublisher(ParamUtils.DescriptorAdvisor spec)
			{
				if (spec.OrderPublisher())
				{
					spec = spec.CustomizePublisher();
				}
				if (!spec.ResolveParameter())
				{
					if (!spec.InterruptParameter())
					{
						throw new ParamUtils.ExporterUtils();
					}
					if (System.IntPtr.Size == 8)
					{
						return this.DefineDatabase().m_ContextUtils.decoratorUtils > ((ParamUtils.WrapperUtils)spec).DefineDatabase().m_ContextUtils.decoratorUtils;
					}
					return this.AddDatabase().messageUtils.m_RequestUtils > ((ParamUtils.WrapperUtils)spec).AddDatabase().messageUtils.m_RequestUtils;
				}
				else
				{
					if (System.IntPtr.Size == 8)
					{
						return this.DefineDatabase().m_ContextUtils.decoratorUtils > ((ParamUtils.CollectionUtils)spec).DefineDatabase().m_ContextUtils.decoratorUtils;
					}
					return this.AddDatabase().messageUtils.m_RequestUtils > ((ParamUtils.CollectionUtils)spec).messageUtils.m_RequestUtils;
				}
			}

			// Token: 0x060002A5 RID: 677 RVA: 0x0000FFB8 File Offset: 0x0000E1B8
			public override bool FindPublisher(ParamUtils.DescriptorAdvisor i)
			{
				if (i.OrderPublisher())
				{
					i = i.CustomizePublisher();
				}
				if (i.ResolveParameter())
				{
					if (System.IntPtr.Size == 8)
					{
						return this.DefineDatabase().m_ContextUtils.m_ProcessorUtils <= ((ParamUtils.CollectionUtils)i).DefineDatabase().m_ContextUtils.m_ProcessorUtils;
					}
					return this.AddDatabase().messageUtils.m_MethodUtils <= ((ParamUtils.CollectionUtils)i).messageUtils.m_MethodUtils;
				}
				else
				{
					if (!i.InterruptParameter())
					{
						throw new ParamUtils.ExporterUtils();
					}
					if (System.IntPtr.Size == 8)
					{
						return this.DefineDatabase().m_ContextUtils.m_ProcessorUtils <= ((ParamUtils.WrapperUtils)i).DefineDatabase().m_ContextUtils.m_ProcessorUtils;
					}
					return this.AddDatabase().messageUtils.m_MethodUtils <= ((ParamUtils.WrapperUtils)i).AddDatabase().messageUtils.m_MethodUtils;
				}
			}

			// Token: 0x060002A6 RID: 678 RVA: 0x000100A4 File Offset: 0x0000E2A4
			public override bool TestPublisher(ParamUtils.DescriptorAdvisor key)
			{
				if (key.OrderPublisher())
				{
					key = key.CustomizePublisher();
				}
				if (!key.ResolveParameter())
				{
					if (!key.InterruptParameter())
					{
						throw new ParamUtils.ExporterUtils();
					}
					if (System.IntPtr.Size == 8)
					{
						return this.DefineDatabase().m_ContextUtils.decoratorUtils <= ((ParamUtils.WrapperUtils)key).DefineDatabase().m_ContextUtils.decoratorUtils;
					}
					return this.AddDatabase().messageUtils.m_RequestUtils <= ((ParamUtils.WrapperUtils)key).AddDatabase().messageUtils.m_RequestUtils;
				}
				else
				{
					if (System.IntPtr.Size == 8)
					{
						return this.DefineDatabase().m_ContextUtils.decoratorUtils <= ((ParamUtils.CollectionUtils)key).DefineDatabase().m_ContextUtils.decoratorUtils;
					}
					return this.AddDatabase().messageUtils.m_RequestUtils <= ((ParamUtils.CollectionUtils)key).messageUtils.m_RequestUtils;
				}
			}

			// Token: 0x060002A7 RID: 679 RVA: 0x00010190 File Offset: 0x0000E390
			public override bool RatePublisher(ParamUtils.DescriptorAdvisor item)
			{
				if (item.OrderPublisher())
				{
					item = item.CustomizePublisher();
				}
				if (item.ResolveParameter())
				{
					if (System.IntPtr.Size == 8)
					{
						return this.DefineDatabase().m_ContextUtils.m_ProcessorUtils < ((ParamUtils.CollectionUtils)item).DefineDatabase().m_ContextUtils.m_ProcessorUtils;
					}
					return this.AddDatabase().messageUtils.m_MethodUtils < ((ParamUtils.CollectionUtils)item).messageUtils.m_MethodUtils;
				}
				else
				{
					if (!item.InterruptParameter())
					{
						throw new ParamUtils.ExporterUtils();
					}
					if (System.IntPtr.Size == 8)
					{
						return this.DefineDatabase().m_ContextUtils.m_ProcessorUtils < ((ParamUtils.WrapperUtils)item).DefineDatabase().m_ContextUtils.m_ProcessorUtils;
					}
					return this.AddDatabase().messageUtils.m_MethodUtils < ((ParamUtils.WrapperUtils)item).AddDatabase().messageUtils.m_MethodUtils;
				}
			}

			// Token: 0x060002A8 RID: 680 RVA: 0x00010270 File Offset: 0x0000E470
			public override bool RestartPublisher(ParamUtils.DescriptorAdvisor asset)
			{
				if (asset.OrderPublisher())
				{
					asset = asset.CustomizePublisher();
				}
				if (!asset.ResolveParameter())
				{
					if (!asset.InterruptParameter())
					{
						throw new ParamUtils.ExporterUtils();
					}
					if (System.IntPtr.Size == 8)
					{
						return this.DefineDatabase().m_ContextUtils.decoratorUtils < ((ParamUtils.WrapperUtils)asset).DefineDatabase().m_ContextUtils.decoratorUtils;
					}
					return this.AddDatabase().messageUtils.m_RequestUtils < ((ParamUtils.WrapperUtils)asset).AddDatabase().messageUtils.m_RequestUtils;
				}
				else
				{
					if (System.IntPtr.Size == 8)
					{
						return this.DefineDatabase().m_ContextUtils.decoratorUtils < ((ParamUtils.CollectionUtils)asset).DefineDatabase().m_ContextUtils.decoratorUtils;
					}
					return this.AddDatabase().messageUtils.m_RequestUtils < ((ParamUtils.CollectionUtils)asset).messageUtils.m_RequestUtils;
				}
			}

			// Token: 0x04000092 RID: 146
			public object m_RegistryUtils;

			// Token: 0x04000093 RID: 147
			public ParamUtils.ProcessUtils m_CodeUtils;
		}

		// Token: 0x0200002D RID: 45
		private abstract class ComparatorUtils : ParamUtils.DescriptorAdvisor
		{
			// Token: 0x060002A9 RID: 681
			public abstract bool LogoutDatabase();

			// Token: 0x060002AA RID: 682
			public abstract bool FindDatabase();

			// Token: 0x060002AB RID: 683
			public abstract ParamUtils.DescriptorAdvisor TestDatabase(ParamUtils.ProcessUtils spec);

			// Token: 0x060002AC RID: 684
			public abstract ParamUtils.CollectionUtils RestartDatabase();

			// Token: 0x060002AD RID: 685
			public abstract ParamUtils.CollectionUtils InstantiateDatabase();

			// Token: 0x060002AE RID: 686
			public abstract ParamUtils.CollectionUtils OrderDatabase();

			// Token: 0x060002AF RID: 687
			public abstract ParamUtils.CollectionUtils SortDatabase();

			// Token: 0x060002B0 RID: 688
			public abstract ParamUtils.CollectionUtils CancelDatabase();

			// Token: 0x060002B1 RID: 689
			public abstract ParamUtils.CollectionUtils AddDatabase();

			// Token: 0x060002B2 RID: 690
			public abstract ParamUtils.CollectionUtils CheckDatabase();

			// Token: 0x060002B3 RID: 691
			public abstract ParamUtils.ReponseUtils DefineDatabase();

			// Token: 0x060002B4 RID: 692
			public abstract ParamUtils.ReponseUtils ViewDatabase();

			// Token: 0x060002B5 RID: 693
			public abstract ParamUtils.CollectionUtils RevertDatabase();

			// Token: 0x060002B6 RID: 694
			public abstract ParamUtils.CollectionUtils PublishPublisher();

			// Token: 0x060002B7 RID: 695
			public abstract ParamUtils.CollectionUtils SetupPublisher();

			// Token: 0x060002B8 RID: 696
			public abstract ParamUtils.ReponseUtils SetPublisher();

			// Token: 0x060002B9 RID: 697
			public abstract ParamUtils.CollectionUtils CountPublisher();

			// Token: 0x060002BA RID: 698
			public abstract ParamUtils.CollectionUtils ReflectPublisher();

			// Token: 0x060002BB RID: 699
			public abstract ParamUtils.CollectionUtils WritePublisher();

			// Token: 0x060002BC RID: 700
			public abstract ParamUtils.ReponseUtils ClonePublisher();

			// Token: 0x060002BD RID: 701
			public abstract ParamUtils.CollectionUtils VisitPublisher();

			// Token: 0x060002BE RID: 702
			public abstract ParamUtils.CollectionUtils MapPublisher();

			// Token: 0x060002BF RID: 703
			public abstract ParamUtils.CollectionUtils VerifyPublisher();

			// Token: 0x060002C0 RID: 704
			public abstract ParamUtils.CollectionUtils ChangePublisher();

			// Token: 0x060002C1 RID: 705
			public abstract ParamUtils.CollectionUtils ListPublisher();

			// Token: 0x060002C2 RID: 706
			public abstract ParamUtils.CollectionUtils IncludePublisher();

			// Token: 0x060002C3 RID: 707
			public abstract ParamUtils.ReponseUtils CreatePublisher();

			// Token: 0x060002C4 RID: 708
			public abstract ParamUtils.ReponseUtils EnablePublisher();

			// Token: 0x060002C5 RID: 709
			public abstract ParamUtils.CollectionUtils PatchPublisher();

			// Token: 0x060002C6 RID: 710
			public abstract ParamUtils.CollectionUtils ForgotPublisher();

			// Token: 0x060002C7 RID: 711
			public abstract ParamUtils.CollectionUtils InitPublisher();

			// Token: 0x060002C8 RID: 712
			public abstract ParamUtils.CollectionUtils CollectPublisher();

			// Token: 0x060002C9 RID: 713
			public abstract ParamUtils.CollectionUtils ConcatPublisher();

			// Token: 0x060002CA RID: 714
			public abstract ParamUtils.CollectionUtils InvokePublisher();

			// Token: 0x060002CB RID: 715
			public abstract ParamUtils.ReponseUtils AwakePublisher();

			// Token: 0x060002CC RID: 716
			public abstract ParamUtils.ReponseUtils FlushPublisher();

			// Token: 0x060002CD RID: 717
			public abstract ParamUtils.CreatorUtils PopPublisher();

			// Token: 0x060002CE RID: 718
			public abstract ParamUtils.CreatorUtils RegisterPublisher();

			// Token: 0x060002CF RID: 719
			public abstract ParamUtils.CreatorUtils CalcPublisher();

			// Token: 0x060002D0 RID: 720
			public abstract ParamUtils.WrapperUtils DestroyPublisher();

			// Token: 0x060002D1 RID: 721
			public abstract ParamUtils.WrapperUtils GetPublisher();

			// Token: 0x060002D2 RID: 722
			public abstract ParamUtils.WrapperUtils StartPublisher();

			// Token: 0x060002D3 RID: 723
			public abstract ParamUtils.WrapperUtils SearchPublisher();

			// Token: 0x060002D4 RID: 724
			public abstract ParamUtils.WrapperUtils PushPublisher();

			// Token: 0x060002D5 RID: 725
			public abstract ParamUtils.WrapperUtils ReadPublisher();

			// Token: 0x060002D6 RID: 726
			public abstract ParamUtils.DescriptorAdvisor ExcludePublisher();

			// Token: 0x060002D7 RID: 727
			public abstract ParamUtils.DescriptorAdvisor CalculatePublisher(ParamUtils.DescriptorAdvisor last);

			// Token: 0x060002D8 RID: 728
			public abstract ParamUtils.DescriptorAdvisor DeletePublisher(ParamUtils.DescriptorAdvisor v);

			// Token: 0x060002D9 RID: 729
			public abstract ParamUtils.DescriptorAdvisor RunPublisher(ParamUtils.DescriptorAdvisor res);

			// Token: 0x060002DA RID: 730
			public abstract ParamUtils.DescriptorAdvisor MovePublisher(ParamUtils.DescriptorAdvisor first);

			// Token: 0x060002DB RID: 731
			public abstract ParamUtils.DescriptorAdvisor ResolvePublisher(ParamUtils.DescriptorAdvisor first);

			// Token: 0x060002DC RID: 732
			public abstract ParamUtils.DescriptorAdvisor InterruptPublisher(ParamUtils.DescriptorAdvisor spec);

			// Token: 0x060002DD RID: 733
			public abstract ParamUtils.DescriptorAdvisor CallPublisher(ParamUtils.DescriptorAdvisor value);

			// Token: 0x060002DE RID: 734
			public abstract ParamUtils.DescriptorAdvisor FillPublisher(ParamUtils.DescriptorAdvisor first);

			// Token: 0x060002DF RID: 735
			public abstract ParamUtils.DescriptorAdvisor QueryPublisher(ParamUtils.DescriptorAdvisor last);

			// Token: 0x060002E0 RID: 736
			public abstract ParamUtils.DescriptorAdvisor StopPublisher(ParamUtils.DescriptorAdvisor config);

			// Token: 0x060002E1 RID: 737
			public abstract ParamUtils.DescriptorAdvisor UpdatePublisher(ParamUtils.DescriptorAdvisor setup);

			// Token: 0x060002E2 RID: 738
			public abstract ParamUtils.DescriptorAdvisor ManagePublisher(ParamUtils.DescriptorAdvisor first);

			// Token: 0x060002E3 RID: 739
			public abstract ParamUtils.DescriptorAdvisor DisablePublisher(ParamUtils.DescriptorAdvisor res);

			// Token: 0x060002E4 RID: 740
			public abstract ParamUtils.DescriptorAdvisor ComputePublisher(ParamUtils.DescriptorAdvisor value);

			// Token: 0x060002E5 RID: 741
			public abstract ParamUtils.DescriptorAdvisor PostPublisher(ParamUtils.DescriptorAdvisor spec);

			// Token: 0x060002E6 RID: 742
			public abstract ParamUtils.DescriptorAdvisor LoginPublisher();

			// Token: 0x060002E7 RID: 743
			public abstract ParamUtils.DescriptorAdvisor AssetPublisher(ParamUtils.DescriptorAdvisor key);

			// Token: 0x060002E8 RID: 744
			public abstract ParamUtils.ComparatorUtils PrepareDatabase();

			// Token: 0x060002E9 RID: 745
			public abstract ParamUtils.DescriptorAdvisor NewPublisher(ParamUtils.DescriptorAdvisor def);

			// Token: 0x060002EA RID: 746
			public abstract ParamUtils.DescriptorAdvisor SelectPublisher(ParamUtils.DescriptorAdvisor i);

			// Token: 0x060002EB RID: 747
			public abstract ParamUtils.DescriptorAdvisor RemovePublisher(ParamUtils.DescriptorAdvisor res);

			// Token: 0x060002EC RID: 748
			public abstract bool ComparePublisher(ParamUtils.DescriptorAdvisor res);

			// Token: 0x060002ED RID: 749
			public abstract bool PrintPublisher(ParamUtils.DescriptorAdvisor res);

			// Token: 0x060002EE RID: 750
			public abstract bool PreparePublisher(ParamUtils.DescriptorAdvisor def);

			// Token: 0x060002EF RID: 751
			public abstract bool LogoutPublisher(ParamUtils.DescriptorAdvisor setup);

			// Token: 0x060002F0 RID: 752
			public abstract bool FindPublisher(ParamUtils.DescriptorAdvisor instance);

			// Token: 0x060002F1 RID: 753
			public abstract bool TestPublisher(ParamUtils.DescriptorAdvisor def);

			// Token: 0x060002F2 RID: 754
			public abstract bool RatePublisher(ParamUtils.DescriptorAdvisor config);

			// Token: 0x060002F3 RID: 755
			public abstract bool RestartPublisher(ParamUtils.DescriptorAdvisor asset);

			// Token: 0x060002F4 RID: 756 RVA: 0x00002728 File Offset: 0x00000928
			internal override bool InstantiatePublisher()
			{
				return true;
			}
		}

		// Token: 0x0200002E RID: 46
		private class CreatorUtils : ParamUtils.ComparatorUtils
		{
			// Token: 0x060002F6 RID: 758 RVA: 0x00010350 File Offset: 0x0000E550
			internal override void CompareDatabase(ParamUtils.DescriptorAdvisor def)
			{
				this.interceptorUtils = ((ParamUtils.CreatorUtils)def).interceptorUtils;
				this.m_CandidateUtils = ((ParamUtils.CreatorUtils)def).m_CandidateUtils;
			}

			// Token: 0x060002F7 RID: 759 RVA: 0x0000B390 File Offset: 0x00009590
			internal override void PrintDatabase(ParamUtils.DescriptorAdvisor v)
			{
				this.CompareDatabase(v);
			}

			// Token: 0x060002F8 RID: 760 RVA: 0x00010380 File Offset: 0x0000E580
			public CreatorUtils(double first)
			{
				this._ProxyAdvisor = (ParamUtils.CopyOption)5;
				this.m_CandidateUtils = (ParamUtils.ProcessUtils)10;
				this.interceptorUtils = first;
			}

			// Token: 0x060002F9 RID: 761 RVA: 0x000103AC File Offset: 0x0000E5AC
			public CreatorUtils(ParamUtils.CreatorUtils v)
			{
				this._ProxyAdvisor = v._ProxyAdvisor;
				this.m_CandidateUtils = v.m_CandidateUtils;
				this.interceptorUtils = v.interceptorUtils;
			}

			// Token: 0x060002FA RID: 762 RVA: 0x00003206 File Offset: 0x00001406
			public override ParamUtils.ComparatorUtils PrepareDatabase()
			{
				return new ParamUtils.CreatorUtils(this);
			}

			// Token: 0x060002FB RID: 763 RVA: 0x000103E4 File Offset: 0x0000E5E4
			public CreatorUtils(double asset, ParamUtils.ProcessUtils cfg)
			{
				this._ProxyAdvisor = (ParamUtils.CopyOption)5;
				this.interceptorUtils = asset;
				this.m_CandidateUtils = cfg;
			}

			// Token: 0x060002FC RID: 764 RVA: 0x0001040C File Offset: 0x0000E60C
			public CreatorUtils(float instance)
			{
				this._ProxyAdvisor = (ParamUtils.CopyOption)5;
				this.interceptorUtils = (double)instance;
				this.m_CandidateUtils = (ParamUtils.ProcessUtils)9;
			}

			// Token: 0x060002FD RID: 765 RVA: 0x00010438 File Offset: 0x0000E638
			public CreatorUtils(float key, ParamUtils.ProcessUtils token)
			{
				this._ProxyAdvisor = (ParamUtils.CopyOption)5;
				this.interceptorUtils = (double)key;
				this.m_CandidateUtils = token;
			}

			// Token: 0x060002FE RID: 766 RVA: 0x0000320E File Offset: 0x0000140E
			public override bool LogoutDatabase()
			{
				return this.interceptorUtils == 0.0;
			}

			// Token: 0x060002FF RID: 767 RVA: 0x00002B72 File Offset: 0x00000D72
			public override bool FindDatabase()
			{
				return !this.LogoutDatabase();
			}

			// Token: 0x06000300 RID: 768 RVA: 0x00003221 File Offset: 0x00001421
			public override string ToString()
			{
				return this.interceptorUtils.ToString();
			}

			// Token: 0x06000301 RID: 769 RVA: 0x00010464 File Offset: 0x0000E664
			public override ParamUtils.DescriptorAdvisor TestDatabase(ParamUtils.ProcessUtils item)
			{
				switch (item)
				{
				case (ParamUtils.ProcessUtils)1:
					return this.InstantiateDatabase();
				case (ParamUtils.ProcessUtils)2:
					return this.OrderDatabase();
				case (ParamUtils.ProcessUtils)3:
					return this.SortDatabase();
				case (ParamUtils.ProcessUtils)4:
					return this.CancelDatabase();
				case (ParamUtils.ProcessUtils)5:
					return this.AddDatabase();
				case (ParamUtils.ProcessUtils)6:
					return this.CheckDatabase();
				case (ParamUtils.ProcessUtils)7:
					return this.DefineDatabase();
				case (ParamUtils.ProcessUtils)8:
					return this.ViewDatabase();
				case (ParamUtils.ProcessUtils)9:
					return this.PopPublisher();
				case (ParamUtils.ProcessUtils)10:
					return this.RegisterPublisher();
				case (ParamUtils.ProcessUtils)11:
					return this.RestartDatabase();
				default:
					throw new System.Exception(((ParamUtils.CancellationMode)4).ToString());
				}
			}

			// Token: 0x06000302 RID: 770 RVA: 0x00010508 File Offset: 0x0000E708
			internal override object RateDatabase(System.Type var1)
			{
				if (var1 != null && var1.IsByRef)
				{
					var1 = var1.GetElementType();
				}
				if (var1 == typeof(float))
				{
					return (float)this.interceptorUtils;
				}
				if (var1 == typeof(double))
				{
					return this.interceptorUtils;
				}
				if ((var1 == null || var1 == typeof(object)) && this.m_CandidateUtils == (ParamUtils.ProcessUtils)9)
				{
					return (float)this.interceptorUtils;
				}
				return this.interceptorUtils;
			}

			// Token: 0x06000303 RID: 771 RVA: 0x000105A8 File Offset: 0x0000E7A8
			public override ParamUtils.CollectionUtils RestartDatabase()
			{
				return new ParamUtils.CollectionUtils(this.LogoutDatabase() ? 1 : 0);
			}

			// Token: 0x06000304 RID: 772 RVA: 0x00002B7D File Offset: 0x00000D7D
			internal override bool InsertDatabase()
			{
				return this.FindDatabase();
			}

			// Token: 0x06000305 RID: 773 RVA: 0x0000322E File Offset: 0x0000142E
			public override ParamUtils.CollectionUtils InstantiateDatabase()
			{
				return new ParamUtils.CollectionUtils((int)((sbyte)this.interceptorUtils), (ParamUtils.ProcessUtils)1);
			}

			// Token: 0x06000306 RID: 774 RVA: 0x0000323D File Offset: 0x0000143D
			public override ParamUtils.CollectionUtils OrderDatabase()
			{
				return new ParamUtils.CollectionUtils((uint)((byte)this.interceptorUtils), (ParamUtils.ProcessUtils)2);
			}

			// Token: 0x06000307 RID: 775 RVA: 0x0000324C File Offset: 0x0000144C
			public override ParamUtils.CollectionUtils SortDatabase()
			{
				return new ParamUtils.CollectionUtils((int)((short)this.interceptorUtils), (ParamUtils.ProcessUtils)3);
			}

			// Token: 0x06000308 RID: 776 RVA: 0x0000325B File Offset: 0x0000145B
			public override ParamUtils.CollectionUtils CancelDatabase()
			{
				return new ParamUtils.CollectionUtils((uint)((ushort)this.interceptorUtils), (ParamUtils.ProcessUtils)4);
			}

			// Token: 0x06000309 RID: 777 RVA: 0x0000326A File Offset: 0x0000146A
			public override ParamUtils.CollectionUtils AddDatabase()
			{
				return new ParamUtils.CollectionUtils((int)this.interceptorUtils, (ParamUtils.ProcessUtils)5);
			}

			// Token: 0x0600030A RID: 778 RVA: 0x00003279 File Offset: 0x00001479
			public override ParamUtils.CollectionUtils CheckDatabase()
			{
				return new ParamUtils.CollectionUtils((uint)this.interceptorUtils, (ParamUtils.ProcessUtils)6);
			}

			// Token: 0x0600030B RID: 779 RVA: 0x00003288 File Offset: 0x00001488
			public override ParamUtils.ReponseUtils DefineDatabase()
			{
				return new ParamUtils.ReponseUtils((long)this.interceptorUtils, (ParamUtils.ProcessUtils)7);
			}

			// Token: 0x0600030C RID: 780 RVA: 0x00003297 File Offset: 0x00001497
			public override ParamUtils.ReponseUtils ViewDatabase()
			{
				return new ParamUtils.ReponseUtils((ulong)this.interceptorUtils, (ParamUtils.ProcessUtils)8);
			}

			// Token: 0x0600030D RID: 781 RVA: 0x00002C33 File Offset: 0x00000E33
			public override ParamUtils.CollectionUtils RevertDatabase()
			{
				return this.InstantiateDatabase();
			}

			// Token: 0x0600030E RID: 782 RVA: 0x00002C3B File Offset: 0x00000E3B
			public override ParamUtils.CollectionUtils PublishPublisher()
			{
				return this.SortDatabase();
			}

			// Token: 0x0600030F RID: 783 RVA: 0x00002C43 File Offset: 0x00000E43
			public override ParamUtils.CollectionUtils SetupPublisher()
			{
				return this.AddDatabase();
			}

			// Token: 0x06000310 RID: 784 RVA: 0x00002C4B File Offset: 0x00000E4B
			public override ParamUtils.ReponseUtils SetPublisher()
			{
				return this.DefineDatabase();
			}

			// Token: 0x06000311 RID: 785 RVA: 0x00002C53 File Offset: 0x00000E53
			public override ParamUtils.CollectionUtils CountPublisher()
			{
				return this.OrderDatabase();
			}

			// Token: 0x06000312 RID: 786 RVA: 0x00002C5B File Offset: 0x00000E5B
			public override ParamUtils.CollectionUtils ReflectPublisher()
			{
				return this.CancelDatabase();
			}

			// Token: 0x06000313 RID: 787 RVA: 0x00002C63 File Offset: 0x00000E63
			public override ParamUtils.CollectionUtils WritePublisher()
			{
				return this.CheckDatabase();
			}

			// Token: 0x06000314 RID: 788 RVA: 0x00002C6B File Offset: 0x00000E6B
			public override ParamUtils.ReponseUtils ClonePublisher()
			{
				return this.ViewDatabase();
			}

			// Token: 0x06000315 RID: 789 RVA: 0x000032A6 File Offset: 0x000014A6
			public override ParamUtils.CollectionUtils VisitPublisher()
			{
				return new ParamUtils.CollectionUtils((int)(checked((sbyte)this.interceptorUtils)), (ParamUtils.ProcessUtils)1);
			}

			// Token: 0x06000316 RID: 790 RVA: 0x000032A6 File Offset: 0x000014A6
			public override ParamUtils.CollectionUtils MapPublisher()
			{
				return new ParamUtils.CollectionUtils((int)(checked((sbyte)this.interceptorUtils)), (ParamUtils.ProcessUtils)1);
			}

			// Token: 0x06000317 RID: 791 RVA: 0x000032B5 File Offset: 0x000014B5
			public override ParamUtils.CollectionUtils VerifyPublisher()
			{
				return new ParamUtils.CollectionUtils((int)(checked((short)this.interceptorUtils)), (ParamUtils.ProcessUtils)3);
			}

			// Token: 0x06000318 RID: 792 RVA: 0x000032B5 File Offset: 0x000014B5
			public override ParamUtils.CollectionUtils ChangePublisher()
			{
				return new ParamUtils.CollectionUtils((int)(checked((short)this.interceptorUtils)), (ParamUtils.ProcessUtils)3);
			}

			// Token: 0x06000319 RID: 793 RVA: 0x000032C4 File Offset: 0x000014C4
			public override ParamUtils.CollectionUtils ListPublisher()
			{
				return new ParamUtils.CollectionUtils(checked((int)this.interceptorUtils), (ParamUtils.ProcessUtils)5);
			}

			// Token: 0x0600031A RID: 794 RVA: 0x000032C4 File Offset: 0x000014C4
			public override ParamUtils.CollectionUtils IncludePublisher()
			{
				return new ParamUtils.CollectionUtils(checked((int)this.interceptorUtils), (ParamUtils.ProcessUtils)5);
			}

			// Token: 0x0600031B RID: 795 RVA: 0x000032D3 File Offset: 0x000014D3
			public override ParamUtils.ReponseUtils CreatePublisher()
			{
				return new ParamUtils.ReponseUtils(checked((long)this.interceptorUtils), (ParamUtils.ProcessUtils)7);
			}

			// Token: 0x0600031C RID: 796 RVA: 0x000032D3 File Offset: 0x000014D3
			public override ParamUtils.ReponseUtils EnablePublisher()
			{
				return new ParamUtils.ReponseUtils(checked((long)this.interceptorUtils), (ParamUtils.ProcessUtils)7);
			}

			// Token: 0x0600031D RID: 797 RVA: 0x000032E2 File Offset: 0x000014E2
			public override ParamUtils.CollectionUtils PatchPublisher()
			{
				return new ParamUtils.CollectionUtils((int)(checked((byte)this.interceptorUtils)), (ParamUtils.ProcessUtils)2);
			}

			// Token: 0x0600031E RID: 798 RVA: 0x000032E2 File Offset: 0x000014E2
			public override ParamUtils.CollectionUtils ForgotPublisher()
			{
				return new ParamUtils.CollectionUtils((int)(checked((byte)this.interceptorUtils)), (ParamUtils.ProcessUtils)2);
			}

			// Token: 0x0600031F RID: 799 RVA: 0x000032F1 File Offset: 0x000014F1
			public override ParamUtils.CollectionUtils InitPublisher()
			{
				return new ParamUtils.CollectionUtils((int)(checked((ushort)this.interceptorUtils)), (ParamUtils.ProcessUtils)4);
			}

			// Token: 0x06000320 RID: 800 RVA: 0x000032F1 File Offset: 0x000014F1
			public override ParamUtils.CollectionUtils CollectPublisher()
			{
				return new ParamUtils.CollectionUtils((int)(checked((ushort)this.interceptorUtils)), (ParamUtils.ProcessUtils)4);
			}

			// Token: 0x06000321 RID: 801 RVA: 0x00003300 File Offset: 0x00001500
			public override ParamUtils.CollectionUtils ConcatPublisher()
			{
				return new ParamUtils.CollectionUtils(checked((uint)this.interceptorUtils), (ParamUtils.ProcessUtils)6);
			}

			// Token: 0x06000322 RID: 802 RVA: 0x00003300 File Offset: 0x00001500
			public override ParamUtils.CollectionUtils InvokePublisher()
			{
				return new ParamUtils.CollectionUtils(checked((uint)this.interceptorUtils), (ParamUtils.ProcessUtils)6);
			}

			// Token: 0x06000323 RID: 803 RVA: 0x0000330F File Offset: 0x0000150F
			public override ParamUtils.ReponseUtils AwakePublisher()
			{
				return new ParamUtils.ReponseUtils(checked((ulong)this.interceptorUtils), (ParamUtils.ProcessUtils)8);
			}

			// Token: 0x06000324 RID: 804 RVA: 0x0000330F File Offset: 0x0000150F
			public override ParamUtils.ReponseUtils FlushPublisher()
			{
				return new ParamUtils.ReponseUtils(checked((ulong)this.interceptorUtils), (ParamUtils.ProcessUtils)8);
			}

			// Token: 0x06000325 RID: 805 RVA: 0x0000331E File Offset: 0x0000151E
			public override ParamUtils.CreatorUtils PopPublisher()
			{
				return new ParamUtils.CreatorUtils((float)this.interceptorUtils, (ParamUtils.ProcessUtils)9);
			}

			// Token: 0x06000326 RID: 806 RVA: 0x0000332E File Offset: 0x0000152E
			public override ParamUtils.CreatorUtils RegisterPublisher()
			{
				return new ParamUtils.CreatorUtils(this.interceptorUtils, (ParamUtils.ProcessUtils)10);
			}

			// Token: 0x06000327 RID: 807 RVA: 0x0000333E File Offset: 0x0000153E
			public override ParamUtils.CreatorUtils CalcPublisher()
			{
				return new ParamUtils.CreatorUtils(this.interceptorUtils);
			}

			// Token: 0x06000328 RID: 808 RVA: 0x0000BAB8 File Offset: 0x00009CB8
			public override ParamUtils.WrapperUtils DestroyPublisher()
			{
				if (System.IntPtr.Size == 8)
				{
					return new ParamUtils.WrapperUtils(this.SetPublisher().m_ContextUtils.m_ProcessorUtils);
				}
				return new ParamUtils.WrapperUtils((long)this.SetupPublisher().messageUtils.m_MethodUtils);
			}

			// Token: 0x06000329 RID: 809 RVA: 0x0000BAFC File Offset: 0x00009CFC
			public override ParamUtils.WrapperUtils GetPublisher()
			{
				if (System.IntPtr.Size == 8)
				{
					return new ParamUtils.WrapperUtils(this.ClonePublisher().m_ContextUtils.decoratorUtils);
				}
				return new ParamUtils.WrapperUtils((ulong)this.WritePublisher().messageUtils.m_RequestUtils);
			}

			// Token: 0x0600032A RID: 810 RVA: 0x0000BB40 File Offset: 0x00009D40
			public override ParamUtils.WrapperUtils StartPublisher()
			{
				if (System.IntPtr.Size == 8)
				{
					return new ParamUtils.WrapperUtils(this.CreatePublisher().m_ContextUtils.m_ProcessorUtils);
				}
				return new ParamUtils.WrapperUtils((long)this.ListPublisher().messageUtils.m_MethodUtils);
			}

			// Token: 0x0600032B RID: 811 RVA: 0x0000BB84 File Offset: 0x00009D84
			public override ParamUtils.WrapperUtils SearchPublisher()
			{
				if (System.IntPtr.Size == 8)
				{
					return new ParamUtils.WrapperUtils(this.AwakePublisher().m_ContextUtils.decoratorUtils);
				}
				return new ParamUtils.WrapperUtils((ulong)this.ConcatPublisher().messageUtils.m_RequestUtils);
			}

			// Token: 0x0600032C RID: 812 RVA: 0x0000BBC8 File Offset: 0x00009DC8
			public override ParamUtils.WrapperUtils PushPublisher()
			{
				if (System.IntPtr.Size == 8)
				{
					return new ParamUtils.WrapperUtils(this.EnablePublisher().m_ContextUtils.m_ProcessorUtils);
				}
				return new ParamUtils.WrapperUtils((long)this.IncludePublisher().messageUtils.m_MethodUtils);
			}

			// Token: 0x0600032D RID: 813 RVA: 0x0000BC0C File Offset: 0x00009E0C
			public override ParamUtils.WrapperUtils ReadPublisher()
			{
				if (System.IntPtr.Size == 8)
				{
					return new ParamUtils.WrapperUtils(this.FlushPublisher().m_ContextUtils.decoratorUtils);
				}
				return new ParamUtils.WrapperUtils((ulong)this.InvokePublisher().messageUtils.m_RequestUtils);
			}

			// Token: 0x0600032E RID: 814 RVA: 0x000105C8 File Offset: 0x0000E7C8
			public override ParamUtils.DescriptorAdvisor ExcludePublisher()
			{
				if (this.m_CandidateUtils == (ParamUtils.ProcessUtils)9)
				{
					return new ParamUtils.CreatorUtils((float)(-(float)this.interceptorUtils));
				}
				return new ParamUtils.CreatorUtils(-this.interceptorUtils);
			}

			// Token: 0x0600032F RID: 815 RVA: 0x000105FC File Offset: 0x0000E7FC
			public override ParamUtils.DescriptorAdvisor CalculatePublisher(ParamUtils.DescriptorAdvisor key)
			{
				if (key.OrderPublisher())
				{
					key = key.CustomizePublisher();
				}
				if (!key.FillParameter())
				{
					throw new ParamUtils.ExporterUtils();
				}
				return new ParamUtils.CreatorUtils(this.interceptorUtils + ((ParamUtils.CreatorUtils)key).interceptorUtils);
			}

			// Token: 0x06000330 RID: 816 RVA: 0x000105FC File Offset: 0x0000E7FC
			public override ParamUtils.DescriptorAdvisor DeletePublisher(ParamUtils.DescriptorAdvisor last)
			{
				if (last.OrderPublisher())
				{
					last = last.CustomizePublisher();
				}
				if (!last.FillParameter())
				{
					throw new ParamUtils.ExporterUtils();
				}
				return new ParamUtils.CreatorUtils(this.interceptorUtils + ((ParamUtils.CreatorUtils)last).interceptorUtils);
			}

			// Token: 0x06000331 RID: 817 RVA: 0x000105FC File Offset: 0x0000E7FC
			public override ParamUtils.DescriptorAdvisor RunPublisher(ParamUtils.DescriptorAdvisor def)
			{
				if (def.OrderPublisher())
				{
					def = def.CustomizePublisher();
				}
				if (!def.FillParameter())
				{
					throw new ParamUtils.ExporterUtils();
				}
				return new ParamUtils.CreatorUtils(this.interceptorUtils + ((ParamUtils.CreatorUtils)def).interceptorUtils);
			}

			// Token: 0x06000332 RID: 818 RVA: 0x00010640 File Offset: 0x0000E840
			public override ParamUtils.DescriptorAdvisor MovePublisher(ParamUtils.DescriptorAdvisor spec)
			{
				if (spec.OrderPublisher())
				{
					spec = spec.CustomizePublisher();
				}
				if (!spec.FillParameter())
				{
					throw new ParamUtils.ExporterUtils();
				}
				return new ParamUtils.CreatorUtils(this.interceptorUtils - ((ParamUtils.CreatorUtils)spec).interceptorUtils);
			}

			// Token: 0x06000333 RID: 819 RVA: 0x00010640 File Offset: 0x0000E840
			public override ParamUtils.DescriptorAdvisor ResolvePublisher(ParamUtils.DescriptorAdvisor v)
			{
				if (v.OrderPublisher())
				{
					v = v.CustomizePublisher();
				}
				if (!v.FillParameter())
				{
					throw new ParamUtils.ExporterUtils();
				}
				return new ParamUtils.CreatorUtils(this.interceptorUtils - ((ParamUtils.CreatorUtils)v).interceptorUtils);
			}

			// Token: 0x06000334 RID: 820 RVA: 0x00010640 File Offset: 0x0000E840
			public override ParamUtils.DescriptorAdvisor InterruptPublisher(ParamUtils.DescriptorAdvisor ident)
			{
				if (ident.OrderPublisher())
				{
					ident = ident.CustomizePublisher();
				}
				if (!ident.FillParameter())
				{
					throw new ParamUtils.ExporterUtils();
				}
				return new ParamUtils.CreatorUtils(this.interceptorUtils - ((ParamUtils.CreatorUtils)ident).interceptorUtils);
			}

			// Token: 0x06000335 RID: 821 RVA: 0x00010684 File Offset: 0x0000E884
			public override ParamUtils.DescriptorAdvisor CallPublisher(ParamUtils.DescriptorAdvisor config)
			{
				if (config.OrderPublisher())
				{
					config = config.CustomizePublisher();
				}
				if (!config.FillParameter() || !config.FillParameter())
				{
					throw new ParamUtils.ExporterUtils();
				}
				return new ParamUtils.CreatorUtils(this.interceptorUtils * ((ParamUtils.CreatorUtils)config).interceptorUtils);
			}

			// Token: 0x06000336 RID: 822 RVA: 0x000106D0 File Offset: 0x0000E8D0
			public override ParamUtils.DescriptorAdvisor FillPublisher(ParamUtils.DescriptorAdvisor def)
			{
				if (def.OrderPublisher())
				{
					def = def.CustomizePublisher();
				}
				if (!def.FillParameter())
				{
					throw new ParamUtils.ExporterUtils();
				}
				return new ParamUtils.CreatorUtils(this.interceptorUtils * ((ParamUtils.CreatorUtils)def).interceptorUtils);
			}

			// Token: 0x06000337 RID: 823 RVA: 0x000106D0 File Offset: 0x0000E8D0
			public override ParamUtils.DescriptorAdvisor QueryPublisher(ParamUtils.DescriptorAdvisor reference)
			{
				if (reference.OrderPublisher())
				{
					reference = reference.CustomizePublisher();
				}
				if (!reference.FillParameter())
				{
					throw new ParamUtils.ExporterUtils();
				}
				return new ParamUtils.CreatorUtils(this.interceptorUtils * ((ParamUtils.CreatorUtils)reference).interceptorUtils);
			}

			// Token: 0x06000338 RID: 824 RVA: 0x00010714 File Offset: 0x0000E914
			public override ParamUtils.DescriptorAdvisor StopPublisher(ParamUtils.DescriptorAdvisor res)
			{
				if (res.OrderPublisher())
				{
					res = res.CustomizePublisher();
				}
				if (!res.FillParameter())
				{
					throw new ParamUtils.ExporterUtils();
				}
				return new ParamUtils.CreatorUtils(this.interceptorUtils / ((ParamUtils.CreatorUtils)res).interceptorUtils);
			}

			// Token: 0x06000339 RID: 825 RVA: 0x00010714 File Offset: 0x0000E914
			public override ParamUtils.DescriptorAdvisor UpdatePublisher(ParamUtils.DescriptorAdvisor spec)
			{
				if (spec.OrderPublisher())
				{
					spec = spec.CustomizePublisher();
				}
				if (!spec.FillParameter())
				{
					throw new ParamUtils.ExporterUtils();
				}
				return new ParamUtils.CreatorUtils(this.interceptorUtils / ((ParamUtils.CreatorUtils)spec).interceptorUtils);
			}

			// Token: 0x0600033A RID: 826 RVA: 0x00010758 File Offset: 0x0000E958
			public override ParamUtils.DescriptorAdvisor ManagePublisher(ParamUtils.DescriptorAdvisor res)
			{
				if (res.OrderPublisher())
				{
					res = res.CustomizePublisher();
				}
				if (!res.FillParameter())
				{
					throw new ParamUtils.ExporterUtils();
				}
				return new ParamUtils.CreatorUtils(this.interceptorUtils % ((ParamUtils.CreatorUtils)res).interceptorUtils);
			}

			// Token: 0x0600033B RID: 827 RVA: 0x00010758 File Offset: 0x0000E958
			public override ParamUtils.DescriptorAdvisor DisablePublisher(ParamUtils.DescriptorAdvisor ident)
			{
				if (ident.OrderPublisher())
				{
					ident = ident.CustomizePublisher();
				}
				if (!ident.FillParameter())
				{
					throw new ParamUtils.ExporterUtils();
				}
				return new ParamUtils.CreatorUtils(this.interceptorUtils % ((ParamUtils.CreatorUtils)ident).interceptorUtils);
			}

			// Token: 0x0600033C RID: 828 RVA: 0x0000334C File Offset: 0x0000154C
			public override ParamUtils.DescriptorAdvisor ComputePublisher(ParamUtils.DescriptorAdvisor var1)
			{
				throw new ParamUtils.ExporterUtils();
			}

			// Token: 0x0600033D RID: 829 RVA: 0x0000334C File Offset: 0x0000154C
			public override ParamUtils.DescriptorAdvisor PostPublisher(ParamUtils.DescriptorAdvisor item)
			{
				throw new ParamUtils.ExporterUtils();
			}

			// Token: 0x0600033E RID: 830 RVA: 0x0000334C File Offset: 0x0000154C
			public override ParamUtils.DescriptorAdvisor LoginPublisher()
			{
				throw new ParamUtils.ExporterUtils();
			}

			// Token: 0x0600033F RID: 831 RVA: 0x0000334C File Offset: 0x0000154C
			public override ParamUtils.DescriptorAdvisor AssetPublisher(ParamUtils.DescriptorAdvisor param)
			{
				throw new ParamUtils.ExporterUtils();
			}

			// Token: 0x06000340 RID: 832 RVA: 0x0000334C File Offset: 0x0000154C
			public override ParamUtils.DescriptorAdvisor NewPublisher(ParamUtils.DescriptorAdvisor res)
			{
				throw new ParamUtils.ExporterUtils();
			}

			// Token: 0x06000341 RID: 833 RVA: 0x0000334C File Offset: 0x0000154C
			public override ParamUtils.DescriptorAdvisor SelectPublisher(ParamUtils.DescriptorAdvisor reference)
			{
				throw new ParamUtils.ExporterUtils();
			}

			// Token: 0x06000342 RID: 834 RVA: 0x0000334C File Offset: 0x0000154C
			public override ParamUtils.DescriptorAdvisor RemovePublisher(ParamUtils.DescriptorAdvisor spec)
			{
				throw new ParamUtils.ExporterUtils();
			}

			// Token: 0x06000343 RID: 835 RVA: 0x00002DB0 File Offset: 0x00000FB0
			internal override ParamUtils.DescriptorAdvisor CustomizePublisher()
			{
				return this;
			}

			// Token: 0x06000344 RID: 836 RVA: 0x0001079C File Offset: 0x0000E99C
			internal override bool ValidatePublisher(ParamUtils.DescriptorAdvisor var1)
			{
				if (var1.MoveParameter())
				{
					return false;
				}
				if (!var1.OrderPublisher())
				{
					ParamUtils.DescriptorAdvisor descriptorAdvisor = var1.CustomizePublisher();
					return descriptorAdvisor.FillParameter() && this.interceptorUtils == ((ParamUtils.CreatorUtils)descriptorAdvisor).interceptorUtils;
				}
				return ((ParamUtils.ProducerUtils)var1).ValidatePublisher(this);
			}

			// Token: 0x06000345 RID: 837 RVA: 0x000107F0 File Offset: 0x0000E9F0
			internal override bool ResetPublisher(ParamUtils.DescriptorAdvisor var1)
			{
				if (var1.MoveParameter())
				{
					return false;
				}
				if (var1.OrderPublisher())
				{
					return ((ParamUtils.ProducerUtils)var1).ResetPublisher(this);
				}
				ParamUtils.DescriptorAdvisor descriptorAdvisor = var1.CustomizePublisher();
				return descriptorAdvisor.FillParameter() && this.interceptorUtils != ((ParamUtils.CreatorUtils)descriptorAdvisor).interceptorUtils;
			}

			// Token: 0x06000346 RID: 838 RVA: 0x00010848 File Offset: 0x0000EA48
			public override bool ComparePublisher(ParamUtils.DescriptorAdvisor i)
			{
				if (i.OrderPublisher())
				{
					i = i.CustomizePublisher();
				}
				if (!i.FillParameter())
				{
					throw new ParamUtils.ExporterUtils();
				}
				return this.interceptorUtils >= ((ParamUtils.CreatorUtils)i).interceptorUtils;
			}

			// Token: 0x06000347 RID: 839 RVA: 0x00010848 File Offset: 0x0000EA48
			public override bool PrintPublisher(ParamUtils.DescriptorAdvisor var1)
			{
				if (var1.OrderPublisher())
				{
					var1 = var1.CustomizePublisher();
				}
				if (!var1.FillParameter())
				{
					throw new ParamUtils.ExporterUtils();
				}
				return this.interceptorUtils >= ((ParamUtils.CreatorUtils)var1).interceptorUtils;
			}

			// Token: 0x06000348 RID: 840 RVA: 0x0001088C File Offset: 0x0000EA8C
			public override bool PreparePublisher(ParamUtils.DescriptorAdvisor info)
			{
				if (info.OrderPublisher())
				{
					info = info.CustomizePublisher();
				}
				if (!info.FillParameter())
				{
					throw new ParamUtils.ExporterUtils();
				}
				return this.interceptorUtils > ((ParamUtils.CreatorUtils)info).interceptorUtils;
			}

			// Token: 0x06000349 RID: 841 RVA: 0x0001088C File Offset: 0x0000EA8C
			public override bool LogoutPublisher(ParamUtils.DescriptorAdvisor last)
			{
				if (last.OrderPublisher())
				{
					last = last.CustomizePublisher();
				}
				if (!last.FillParameter())
				{
					throw new ParamUtils.ExporterUtils();
				}
				return this.interceptorUtils > ((ParamUtils.CreatorUtils)last).interceptorUtils;
			}

			// Token: 0x0600034A RID: 842 RVA: 0x000108CC File Offset: 0x0000EACC
			public override bool FindPublisher(ParamUtils.DescriptorAdvisor spec)
			{
				if (spec.OrderPublisher())
				{
					spec = spec.CustomizePublisher();
				}
				if (!spec.FillParameter())
				{
					throw new ParamUtils.ExporterUtils();
				}
				return this.interceptorUtils <= ((ParamUtils.CreatorUtils)spec).interceptorUtils;
			}

			// Token: 0x0600034B RID: 843 RVA: 0x000108CC File Offset: 0x0000EACC
			public override bool TestPublisher(ParamUtils.DescriptorAdvisor var1)
			{
				if (var1.OrderPublisher())
				{
					var1 = var1.CustomizePublisher();
				}
				if (!var1.FillParameter())
				{
					throw new ParamUtils.ExporterUtils();
				}
				return this.interceptorUtils <= ((ParamUtils.CreatorUtils)var1).interceptorUtils;
			}

			// Token: 0x0600034C RID: 844 RVA: 0x00010910 File Offset: 0x0000EB10
			public override bool RatePublisher(ParamUtils.DescriptorAdvisor instance)
			{
				if (instance.OrderPublisher())
				{
					instance = instance.CustomizePublisher();
				}
				if (!instance.FillParameter())
				{
					throw new ParamUtils.ExporterUtils();
				}
				return this.interceptorUtils < ((ParamUtils.CreatorUtils)instance).interceptorUtils;
			}

			// Token: 0x0600034D RID: 845 RVA: 0x00010910 File Offset: 0x0000EB10
			public override bool RestartPublisher(ParamUtils.DescriptorAdvisor param)
			{
				if (param.OrderPublisher())
				{
					param = param.CustomizePublisher();
				}
				if (!param.FillParameter())
				{
					throw new ParamUtils.ExporterUtils();
				}
				return this.interceptorUtils < ((ParamUtils.CreatorUtils)param).interceptorUtils;
			}

			// Token: 0x04000094 RID: 148
			public double interceptorUtils;

			// Token: 0x04000095 RID: 149
			public ParamUtils.ProcessUtils m_CandidateUtils;
		}

		// Token: 0x0200002F RID: 47
		internal enum ProcessUtils : byte
		{

		}

		// Token: 0x02000030 RID: 48
		internal enum tagOLELINKBIND : byte
		{

		}

		// Token: 0x02000031 RID: 49
		private class EventUtils : System.Exception
		{
			// Token: 0x0600034E RID: 846 RVA: 0x00010950 File Offset: 0x0000EB50
			public EventUtils(string def) : base(def)
			{
			}
		}

		// Token: 0x02000032 RID: 50
		private class ExporterUtils : System.Exception
		{
			// Token: 0x0600034F RID: 847 RVA: 0x00003353 File Offset: 0x00001553
			public ExporterUtils()
			{
			}

			// Token: 0x06000350 RID: 848 RVA: 0x00010950 File Offset: 0x0000EB50
			public ExporterUtils(string init) : base(init)
			{
			}
		}

		// Token: 0x02000033 RID: 51
		internal class ValueUtils
		{
			// Token: 0x06000351 RID: 849 RVA: 0x00010964 File Offset: 0x0000EB64
			public override string ToString()
			{
				object obj = this.m_DicUtils;
				if (this._StatusUtils != null)
				{
					return obj.ToString() + 'H'.ToString() + this._StatusUtils.ToString();
				}
				return obj.ToString();
			}

			// Token: 0x04000098 RID: 152
			internal ParamUtils.FDESVR m_DicUtils = (ParamUtils.FDESVR)126;

			// Token: 0x04000099 RID: 153
			internal object _StatusUtils;
		}

		// Token: 0x02000034 RID: 52
		internal abstract class ProducerUtils : ParamUtils.DescriptorAdvisor
		{
			// Token: 0x06000353 RID: 851 RVA: 0x000031FE File Offset: 0x000013FE
			public ProducerUtils()
			{
			}

			// Token: 0x06000354 RID: 852 RVA: 0x00002728 File Offset: 0x00000928
			internal override bool OrderPublisher()
			{
				return true;
			}

			// Token: 0x06000355 RID: 853
			internal abstract System.IntPtr SortPublisher();

			// Token: 0x06000356 RID: 854
			internal abstract void CancelPublisher(ParamUtils.DescriptorAdvisor i);

			// Token: 0x06000357 RID: 855 RVA: 0x00002728 File Offset: 0x00000928
			internal override bool InsertPublisher()
			{
				return true;
			}
		}

		// Token: 0x02000035 RID: 53
		internal class VisitorUtils : ParamUtils.ProducerUtils
		{
			// Token: 0x06000358 RID: 856 RVA: 0x000109CC File Offset: 0x0000EBCC
			public VisitorUtils(int indexinit, ParamUtils.FactoryUtils ivk)
			{
				this.m_DefinitionUtils = ivk;
				this.m_InvocationUtils = indexinit;
				this._ProxyAdvisor = (ParamUtils.CopyOption)7;
			}

			// Token: 0x06000359 RID: 857 RVA: 0x000109F4 File Offset: 0x0000EBF4
			internal override void CompareDatabase(ParamUtils.DescriptorAdvisor i)
			{
				if (i is ParamUtils.VisitorUtils)
				{
					this.m_DefinitionUtils = ((ParamUtils.VisitorUtils)i).m_DefinitionUtils;
					this.m_InvocationUtils = ((ParamUtils.VisitorUtils)i).m_InvocationUtils;
					return;
				}
				ParamUtils.StructUtils structUtils = this.m_DefinitionUtils.m_GetterUtils._PoolUtils[this.m_InvocationUtils];
				if (i is ParamUtils.ProducerUtils && (structUtils._ObjectUtils & (ParamUtils.ProcessUtils)226) > (ParamUtils.ProcessUtils)0)
				{
					ParamUtils.DescriptorAdvisor i2 = (i as ParamUtils.ProducerUtils).CustomizePublisher();
					this.CancelPublisher(i2);
					return;
				}
				this.CancelPublisher(i);
			}

			// Token: 0x0600035A RID: 858 RVA: 0x00010A80 File Offset: 0x0000EC80
			internal override void PrintDatabase(ParamUtils.DescriptorAdvisor ident)
			{
				this.CancelPublisher(ident);
			}

			// Token: 0x0600035B RID: 859 RVA: 0x0000335B File Offset: 0x0000155B
			internal override System.IntPtr SortPublisher()
			{
				throw new System.NotImplementedException();
			}

			// Token: 0x0600035C RID: 860 RVA: 0x00010A94 File Offset: 0x0000EC94
			internal override void CancelPublisher(ParamUtils.DescriptorAdvisor v)
			{
				this.m_DefinitionUtils.singletonAdvisor[this.m_InvocationUtils] = v;
			}

			// Token: 0x0600035D RID: 861 RVA: 0x00010AB4 File Offset: 0x0000ECB4
			internal override object RateDatabase(System.Type info)
			{
				if (this.m_DefinitionUtils.singletonAdvisor[this.m_InvocationUtils] != null)
				{
					return this.CustomizePublisher().RateDatabase(info);
				}
				return null;
			}

			// Token: 0x0600035E RID: 862 RVA: 0x00010AE4 File Offset: 0x0000ECE4
			internal override ParamUtils.DescriptorAdvisor CustomizePublisher()
			{
				if (this.m_DefinitionUtils.singletonAdvisor[this.m_InvocationUtils] == null)
				{
					return new ParamUtils.WorkerAdvisor(null);
				}
				return this.m_DefinitionUtils.singletonAdvisor[this.m_InvocationUtils].CustomizePublisher();
			}

			// Token: 0x0600035F RID: 863 RVA: 0x00003362 File Offset: 0x00001562
			internal override bool ConnectPublisher()
			{
				return this.CustomizePublisher().ConnectPublisher();
			}

			// Token: 0x06000360 RID: 864 RVA: 0x00010B24 File Offset: 0x0000ED24
			internal override bool ValidatePublisher(ParamUtils.DescriptorAdvisor def)
			{
				return def.OrderPublisher() && def is ParamUtils.VisitorUtils && ((ParamUtils.VisitorUtils)def).m_InvocationUtils == this.m_InvocationUtils;
			}

			// Token: 0x06000361 RID: 865 RVA: 0x00010B5C File Offset: 0x0000ED5C
			internal override bool ResetPublisher(ParamUtils.DescriptorAdvisor key)
			{
				return !key.OrderPublisher() || !(key is ParamUtils.VisitorUtils) || ((ParamUtils.VisitorUtils)key).m_InvocationUtils != this.m_InvocationUtils;
			}

			// Token: 0x06000362 RID: 866 RVA: 0x0000336F File Offset: 0x0000156F
			internal override bool InsertDatabase()
			{
				return this.CustomizePublisher().InsertDatabase();
			}

			// Token: 0x0400009A RID: 154
			private ParamUtils.FactoryUtils m_DefinitionUtils;

			// Token: 0x0400009B RID: 155
			internal int m_InvocationUtils;
		}

		// Token: 0x02000036 RID: 54
		internal class DispatcherUtils : ParamUtils.ProducerUtils
		{
			// Token: 0x06000363 RID: 867 RVA: 0x00010B94 File Offset: 0x0000ED94
			public DispatcherUtils(int ID_setup, System.Array token)
			{
				this._ImporterUtils = token;
				this.m_SerializerUtils = ID_setup;
				this._ProxyAdvisor = (ParamUtils.CopyOption)7;
			}

			// Token: 0x06000364 RID: 868 RVA: 0x0000335B File Offset: 0x0000155B
			internal override System.IntPtr SortPublisher()
			{
				throw new System.NotImplementedException();
			}

			// Token: 0x06000365 RID: 869 RVA: 0x00010BBC File Offset: 0x0000EDBC
			internal override void CompareDatabase(ParamUtils.DescriptorAdvisor spec)
			{
				if (spec is ParamUtils.DispatcherUtils)
				{
					this._ImporterUtils = ((ParamUtils.DispatcherUtils)spec)._ImporterUtils;
					this.m_SerializerUtils = ((ParamUtils.DispatcherUtils)spec).m_SerializerUtils;
					return;
				}
				this.CancelPublisher(spec);
			}

			// Token: 0x06000366 RID: 870 RVA: 0x00010A80 File Offset: 0x0000EC80
			internal override void PrintDatabase(ParamUtils.DescriptorAdvisor config)
			{
				this.CancelPublisher(config);
			}

			// Token: 0x06000367 RID: 871 RVA: 0x00010BFC File Offset: 0x0000EDFC
			internal override void CancelPublisher(ParamUtils.DescriptorAdvisor first)
			{
				this._ImporterUtils.SetValue(first.RateDatabase(null), this.m_SerializerUtils);
			}

			// Token: 0x06000368 RID: 872 RVA: 0x0000337C File Offset: 0x0000157C
			internal override object RateDatabase(System.Type def)
			{
				return this.CustomizePublisher().RateDatabase(def);
			}

			// Token: 0x06000369 RID: 873 RVA: 0x0000338A File Offset: 0x0000158A
			internal override ParamUtils.DescriptorAdvisor CustomizePublisher()
			{
				return ParamUtils.DescriptorAdvisor.UpdateParameter(this._ImporterUtils.GetType().GetElementType(), this._ImporterUtils.GetValue(this.m_SerializerUtils));
			}

			// Token: 0x0600036A RID: 874 RVA: 0x00003362 File Offset: 0x00001562
			internal override bool ConnectPublisher()
			{
				return this.CustomizePublisher().ConnectPublisher();
			}

			// Token: 0x0600036B RID: 875 RVA: 0x00010C24 File Offset: 0x0000EE24
			internal override bool ValidatePublisher(ParamUtils.DescriptorAdvisor init)
			{
				if (!init.OrderPublisher())
				{
					return false;
				}
				if (init is ParamUtils.DispatcherUtils)
				{
					ParamUtils.DispatcherUtils dispatcherUtils = (ParamUtils.DispatcherUtils)init;
					return dispatcherUtils.m_SerializerUtils == this.m_SerializerUtils && dispatcherUtils._ImporterUtils == this._ImporterUtils;
				}
				return false;
			}

			// Token: 0x0600036C RID: 876 RVA: 0x00010C70 File Offset: 0x0000EE70
			internal override bool ResetPublisher(ParamUtils.DescriptorAdvisor first)
			{
				if (!first.OrderPublisher())
				{
					return true;
				}
				if (!(first is ParamUtils.DispatcherUtils))
				{
					return true;
				}
				ParamUtils.DispatcherUtils dispatcherUtils = (ParamUtils.DispatcherUtils)first;
				return dispatcherUtils.m_SerializerUtils != this.m_SerializerUtils || dispatcherUtils._ImporterUtils != this._ImporterUtils;
			}

			// Token: 0x0600036D RID: 877 RVA: 0x0000336F File Offset: 0x0000156F
			internal override bool InsertDatabase()
			{
				return this.CustomizePublisher().InsertDatabase();
			}

			// Token: 0x0400009C RID: 156
			private System.Array _ImporterUtils;

			// Token: 0x0400009D RID: 157
			internal int m_SerializerUtils;
		}

		// Token: 0x02000037 RID: 55
		internal class ResolverUtils : ParamUtils.ProducerUtils
		{
			// Token: 0x0600036E RID: 878 RVA: 0x00010CBC File Offset: 0x0000EEBC
			public ResolverUtils(System.Reflection.FieldInfo init, object ord)
			{
				this.adapterUtils = init;
				this.mapperUtils = ord;
				this._ProxyAdvisor = (ParamUtils.CopyOption)7;
			}

			// Token: 0x0600036F RID: 879 RVA: 0x0000335B File Offset: 0x0000155B
			internal override System.IntPtr SortPublisher()
			{
				throw new System.NotImplementedException();
			}

			// Token: 0x06000370 RID: 880 RVA: 0x00010CE4 File Offset: 0x0000EEE4
			internal override void CancelPublisher(ParamUtils.DescriptorAdvisor first)
			{
				if (this.mapperUtils != null && this.mapperUtils is ParamUtils.DescriptorAdvisor)
				{
					this.adapterUtils.SetValue(((ParamUtils.DescriptorAdvisor)this.mapperUtils).RateDatabase(null), first.RateDatabase(null));
					return;
				}
				this.adapterUtils.SetValue(this.mapperUtils, first.RateDatabase(null));
			}

			// Token: 0x06000371 RID: 881 RVA: 0x00010D44 File Offset: 0x0000EF44
			internal override void CompareDatabase(ParamUtils.DescriptorAdvisor res)
			{
				if (res is ParamUtils.ResolverUtils)
				{
					this.adapterUtils = ((ParamUtils.ResolverUtils)res).adapterUtils;
					this.mapperUtils = ((ParamUtils.ResolverUtils)res).mapperUtils;
					return;
				}
				this.CancelPublisher(res);
			}

			// Token: 0x06000372 RID: 882 RVA: 0x00010A80 File Offset: 0x0000EC80
			internal override void PrintDatabase(ParamUtils.DescriptorAdvisor init)
			{
				this.CancelPublisher(init);
			}

			// Token: 0x06000373 RID: 883 RVA: 0x0000337C File Offset: 0x0000157C
			internal override object RateDatabase(System.Type var1)
			{
				return this.CustomizePublisher().RateDatabase(var1);
			}

			// Token: 0x06000374 RID: 884 RVA: 0x00010D84 File Offset: 0x0000EF84
			internal override ParamUtils.DescriptorAdvisor CustomizePublisher()
			{
				if (this.mapperUtils != null && this.mapperUtils is ParamUtils.DescriptorAdvisor)
				{
					return ParamUtils.DescriptorAdvisor.UpdateParameter(this.adapterUtils.FieldType, this.adapterUtils.GetValue(((ParamUtils.DescriptorAdvisor)this.mapperUtils).RateDatabase(null)));
				}
				return ParamUtils.DescriptorAdvisor.UpdateParameter(this.adapterUtils.FieldType, this.adapterUtils.GetValue(this.mapperUtils));
			}

			// Token: 0x06000375 RID: 885 RVA: 0x00003362 File Offset: 0x00001562
			internal override bool ConnectPublisher()
			{
				return this.CustomizePublisher().ConnectPublisher();
			}

			// Token: 0x06000376 RID: 886 RVA: 0x00010DF4 File Offset: 0x0000EFF4
			internal override bool ValidatePublisher(ParamUtils.DescriptorAdvisor asset)
			{
				if (!asset.OrderPublisher())
				{
					return false;
				}
				if (asset is ParamUtils.ResolverUtils)
				{
					ParamUtils.ResolverUtils resolverUtils = (ParamUtils.ResolverUtils)asset;
					return !(resolverUtils.adapterUtils != this.adapterUtils) && resolverUtils.mapperUtils == this.mapperUtils;
				}
				return false;
			}

			// Token: 0x06000377 RID: 887 RVA: 0x00010E48 File Offset: 0x0000F048
			internal override bool ResetPublisher(ParamUtils.DescriptorAdvisor last)
			{
				if (!last.OrderPublisher())
				{
					return true;
				}
				if (last is ParamUtils.ResolverUtils)
				{
					ParamUtils.ResolverUtils resolverUtils = (ParamUtils.ResolverUtils)last;
					return resolverUtils.adapterUtils != this.adapterUtils || resolverUtils.mapperUtils != this.mapperUtils;
				}
				return true;
			}

			// Token: 0x06000378 RID: 888 RVA: 0x0000336F File Offset: 0x0000156F
			internal override bool InsertDatabase()
			{
				return this.CustomizePublisher().InsertDatabase();
			}

			// Token: 0x0400009E RID: 158
			internal System.Reflection.FieldInfo adapterUtils;

			// Token: 0x0400009F RID: 159
			internal object mapperUtils;
		}

		// Token: 0x02000038 RID: 56
		internal class TokenizerUtils : ParamUtils.ProducerUtils
		{
			// Token: 0x06000379 RID: 889 RVA: 0x00010E9C File Offset: 0x0000F09C
			public TokenizerUtils(int init_count, ParamUtils.FactoryUtils vis)
			{
				this.propertyUtils = vis;
				this.m_MappingUtils = init_count;
				this._ProxyAdvisor = (ParamUtils.CopyOption)7;
			}

			// Token: 0x0600037A RID: 890 RVA: 0x0000335B File Offset: 0x0000155B
			internal override System.IntPtr SortPublisher()
			{
				throw new System.NotImplementedException();
			}

			// Token: 0x0600037B RID: 891 RVA: 0x00010EC4 File Offset: 0x0000F0C4
			internal override void CompareDatabase(ParamUtils.DescriptorAdvisor instance)
			{
				if (!(instance is ParamUtils.TokenizerUtils))
				{
					this.CancelPublisher(instance);
					return;
				}
				this.propertyUtils = ((ParamUtils.TokenizerUtils)instance).propertyUtils;
				this.m_MappingUtils = ((ParamUtils.TokenizerUtils)instance).m_MappingUtils;
			}

			// Token: 0x0600037C RID: 892 RVA: 0x00010A80 File Offset: 0x0000EC80
			internal override void PrintDatabase(ParamUtils.DescriptorAdvisor item)
			{
				this.CancelPublisher(item);
			}

			// Token: 0x0600037D RID: 893 RVA: 0x00010F04 File Offset: 0x0000F104
			internal override void CancelPublisher(ParamUtils.DescriptorAdvisor init)
			{
				this.propertyUtils.m_ProcUtils[this.m_MappingUtils] = init;
			}

			// Token: 0x0600037E RID: 894 RVA: 0x00010F24 File Offset: 0x0000F124
			internal override object RateDatabase(System.Type instance)
			{
				if (this.propertyUtils.m_ProcUtils[this.m_MappingUtils] != null)
				{
					return this.CustomizePublisher().RateDatabase(instance);
				}
				return null;
			}

			// Token: 0x0600037F RID: 895 RVA: 0x00010F54 File Offset: 0x0000F154
			internal override ParamUtils.DescriptorAdvisor CustomizePublisher()
			{
				if (this.propertyUtils.m_ProcUtils[this.m_MappingUtils] != null)
				{
					return this.propertyUtils.m_ProcUtils[this.m_MappingUtils].CustomizePublisher();
				}
				return new ParamUtils.WorkerAdvisor(null);
			}

			// Token: 0x06000380 RID: 896 RVA: 0x00003362 File Offset: 0x00001562
			internal override bool ConnectPublisher()
			{
				return this.CustomizePublisher().ConnectPublisher();
			}

			// Token: 0x06000381 RID: 897 RVA: 0x00010F94 File Offset: 0x0000F194
			internal override bool ValidatePublisher(ParamUtils.DescriptorAdvisor key)
			{
				return key.OrderPublisher() && key is ParamUtils.TokenizerUtils && ((ParamUtils.TokenizerUtils)key).m_MappingUtils == this.m_MappingUtils;
			}

			// Token: 0x06000382 RID: 898 RVA: 0x00010FC8 File Offset: 0x0000F1C8
			internal override bool ResetPublisher(ParamUtils.DescriptorAdvisor init)
			{
				return !init.OrderPublisher() || !(init is ParamUtils.TokenizerUtils) || ((ParamUtils.TokenizerUtils)init).m_MappingUtils != this.m_MappingUtils;
			}

			// Token: 0x06000383 RID: 899 RVA: 0x0000336F File Offset: 0x0000156F
			internal override bool InsertDatabase()
			{
				return this.CustomizePublisher().InsertDatabase();
			}

			// Token: 0x040000A0 RID: 160
			private ParamUtils.FactoryUtils propertyUtils;

			// Token: 0x040000A1 RID: 161
			internal int m_MappingUtils;
		}

		// Token: 0x02000039 RID: 57
		internal class AttrUtils : ParamUtils.ProducerUtils
		{
			// Token: 0x06000384 RID: 900 RVA: 0x00011000 File Offset: 0x0000F200
			public AttrUtils(ParamUtils.DescriptorAdvisor param, System.Type second)
			{
				this.printerUtils = param;
				this.m_FieldUtils = second;
				this._ProxyAdvisor = (ParamUtils.CopyOption)7;
			}

			// Token: 0x06000385 RID: 901 RVA: 0x0000335B File Offset: 0x0000155B
			internal override System.IntPtr SortPublisher()
			{
				throw new System.NotImplementedException();
			}

			// Token: 0x06000386 RID: 902 RVA: 0x00011028 File Offset: 0x0000F228
			internal override void CompareDatabase(ParamUtils.DescriptorAdvisor param)
			{
				if (param is ParamUtils.AttrUtils)
				{
					this.m_FieldUtils = ((ParamUtils.AttrUtils)param).m_FieldUtils;
					this.printerUtils = ((ParamUtils.AttrUtils)param).printerUtils;
					return;
				}
				this.printerUtils.CompareDatabase(param);
			}

			// Token: 0x06000387 RID: 903 RVA: 0x00010A80 File Offset: 0x0000EC80
			internal override void PrintDatabase(ParamUtils.DescriptorAdvisor instance)
			{
				this.CancelPublisher(instance);
			}

			// Token: 0x06000388 RID: 904 RVA: 0x0001106C File Offset: 0x0000F26C
			internal override void CancelPublisher(ParamUtils.DescriptorAdvisor config)
			{
				this.printerUtils = config;
			}

			// Token: 0x06000389 RID: 905 RVA: 0x00011080 File Offset: 0x0000F280
			internal override object RateDatabase(System.Type res)
			{
				if (this.printerUtils == null)
				{
					return new ParamUtils.WorkerAdvisor(null);
				}
				if (!(res == null) && !(res == typeof(object)))
				{
					return this.printerUtils.RateDatabase(res);
				}
				return this.printerUtils.RateDatabase(this.m_FieldUtils);
			}

			// Token: 0x0600038A RID: 906 RVA: 0x000110D8 File Offset: 0x0000F2D8
			internal override ParamUtils.DescriptorAdvisor CustomizePublisher()
			{
				if (this.printerUtils != null)
				{
					return this.printerUtils.CustomizePublisher();
				}
				return new ParamUtils.WorkerAdvisor(null);
			}

			// Token: 0x0600038B RID: 907 RVA: 0x00003362 File Offset: 0x00001562
			internal override bool ConnectPublisher()
			{
				return this.CustomizePublisher().ConnectPublisher();
			}

			// Token: 0x0600038C RID: 908 RVA: 0x00011100 File Offset: 0x0000F300
			internal override bool ValidatePublisher(ParamUtils.DescriptorAdvisor param)
			{
				if (!param.OrderPublisher())
				{
					return false;
				}
				if (!(param is ParamUtils.AttrUtils))
				{
					return false;
				}
				ParamUtils.AttrUtils attrUtils = (ParamUtils.AttrUtils)param;
				if (attrUtils.m_FieldUtils != this.m_FieldUtils)
				{
					return false;
				}
				if (this.printerUtils == null)
				{
					return attrUtils.printerUtils == null;
				}
				return this.printerUtils.ValidatePublisher(attrUtils.printerUtils);
			}

			// Token: 0x0600038D RID: 909 RVA: 0x00011168 File Offset: 0x0000F368
			internal override bool ResetPublisher(ParamUtils.DescriptorAdvisor var1)
			{
				if (!var1.OrderPublisher())
				{
					return true;
				}
				if (!(var1 is ParamUtils.AttrUtils))
				{
					return true;
				}
				ParamUtils.AttrUtils attrUtils = (ParamUtils.AttrUtils)var1;
				if (attrUtils.m_FieldUtils != this.m_FieldUtils)
				{
					return true;
				}
				if (this.printerUtils == null)
				{
					return attrUtils.printerUtils != null;
				}
				return this.printerUtils.ResetPublisher(attrUtils.printerUtils);
			}

			// Token: 0x0600038E RID: 910 RVA: 0x0000336F File Offset: 0x0000156F
			internal override bool InsertDatabase()
			{
				return this.CustomizePublisher().InsertDatabase();
			}

			// Token: 0x040000A2 RID: 162
			private ParamUtils.DescriptorAdvisor printerUtils;

			// Token: 0x040000A3 RID: 163
			private System.Type m_FieldUtils;
		}

		// Token: 0x0200003A RID: 58
		internal class RuleUtils
		{
			// Token: 0x040000A4 RID: 164
			public int _StateUtils;

			// Token: 0x040000A5 RID: 165
			public bool _RegUtils;

			// Token: 0x040000A6 RID: 166
			public ParamUtils.ProcessUtils m_RepositoryUtils;
		}

		// Token: 0x0200003B RID: 59
		internal class StructUtils
		{
			// Token: 0x040000A7 RID: 167
			public int m_AnnotationUtils;

			// Token: 0x040000A8 RID: 168
			public ParamUtils.ProcessUtils _ObjectUtils;

			// Token: 0x040000A9 RID: 169
			public bool m_ObserverUtils;

			// Token: 0x040000AA RID: 170
			public System.Type m_TagUtils = typeof(object);
		}

		// Token: 0x0200003C RID: 60
		internal class ReaderUtils
		{
			// Token: 0x040000AB RID: 171
			public int _StubUtils;

			// Token: 0x040000AC RID: 172
			public int _PageUtils;

			// Token: 0x040000AD RID: 173
			public ParamUtils.QueueUtils classUtils;
		}

		// Token: 0x0200003D RID: 61
		internal class QueueUtils
		{
			// Token: 0x040000AE RID: 174
			public int _CustomerUtils;

			// Token: 0x040000AF RID: 175
			public int m_AttributeUtils;

			// Token: 0x040000B0 RID: 176
			public byte m_AccountUtils;

			// Token: 0x040000B1 RID: 177
			public System.Type _TaskUtils;

			// Token: 0x040000B2 RID: 178
			public int _IteratorUtils;

			// Token: 0x040000B3 RID: 179
			public int m_ModelUtils;
		}

		// Token: 0x0200003E RID: 62
		internal class FacadeUtils
		{
			// Token: 0x040000B4 RID: 180
			internal object managerUtils;

			// Token: 0x040000B5 RID: 181
			internal System.Collections.Generic.List<ParamUtils.ValueUtils> policyUtils;

			// Token: 0x040000B6 RID: 182
			internal ParamUtils.RuleUtils[] m_RecordUtils;

			// Token: 0x040000B7 RID: 183
			internal System.Collections.Generic.List<ParamUtils.StructUtils> _PoolUtils;

			// Token: 0x040000B8 RID: 184
			internal System.Collections.Generic.List<ParamUtils.ReaderUtils> m_InitializerUtils;
		}

		// Token: 0x0200003F RID: 63
		private class ConsumerUtils
		{
			// Token: 0x06000394 RID: 916 RVA: 0x000111F4 File Offset: 0x0000F3F4
			public ConsumerUtils(System.Reflection.FieldInfo ident, int counter_low)
			{
				this._SpecificationUtils = ident;
				this.m_MerchantUtils = counter_low;
			}

			// Token: 0x040000B9 RID: 185
			internal object _SpecificationUtils;

			// Token: 0x040000BA RID: 186
			internal int m_MerchantUtils;
		}

		// Token: 0x02000040 RID: 64
		private class ValUtils
		{
			// Token: 0x06000395 RID: 917 RVA: 0x000033B2 File Offset: 0x000015B2
			public ValUtils(System.Reflection.MethodBase init, System.Collections.Generic.List<ParamUtils.ConsumerUtils> pol)
			{
				this.m_IssuerUtils = pol;
				this.rulesUtils = init;
			}

			// Token: 0x06000396 RID: 918 RVA: 0x00011218 File Offset: 0x0000F418
			public ValUtils(System.Reflection.MethodBase param, ParamUtils.ConsumerUtils[] selection)
			{
				this.m_IssuerUtils.AddRange(selection);
			}

			// Token: 0x06000397 RID: 919 RVA: 0x00011244 File Offset: 0x0000F444
			public override bool Equals(object spec)
			{
				ParamUtils.ValUtils valUtils = spec as ParamUtils.ValUtils;
				if (spec == null)
				{
					return false;
				}
				if (this.rulesUtils != valUtils.rulesUtils)
				{
					return false;
				}
				if (this.m_IssuerUtils.Count != valUtils.m_IssuerUtils.Count)
				{
					return false;
				}
				for (int i = 0; i < this.m_IssuerUtils.Count; i++)
				{
					if (this.m_IssuerUtils[i]._SpecificationUtils != valUtils.m_IssuerUtils[i]._SpecificationUtils)
					{
						return false;
					}
					if (this.m_IssuerUtils[i].m_MerchantUtils != valUtils.m_IssuerUtils[i].m_MerchantUtils)
					{
						return false;
					}
				}
				return true;
			}

			// Token: 0x06000398 RID: 920 RVA: 0x00011308 File Offset: 0x0000F508
			public override int GetHashCode()
			{
				int num = this.rulesUtils.GetHashCode();
				foreach (ParamUtils.ConsumerUtils consumerUtils in this.m_IssuerUtils)
				{
					int num2 = consumerUtils._SpecificationUtils.GetHashCode() + consumerUtils.m_MerchantUtils;
					num = (num ^ num2) + num2;
				}
				return num;
			}

			// Token: 0x06000399 RID: 921 RVA: 0x00011388 File Offset: 0x0000F588
			public ParamUtils.ConsumerUtils SetAdvisor(int IDasset)
			{
				foreach (ParamUtils.ConsumerUtils consumerUtils in this.m_IssuerUtils)
				{
					if (consumerUtils.m_MerchantUtils == IDasset)
					{
						return consumerUtils;
					}
				}
				return null;
			}

			// Token: 0x0600039A RID: 922 RVA: 0x000113F0 File Offset: 0x0000F5F0
			public bool CountAdvisor(int IDsetup)
			{
				using (System.Collections.Generic.List<ParamUtils.ConsumerUtils>.Enumerator enumerator = this.m_IssuerUtils.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						if (enumerator.Current.m_MerchantUtils == IDsetup)
						{
							return true;
						}
					}
				}
				return false;
			}

			// Token: 0x040000BB RID: 187
			private System.Collections.Generic.List<ParamUtils.ConsumerUtils> m_IssuerUtils = new System.Collections.Generic.List<ParamUtils.ConsumerUtils>();

			// Token: 0x040000BC RID: 188
			private System.Reflection.MethodBase rulesUtils;
		}

		// Token: 0x02000041 RID: 65
		// (Invoke) Token: 0x0600039C RID: 924
		private delegate object SystemUtils(object target, object[] paramters);

		// Token: 0x02000042 RID: 66
		// (Invoke) Token: 0x060003A0 RID: 928
		private delegate object InstanceUtils(object target);

		// Token: 0x02000043 RID: 67
		// (Invoke) Token: 0x060003A4 RID: 932
		private delegate void SchemaUtils(System.IntPtr a, byte b, int c);

		// Token: 0x02000044 RID: 68
		// (Invoke) Token: 0x060003A8 RID: 936
		private delegate void GlobalUtils(System.IntPtr s, System.IntPtr t, uint c);

		// Token: 0x02000045 RID: 69
		internal class FactoryUtils
		{
			// Token: 0x060003AB RID: 939 RVA: 0x00011450 File Offset: 0x0000F650
			internal void ReflectAdvisor()
			{
				bool flag = false;
				this.CloneAdvisor(ref flag);
			}

			// Token: 0x060003AC RID: 940 RVA: 0x00011468 File Offset: 0x0000F668
			internal void WriteAdvisor()
			{
				this.utilsAdvisor.ComputeParameter();
				this.singletonAdvisor = null;
				if (this.parameterAdvisor != null)
				{
					foreach (System.IntPtr hglobal in this.parameterAdvisor)
					{
						try
						{
							System.Runtime.InteropServices.Marshal.FreeHGlobal(hglobal);
						}
						catch
						{
						}
					}
					this.parameterAdvisor.Clear();
					this.parameterAdvisor = null;
				}
			}

			// Token: 0x060003AD RID: 941 RVA: 0x000114FC File Offset: 0x0000F6FC
			internal void CloneAdvisor(ref bool reference)
			{
				while (this.m_DatabaseAdvisor > -2)
				{
					if (this._ServiceAdvisor)
					{
						this._ServiceAdvisor = false;
						int publisherAdvisor = this._PublisherAdvisor;
						int databaseAdvisor = this.m_DatabaseAdvisor;
						this.MapAdvisor(this._PublisherAdvisor, this.m_DatabaseAdvisor);
						this.m_DatabaseAdvisor = databaseAdvisor;
						this._PublisherAdvisor = publisherAdvisor;
					}
					if (this.callbackAdvisor)
					{
						this.callbackAdvisor = false;
						return;
					}
					if (!this._AlgoAdvisor)
					{
						this._PublisherAdvisor = this.m_DatabaseAdvisor;
						ParamUtils.ValueUtils valueUtils = this.m_GetterUtils.policyUtils[this.m_DatabaseAdvisor];
						this._WriterAdvisor = valueUtils._StatusUtils;
						try
						{
							this.ListAdvisor(valueUtils);
						}
						catch (System.Exception innerException)
						{
							if (innerException is System.Reflection.TargetInvocationException)
							{
								System.Reflection.TargetInvocationException ex = (System.Reflection.TargetInvocationException)innerException;
								if (ex.InnerException != null)
								{
									innerException = ex.InnerException;
								}
							}
							this.m_RefAdvisor = innerException;
							reference = true;
							this.utilsAdvisor.ComputeParameter();
							int publisherAdvisor2 = this._PublisherAdvisor;
							ParamUtils.ReaderUtils readerUtils = this.VerifyAdvisor(publisherAdvisor2, innerException);
							System.Collections.Generic.List<ParamUtils.ReaderUtils> list = this.ChangeAdvisor(publisherAdvisor2, false);
							System.Collections.Generic.List<ParamUtils.ReaderUtils> list2 = new System.Collections.Generic.List<ParamUtils.ReaderUtils>();
							if (readerUtils != null)
							{
								list2.Add(readerUtils);
							}
							if (list != null && list.Count > 0)
							{
								list2.AddRange(list);
							}
							list2.Sort(new System.Comparison<ParamUtils.ReaderUtils>(ParamUtils.FactoryUtils.Class0.<>9.method_0));
							ParamUtils.ReaderUtils readerUtils2 = null;
							foreach (ParamUtils.ReaderUtils readerUtils3 in list2)
							{
								if (readerUtils3.classUtils.m_ModelUtils != 0)
								{
									this.utilsAdvisor.PostParameter(new ParamUtils.WorkerAdvisor(innerException));
									this._PublisherAdvisor = readerUtils3.classUtils._IteratorUtils;
									this.m_DatabaseAdvisor = this._PublisherAdvisor;
									this.ReflectAdvisor();
									if (!this.prototypeAdvisor)
									{
										continue;
									}
									this.prototypeAdvisor = false;
									readerUtils2 = readerUtils3;
								}
								else
								{
									readerUtils2 = readerUtils3;
								}
								break;
							}
							if (readerUtils2 != null)
							{
								this._ParamsAdvisor = readerUtils2.classUtils._CustomerUtils;
								this.VisitAdvisor(publisherAdvisor2, readerUtils2.classUtils._CustomerUtils);
								if (this._ParamsAdvisor >= 0)
								{
									this.utilsAdvisor.PostParameter(new ParamUtils.WorkerAdvisor(innerException));
									this._PublisherAdvisor = this._ParamsAdvisor;
									this.m_DatabaseAdvisor = this._PublisherAdvisor;
									this._ParamsAdvisor = -1;
									this.ReflectAdvisor();
								}
								return;
							}
							throw innerException;
						}
						this.m_DatabaseAdvisor++;
						continue;
					}
					this._AlgoAdvisor = false;
					return;
				}
				this.utilsAdvisor.ComputeParameter();
			}

			// Token: 0x060003AE RID: 942 RVA: 0x000117BC File Offset: 0x0000F9BC
			internal void VisitAdvisor(int first_X, int nextivk)
			{
				if (this.m_GetterUtils.m_InitializerUtils != null)
				{
					foreach (ParamUtils.ReaderUtils readerUtils in this.m_GetterUtils.m_InitializerUtils)
					{
						if ((readerUtils.classUtils.m_ModelUtils == 4 || readerUtils.classUtils.m_ModelUtils == 2) && readerUtils.classUtils._CustomerUtils >= first_X && readerUtils.classUtils.m_AttributeUtils <= nextivk)
						{
							this._PublisherAdvisor = readerUtils.classUtils._CustomerUtils;
							this.m_DatabaseAdvisor = this._PublisherAdvisor;
							bool flag = false;
							this.CloneAdvisor(ref flag);
							if (flag)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x060003AF RID: 943 RVA: 0x0001188C File Offset: 0x0000FA8C
			internal void MapAdvisor(int row_info, int selectioncount)
			{
				if (this.m_GetterUtils.m_InitializerUtils != null)
				{
					foreach (ParamUtils.ReaderUtils readerUtils in this.m_GetterUtils.m_InitializerUtils)
					{
						if (readerUtils.classUtils.m_ModelUtils == 2 && readerUtils.classUtils._CustomerUtils >= row_info && readerUtils.classUtils.m_AttributeUtils <= selectioncount)
						{
							this._PublisherAdvisor = readerUtils.classUtils._CustomerUtils;
							this.m_DatabaseAdvisor = this._PublisherAdvisor;
							bool flag = false;
							this.CloneAdvisor(ref flag);
							if (flag)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x060003B0 RID: 944 RVA: 0x0001194C File Offset: 0x0000FB4C
			internal ParamUtils.ReaderUtils VerifyAdvisor(int taskmin, System.Exception visitor)
			{
				ParamUtils.ReaderUtils readerUtils = null;
				if (this.m_GetterUtils.m_InitializerUtils != null)
				{
					foreach (ParamUtils.ReaderUtils readerUtils2 in this.m_GetterUtils.m_InitializerUtils)
					{
						if (readerUtils2.classUtils.m_ModelUtils == 0 && (readerUtils2.classUtils._TaskUtils == visitor.GetType() || (readerUtils2.classUtils._TaskUtils != null && (readerUtils2.classUtils._TaskUtils.FullName == visitor.GetType().FullName || readerUtils2.classUtils._TaskUtils.FullName == typeof(object).FullName || readerUtils2.classUtils._TaskUtils.FullName == typeof(System.Exception).FullName))) && taskmin >= readerUtils2._StubUtils && taskmin <= readerUtils2._PageUtils)
						{
							if (readerUtils != null)
							{
								if (readerUtils2.classUtils._CustomerUtils < readerUtils.classUtils._CustomerUtils)
								{
									readerUtils = readerUtils2;
								}
							}
							else
							{
								readerUtils = readerUtils2;
							}
						}
					}
				}
				return readerUtils;
			}

			// Token: 0x060003B1 RID: 945 RVA: 0x00011AB8 File Offset: 0x0000FCB8
			internal System.Collections.Generic.List<ParamUtils.ReaderUtils> ChangeAdvisor(int int_0, bool isivk)
			{
				if (this.m_GetterUtils.m_InitializerUtils == null)
				{
					return null;
				}
				System.Collections.Generic.List<ParamUtils.ReaderUtils> list = new System.Collections.Generic.List<ParamUtils.ReaderUtils>();
				foreach (ParamUtils.ReaderUtils readerUtils in this.m_GetterUtils.m_InitializerUtils)
				{
					if ((readerUtils.classUtils.m_ModelUtils & 1) == 1 && int_0 >= readerUtils._StubUtils && int_0 <= readerUtils._PageUtils)
					{
						list.Add(readerUtils);
					}
				}
				if (list.Count == 0)
				{
					return null;
				}
				return list;
			}

			// Token: 0x060003B2 RID: 946 RVA: 0x00011B54 File Offset: 0x0000FD54
			private unsafe void ListAdvisor(ParamUtils.ValueUtils v)
			{
				switch (v.m_DicUtils)
				{
				case (ParamUtils.FDESVR)0:
				{
					ParamUtils.ComparatorUtils comparatorUtils = ParamUtils.FactoryUtils.InitParameter(this.utilsAdvisor.AssetParameter());
					if (comparatorUtils == null)
					{
						throw new ParamUtils.ExporterUtils();
					}
					this.utilsAdvisor.PostParameter(comparatorUtils.CountPublisher());
					return;
				}
				case (ParamUtils.FDESVR)1:
				{
					ParamUtils.ComparatorUtils comparatorUtils = ParamUtils.FactoryUtils.InitParameter(this.utilsAdvisor.AssetParameter());
					ParamUtils.ComparatorUtils comparatorUtils2 = ParamUtils.FactoryUtils.InitParameter(this.utilsAdvisor.AssetParameter());
					if (comparatorUtils != null && comparatorUtils2 != null)
					{
						this.utilsAdvisor.PostParameter(comparatorUtils.PostPublisher(comparatorUtils2));
						return;
					}
					throw new ParamUtils.ExporterUtils();
				}
				case (ParamUtils.FDESVR)2:
				case (ParamUtils.FDESVR)19:
				case (ParamUtils.FDESVR)35:
				case (ParamUtils.FDESVR)85:
				case (ParamUtils.FDESVR)113:
				case (ParamUtils.FDESVR)155:
				case (ParamUtils.FDESVR)171:
				case (ParamUtils.FDESVR)173:
				{
					ParamUtils.DescriptorAdvisor descriptorAdvisor = this.utilsAdvisor.AssetParameter();
					ParamUtils.ComparatorUtils comparatorUtils = ParamUtils.FactoryUtils.InitParameter(this.utilsAdvisor.AssetParameter());
					System.Array array = (System.Array)this.utilsAdvisor.AssetParameter().RateDatabase(null);
					System.Type type = array.GetType().GetElementType();
					array.SetValue(descriptorAdvisor.RateDatabase(type), comparatorUtils.AddDatabase().messageUtils.m_MethodUtils);
					return;
				}
				case (ParamUtils.FDESVR)3:
				{
					ParamUtils.ComparatorUtils comparatorUtils = ParamUtils.FactoryUtils.InitParameter(this.utilsAdvisor.AssetParameter());
					object obj = ((System.Array)this.utilsAdvisor.AssetParameter().RateDatabase(null)).GetValue(comparatorUtils.AddDatabase().messageUtils.m_MethodUtils);
					this.utilsAdvisor.PostParameter(ParamUtils.DescriptorAdvisor.UpdateParameter(typeof(long), obj));
					return;
				}
				case (ParamUtils.FDESVR)4:
				{
					int num = (int)this._WriterAdvisor;
					System.Type type = typeof(ParamUtils).Module.ResolveType(num);
					ParamUtils.ProducerUtils producerUtils = this.utilsAdvisor.AssetParameter() as ParamUtils.ProducerUtils;
					if (producerUtils == null)
					{
						throw new ParamUtils.ExporterUtils();
					}
					if (type.IsValueType)
					{
						object obj = System.Activator.CreateInstance(type);
						producerUtils.CancelPublisher(ParamUtils.DescriptorAdvisor.UpdateParameter(type, obj));
						return;
					}
					producerUtils.CancelPublisher(new ParamUtils.WorkerAdvisor(null));
					return;
				}
				case (ParamUtils.FDESVR)5:
				{
					int num = (int)this._WriterAdvisor;
					System.Reflection.FieldInfo fieldInfo = typeof(ParamUtils).Module.ResolveField(num);
					this.utilsAdvisor.PostParameter(ParamUtils.DescriptorAdvisor.UpdateParameter(fieldInfo.FieldType, fieldInfo.GetValue(null)));
					return;
				}
				case (ParamUtils.FDESVR)6:
					this.utilsAdvisor.PostParameter(new ParamUtils.VisitorUtils((int)this._WriterAdvisor, this));
					return;
				case (ParamUtils.FDESVR)7:
				{
					ParamUtils.ComparatorUtils comparatorUtils = ParamUtils.FactoryUtils.InitParameter(this.utilsAdvisor.AssetParameter());
					if (comparatorUtils == null)
					{
						throw new ParamUtils.ExporterUtils();
					}
					this.utilsAdvisor.PostParameter(comparatorUtils.PatchPublisher());
					return;
				}
				case (ParamUtils.FDESVR)8:
				{
					ParamUtils.DescriptorAdvisor descriptorAdvisor = this.utilsAdvisor.AssetParameter();
					ParamUtils.ComparatorUtils comparatorUtils = ParamUtils.FactoryUtils.InitParameter(descriptorAdvisor);
					if (descriptorAdvisor != null && descriptorAdvisor.OrderPublisher() && comparatorUtils != null)
					{
						this.utilsAdvisor.PostParameter(comparatorUtils.ReflectPublisher());
						return;
					}
					if (comparatorUtils != null && comparatorUtils.InterruptParameter())
					{
						System.IntPtr intPtr = ((ParamUtils.WrapperUtils)comparatorUtils).InstantiateUtils();
						this.utilsAdvisor.PostParameter(new ParamUtils.CollectionUtils((int)(*(ushort*)((void*)intPtr)), (ParamUtils.ProcessUtils)4));
						return;
					}
					throw new ParamUtils.ExporterUtils();
				}
				case (ParamUtils.FDESVR)9:
				{
					ParamUtils.ComparatorUtils comparatorUtils = ParamUtils.FactoryUtils.InitParameter(this.utilsAdvisor.AssetParameter());
					ParamUtils.ComparatorUtils comparatorUtils2 = ParamUtils.FactoryUtils.InitParameter(this.utilsAdvisor.AssetParameter());
					if (comparatorUtils2 != null && comparatorUtils != null)
					{
						this.utilsAdvisor.PostParameter(comparatorUtils2.UpdatePublisher(comparatorUtils));
						return;
					}
					throw new ParamUtils.ExporterUtils();
				}
				case (ParamUtils.FDESVR)10:
				{
					ParamUtils.ComparatorUtils comparatorUtils = ParamUtils.FactoryUtils.InitParameter(this.utilsAdvisor.AssetParameter());
					if (comparatorUtils == null)
					{
						throw new ParamUtils.ExporterUtils();
					}
					this.utilsAdvisor.PostParameter(comparatorUtils.GetPublisher());
					return;
				}
				case (ParamUtils.FDESVR)11:
				{
					ParamUtils.DescriptorAdvisor descriptorAdvisor2 = this.utilsAdvisor.AssetParameter();
					ParamUtils.DescriptorAdvisor descriptorAdvisor = this.utilsAdvisor.AssetParameter();
					if (descriptorAdvisor2.ValidatePublisher(descriptorAdvisor))
					{
						this.m_DatabaseAdvisor = (int)this._WriterAdvisor - 1;
					}
					return;
				}
				case (ParamUtils.FDESVR)12:
				{
					ParamUtils.ComparatorUtils comparatorUtils = ParamUtils.FactoryUtils.InitParameter(this.utilsAdvisor.AssetParameter());
					ParamUtils.ComparatorUtils comparatorUtils2 = (ParamUtils.ComparatorUtils)this.utilsAdvisor.AssetParameter();
					if (comparatorUtils2 != null && comparatorUtils != null)
					{
						this.utilsAdvisor.PostParameter(comparatorUtils2.ResolvePublisher(comparatorUtils));
						return;
					}
					throw new ParamUtils.ExporterUtils();
				}
				case (ParamUtils.FDESVR)13:
					this.utilsAdvisor.PostParameter(new ParamUtils.ReponseUtils((long)this._WriterAdvisor));
					return;
				case (ParamUtils.FDESVR)14:
				{
					ParamUtils.ComparatorUtils comparatorUtils = ParamUtils.FactoryUtils.InitParameter(this.utilsAdvisor.AssetParameter());
					ParamUtils.ComparatorUtils comparatorUtils2 = ParamUtils.FactoryUtils.InitParameter(this.utilsAdvisor.AssetParameter());
					if (comparatorUtils2 != null && comparatorUtils != null)
					{
						this.utilsAdvisor.PostParameter(comparatorUtils2.InterruptPublisher(comparatorUtils));
						return;
					}
					throw new ParamUtils.ExporterUtils();
				}
				case (ParamUtils.FDESVR)15:
				{
					ParamUtils.DescriptorAdvisor descriptorAdvisor = this.utilsAdvisor.AssetParameter();
					if (descriptorAdvisor.InstantiatePublisher())
					{
						descriptorAdvisor = ((ParamUtils.ComparatorUtils)descriptorAdvisor).PopPublisher();
					}
					this.utilsAdvisor.AssetParameter().PrintDatabase(descriptorAdvisor);
					return;
				}
				case (ParamUtils.FDESVR)16:
				{
					int num = (int)this._WriterAdvisor;
					System.Reflection.FieldInfo fieldInfo = typeof(ParamUtils).Module.ResolveField(num);
					object obj = this.utilsAdvisor.AssetParameter().RateDatabase(fieldInfo.FieldType);
					fieldInfo.SetValue(null, obj);
					return;
				}
				case (ParamUtils.FDESVR)17:
				{
					int num = (int)this._WriterAdvisor;
					System.Reflection.FieldInfo fieldInfo = typeof(ParamUtils).Module.ResolveField(num);
					this.utilsAdvisor.PostParameter(new ParamUtils.ResolverUtils(fieldInfo, null));
					return;
				}
				case (ParamUtils.FDESVR)18:
				case (ParamUtils.FDESVR)33:
				case (ParamUtils.FDESVR)39:
				case (ParamUtils.FDESVR)45:
				case (ParamUtils.FDESVR)87:
				case (ParamUtils.FDESVR)168:
					return;
				case (ParamUtils.FDESVR)20:
				{
					ParamUtils.ComparatorUtils comparatorUtils = ParamUtils.FactoryUtils.InitParameter(this.utilsAdvisor.AssetParameter());
					if (comparatorUtils != null)
					{
						this.utilsAdvisor.PostParameter(comparatorUtils.InvokePublisher());
						return;
					}
					throw new ParamUtils.ExporterUtils();
				}
				case (ParamUtils.FDESVR)21:
				{
					ParamUtils.DescriptorAdvisor descriptorAdvisor = this.utilsAdvisor.AssetParameter();
					ParamUtils.ComparatorUtils comparatorUtils = ParamUtils.FactoryUtils.InitParameter(descriptorAdvisor);
					ParamUtils.DescriptorAdvisor descriptorAdvisor3 = this.utilsAdvisor.AssetParameter();
					ParamUtils.ComparatorUtils comparatorUtils2 = ParamUtils.FactoryUtils.InitParameter(descriptorAdvisor3);
					if (comparatorUtils2 != null && comparatorUtils != null)
					{
						if (!comparatorUtils2.LogoutPublisher(descriptorAdvisor))
						{
							this.utilsAdvisor.PostParameter(new ParamUtils.CollectionUtils(0));
							return;
						}
						this.utilsAdvisor.PostParameter(new ParamUtils.CollectionUtils(1));
						return;
					}
					else
					{
						if (!descriptorAdvisor.ResetPublisher(descriptorAdvisor3))
						{
							this.utilsAdvisor.PostParameter(new ParamUtils.CollectionUtils(0));
							return;
						}
						this.utilsAdvisor.PostParameter(new ParamUtils.CollectionUtils(1));
						return;
					}
					break;
				}
				case (ParamUtils.FDESVR)22:
				{
					ParamUtils.ComparatorUtils comparatorUtils = ParamUtils.FactoryUtils.InitParameter(this.utilsAdvisor.AssetParameter());
					ParamUtils.ComparatorUtils comparatorUtils2 = ParamUtils.FactoryUtils.InitParameter(this.utilsAdvisor.AssetParameter());
					if (comparatorUtils2 != null && comparatorUtils != null)
					{
						this.utilsAdvisor.PostParameter(comparatorUtils2.NewPublisher(comparatorUtils));
						return;
					}
					throw new ParamUtils.ExporterUtils();
				}
				case (ParamUtils.FDESVR)23:
				{
					ParamUtils.DescriptorAdvisor descriptorAdvisor = this.utilsAdvisor.AssetParameter();
					if (descriptorAdvisor != null && descriptorAdvisor.InsertDatabase())
					{
						this.m_DatabaseAdvisor = (int)this._WriterAdvisor - 1;
					}
					return;
				}
				case (ParamUtils.FDESVR)24:
				{
					int num = (int)this._WriterAdvisor;
					if (!this.m_GetterUtils.managerUtils.IsStatic)
					{
						this.m_ProcUtils[num] = this.CreateAdvisor(this.utilsAdvisor.AssetParameter(), this.m_GetterUtils.m_RecordUtils[num - 1].m_RepositoryUtils, false);
						return;
					}
					this.m_ProcUtils[num] = this.CreateAdvisor(this.utilsAdvisor.AssetParameter(), this.m_GetterUtils.m_RecordUtils[num].m_RepositoryUtils, false);
					return;
				}
				case (ParamUtils.FDESVR)25:
					this.m_DatabaseAdvisor = (int)this._WriterAdvisor - 1;
					this._ServiceAdvisor = true;
					return;
				case (ParamUtils.FDESVR)26:
				{
					int num = (int)this._WriterAdvisor;
					System.Type type = typeof(ParamUtils).Module.ResolveType(num);
					object obj = this.utilsAdvisor.AssetParameter().CustomizePublisher().RateDatabase(type);
					ParamUtils.DescriptorAdvisor descriptorAdvisor = ParamUtils.DescriptorAdvisor.UpdateParameter(type, obj);
					this.utilsAdvisor.PostParameter(descriptorAdvisor);
					return;
				}
				case (ParamUtils.FDESVR)27:
				{
					ParamUtils.ComparatorUtils comparatorUtils = ParamUtils.FactoryUtils.InitParameter(this.utilsAdvisor.AssetParameter());
					if (comparatorUtils != null)
					{
						this.utilsAdvisor.PostParameter(comparatorUtils.PopPublisher());
						return;
					}
					throw new ParamUtils.ExporterUtils();
				}
				case (ParamUtils.FDESVR)28:
				{
					ParamUtils.DescriptorAdvisor descriptorAdvisor = this.utilsAdvisor.AssetParameter();
					if (descriptorAdvisor.InstantiatePublisher())
					{
						descriptorAdvisor = ((ParamUtils.ComparatorUtils)descriptorAdvisor).RegisterPublisher();
					}
					this.utilsAdvisor.AssetParameter().PrintDatabase(descriptorAdvisor);
					return;
				}
				case (ParamUtils.FDESVR)29:
				{
					int[] array2 = (int[])this._WriterAdvisor;
					ParamUtils.ComparatorUtils comparatorUtils = ParamUtils.FactoryUtils.InitParameter(this.utilsAdvisor.AssetParameter());
					long num2 = comparatorUtils.DefineDatabase().m_ContextUtils.m_ProcessorUtils;
					if ((num2 < 0L || comparatorUtils.FillParameter()) && System.IntPtr.Size == 4)
					{
						num2 = (long)((int)num2);
					}
					if (comparatorUtils.ResolveParameter())
					{
						ParamUtils.CollectionUtils collectionUtils = (ParamUtils.CollectionUtils)comparatorUtils;
						if (collectionUtils._BroadcasterUtils == (ParamUtils.ProcessUtils)6)
						{
							num2 = (long)((ulong)collectionUtils.messageUtils.m_RequestUtils);
						}
					}
					if (num2 < (long)array2.Length && num2 >= 0L)
					{
						this.m_DatabaseAdvisor = array2[(int)(checked((System.IntPtr)num2))] - 1;
					}
					return;
				}
				case (ParamUtils.FDESVR)30:
				{
					ParamUtils.DescriptorAdvisor descriptorAdvisor = this.utilsAdvisor.AssetParameter();
					if (descriptorAdvisor.InstantiatePublisher())
					{
						descriptorAdvisor = ((ParamUtils.ComparatorUtils)descriptorAdvisor).PublishPublisher();
					}
					this.utilsAdvisor.AssetParameter().PrintDatabase(descriptorAdvisor);
					return;
				}
				case (ParamUtils.FDESVR)31:
				{
					ParamUtils.ComparatorUtils comparatorUtils = ParamUtils.FactoryUtils.InitParameter(this.utilsAdvisor.AssetParameter());
					if (comparatorUtils == null)
					{
						throw new ParamUtils.ExporterUtils();
					}
					this.utilsAdvisor.PostParameter(comparatorUtils.ListPublisher());
					return;
				}
				case (ParamUtils.FDESVR)32:
				{
					ParamUtils.ComparatorUtils comparatorUtils = ParamUtils.FactoryUtils.InitParameter(this.utilsAdvisor.AssetParameter());
					if (comparatorUtils != null)
					{
						this.utilsAdvisor.PostParameter(comparatorUtils.EnablePublisher());
						return;
					}
					throw new ParamUtils.ExporterUtils();
				}
				case (ParamUtils.FDESVR)34:
				{
					ParamUtils.ComparatorUtils comparatorUtils = ParamUtils.FactoryUtils.InitParameter(this.utilsAdvisor.AssetParameter());
					ParamUtils.ComparatorUtils comparatorUtils2 = ParamUtils.FactoryUtils.InitParameter(this.utilsAdvisor.AssetParameter());
					if (comparatorUtils2 != null && comparatorUtils != null)
					{
						this.utilsAdvisor.PostParameter(comparatorUtils2.ManagePublisher(comparatorUtils));
						return;
					}
					throw new ParamUtils.ExporterUtils();
				}
				case (ParamUtils.FDESVR)36:
					this.utilsAdvisor.PostParameter(this.utilsAdvisor.AssetParameter().CustomizePublisher());
					return;
				case (ParamUtils.FDESVR)37:
				{
					ParamUtils.ComparatorUtils comparatorUtils = ParamUtils.FactoryUtils.InitParameter(this.utilsAdvisor.AssetParameter());
					object obj = ((System.Array)this.utilsAdvisor.AssetParameter().RateDatabase(null)).GetValue(comparatorUtils.AddDatabase().messageUtils.m_MethodUtils);
					this.utilsAdvisor.PostParameter(ParamUtils.DescriptorAdvisor.UpdateParameter(typeof(uint), obj));
					return;
				}
				case (ParamUtils.FDESVR)38:
				{
					int num = (int)this._WriterAdvisor;
					System.Type type = typeof(ParamUtils).Module.ResolveType(num);
					ParamUtils.DescriptorAdvisor descriptorAdvisor = this.utilsAdvisor.AssetParameter();
					object obj = descriptorAdvisor.RateDatabase(null);
					if (obj == null)
					{
						this.utilsAdvisor.PostParameter(new ParamUtils.WorkerAdvisor(null));
						return;
					}
					if (type.IsAssignableFrom(obj.GetType()))
					{
						this.utilsAdvisor.PostParameter(descriptorAdvisor);
						return;
					}
					this.utilsAdvisor.PostParameter(new ParamUtils.WorkerAdvisor(null));
					return;
				}
				case (ParamUtils.FDESVR)40:
				{
					ParamUtils.DescriptorAdvisor descriptorAdvisor = this.utilsAdvisor.AssetParameter();
					ParamUtils.ComparatorUtils comparatorUtils = ParamUtils.FactoryUtils.InitParameter(descriptorAdvisor);
					if (descriptorAdvisor != null && descriptorAdvisor.OrderPublisher() && comparatorUtils != null)
					{
						this.utilsAdvisor.PostParameter(comparatorUtils.WritePublisher());
						return;
					}
					if (comparatorUtils != null && comparatorUtils.InterruptParameter())
					{
						System.IntPtr intPtr = ((ParamUtils.WrapperUtils)comparatorUtils).InstantiateUtils();
						this.utilsAdvisor.PostParameter(new ParamUtils.CollectionUtils(*(uint*)((void*)intPtr), (ParamUtils.ProcessUtils)6));
						return;
					}
					throw new ParamUtils.ExporterUtils();
				}
				case (ParamUtils.FDESVR)41:
					this.utilsAdvisor.PostParameter(new ParamUtils.CollectionUtils((int)this._WriterAdvisor));
					return;
				case (ParamUtils.FDESVR)42:
				{
					ParamUtils.ComparatorUtils comparatorUtils = ParamUtils.FactoryUtils.InitParameter(this.utilsAdvisor.AssetParameter());
					if (comparatorUtils != null)
					{
						this.utilsAdvisor.PostParameter(comparatorUtils.SearchPublisher());
						return;
					}
					throw new ParamUtils.ExporterUtils();
				}
				case (ParamUtils.FDESVR)43:
				{
					int num = (int)this._WriterAdvisor;
					System.Reflection.FieldInfo fieldInfo = typeof(ParamUtils).Module.ResolveField(num);
					object obj = this.utilsAdvisor.AssetParameter().RateDatabase(fieldInfo.FieldType);
					ParamUtils.DescriptorAdvisor descriptorAdvisor = this.utilsAdvisor.AssetParameter();
					object obj2 = descriptorAdvisor.RateDatabase(null);
					if (obj2 == null)
					{
						System.Type type = fieldInfo.DeclaringType;
						if (type.IsByRef)
						{
							type = type.GetElementType();
						}
						if (!type.IsValueType)
						{
							throw new System.NullReferenceException();
						}
						obj2 = System.Activator.CreateInstance(type);
						if (descriptorAdvisor is ParamUtils.VisitorUtils)
						{
							((ParamUtils.ProducerUtils)descriptorAdvisor).CancelPublisher(ParamUtils.DescriptorAdvisor.UpdateParameter(type, obj2));
						}
					}
					fieldInfo.SetValue(obj2, obj);
					return;
				}
				case (ParamUtils.FDESVR)44:
				{
					ParamUtils.ComparatorUtils comparatorUtils = ParamUtils.FactoryUtils.InitParameter(this.utilsAdvisor.AssetParameter());
					if (comparatorUtils == null)
					{
						throw new ParamUtils.ExporterUtils();
					}
					this.utilsAdvisor.PostParameter(comparatorUtils.FlushPublisher());
					return;
				}
				case (ParamUtils.FDESVR)46:
				{
					ParamUtils.ComparatorUtils comparatorUtils = ParamUtils.FactoryUtils.InitParameter(this.utilsAdvisor.AssetParameter());
					object obj = ((System.Array)this.utilsAdvisor.AssetParameter().RateDatabase(null)).GetValue(comparatorUtils.AddDatabase().messageUtils.m_MethodUtils);
					this.utilsAdvisor.PostParameter(ParamUtils.DescriptorAdvisor.UpdateParameter(typeof(ushort), obj));
					return;
				}
				case (ParamUtils.FDESVR)47:
				case (ParamUtils.FDESVR)166:
				{
					int num = (int)this._WriterAdvisor;
					System.Reflection.Module module = typeof(ParamUtils).Module;
					this.utilsAdvisor.PostParameter(new ParamUtils.WrapperUtils(module.ResolveMethod(num).MethodHandle.GetFunctionPointer()));
					return;
				}
				case (ParamUtils.FDESVR)48:
					throw (System.Exception)this.utilsAdvisor.AssetParameter().RateDatabase(null);
				case (ParamUtils.FDESVR)49:
				{
					ParamUtils.ComparatorUtils comparatorUtils = ParamUtils.FactoryUtils.InitParameter(this.utilsAdvisor.AssetParameter());
					object obj = ((System.Array)this.utilsAdvisor.AssetParameter().RateDatabase(null)).GetValue(comparatorUtils.AddDatabase().messageUtils.m_MethodUtils);
					this.utilsAdvisor.PostParameter(ParamUtils.DescriptorAdvisor.UpdateParameter(typeof(short), obj));
					return;
				}
				case (ParamUtils.FDESVR)50:
				{
					ParamUtils.DescriptorAdvisor descriptorAdvisor = this.utilsAdvisor.AssetParameter();
					ParamUtils.ComparatorUtils comparatorUtils = ParamUtils.FactoryUtils.InitParameter(descriptorAdvisor);
					if (descriptorAdvisor != null && descriptorAdvisor.OrderPublisher() && comparatorUtils != null)
					{
						this.utilsAdvisor.PostParameter(comparatorUtils.RevertDatabase());
						return;
					}
					if (comparatorUtils != null && comparatorUtils.InterruptParameter())
					{
						System.IntPtr intPtr = ((ParamUtils.WrapperUtils)comparatorUtils).InstantiateUtils();
						this.utilsAdvisor.PostParameter(new ParamUtils.CollectionUtils((int)(*(sbyte*)((void*)intPtr)), (ParamUtils.ProcessUtils)1));
						return;
					}
					throw new ParamUtils.ExporterUtils();
				}
				case (ParamUtils.FDESVR)51:
				{
					ParamUtils.DescriptorAdvisor descriptorAdvisor = this.utilsAdvisor.AssetParameter();
					if (descriptorAdvisor.InstantiatePublisher())
					{
						descriptorAdvisor = ((ParamUtils.ComparatorUtils)descriptorAdvisor).SetPublisher();
					}
					this.utilsAdvisor.AssetParameter().PrintDatabase(descriptorAdvisor);
					return;
				}
				case (ParamUtils.FDESVR)52:
				{
					ParamUtils.ComparatorUtils comparatorUtils = ParamUtils.FactoryUtils.InitParameter(this.utilsAdvisor.AssetParameter());
					ParamUtils.ComparatorUtils comparatorUtils2 = ParamUtils.FactoryUtils.InitParameter(this.utilsAdvisor.AssetParameter());
					if (comparatorUtils2 != null && comparatorUtils != null)
					{
						this.utilsAdvisor.PostParameter(comparatorUtils2.RunPublisher(comparatorUtils));
						return;
					}
					throw new ParamUtils.ExporterUtils();
				}
				case (ParamUtils.FDESVR)53:
				{
					ParamUtils.ComparatorUtils comparatorUtils = ParamUtils.FactoryUtils.InitParameter(this.utilsAdvisor.AssetParameter());
					ParamUtils.ComparatorUtils comparatorUtils2 = ParamUtils.FactoryUtils.InitParameter(this.utilsAdvisor.AssetParameter());
					if (comparatorUtils != null && comparatorUtils2 != null)
					{
						this.utilsAdvisor.PostParameter(comparatorUtils.AssetPublisher(comparatorUtils2));
						return;
					}
					throw new ParamUtils.ExporterUtils();
				}
				case (ParamUtils.FDESVR)54:
				{
					ParamUtils.DescriptorAdvisor descriptorAdvisor = this.utilsAdvisor.AssetParameter();
					ParamUtils.ComparatorUtils comparatorUtils = ParamUtils.FactoryUtils.InitParameter(descriptorAdvisor);
					ParamUtils.DescriptorAdvisor descriptorAdvisor3 = this.utilsAdvisor.AssetParameter();
					ParamUtils.ComparatorUtils comparatorUtils2 = ParamUtils.FactoryUtils.InitParameter(descriptorAdvisor3);
					if (comparatorUtils2 != null && comparatorUtils != null)
					{
						if (comparatorUtils2.LogoutPublisher(descriptorAdvisor))
						{
							this.m_DatabaseAdvisor = (int)this._WriterAdvisor - 1;
						}
						return;
					}
					if (descriptorAdvisor.ResetPublisher(descriptorAdvisor3))
					{
						this.m_DatabaseAdvisor = (int)this._WriterAdvisor - 1;
					}
					return;
				}
				case (ParamUtils.FDESVR)55:
				case (ParamUtils.FDESVR)107:
				{
					int num = (int)this._WriterAdvisor;
					System.Type type = typeof(ParamUtils).Module.ResolveType(num);
					ParamUtils.DescriptorAdvisor descriptorAdvisor = this.utilsAdvisor.AssetParameter();
					object obj = descriptorAdvisor.RateDatabase(type);
					if (obj == null)
					{
						if (type.IsValueType)
						{
							obj = System.Activator.CreateInstance(type);
							descriptorAdvisor = ParamUtils.DescriptorAdvisor.UpdateParameter(type, obj);
						}
						else
						{
							descriptorAdvisor = new ParamUtils.WorkerAdvisor(null);
						}
					}
					else
					{
						if (type.IsValueType)
						{
							obj = ParamUtils.FactoryUtils.CalculateParameter(obj);
						}
						descriptorAdvisor = ParamUtils.DescriptorAdvisor.UpdateParameter(type, obj);
					}
					ParamUtils.ProducerUtils producerUtils2 = this.utilsAdvisor.AssetParameter() as ParamUtils.ProducerUtils;
					if (producerUtils2 == null)
					{
						throw new ParamUtils.ExporterUtils();
					}
					producerUtils2.CompareDatabase(descriptorAdvisor);
					return;
				}
				case (ParamUtils.FDESVR)56:
				{
					ParamUtils.ComparatorUtils comparatorUtils = ParamUtils.FactoryUtils.InitParameter(this.utilsAdvisor.AssetParameter());
					if (comparatorUtils == null)
					{
						throw new ParamUtils.ExporterUtils();
					}
					this.utilsAdvisor.PostParameter(comparatorUtils.RevertDatabase());
					return;
				}
				case (ParamUtils.FDESVR)57:
				{
					ParamUtils.ComparatorUtils comparatorUtils = ParamUtils.FactoryUtils.InitParameter(this.utilsAdvisor.AssetParameter());
					if (comparatorUtils == null)
					{
						throw new ParamUtils.ExporterUtils();
					}
					this.utilsAdvisor.PostParameter(comparatorUtils.PublishPublisher());
					return;
				}
				case (ParamUtils.FDESVR)58:
					this.utilsAdvisor.AssetParameter();
					return;
				case (ParamUtils.FDESVR)59:
				{
					ParamUtils.DescriptorAdvisor descriptorAdvisor = this.utilsAdvisor.AssetParameter();
					if (ParamUtils.FactoryUtils.InitParameter(this.utilsAdvisor.AssetParameter()).RatePublisher(descriptorAdvisor))
					{
						this.m_DatabaseAdvisor = (int)this._WriterAdvisor - 1;
					}
					return;
				}
				case (ParamUtils.FDESVR)60:
				{
					ParamUtils.DescriptorAdvisor descriptorAdvisor = this.utilsAdvisor.AssetParameter();
					if (!ParamUtils.FactoryUtils.InitParameter(this.utilsAdvisor.AssetParameter()).RatePublisher(descriptorAdvisor))
					{
						this.utilsAdvisor.PostParameter(new ParamUtils.CollectionUtils(0));
						return;
					}
					this.utilsAdvisor.PostParameter(new ParamUtils.CollectionUtils(1));
					return;
				}
				case (ParamUtils.FDESVR)61:
				{
					int num = (int)this._WriterAdvisor;
					System.Reflection.FieldInfo fieldInfo = typeof(ParamUtils).Module.ResolveField(num);
					ParamUtils.DescriptorAdvisor descriptorAdvisor4 = this.utilsAdvisor.AssetParameter();
					descriptorAdvisor4.CustomizePublisher();
					object obj = descriptorAdvisor4.RateDatabase(null);
					this.utilsAdvisor.PostParameter(new ParamUtils.ResolverUtils(fieldInfo, obj));
					return;
				}
				case (ParamUtils.FDESVR)62:
				{
					ParamUtils.ComparatorUtils comparatorUtils = ParamUtils.FactoryUtils.InitParameter(this.utilsAdvisor.AssetParameter());
					object obj = ((System.Array)this.utilsAdvisor.AssetParameter().RateDatabase(null)).GetValue(comparatorUtils.AddDatabase().messageUtils.m_MethodUtils);
					this.utilsAdvisor.PostParameter(ParamUtils.DescriptorAdvisor.UpdateParameter(typeof(sbyte), obj));
					return;
				}
				case (ParamUtils.FDESVR)63:
				{
					System.IntPtr intPtr = System.Runtime.InteropServices.Marshal.AllocHGlobal((this.utilsAdvisor.AssetParameter() as ParamUtils.ComparatorUtils).AddDatabase().messageUtils.m_MethodUtils);
					if (this.parameterAdvisor == null)
					{
						this.parameterAdvisor = new System.Collections.Generic.List<System.IntPtr>();
					}
					this.parameterAdvisor.Add(intPtr);
					this.utilsAdvisor.PostParameter(new ParamUtils.WrapperUtils(intPtr));
					return;
				}
				case (ParamUtils.FDESVR)64:
				{
					int num = (int)this._WriterAdvisor;
					System.Reflection.Module module = typeof(ParamUtils).Module;
					object obj = null;
					try
					{
						obj = module.ResolveType(num);
					}
					catch
					{
						try
						{
							obj = module.ResolveMethod(num);
						}
						catch
						{
							try
							{
								obj = module.ResolveField(num);
							}
							catch
							{
								obj = module.ResolveMember(num);
							}
						}
					}
					this.utilsAdvisor.PostParameter(new ParamUtils.WorkerAdvisor(obj));
					return;
				}
				case (ParamUtils.FDESVR)65:
				{
					ParamUtils.ComparatorUtils comparatorUtils = ParamUtils.FactoryUtils.InitParameter(this.utilsAdvisor.AssetParameter());
					if (comparatorUtils != null)
					{
						this.utilsAdvisor.PostParameter(comparatorUtils.StartPublisher());
						return;
					}
					throw new ParamUtils.ExporterUtils();
				}
				case (ParamUtils.FDESVR)66:
				case (ParamUtils.FDESVR)78:
				case (ParamUtils.FDESVR)111:
				case (ParamUtils.FDESVR)112:
				case (ParamUtils.FDESVR)133:
				case (ParamUtils.FDESVR)137:
					throw new ParamUtils.ExporterUtils();
				case (ParamUtils.FDESVR)67:
					this.utilsAdvisor.PostParameter(this.utilsAdvisor.LoginParameter());
					return;
				case (ParamUtils.FDESVR)68:
				{
					ParamUtils.DescriptorAdvisor descriptorAdvisor = this.utilsAdvisor.AssetParameter();
					ParamUtils.ComparatorUtils comparatorUtils = ParamUtils.FactoryUtils.InitParameter(descriptorAdvisor);
					if (descriptorAdvisor != null && descriptorAdvisor.OrderPublisher() && comparatorUtils != null)
					{
						this.utilsAdvisor.PostParameter(comparatorUtils.CountPublisher());
						return;
					}
					if (comparatorUtils != null && comparatorUtils.InterruptParameter())
					{
						System.IntPtr intPtr = ((ParamUtils.WrapperUtils)comparatorUtils).InstantiateUtils();
						this.utilsAdvisor.PostParameter(new ParamUtils.CollectionUtils((int)(*(byte*)((void*)intPtr)), (ParamUtils.ProcessUtils)2));
						return;
					}
					throw new ParamUtils.ExporterUtils();
				}
				case (ParamUtils.FDESVR)69:
				{
					int num = (int)this._WriterAdvisor;
					System.Type type = typeof(ParamUtils).Module.ResolveType(num);
					ParamUtils.ComparatorUtils comparatorUtils = ParamUtils.FactoryUtils.InitParameter(this.utilsAdvisor.AssetParameter());
					object obj = ((System.Array)this.utilsAdvisor.AssetParameter().RateDatabase(null)).GetValue(comparatorUtils.AddDatabase().messageUtils.m_MethodUtils);
					this.utilsAdvisor.PostParameter(ParamUtils.DescriptorAdvisor.UpdateParameter(type, obj));
					return;
				}
				case (ParamUtils.FDESVR)70:
				{
					ParamUtils.DescriptorAdvisor descriptorAdvisor = this.utilsAdvisor.AssetParameter();
					ParamUtils.ComparatorUtils comparatorUtils = ParamUtils.FactoryUtils.InitParameter(descriptorAdvisor);
					if (descriptorAdvisor != null && descriptorAdvisor.OrderPublisher() && comparatorUtils != null)
					{
						this.utilsAdvisor.PostParameter(comparatorUtils.SetPublisher());
						return;
					}
					if (comparatorUtils != null && comparatorUtils.InterruptParameter())
					{
						System.IntPtr intPtr = ((ParamUtils.WrapperUtils)comparatorUtils).InstantiateUtils();
						this.utilsAdvisor.PostParameter(new ParamUtils.ReponseUtils(*(long*)((void*)intPtr), (ParamUtils.ProcessUtils)7));
						return;
					}
					throw new ParamUtils.ExporterUtils();
				}
				case (ParamUtils.FDESVR)71:
					this.CalcParameter(false);
					return;
				case (ParamUtils.FDESVR)72:
				{
					ParamUtils.DescriptorAdvisor descriptorAdvisor = this.utilsAdvisor.AssetParameter();
					bool flag = ParamUtils.FactoryUtils.InitParameter(this.utilsAdvisor.AssetParameter()).RestartPublisher(descriptorAdvisor);
					if (!flag)
					{
						this.utilsAdvisor.PostParameter(new ParamUtils.CollectionUtils(0));
					}
					else
					{
						this.utilsAdvisor.PostParameter(new ParamUtils.CollectionUtils(1));
					}
					if (flag)
					{
						this.m_DatabaseAdvisor = (int)this._WriterAdvisor - 1;
					}
					return;
				}
				case (ParamUtils.FDESVR)73:
				{
					ParamUtils.DescriptorAdvisor descriptorAdvisor = this.utilsAdvisor.AssetParameter();
					ParamUtils.ComparatorUtils comparatorUtils = ParamUtils.FactoryUtils.InitParameter(descriptorAdvisor);
					if (descriptorAdvisor != null && descriptorAdvisor.OrderPublisher() && comparatorUtils != null)
					{
						this.utilsAdvisor.PostParameter(comparatorUtils.PublishPublisher());
						return;
					}
					if (comparatorUtils != null && comparatorUtils.InterruptParameter())
					{
						System.IntPtr intPtr = ((ParamUtils.WrapperUtils)comparatorUtils).InstantiateUtils();
						this.utilsAdvisor.PostParameter(new ParamUtils.CollectionUtils((int)(*(short*)((void*)intPtr)), (ParamUtils.ProcessUtils)3));
						return;
					}
					throw new ParamUtils.ExporterUtils();
				}
				case (ParamUtils.FDESVR)74:
				{
					ParamUtils.DescriptorAdvisor descriptorAdvisor = this.utilsAdvisor.AssetParameter();
					this.utilsAdvisor.AssetParameter().PrintDatabase(descriptorAdvisor);
					return;
				}
				case (ParamUtils.FDESVR)75:
				{
					ParamUtils.ComparatorUtils comparatorUtils = ParamUtils.FactoryUtils.InitParameter(this.utilsAdvisor.AssetParameter());
					if (comparatorUtils == null)
					{
						throw new ParamUtils.ExporterUtils();
					}
					this.utilsAdvisor.PostParameter(comparatorUtils.CalcPublisher());
					return;
				}
				case (ParamUtils.FDESVR)76:
				{
					ParamUtils.ComparatorUtils comparatorUtils = ParamUtils.FactoryUtils.InitParameter(this.utilsAdvisor.AssetParameter());
					ParamUtils.ComparatorUtils comparatorUtils2 = ParamUtils.FactoryUtils.InitParameter(this.utilsAdvisor.AssetParameter());
					if (comparatorUtils2 != null && comparatorUtils != null)
					{
						this.utilsAdvisor.PostParameter(comparatorUtils2.CallPublisher(comparatorUtils));
						return;
					}
					throw new ParamUtils.ExporterUtils();
				}
				case (ParamUtils.FDESVR)77:
				{
					ParamUtils.DescriptorAdvisor descriptorAdvisor5 = ParamUtils.FactoryUtils.PushParameter(this.utilsAdvisor.AssetParameter());
					ParamUtils.DescriptorAdvisor descriptorAdvisor = ParamUtils.FactoryUtils.PushParameter(this.utilsAdvisor.AssetParameter());
					if (!descriptorAdvisor5.ValidatePublisher(descriptorAdvisor))
					{
						this.utilsAdvisor.PostParameter(new ParamUtils.CollectionUtils(0));
						return;
					}
					this.utilsAdvisor.PostParameter(new ParamUtils.CollectionUtils(1));
					return;
				}
				case (ParamUtils.FDESVR)79:
					if (ParamUtils.helperUtils.Count == 0)
					{
						System.Reflection.Module module = typeof(ParamUtils).Module;
						this.utilsAdvisor.PostParameter(new ParamUtils.ParamAdvisor(module.ResolveString((int)this._WriterAdvisor | 1879048192)));
						return;
					}
					this.utilsAdvisor.PostParameter(new ParamUtils.ParamAdvisor(ParamUtils.helperUtils[(int)this._WriterAdvisor]));
					return;
				case (ParamUtils.FDESVR)80:
					this.utilsAdvisor.PostParameter(new ParamUtils.WorkerAdvisor(null));
					return;
				case (ParamUtils.FDESVR)81:
				{
					ParamUtils.DescriptorAdvisor descriptorAdvisor = this.utilsAdvisor.AssetParameter();
					if (ParamUtils.FactoryUtils.InitParameter(this.utilsAdvisor.AssetParameter()).PreparePublisher(descriptorAdvisor))
					{
						this.utilsAdvisor.PostParameter(new ParamUtils.CollectionUtils(1));
						return;
					}
					this.utilsAdvisor.PostParameter(new ParamUtils.CollectionUtils(0));
					return;
				}
				case (ParamUtils.FDESVR)82:
					this.utilsAdvisor.PostParameter(new ParamUtils.CreatorUtils((double)this._WriterAdvisor));
					return;
				case (ParamUtils.FDESVR)83:
				{
					int num = (int)this._WriterAdvisor;
					System.Type elementType = typeof(ParamUtils).Module.ResolveType(num);
					ParamUtils.ComparatorUtils comparatorUtils = ParamUtils.FactoryUtils.InitParameter(this.utilsAdvisor.AssetParameter());
					System.Array array3 = System.Array.CreateInstance(elementType, comparatorUtils.AddDatabase().messageUtils.m_MethodUtils);
					this.utilsAdvisor.PostParameter(new ParamUtils.WorkerAdvisor(array3));
					return;
				}
				case (ParamUtils.FDESVR)84:
					this.m_DatabaseAdvisor = (int)this._WriterAdvisor - 1;
					return;
				case (ParamUtils.FDESVR)86:
				{
					ParamUtils.ComparatorUtils comparatorUtils = ParamUtils.FactoryUtils.InitParameter(this.utilsAdvisor.AssetParameter());
					if (comparatorUtils == null)
					{
						throw new ParamUtils.ExporterUtils();
					}
					this.utilsAdvisor.PostParameter(comparatorUtils.ChangePublisher());
					return;
				}
				case (ParamUtils.FDESVR)88:
				{
					ParamUtils.ComparatorUtils comparatorUtils = ParamUtils.FactoryUtils.InitParameter(this.utilsAdvisor.AssetParameter());
					if (comparatorUtils != null)
					{
						this.utilsAdvisor.PostParameter(comparatorUtils.VerifyPublisher());
						return;
					}
					throw new ParamUtils.ExporterUtils();
				}
				case (ParamUtils.FDESVR)89:
				{
					ParamUtils.ComparatorUtils comparatorUtils = ParamUtils.FactoryUtils.InitParameter(this.utilsAdvisor.AssetParameter());
					if (comparatorUtils == null)
					{
						throw new ParamUtils.ExporterUtils();
					}
					this.utilsAdvisor.PostParameter(comparatorUtils.VisitPublisher());
					return;
				}
				case (ParamUtils.FDESVR)90:
				{
					ParamUtils.ComparatorUtils comparatorUtils = ParamUtils.FactoryUtils.InitParameter(this.utilsAdvisor.AssetParameter());
					object obj = ((System.Array)this.utilsAdvisor.AssetParameter().RateDatabase(null)).GetValue(comparatorUtils.AddDatabase().messageUtils.m_MethodUtils);
					this.utilsAdvisor.PostParameter(ParamUtils.DescriptorAdvisor.UpdateParameter(typeof(float), obj));
					return;
				}
				case (ParamUtils.FDESVR)91:
				{
					int num = (int)this._WriterAdvisor;
					typeof(ParamUtils).Module.ResolveType(num);
					ParamUtils.ComparatorUtils comparatorUtils = ParamUtils.FactoryUtils.InitParameter(this.utilsAdvisor.AssetParameter());
					System.Array array3 = (System.Array)this.utilsAdvisor.AssetParameter().RateDatabase(null);
					this.utilsAdvisor.PostParameter(new ParamUtils.DispatcherUtils(comparatorUtils.AddDatabase().messageUtils.m_MethodUtils, array3));
					return;
				}
				case (ParamUtils.FDESVR)92:
				{
					ParamUtils.ComparatorUtils comparatorUtils = ParamUtils.FactoryUtils.InitParameter(this.utilsAdvisor.AssetParameter());
					if (comparatorUtils == null)
					{
						throw new ParamUtils.ExporterUtils();
					}
					this.utilsAdvisor.PostParameter(comparatorUtils.RegisterPublisher());
					return;
				}
				case (ParamUtils.FDESVR)93:
					this.CalcParameter(true);
					return;
				case (ParamUtils.FDESVR)94:
				{
					ParamUtils.ComparatorUtils comparatorUtils = ParamUtils.FactoryUtils.InitParameter(this.utilsAdvisor.AssetParameter());
					ParamUtils.ComparatorUtils comparatorUtils2 = ParamUtils.FactoryUtils.InitParameter(this.utilsAdvisor.AssetParameter());
					if (comparatorUtils2 != null && comparatorUtils != null)
					{
						this.utilsAdvisor.PostParameter(comparatorUtils2.QueryPublisher(comparatorUtils));
						return;
					}
					throw new ParamUtils.ExporterUtils();
				}
				case (ParamUtils.FDESVR)95:
				{
					ParamUtils.DescriptorAdvisor descriptorAdvisor = this.utilsAdvisor.AssetParameter();
					ParamUtils.ComparatorUtils comparatorUtils = ParamUtils.FactoryUtils.InitParameter(descriptorAdvisor);
					if (descriptorAdvisor != null && descriptorAdvisor.OrderPublisher() && comparatorUtils != null)
					{
						this.utilsAdvisor.PostParameter(comparatorUtils.DestroyPublisher());
						return;
					}
					if (comparatorUtils == null || !comparatorUtils.InterruptParameter())
					{
						throw new ParamUtils.ExporterUtils();
					}
					System.IntPtr intPtr = ((ParamUtils.WrapperUtils)comparatorUtils).InstantiateUtils();
					if (System.IntPtr.Size == 8)
					{
						long num2 = *(long*)((void*)intPtr);
						this.utilsAdvisor.PostParameter(new ParamUtils.WrapperUtils(num2, (ParamUtils.ProcessUtils)12));
						return;
					}
					int num = *(int*)((void*)intPtr);
					this.utilsAdvisor.PostParameter(new ParamUtils.WrapperUtils((long)num, (ParamUtils.ProcessUtils)12));
					return;
				}
				case (ParamUtils.FDESVR)96:
				{
					ParamUtils.ComparatorUtils comparatorUtils = ParamUtils.FactoryUtils.InitParameter(this.utilsAdvisor.AssetParameter());
					ParamUtils.ComparatorUtils comparatorUtils2 = ParamUtils.FactoryUtils.InitParameter(this.utilsAdvisor.AssetParameter());
					if (comparatorUtils2 != null && comparatorUtils != null)
					{
						this.utilsAdvisor.PostParameter(comparatorUtils2.CalculatePublisher(comparatorUtils));
						return;
					}
					throw new ParamUtils.ExporterUtils();
				}
				case (ParamUtils.FDESVR)97:
				{
					ParamUtils.ComparatorUtils comparatorUtils = ParamUtils.FactoryUtils.InitParameter(this.utilsAdvisor.AssetParameter());
					ParamUtils.ComparatorUtils comparatorUtils2 = ParamUtils.FactoryUtils.InitParameter(this.utilsAdvisor.AssetParameter());
					if (comparatorUtils != null && comparatorUtils2 != null)
					{
						this.utilsAdvisor.PostParameter(comparatorUtils.ComputePublisher(comparatorUtils2));
						return;
					}
					throw new ParamUtils.ExporterUtils();
				}
				case (ParamUtils.FDESVR)98:
				{
					ParamUtils.DescriptorAdvisor descriptorAdvisor = this.utilsAdvisor.AssetParameter();
					if (descriptorAdvisor.InstantiatePublisher())
					{
						descriptorAdvisor = ((ParamUtils.ComparatorUtils)descriptorAdvisor).SetupPublisher();
					}
					this.utilsAdvisor.AssetParameter().PrintDatabase(descriptorAdvisor);
					return;
				}
				case (ParamUtils.FDESVR)99:
				{
					ParamUtils.ComparatorUtils comparatorUtils = ParamUtils.FactoryUtils.InitParameter(this.utilsAdvisor.AssetParameter());
					if (comparatorUtils != null)
					{
						this.utilsAdvisor.PostParameter(comparatorUtils.MapPublisher());
						return;
					}
					throw new ParamUtils.ExporterUtils();
				}
				case (ParamUtils.FDESVR)100:
				{
					System.Array array3 = (System.Array)this.utilsAdvisor.AssetParameter().RateDatabase(null);
					this.utilsAdvisor.PostParameter(new ParamUtils.CollectionUtils(array3.Length, (ParamUtils.ProcessUtils)5));
					return;
				}
				case (ParamUtils.FDESVR)101:
				{
					ParamUtils.ComparatorUtils comparatorUtils = ParamUtils.FactoryUtils.InitParameter(this.utilsAdvisor.AssetParameter());
					ParamUtils.ComparatorUtils comparatorUtils2 = ParamUtils.FactoryUtils.InitParameter(this.utilsAdvisor.AssetParameter());
					if (comparatorUtils2 != null && comparatorUtils != null)
					{
						this.utilsAdvisor.PostParameter(comparatorUtils2.FillPublisher(comparatorUtils));
						return;
					}
					throw new ParamUtils.ExporterUtils();
				}
				case (ParamUtils.FDESVR)102:
				{
					ParamUtils.ComparatorUtils comparatorUtils = ParamUtils.FactoryUtils.InitParameter(this.utilsAdvisor.AssetParameter());
					object obj = ((System.Array)this.utilsAdvisor.AssetParameter().RateDatabase(null)).GetValue(comparatorUtils.AddDatabase().messageUtils.m_MethodUtils);
					this.utilsAdvisor.PostParameter(ParamUtils.DescriptorAdvisor.UpdateParameter(typeof(byte), obj));
					return;
				}
				case (ParamUtils.FDESVR)103:
					throw this.m_RefAdvisor;
				case (ParamUtils.FDESVR)104:
				{
					ParamUtils.ComparatorUtils comparatorUtils = ParamUtils.FactoryUtils.InitParameter(this.utilsAdvisor.AssetParameter());
					if (comparatorUtils == null)
					{
						throw new ParamUtils.ExporterUtils();
					}
					this.utilsAdvisor.PostParameter(comparatorUtils.ReadPublisher());
					return;
				}
				case (ParamUtils.FDESVR)105:
				{
					int num = (int)this._WriterAdvisor;
					System.Reflection.ConstructorInfo constructorInfo = (System.Reflection.ConstructorInfo)typeof(ParamUtils).Module.ResolveMethod(num);
					System.Reflection.ParameterInfo[] parameters = constructorInfo.GetParameters();
					object[] array4 = new object[parameters.Length];
					ParamUtils.DescriptorAdvisor[] array5 = new ParamUtils.DescriptorAdvisor[parameters.Length];
					System.Collections.Generic.List<ParamUtils.ConsumerUtils> list = null;
					ParamUtils.ValUtils valUtils = null;
					for (int i = 0; i < parameters.Length; i++)
					{
						ParamUtils.DescriptorAdvisor descriptorAdvisor = this.utilsAdvisor.AssetParameter();
						System.Type type = parameters[parameters.Length - 1 - i].ParameterType;
						object obj2 = null;
						bool flag2 = false;
						if (type.IsByRef)
						{
							ParamUtils.ResolverUtils resolverUtils = descriptorAdvisor as ParamUtils.ResolverUtils;
							if (resolverUtils != null)
							{
								if (list == null)
								{
									list = new System.Collections.Generic.List<ParamUtils.ConsumerUtils>();
								}
								list.Add(new ParamUtils.ConsumerUtils(resolverUtils.adapterUtils, i));
								obj2 = resolverUtils.mapperUtils;
								if (obj2 is ParamUtils.DescriptorAdvisor)
								{
									descriptorAdvisor = (obj2 as ParamUtils.DescriptorAdvisor);
								}
								else
								{
									flag2 = true;
								}
							}
						}
						if (!flag2)
						{
							if (descriptorAdvisor != null)
							{
								obj2 = descriptorAdvisor.RateDatabase(type);
							}
							if (obj2 == null)
							{
								if (type.IsByRef)
								{
									type = type.GetElementType();
								}
								if (type.IsValueType)
								{
									obj2 = System.Activator.CreateInstance(type);
									if (descriptorAdvisor is ParamUtils.VisitorUtils)
									{
										((ParamUtils.ProducerUtils)descriptorAdvisor).CancelPublisher(ParamUtils.DescriptorAdvisor.UpdateParameter(type, obj2));
									}
								}
							}
						}
						array5[array4.Length - 1 - i] = descriptorAdvisor;
						array4[array4.Length - 1 - i] = obj2;
					}
					ParamUtils.SystemUtils systemUtils = null;
					if (list != null)
					{
						valUtils = new ParamUtils.ValUtils(constructorInfo, list);
						systemUtils = ParamUtils.FactoryUtils.StartParameter(constructorInfo, true, valUtils);
					}
					object obj = null;
					if (systemUtils == null)
					{
						obj = constructorInfo.Invoke(array4);
					}
					else
					{
						obj = systemUtils(null, array4);
					}
					for (int j = 0; j < parameters.Length; j++)
					{
						if (parameters[j].ParameterType.IsByRef && (valUtils == null || !valUtils.CountAdvisor(j)))
						{
							if (!array5[j].InterruptParameter())
							{
								if (!(array5[j] is ParamUtils.VisitorUtils))
								{
									array5[j].CompareDatabase(ParamUtils.DescriptorAdvisor.UpdateParameter(parameters[j].ParameterType, array4[j]));
								}
								else
								{
									array5[j].CompareDatabase(ParamUtils.DescriptorAdvisor.UpdateParameter(parameters[j].ParameterType.GetElementType(), array4[j]));
								}
							}
							else
							{
								((ParamUtils.WrapperUtils)array5[j]).InsertUtils(ParamUtils.DescriptorAdvisor.UpdateParameter(parameters[j].ParameterType, array4[j]));
							}
						}
					}
					this.utilsAdvisor.PostParameter(ParamUtils.DescriptorAdvisor.UpdateParameter(constructorInfo.DeclaringType, obj));
					return;
				}
				case (ParamUtils.FDESVR)106:
					return;
				case (ParamUtils.FDESVR)108:
				{
					ParamUtils.ComparatorUtils comparatorUtils = ParamUtils.FactoryUtils.InitParameter(this.utilsAdvisor.AssetParameter());
					ParamUtils.ComparatorUtils comparatorUtils2 = ParamUtils.FactoryUtils.InitParameter(this.utilsAdvisor.AssetParameter());
					if (comparatorUtils2 != null && comparatorUtils != null)
					{
						this.utilsAdvisor.PostParameter(comparatorUtils2.MovePublisher(comparatorUtils));
						return;
					}
					throw new ParamUtils.ExporterUtils();
				}
				case (ParamUtils.FDESVR)109:
				{
					ParamUtils.ComparatorUtils comparatorUtils = ParamUtils.FactoryUtils.InitParameter(this.utilsAdvisor.AssetParameter());
					if (comparatorUtils == null)
					{
						throw new ParamUtils.ExporterUtils();
					}
					this.utilsAdvisor.PostParameter(comparatorUtils.WritePublisher());
					return;
				}
				case (ParamUtils.FDESVR)110:
				{
					ParamUtils.DescriptorAdvisor descriptorAdvisor = this.utilsAdvisor.AssetParameter();
					ParamUtils.ComparatorUtils comparatorUtils = ParamUtils.FactoryUtils.InitParameter(descriptorAdvisor);
					if (descriptorAdvisor != null && descriptorAdvisor.OrderPublisher() && comparatorUtils != null)
					{
						this.utilsAdvisor.PostParameter(comparatorUtils.PopPublisher());
						return;
					}
					if (comparatorUtils != null && comparatorUtils.InterruptParameter())
					{
						System.IntPtr intPtr = ((ParamUtils.WrapperUtils)comparatorUtils).InstantiateUtils();
						this.utilsAdvisor.PostParameter(new ParamUtils.CreatorUtils(*(float*)((void*)intPtr), (ParamUtils.ProcessUtils)9));
						return;
					}
					throw new ParamUtils.ExporterUtils();
				}
				case (ParamUtils.FDESVR)114:
				{
					ParamUtils.DescriptorAdvisor descriptorAdvisor = this.singletonAdvisor[(int)this._WriterAdvisor];
					this.utilsAdvisor.PostParameter(descriptorAdvisor);
					return;
				}
				case (ParamUtils.FDESVR)115:
				{
					ParamUtils.ComparatorUtils comparatorUtils = ParamUtils.FactoryUtils.InitParameter(this.utilsAdvisor.AssetParameter());
					if (comparatorUtils != null)
					{
						this.utilsAdvisor.PostParameter(comparatorUtils.LoginPublisher());
						return;
					}
					throw new ParamUtils.ExporterUtils();
				}
				case (ParamUtils.FDESVR)116:
				{
					ParamUtils.ComparatorUtils comparatorUtils = ParamUtils.FactoryUtils.InitParameter(this.utilsAdvisor.AssetParameter());
					ParamUtils.ComparatorUtils comparatorUtils2 = ParamUtils.FactoryUtils.InitParameter(this.utilsAdvisor.AssetParameter());
					if (comparatorUtils2 != null && comparatorUtils != null)
					{
						this.utilsAdvisor.PostParameter(comparatorUtils2.RemovePublisher(comparatorUtils));
						return;
					}
					throw new ParamUtils.ExporterUtils();
				}
				case (ParamUtils.FDESVR)117:
				{
					ParamUtils.ComparatorUtils comparatorUtils = ParamUtils.FactoryUtils.InitParameter(this.utilsAdvisor.AssetParameter());
					object obj = ((System.Array)this.utilsAdvisor.AssetParameter().RateDatabase(null)).GetValue(comparatorUtils.AddDatabase().messageUtils.m_MethodUtils);
					this.utilsAdvisor.PostParameter(ParamUtils.DescriptorAdvisor.UpdateParameter(typeof(int), obj));
					return;
				}
				case (ParamUtils.FDESVR)118:
				{
					ParamUtils.DescriptorAdvisor descriptorAdvisor = this.utilsAdvisor.AssetParameter();
					if (descriptorAdvisor.InstantiatePublisher())
					{
						descriptorAdvisor = ((ParamUtils.ComparatorUtils)descriptorAdvisor).DestroyPublisher();
					}
					this.utilsAdvisor.AssetParameter().PrintDatabase(descriptorAdvisor);
					return;
				}
				case (ParamUtils.FDESVR)119:
				{
					int num = (int)this._WriterAdvisor;
					System.Type type = typeof(ParamUtils).Module.ResolveType(num);
					ParamUtils.ProducerUtils producerUtils3 = this.utilsAdvisor.AssetParameter() as ParamUtils.ProducerUtils;
					if (producerUtils3 == null)
					{
						throw new ParamUtils.ExporterUtils();
					}
					object obj = producerUtils3.RateDatabase(type);
					ParamUtils.DescriptorAdvisor descriptorAdvisor;
					if (obj == null)
					{
						if (type.IsValueType)
						{
							obj = System.Activator.CreateInstance(type);
							descriptorAdvisor = ParamUtils.DescriptorAdvisor.UpdateParameter(type, obj);
						}
						else
						{
							descriptorAdvisor = new ParamUtils.WorkerAdvisor(null);
						}
					}
					else
					{
						if (type.IsValueType)
						{
							obj = ParamUtils.FactoryUtils.CalculateParameter(obj);
						}
						descriptorAdvisor = ParamUtils.DescriptorAdvisor.UpdateParameter(type, obj);
					}
					this.utilsAdvisor.PostParameter(descriptorAdvisor);
					return;
				}
				case (ParamUtils.FDESVR)120:
					this.utilsAdvisor.PostParameter(((ParamUtils.ComparatorUtils)this.utilsAdvisor.AssetParameter()).ExcludePublisher());
					return;
				case (ParamUtils.FDESVR)121:
				{
					ParamUtils.ComparatorUtils comparatorUtils = ParamUtils.FactoryUtils.InitParameter(this.utilsAdvisor.AssetParameter());
					ParamUtils.ComparatorUtils comparatorUtils2 = ParamUtils.FactoryUtils.InitParameter(this.utilsAdvisor.AssetParameter());
					if (comparatorUtils2 != null && comparatorUtils != null)
					{
						this.utilsAdvisor.PostParameter(comparatorUtils2.StopPublisher(comparatorUtils));
						return;
					}
					throw new ParamUtils.ExporterUtils();
				}
				case (ParamUtils.FDESVR)122:
				{
					ParamUtils.DescriptorAdvisor descriptorAdvisor = this.utilsAdvisor.AssetParameter();
					ParamUtils.ComparatorUtils comparatorUtils = ParamUtils.FactoryUtils.InitParameter(descriptorAdvisor);
					if (descriptorAdvisor != null && descriptorAdvisor.OrderPublisher() && comparatorUtils != null)
					{
						this.utilsAdvisor.PostParameter(comparatorUtils.SetupPublisher());
						return;
					}
					if (comparatorUtils != null && comparatorUtils.InterruptParameter())
					{
						System.IntPtr intPtr = ((ParamUtils.WrapperUtils)comparatorUtils).InstantiateUtils();
						this.utilsAdvisor.PostParameter(new ParamUtils.CollectionUtils(*(int*)((void*)intPtr), (ParamUtils.ProcessUtils)5));
						return;
					}
					throw new ParamUtils.ExporterUtils();
				}
				case (ParamUtils.FDESVR)123:
				{
					ParamUtils.ComparatorUtils comparatorUtils = ParamUtils.FactoryUtils.InitParameter(this.utilsAdvisor.AssetParameter());
					if (comparatorUtils == null)
					{
						throw new ParamUtils.ExporterUtils();
					}
					this.utilsAdvisor.PostParameter(comparatorUtils.IncludePublisher());
					return;
				}
				case (ParamUtils.FDESVR)124:
				{
					ParamUtils.DescriptorAdvisor descriptorAdvisor = this.utilsAdvisor.AssetParameter();
					if (ParamUtils.FactoryUtils.InitParameter(this.utilsAdvisor.AssetParameter()).TestPublisher(descriptorAdvisor))
					{
						this.m_DatabaseAdvisor = (int)this._WriterAdvisor - 1;
					}
					return;
				}
				case (ParamUtils.FDESVR)125:
				{
					ParamUtils.ComparatorUtils comparatorUtils = ParamUtils.FactoryUtils.InitParameter(this.utilsAdvisor.AssetParameter());
					object obj = ((System.Array)this.utilsAdvisor.AssetParameter().RateDatabase(null)).GetValue(comparatorUtils.AddDatabase().messageUtils.m_MethodUtils);
					this.utilsAdvisor.PostParameter(ParamUtils.DescriptorAdvisor.UpdateParameter(typeof(double), obj));
					return;
				}
				case (ParamUtils.FDESVR)126:
				{
					ParamUtils.ComparatorUtils comparatorUtils = ParamUtils.FactoryUtils.InitParameter(this.utilsAdvisor.AssetParameter());
					ParamUtils.ComparatorUtils comparatorUtils2 = ParamUtils.FactoryUtils.InitParameter(this.utilsAdvisor.AssetParameter());
					if (comparatorUtils2 != null && comparatorUtils != null)
					{
						this.utilsAdvisor.PostParameter(comparatorUtils2.DisablePublisher(comparatorUtils));
						return;
					}
					throw new ParamUtils.ExporterUtils();
				}
				case (ParamUtils.FDESVR)127:
				{
					ParamUtils.ComparatorUtils comparatorUtils = ParamUtils.FactoryUtils.InitParameter(this.utilsAdvisor.AssetParameter());
					if (comparatorUtils != null)
					{
						this.utilsAdvisor.PostParameter(comparatorUtils.ForgotPublisher());
						return;
					}
					throw new ParamUtils.ExporterUtils();
				}
				case (ParamUtils.FDESVR)128:
				{
					ParamUtils.DescriptorAdvisor descriptorAdvisor = this.utilsAdvisor.AssetParameter();
					if (descriptorAdvisor.OrderPublisher())
					{
						object obj = descriptorAdvisor.RateDatabase(null);
						if (obj != null)
						{
							descriptorAdvisor = ParamUtils.DescriptorAdvisor.UpdateParameter(obj.GetType(), obj);
						}
						else
						{
							descriptorAdvisor = new ParamUtils.WorkerAdvisor(null);
						}
						this.utilsAdvisor.PostParameter(descriptorAdvisor);
						return;
					}
					throw new ParamUtils.ExporterUtils();
				}
				case (ParamUtils.FDESVR)129:
				{
					ParamUtils.DescriptorAdvisor descriptorAdvisor = this.utilsAdvisor.AssetParameter();
					if (!ParamUtils.FactoryUtils.InitParameter(this.utilsAdvisor.AssetParameter()).RestartPublisher(descriptorAdvisor))
					{
						this.utilsAdvisor.PostParameter(new ParamUtils.CollectionUtils(0));
						return;
					}
					this.utilsAdvisor.PostParameter(new ParamUtils.CollectionUtils(1));
					return;
				}
				case (ParamUtils.FDESVR)130:
				{
					ParamUtils.ComparatorUtils comparatorUtils = ParamUtils.FactoryUtils.InitParameter(this.utilsAdvisor.AssetParameter());
					if (comparatorUtils == null)
					{
						throw new ParamUtils.ExporterUtils();
					}
					this.utilsAdvisor.PostParameter(comparatorUtils.CollectPublisher());
					return;
				}
				case (ParamUtils.FDESVR)131:
				{
					ParamUtils.ComparatorUtils comparatorUtils = ParamUtils.FactoryUtils.InitParameter(this.utilsAdvisor.AssetParameter());
					if (comparatorUtils != null)
					{
						this.utilsAdvisor.PostParameter(comparatorUtils.AwakePublisher());
						return;
					}
					throw new ParamUtils.ExporterUtils();
				}
				case (ParamUtils.FDESVR)132:
				{
					int num = (int)this._WriterAdvisor;
					System.Type type = typeof(ParamUtils).Module.ResolveType(num);
					ParamUtils.DescriptorAdvisor descriptorAdvisor = this.utilsAdvisor.AssetParameter();
					ParamUtils.ComparatorUtils comparatorUtils = ParamUtils.FactoryUtils.InitParameter(this.utilsAdvisor.AssetParameter());
					((System.Array)this.utilsAdvisor.AssetParameter().RateDatabase(null)).SetValue(descriptorAdvisor.RateDatabase(type), comparatorUtils.AddDatabase().messageUtils.m_MethodUtils);
					return;
				}
				case (ParamUtils.FDESVR)134:
					this.utilsAdvisor.PostParameter(new ParamUtils.TokenizerUtils((int)this._WriterAdvisor, this));
					return;
				case (ParamUtils.FDESVR)135:
				{
					int num = (int)this._WriterAdvisor;
					uint num3 = (uint)ParamUtils.FactoryUtils.CountParameter(typeof(ParamUtils).Module.ResolveType(num));
					this.utilsAdvisor.PostParameter(new ParamUtils.CollectionUtils(num3, (ParamUtils.ProcessUtils)6));
					return;
				}
				case (ParamUtils.FDESVR)136:
				{
					ParamUtils.ComparatorUtils comparatorUtils = this.utilsAdvisor.AssetParameter() as ParamUtils.ComparatorUtils;
					System.IntPtr intPtr = ParamUtils.FactoryUtils.ExcludeParameter(this.utilsAdvisor.AssetParameter());
					System.IntPtr intPtr2 = ParamUtils.FactoryUtils.ExcludeParameter(this.utilsAdvisor.AssetParameter());
					if (intPtr != System.IntPtr.Zero && intPtr2 != System.IntPtr.Zero)
					{
						uint num3 = comparatorUtils.CheckDatabase().messageUtils.m_RequestUtils;
						ParamUtils.FactoryUtils.RunParameter(intPtr2, intPtr, num3);
					}
					return;
				}
				case (ParamUtils.FDESVR)138:
				{
					ParamUtils.ComparatorUtils comparatorUtils = ParamUtils.FactoryUtils.InitParameter(this.utilsAdvisor.AssetParameter());
					if (comparatorUtils == null)
					{
						throw new ParamUtils.ExporterUtils();
					}
					this.utilsAdvisor.PostParameter(comparatorUtils.ConcatPublisher());
					return;
				}
				case (ParamUtils.FDESVR)139:
				{
					ParamUtils.ComparatorUtils comparatorUtils3 = ParamUtils.FactoryUtils.InitParameter(this.utilsAdvisor.LoginParameter());
					if (comparatorUtils3 != null)
					{
						ParamUtils.CreatorUtils creatorUtils = comparatorUtils3 as ParamUtils.CreatorUtils;
						if (creatorUtils != null)
						{
							if (double.IsNaN(creatorUtils.interceptorUtils))
							{
								throw new System.OverflowException(((ParamUtils.CancellationMode)2).ToString());
							}
							if (double.IsInfinity(creatorUtils.interceptorUtils))
							{
								throw new System.OverflowException(((ParamUtils.CancellationMode)1).ToString());
							}
						}
						return;
					}
					throw new System.ArithmeticException(((ParamUtils.CancellationMode)0).ToString());
				}
				case (ParamUtils.FDESVR)140:
				{
					ParamUtils.DescriptorAdvisor descriptorAdvisor = this.utilsAdvisor.AssetParameter();
					if (descriptorAdvisor.InstantiatePublisher())
					{
						descriptorAdvisor = ((ParamUtils.ComparatorUtils)descriptorAdvisor).RevertDatabase();
					}
					this.utilsAdvisor.AssetParameter().PrintDatabase(descriptorAdvisor);
					return;
				}
				case (ParamUtils.FDESVR)141:
				{
					ParamUtils.ComparatorUtils comparatorUtils = ParamUtils.FactoryUtils.InitParameter(this.utilsAdvisor.AssetParameter());
					if (comparatorUtils == null)
					{
						throw new ParamUtils.ExporterUtils();
					}
					this.utilsAdvisor.PostParameter(comparatorUtils.CreatePublisher());
					return;
				}
				case (ParamUtils.FDESVR)142:
				{
					ParamUtils.ComparatorUtils comparatorUtils = ParamUtils.FactoryUtils.InitParameter(this.utilsAdvisor.AssetParameter());
					System.Array array6 = (System.Array)this.utilsAdvisor.AssetParameter().RateDatabase(null);
					object obj = array6.GetValue(comparatorUtils.AddDatabase().messageUtils.m_MethodUtils);
					System.Type type = array6.GetType().GetElementType();
					this.utilsAdvisor.PostParameter(ParamUtils.DescriptorAdvisor.UpdateParameter(type, obj));
					return;
				}
				case (ParamUtils.FDESVR)143:
				{
					ParamUtils.ComparatorUtils comparatorUtils = ParamUtils.FactoryUtils.InitParameter(this.utilsAdvisor.AssetParameter());
					if (comparatorUtils != null)
					{
						this.utilsAdvisor.PostParameter(comparatorUtils.InitPublisher());
						return;
					}
					throw new ParamUtils.ExporterUtils();
				}
				case (ParamUtils.FDESVR)144:
					this.utilsAdvisor.PostParameter(this.m_ProcUtils[(int)this._WriterAdvisor]);
					return;
				case (ParamUtils.FDESVR)145:
				{
					object obj = this.utilsAdvisor.AssetParameter().RateDatabase(null);
					ParamUtils.DescriptorAdvisor descriptorAdvisor = null;
					if (ParamUtils.FactoryUtils.m_BridgeAdvisor.TryGetValue(obj, out descriptorAdvisor))
					{
						this.utilsAdvisor.PostParameter(descriptorAdvisor);
						return;
					}
					this.utilsAdvisor.PostParameter(new ParamUtils.WorkerAdvisor(null));
					return;
				}
				case (ParamUtils.FDESVR)146:
				{
					ParamUtils.DescriptorAdvisor descriptorAdvisor = this.utilsAdvisor.AssetParameter();
					ParamUtils.ComparatorUtils comparatorUtils = ParamUtils.FactoryUtils.InitParameter(descriptorAdvisor);
					if (descriptorAdvisor != null && descriptorAdvisor.OrderPublisher() && comparatorUtils != null)
					{
						this.utilsAdvisor.PostParameter(comparatorUtils.RegisterPublisher());
						return;
					}
					if (comparatorUtils != null && comparatorUtils.InterruptParameter())
					{
						System.IntPtr intPtr = ((ParamUtils.WrapperUtils)comparatorUtils).InstantiateUtils();
						this.utilsAdvisor.PostParameter(new ParamUtils.CreatorUtils(*(double*)((void*)intPtr), (ParamUtils.ProcessUtils)10));
						return;
					}
					throw new ParamUtils.ExporterUtils();
				}
				case (ParamUtils.FDESVR)147:
				{
					ParamUtils.DescriptorAdvisor descriptorAdvisor = this.utilsAdvisor.AssetParameter();
					object obj = this.utilsAdvisor.AssetParameter().RateDatabase(null);
					ParamUtils.FactoryUtils.m_BridgeAdvisor[obj] = descriptorAdvisor;
					return;
				}
				case (ParamUtils.FDESVR)148:
				{
					int num = (int)this._WriterAdvisor;
					this.singletonAdvisor[num] = this.CreateAdvisor(this.utilsAdvisor.AssetParameter(), this.m_GetterUtils._PoolUtils[num]._ObjectUtils, this.m_GetterUtils._PoolUtils[num].m_ObserverUtils);
					return;
				}
				case (ParamUtils.FDESVR)149:
					if (this.utilsAdvisor.AssetParameter().ResetPublisher(this.utilsAdvisor.AssetParameter()))
					{
						this.m_DatabaseAdvisor = (int)this._WriterAdvisor - 1;
					}
					return;
				case (ParamUtils.FDESVR)150:
				{
					ParamUtils.ComparatorUtils comparatorUtils = ParamUtils.FactoryUtils.InitParameter(this.utilsAdvisor.AssetParameter());
					ParamUtils.ComparatorUtils comparatorUtils2 = ParamUtils.FactoryUtils.InitParameter(this.utilsAdvisor.AssetParameter());
					if (comparatorUtils2 != null && comparatorUtils != null)
					{
						this.utilsAdvisor.PostParameter(comparatorUtils2.SelectPublisher(comparatorUtils));
						return;
					}
					throw new ParamUtils.ExporterUtils();
				}
				case (ParamUtils.FDESVR)151:
					this.prototypeAdvisor = (bool)this.utilsAdvisor.AssetParameter().RateDatabase(typeof(bool));
					this._AlgoAdvisor = true;
					return;
				case (ParamUtils.FDESVR)152:
				{
					int num = (int)this._WriterAdvisor;
					System.Reflection.FieldInfo fieldInfo = typeof(ParamUtils).Module.ResolveField(num);
					object obj = this.utilsAdvisor.AssetParameter().RateDatabase(null);
					this.utilsAdvisor.PostParameter(ParamUtils.DescriptorAdvisor.UpdateParameter(fieldInfo.FieldType, fieldInfo.GetValue(obj)));
					return;
				}
				case (ParamUtils.FDESVR)153:
				{
					ParamUtils.ComparatorUtils comparatorUtils = ParamUtils.FactoryUtils.InitParameter(this.utilsAdvisor.AssetParameter());
					if (comparatorUtils != null)
					{
						this.utilsAdvisor.PostParameter(comparatorUtils.DestroyPublisher());
						return;
					}
					throw new ParamUtils.ExporterUtils();
				}
				case (ParamUtils.FDESVR)154:
				{
					ParamUtils.DescriptorAdvisor descriptorAdvisor = this.utilsAdvisor.AssetParameter();
					if (ParamUtils.FactoryUtils.InitParameter(this.utilsAdvisor.AssetParameter()).ComparePublisher(descriptorAdvisor))
					{
						this.m_DatabaseAdvisor = (int)this._WriterAdvisor - 1;
					}
					return;
				}
				case (ParamUtils.FDESVR)156:
				{
					ParamUtils.DescriptorAdvisor descriptorAdvisor = this.utilsAdvisor.AssetParameter();
					if (ParamUtils.FactoryUtils.InitParameter(this.utilsAdvisor.AssetParameter()).PrintPublisher(descriptorAdvisor))
					{
						this.m_DatabaseAdvisor = (int)this._WriterAdvisor - 1;
					}
					return;
				}
				case (ParamUtils.FDESVR)157:
				{
					ParamUtils.ComparatorUtils comparatorUtils = ParamUtils.FactoryUtils.InitParameter(this.utilsAdvisor.AssetParameter());
					object obj = ((System.Array)this.utilsAdvisor.AssetParameter().RateDatabase(null)).GetValue(comparatorUtils.AddDatabase().messageUtils.m_MethodUtils);
					this.utilsAdvisor.PostParameter(ParamUtils.DescriptorAdvisor.UpdateParameter(typeof(System.IntPtr), obj));
					return;
				}
				case (ParamUtils.FDESVR)158:
				{
					ParamUtils.DescriptorAdvisor descriptorAdvisor = this.utilsAdvisor.AssetParameter();
					if (ParamUtils.FactoryUtils.InitParameter(this.utilsAdvisor.AssetParameter()).FindPublisher(descriptorAdvisor))
					{
						this.m_DatabaseAdvisor = (int)this._WriterAdvisor - 1;
					}
					return;
				}
				case (ParamUtils.FDESVR)159:
					this.m_DatabaseAdvisor = -3;
					if (this.utilsAdvisor.method_0() > 0)
					{
						this.advisorAdvisor = this.utilsAdvisor.AssetParameter();
					}
					return;
				case (ParamUtils.FDESVR)160:
				{
					ParamUtils.DescriptorAdvisor descriptorAdvisor = this.utilsAdvisor.AssetParameter();
					bool flag2 = descriptorAdvisor == null || !descriptorAdvisor.InsertDatabase();
					if (flag2)
					{
						this.m_DatabaseAdvisor = (int)this._WriterAdvisor - 1;
					}
					return;
				}
				case (ParamUtils.FDESVR)161:
				{
					ParamUtils.ComparatorUtils comparatorUtils = ParamUtils.FactoryUtils.InitParameter(this.utilsAdvisor.AssetParameter());
					if (comparatorUtils != null)
					{
						this.utilsAdvisor.PostParameter(comparatorUtils.ReflectPublisher());
						return;
					}
					throw new ParamUtils.ExporterUtils();
				}
				case (ParamUtils.FDESVR)162:
					this.utilsAdvisor.PostParameter(new ParamUtils.CreatorUtils((float)this._WriterAdvisor));
					return;
				case (ParamUtils.FDESVR)163:
				{
					ParamUtils.ComparatorUtils comparatorUtils = ParamUtils.FactoryUtils.InitParameter(this.utilsAdvisor.AssetParameter());
					ParamUtils.ComparatorUtils comparatorUtils2 = ParamUtils.FactoryUtils.InitParameter(this.utilsAdvisor.AssetParameter());
					if (comparatorUtils2 != null && comparatorUtils != null)
					{
						this.utilsAdvisor.PostParameter(comparatorUtils2.DeletePublisher(comparatorUtils));
						return;
					}
					throw new ParamUtils.ExporterUtils();
				}
				case (ParamUtils.FDESVR)164:
				{
					ParamUtils.ComparatorUtils comparatorUtils = this.utilsAdvisor.AssetParameter() as ParamUtils.ComparatorUtils;
					ParamUtils.ComparatorUtils comparatorUtils2 = this.utilsAdvisor.AssetParameter() as ParamUtils.ComparatorUtils;
					System.IntPtr intPtr = ParamUtils.FactoryUtils.ExcludeParameter(this.utilsAdvisor.AssetParameter());
					if (intPtr != System.IntPtr.Zero)
					{
						byte containerUtils = comparatorUtils2.OrderDatabase().messageUtils.m_ContainerUtils;
						uint num3 = comparatorUtils.CheckDatabase().messageUtils.m_RequestUtils;
						ParamUtils.FactoryUtils.DeleteParameter(intPtr, containerUtils, (int)num3);
					}
					return;
				}
				case (ParamUtils.FDESVR)165:
				{
					ParamUtils.ComparatorUtils comparatorUtils = ParamUtils.FactoryUtils.InitParameter(this.utilsAdvisor.AssetParameter());
					if (comparatorUtils != null)
					{
						this.utilsAdvisor.PostParameter(comparatorUtils.ClonePublisher());
						return;
					}
					throw new ParamUtils.ExporterUtils();
				}
				case (ParamUtils.FDESVR)167:
				{
					ParamUtils.DescriptorAdvisor descriptorAdvisor = this.utilsAdvisor.AssetParameter();
					if (ParamUtils.FactoryUtils.InitParameter(this.utilsAdvisor.AssetParameter()).PreparePublisher(descriptorAdvisor))
					{
						this.m_DatabaseAdvisor = (int)this._WriterAdvisor - 1;
					}
					return;
				}
				case (ParamUtils.FDESVR)169:
					this.callbackAdvisor = true;
					return;
				case (ParamUtils.FDESVR)170:
				{
					ParamUtils.ComparatorUtils comparatorUtils = ParamUtils.FactoryUtils.InitParameter(this.utilsAdvisor.AssetParameter());
					if (comparatorUtils == null)
					{
						throw new ParamUtils.ExporterUtils();
					}
					this.utilsAdvisor.PostParameter(comparatorUtils.SetupPublisher());
					return;
				}
				case (ParamUtils.FDESVR)172:
				{
					ParamUtils.ComparatorUtils comparatorUtils = ParamUtils.FactoryUtils.InitParameter(this.utilsAdvisor.AssetParameter());
					if (comparatorUtils == null)
					{
						throw new ParamUtils.ExporterUtils();
					}
					this.utilsAdvisor.PostParameter(comparatorUtils.PushPublisher());
					return;
				}
				case (ParamUtils.FDESVR)174:
				{
					System.Type type = typeof(ParamUtils).Module.ResolveType((int)this._WriterAdvisor);
					object obj = this.utilsAdvisor.AssetParameter().RateDatabase(type);
					if (obj == null)
					{
						obj = System.Activator.CreateInstance(type);
					}
					this.utilsAdvisor.PostParameter(new ParamUtils.WorkerAdvisor(ParamUtils.DescriptorAdvisor.UpdateParameter(type, ParamUtils.FactoryUtils.CalculateParameter(obj))));
					return;
				}
				case (ParamUtils.FDESVR)175:
				{
					ParamUtils.ComparatorUtils comparatorUtils = ParamUtils.FactoryUtils.InitParameter(this.utilsAdvisor.AssetParameter());
					if (comparatorUtils == null)
					{
						throw new ParamUtils.ExporterUtils();
					}
					this.utilsAdvisor.PostParameter(comparatorUtils.SetPublisher());
					return;
				}
				default:
					return;
				}
			}

			// Token: 0x060003B3 RID: 947 RVA: 0x00014A64 File Offset: 0x00012C64
			private ParamUtils.DescriptorAdvisor CreateAdvisor(ParamUtils.DescriptorAdvisor v, ParamUtils.ProcessUtils visitor, bool readproc = false)
			{
				if (!readproc && v.OrderPublisher())
				{
					v = v.CustomizePublisher();
				}
				if (v.ResolveParameter())
				{
					return ((ParamUtils.CollectionUtils)v).TestDatabase(visitor);
				}
				if (v.CallParameter())
				{
					return ((ParamUtils.ReponseUtils)v).TestDatabase(visitor);
				}
				if (v.FillParameter())
				{
					return ((ParamUtils.CreatorUtils)v).TestDatabase(visitor);
				}
				if (!v.InterruptParameter())
				{
					return v;
				}
				return ((ParamUtils.WrapperUtils)v).TestDatabase(visitor);
			}

			// Token: 0x060003B4 RID: 948 RVA: 0x000033D3 File Offset: 0x000015D3
			private ParamUtils.DescriptorAdvisor ConcatRef(int ID_ident)
			{
				return this.singletonAdvisor[ID_ident];
			}

			// Token: 0x060003B5 RID: 949 RVA: 0x00014ADC File Offset: 0x00012CDC
			private void InvokeRef(int insert_DEFAt)
			{
				this.ForgotParameter(insert_DEFAt, this.utilsAdvisor.AssetParameter());
			}

			// Token: 0x060003B6 RID: 950 RVA: 0x00014AFC File Offset: 0x00012CFC
			private static int CountParameter(System.Type config)
			{
				if (ParamUtils.FactoryUtils.authenticationAdvisor == null)
				{
					ParamUtils.FactoryUtils.authenticationAdvisor = new System.Collections.Generic.Dictionary<System.Type, int>();
				}
				int result;
				try
				{
					int num = 0;
					if (ParamUtils.FactoryUtils.authenticationAdvisor.TryGetValue(config, out num))
					{
						result = num;
					}
					else
					{
						System.Reflection.Emit.DynamicMethod dynamicMethod = new System.Reflection.Emit.DynamicMethod(string.Empty, typeof(int), System.Type.EmptyTypes, true);
						System.Reflection.Emit.ILGenerator ilgenerator = dynamicMethod.GetILGenerator();
						ilgenerator.Emit(System.Reflection.Emit.OpCodes.Sizeof, config);
						ilgenerator.Emit(System.Reflection.Emit.OpCodes.Ret);
						num = (int)dynamicMethod.Invoke(null, null);
						ParamUtils.FactoryUtils.authenticationAdvisor[config] = num;
						result = num;
					}
				}
				catch
				{
					result = 0;
				}
				return result;
			}

			// Token: 0x060003B7 RID: 951 RVA: 0x00014BA4 File Offset: 0x00012DA4
			private void ForgotParameter(int insert_TASKAt, ParamUtils.DescriptorAdvisor token)
			{
				this.singletonAdvisor[insert_TASKAt] = this.CreateAdvisor(token, this.m_GetterUtils._PoolUtils[insert_TASKAt]._ObjectUtils, this.m_GetterUtils._PoolUtils[insert_TASKAt].m_ObserverUtils);
			}

			// Token: 0x060003B8 RID: 952 RVA: 0x0000C50C File Offset: 0x0000A70C
			private static ParamUtils.ComparatorUtils InitParameter(ParamUtils.DescriptorAdvisor param)
			{
				ParamUtils.ComparatorUtils comparatorUtils = param as ParamUtils.ComparatorUtils;
				if (comparatorUtils == null && param.OrderPublisher())
				{
					comparatorUtils = (param.CustomizePublisher() as ParamUtils.ComparatorUtils);
				}
				return comparatorUtils;
			}

			// Token: 0x060003B9 RID: 953 RVA: 0x00014BEC File Offset: 0x00012DEC
			private void CalcParameter(bool isv)
			{
				int metadataToken = (int)this._WriterAdvisor;
				System.Reflection.MethodBase methodBase = typeof(ParamUtils).Module.ResolveMethod(metadataToken);
				System.Reflection.MethodInfo methodInfo = methodBase as System.Reflection.MethodInfo;
				System.Reflection.ParameterInfo[] parameters = methodBase.GetParameters();
				object[] array = new object[parameters.Length];
				ParamUtils.DescriptorAdvisor[] array2 = new ParamUtils.DescriptorAdvisor[parameters.Length];
				System.Collections.Generic.List<ParamUtils.ConsumerUtils> list = null;
				ParamUtils.ValUtils valUtils = null;
				for (int i = 0; i < parameters.Length; i++)
				{
					ParamUtils.DescriptorAdvisor descriptorAdvisor = this.utilsAdvisor.AssetParameter();
					System.Type type = parameters[parameters.Length - 1 - i].ParameterType;
					object obj = null;
					bool flag = false;
					if (type.IsByRef)
					{
						ParamUtils.ResolverUtils resolverUtils = descriptorAdvisor as ParamUtils.ResolverUtils;
						if (resolverUtils != null)
						{
							if (list == null)
							{
								list = new System.Collections.Generic.List<ParamUtils.ConsumerUtils>();
							}
							list.Add(new ParamUtils.ConsumerUtils(resolverUtils.adapterUtils, i));
							obj = resolverUtils.mapperUtils;
							if (obj is ParamUtils.DescriptorAdvisor)
							{
								descriptorAdvisor = (obj as ParamUtils.DescriptorAdvisor);
							}
							else
							{
								flag = true;
							}
						}
					}
					if (!flag)
					{
						if (descriptorAdvisor != null)
						{
							obj = descriptorAdvisor.RateDatabase(type);
						}
						if (obj == null)
						{
							if (type.IsByRef)
							{
								type = type.GetElementType();
							}
							if (type.IsValueType)
							{
								obj = System.Activator.CreateInstance(type);
								if (descriptorAdvisor is ParamUtils.VisitorUtils)
								{
									((ParamUtils.ProducerUtils)descriptorAdvisor).CancelPublisher(ParamUtils.DescriptorAdvisor.UpdateParameter(type, obj));
								}
							}
						}
					}
					array2[array.Length - 1 - i] = descriptorAdvisor;
					array[array.Length - 1 - i] = obj;
				}
				ParamUtils.SystemUtils systemUtils = null;
				if (list == null)
				{
					if (methodInfo != null && methodInfo.ReturnType.IsByRef)
					{
						systemUtils = ParamUtils.FactoryUtils.DestroyParameter(methodBase, isv);
					}
				}
				else
				{
					valUtils = new ParamUtils.ValUtils(methodBase, list);
					systemUtils = ParamUtils.FactoryUtils.GetParameter(methodBase, isv, valUtils);
				}
				object obj2 = null;
				if (!methodBase.IsStatic)
				{
					ParamUtils.DescriptorAdvisor descriptorAdvisor2 = this.utilsAdvisor.AssetParameter();
					if (descriptorAdvisor2 != null)
					{
						obj2 = descriptorAdvisor2.RateDatabase(methodBase.DeclaringType);
					}
					if (obj2 == null)
					{
						System.Type type2 = methodBase.DeclaringType;
						if (type2.IsByRef)
						{
							type2 = type2.GetElementType();
						}
						if (!type2.IsValueType)
						{
							throw new System.NullReferenceException();
						}
						obj2 = System.Activator.CreateInstance(type2);
						if (descriptorAdvisor2 is ParamUtils.VisitorUtils)
						{
							((ParamUtils.ProducerUtils)descriptorAdvisor2).CancelPublisher(ParamUtils.DescriptorAdvisor.UpdateParameter(type2, obj2));
						}
					}
				}
				object selection;
				if (systemUtils == null)
				{
					selection = methodBase.Invoke(obj2, array);
				}
				else
				{
					selection = systemUtils(obj2, array);
				}
				for (int j = 0; j < parameters.Length; j++)
				{
					if (parameters[j].ParameterType.IsByRef && (valUtils == null || !valUtils.CountAdvisor(j)))
					{
						if (!array2[j].InterruptParameter())
						{
							if (array2[j] is ParamUtils.VisitorUtils)
							{
								array2[j].CompareDatabase(ParamUtils.DescriptorAdvisor.UpdateParameter(parameters[j].ParameterType.GetElementType(), array[j]));
							}
							else
							{
								array2[j].CompareDatabase(ParamUtils.DescriptorAdvisor.UpdateParameter(parameters[j].ParameterType, array[j]));
							}
						}
						else
						{
							((ParamUtils.WrapperUtils)array2[j]).InsertUtils(ParamUtils.DescriptorAdvisor.UpdateParameter(parameters[j].ParameterType, array[j]));
						}
					}
				}
				if (methodInfo != null && methodInfo.ReturnType != typeof(void))
				{
					this.utilsAdvisor.PostParameter(ParamUtils.DescriptorAdvisor.UpdateParameter(methodInfo.ReturnType, selection));
				}
			}

			// Token: 0x060003BA RID: 954 RVA: 0x00014F3C File Offset: 0x0001313C
			private static ParamUtils.SystemUtils DestroyParameter(object setup, bool removevisitor)
			{
				ParamUtils.SystemUtils result = null;
				if (!removevisitor)
				{
					if (ParamUtils.FactoryUtils._ProductAdvisor.TryGetValue(setup, out result))
					{
						return result;
					}
				}
				else if (ParamUtils.FactoryUtils.m_PredicateAdvisor.TryGetValue(setup, out result))
				{
					return result;
				}
				System.Reflection.MethodInfo methodInfo = setup as System.Reflection.MethodInfo;
				System.Reflection.Emit.DynamicMethod dynamicMethod = new System.Reflection.Emit.DynamicMethod(string.Empty, typeof(object), new System.Type[]
				{
					typeof(object),
					typeof(object[])
				}, true);
				System.Reflection.Emit.ILGenerator ilgenerator = dynamicMethod.GetILGenerator();
				System.Reflection.ParameterInfo[] parameters = setup.GetParameters();
				System.Type[] array = new System.Type[parameters.Length];
				for (int i = 0; i < array.Length; i++)
				{
					if (parameters[i].ParameterType.IsByRef)
					{
						array[i] = parameters[i].ParameterType.GetElementType();
					}
					else
					{
						array[i] = parameters[i].ParameterType;
					}
				}
				int num = array.Length;
				if (setup.DeclaringType.IsValueType)
				{
					num++;
				}
				System.Reflection.Emit.LocalBuilder[] array2 = new System.Reflection.Emit.LocalBuilder[num];
				for (int j = 0; j < array.Length; j++)
				{
					array2[j] = ilgenerator.DeclareLocal(array[j]);
				}
				if (setup.DeclaringType.IsValueType)
				{
					array2[array2.Length - 1] = ilgenerator.DeclareLocal(setup.DeclaringType.MakeByRefType());
				}
				for (int k = 0; k < array.Length; k++)
				{
					ilgenerator.Emit(System.Reflection.Emit.OpCodes.Ldarg_1);
					ParamUtils.FactoryUtils.SearchParameter(ilgenerator, k);
					ilgenerator.Emit(System.Reflection.Emit.OpCodes.Ldelem_Ref);
					if (!array[k].IsValueType)
					{
						if (array[k] != typeof(object))
						{
							ilgenerator.Emit(System.Reflection.Emit.OpCodes.Castclass, array[k]);
						}
					}
					else
					{
						ilgenerator.Emit(System.Reflection.Emit.OpCodes.Unbox_Any, array[k]);
					}
					ilgenerator.Emit(System.Reflection.Emit.OpCodes.Stloc, array2[k]);
				}
				if (!setup.IsStatic)
				{
					ilgenerator.Emit(System.Reflection.Emit.OpCodes.Ldarg_0);
					if (!setup.DeclaringType.IsValueType)
					{
						ilgenerator.Emit(System.Reflection.Emit.OpCodes.Castclass, setup.DeclaringType);
					}
					else
					{
						ilgenerator.Emit(System.Reflection.Emit.OpCodes.Unbox, setup.DeclaringType);
						ilgenerator.Emit(System.Reflection.Emit.OpCodes.Stloc, array2[array2.Length - 1]);
						ilgenerator.Emit(System.Reflection.Emit.OpCodes.Ldloc_S, array2[array2.Length - 1]);
					}
				}
				for (int l = 0; l < array.Length; l++)
				{
					if (parameters[l].ParameterType.IsByRef)
					{
						ilgenerator.Emit(System.Reflection.Emit.OpCodes.Ldloca_S, array2[l]);
					}
					else
					{
						ilgenerator.Emit(System.Reflection.Emit.OpCodes.Ldloc, array2[l]);
					}
				}
				if (!removevisitor)
				{
					if (!(methodInfo != null))
					{
						ilgenerator.Emit(System.Reflection.Emit.OpCodes.Callvirt, setup as System.Reflection.ConstructorInfo);
					}
					else
					{
						ilgenerator.EmitCall(System.Reflection.Emit.OpCodes.Callvirt, methodInfo, null);
					}
				}
				else if (!(methodInfo != null))
				{
					ilgenerator.Emit(System.Reflection.Emit.OpCodes.Call, setup as System.Reflection.ConstructorInfo);
				}
				else
				{
					ilgenerator.EmitCall(System.Reflection.Emit.OpCodes.Call, methodInfo, null);
				}
				if (!(methodInfo == null) && !(methodInfo.ReturnType == typeof(void)))
				{
					if (!methodInfo.ReturnType.IsByRef)
					{
						if (methodInfo.ReturnType.IsValueType)
						{
							ilgenerator.Emit(System.Reflection.Emit.OpCodes.Box, methodInfo.ReturnType);
						}
					}
					else
					{
						System.Type elementType = methodInfo.ReturnType.GetElementType();
						if (!elementType.IsValueType)
						{
							ilgenerator.Emit(System.Reflection.Emit.OpCodes.Ldind_Ref, elementType);
						}
						else
						{
							ilgenerator.Emit(System.Reflection.Emit.OpCodes.Ldobj, elementType);
						}
						if (elementType.IsValueType)
						{
							ilgenerator.Emit(System.Reflection.Emit.OpCodes.Box, elementType);
						}
					}
				}
				else
				{
					ilgenerator.Emit(System.Reflection.Emit.OpCodes.Ldnull);
				}
				for (int m = 0; m < array.Length; m++)
				{
					if (parameters[m].ParameterType.IsByRef)
					{
						ilgenerator.Emit(System.Reflection.Emit.OpCodes.Ldarg_1);
						ParamUtils.FactoryUtils.SearchParameter(ilgenerator, m);
						ilgenerator.Emit(System.Reflection.Emit.OpCodes.Ldloc, array2[m]);
						if (array2[m].LocalType.IsValueType)
						{
							ilgenerator.Emit(System.Reflection.Emit.OpCodes.Box, array2[m].LocalType);
						}
						ilgenerator.Emit(System.Reflection.Emit.OpCodes.Stelem_Ref);
					}
				}
				ilgenerator.Emit(System.Reflection.Emit.OpCodes.Ret);
				ParamUtils.SystemUtils systemUtils = (ParamUtils.SystemUtils)dynamicMethod.CreateDelegate(typeof(ParamUtils.SystemUtils));
				if (!removevisitor)
				{
					ParamUtils.FactoryUtils._ProductAdvisor.Add(setup, systemUtils);
				}
				else
				{
					ParamUtils.FactoryUtils.m_PredicateAdvisor.Add(setup, systemUtils);
				}
				return systemUtils;
			}

			// Token: 0x060003BB RID: 955 RVA: 0x000153A0 File Offset: 0x000135A0
			private static ParamUtils.SystemUtils GetParameter(object res, bool iscaller, ParamUtils.ValUtils pool)
			{
				ParamUtils.SystemUtils result = null;
				if (!iscaller)
				{
					if (ParamUtils.FactoryUtils._RoleAdvisor.TryGetValue(pool, out result))
					{
						return result;
					}
				}
				else if (ParamUtils.FactoryUtils.m_BaseAdvisor.TryGetValue(pool, out result))
				{
					return result;
				}
				System.Reflection.MethodInfo methodInfo = res as System.Reflection.MethodInfo;
				System.Reflection.Emit.DynamicMethod dynamicMethod = new System.Reflection.Emit.DynamicMethod(string.Empty, typeof(object), new System.Type[]
				{
					typeof(object),
					typeof(object[])
				}, typeof(ParamUtils), true);
				System.Reflection.Emit.ILGenerator ilgenerator = dynamicMethod.GetILGenerator();
				System.Reflection.ParameterInfo[] parameters = res.GetParameters();
				System.Type[] array = new System.Type[parameters.Length];
				for (int i = 0; i < array.Length; i++)
				{
					if (!parameters[i].ParameterType.IsByRef)
					{
						array[i] = parameters[i].ParameterType;
					}
					else
					{
						array[i] = parameters[i].ParameterType.GetElementType();
					}
				}
				int num = array.Length;
				if (res.DeclaringType.IsValueType)
				{
					num++;
				}
				System.Reflection.Emit.LocalBuilder[] array2 = new System.Reflection.Emit.LocalBuilder[num];
				for (int j = 0; j < array.Length; j++)
				{
					if (!pool.CountAdvisor(j))
					{
						array2[j] = ilgenerator.DeclareLocal(array[j]);
					}
					else
					{
						array2[j] = ilgenerator.DeclareLocal(typeof(object));
					}
				}
				if (res.DeclaringType.IsValueType)
				{
					array2[array2.Length - 1] = ilgenerator.DeclareLocal(res.DeclaringType.MakeByRefType());
				}
				for (int k = 0; k < array.Length; k++)
				{
					ilgenerator.Emit(System.Reflection.Emit.OpCodes.Ldarg_1);
					ParamUtils.FactoryUtils.SearchParameter(ilgenerator, k);
					ilgenerator.Emit(System.Reflection.Emit.OpCodes.Ldelem_Ref);
					if (!pool.CountAdvisor(k))
					{
						if (!array[k].IsValueType)
						{
							if (array[k] != typeof(object))
							{
								ilgenerator.Emit(System.Reflection.Emit.OpCodes.Castclass, array[k]);
							}
						}
						else
						{
							ilgenerator.Emit(System.Reflection.Emit.OpCodes.Unbox_Any, array[k]);
						}
					}
					ilgenerator.Emit(System.Reflection.Emit.OpCodes.Stloc, array2[k]);
				}
				if (!res.IsStatic)
				{
					ilgenerator.Emit(System.Reflection.Emit.OpCodes.Ldarg_0);
					if (!res.DeclaringType.IsValueType)
					{
						ilgenerator.Emit(System.Reflection.Emit.OpCodes.Castclass, res.DeclaringType);
					}
					else
					{
						ilgenerator.Emit(System.Reflection.Emit.OpCodes.Unbox, res.DeclaringType);
						ilgenerator.Emit(System.Reflection.Emit.OpCodes.Stloc, array2[array2.Length - 1]);
						ilgenerator.Emit(System.Reflection.Emit.OpCodes.Ldloc_S, array2[array2.Length - 1]);
					}
				}
				for (int l = 0; l < array.Length; l++)
				{
					if (!pool.CountAdvisor(l))
					{
						if (!parameters[l].ParameterType.IsByRef)
						{
							ilgenerator.Emit(System.Reflection.Emit.OpCodes.Ldloc, array2[l]);
						}
						else
						{
							ilgenerator.Emit(System.Reflection.Emit.OpCodes.Ldloca_S, array2[l]);
						}
					}
					else
					{
						ParamUtils.ConsumerUtils consumerUtils = pool.SetAdvisor(l);
						if (consumerUtils._SpecificationUtils.IsStatic)
						{
							ilgenerator.Emit(System.Reflection.Emit.OpCodes.Ldsflda, consumerUtils._SpecificationUtils);
						}
						else if (consumerUtils._SpecificationUtils.DeclaringType.IsValueType)
						{
							ilgenerator.Emit(System.Reflection.Emit.OpCodes.Ldloc, array2[l]);
							ilgenerator.Emit(System.Reflection.Emit.OpCodes.Unbox, consumerUtils._SpecificationUtils.DeclaringType);
							ilgenerator.Emit(System.Reflection.Emit.OpCodes.Ldflda, consumerUtils._SpecificationUtils);
						}
						else
						{
							ilgenerator.Emit(System.Reflection.Emit.OpCodes.Ldloc, array2[l]);
							ilgenerator.Emit(System.Reflection.Emit.OpCodes.Castclass, consumerUtils._SpecificationUtils.DeclaringType);
							ilgenerator.Emit(System.Reflection.Emit.OpCodes.Ldflda, consumerUtils._SpecificationUtils);
						}
					}
				}
				if (!iscaller)
				{
					if (methodInfo != null)
					{
						ilgenerator.EmitCall(System.Reflection.Emit.OpCodes.Callvirt, methodInfo, null);
					}
					else
					{
						ilgenerator.Emit(System.Reflection.Emit.OpCodes.Callvirt, res as System.Reflection.ConstructorInfo);
					}
				}
				else if (methodInfo != null)
				{
					ilgenerator.EmitCall(System.Reflection.Emit.OpCodes.Call, methodInfo, null);
				}
				else
				{
					ilgenerator.Emit(System.Reflection.Emit.OpCodes.Call, res as System.Reflection.ConstructorInfo);
				}
				if (!(methodInfo == null) && !(methodInfo.ReturnType == typeof(void)))
				{
					if (methodInfo.ReturnType.IsByRef)
					{
						System.Type elementType = methodInfo.ReturnType.GetElementType();
						if (elementType.IsValueType)
						{
							ilgenerator.Emit(System.Reflection.Emit.OpCodes.Ldobj, elementType);
						}
						else
						{
							ilgenerator.Emit(System.Reflection.Emit.OpCodes.Ldind_Ref, elementType);
						}
						if (elementType.IsValueType)
						{
							ilgenerator.Emit(System.Reflection.Emit.OpCodes.Box, elementType);
						}
					}
					else if (methodInfo.ReturnType.IsValueType)
					{
						ilgenerator.Emit(System.Reflection.Emit.OpCodes.Box, methodInfo.ReturnType);
					}
				}
				else
				{
					ilgenerator.Emit(System.Reflection.Emit.OpCodes.Ldnull);
				}
				for (int m = 0; m < array.Length; m++)
				{
					if (parameters[m].ParameterType.IsByRef)
					{
						if (!pool.CountAdvisor(m))
						{
							ilgenerator.Emit(System.Reflection.Emit.OpCodes.Ldarg_1);
							ParamUtils.FactoryUtils.SearchParameter(ilgenerator, m);
							ilgenerator.Emit(System.Reflection.Emit.OpCodes.Ldloc, array2[m]);
							if (array2[m].LocalType.IsValueType)
							{
								ilgenerator.Emit(System.Reflection.Emit.OpCodes.Box, array2[m].LocalType);
							}
							ilgenerator.Emit(System.Reflection.Emit.OpCodes.Stelem_Ref);
						}
						else
						{
							ParamUtils.ConsumerUtils consumerUtils2 = pool.SetAdvisor(m);
							if (!consumerUtils2._SpecificationUtils.IsStatic)
							{
								ilgenerator.Emit(System.Reflection.Emit.OpCodes.Ldarg_1);
								ParamUtils.FactoryUtils.SearchParameter(ilgenerator, m);
								ilgenerator.Emit(System.Reflection.Emit.OpCodes.Ldloc, array2[m]);
								if (array2[m].LocalType.IsValueType)
								{
									ilgenerator.Emit(System.Reflection.Emit.OpCodes.Box, array2[m].LocalType);
								}
								ilgenerator.Emit(System.Reflection.Emit.OpCodes.Stelem_Ref);
							}
							else
							{
								ilgenerator.Emit(System.Reflection.Emit.OpCodes.Ldarg_1);
								ParamUtils.FactoryUtils.SearchParameter(ilgenerator, m);
								ilgenerator.Emit(System.Reflection.Emit.OpCodes.Ldsfld, consumerUtils2._SpecificationUtils);
								if (consumerUtils2._SpecificationUtils.FieldType.IsValueType)
								{
									ilgenerator.Emit(System.Reflection.Emit.OpCodes.Box, array2[m].LocalType);
								}
								ilgenerator.Emit(System.Reflection.Emit.OpCodes.Stelem_Ref);
							}
						}
					}
				}
				ilgenerator.Emit(System.Reflection.Emit.OpCodes.Ret);
				ParamUtils.SystemUtils systemUtils = (ParamUtils.SystemUtils)dynamicMethod.CreateDelegate(typeof(ParamUtils.SystemUtils));
				if (iscaller)
				{
					ParamUtils.FactoryUtils.m_BaseAdvisor.Add(pool, systemUtils);
				}
				else
				{
					ParamUtils.FactoryUtils._RoleAdvisor.Add(pool, systemUtils);
				}
				return systemUtils;
			}

			// Token: 0x060003BC RID: 956 RVA: 0x000159F8 File Offset: 0x00013BF8
			private static ParamUtils.SystemUtils StartParameter(object var1, bool isord, ParamUtils.ValUtils util)
			{
				ParamUtils.SystemUtils result = null;
				if (ParamUtils.FactoryUtils.clientAdvisor.TryGetValue(util, out result))
				{
					return result;
				}
				System.Reflection.ConstructorInfo constructorInfo = var1 as System.Reflection.ConstructorInfo;
				System.Reflection.Emit.DynamicMethod dynamicMethod = new System.Reflection.Emit.DynamicMethod(string.Empty, typeof(object), new System.Type[]
				{
					typeof(object),
					typeof(object[])
				}, typeof(ParamUtils), true);
				System.Reflection.Emit.ILGenerator ilgenerator = dynamicMethod.GetILGenerator();
				System.Reflection.ParameterInfo[] parameters = var1.GetParameters();
				System.Type[] array = new System.Type[parameters.Length];
				for (int i = 0; i < array.Length; i++)
				{
					if (!parameters[i].ParameterType.IsByRef)
					{
						array[i] = parameters[i].ParameterType;
					}
					else
					{
						array[i] = parameters[i].ParameterType.GetElementType();
					}
				}
				int num = array.Length;
				if (var1.DeclaringType.IsValueType)
				{
					num++;
				}
				System.Reflection.Emit.LocalBuilder[] array2 = new System.Reflection.Emit.LocalBuilder[num];
				for (int j = 0; j < array.Length; j++)
				{
					if (util.CountAdvisor(j))
					{
						array2[j] = ilgenerator.DeclareLocal(typeof(object));
					}
					else
					{
						array2[j] = ilgenerator.DeclareLocal(array[j]);
					}
				}
				if (var1.DeclaringType.IsValueType)
				{
					array2[array2.Length - 1] = ilgenerator.DeclareLocal(var1.DeclaringType.MakeByRefType());
				}
				for (int k = 0; k < array.Length; k++)
				{
					ilgenerator.Emit(System.Reflection.Emit.OpCodes.Ldarg_1);
					ParamUtils.FactoryUtils.SearchParameter(ilgenerator, k);
					ilgenerator.Emit(System.Reflection.Emit.OpCodes.Ldelem_Ref);
					if (!util.CountAdvisor(k))
					{
						if (array[k].IsValueType)
						{
							ilgenerator.Emit(System.Reflection.Emit.OpCodes.Unbox_Any, array[k]);
						}
						else if (array[k] != typeof(object))
						{
							ilgenerator.Emit(System.Reflection.Emit.OpCodes.Castclass, array[k]);
						}
					}
					ilgenerator.Emit(System.Reflection.Emit.OpCodes.Stloc, array2[k]);
				}
				for (int l = 0; l < array.Length; l++)
				{
					if (util.CountAdvisor(l))
					{
						ParamUtils.ConsumerUtils consumerUtils = util.SetAdvisor(l);
						if (!consumerUtils._SpecificationUtils.IsStatic)
						{
							if (!consumerUtils._SpecificationUtils.DeclaringType.IsValueType)
							{
								ilgenerator.Emit(System.Reflection.Emit.OpCodes.Ldloc, array2[l]);
								ilgenerator.Emit(System.Reflection.Emit.OpCodes.Castclass, consumerUtils._SpecificationUtils.DeclaringType);
								ilgenerator.Emit(System.Reflection.Emit.OpCodes.Ldflda, consumerUtils._SpecificationUtils);
							}
							else
							{
								ilgenerator.Emit(System.Reflection.Emit.OpCodes.Ldloc, array2[l]);
								ilgenerator.Emit(System.Reflection.Emit.OpCodes.Unbox, consumerUtils._SpecificationUtils.DeclaringType);
								ilgenerator.Emit(System.Reflection.Emit.OpCodes.Ldflda, consumerUtils._SpecificationUtils);
							}
						}
						else
						{
							ilgenerator.Emit(System.Reflection.Emit.OpCodes.Ldsflda, consumerUtils._SpecificationUtils);
						}
					}
					else if (parameters[l].ParameterType.IsByRef)
					{
						ilgenerator.Emit(System.Reflection.Emit.OpCodes.Ldloca_S, array2[l]);
					}
					else
					{
						ilgenerator.Emit(System.Reflection.Emit.OpCodes.Ldloc, array2[l]);
					}
				}
				ilgenerator.Emit(System.Reflection.Emit.OpCodes.Newobj, var1 as System.Reflection.ConstructorInfo);
				if (constructorInfo.DeclaringType.IsValueType)
				{
					ilgenerator.Emit(System.Reflection.Emit.OpCodes.Box, constructorInfo.DeclaringType);
				}
				for (int m = 0; m < array.Length; m++)
				{
					if (parameters[m].ParameterType.IsByRef)
					{
						if (!util.CountAdvisor(m))
						{
							ilgenerator.Emit(System.Reflection.Emit.OpCodes.Ldarg_1);
							ParamUtils.FactoryUtils.SearchParameter(ilgenerator, m);
							ilgenerator.Emit(System.Reflection.Emit.OpCodes.Ldloc, array2[m]);
							if (array2[m].LocalType.IsValueType)
							{
								ilgenerator.Emit(System.Reflection.Emit.OpCodes.Box, array2[m].LocalType);
							}
							ilgenerator.Emit(System.Reflection.Emit.OpCodes.Stelem_Ref);
						}
						else
						{
							ParamUtils.ConsumerUtils consumerUtils2 = util.SetAdvisor(m);
							if (!consumerUtils2._SpecificationUtils.IsStatic)
							{
								ilgenerator.Emit(System.Reflection.Emit.OpCodes.Ldarg_1);
								ParamUtils.FactoryUtils.SearchParameter(ilgenerator, m);
								ilgenerator.Emit(System.Reflection.Emit.OpCodes.Ldloc, array2[m]);
								if (array2[m].LocalType.IsValueType)
								{
									ilgenerator.Emit(System.Reflection.Emit.OpCodes.Box, array2[m].LocalType);
								}
								ilgenerator.Emit(System.Reflection.Emit.OpCodes.Stelem_Ref);
							}
							else
							{
								ilgenerator.Emit(System.Reflection.Emit.OpCodes.Ldarg_1);
								ParamUtils.FactoryUtils.SearchParameter(ilgenerator, m);
								ilgenerator.Emit(System.Reflection.Emit.OpCodes.Ldsfld, consumerUtils2._SpecificationUtils);
								if (consumerUtils2._SpecificationUtils.FieldType.IsValueType)
								{
									ilgenerator.Emit(System.Reflection.Emit.OpCodes.Box, array2[m].LocalType);
								}
								ilgenerator.Emit(System.Reflection.Emit.OpCodes.Stelem_Ref);
							}
						}
					}
				}
				ilgenerator.Emit(System.Reflection.Emit.OpCodes.Ret);
				ParamUtils.SystemUtils systemUtils = (ParamUtils.SystemUtils)dynamicMethod.CreateDelegate(typeof(ParamUtils.SystemUtils));
				ParamUtils.FactoryUtils.clientAdvisor.Add(util, systemUtils);
				return systemUtils;
			}

			// Token: 0x060003BD RID: 957 RVA: 0x00015EDC File Offset: 0x000140DC
			private static void SearchParameter(System.Reflection.Emit.ILGenerator key, int indexOfattr)
			{
				switch (indexOfattr)
				{
				case -1:
					key.Emit(System.Reflection.Emit.OpCodes.Ldc_I4_M1);
					return;
				case 0:
					key.Emit(System.Reflection.Emit.OpCodes.Ldc_I4_0);
					return;
				case 1:
					key.Emit(System.Reflection.Emit.OpCodes.Ldc_I4_1);
					return;
				case 2:
					key.Emit(System.Reflection.Emit.OpCodes.Ldc_I4_2);
					return;
				case 3:
					key.Emit(System.Reflection.Emit.OpCodes.Ldc_I4_3);
					return;
				case 4:
					key.Emit(System.Reflection.Emit.OpCodes.Ldc_I4_4);
					return;
				case 5:
					key.Emit(System.Reflection.Emit.OpCodes.Ldc_I4_5);
					return;
				case 6:
					key.Emit(System.Reflection.Emit.OpCodes.Ldc_I4_6);
					return;
				case 7:
					key.Emit(System.Reflection.Emit.OpCodes.Ldc_I4_7);
					return;
				case 8:
					key.Emit(System.Reflection.Emit.OpCodes.Ldc_I4_8);
					return;
				default:
					if (indexOfattr > -129 && indexOfattr < 128)
					{
						key.Emit(System.Reflection.Emit.OpCodes.Ldc_I4_S, (sbyte)indexOfattr);
						return;
					}
					key.Emit(System.Reflection.Emit.OpCodes.Ldc_I4, indexOfattr);
					return;
				}
			}

			// Token: 0x060003BE RID: 958 RVA: 0x00015FBC File Offset: 0x000141BC
			private static ParamUtils.DescriptorAdvisor PushParameter(ParamUtils.DescriptorAdvisor last)
			{
				if (last.CustomizePublisher().MoveParameter())
				{
					object obj = last.RateDatabase(null);
					if (obj != null && obj.GetType().IsEnum)
					{
						System.Type underlyingType = System.Enum.GetUnderlyingType(obj.GetType());
						object selection = System.Convert.ChangeType(obj, underlyingType);
						ParamUtils.DescriptorAdvisor descriptorAdvisor = ParamUtils.FactoryUtils.ReadParameter(ParamUtils.DescriptorAdvisor.UpdateParameter(underlyingType, selection));
						if (descriptorAdvisor != null)
						{
							return descriptorAdvisor as ParamUtils.ComparatorUtils;
						}
					}
				}
				return last;
			}

			// Token: 0x060003BF RID: 959 RVA: 0x00016028 File Offset: 0x00014228
			private static ParamUtils.ComparatorUtils ReadParameter(ParamUtils.DescriptorAdvisor config)
			{
				ParamUtils.ComparatorUtils comparatorUtils = config as ParamUtils.ComparatorUtils;
				if (comparatorUtils == null && config.OrderPublisher())
				{
					comparatorUtils = (config.CustomizePublisher() as ParamUtils.ComparatorUtils);
				}
				return comparatorUtils;
			}

			// Token: 0x060003C0 RID: 960 RVA: 0x00016058 File Offset: 0x00014258
			private static System.IntPtr ExcludeParameter(object init)
			{
				if (init == null)
				{
					return System.IntPtr.Zero;
				}
				if (init.InterruptParameter())
				{
					return ((ParamUtils.WrapperUtils)init).InstantiateUtils();
				}
				if (init.OrderPublisher())
				{
					ParamUtils.ProducerUtils producerUtils = (ParamUtils.ProducerUtils)init;
					System.IntPtr result;
					try
					{
						result = producerUtils.SortPublisher();
					}
					catch
					{
						goto IL_3E;
					}
					return result;
				}
				IL_3E:
				object obj = init.RateDatabase(typeof(System.IntPtr));
				if (obj == null || !(obj.GetType() == typeof(System.IntPtr)))
				{
					throw new ParamUtils.ExporterUtils();
				}
				return (System.IntPtr)obj;
			}

			// Token: 0x060003C1 RID: 961 RVA: 0x000160F0 File Offset: 0x000142F0
			private static object CalculateParameter(object key)
			{
				if (ParamUtils.FactoryUtils._InterpreterAdvisor == null)
				{
					ParamUtils.FactoryUtils._InterpreterAdvisor = new System.Collections.Generic.Dictionary<System.Type, ParamUtils.InstanceUtils>();
				}
				if (key != null)
				{
					object result;
					try
					{
						System.Type type = key.GetType();
						ParamUtils.InstanceUtils instanceUtils;
						if (ParamUtils.FactoryUtils._InterpreterAdvisor.TryGetValue(type, out instanceUtils))
						{
							result = instanceUtils(key);
						}
						else
						{
							System.Reflection.Emit.DynamicMethod dynamicMethod = new System.Reflection.Emit.DynamicMethod(string.Empty, typeof(object), new System.Type[]
							{
								typeof(object)
							}, true);
							System.Reflection.Emit.ILGenerator ilgenerator = dynamicMethod.GetILGenerator();
							ilgenerator.Emit(System.Reflection.Emit.OpCodes.Ldarg_0);
							ilgenerator.Emit(System.Reflection.Emit.OpCodes.Unbox_Any, type);
							ilgenerator.Emit(System.Reflection.Emit.OpCodes.Box, type);
							ilgenerator.Emit(System.Reflection.Emit.OpCodes.Ret);
							ParamUtils.InstanceUtils instanceUtils2 = (ParamUtils.InstanceUtils)dynamicMethod.CreateDelegate(typeof(ParamUtils.InstanceUtils));
							ParamUtils.FactoryUtils._InterpreterAdvisor.Add(type, instanceUtils2);
							result = instanceUtils2(key);
						}
					}
					catch
					{
						result = null;
					}
					return result;
				}
				return null;
			}

			// Token: 0x060003C2 RID: 962 RVA: 0x000161E4 File Offset: 0x000143E4
			private static void DeleteParameter(System.IntPtr setup, byte b_Z, int dic)
			{
				if (ParamUtils.FactoryUtils._ParserAdvisor == null)
				{
					System.Reflection.Emit.DynamicMethod dynamicMethod = new System.Reflection.Emit.DynamicMethod(string.Empty, typeof(void), new System.Type[]
					{
						typeof(System.IntPtr),
						typeof(byte),
						typeof(int)
					}, typeof(ParamUtils), true);
					System.Reflection.Emit.ILGenerator ilgenerator = dynamicMethod.GetILGenerator();
					ilgenerator.Emit(System.Reflection.Emit.OpCodes.Ldarg_0);
					ilgenerator.Emit(System.Reflection.Emit.OpCodes.Ldarg_1);
					ilgenerator.Emit(System.Reflection.Emit.OpCodes.Ldarg_2);
					ilgenerator.Emit(System.Reflection.Emit.OpCodes.Initblk);
					ilgenerator.Emit(System.Reflection.Emit.OpCodes.Ret);
					ParamUtils.FactoryUtils._ParserAdvisor = (ParamUtils.SchemaUtils)dynamicMethod.CreateDelegate(typeof(ParamUtils.SchemaUtils));
				}
				ParamUtils.FactoryUtils._ParserAdvisor(setup, b_Z, dic);
			}

			// Token: 0x060003C3 RID: 963 RVA: 0x000162AC File Offset: 0x000144AC
			private static void RunParameter(System.IntPtr res, System.IntPtr vis, uint row_comp)
			{
				if (ParamUtils.FactoryUtils.connectionAdvisor == null)
				{
					System.Reflection.Emit.DynamicMethod dynamicMethod = new System.Reflection.Emit.DynamicMethod(string.Empty, typeof(void), new System.Type[]
					{
						typeof(System.IntPtr),
						typeof(System.IntPtr),
						typeof(uint)
					}, typeof(ParamUtils), true);
					System.Reflection.Emit.ILGenerator ilgenerator = dynamicMethod.GetILGenerator();
					ilgenerator.Emit(System.Reflection.Emit.OpCodes.Ldarg_0);
					ilgenerator.Emit(System.Reflection.Emit.OpCodes.Ldarg_1);
					ilgenerator.Emit(System.Reflection.Emit.OpCodes.Ldarg_2);
					ilgenerator.Emit(System.Reflection.Emit.OpCodes.Cpblk);
					ilgenerator.Emit(System.Reflection.Emit.OpCodes.Ret);
					ParamUtils.FactoryUtils.connectionAdvisor = (ParamUtils.GlobalUtils)dynamicMethod.CreateDelegate(typeof(ParamUtils.GlobalUtils));
				}
				ParamUtils.FactoryUtils.connectionAdvisor(res, vis, row_comp);
			}

			// Token: 0x040000BD RID: 189
			internal ParamUtils.FacadeUtils m_GetterUtils;

			// Token: 0x040000BE RID: 190
			internal ParamUtils.DescriptorAdvisor[] m_ProcUtils = new ParamUtils.DescriptorAdvisor[0];

			// Token: 0x040000BF RID: 191
			internal ParamUtils.DescriptorAdvisor[] singletonAdvisor = new ParamUtils.DescriptorAdvisor[0];

			// Token: 0x040000C0 RID: 192
			internal ParamUtils.ExpressionAdvisor utilsAdvisor = new ParamUtils.ExpressionAdvisor();

			// Token: 0x040000C1 RID: 193
			internal ParamUtils.DescriptorAdvisor advisorAdvisor;

			// Token: 0x040000C2 RID: 194
			internal System.Exception m_RefAdvisor;

			// Token: 0x040000C3 RID: 195
			internal System.Collections.Generic.List<System.IntPtr> parameterAdvisor;

			// Token: 0x040000C4 RID: 196
			private int m_DatabaseAdvisor;

			// Token: 0x040000C5 RID: 197
			private int _PublisherAdvisor;

			// Token: 0x040000C6 RID: 198
			private int _ParamsAdvisor = -1;

			// Token: 0x040000C7 RID: 199
			private object _WriterAdvisor;

			// Token: 0x040000C8 RID: 200
			private bool _ServiceAdvisor;

			// Token: 0x040000C9 RID: 201
			private bool _AlgoAdvisor;

			// Token: 0x040000CA RID: 202
			private bool callbackAdvisor;

			// Token: 0x040000CB RID: 203
			private bool prototypeAdvisor;

			// Token: 0x040000CC RID: 204
			private static System.Collections.Generic.Dictionary<System.Type, int> authenticationAdvisor;

			// Token: 0x040000CD RID: 205
			private static System.Collections.Generic.Dictionary<object, ParamUtils.DescriptorAdvisor> m_BridgeAdvisor = new System.Collections.Generic.Dictionary<object, ParamUtils.DescriptorAdvisor>();

			// Token: 0x040000CE RID: 206
			private static System.Collections.Generic.Dictionary<System.Reflection.MethodBase, ParamUtils.SystemUtils> m_PredicateAdvisor = new System.Collections.Generic.Dictionary<System.Reflection.MethodBase, ParamUtils.SystemUtils>();

			// Token: 0x040000CF RID: 207
			private static System.Collections.Generic.Dictionary<System.Reflection.MethodBase, ParamUtils.SystemUtils> _ProductAdvisor = new System.Collections.Generic.Dictionary<System.Reflection.MethodBase, ParamUtils.SystemUtils>();

			// Token: 0x040000D0 RID: 208
			private static System.Collections.Generic.Dictionary<ParamUtils.ValUtils, ParamUtils.SystemUtils> m_BaseAdvisor = new System.Collections.Generic.Dictionary<ParamUtils.ValUtils, ParamUtils.SystemUtils>();

			// Token: 0x040000D1 RID: 209
			private static System.Collections.Generic.Dictionary<ParamUtils.ValUtils, ParamUtils.SystemUtils> _RoleAdvisor = new System.Collections.Generic.Dictionary<ParamUtils.ValUtils, ParamUtils.SystemUtils>();

			// Token: 0x040000D2 RID: 210
			private static System.Collections.Generic.Dictionary<ParamUtils.ValUtils, ParamUtils.SystemUtils> clientAdvisor = new System.Collections.Generic.Dictionary<ParamUtils.ValUtils, ParamUtils.SystemUtils>();

			// Token: 0x040000D3 RID: 211
			private static System.Collections.Generic.Dictionary<System.Type, ParamUtils.InstanceUtils> _InterpreterAdvisor;

			// Token: 0x040000D4 RID: 212
			private static ParamUtils.SchemaUtils _ParserAdvisor;

			// Token: 0x040000D5 RID: 213
			private static ParamUtils.GlobalUtils connectionAdvisor;

			// Token: 0x02000046 RID: 70
			[System.Runtime.CompilerServices.CompilerGenerated]
			[System.Serializable]
			private sealed class Class0
			{
				// Token: 0x060003C8 RID: 968 RVA: 0x000033EA File Offset: 0x000015EA
				internal int method_0(ParamUtils.ReaderUtils x, ParamUtils.ReaderUtils y)
				{
					return x.classUtils._CustomerUtils.CompareTo(y.classUtils._CustomerUtils);
				}

				// Token: 0x040000D6 RID: 214
				public static readonly ParamUtils.FactoryUtils.Class0 <>9 = new ParamUtils.FactoryUtils.Class0();

				// Token: 0x040000D7 RID: 215
				public static System.Comparison<ParamUtils.ReaderUtils> <>9__12_0;
			}
		}

		// Token: 0x02000047 RID: 71
		internal enum FDESVR : byte
		{

		}

		// Token: 0x02000048 RID: 72
		internal enum CopyOption : byte
		{

		}

		// Token: 0x02000049 RID: 73
		internal abstract class DescriptorAdvisor
		{
			// Token: 0x060003C9 RID: 969 RVA: 0x000022A1 File Offset: 0x000004A1
			public DescriptorAdvisor()
			{
			}

			// Token: 0x060003CA RID: 970 RVA: 0x00003407 File Offset: 0x00001607
			internal bool MoveParameter()
			{
				return this._ProxyAdvisor == (ParamUtils.CopyOption)0;
			}

			// Token: 0x060003CB RID: 971 RVA: 0x00003412 File Offset: 0x00001612
			internal bool ResolveParameter()
			{
				return this._ProxyAdvisor == (ParamUtils.CopyOption)1;
			}

			// Token: 0x060003CC RID: 972 RVA: 0x00016400 File Offset: 0x00014600
			internal bool InterruptParameter()
			{
				return this._ProxyAdvisor == (ParamUtils.CopyOption)3 || this._ProxyAdvisor == (ParamUtils.CopyOption)4;
			}

			// Token: 0x060003CD RID: 973 RVA: 0x0000341D File Offset: 0x0000161D
			internal bool CallParameter()
			{
				return this._ProxyAdvisor == (ParamUtils.CopyOption)2;
			}

			// Token: 0x060003CE RID: 974 RVA: 0x00003428 File Offset: 0x00001628
			internal bool FillParameter()
			{
				return this._ProxyAdvisor == (ParamUtils.CopyOption)5;
			}

			// Token: 0x060003CF RID: 975 RVA: 0x00003433 File Offset: 0x00001633
			internal bool QueryParameter()
			{
				return this._ProxyAdvisor == (ParamUtils.CopyOption)6;
			}

			// Token: 0x060003D0 RID: 976 RVA: 0x0000343E File Offset: 0x0000163E
			internal virtual bool OrderPublisher()
			{
				return false;
			}

			// Token: 0x060003D1 RID: 977 RVA: 0x0000343E File Offset: 0x0000163E
			internal virtual bool InsertPublisher()
			{
				return false;
			}

			// Token: 0x060003D2 RID: 978
			internal abstract void PrintDatabase(ParamUtils.DescriptorAdvisor v);

			// Token: 0x060003D3 RID: 979 RVA: 0x0000343E File Offset: 0x0000163E
			internal virtual bool InstantiatePublisher()
			{
				return false;
			}

			// Token: 0x060003D4 RID: 980 RVA: 0x00016424 File Offset: 0x00014624
			internal DescriptorAdvisor(ParamUtils.CopyOption asset)
			{
				this._ProxyAdvisor = asset;
			}

			// Token: 0x060003D5 RID: 981
			internal abstract object RateDatabase(System.Type v);

			// Token: 0x060003D6 RID: 982
			internal abstract bool ValidatePublisher(ParamUtils.DescriptorAdvisor spec);

			// Token: 0x060003D7 RID: 983
			internal abstract bool ResetPublisher(ParamUtils.DescriptorAdvisor config);

			// Token: 0x060003D8 RID: 984
			internal abstract bool InsertDatabase();

			// Token: 0x060003D9 RID: 985
			internal abstract ParamUtils.DescriptorAdvisor CustomizePublisher();

			// Token: 0x060003DA RID: 986 RVA: 0x0000343E File Offset: 0x0000163E
			internal virtual bool ConnectPublisher()
			{
				return false;
			}

			// Token: 0x060003DB RID: 987
			internal abstract void CompareDatabase(ParamUtils.DescriptorAdvisor def);

			// Token: 0x060003DC RID: 988 RVA: 0x00016440 File Offset: 0x00014640
			internal static ParamUtils.tagOLELINKBIND StopParameter(System.Type ident)
			{
				System.Type type = ident;
				if (!(type != null))
				{
					return (ParamUtils.tagOLELINKBIND)18;
				}
				if (type.IsByRef)
				{
					type = type.GetElementType();
				}
				if (type == typeof(string))
				{
					return (ParamUtils.tagOLELINKBIND)14;
				}
				if (type == typeof(byte))
				{
					return (ParamUtils.tagOLELINKBIND)2;
				}
				if (type == typeof(sbyte))
				{
					return (ParamUtils.tagOLELINKBIND)1;
				}
				if (type == typeof(short))
				{
					return (ParamUtils.tagOLELINKBIND)3;
				}
				if (type == typeof(ushort))
				{
					return (ParamUtils.tagOLELINKBIND)4;
				}
				if (type == typeof(int))
				{
					return (ParamUtils.tagOLELINKBIND)5;
				}
				if (type == typeof(uint))
				{
					return (ParamUtils.tagOLELINKBIND)6;
				}
				if (type == typeof(long))
				{
					return (ParamUtils.tagOLELINKBIND)7;
				}
				if (type == typeof(ulong))
				{
					return (ParamUtils.tagOLELINKBIND)8;
				}
				if (type == typeof(float))
				{
					return (ParamUtils.tagOLELINKBIND)9;
				}
				if (type == typeof(double))
				{
					return (ParamUtils.tagOLELINKBIND)10;
				}
				if (type == typeof(bool))
				{
					return (ParamUtils.tagOLELINKBIND)11;
				}
				if (type == typeof(System.IntPtr))
				{
					return (ParamUtils.tagOLELINKBIND)12;
				}
				if (type == typeof(System.UIntPtr))
				{
					return (ParamUtils.tagOLELINKBIND)13;
				}
				if (type == typeof(char))
				{
					return (ParamUtils.tagOLELINKBIND)15;
				}
				if (type == typeof(object))
				{
					return (ParamUtils.tagOLELINKBIND)0;
				}
				if (type.IsEnum)
				{
					return (ParamUtils.tagOLELINKBIND)16;
				}
				return (ParamUtils.tagOLELINKBIND)17;
			}

			// Token: 0x060003DD RID: 989 RVA: 0x000165E0 File Offset: 0x000147E0
			internal static ParamUtils.DescriptorAdvisor UpdateParameter(System.Type i, object selection)
			{
				ParamUtils.tagOLELINKBIND tagOLELINKBIND = ParamUtils.DescriptorAdvisor.StopParameter(i);
				ParamUtils.tagOLELINKBIND tagOLELINKBIND2 = (ParamUtils.tagOLELINKBIND)18;
				if (selection != null)
				{
					tagOLELINKBIND2 = ParamUtils.DescriptorAdvisor.StopParameter(selection.GetType());
				}
				ParamUtils.DescriptorAdvisor descriptorAdvisor = null;
				switch (tagOLELINKBIND)
				{
				case (ParamUtils.tagOLELINKBIND)0:
					if (tagOLELINKBIND2 == (ParamUtils.tagOLELINKBIND)15)
					{
						descriptorAdvisor = new ParamUtils.WorkerAdvisor(selection);
					}
					else
					{
						descriptorAdvisor = ParamUtils.DescriptorAdvisor.ManageParameter(selection);
					}
					break;
				case (ParamUtils.tagOLELINKBIND)1:
					if (tagOLELINKBIND2 <= (ParamUtils.tagOLELINKBIND)2)
					{
						if (tagOLELINKBIND2 == (ParamUtils.tagOLELINKBIND)1)
						{
							descriptorAdvisor = new ParamUtils.CollectionUtils((int)((sbyte)selection), (ParamUtils.ProcessUtils)1);
							break;
						}
						if (tagOLELINKBIND2 == (ParamUtils.tagOLELINKBIND)2)
						{
							descriptorAdvisor = new ParamUtils.CollectionUtils((int)((sbyte)((byte)selection)), (ParamUtils.ProcessUtils)1);
							break;
						}
					}
					else if (tagOLELINKBIND2 != (ParamUtils.tagOLELINKBIND)11)
					{
						if (tagOLELINKBIND2 == (ParamUtils.tagOLELINKBIND)15)
						{
							descriptorAdvisor = new ParamUtils.CollectionUtils((int)((sbyte)((char)selection)), (ParamUtils.ProcessUtils)1);
							break;
						}
					}
					else
					{
						if ((bool)selection)
						{
							descriptorAdvisor = new ParamUtils.CollectionUtils(1, (ParamUtils.ProcessUtils)1);
							break;
						}
						descriptorAdvisor = new ParamUtils.CollectionUtils(0, (ParamUtils.ProcessUtils)1);
						break;
					}
					throw new System.InvalidCastException();
				case (ParamUtils.tagOLELINKBIND)2:
					if (tagOLELINKBIND2 <= (ParamUtils.tagOLELINKBIND)2)
					{
						if (tagOLELINKBIND2 == (ParamUtils.tagOLELINKBIND)1)
						{
							descriptorAdvisor = new ParamUtils.CollectionUtils((int)((byte)((sbyte)selection)), (ParamUtils.ProcessUtils)2);
							break;
						}
						if (tagOLELINKBIND2 == (ParamUtils.tagOLELINKBIND)2)
						{
							descriptorAdvisor = new ParamUtils.CollectionUtils((int)((byte)selection), (ParamUtils.ProcessUtils)2);
							break;
						}
					}
					else if (tagOLELINKBIND2 != (ParamUtils.tagOLELINKBIND)11)
					{
						if (tagOLELINKBIND2 == (ParamUtils.tagOLELINKBIND)15)
						{
							descriptorAdvisor = new ParamUtils.CollectionUtils((int)((byte)((char)selection)), (ParamUtils.ProcessUtils)2);
							break;
						}
					}
					else
					{
						if ((bool)selection)
						{
							descriptorAdvisor = new ParamUtils.CollectionUtils(1, (ParamUtils.ProcessUtils)2);
							break;
						}
						descriptorAdvisor = new ParamUtils.CollectionUtils(0, (ParamUtils.ProcessUtils)2);
						break;
					}
					throw new System.InvalidCastException();
				case (ParamUtils.tagOLELINKBIND)3:
					if (tagOLELINKBIND2 != (ParamUtils.tagOLELINKBIND)3)
					{
						if (tagOLELINKBIND2 != (ParamUtils.tagOLELINKBIND)11)
						{
							if (tagOLELINKBIND2 != (ParamUtils.tagOLELINKBIND)15)
							{
								throw new System.InvalidCastException();
							}
							descriptorAdvisor = new ParamUtils.CollectionUtils((int)((short)((char)selection)), (ParamUtils.ProcessUtils)3);
						}
						else if (!(bool)selection)
						{
							descriptorAdvisor = new ParamUtils.CollectionUtils(0, (ParamUtils.ProcessUtils)3);
						}
						else
						{
							descriptorAdvisor = new ParamUtils.CollectionUtils(1, (ParamUtils.ProcessUtils)3);
						}
					}
					else
					{
						descriptorAdvisor = new ParamUtils.CollectionUtils((int)((short)selection), (ParamUtils.ProcessUtils)3);
					}
					break;
				case (ParamUtils.tagOLELINKBIND)4:
					if (tagOLELINKBIND2 != (ParamUtils.tagOLELINKBIND)4)
					{
						if (tagOLELINKBIND2 != (ParamUtils.tagOLELINKBIND)11)
						{
							if (tagOLELINKBIND2 != (ParamUtils.tagOLELINKBIND)15)
							{
								throw new System.InvalidCastException();
							}
							descriptorAdvisor = new ParamUtils.CollectionUtils((int)((char)selection), (ParamUtils.ProcessUtils)4);
						}
						else if (!(bool)selection)
						{
							descriptorAdvisor = new ParamUtils.CollectionUtils(0, (ParamUtils.ProcessUtils)4);
						}
						else
						{
							descriptorAdvisor = new ParamUtils.CollectionUtils(1, (ParamUtils.ProcessUtils)4);
						}
					}
					else
					{
						descriptorAdvisor = new ParamUtils.CollectionUtils((int)((ushort)selection), (ParamUtils.ProcessUtils)4);
					}
					break;
				case (ParamUtils.tagOLELINKBIND)5:
					if (tagOLELINKBIND2 != (ParamUtils.tagOLELINKBIND)5)
					{
						if (tagOLELINKBIND2 != (ParamUtils.tagOLELINKBIND)11)
						{
							if (tagOLELINKBIND2 != (ParamUtils.tagOLELINKBIND)15)
							{
								throw new System.InvalidCastException();
							}
							descriptorAdvisor = new ParamUtils.CollectionUtils((int)((char)selection), (ParamUtils.ProcessUtils)5);
						}
						else if (!(bool)selection)
						{
							descriptorAdvisor = new ParamUtils.CollectionUtils(0, (ParamUtils.ProcessUtils)5);
						}
						else
						{
							descriptorAdvisor = new ParamUtils.CollectionUtils(1, (ParamUtils.ProcessUtils)5);
						}
					}
					else
					{
						descriptorAdvisor = new ParamUtils.CollectionUtils((int)selection, (ParamUtils.ProcessUtils)5);
					}
					break;
				case (ParamUtils.tagOLELINKBIND)6:
					if (tagOLELINKBIND2 != (ParamUtils.tagOLELINKBIND)6)
					{
						if (tagOLELINKBIND2 != (ParamUtils.tagOLELINKBIND)11)
						{
							if (tagOLELINKBIND2 != (ParamUtils.tagOLELINKBIND)15)
							{
								throw new System.InvalidCastException();
							}
							descriptorAdvisor = new ParamUtils.CollectionUtils((uint)((char)selection), (ParamUtils.ProcessUtils)6);
						}
						else if ((bool)selection)
						{
							descriptorAdvisor = new ParamUtils.CollectionUtils(1U, (ParamUtils.ProcessUtils)6);
						}
						else
						{
							descriptorAdvisor = new ParamUtils.CollectionUtils(0U, (ParamUtils.ProcessUtils)6);
						}
					}
					else
					{
						descriptorAdvisor = new ParamUtils.CollectionUtils((uint)selection, (ParamUtils.ProcessUtils)6);
					}
					break;
				case (ParamUtils.tagOLELINKBIND)7:
					if (tagOLELINKBIND2 != (ParamUtils.tagOLELINKBIND)7)
					{
						if (tagOLELINKBIND2 != (ParamUtils.tagOLELINKBIND)11)
						{
							if (tagOLELINKBIND2 != (ParamUtils.tagOLELINKBIND)15)
							{
								throw new System.InvalidCastException();
							}
							descriptorAdvisor = new ParamUtils.ReponseUtils((long)((ulong)((char)selection)), (ParamUtils.ProcessUtils)7);
						}
						else if (!(bool)selection)
						{
							descriptorAdvisor = new ParamUtils.ReponseUtils(0L, (ParamUtils.ProcessUtils)7);
						}
						else
						{
							descriptorAdvisor = new ParamUtils.ReponseUtils(1L, (ParamUtils.ProcessUtils)7);
						}
					}
					else
					{
						descriptorAdvisor = new ParamUtils.ReponseUtils((long)selection, (ParamUtils.ProcessUtils)7);
					}
					break;
				case (ParamUtils.tagOLELINKBIND)8:
					if (tagOLELINKBIND2 != (ParamUtils.tagOLELINKBIND)8)
					{
						if (tagOLELINKBIND2 != (ParamUtils.tagOLELINKBIND)11)
						{
							if (tagOLELINKBIND2 != (ParamUtils.tagOLELINKBIND)15)
							{
								throw new System.InvalidCastException();
							}
							descriptorAdvisor = new ParamUtils.ReponseUtils((ulong)((char)selection), (ParamUtils.ProcessUtils)8);
						}
						else if (!(bool)selection)
						{
							descriptorAdvisor = new ParamUtils.ReponseUtils(0UL, (ParamUtils.ProcessUtils)8);
						}
						else
						{
							descriptorAdvisor = new ParamUtils.ReponseUtils(1UL, (ParamUtils.ProcessUtils)8);
						}
					}
					else
					{
						descriptorAdvisor = new ParamUtils.ReponseUtils((ulong)selection, (ParamUtils.ProcessUtils)8);
					}
					break;
				case (ParamUtils.tagOLELINKBIND)9:
					if (tagOLELINKBIND2 != (ParamUtils.tagOLELINKBIND)9)
					{
						throw new System.InvalidCastException();
					}
					descriptorAdvisor = new ParamUtils.CreatorUtils((float)selection);
					break;
				case (ParamUtils.tagOLELINKBIND)10:
					if (tagOLELINKBIND2 != (ParamUtils.tagOLELINKBIND)10)
					{
						throw new System.InvalidCastException();
					}
					descriptorAdvisor = new ParamUtils.CreatorUtils((double)selection);
					break;
				case (ParamUtils.tagOLELINKBIND)11:
					switch (tagOLELINKBIND2)
					{
					case (ParamUtils.tagOLELINKBIND)1:
						descriptorAdvisor = new ParamUtils.CollectionUtils((sbyte)selection != 0);
						goto IL_67D;
					case (ParamUtils.tagOLELINKBIND)2:
						descriptorAdvisor = new ParamUtils.CollectionUtils((byte)selection > 0);
						goto IL_67D;
					case (ParamUtils.tagOLELINKBIND)3:
						descriptorAdvisor = new ParamUtils.CollectionUtils((short)selection != 0);
						goto IL_67D;
					case (ParamUtils.tagOLELINKBIND)4:
						descriptorAdvisor = new ParamUtils.CollectionUtils((ushort)selection > 0);
						goto IL_67D;
					case (ParamUtils.tagOLELINKBIND)5:
						descriptorAdvisor = new ParamUtils.CollectionUtils((int)selection != 0);
						goto IL_67D;
					case (ParamUtils.tagOLELINKBIND)6:
						descriptorAdvisor = new ParamUtils.CollectionUtils((uint)selection > 0U);
						goto IL_67D;
					case (ParamUtils.tagOLELINKBIND)7:
						descriptorAdvisor = new ParamUtils.CollectionUtils((long)selection != 0L);
						goto IL_67D;
					case (ParamUtils.tagOLELINKBIND)8:
						descriptorAdvisor = new ParamUtils.CollectionUtils((ulong)selection > 0UL);
						goto IL_67D;
					case (ParamUtils.tagOLELINKBIND)9:
					case (ParamUtils.tagOLELINKBIND)10:
					case (ParamUtils.tagOLELINKBIND)12:
					case (ParamUtils.tagOLELINKBIND)13:
					case (ParamUtils.tagOLELINKBIND)14:
					case (ParamUtils.tagOLELINKBIND)15:
					case (ParamUtils.tagOLELINKBIND)16:
						throw new System.InvalidCastException();
					case (ParamUtils.tagOLELINKBIND)11:
						descriptorAdvisor = new ParamUtils.CollectionUtils((bool)selection);
						goto IL_67D;
					case (ParamUtils.tagOLELINKBIND)18:
						descriptorAdvisor = new ParamUtils.CollectionUtils(false);
						goto IL_67D;
					}
					descriptorAdvisor = new ParamUtils.CollectionUtils(selection != null);
					break;
				case (ParamUtils.tagOLELINKBIND)12:
					if (tagOLELINKBIND2 != (ParamUtils.tagOLELINKBIND)12)
					{
						throw new System.InvalidCastException();
					}
					descriptorAdvisor = new ParamUtils.WrapperUtils((System.IntPtr)selection);
					break;
				case (ParamUtils.tagOLELINKBIND)13:
					if (tagOLELINKBIND2 != (ParamUtils.tagOLELINKBIND)13)
					{
						throw new System.InvalidCastException();
					}
					descriptorAdvisor = new ParamUtils.WrapperUtils((System.UIntPtr)selection);
					break;
				case (ParamUtils.tagOLELINKBIND)14:
					descriptorAdvisor = new ParamUtils.ParamAdvisor(selection as string);
					break;
				case (ParamUtils.tagOLELINKBIND)15:
					switch (tagOLELINKBIND2)
					{
					case (ParamUtils.tagOLELINKBIND)1:
						descriptorAdvisor = new ParamUtils.CollectionUtils((int)((sbyte)selection), (ParamUtils.ProcessUtils)15);
						break;
					case (ParamUtils.tagOLELINKBIND)2:
						descriptorAdvisor = new ParamUtils.CollectionUtils((int)((byte)selection), (ParamUtils.ProcessUtils)15);
						break;
					case (ParamUtils.tagOLELINKBIND)3:
						descriptorAdvisor = new ParamUtils.CollectionUtils((int)((short)selection), (ParamUtils.ProcessUtils)15);
						break;
					case (ParamUtils.tagOLELINKBIND)4:
						descriptorAdvisor = new ParamUtils.CollectionUtils((int)((ushort)selection), (ParamUtils.ProcessUtils)15);
						break;
					case (ParamUtils.tagOLELINKBIND)5:
						descriptorAdvisor = new ParamUtils.CollectionUtils((int)selection, (ParamUtils.ProcessUtils)15);
						break;
					case (ParamUtils.tagOLELINKBIND)6:
						descriptorAdvisor = new ParamUtils.CollectionUtils((int)((uint)selection), (ParamUtils.ProcessUtils)15);
						break;
					default:
						if (tagOLELINKBIND2 != (ParamUtils.tagOLELINKBIND)15)
						{
							throw new System.InvalidCastException();
						}
						descriptorAdvisor = new ParamUtils.CollectionUtils((int)((char)selection), (ParamUtils.ProcessUtils)15);
						break;
					}
					break;
				case (ParamUtils.tagOLELINKBIND)16:
				case (ParamUtils.tagOLELINKBIND)17:
					descriptorAdvisor = ParamUtils.DescriptorAdvisor.ManageParameter(selection);
					break;
				case (ParamUtils.tagOLELINKBIND)18:
					throw new System.InvalidCastException();
				}
				IL_67D:
				if (i.IsByRef)
				{
					descriptorAdvisor = new ParamUtils.AttrUtils(descriptorAdvisor, i.GetElementType());
				}
				return descriptorAdvisor;
			}

			// Token: 0x060003DE RID: 990 RVA: 0x00016C8C File Offset: 0x00014E8C
			private static ParamUtils.DescriptorAdvisor ManageParameter(object config)
			{
				if (config != null && config.GetType().IsEnum)
				{
					System.Type underlyingType = System.Enum.GetUnderlyingType(config.GetType());
					object selection = System.Convert.ChangeType(config, underlyingType);
					ParamUtils.DescriptorAdvisor descriptorAdvisor = ParamUtils.DescriptorAdvisor.DisableParameter(ParamUtils.DescriptorAdvisor.UpdateParameter(underlyingType, selection));
					if (descriptorAdvisor != null)
					{
						return descriptorAdvisor as ParamUtils.ComparatorUtils;
					}
				}
				return new ParamUtils.WorkerAdvisor(config);
			}

			// Token: 0x060003DF RID: 991 RVA: 0x00016028 File Offset: 0x00014228
			private static ParamUtils.ComparatorUtils DisableParameter(ParamUtils.DescriptorAdvisor param)
			{
				ParamUtils.ComparatorUtils comparatorUtils = param as ParamUtils.ComparatorUtils;
				if (comparatorUtils == null && param.OrderPublisher())
				{
					comparatorUtils = (param.CustomizePublisher() as ParamUtils.ComparatorUtils);
				}
				return comparatorUtils;
			}

			// Token: 0x040000DA RID: 218
			internal ParamUtils.CopyOption _ProxyAdvisor;
		}

		// Token: 0x0200004A RID: 74
		private class WorkerAdvisor : ParamUtils.DescriptorAdvisor
		{
			// Token: 0x060003E0 RID: 992 RVA: 0x00016CE4 File Offset: 0x00014EE4
			public WorkerAdvisor() : this(null)
			{
			}

			// Token: 0x060003E1 RID: 993 RVA: 0x00016CF8 File Offset: 0x00014EF8
			internal override void CompareDatabase(ParamUtils.DescriptorAdvisor instance)
			{
				if (instance is ParamUtils.WorkerAdvisor)
				{
					this.m_ConfigAdvisor = ((ParamUtils.WorkerAdvisor)instance).m_ConfigAdvisor;
					this.m_TokenAdvisor = ((ParamUtils.WorkerAdvisor)instance).m_TokenAdvisor;
					return;
				}
				this.m_ConfigAdvisor = instance.CustomizePublisher();
			}

			// Token: 0x060003E2 RID: 994 RVA: 0x0000B390 File Offset: 0x00009590
			internal override void PrintDatabase(ParamUtils.DescriptorAdvisor init)
			{
				this.CompareDatabase(init);
			}

			// Token: 0x060003E3 RID: 995 RVA: 0x00016D3C File Offset: 0x00014F3C
			public WorkerAdvisor(object spec) : base((ParamUtils.CopyOption)0)
			{
				this.m_ConfigAdvisor = spec;
				this.m_TokenAdvisor = null;
			}

			// Token: 0x060003E4 RID: 996 RVA: 0x00016D60 File Offset: 0x00014F60
			public WorkerAdvisor(object param, System.Type connection) : base((ParamUtils.CopyOption)0)
			{
				this.m_ConfigAdvisor = param;
				this.m_TokenAdvisor = connection;
			}

			// Token: 0x060003E5 RID: 997 RVA: 0x00016D84 File Offset: 0x00014F84
			public override string ToString()
			{
				if (this.m_ConfigAdvisor == null)
				{
					return ((ParamUtils.CancellationMode)5).ToString();
				}
				return this.m_ConfigAdvisor.ToString();
			}

			// Token: 0x060003E6 RID: 998 RVA: 0x00016DB8 File Offset: 0x00014FB8
			internal override object RateDatabase(System.Type task)
			{
				if (this.m_ConfigAdvisor == null)
				{
					return null;
				}
				if (task != null && task.IsByRef)
				{
					task = task.GetElementType();
				}
				if (!(this.m_ConfigAdvisor is ParamUtils.DescriptorAdvisor))
				{
					object obj = this.m_ConfigAdvisor;
					if (obj != null && task != null && obj.GetType() != task)
					{
						if (task == typeof(System.RuntimeFieldHandle) && obj is System.Reflection.FieldInfo)
						{
							obj = ((System.Reflection.FieldInfo)obj).FieldHandle;
						}
						else if (task == typeof(System.RuntimeTypeHandle) && obj is System.Type)
						{
							obj = ((System.Type)obj).TypeHandle;
						}
						else if (task == typeof(System.RuntimeMethodHandle) && obj is System.Reflection.MethodBase)
						{
							obj = ((System.Reflection.MethodBase)obj).MethodHandle;
						}
					}
					return obj;
				}
				if (this.m_TokenAdvisor != null)
				{
					return ((ParamUtils.DescriptorAdvisor)this.m_ConfigAdvisor).RateDatabase(this.m_TokenAdvisor);
				}
				object obj2 = ((ParamUtils.DescriptorAdvisor)this.m_ConfigAdvisor).RateDatabase(task);
				if (obj2 != null && task != null && obj2.GetType() != task)
				{
					if (task == typeof(System.RuntimeFieldHandle) && obj2 is System.Reflection.FieldInfo)
					{
						obj2 = ((System.Reflection.FieldInfo)obj2).FieldHandle;
					}
					else if (task == typeof(System.RuntimeTypeHandle) && obj2 is System.Type)
					{
						obj2 = ((System.Type)obj2).TypeHandle;
					}
					else if (task == typeof(System.RuntimeMethodHandle) && obj2 is System.Reflection.MethodBase)
					{
						obj2 = ((System.Reflection.MethodBase)obj2).MethodHandle;
					}
				}
				return obj2;
			}

			// Token: 0x060003E7 RID: 999 RVA: 0x00016FA8 File Offset: 0x000151A8
			internal override bool ValidatePublisher(ParamUtils.DescriptorAdvisor reference)
			{
				if (!reference.OrderPublisher())
				{
					object obj = this.RateDatabase(null);
					object obj2 = reference.RateDatabase(null);
					return obj == obj2;
				}
				return ((ParamUtils.ProducerUtils)reference).ValidatePublisher(this);
			}

			// Token: 0x060003E8 RID: 1000 RVA: 0x00016FE0 File Offset: 0x000151E0
			internal override bool ResetPublisher(ParamUtils.DescriptorAdvisor instance)
			{
				if (instance.OrderPublisher())
				{
					return ((ParamUtils.ProducerUtils)instance).ResetPublisher(this);
				}
				object obj = this.RateDatabase(null);
				object obj2 = instance.RateDatabase(null);
				return obj != obj2;
			}

			// Token: 0x060003E9 RID: 1001 RVA: 0x0001701C File Offset: 0x0001521C
			internal override ParamUtils.DescriptorAdvisor CustomizePublisher()
			{
				ParamUtils.DescriptorAdvisor descriptorAdvisor = this.m_ConfigAdvisor as ParamUtils.DescriptorAdvisor;
				if (descriptorAdvisor == null)
				{
					return this;
				}
				return descriptorAdvisor.CustomizePublisher();
			}

			// Token: 0x060003EA RID: 1002 RVA: 0x00017044 File Offset: 0x00015244
			internal override bool InsertDatabase()
			{
				if (this.m_ConfigAdvisor == null)
				{
					return false;
				}
				ParamUtils.DescriptorAdvisor descriptorAdvisor = this.m_ConfigAdvisor as ParamUtils.DescriptorAdvisor;
				return descriptorAdvisor == null || descriptorAdvisor.RateDatabase(null) != null;
			}

			// Token: 0x040000DB RID: 219
			public ParamUtils.DescriptorAdvisor m_ConfigAdvisor;

			// Token: 0x040000DC RID: 220
			public System.Type m_TokenAdvisor;
		}

		// Token: 0x0200004B RID: 75
		private class ParamAdvisor : ParamUtils.DescriptorAdvisor
		{
			// Token: 0x060003EB RID: 1003 RVA: 0x0001707C File Offset: 0x0001527C
			public ParamAdvisor(string reference) : base((ParamUtils.CopyOption)6)
			{
				this.m_MockAdvisor = reference;
			}

			// Token: 0x060003EC RID: 1004 RVA: 0x00017098 File Offset: 0x00015298
			internal override void CompareDatabase(ParamUtils.DescriptorAdvisor asset)
			{
				this.m_MockAdvisor = ((ParamUtils.ParamAdvisor)asset).m_MockAdvisor;
			}

			// Token: 0x060003ED RID: 1005 RVA: 0x0000B390 File Offset: 0x00009590
			internal override void PrintDatabase(ParamUtils.DescriptorAdvisor value)
			{
				this.CompareDatabase(value);
			}

			// Token: 0x060003EE RID: 1006 RVA: 0x000170B8 File Offset: 0x000152B8
			public override string ToString()
			{
				if (this.m_MockAdvisor != null)
				{
					return '*'.ToString() + this.m_MockAdvisor + '*'.ToString();
				}
				return ((ParamUtils.CancellationMode)5).ToString();
			}

			// Token: 0x060003EF RID: 1007 RVA: 0x00003441 File Offset: 0x00001641
			internal override bool InsertDatabase()
			{
				return this.m_MockAdvisor != null;
			}

			// Token: 0x060003F0 RID: 1008 RVA: 0x0000344C File Offset: 0x0000164C
			internal override object RateDatabase(System.Type reference)
			{
				return this.m_MockAdvisor;
			}

			// Token: 0x060003F1 RID: 1009 RVA: 0x00017100 File Offset: 0x00015300
			internal override bool ValidatePublisher(ParamUtils.DescriptorAdvisor res)
			{
				if (!res.OrderPublisher())
				{
					object mockAdvisor = this.m_MockAdvisor;
					object obj = res.RateDatabase(null);
					return mockAdvisor == obj;
				}
				return ((ParamUtils.ProducerUtils)res).ValidatePublisher(this);
			}

			// Token: 0x060003F2 RID: 1010 RVA: 0x00017138 File Offset: 0x00015338
			internal override bool ResetPublisher(ParamUtils.DescriptorAdvisor value)
			{
				if (!value.OrderPublisher())
				{
					object mockAdvisor = this.m_MockAdvisor;
					object obj = value.RateDatabase(null);
					return mockAdvisor != obj;
				}
				return ((ParamUtils.ProducerUtils)value).ResetPublisher(this);
			}

			// Token: 0x060003F3 RID: 1011 RVA: 0x00002DB0 File Offset: 0x00000FB0
			internal override ParamUtils.DescriptorAdvisor CustomizePublisher()
			{
				return this;
			}

			// Token: 0x040000DD RID: 221
			public string m_MockAdvisor;
		}

		// Token: 0x0200004C RID: 76
		internal class ExpressionAdvisor
		{
			// Token: 0x060003F4 RID: 1012 RVA: 0x00003454 File Offset: 0x00001654
			public int method_0()
			{
				return this._HelperAdvisor.Count;
			}

			// Token: 0x060003F5 RID: 1013 RVA: 0x00017170 File Offset: 0x00015370
			public void ComputeParameter()
			{
				this._HelperAdvisor.Clear();
			}

			// Token: 0x060003F6 RID: 1014 RVA: 0x00017188 File Offset: 0x00015388
			public void PostParameter(ParamUtils.DescriptorAdvisor first)
			{
				this._HelperAdvisor.Add(first);
			}

			// Token: 0x060003F7 RID: 1015 RVA: 0x00003461 File Offset: 0x00001661
			public ParamUtils.DescriptorAdvisor LoginParameter()
			{
				return this._HelperAdvisor[this._HelperAdvisor.Count - 1];
			}

			// Token: 0x060003F8 RID: 1016 RVA: 0x0000347B File Offset: 0x0000167B
			public ParamUtils.DescriptorAdvisor AssetParameter()
			{
				ParamUtils.DescriptorAdvisor result = this.LoginParameter();
				if (this._HelperAdvisor.Count != 0)
				{
					this._HelperAdvisor.RemoveAt(this._HelperAdvisor.Count - 1);
				}
				return result;
			}

			// Token: 0x040000DE RID: 222
			private System.Collections.Generic.List<ParamUtils.DescriptorAdvisor> _HelperAdvisor = new System.Collections.Generic.List<ParamUtils.DescriptorAdvisor>();
		}

		// Token: 0x0200004D RID: 77
		internal enum CancellationMode
		{

		}

		// Token: 0x0200004E RID: 78
		[System.Runtime.CompilerServices.CompilerGenerated]
		[System.Serializable]
		private sealed class Class1<T>
		{
			// Token: 0x060003FC RID: 1020 RVA: 0x000033EA File Offset: 0x000015EA
			internal int method_0(ParamUtils.ReaderUtils x, ParamUtils.ReaderUtils y)
			{
				return x.classUtils._CustomerUtils.CompareTo(y.classUtils._CustomerUtils);
			}

			// Token: 0x060003FD RID: 1021 RVA: 0x000034B5 File Offset: 0x000016B5
			internal static bool RunObserver()
			{
				return ParamUtils.Class1<T>.AssetObserver == null;
			}

			// Token: 0x060003FE RID: 1022 RVA: 0x000034BF File Offset: 0x000016BF
			internal static object RateObserver()
			{
				return ParamUtils.Class1<T>.AssetObserver;
			}

			// Token: 0x040000E0 RID: 224
			public static readonly ParamUtils.Class1<T> <>9 = new ParamUtils.Class1<T>();

			// Token: 0x040000E1 RID: 225
			public static System.Comparison<ParamUtils.ReaderUtils> <>9__45_0;

			// Token: 0x040000E2 RID: 226
			private static object AssetObserver;
		}
	}
}
