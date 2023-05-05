using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using EnsureThat;
using Ensure6 = EnsureArgVI.EnsureArgFluent;

namespace Benchmarks
{
	internal static class Program
	{
		static void Main()
		{
			BenchmarkRunner.Run<EnsureArgBenchmark>();
			BenchmarkRunner.Run<FluentBenchmark>();
		}
	}

	public class EnsureArgBenchmark
	{
		[Params(10, 100, 1_000)]
		public int Times { get; set; }

		[Benchmark(Baseline = true)]
		public void EnsureAllRight()
		{
			int? param = 5;
			EnsureArg.IsNotNull(param, nameof(param));
		}
	}

	public class FluentBenchmark
	{
		[Params(10, 100, 1_000)]
		public int Times { get; set; }

		[Benchmark(Baseline = true)]
		public void EnsureAllRight()
		{
			Ensure6.Arg(5).IsNotNull();
		}
	}
}