using System;
using System.Reflection;

namespace NET.Internal
{
	// Token: 0x02000014 RID: 20
	internal class Tokenizer
	{
		// Token: 0x060000A8 RID: 168 RVA: 0x000075FC File Offset: 0x000057FC
		internal static void CreateIndexer(int typemdt)
		{
			System.Type type = Tokenizer.m_Property.ResolveType(33554432 + typemdt);
			foreach (System.Reflection.FieldInfo fieldInfo in type.GetFields())
			{
				System.Reflection.MethodInfo method = (System.Reflection.MethodInfo)Tokenizer.m_Property.ResolveMethod(fieldInfo.MetadataToken + 100663296);
				fieldInfo.SetValue(null, (System.MulticastDelegate)System.Delegate.CreateDelegate(type, method));
			}
		}

		// Token: 0x04000049 RID: 73
		internal static System.Reflection.Module m_Property = typeof(Tokenizer).Assembly.ManifestModule;

		// Token: 0x02000015 RID: 21
		// (Invoke) Token: 0x060000AC RID: 172
		internal delegate void Mapping(object o);
	}
}
