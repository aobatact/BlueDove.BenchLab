using System;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Attributes.Jobs;
using BenchmarkDotNet.Jobs;
namespace BlueDove.BenchLab
{
    [ShortRunJob]
	public class Constructor
	{
		class C0
		{
		}

		[Benchmark]
		public void BC0()
		{
			GC.KeepAlive(new C0());
		}

		class C1
		{
			void M0(){}
		}

		[Benchmark]
		public void BC1()
		{
			GC.KeepAlive(new C1());
		}

		class C2
		{
			void M0(){}
			void M1(){}
		}

		[Benchmark]
		public void BC2()
		{
			GC.KeepAlive(new C2());
		}

		class C3
		{
			void M0(){}
			void M1(){}
			void M2(){}
		}

		[Benchmark]
		public void BC3()
		{
			GC.KeepAlive(new C3());
		}

		class C4
		{
			void M0(){}
			void M1(){}
			void M2(){}
			void M3(){}
		}

		[Benchmark]
		public void BC4()
		{
			GC.KeepAlive(new C4());
		}

		class C5
		{
			void M0(){}
			void M1(){}
			void M2(){}
			void M3(){}
			void M4(){}
		}

		[Benchmark]
		public void BC5()
		{
			GC.KeepAlive(new C5());
		}

		struct S0
		{
		}

		[Benchmark]
		public void BS0()
		{
			GC.KeepAlive(new S0());
		}

		struct S1
		{
			void M0(){}
		}

		[Benchmark]
		public void BS1()
		{
			GC.KeepAlive(new S1());
		}

		struct S2
		{
			void M0(){}
			void M1(){}
		}

		[Benchmark]
		public void BS2()
		{
			GC.KeepAlive(new S2());
		}

		struct S3
		{
			void M0(){}
			void M1(){}
			void M2(){}
		}

		[Benchmark]
		public void BS3()
		{
			GC.KeepAlive(new S3());
		}

		struct S4
		{
			void M0(){}
			void M1(){}
			void M2(){}
			void M3(){}
		}

		[Benchmark]
		public void BS4()
		{
			GC.KeepAlive(new S4());
		}

		struct S5
		{
			void M0(){}
			void M1(){}
			void M2(){}
			void M3(){}
			void M4(){}
		}

		[Benchmark]
		public void BS5()
		{
			GC.KeepAlive(new S5());
		}

	}
}