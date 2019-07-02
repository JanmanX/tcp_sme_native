using System;
using System.Runtime.InteropServices;

namespace tcp_sme_native
{
	class Program
	{
		[NativeCallable(EntryPoint = "add", CallingConvention = CallingConvention.StdCall)]
		public static int Add(int a, int b)
		{
			return a + b;
		}

	}
}
