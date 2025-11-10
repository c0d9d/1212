using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;

namespace NET.Internal
{
	// Token: 0x02000016 RID: 22
	internal class Attr
	{
		// Token: 0x060000AF RID: 175 RVA: 0x0000769C File Offset: 0x0000589C
		static Attr()
		{
			Attr.state = new uint[]
			{
				3614090360U,
				3905402710U,
				606105819U,
				3250441966U,
				4118548399U,
				1200080426U,
				2821735955U,
				4249261313U,
				1770035416U,
				2336552879U,
				4294925233U,
				2304563134U,
				1804603682U,
				4254626195U,
				2792965006U,
				1236535329U,
				4129170786U,
				3225465664U,
				643717713U,
				3921069994U,
				3593408605U,
				38016083U,
				3634488961U,
				3889429448U,
				568446438U,
				3275163606U,
				4107603335U,
				1163531501U,
				2850285829U,
				4243563512U,
				1735328473U,
				2368359562U,
				4294588738U,
				2272392833U,
				1839030562U,
				4259657740U,
				2763975236U,
				1272893353U,
				4139469664U,
				3200236656U,
				681279174U,
				3936430074U,
				3572445317U,
				76029189U,
				3654602809U,
				3873151461U,
				530742520U,
				3299628645U,
				4096336452U,
				1126891415U,
				2878612391U,
				4237533241U,
				1700485571U,
				2399980690U,
				4293915773U,
				2240044497U,
				1873313359U,
				4264355552U,
				2734768916U,
				1309151649U,
				4149444226U,
				3174756917U,
				718787259U,
				3951481745U
			};
			Attr.m_Reg = false;
			Attr.repository = false;
			Attr.@struct = null;
			Attr.m_Annotation = null;
			Attr.m_Object = new object();
			Attr.m_Tag = 0;
			Attr._Map = new object();
			Attr.reader = null;
			Attr._Stub = null;
			Attr.page = new byte[0];
			Attr._Class = new byte[0];
			Attr.queue = System.IntPtr.Zero;
			Attr.m_Customer = System.IntPtr.Zero;
			Attr._Attribute = new string[0];
			Attr.m_Task = new int[0];
			Attr.m_Iterator = 1;
			Attr.m_Facade = false;
			Attr.m_Manager = new SortedList();
			Attr.policy = 0;
			Attr._Record = 0L;
			Attr.m_Pool = null;
			Attr.consumer = null;
			Attr.specification = 0L;
			Attr.m_Merchant = 0;
			Attr._Val = false;
			Attr.m_Issuer = false;
			Attr.m_Rules = 0;
			Attr.m_System = System.IntPtr.Zero;
			Attr.m_Instance = false;
			Attr.m_Schema = new System.Collections.Hashtable();
			Attr._Global = null;
			Attr._Factory = null;
			Attr.m_Order = null;
			Attr._Getter = null;
			Attr._Proc = null;
			Attr.m_SingletonUtils = null;
			Attr.utilsUtils = System.IntPtr.Zero;
			Attr.m_AdvisorUtils = System.Text.Encoding.Unicode.GetString(new byte[]
			{
				134,
				123,
				241,
				8,
				24,
				98,
				77,
				199
			});
			try
			{
				RSACryptoServiceProvider.UseMachineKeyStore = true;
			}
			catch
			{
			}
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x00002460 File Offset: 0x00000660
		private void PushIndexer()
		{
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x00007838 File Offset: 0x00005A38
		internal static byte[] ConnectSingleton(object asset)
		{
			uint[] array = new uint[16];
			uint num = (uint)((448 - asset.Length * 8 % 512 + 512) % 512);
			if (num == 0U)
			{
				num = 512U;
			}
			uint num2 = (uint)((long)asset.Length + (long)((ulong)(num / 8U)) + 8L);
			ulong num3 = (ulong)((long)asset.Length * 8L);
			byte[] array2 = new byte[num2];
			for (int i = 0; i < asset.Length; i++)
			{
				array2[i] = asset[i];
			}
			byte[] array3 = array2;
			int num4 = asset.Length;
			array3[num4] |= 128;
			for (int j = 8; j > 0; j--)
			{
				array2[(int)(checked((System.IntPtr)(unchecked((ulong)num2 - (ulong)((long)j)))))] = (byte)(num3 >> (8 - j) * 8 & 255UL);
			}
			uint num5 = (uint)(array2.Length * 8 / 32);
			uint num6 = 1732584193U;
			uint num7 = 4023233417U;
			uint num8 = 2562383102U;
			uint num9 = 271733878U;
			for (uint num10 = 0U; num10 < num5 / 16U; num10 += 1U)
			{
				uint num11 = num10 << 6;
				for (uint num12 = 0U; num12 < 61U; num12 += 4U)
				{
					array[(int)(num12 >> 2)] = (uint)((int)array2[(int)(num11 + (num12 + 3U))] << 24 | (int)array2[(int)(num11 + (num12 + 2U))] << 16 | (int)array2[(int)(num11 + (num12 + 1U))] << 8 | (int)array2[(int)(num11 + num12)]);
				}
				uint num13 = num6;
				uint num14 = num7;
				uint num15 = num8;
				uint num16 = num9;
				Attr.ValidateSingleton(ref num6, num7, num8, num9, 0U, 7, 1U, array);
				Attr.ValidateSingleton(ref num9, num6, num7, num8, 1U, 12, 2U, array);
				Attr.ValidateSingleton(ref num8, num9, num6, num7, 2U, 17, 3U, array);
				Attr.ValidateSingleton(ref num7, num8, num9, num6, 3U, 22, 4U, array);
				Attr.ValidateSingleton(ref num6, num7, num8, num9, 4U, 7, 5U, array);
				Attr.ValidateSingleton(ref num9, num6, num7, num8, 5U, 12, 6U, array);
				Attr.ValidateSingleton(ref num8, num9, num6, num7, 6U, 17, 7U, array);
				Attr.ValidateSingleton(ref num7, num8, num9, num6, 7U, 22, 8U, array);
				Attr.ValidateSingleton(ref num6, num7, num8, num9, 8U, 7, 9U, array);
				Attr.ValidateSingleton(ref num9, num6, num7, num8, 9U, 12, 10U, array);
				Attr.ValidateSingleton(ref num8, num9, num6, num7, 10U, 17, 11U, array);
				Attr.ValidateSingleton(ref num7, num8, num9, num6, 11U, 22, 12U, array);
				Attr.ValidateSingleton(ref num6, num7, num8, num9, 12U, 7, 13U, array);
				Attr.ValidateSingleton(ref num9, num6, num7, num8, 13U, 12, 14U, array);
				Attr.ValidateSingleton(ref num8, num9, num6, num7, 14U, 17, 15U, array);
				Attr.ValidateSingleton(ref num7, num8, num9, num6, 15U, 22, 16U, array);
				Attr.ResetSingleton(ref num6, num7, num8, num9, 1U, 5, 17U, array);
				Attr.ResetSingleton(ref num9, num6, num7, num8, 6U, 9, 18U, array);
				Attr.ResetSingleton(ref num8, num9, num6, num7, 11U, 14, 19U, array);
				Attr.ResetSingleton(ref num7, num8, num9, num6, 0U, 20, 20U, array);
				Attr.ResetSingleton(ref num6, num7, num8, num9, 5U, 5, 21U, array);
				Attr.ResetSingleton(ref num9, num6, num7, num8, 10U, 9, 22U, array);
				Attr.ResetSingleton(ref num8, num9, num6, num7, 15U, 14, 23U, array);
				Attr.ResetSingleton(ref num7, num8, num9, num6, 4U, 20, 24U, array);
				Attr.ResetSingleton(ref num6, num7, num8, num9, 9U, 5, 25U, array);
				Attr.ResetSingleton(ref num9, num6, num7, num8, 14U, 9, 26U, array);
				Attr.ResetSingleton(ref num8, num9, num6, num7, 3U, 14, 27U, array);
				Attr.ResetSingleton(ref num7, num8, num9, num6, 8U, 20, 28U, array);
				Attr.ResetSingleton(ref num6, num7, num8, num9, 13U, 5, 29U, array);
				Attr.ResetSingleton(ref num9, num6, num7, num8, 2U, 9, 30U, array);
				Attr.ResetSingleton(ref num8, num9, num6, num7, 7U, 14, 31U, array);
				Attr.ResetSingleton(ref num7, num8, num9, num6, 12U, 20, 32U, array);
				Attr.CompareSingleton(ref num6, num7, num8, num9, 5U, 4, 33U, array);
				Attr.CompareSingleton(ref num9, num6, num7, num8, 8U, 11, 34U, array);
				Attr.CompareSingleton(ref num8, num9, num6, num7, 11U, 16, 35U, array);
				Attr.CompareSingleton(ref num7, num8, num9, num6, 14U, 23, 36U, array);
				Attr.CompareSingleton(ref num6, num7, num8, num9, 1U, 4, 37U, array);
				Attr.CompareSingleton(ref num9, num6, num7, num8, 4U, 11, 38U, array);
				Attr.CompareSingleton(ref num8, num9, num6, num7, 7U, 16, 39U, array);
				Attr.CompareSingleton(ref num7, num8, num9, num6, 10U, 23, 40U, array);
				Attr.CompareSingleton(ref num6, num7, num8, num9, 13U, 4, 41U, array);
				Attr.CompareSingleton(ref num9, num6, num7, num8, 0U, 11, 42U, array);
				Attr.CompareSingleton(ref num8, num9, num6, num7, 3U, 16, 43U, array);
				Attr.CompareSingleton(ref num7, num8, num9, num6, 6U, 23, 44U, array);
				Attr.CompareSingleton(ref num6, num7, num8, num9, 9U, 4, 45U, array);
				Attr.CompareSingleton(ref num9, num6, num7, num8, 12U, 11, 46U, array);
				Attr.CompareSingleton(ref num8, num9, num6, num7, 15U, 16, 47U, array);
				Attr.CompareSingleton(ref num7, num8, num9, num6, 2U, 23, 48U, array);
				Attr.PrintSingleton(ref num6, num7, num8, num9, 0U, 6, 49U, array);
				Attr.PrintSingleton(ref num9, num6, num7, num8, 7U, 10, 50U, array);
				Attr.PrintSingleton(ref num8, num9, num6, num7, 14U, 15, 51U, array);
				Attr.PrintSingleton(ref num7, num8, num9, num6, 5U, 21, 52U, array);
				Attr.PrintSingleton(ref num6, num7, num8, num9, 12U, 6, 53U, array);
				Attr.PrintSingleton(ref num9, num6, num7, num8, 3U, 10, 54U, array);
				Attr.PrintSingleton(ref num8, num9, num6, num7, 10U, 15, 55U, array);
				Attr.PrintSingleton(ref num7, num8, num9, num6, 1U, 21, 56U, array);
				Attr.PrintSingleton(ref num6, num7, num8, num9, 8U, 6, 57U, array);
				Attr.PrintSingleton(ref num9, num6, num7, num8, 15U, 10, 58U, array);
				Attr.PrintSingleton(ref num8, num9, num6, num7, 6U, 15, 59U, array);
				Attr.PrintSingleton(ref num7, num8, num9, num6, 13U, 21, 60U, array);
				Attr.PrintSingleton(ref num6, num7, num8, num9, 4U, 6, 61U, array);
				Attr.PrintSingleton(ref num9, num6, num7, num8, 11U, 10, 62U, array);
				Attr.PrintSingleton(ref num8, num9, num6, num7, 2U, 15, 63U, array);
				Attr.PrintSingleton(ref num7, num8, num9, num6, 9U, 21, 64U, array);
				num6 += num13;
				num7 += num14;
				num8 += num15;
				num9 += num16;
			}
			byte[] array4 = new byte[16];
			System.Array.Copy(System.BitConverter.GetBytes(num6), 0, array4, 0, 4);
			System.Array.Copy(System.BitConverter.GetBytes(num7), 0, array4, 4, 4);
			System.Array.Copy(System.BitConverter.GetBytes(num8), 0, array4, 8, 4);
			System.Array.Copy(System.BitConverter.GetBytes(num9), 0, array4, 12, 4);
			return array4;
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x00002462 File Offset: 0x00000662
		private static void ValidateSingleton(ref uint ident, uint attr_length, uint endutil, uint uint_0, uint offset_asset3, ushort positionmap4, uint sum_param5, object first6)
		{
			ident = attr_length + Attr.PrepareSingleton(ident + ((attr_length & endutil) | (~attr_length & uint_0)) + first6[(int)offset_asset3] + Attr.state[(int)(sum_param5 - 1U)], positionmap4);
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x0000248B File Offset: 0x0000068B
		private static void ResetSingleton(ref uint asset, uint flagsb, uint offset_serv, uint indexOf_setup2, uint rowpol3, ushort result4_min, uint column_cfg5, object instance6)
		{
			asset = flagsb + Attr.PrepareSingleton(asset + ((flagsb & indexOf_setup2) | (offset_serv & ~indexOf_setup2)) + instance6[(int)rowpol3] + Attr.state[(int)(column_cfg5 - 1U)], result4_min);
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x000024B4 File Offset: 0x000006B4
		private static void CompareSingleton(ref uint last, uint b_offset, uint dic_ID, uint pol2Ptr, uint no_config3, ushort first4_end, uint cust5Z, object col6)
		{
			last = b_offset + Attr.PrepareSingleton(last + (b_offset ^ dic_ID ^ pol2Ptr) + col6[(int)no_config3] + Attr.state[(int)(cust5Z - 1U)], first4_end);
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x000024DA File Offset: 0x000006DA
		private static void PrintSingleton(ref uint last, uint positionord, uint end_consumer, uint ident2_size, uint idx_task3, ushort reg4_end, uint insert_IVK5At, object ident6)
		{
			last = positionord + Attr.PrepareSingleton(last + (end_consumer ^ (positionord | ~ident2_size)) + ident6[(int)idx_task3] + Attr.state[(int)(insert_IVK5At - 1U)], reg4_end);
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x00002501 File Offset: 0x00000701
		private static uint PrepareSingleton(uint spec_start, ushort token_counter)
		{
			return spec_start >> (int)(32 - token_counter) | spec_start << (int)token_counter;
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x00002513 File Offset: 0x00000713
		internal static bool LogoutSingleton()
		{
			if (!Attr.m_Reg)
			{
				Attr.RateSingleton();
				Attr.m_Reg = true;
			}
			return Attr.repository;
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x000022A1 File Offset: 0x000004A1
		internal Attr()
		{
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x00007E98 File Offset: 0x00006098
		private void FindSingleton(byte[] first, byte[] second, byte[] c)
		{
			int num = c.Length % 4;
			int num2 = c.Length / 4;
			byte[] array = new byte[c.Length];
			int num3 = first.Length / 4;
			uint num4 = 0U;
			if (num > 0)
			{
				num2++;
			}
			for (int i = 0; i < num2; i++)
			{
				int num5 = i % num3;
				int num6 = i * 4;
				uint num7 = (uint)(num5 * 4);
				uint num8 = (uint)((int)first[(int)(num7 + 3U)] << 24 | (int)first[(int)(num7 + 2U)] << 16 | (int)first[(int)(num7 + 1U)] << 8 | (int)first[(int)num7]);
				uint num9 = 255U;
				int num10 = 0;
				uint num11;
				if (i == num2 - 1 && num > 0)
				{
					num11 = 0U;
					num4 += num8;
					for (int j = 0; j < num; j++)
					{
						if (j > 0)
						{
							num11 <<= 8;
						}
						num11 |= (uint)c[c.Length - (1 + j)];
					}
				}
				else
				{
					num4 += num8;
					num7 = (uint)num6;
					num11 = (uint)((int)c[(int)(num7 + 3U)] << 24 | (int)c[(int)(num7 + 2U)] << 16 | (int)c[(int)(num7 + 1U)] << 8 | (int)c[(int)num7]);
				}
				uint num13;
				uint num12 = num13 = num4;
				num13 ^= num13 >> 11;
				num13 += 4004818658U;
				num13 ^= num13 >> 13;
				num13 += 1097289544U;
				num13 ^= num13 << 21;
				num13 += 860667823U;
				num13 = 1242666699U + num13;
				num4 = num12 + (uint)num13;
				if (i == num2 - 1 && num > 0)
				{
					uint num14 = num4 ^ num11;
					for (int k = 0; k < num; k++)
					{
						if (k > 0)
						{
							num9 <<= 8;
							num10 += 8;
						}
						array[num6 + k] = (byte)((num14 & num9) >> num10);
					}
				}
				else
				{
					uint num15 = num4 ^ num11;
					array[num6] = (byte)(num15 & 255U);
					array[num6 + 1] = (byte)((num15 & 65280U) >> 8);
					array[num6 + 2] = (byte)((num15 & 16711680U) >> 16);
					array[num6 + 3] = (byte)((num15 & 4278190080U) >> 24);
				}
			}
			Attr.page = array;
		}

		// Token: 0x060000BA RID: 186 RVA: 0x000080AC File Offset: 0x000062AC
		internal static SymmetricAlgorithm TestSingleton()
		{
			SymmetricAlgorithm result = null;
			if (Attr.LogoutSingleton())
			{
				result = new AesCryptoServiceProvider();
			}
			else
			{
				try
				{
					result = new RijndaelManaged();
				}
				catch
				{
					result = (SymmetricAlgorithm)System.Activator.CreateInstance("System.Core, Version=3.5.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089", "System.Security.Cryptography.AesCryptoServiceProvider").Unwrap();
				}
			}
			return result;
		}

		// Token: 0x060000BB RID: 187 RVA: 0x00008104 File Offset: 0x00006304
		internal static void RateSingleton()
		{
			try
			{
				Attr.repository = CryptoConfig.AllowOnlyFipsAlgorithms;
			}
			catch
			{
			}
		}

		// Token: 0x060000BC RID: 188 RVA: 0x0000252C File Offset: 0x0000072C
		internal static byte[] RestartSingleton(byte[] first)
		{
			if (!Attr.LogoutSingleton())
			{
				return new MD5CryptoServiceProvider().ComputeHash(first);
			}
			return Attr.ConnectSingleton(first);
		}

		// Token: 0x060000BD RID: 189 RVA: 0x00008130 File Offset: 0x00006330
		internal static void InsertSingleton(HashAlgorithm value, System.IO.Stream selection, uint filterZ, byte[] reg2)
		{
			while (filterZ > 0U)
			{
				int num = (filterZ > (uint)reg2.Length) ? reg2.Length : ((int)filterZ);
				selection.Read(reg2, 0, num);
				Attr.InstantiateSingleton(value, reg2, 0, num);
				filterZ -= (uint)num;
			}
		}

		// Token: 0x060000BE RID: 190 RVA: 0x00002547 File Offset: 0x00000747
		internal static void InstantiateSingleton(HashAlgorithm instance, byte[] caller, int controlPosition, int num_t2)
		{
			instance.TransformBlock(caller, controlPosition, num_t2, caller, controlPosition);
		}

		// Token: 0x060000BF RID: 191 RVA: 0x0000816C File Offset: 0x0000636C
		internal static uint OrderSingleton(uint res_amount, int max_token, long indexOf_state, System.IO.BinaryReader instance2)
		{
			for (int i = 0; i < max_token; i++)
			{
				instance2.BaseStream.Position = indexOf_state + (long)(i * 40 + 8);
				uint num = instance2.ReadUInt32();
				uint num2 = instance2.ReadUInt32();
				instance2.ReadUInt32();
				uint num3 = instance2.ReadUInt32();
				if (num2 <= res_amount && res_amount < num2 + num)
				{
					return num3 + res_amount - num2;
				}
			}
			return 0U;
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x000081C8 File Offset: 0x000063C8
		private static void ViewSingleton(object first, int attr)
		{
			ParamUtils.CustomizeUtils(0, new object[]
			{
				first,
				attr
			}, null);
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x00008208 File Offset: 0x00006408
		internal static string PublishUtils(string ident)
		{
			"{11111-22222-50001-00000}".Trim();
			byte[] array = System.Convert.FromBase64String(ident);
			return System.Text.Encoding.Unicode.GetString(array, 0, array.Length);
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x00008238 File Offset: 0x00006438
		internal static uint SetupUtils(System.IntPtr v, System.IntPtr cont, System.IntPtr role, [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.U4)] uint counter2_ID, System.IntPtr key3, ref uint connection4)
		{
			System.IntPtr ptr = role;
			if (Attr.m_Field)
			{
				ptr = cont;
			}
			long num;
			if (System.IntPtr.Size == 4)
			{
				num = (long)System.Runtime.InteropServices.Marshal.ReadInt32(ptr, System.IntPtr.Size * 2);
			}
			else
			{
				num = System.Runtime.InteropServices.Marshal.ReadInt64(ptr, System.IntPtr.Size * 2);
			}
			object obj = Attr.m_Schema[num];
			if (obj == null)
			{
				return Attr.m_Pool(v, cont, role, counter2_ID, key3, ref connection4);
			}
			Attr.ServiceUtils serviceUtils = (Attr.ServiceUtils)obj;
			System.IntPtr intPtr = System.Runtime.InteropServices.Marshal.AllocCoTaskMem(serviceUtils.m_CallbackUtils.Length);
			System.Runtime.InteropServices.Marshal.Copy(serviceUtils.m_CallbackUtils, 0, intPtr, serviceUtils.m_CallbackUtils.Length);
			if (serviceUtils.algoUtils)
			{
				key3 = intPtr;
				connection4 = (uint)serviceUtils.m_CallbackUtils.Length;
				Attr.IncludeUtils(key3, serviceUtils.m_CallbackUtils.Length, 64, ref Attr.m_Rules);
				return 0U;
			}
			System.Runtime.InteropServices.Marshal.WriteIntPtr(ptr, System.IntPtr.Size * 2, intPtr);
			System.Runtime.InteropServices.Marshal.WriteInt32(ptr, System.IntPtr.Size * 3, serviceUtils.m_CallbackUtils.Length);
			uint result = 0U;
			if (counter2_ID == 216669565U && !Attr.m_Instance)
			{
				Attr.m_Instance = true;
			}
			else
			{
				result = Attr.m_Pool(v, cont, role, counter2_ID, key3, ref connection4);
			}
			return result;
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x00002555 File Offset: 0x00000755
		private static int SetUtils()
		{
			return 5;
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x0000835C File Offset: 0x0000655C
		private static void CountUtils()
		{
			try
			{
				RSACryptoServiceProvider.UseMachineKeyStore = true;
			}
			catch
			{
			}
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x00008384 File Offset: 0x00006584
		private static System.Delegate ReflectUtils(System.IntPtr init, System.Type vis)
		{
			return (System.Delegate)typeof(System.Runtime.InteropServices.Marshal).GetMethod("GetDelegateForFunctionPointer", new System.Type[]
			{
				typeof(System.IntPtr),
				typeof(System.Type)
			}).Invoke(null, new object[]
			{
				init,
				vis
			});
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x000083E4 File Offset: 0x000065E4
		internal unsafe static void WriteUtils()
		{
			if (!Attr.m_Facade)
			{
				Attr.m_Facade = true;
				long num = 0L;
				System.Runtime.InteropServices.Marshal.ReadIntPtr(new System.IntPtr((void*)(&num)), 0);
				System.Runtime.InteropServices.Marshal.ReadInt32(new System.IntPtr((void*)(&num)), 0);
				System.Runtime.InteropServices.Marshal.ReadInt64(new System.IntPtr((void*)(&num)), 0);
				System.Runtime.InteropServices.Marshal.WriteIntPtr(new System.IntPtr((void*)(&num)), 0, System.IntPtr.Zero);
				System.Runtime.InteropServices.Marshal.WriteInt32(new System.IntPtr((void*)(&num)), 0, 0);
				System.Runtime.InteropServices.Marshal.WriteInt64(new System.IntPtr((void*)(&num)), 0, 0L);
				System.Runtime.InteropServices.Marshal.Copy(new byte[1], 0, System.Runtime.InteropServices.Marshal.AllocCoTaskMem(8), 1);
				Attr.CountUtils();
				if (System.IntPtr.Size == 4 && System.Type.GetType("System.Reflection.ReflectionContext", false) != null)
				{
					foreach (object obj in Process.GetCurrentProcess().Modules)
					{
						ProcessModule processModule = (ProcessModule)obj;
						if (processModule.ModuleName.ToLower() == "clrjit.dll")
						{
							System.Version v = new System.Version(processModule.FileVersionInfo.ProductMajorPart, processModule.FileVersionInfo.ProductMinorPart, processModule.FileVersionInfo.ProductBuildPart, processModule.FileVersionInfo.ProductPrivatePart);
							System.Version v2 = new System.Version(4, 0, 30319, 17020);
							System.Version v3 = new System.Version(4, 0, 30319, 17921);
							if (v >= v2 && v < v3)
							{
								Attr.m_Field = true;
								break;
							}
						}
					}
				}
				Attr.PrototypeUtils prototypeUtils = new Attr.PrototypeUtils(Attr.rule.GetManifestResourceStream("Configuration.Exception"));
				prototypeUtils.method_0().Position = 0L;
				byte[] array = prototypeUtils.ExcludeUtils((int)prototypeUtils.method_0().Length);
				byte[] array2 = new byte[32];
				array2[0] = 158;
				array2[0] = 28;
				array2[0] = 194;
				array2[0] = 173;
				array2[1] = 86;
				array2[1] = 151;
				array2[1] = 134;
				array2[1] = 138;
				array2[1] = 148;
				array2[1] = 50;
				array2[2] = 166;
				array2[2] = 113;
				array2[2] = 97;
				array2[2] = 169;
				array2[2] = 157;
				array2[2] = 185;
				array2[3] = 92;
				array2[3] = 98;
				array2[3] = 100;
				array2[3] = 124;
				array2[3] = 145;
				array2[3] = 43;
				array2[4] = 147;
				array2[4] = 87;
				array2[4] = 48;
				array2[4] = 130;
				array2[4] = 188;
				array2[5] = 187;
				array2[5] = 90;
				array2[5] = 173;
				array2[6] = 122;
				array2[6] = 170;
				array2[6] = 188;
				array2[6] = 34;
				array2[7] = 201;
				array2[7] = 107;
				array2[7] = 115;
				array2[7] = 143;
				array2[7] = 107;
				array2[7] = 14;
				array2[8] = 148;
				array2[8] = 152;
				array2[8] = 127;
				array2[9] = 67;
				array2[9] = 72;
				array2[9] = 119;
				array2[9] = 162;
				array2[9] = 131;
				array2[9] = 97;
				array2[10] = 124;
				array2[10] = 162;
				array2[10] = 152;
				array2[10] = 159;
				array2[11] = 75;
				array2[11] = 30;
				array2[11] = 138;
				array2[11] = 55;
				array2[11] = 219;
				array2[12] = 148;
				array2[12] = 77;
				array2[12] = 48;
				array2[13] = 198;
				array2[13] = 107;
				array2[13] = 72;
				array2[13] = 84;
				array2[13] = 134;
				array2[13] = 181;
				array2[14] = 58;
				array2[14] = 81;
				array2[14] = 72;
				array2[14] = 155;
				array2[14] = 164;
				array2[14] = 172;
				array2[15] = 89;
				array2[15] = 152;
				array2[15] = 136;
				array2[15] = 86;
				array2[15] = 196;
				array2[16] = 119;
				array2[16] = 141;
				array2[16] = 170;
				array2[16] = 95;
				array2[16] = 233;
				array2[17] = 147;
				array2[17] = 177;
				array2[17] = 48;
				array2[17] = 113;
				array2[17] = 115;
				array2[17] = 25;
				array2[18] = 56;
				array2[18] = 84;
				array2[18] = 160;
				array2[18] = 141;
				array2[18] = 129;
				array2[18] = 253;
				array2[19] = 108;
				array2[19] = 151;
				array2[19] = 90;
				array2[19] = 127;
				array2[19] = 93;
				array2[20] = 154;
				array2[20] = 111;
				array2[20] = 48;
				array2[20] = 117;
				array2[21] = 157;
				array2[21] = 153;
				array2[21] = 130;
				array2[21] = 141;
				array2[21] = 15;
				array2[22] = 101;
				array2[22] = 99;
				array2[22] = 108;
				array2[23] = 198;
				array2[23] = 156;
				array2[23] = 120;
				array2[23] = 190;
				array2[24] = 154;
				array2[24] = 107;
				array2[24] = 160;
				array2[24] = 217;
				array2[25] = 93;
				array2[25] = 86;
				array2[25] = 88;
				array2[25] = 190;
				array2[25] = 135;
				array2[25] = 179;
				array2[26] = 132;
				array2[26] = 58;
				array2[26] = 122;
				array2[26] = 135;
				array2[27] = 118;
				array2[27] = 222;
				array2[27] = 164;
				array2[28] = 188;
				array2[28] = 134;
				array2[28] = 174;
				array2[29] = 87;
				array2[29] = 194;
				array2[29] = 134;
				array2[29] = 227;
				array2[30] = 211;
				array2[30] = 113;
				array2[30] = 176;
				array2[30] = 200;
				array2[31] = 84;
				array2[31] = 107;
				array2[31] = 149;
				array2[31] = 203;
				byte[] array3 = array2;
				byte[] array4 = new byte[16];
				array4[0] = 158;
				array4[0] = 28;
				array4[0] = 162;
				array4[1] = 170;
				array4[1] = 136;
				array4[1] = 17;
				array4[2] = 120;
				array4[2] = 154;
				array4[2] = 60;
				array4[3] = 133;
				array4[3] = 168;
				array4[3] = 150;
				array4[3] = 60;
				array4[4] = 113;
				array4[4] = 140;
				array4[4] = 77;
				array4[5] = 190;
				array4[5] = 92;
				array4[5] = 98;
				array4[5] = 126;
				array4[5] = 110;
				array4[5] = 42;
				array4[6] = 150;
				array4[6] = 76;
				array4[6] = 166;
				array4[6] = 62;
				array4[7] = 119;
				array4[7] = 93;
				array4[7] = 155;
				array4[7] = 167;
				array4[7] = 90;
				array4[7] = 233;
				array4[8] = 115;
				array4[8] = 243;
				array4[8] = 168;
				array4[8] = 93;
				array4[8] = 165;
				array4[8] = 97;
				array4[9] = 131;
				array4[9] = 128;
				array4[9] = 198;
				array4[9] = 151;
				array4[9] = 133;
				array4[9] = 4;
				array4[10] = 164;
				array4[10] = 121;
				array4[10] = 15;
				array4[11] = 108;
				array4[11] = 119;
				array4[11] = 130;
				array4[11] = 144;
				array4[11] = 125;
				array4[11] = 43;
				array4[12] = 168;
				array4[12] = 93;
				array4[12] = 107;
				array4[12] = 30;
				array4[12] = 138;
				array4[12] = 21;
				array4[13] = 160;
				array4[13] = 111;
				array4[13] = 107;
				array4[14] = 134;
				array4[14] = 154;
				array4[14] = 59;
				array4[15] = 149;
				array4[15] = 158;
				array4[15] = 77;
				array4[15] = 191;
				byte[] array5 = array4;
				System.Array.Reverse(array5);
				byte[] publicKeyToken = Attr.rule.GetName().GetPublicKeyToken();
				if (publicKeyToken != null && publicKeyToken.Length != 0)
				{
					array5[1] = publicKeyToken[0];
					array5[3] = publicKeyToken[1];
					array5[5] = publicKeyToken[2];
					array5[7] = publicKeyToken[3];
					array5[9] = publicKeyToken[4];
					array5[11] = publicKeyToken[5];
					array5[13] = publicKeyToken[6];
					array5[15] = publicKeyToken[7];
					System.Array.Clear(publicKeyToken, 0, publicKeyToken.Length);
				}
				for (int i = 0; i < array5.Length; i++)
				{
					array3[i] ^= array5[i];
				}
				byte[] array6 = array;
				int num2 = array6.Length % 4;
				int num3 = array6.Length / 4;
				byte[] array7 = new byte[array6.Length];
				int num4 = array3.Length / 4;
				uint num5 = 0U;
				if (num2 > 0)
				{
					num3++;
				}
				for (int j = 0; j < num3; j++)
				{
					int num6 = j % num4;
					int num7 = j * 4;
					uint num8 = (uint)(num6 * 4);
					uint num9 = (uint)((int)array3[(int)(num8 + 3U)] << 24 | (int)array3[(int)(num8 + 2U)] << 16 | (int)array3[(int)(num8 + 1U)] << 8 | (int)array3[(int)num8]);
					uint num10 = 255U;
					int num11 = 0;
					uint num12;
					if (j == num3 - 1 && num2 > 0)
					{
						num5 += num9;
						num12 = 0U;
						for (int k = 0; k < num2; k++)
						{
							if (k > 0)
							{
								num12 <<= 8;
							}
							num12 |= (uint)array6[array6.Length - (1 + k)];
						}
					}
					else
					{
						num8 = (uint)num7;
						num5 += num9;
						num12 = (uint)((int)array6[(int)(num8 + 3U)] << 24 | (int)array6[(int)(num8 + 2U)] << 16 | (int)array6[(int)(num8 + 1U)] << 8 | (int)array6[(int)num8]);
					}
					num5 = num5;
					uint num13 = num5;
					uint num14 = num5;
					num14 ^= num14 >> 11;
					num14 += 4004818658U;
					num14 ^= num14 >> 13;
					num14 += 1097289544U;
					num14 ^= num14 << 21;
					num14 += 860667823U;
					num14 = 1242666699U + num14;
					num5 = num13 + (uint)num14;
					if (j == num3 - 1 && num2 > 0)
					{
						uint num15 = num5 ^ num12;
						for (int l = 0; l < num2; l++)
						{
							if (l > 0)
							{
								num10 <<= 8;
								num11 += 8;
							}
							array7[num7 + l] = (byte)((num15 & num10) >> num11);
						}
					}
					else
					{
						uint num16 = num5 ^ num12;
						array7[num7] = (byte)(num16 & 255U);
						array7[num7 + 1] = (byte)((num16 & 65280U) >> 8);
						array7[num7 + 2] = (byte)((num16 & 16711680U) >> 16);
						array7[num7 + 3] = (byte)((num16 & 4278190080U) >> 24);
					}
				}
				byte[] array8 = array7;
				int num17 = array8.Length / 8;
				byte[] array9;
				byte* ptr;
				if ((array9 = array8) != null && array9.Length != 0)
				{
					ptr = &array9[0];
				}
				else
				{
					ptr = null;
				}
				for (int m = 0; m < num17; m++)
				{
					*(long*)(ptr + m * 8) ^= 1067191516L;
				}
				array9 = null;
				prototypeUtils = new Attr.PrototypeUtils(new System.IO.MemoryStream(array8));
				prototypeUtils.method_0().Position = 0L;
				long num18 = System.Runtime.InteropServices.Marshal.GetHINSTANCE(Attr.rule.GetModules()[0]).ToInt64();
				int offset_third = 0;
				int num19 = 0;
				if (Attr.rule.Location == null || Attr.rule.Location.Length == 0)
				{
					num19 = 7680;
				}
				prototypeUtils.DeleteUtils();
				prototypeUtils.DeleteUtils();
				int num20 = prototypeUtils.DeleteUtils();
				int num21 = prototypeUtils.DeleteUtils();
				if (num21 == 4)
				{
					SymmetricAlgorithm symmetricAlgorithm = Attr.TestSingleton();
					symmetricAlgorithm.Mode = CipherMode.CBC;
					ICryptoTransform transform = symmetricAlgorithm.CreateDecryptor(array3, array5);
					System.Array.Clear(array3, 0, array3.Length);
					System.IO.MemoryStream memoryStream = new System.IO.MemoryStream();
					CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write);
					cryptoStream.Write(array, 0, array.Length);
					cryptoStream.FlushFinalBlock();
					array8 = memoryStream.ToArray();
					System.Array.Clear(array5, 0, array5.Length);
					memoryStream.Close();
					cryptoStream.Close();
					prototypeUtils.RunUtils();
					num20 = prototypeUtils.DeleteUtils();
					num21 = prototypeUtils.DeleteUtils();
				}
				if (num21 == 1)
				{
					System.IntPtr intPtr = System.IntPtr.Zero;
					intPtr = Attr.CreateUtils(56U, 1, (uint)Process.GetCurrentProcess().Id);
					if (System.IntPtr.Size == 4)
					{
						Attr.policy = System.Runtime.InteropServices.Marshal.GetHINSTANCE(Attr.rule.GetModules()[0]).ToInt32();
					}
					Attr._Record = System.Runtime.InteropServices.Marshal.GetHINSTANCE(Attr.rule.GetModules()[0]).ToInt64();
					System.IntPtr zero = System.IntPtr.Zero;
					for (int n = 0; n < num20; n++)
					{
						System.IntPtr intPtr2 = new System.IntPtr(Attr._Record + (long)prototypeUtils.DeleteUtils() - (long)num19);
						if (Attr.IncludeUtils(intPtr2, 4, 4, ref offset_third) == 0)
						{
							Attr.IncludeUtils(intPtr2, 4, 8, ref offset_third);
						}
						if (System.IntPtr.Size == 4)
						{
							Attr.ListUtils(intPtr, intPtr2, System.BitConverter.GetBytes(prototypeUtils.DeleteUtils()), 4U, out zero);
						}
						else
						{
							Attr.ListUtils(intPtr, intPtr2, System.BitConverter.GetBytes(prototypeUtils.DeleteUtils()), 4U, out zero);
						}
						Attr.IncludeUtils(intPtr2, 4, offset_third, ref offset_third);
					}
					while (prototypeUtils.method_0().Position < prototypeUtils.method_0().Length - 1L)
					{
						int num22 = prototypeUtils.DeleteUtils();
						System.IntPtr config = new System.IntPtr(Attr._Record + (long)num22 - (long)num19);
						int num23 = prototypeUtils.DeleteUtils();
						if (Attr.IncludeUtils(config, num23 * 4, 4, ref offset_third) == 0)
						{
							Attr.IncludeUtils(config, num23 * 4, 8, ref offset_third);
						}
						for (int num24 = 0; num24 < num23; num24++)
						{
							System.Runtime.InteropServices.Marshal.WriteInt32(new System.IntPtr(config.ToInt64() + (long)(num24 * 4)), prototypeUtils.DeleteUtils());
						}
						Attr.IncludeUtils(config, num23 * 4, offset_third, ref offset_third);
					}
					Attr.EnableUtils(intPtr);
					return;
				}
				for (int num25 = 0; num25 < num20; num25++)
				{
					System.IntPtr intPtr3 = new System.IntPtr(num18 + (long)prototypeUtils.DeleteUtils() - (long)num19);
					if (Attr.IncludeUtils(intPtr3, 4, 4, ref offset_third) == 0)
					{
						Attr.IncludeUtils(intPtr3, 4, 8, ref offset_third);
					}
					System.Runtime.InteropServices.Marshal.WriteInt32(intPtr3, prototypeUtils.DeleteUtils());
					Attr.IncludeUtils(intPtr3, 4, offset_third, ref offset_third);
				}
				Attr.m_Schema = new System.Collections.Hashtable(prototypeUtils.DeleteUtils() + 1);
				Attr.ServiceUtils serviceUtils = default(Attr.ServiceUtils);
				serviceUtils.m_CallbackUtils = new byte[]
				{
					42
				};
				serviceUtils.algoUtils = false;
				Attr.m_Schema.Add(0L, serviceUtils);
				while (prototypeUtils.method_0().Position < prototypeUtils.method_0().Length - 1L)
				{
					int num26 = prototypeUtils.DeleteUtils() - num19;
					int num27 = prototypeUtils.DeleteUtils();
					bool algoUtils = false;
					if (num27 >= 1879048192)
					{
						algoUtils = true;
					}
					int sumasset = prototypeUtils.DeleteUtils();
					byte[] callbackUtils = prototypeUtils.ExcludeUtils(sumasset);
					Attr.ServiceUtils serviceUtils2 = default(Attr.ServiceUtils);
					serviceUtils2.m_CallbackUtils = callbackUtils;
					serviceUtils2.algoUtils = algoUtils;
					Attr.m_Schema.Add(num18 + (long)num26, serviceUtils2);
				}
				Attr.specification = System.Runtime.InteropServices.Marshal.GetHINSTANCE(typeof(Attr).Assembly.GetModules()[0]).ToInt64();
				if (System.IntPtr.Size == 4)
				{
					Attr.m_Merchant = System.Convert.ToInt32(Attr.specification);
				}
				byte[] bytes = new byte[]
				{
					109,
					115,
					99,
					111,
					114,
					106,
					105,
					116,
					46,
					100,
					108,
					108
				};
				string @string = System.Text.Encoding.UTF8.GetString(bytes);
				System.IntPtr intPtr4 = Attr.LoadLibrary(@string);
				if (intPtr4 == System.IntPtr.Zero)
				{
					bytes = new byte[]
					{
						99,
						108,
						114,
						106,
						105,
						116,
						46,
						100,
						108,
						108
					};
					@string = System.Text.Encoding.UTF8.GetString(bytes);
					intPtr4 = Attr.LoadLibrary(@string);
				}
				byte[] bytes2 = new byte[]
				{
					103,
					101,
					116,
					74,
					105,
					116
				};
				string string2 = System.Text.Encoding.UTF8.GetString(bytes2);
				System.IntPtr ptr2 = ((Attr.WriterUtils)Attr.ReflectUtils(Attr.GetProcAddress(intPtr4, string2), typeof(Attr.WriterUtils)))();
				long value = 0L;
				if (System.IntPtr.Size == 4)
				{
					value = (long)System.Runtime.InteropServices.Marshal.ReadInt32(ptr2);
				}
				else
				{
					value = System.Runtime.InteropServices.Marshal.ReadInt64(ptr2);
				}
				System.Runtime.InteropServices.Marshal.ReadIntPtr(ptr2, 0);
				Attr.consumer = new Attr.ParamsUtils(Attr.SetupUtils);
				System.IntPtr intPtr5 = System.IntPtr.Zero;
				intPtr5 = System.Runtime.InteropServices.Marshal.GetFunctionPointerForDelegate(Attr.consumer);
				long num28 = 0L;
				if (System.IntPtr.Size == 4)
				{
					num28 = (long)System.Runtime.InteropServices.Marshal.ReadInt32(new System.IntPtr(value));
				}
				else
				{
					num28 = System.Runtime.InteropServices.Marshal.ReadInt64(new System.IntPtr(value));
				}
				Process currentProcess = Process.GetCurrentProcess();
				try
				{
					foreach (object obj2 in currentProcess.Modules)
					{
						ProcessModule processModule2 = (ProcessModule)obj2;
						if (processModule2.ModuleName == @string && (num28 < processModule2.BaseAddress.ToInt64() || num28 > processModule2.BaseAddress.ToInt64() + (long)processModule2.ModuleMemorySize) && typeof(Attr).Assembly.EntryPoint != null)
						{
							return;
						}
					}
				}
				catch
				{
				}
				try
				{
					using (System.Collections.IEnumerator enumerator = currentProcess.Modules.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							if (((ProcessModule)enumerator.Current).BaseAddress.ToInt64() == Attr.specification)
							{
								break;
							}
						}
					}
				}
				catch
				{
				}
				Attr.m_Pool = null;
				try
				{
					Attr.m_Pool = (Attr.ParamsUtils)Attr.ReflectUtils(new System.IntPtr(num28), typeof(Attr.ParamsUtils));
				}
				catch
				{
					try
					{
						System.Delegate @delegate = Attr.ReflectUtils(new System.IntPtr(num28), typeof(Attr.ParamsUtils));
						Attr.m_Pool = (Attr.ParamsUtils)System.Delegate.CreateDelegate(typeof(Attr.ParamsUtils), @delegate.Method);
					}
					catch
					{
					}
				}
				int offset_third2 = 0;
				if (typeof(Attr).Assembly.EntryPoint != null && typeof(Attr).Assembly.EntryPoint.GetParameters().Length == 2 && typeof(Attr).Assembly.Location != null && typeof(Attr).Assembly.Location.Length > 0)
				{
					return;
				}
				try
				{
					object value2 = typeof(Attr).Assembly.ManifestModule.ModuleHandle.GetType().GetField("m_ptr", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic).GetValue(typeof(Attr).Assembly.ManifestModule.ModuleHandle);
					if (value2 is System.IntPtr)
					{
						Attr.m_System = (System.IntPtr)value2;
					}
					if (value2.GetType().ToString() == "System.Reflection.RuntimeModule")
					{
						Attr.m_System = (System.IntPtr)value2.GetType().GetField("m_pData", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic).GetValue(value2);
					}
					System.IO.MemoryStream memoryStream2 = new System.IO.MemoryStream();
					memoryStream2.Write(new byte[System.IntPtr.Size], 0, System.IntPtr.Size);
					if (System.IntPtr.Size == 4)
					{
						memoryStream2.Write(System.BitConverter.GetBytes(Attr.m_System.ToInt32()), 0, 4);
					}
					else
					{
						memoryStream2.Write(System.BitConverter.GetBytes(Attr.m_System.ToInt64()), 0, 8);
					}
					memoryStream2.Write(new byte[System.IntPtr.Size], 0, System.IntPtr.Size);
					memoryStream2.Write(new byte[System.IntPtr.Size], 0, System.IntPtr.Size);
					memoryStream2.Position = 0L;
					byte[] array10 = memoryStream2.ToArray();
					memoryStream2.Close();
					uint num29 = 0U;
					try
					{
						byte* value3;
						if ((array9 = array10) != null && array9.Length != 0)
						{
							value3 = &array9[0];
						}
						else
						{
							value3 = null;
						}
						Attr.consumer(new System.IntPtr((void*)value3), new System.IntPtr((void*)value3), new System.IntPtr((void*)value3), 216669565U, new System.IntPtr((void*)value3), ref num29);
					}
					finally
					{
						array9 = null;
					}
				}
				catch
				{
				}
				System.Runtime.CompilerServices.RuntimeHelpers.PrepareDelegate(Attr.m_Pool);
				System.Runtime.CompilerServices.RuntimeHelpers.PrepareMethod(Attr.m_Pool.Method.MethodHandle);
				System.Runtime.CompilerServices.RuntimeHelpers.PrepareDelegate(Attr.consumer);
				System.Runtime.CompilerServices.RuntimeHelpers.PrepareMethod(Attr.consumer.Method.MethodHandle);
				byte[] array11;
				if (System.IntPtr.Size != 4)
				{
					array11 = new byte[]
					{
						72,
						184,
						0,
						0,
						0,
						0,
						0,
						0,
						0,
						0,
						73,
						57,
						64,
						8,
						116,
						12,
						72,
						184,
						0,
						0,
						0,
						0,
						0,
						0,
						0,
						0,
						byte.MaxValue,
						224,
						72,
						184,
						0,
						0,
						0,
						0,
						0,
						0,
						0,
						0,
						byte.MaxValue,
						224
					};
				}
				else
				{
					array11 = new byte[]
					{
						85,
						139,
						236,
						139,
						69,
						16,
						129,
						120,
						4,
						125,
						29,
						234,
						12,
						116,
						7,
						184,
						182,
						177,
						74,
						6,
						235,
						5,
						184,
						182,
						146,
						64,
						12,
						93,
						byte.MaxValue,
						224
					};
				}
				System.IntPtr intPtr6 = Attr.ChangeUtils(System.IntPtr.Zero, (uint)array11.Length, 4096U, 64U);
				byte[] array12 = array11;
				byte[] bytes3;
				byte[] bytes4;
				byte[] bytes5;
				if (System.IntPtr.Size == 4)
				{
					bytes3 = System.BitConverter.GetBytes(Attr.m_System.ToInt32());
					bytes4 = System.BitConverter.GetBytes(intPtr5.ToInt32());
					bytes5 = System.BitConverter.GetBytes(System.Convert.ToInt32(num28));
				}
				else
				{
					bytes3 = System.BitConverter.GetBytes(Attr.m_System.ToInt64());
					bytes4 = System.BitConverter.GetBytes(intPtr5.ToInt64());
					bytes5 = System.BitConverter.GetBytes(num28);
				}
				if (System.IntPtr.Size == 4)
				{
					array12[9] = bytes3[0];
					array12[10] = bytes3[1];
					array12[11] = bytes3[2];
					array12[12] = bytes3[3];
					array12[16] = bytes5[0];
					array12[17] = bytes5[1];
					array12[18] = bytes5[2];
					array12[19] = bytes5[3];
					array12[23] = bytes4[0];
					array12[24] = bytes4[1];
					array12[25] = bytes4[2];
					array12[26] = bytes4[3];
				}
				else
				{
					array12[2] = bytes3[0];
					array12[3] = bytes3[1];
					array12[4] = bytes3[2];
					array12[5] = bytes3[3];
					array12[6] = bytes3[4];
					array12[7] = bytes3[5];
					array12[8] = bytes3[6];
					array12[9] = bytes3[7];
					array12[18] = bytes5[0];
					array12[19] = bytes5[1];
					array12[20] = bytes5[2];
					array12[21] = bytes5[3];
					array12[22] = bytes5[4];
					array12[23] = bytes5[5];
					array12[24] = bytes5[6];
					array12[25] = bytes5[7];
					array12[30] = bytes4[0];
					array12[31] = bytes4[1];
					array12[32] = bytes4[2];
					array12[33] = bytes4[3];
					array12[34] = bytes4[4];
					array12[35] = bytes4[5];
					array12[36] = bytes4[6];
					array12[37] = bytes4[7];
				}
				System.Runtime.InteropServices.Marshal.Copy(array12, 0, intPtr6, array12.Length);
				Attr._Val = false;
				Attr.IncludeUtils(new System.IntPtr(value), System.IntPtr.Size, 64, ref offset_third2);
				System.Runtime.InteropServices.Marshal.WriteIntPtr(new System.IntPtr(value), intPtr6);
				Attr.IncludeUtils(new System.IntPtr(value), System.IntPtr.Size, offset_third2, ref offset_third2);
			}
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x0000A184 File Offset: 0x00008384
		internal static object CloneUtils(System.Reflection.Assembly ident)
		{
			try
			{
				if (File.Exists(((System.Reflection.Assembly)ident).Location))
				{
					return ((System.Reflection.Assembly)ident).Location;
				}
			}
			catch
			{
			}
			try
			{
				if (File.Exists(((System.Reflection.Assembly)ident).GetName().CodeBase.ToString().Replace("file:///", "")))
				{
					return ((System.Reflection.Assembly)ident).GetName().CodeBase.ToString().Replace("file:///", "");
				}
			}
			catch
			{
			}
			try
			{
				if (File.Exists(ident.GetType().GetProperty("Location").GetValue(ident, new object[0]).ToString()))
				{
					return ident.GetType().GetProperty("Location").GetValue(ident, new object[0]).ToString();
				}
			}
			catch
			{
			}
			return "";
		}

		// Token: 0x060000C8 RID: 200
		[System.Runtime.InteropServices.DllImport("kernel32")]
		public static extern System.IntPtr LoadLibrary(string init);

		// Token: 0x060000C9 RID: 201
		[System.Runtime.InteropServices.DllImport("kernel32", CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
		public static extern System.IntPtr GetProcAddress(System.IntPtr key, string cont);

		// Token: 0x060000CA RID: 202 RVA: 0x0000A294 File Offset: 0x00008494
		private static System.IntPtr VerifyUtils(System.IntPtr v, string pol, uint state_Ptr)
		{
			if (Attr._Global == null)
			{
				Attr._Global = (Attr.TestUtils)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(Attr.GetProcAddress(Attr.smethod_0(), "Find ".Trim() + "ResourceA"), typeof(Attr.TestUtils));
			}
			return Attr._Global(v, pol, state_Ptr);
		}

		// Token: 0x060000CB RID: 203 RVA: 0x0000A2EC File Offset: 0x000084EC
		private static System.IntPtr ChangeUtils(System.IntPtr reference, uint visitor, uint meanproc, uint cont2_size)
		{
			if (Attr._Factory == null)
			{
				Attr._Factory = (Attr.BridgeUtils)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(Attr.GetProcAddress(Attr.smethod_0(), "Virtual ".Trim() + "Alloc"), typeof(Attr.BridgeUtils));
			}
			return Attr._Factory(reference, visitor, meanproc, cont2_size);
		}

		// Token: 0x060000CC RID: 204 RVA: 0x0000A348 File Offset: 0x00008548
		private static int ListUtils(System.IntPtr first, System.IntPtr map, [System.Runtime.InteropServices.In] [System.Runtime.InteropServices.Out] byte[] role, uint reference2, out System.IntPtr attr3)
		{
			if (Attr.m_Order == null)
			{
				Attr.m_Order = (Attr.PredicateUtils)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(Attr.GetProcAddress(Attr.smethod_0(), "Write ".Trim() + "Process ".Trim() + "Memory"), typeof(Attr.PredicateUtils));
			}
			return Attr.m_Order(first, map, role, reference2, out attr3);
		}

		// Token: 0x060000CD RID: 205 RVA: 0x0000A3B0 File Offset: 0x000085B0
		private static int IncludeUtils(System.IntPtr config, int removeCOUNTERAt, int offset_third, ref int visitor2)
		{
			if (Attr._Getter == null)
			{
				Attr._Getter = (Attr.ProductUtils)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(Attr.GetProcAddress(Attr.smethod_0(), "Virtual ".Trim() + "Protect"), typeof(Attr.ProductUtils));
			}
			return Attr._Getter(config, removeCOUNTERAt, offset_third, ref visitor2);
		}

		// Token: 0x060000CE RID: 206 RVA: 0x0000A40C File Offset: 0x0000860C
		private static System.IntPtr CreateUtils(uint index_reference, int caller_end, uint end_rule)
		{
			if (Attr._Proc == null)
			{
				Attr._Proc = (Attr.BaseUtils)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(Attr.GetProcAddress(Attr.smethod_0(), "Open ".Trim() + "Process"), typeof(Attr.BaseUtils));
			}
			return Attr._Proc(index_reference, caller_end, end_rule);
		}

		// Token: 0x060000CF RID: 207 RVA: 0x0000A464 File Offset: 0x00008664
		private static int EnableUtils(System.IntPtr asset)
		{
			if (Attr.m_SingletonUtils == null)
			{
				Attr.m_SingletonUtils = (Attr.RoleUtils)System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer(Attr.GetProcAddress(Attr.smethod_0(), "Close ".Trim() + "Handle"), typeof(Attr.RoleUtils));
			}
			return Attr.m_SingletonUtils(asset);
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x00002558 File Offset: 0x00000758
		private static System.IntPtr smethod_0()
		{
			if (Attr.utilsUtils == System.IntPtr.Zero)
			{
				Attr.utilsUtils = Attr.LoadLibrary("kernel ".Trim() + "32.dll");
			}
			return Attr.utilsUtils;
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x0000A4BC File Offset: 0x000086BC
		private static byte[] PatchUtils(string config)
		{
			byte[] array;
			using (System.IO.FileStream fileStream = new System.IO.FileStream(config, System.IO.FileMode.Open, System.IO.FileAccess.Read, System.IO.FileShare.Read))
			{
				int num = 0;
				int i = (int)fileStream.Length;
				array = new byte[i];
				while (i > 0)
				{
					int num2 = fileStream.Read(array, num, i);
					num += num2;
					i -= num2;
				}
			}
			return array;
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x0000258E File Offset: 0x0000078E
		internal static byte[] InitUtils(System.IO.MemoryStream i)
		{
			return ((System.IO.MemoryStream)i).ToArray();
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x0000A51C File Offset: 0x0000871C
		private static byte[] CollectUtils(byte[] v)
		{
			System.IO.Stream stream = new System.IO.MemoryStream();
			SymmetricAlgorithm symmetricAlgorithm = Attr.TestSingleton();
			symmetricAlgorithm.Key = new byte[]
			{
				26,
				22,
				172,
				51,
				10,
				32,
				104,
				164,
				186,
				72,
				54,
				130,
				241,
				71,
				20,
				251,
				134,
				81,
				56,
				180,
				162,
				123,
				215,
				125,
				249,
				129,
				131,
				62,
				142,
				39,
				57,
				227
			};
			symmetricAlgorithm.IV = new byte[]
			{
				202,
				51,
				56,
				157,
				0,
				106,
				252,
				177,
				168,
				5,
				158,
				10,
				124,
				228,
				223,
				135
			};
			CryptoStream cryptoStream = new CryptoStream(stream, symmetricAlgorithm.CreateDecryptor(), CryptoStreamMode.Write);
			cryptoStream.Write(v, 0, v.Length);
			cryptoStream.Close();
			return Attr.InitUtils(stream);
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x0000A58C File Offset: 0x0000878C
		private unsafe static int ConcatUtils(object spec)
		{
			char* ptr = spec;
			if (ptr != null)
			{
				ptr += System.Runtime.CompilerServices.RuntimeHelpers.OffsetToStringData / 2;
			}
			int num = 5381;
			int num2 = 5381;
			char* ptr2 = ptr;
			int num3;
			while ((num3 = (int)(*ptr2)) != 0)
			{
				num = ((num << 5) + num ^ num3);
				num3 = (int)ptr2[1];
				if (num3 == 0)
				{
					break;
				}
				num2 = ((num2 << 5) + num2 ^ num3);
				ptr2 += 2;
			}
			return num + num2 * 1566083941;
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x0000A5F4 File Offset: 0x000087F4
		internal static bool InvokeUtils(string setup, string ord)
		{
			if (setup == ord)
			{
				return true;
			}
			if (setup == null || ord == null)
			{
				return false;
			}
			bool flag = false;
			bool flag2 = false;
			int num = 0;
			int num2 = 0;
			if (setup.StartsWith(Attr.m_AdvisorUtils))
			{
				flag = true;
				num = (int)(setup[4] | (int)setup[5] << 8 | (int)setup[6] << 16 | (int)setup[7] << 24);
			}
			if (ord.StartsWith(Attr.m_AdvisorUtils))
			{
				flag2 = true;
				num2 = (int)(ord[4] | (int)ord[5] << 8 | (int)ord[6] << 16 | (int)ord[7] << 24);
			}
			if (!flag && !flag2)
			{
				return false;
			}
			if (!flag)
			{
				num = Attr.ConcatUtils(setup);
			}
			if (!flag2)
			{
				num2 = Attr.ConcatUtils(ord);
			}
			return num == num2;
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x0000A6B0 File Offset: 0x000088B0
		private byte[] AwakeUtils()
		{
			return null;
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x0000A6B0 File Offset: 0x000088B0
		private byte[] FlushUtils()
		{
			return null;
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x0000259B File Offset: 0x0000079B
		private byte[] PopUtils()
		{
			int length = "{11111-22222-20001-00001}".Length;
			return new byte[]
			{
				1,
				2
			};
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x000025B6 File Offset: 0x000007B6
		private byte[] RegisterUtils()
		{
			int length = "{11111-22222-20001-00002}".Length;
			return new byte[]
			{
				1,
				2
			};
		}

		// Token: 0x060000DA RID: 218 RVA: 0x0000A6B0 File Offset: 0x000088B0
		private byte[] CalcUtils()
		{
			return null;
		}

		// Token: 0x060000DB RID: 219 RVA: 0x0000A6B0 File Offset: 0x000088B0
		private byte[] DestroyUtils()
		{
			return null;
		}

		// Token: 0x060000DC RID: 220 RVA: 0x000025D1 File Offset: 0x000007D1
		internal byte[] GetUtils()
		{
			int length = "{11111-22222-40001-00001}".Length;
			return new byte[]
			{
				1,
				2
			};
		}

		// Token: 0x060000DD RID: 221 RVA: 0x000025EC File Offset: 0x000007EC
		internal byte[] StartUtils()
		{
			int length = "{11111-22222-40001-00002}".Length;
			return new byte[]
			{
				1,
				2
			};
		}

		// Token: 0x060000DE RID: 222 RVA: 0x00002607 File Offset: 0x00000807
		internal byte[] SearchUtils()
		{
			int length = "{11111-22222-50001-00001}".Length;
			return new byte[]
			{
				1,
				2
			};
		}

		// Token: 0x060000DF RID: 223 RVA: 0x00002622 File Offset: 0x00000822
		internal byte[] PushUtils()
		{
			int length = "{11111-22222-50001-00002}".Length;
			return new byte[]
			{
				1,
				2
			};
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x0000263D File Offset: 0x0000083D
		internal static object CallConnection(Attr.PrototypeUtils prototypeUtils_0)
		{
			return prototypeUtils_0.method_0();
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x00002648 File Offset: 0x00000848
		internal static void FillConnection(System.IO.Stream stream_0, long long_0)
		{
			stream_0.Position = long_0;
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x00002657 File Offset: 0x00000857
		internal static long FindConnection(System.IO.Stream stream_0)
		{
			return stream_0.Length;
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x00002662 File Offset: 0x00000862
		internal static object ReflectConnection(Attr.PrototypeUtils prototypeUtils_0, int sumasset)
		{
			return prototypeUtils_0.ExcludeUtils(sumasset);
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x00002671 File Offset: 0x00000871
		internal static void PostConnection(Attr.PrototypeUtils prototypeUtils_0)
		{
			prototypeUtils_0.RunUtils();
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x0000267C File Offset: 0x0000087C
		internal static void SelectConnection(System.Array array_0)
		{
			System.Array.Reverse(array_0);
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x00002687 File Offset: 0x00000887
		internal static object CustomizeConnection(System.Reflection.Assembly assembly_0)
		{
			return assembly_0.GetName();
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x00002692 File Offset: 0x00000892
		internal static object NewConnection(System.Reflection.AssemblyName assemblyName_0)
		{
			return assemblyName_0.GetPublicKeyToken();
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x0000269D File Offset: 0x0000089D
		internal static object DefineConnection()
		{
			return Attr.TestSingleton();
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x000026A4 File Offset: 0x000008A4
		internal static void InterruptConnection(SymmetricAlgorithm symmetricAlgorithm_0, CipherMode cipherMode_0)
		{
			symmetricAlgorithm_0.Mode = cipherMode_0;
		}

		// Token: 0x060000EA RID: 234 RVA: 0x000026B3 File Offset: 0x000008B3
		internal static object CreateConnection(SymmetricAlgorithm symmetricAlgorithm_0, byte[] byte_0, byte[] byte_1)
		{
			return symmetricAlgorithm_0.CreateDecryptor(byte_0, byte_1);
		}

		// Token: 0x060000EB RID: 235 RVA: 0x000026C6 File Offset: 0x000008C6
		internal static object PushConnection()
		{
			return new System.IO.MemoryStream();
		}

		// Token: 0x060000EC RID: 236 RVA: 0x000026CD File Offset: 0x000008CD
		internal static void ManageConnection(System.IO.Stream stream_0, byte[] byte_0, int int_0, int int_1)
		{
			stream_0.Write(byte_0, int_0, int_1);
		}

		// Token: 0x060000ED RID: 237 RVA: 0x000026E4 File Offset: 0x000008E4
		internal static void PrepareConnection(CryptoStream cryptoStream_0)
		{
			cryptoStream_0.FlushFinalBlock();
		}

		// Token: 0x060000EE RID: 238 RVA: 0x000026EF File Offset: 0x000008EF
		internal static object RestartConnection(System.IO.MemoryStream memoryStream_0)
		{
			return Attr.InitUtils(memoryStream_0);
		}

		// Token: 0x060000EF RID: 239 RVA: 0x000026FA File Offset: 0x000008FA
		internal static void InvokeConnection(System.IO.Stream stream_0)
		{
			stream_0.Close();
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x00002705 File Offset: 0x00000905
		internal static object WriteConnection(System.Reflection.Assembly assembly_0)
		{
			return assembly_0.EntryPoint;
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x00002710 File Offset: 0x00000910
		internal static bool ExcludeConnection(System.Reflection.MethodInfo methodInfo_0, System.Reflection.MethodInfo methodInfo_1)
		{
			return methodInfo_0 == methodInfo_1;
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x0000271F File Offset: 0x0000091F
		internal static bool ConnectConnection()
		{
			return null == null;
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x00002725 File Offset: 0x00000925
		internal static object SetupConnection()
		{
			return null;
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x00002728 File Offset: 0x00000928
		static int ManageIndexer()
		{
			return 1;
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x0000272B File Offset: 0x0000092B
		internal static System.IntPtr InvokeIndexer(System.IntPtr intptr_0, int int_0)
		{
			return System.Runtime.InteropServices.Marshal.ReadIntPtr(intptr_0, int_0);
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x0000273A File Offset: 0x0000093A
		internal static int WriteIndexer(System.IntPtr intptr_0, int int_0)
		{
			return System.Runtime.InteropServices.Marshal.ReadInt32(intptr_0, int_0);
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x00002749 File Offset: 0x00000949
		internal static long ExcludeIndexer(System.IntPtr intptr_0, int int_0)
		{
			return System.Runtime.InteropServices.Marshal.ReadInt64(intptr_0, int_0);
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x00002758 File Offset: 0x00000958
		internal static void StopIndexer(System.IntPtr intptr_0, int int_0, System.IntPtr intptr_1)
		{
			System.Runtime.InteropServices.Marshal.WriteIntPtr(intptr_0, int_0, intptr_1);
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x0000276B File Offset: 0x0000096B
		internal static void CompareIndexer(System.IntPtr intptr_0, int int_0, int int_1)
		{
			System.Runtime.InteropServices.Marshal.WriteInt32(intptr_0, int_0, int_1);
		}

		// Token: 0x060000FA RID: 250 RVA: 0x0000277E File Offset: 0x0000097E
		internal static void OrderIndexer(System.IntPtr intptr_0, int int_0, long long_0)
		{
			System.Runtime.InteropServices.Marshal.WriteInt64(intptr_0, int_0, long_0);
		}

		// Token: 0x060000FB RID: 251 RVA: 0x00002791 File Offset: 0x00000991
		internal static System.IntPtr LoginIndexer(int int_0)
		{
			return System.Runtime.InteropServices.Marshal.AllocCoTaskMem(int_0);
		}

		// Token: 0x060000FC RID: 252 RVA: 0x0000279C File Offset: 0x0000099C
		internal static void InitIndexer(byte[] byte_0, int int_0, System.IntPtr intptr_0, int int_1)
		{
			System.Runtime.InteropServices.Marshal.Copy(byte_0, int_0, intptr_0, int_1);
		}

		// Token: 0x060000FD RID: 253 RVA: 0x000027B3 File Offset: 0x000009B3
		internal static void AwakeIndexer()
		{
			Attr.CountUtils();
		}

		// Token: 0x060000FE RID: 254 RVA: 0x000027BA File Offset: 0x000009BA
		internal static object DisableIndexer()
		{
			return Process.GetCurrentProcess();
		}

		// Token: 0x060000FF RID: 255 RVA: 0x000027C1 File Offset: 0x000009C1
		internal static object ReadIndexer(Process process_0)
		{
			return process_0.MainModule;
		}

		// Token: 0x06000100 RID: 256 RVA: 0x000027CC File Offset: 0x000009CC
		internal static System.IntPtr IncludeIndexer(ProcessModule processModule_0)
		{
			return processModule_0.BaseAddress;
		}

		// Token: 0x06000101 RID: 257 RVA: 0x000027D7 File Offset: 0x000009D7
		internal static System.IntPtr DestroyIndexer(System.IntPtr v, string string_0, uint state_Ptr)
		{
			return Attr.VerifyUtils(v, string_0, state_Ptr);
		}

		// Token: 0x06000102 RID: 258 RVA: 0x000027EA File Offset: 0x000009EA
		internal static bool CollectIndexer(System.IntPtr intptr_0, System.IntPtr intptr_1)
		{
			return intptr_0 != intptr_1;
		}

		// Token: 0x06000103 RID: 259 RVA: 0x000027F9 File Offset: 0x000009F9
		internal static void CalcIndexer()
		{
		}

		// Token: 0x06000104 RID: 260 RVA: 0x000027FC File Offset: 0x000009FC
		internal static int GetIndexer()
		{
			return System.IntPtr.Size;
		}

		// Token: 0x06000105 RID: 261 RVA: 0x00002803 File Offset: 0x00000A03
		internal static System.Type RemoveIndexer(string string_0, bool bool_0)
		{
			return System.Type.GetType(string_0, bool_0);
		}

		// Token: 0x06000106 RID: 262 RVA: 0x00002812 File Offset: 0x00000A12
		internal static bool EnableIndexer(System.Type type_0, System.Type type_1)
		{
			return type_0 != type_1;
		}

		// Token: 0x06000107 RID: 263 RVA: 0x00002821 File Offset: 0x00000A21
		internal static object ComputeIndexer(Process process_0)
		{
			return process_0.Modules;
		}

		// Token: 0x06000108 RID: 264 RVA: 0x0000282C File Offset: 0x00000A2C
		internal static object CloneIndexer(ReadOnlyCollectionBase readOnlyCollectionBase_0)
		{
			return readOnlyCollectionBase_0.GetEnumerator();
		}

		// Token: 0x06000109 RID: 265 RVA: 0x00002837 File Offset: 0x00000A37
		internal static object InsertIndexer(System.Collections.IEnumerator ienumerator_0)
		{
			return ienumerator_0.Current;
		}

		// Token: 0x0600010A RID: 266 RVA: 0x00002842 File Offset: 0x00000A42
		internal static object ResolveIndexer(ProcessModule processModule_0)
		{
			return processModule_0.ModuleName;
		}

		// Token: 0x0600010B RID: 267 RVA: 0x0000284D File Offset: 0x00000A4D
		internal static object TestIndexer(string string_0)
		{
			return string_0.ToLower();
		}

		// Token: 0x0600010C RID: 268 RVA: 0x00002858 File Offset: 0x00000A58
		internal static bool MapIndexer(string string_0, string string_1)
		{
			return string_0 == string_1;
		}

		// Token: 0x0600010D RID: 269 RVA: 0x00002867 File Offset: 0x00000A67
		internal static object PublishIndexer(ProcessModule processModule_0)
		{
			return processModule_0.FileVersionInfo;
		}

		// Token: 0x0600010E RID: 270 RVA: 0x00002872 File Offset: 0x00000A72
		internal static int FlushIndexer(FileVersionInfo fileVersionInfo_0)
		{
			return fileVersionInfo_0.ProductMajorPart;
		}

		// Token: 0x0600010F RID: 271 RVA: 0x0000287D File Offset: 0x00000A7D
		internal static int ListIndexer(FileVersionInfo fileVersionInfo_0)
		{
			return fileVersionInfo_0.ProductMinorPart;
		}

		// Token: 0x06000110 RID: 272 RVA: 0x00002888 File Offset: 0x00000A88
		internal static int UpdateIndexer(FileVersionInfo fileVersionInfo_0)
		{
			return fileVersionInfo_0.ProductBuildPart;
		}

		// Token: 0x06000111 RID: 273 RVA: 0x00002893 File Offset: 0x00000A93
		internal static int PrintIndexer(FileVersionInfo fileVersionInfo_0)
		{
			return fileVersionInfo_0.ProductPrivatePart;
		}

		// Token: 0x06000112 RID: 274 RVA: 0x0000289E File Offset: 0x00000A9E
		internal static bool VisitIndexer(System.Version version_0, System.Version version_1)
		{
			return version_0 >= version_1;
		}

		// Token: 0x06000113 RID: 275 RVA: 0x000028AD File Offset: 0x00000AAD
		internal static bool ViewIndexer(System.Version version_0, System.Version version_1)
		{
			return version_0 < version_1;
		}

		// Token: 0x06000114 RID: 276 RVA: 0x000028BC File Offset: 0x00000ABC
		internal static bool ChangeIndexer(System.Collections.IEnumerator ienumerator_0)
		{
			return ienumerator_0.MoveNext();
		}

		// Token: 0x06000115 RID: 277 RVA: 0x000028C7 File Offset: 0x00000AC7
		internal static void SortIndexer(System.IDisposable idisposable_0)
		{
			idisposable_0.Dispose();
		}

		// Token: 0x06000116 RID: 278 RVA: 0x000028D2 File Offset: 0x00000AD2
		internal static object VerifyIndexer(System.Reflection.Assembly assembly_0, string string_0)
		{
			return assembly_0.GetManifestResourceStream(string_0);
		}

		// Token: 0x06000117 RID: 279 RVA: 0x0000263D File Offset: 0x0000083D
		internal static object DeleteIndexer(Attr.PrototypeUtils prototypeUtils_0)
		{
			return prototypeUtils_0.method_0();
		}

		// Token: 0x06000118 RID: 280 RVA: 0x00002648 File Offset: 0x00000848
		internal static void ForgotIndexer(System.IO.Stream stream_0, long long_0)
		{
			stream_0.Position = long_0;
		}

		// Token: 0x06000119 RID: 281 RVA: 0x00002657 File Offset: 0x00000857
		internal static long PopIndexer(System.IO.Stream stream_0)
		{
			return stream_0.Length;
		}

		// Token: 0x0600011A RID: 282 RVA: 0x00002662 File Offset: 0x00000862
		internal static object SetIndexer(Attr.PrototypeUtils prototypeUtils_0, int sumasset)
		{
			return prototypeUtils_0.ExcludeUtils(sumasset);
		}

		// Token: 0x0600011B RID: 283 RVA: 0x0000267C File Offset: 0x0000087C
		internal static void ValidateIndexer(System.Array array_0)
		{
			System.Array.Reverse(array_0);
		}

		// Token: 0x0600011C RID: 284 RVA: 0x00002687 File Offset: 0x00000887
		internal static object CancelIndexer(System.Reflection.Assembly assembly_0)
		{
			return assembly_0.GetName();
		}

		// Token: 0x0600011D RID: 285 RVA: 0x00002692 File Offset: 0x00000892
		internal static object AssetIndexer(System.Reflection.AssemblyName assemblyName_0)
		{
			return assemblyName_0.GetPublicKeyToken();
		}

		// Token: 0x0600011E RID: 286 RVA: 0x000028E1 File Offset: 0x00000AE1
		internal static void RunIndexer(System.Array array_0, int int_0, int int_1)
		{
			System.Array.Clear(array_0, int_0, int_1);
		}

		// Token: 0x0600011F RID: 287 RVA: 0x000028F4 File Offset: 0x00000AF4
		internal static object RateIndexer(System.Reflection.Assembly assembly_0)
		{
			return assembly_0.GetModules();
		}

		// Token: 0x06000120 RID: 288 RVA: 0x000028FF File Offset: 0x00000AFF
		internal static System.IntPtr LogoutIndexer(System.Reflection.Module module_0)
		{
			return System.Runtime.InteropServices.Marshal.GetHINSTANCE(module_0);
		}

		// Token: 0x06000121 RID: 289 RVA: 0x0000290A File Offset: 0x00000B0A
		internal static object CheckIndexer(System.Reflection.Assembly assembly_0)
		{
			return assembly_0.Location;
		}

		// Token: 0x06000122 RID: 290 RVA: 0x00002915 File Offset: 0x00000B15
		internal static int QueryIndexer(string string_0)
		{
			return string_0.Length;
		}

		// Token: 0x06000123 RID: 291 RVA: 0x00002920 File Offset: 0x00000B20
		internal static int SearchIndexer(Attr.PrototypeUtils prototypeUtils_0)
		{
			return prototypeUtils_0.DeleteUtils();
		}

		// Token: 0x06000124 RID: 292 RVA: 0x0000269D File Offset: 0x0000089D
		internal static object CalculateIndexer()
		{
			return Attr.TestSingleton();
		}

		// Token: 0x06000125 RID: 293 RVA: 0x000026A4 File Offset: 0x000008A4
		internal static void StartIndexer(SymmetricAlgorithm symmetricAlgorithm_0, CipherMode cipherMode_0)
		{
			symmetricAlgorithm_0.Mode = cipherMode_0;
		}

		// Token: 0x06000126 RID: 294 RVA: 0x000026B3 File Offset: 0x000008B3
		internal static object InstantiateIndexer(SymmetricAlgorithm symmetricAlgorithm_0, byte[] byte_0, byte[] byte_1)
		{
			return symmetricAlgorithm_0.CreateDecryptor(byte_0, byte_1);
		}

		// Token: 0x06000127 RID: 295 RVA: 0x000026CD File Offset: 0x000008CD
		internal static void ConcatIndexer(System.IO.Stream stream_0, byte[] byte_0, int int_0, int int_1)
		{
			stream_0.Write(byte_0, int_0, int_1);
		}

		// Token: 0x06000128 RID: 296 RVA: 0x000026E4 File Offset: 0x000008E4
		internal static void ResetIndexer(CryptoStream cryptoStream_0)
		{
			cryptoStream_0.FlushFinalBlock();
		}

		// Token: 0x06000129 RID: 297 RVA: 0x0000292B File Offset: 0x00000B2B
		internal static object MoveIndexer(System.IO.MemoryStream memoryStream_0)
		{
			return memoryStream_0.ToArray();
		}

		// Token: 0x0600012A RID: 298 RVA: 0x000026FA File Offset: 0x000008FA
		internal static void AddIndexer(System.IO.Stream stream_0)
		{
			stream_0.Close();
		}

		// Token: 0x0600012B RID: 299 RVA: 0x00002671 File Offset: 0x00000871
		internal static void PatchIndexer(Attr.PrototypeUtils prototypeUtils_0)
		{
			prototypeUtils_0.RunUtils();
		}

		// Token: 0x0600012C RID: 300 RVA: 0x00002936 File Offset: 0x00000B36
		internal static int CountIndexer(Process process_0)
		{
			return process_0.Id;
		}

		// Token: 0x0600012D RID: 301 RVA: 0x00002941 File Offset: 0x00000B41
		internal static System.IntPtr RegisterIndexer(uint index_reference, int caller_end, uint end_rule)
		{
			return Attr.CreateUtils(index_reference, caller_end, end_rule);
		}

		// Token: 0x0600012E RID: 302 RVA: 0x00002954 File Offset: 0x00000B54
		internal static object RevertIndexer(int int_0)
		{
			return System.BitConverter.GetBytes(int_0);
		}

		// Token: 0x0600012F RID: 303 RVA: 0x0000295F File Offset: 0x00000B5F
		internal static long ConnectPredicate(System.IO.Stream stream_0)
		{
			return stream_0.Position;
		}

		// Token: 0x06000130 RID: 304 RVA: 0x0000296A File Offset: 0x00000B6A
		internal static void SetupPredicate(System.IntPtr intptr_0, int int_0)
		{
			System.Runtime.InteropServices.Marshal.WriteInt32(intptr_0, int_0);
		}

		// Token: 0x06000131 RID: 305 RVA: 0x00002979 File Offset: 0x00000B79
		internal static int CallPredicate(System.IntPtr asset)
		{
			return Attr.EnableUtils(asset);
		}

		// Token: 0x06000132 RID: 306 RVA: 0x00002984 File Offset: 0x00000B84
		internal static void FillPredicate(System.Collections.Hashtable hashtable_0, object object_0, object object_1)
		{
			hashtable_0.Add(object_0, object_1);
		}

		// Token: 0x06000133 RID: 307 RVA: 0x00002997 File Offset: 0x00000B97
		internal static System.Type FindPredicate(System.RuntimeTypeHandle runtimeTypeHandle_0)
		{
			return System.Type.GetTypeFromHandle(runtimeTypeHandle_0);
		}

		// Token: 0x06000134 RID: 308 RVA: 0x000029A2 File Offset: 0x00000BA2
		internal static int ReflectPredicate(long long_0)
		{
			return System.Convert.ToInt32(long_0);
		}

		// Token: 0x06000135 RID: 309 RVA: 0x000029AD File Offset: 0x00000BAD
		internal static object PostPredicate()
		{
			return System.Text.Encoding.UTF8;
		}

		// Token: 0x06000136 RID: 310 RVA: 0x000029B4 File Offset: 0x00000BB4
		internal static object SelectPredicate(System.Text.Encoding encoding_0, byte[] byte_0)
		{
			return encoding_0.GetString(byte_0);
		}

		// Token: 0x06000137 RID: 311 RVA: 0x000029C3 File Offset: 0x00000BC3
		internal static bool CustomizePredicate(System.IntPtr intptr_0, System.IntPtr intptr_1)
		{
			return intptr_0 == intptr_1;
		}

		// Token: 0x06000138 RID: 312 RVA: 0x000029D2 File Offset: 0x00000BD2
		internal static object NewPredicate(System.IntPtr init, System.Type vis)
		{
			return Attr.ReflectUtils(init, vis);
		}

		// Token: 0x06000139 RID: 313 RVA: 0x000029E1 File Offset: 0x00000BE1
		internal static System.IntPtr DefinePredicate(Attr.WriterUtils writerUtils_0)
		{
			return writerUtils_0();
		}

		// Token: 0x0600013A RID: 314 RVA: 0x000029EC File Offset: 0x00000BEC
		internal static int InterruptPredicate(System.IntPtr intptr_0)
		{
			return System.Runtime.InteropServices.Marshal.ReadInt32(intptr_0);
		}

		// Token: 0x0600013B RID: 315 RVA: 0x000029F7 File Offset: 0x00000BF7
		internal static long CreatePredicate(System.IntPtr intptr_0)
		{
			return System.Runtime.InteropServices.Marshal.ReadInt64(intptr_0);
		}

		// Token: 0x0600013C RID: 316 RVA: 0x00002A02 File Offset: 0x00000C02
		internal static System.IntPtr PushPredicate(System.Delegate delegate_0)
		{
			return System.Runtime.InteropServices.Marshal.GetFunctionPointerForDelegate(delegate_0);
		}

		// Token: 0x0600013D RID: 317 RVA: 0x00002A0D File Offset: 0x00000C0D
		internal static int ManagePredicate(ProcessModule processModule_0)
		{
			return processModule_0.ModuleMemorySize;
		}

		// Token: 0x0600013E RID: 318 RVA: 0x00002705 File Offset: 0x00000905
		internal static object PreparePredicate(System.Reflection.Assembly assembly_0)
		{
			return assembly_0.EntryPoint;
		}

		// Token: 0x0600013F RID: 319 RVA: 0x00002A18 File Offset: 0x00000C18
		internal static bool RestartPredicate(System.Reflection.MethodInfo methodInfo_0, System.Reflection.MethodInfo methodInfo_1)
		{
			return methodInfo_0 != methodInfo_1;
		}

		// Token: 0x06000140 RID: 320 RVA: 0x00002A27 File Offset: 0x00000C27
		internal static object InvokePredicate(System.Delegate delegate_0)
		{
			return delegate_0.Method;
		}

		// Token: 0x06000141 RID: 321 RVA: 0x00002A32 File Offset: 0x00000C32
		internal static object WritePredicate(System.Type type_0, System.Reflection.MethodInfo methodInfo_0)
		{
			return System.Delegate.CreateDelegate(type_0, methodInfo_0);
		}

		// Token: 0x06000142 RID: 322 RVA: 0x00002A41 File Offset: 0x00000C41
		internal static object ExcludePredicate(System.Reflection.MethodBase methodBase_0)
		{
			return methodBase_0.GetParameters();
		}

		// Token: 0x06000143 RID: 323 RVA: 0x00002A4C File Offset: 0x00000C4C
		internal static object StopPredicate(System.Reflection.Assembly assembly_0)
		{
			return assembly_0.ManifestModule;
		}

		// Token: 0x06000144 RID: 324 RVA: 0x00002A57 File Offset: 0x00000C57
		internal static System.ModuleHandle ComparePredicate(System.Reflection.Module module_0)
		{
			return module_0.ModuleHandle;
		}

		// Token: 0x06000145 RID: 325 RVA: 0x00002A62 File Offset: 0x00000C62
		internal static System.Type OrderPredicate(object object_0)
		{
			return object_0.GetType();
		}

		// Token: 0x06000146 RID: 326 RVA: 0x00002A6D File Offset: 0x00000C6D
		internal static object LoginPredicate(System.Reflection.FieldInfo fieldInfo_0, object object_0)
		{
			return fieldInfo_0.GetValue(object_0);
		}

		// Token: 0x06000147 RID: 327 RVA: 0x00002A7C File Offset: 0x00000C7C
		internal static object InitPredicate(long long_0)
		{
			return System.BitConverter.GetBytes(long_0);
		}

		// Token: 0x06000148 RID: 328 RVA: 0x00002A87 File Offset: 0x00000C87
		internal static void AwakePredicate(System.Delegate delegate_0)
		{
			System.Runtime.CompilerServices.RuntimeHelpers.PrepareDelegate(delegate_0);
		}

		// Token: 0x06000149 RID: 329 RVA: 0x00002A92 File Offset: 0x00000C92
		internal static System.RuntimeMethodHandle DisablePredicate(System.Reflection.MethodBase methodBase_0)
		{
			return methodBase_0.MethodHandle;
		}

		// Token: 0x0600014A RID: 330 RVA: 0x00002A9D File Offset: 0x00000C9D
		internal static void ReadPredicate(System.RuntimeMethodHandle runtimeMethodHandle_0)
		{
			System.Runtime.CompilerServices.RuntimeHelpers.PrepareMethod(runtimeMethodHandle_0);
		}

		// Token: 0x0600014B RID: 331 RVA: 0x00002AA8 File Offset: 0x00000CA8
		internal static void IncludePredicate(System.Array array_0, System.RuntimeFieldHandle runtimeFieldHandle_0)
		{
			System.Runtime.CompilerServices.RuntimeHelpers.InitializeArray(array_0, runtimeFieldHandle_0);
		}

		// Token: 0x0600014C RID: 332 RVA: 0x00002AB7 File Offset: 0x00000CB7
		internal static System.IntPtr DestroyPredicate(System.IntPtr reference, uint visitor, uint meanproc, uint cont2_size)
		{
			return Attr.ChangeUtils(reference, visitor, meanproc, cont2_size);
		}

		// Token: 0x0600014D RID: 333 RVA: 0x00002ACE File Offset: 0x00000CCE
		internal static void CollectPredicate(System.IntPtr intptr_0, System.IntPtr intptr_1)
		{
			System.Runtime.InteropServices.Marshal.WriteIntPtr(intptr_0, intptr_1);
		}

		// Token: 0x0600014E RID: 334 RVA: 0x0000271F File Offset: 0x0000091F
		internal static bool PrepareIndexer()
		{
			return null == null;
		}

		// Token: 0x0600014F RID: 335 RVA: 0x00002725 File Offset: 0x00000925
		internal static object RestartIndexer()
		{
			return null;
		}

		// Token: 0x0400004A RID: 74
		private static System.Collections.Generic.Dictionary<int, int> m_Annotation;

		// Token: 0x0400004B RID: 75
		private static byte[] _Class;

		// Token: 0x0400004C RID: 76
		private static System.IntPtr m_Customer;

		// Token: 0x0400004D RID: 77
		private static bool m_Facade;

		// Token: 0x0400004E RID: 78
		private static long _Record;

		// Token: 0x0400004F RID: 79
		private static bool _Val;

		// Token: 0x04000050 RID: 80
		private static int m_Rules;

		// Token: 0x04000051 RID: 81
		private static Attr.BridgeUtils _Factory;

		// Token: 0x04000052 RID: 82
		private static Attr.PredicateUtils m_Order;

		// Token: 0x04000053 RID: 83
		private static Attr.ProductUtils _Getter;

		// Token: 0x04000054 RID: 84
		internal static object @struct;

		// Token: 0x04000055 RID: 85
		private static byte[] page;

		// Token: 0x04000056 RID: 86
		internal static Attr.ParamsUtils consumer;

		// Token: 0x04000057 RID: 87
		private static System.IntPtr queue;

		// Token: 0x04000058 RID: 88
		private static string[] _Attribute;

		// Token: 0x04000059 RID: 89
		private static Attr.RoleUtils m_SingletonUtils;

		// Token: 0x0400005A RID: 90
		private static object m_Object;

		// Token: 0x0400005B RID: 91
		[Attr.ParameterUtils(typeof(Attr.ParameterUtils.DatabaseUtils<object>[]))]
		private static bool m_Instance;

		// Token: 0x0400005C RID: 92
		private static System.Collections.Generic.List<int> _Stub;

		// Token: 0x0400005D RID: 93
		private static bool m_Field = false;

		// Token: 0x0400005E RID: 94
		private static bool repository;

		// Token: 0x0400005F RID: 95
		private static object _Map;

		// Token: 0x04000060 RID: 96
		private static System.Collections.Generic.List<string> reader;

		// Token: 0x04000061 RID: 97
		private static uint[] state;

		// Token: 0x04000062 RID: 98
		private static int policy;

		// Token: 0x04000063 RID: 99
		private static System.IntPtr utilsUtils;

		// Token: 0x04000064 RID: 100
		private static int[] m_Task;

		// Token: 0x04000065 RID: 101
		private static SortedList m_Manager;

		// Token: 0x04000066 RID: 102
		internal static System.Reflection.Assembly rule = typeof(Attr).Assembly;

		// Token: 0x04000067 RID: 103
		private static int m_Merchant;

		// Token: 0x04000068 RID: 104
		private static System.IntPtr m_System;

		// Token: 0x04000069 RID: 105
		internal static Attr.ParamsUtils m_Pool;

		// Token: 0x0400006A RID: 106
		private static Attr.BaseUtils _Proc;

		// Token: 0x0400006B RID: 107
		private static int m_Tag;

		// Token: 0x0400006C RID: 108
		internal static System.Collections.Hashtable m_Schema;

		// Token: 0x0400006D RID: 109
		private static bool m_Reg;

		// Token: 0x0400006E RID: 110
		private static bool m_Issuer;

		// Token: 0x0400006F RID: 111
		private static Attr.TestUtils _Global;

		// Token: 0x04000070 RID: 112
		private static string m_AdvisorUtils;

		// Token: 0x04000071 RID: 113
		private static long specification;

		// Token: 0x04000072 RID: 114
		private static int m_Iterator;

		// Token: 0x02000017 RID: 23
		// (Invoke) Token: 0x06000151 RID: 337
		private delegate void RefUtils(object o);

		// Token: 0x02000018 RID: 24
		internal class ParameterUtils : System.Attribute
		{
			// Token: 0x06000154 RID: 340 RVA: 0x00002ADD File Offset: 0x00000CDD
			public ParameterUtils(object setup)
			{
			}

			// Token: 0x02000019 RID: 25
			internal class DatabaseUtils<T>
			{
			}
		}

		// Token: 0x0200001A RID: 26
		internal class PublisherUtils
		{
			// Token: 0x06000156 RID: 342 RVA: 0x0000A6C0 File Offset: 0x000088C0
			internal static string ReadUtils(string ident, string b)
			{
				byte[] bytes = System.Text.Encoding.Unicode.GetBytes(ident);
				byte[] key = new byte[]
				{
					82,
					102,
					104,
					110,
					32,
					77,
					24,
					34,
					118,
					181,
					51,
					17,
					18,
					51,
					12,
					109,
					10,
					32,
					77,
					24,
					34,
					158,
					161,
					41,
					97,
					28,
					118,
					181,
					5,
					25,
					1,
					88
				};
				byte[] iv = Attr.RestartSingleton(System.Text.Encoding.Unicode.GetBytes(b));
				System.IO.MemoryStream memoryStream = new System.IO.MemoryStream();
				SymmetricAlgorithm symmetricAlgorithm = Attr.TestSingleton();
				symmetricAlgorithm.Key = key;
				symmetricAlgorithm.IV = iv;
				CryptoStream cryptoStream = new CryptoStream(memoryStream, symmetricAlgorithm.CreateEncryptor(), CryptoStreamMode.Write);
				cryptoStream.Write(bytes, 0, bytes.Length);
				cryptoStream.Close();
				return System.Convert.ToBase64String(memoryStream.ToArray());
			}
		}

		// Token: 0x0200001B RID: 27
		// (Invoke) Token: 0x06000159 RID: 345
		[System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
		internal delegate uint ParamsUtils(System.IntPtr classthis, System.IntPtr comp, System.IntPtr info, [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.U4)] uint flags, System.IntPtr nativeEntry, ref uint nativeSizeOfCode);

		// Token: 0x0200001C RID: 28
		// (Invoke) Token: 0x0600015D RID: 349
		[System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
		private delegate System.IntPtr WriterUtils();

		// Token: 0x0200001D RID: 29
		internal struct ServiceUtils
		{
			// Token: 0x04000073 RID: 115
			internal bool algoUtils;

			// Token: 0x04000074 RID: 116
			internal byte[] m_CallbackUtils;
		}

		// Token: 0x0200001E RID: 30
		internal class PrototypeUtils
		{
			// Token: 0x06000160 RID: 352 RVA: 0x00002AE5 File Offset: 0x00000CE5
			public PrototypeUtils(System.IO.Stream config)
			{
				this.authenticationUtils = new System.IO.BinaryReader(config);
			}

			// Token: 0x06000161 RID: 353 RVA: 0x00002AF9 File Offset: 0x00000CF9
			internal System.IO.Stream method_0()
			{
				return this.authenticationUtils.BaseStream;
			}

			// Token: 0x06000162 RID: 354 RVA: 0x00002B06 File Offset: 0x00000D06
			internal byte[] ExcludeUtils(int sumasset)
			{
				return this.authenticationUtils.ReadBytes(sumasset);
			}

			// Token: 0x06000163 RID: 355 RVA: 0x00002B14 File Offset: 0x00000D14
			internal int CalculateUtils(byte[] info, int token_X, int previoushelper)
			{
				return this.authenticationUtils.Read(info, token_X, previoushelper);
			}

			// Token: 0x06000164 RID: 356 RVA: 0x00002B24 File Offset: 0x00000D24
			internal int DeleteUtils()
			{
				return this.authenticationUtils.ReadInt32();
			}

			// Token: 0x06000165 RID: 357 RVA: 0x00002B31 File Offset: 0x00000D31
			internal void RunUtils()
			{
				this.authenticationUtils.Close();
			}

			// Token: 0x04000075 RID: 117
			private System.IO.BinaryReader authenticationUtils;
		}

		// Token: 0x0200001F RID: 31
		// (Invoke) Token: 0x06000167 RID: 359
		[System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
		private delegate System.IntPtr TestUtils(System.IntPtr hModule, string lpName, uint lpType);

		// Token: 0x02000020 RID: 32
		// (Invoke) Token: 0x0600016B RID: 363
		[System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
		private delegate System.IntPtr BridgeUtils(System.IntPtr lpAddress, uint dwSize, uint flAllocationType, uint flProtect);

		// Token: 0x02000021 RID: 33
		// (Invoke) Token: 0x0600016F RID: 367
		[System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
		private delegate int PredicateUtils(System.IntPtr hProcess, System.IntPtr lpBaseAddress, [System.Runtime.InteropServices.In] [System.Runtime.InteropServices.Out] byte[] buffer, uint size, out System.IntPtr lpNumberOfBytesWritten);

		// Token: 0x02000022 RID: 34
		// (Invoke) Token: 0x06000173 RID: 371
		[System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
		private delegate int ProductUtils(System.IntPtr lpAddress, int dwSize, int flNewProtect, ref int lpflOldProtect);

		// Token: 0x02000023 RID: 35
		// (Invoke) Token: 0x06000177 RID: 375
		[System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
		private delegate System.IntPtr BaseUtils(uint dwDesiredAccess, int bInheritHandle, uint dwProcessId);

		// Token: 0x02000024 RID: 36
		// (Invoke) Token: 0x0600017B RID: 379
		[System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall)]
		private delegate int RoleUtils(System.IntPtr ptr);

		// Token: 0x02000025 RID: 37
		[System.Flags]
		private enum CreateContextFlags
		{

		}
	}
}
