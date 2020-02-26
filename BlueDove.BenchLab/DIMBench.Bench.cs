using System;
using BenchmarkDotNet.Attributes;

namespace BlueDove.BenchLab
{
    public class DIMBenchAdd
	{
		interface INonDim
		{
			int Add(int x, int y);
		}

		interface IDim
		{
			int Add(int x, int y);
			int AddDim(int x, int y) => x + y;
		}

		interface IOverridedDim : IDim
        {
            abstract int IDim.AddDim(int x, int y);
        }

		static int NonDimAdd<T>(T ins, int x, int y) where T : INonDim => ins.Add(x, y);
		static int DimNonDimAdd<T>(T ins, int x, int y) where T : IDim => ins.Add(x, y);
		static int DimDimAdd<T>(T ins, int x, int y) where T : IDim => ins.AddDim(x, y);

		int x;
		int y;
		int res;
		class NonDimclass : INonDim
		{
			public int Add(int x, int y) => x + y;
		}
		
		NonDimclass NonDimclass_Instance;

		[Benchmark]
		public void NonDimclass_NonDimAdd()
		{
			res = NonDimAdd(NonDimclass_Instance, x, y);
		}


		struct NonDimstruct : INonDim
		{
			public int Add(int x, int y) => x + y;
		}
		
		NonDimstruct NonDimstruct_Instance;

		[Benchmark]
		public void NonDimstruct_NonDimAdd()
		{
			res = NonDimAdd(NonDimstruct_Instance, x, y);
		}


		class Dimclass : IDim
		{
			public int Add(int x, int y) => x + y;
		}
		
		Dimclass Dimclass_Instance;

		[Benchmark]
		public void Dimclass_NonDimAdd()
		{
			res = DimNonDimAdd(Dimclass_Instance, x, y);
		}

		[Benchmark]
		public void Dimclass_DimAdd()
		{
			res = DimDimAdd(Dimclass_Instance, x, y);
		}

		struct Dimstruct : IDim
		{
			public int Add(int x, int y) => x + y;
		}
		
		Dimstruct Dimstruct_Instance;

		[Benchmark]
		public void Dimstruct_NonDimAdd()
		{
			res = DimNonDimAdd(Dimstruct_Instance, x, y);
		}

		[Benchmark]
		public void Dimstruct_DimAdd()
		{
			res = DimDimAdd(Dimstruct_Instance, x, y);
		}

		class DimOverrideclass : IDim
		{
			public int Add(int x, int y) => x + y;
			public int AddDim(int x, int y) => x + y;
		}
		
		DimOverrideclass DimOverrideclass_Instance;

		[Benchmark]
		public void DimOverrideclass_NonDimAdd()
		{
			res = DimNonDimAdd(DimOverrideclass_Instance, x, y);
		}

		[Benchmark]
		public void DimOverrideclass_DimAdd()
		{
			res = DimDimAdd(DimOverrideclass_Instance, x, y);
		}

		struct DimOverridestruct : IDim
		{
			public int Add(int x, int y) => x + y;
			public int AddDim(int x, int y) => x + y;
		}
		
		DimOverridestruct DimOverridestruct_Instance;

		[Benchmark]
		public void DimOverridestruct_NonDimAdd()
		{
			res = DimNonDimAdd(DimOverridestruct_Instance, x, y);
		}

		[Benchmark]
		public void DimOverridestruct_DimAdd()
		{
			res = DimDimAdd(DimOverridestruct_Instance, x, y);
		}


		[GlobalSetup]
		public void SetUp()
		{
			var random = new Random();
			x = random.Next();
			y = random.Next();
			NonDimclass_Instance = new NonDimclass();
			NonDimstruct_Instance = new NonDimstruct();
			Dimclass_Instance = new Dimclass();
			Dimstruct_Instance = new Dimstruct();
			DimOverrideclass_Instance = new DimOverrideclass();
			DimOverridestruct_Instance = new DimOverridestruct();
		}
	}
}