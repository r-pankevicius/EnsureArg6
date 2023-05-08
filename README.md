# EnsureArg6
EnsureArg without nameof.

## Performance of EnsureArgFluent is poor (but stable)
I suspect it's because of `new Int32Assure(value, paramName)` allocation.

### Benchmarks.EnsureArgBenchmark
|         Method | Times |      Mean |     Error |    StdDev |    Median | Ratio | RatioSD |
|--------------- |------ |----------:|----------:|----------:|----------:|------:|--------:|
| **EnsureAllRight** |    **10** | **0.2135 ns** | **0.0566 ns** | **0.1660 ns** | **0.1674 ns** |     **?** |       **?** |
|                |       |           |           |           |           |       |         |
| **EnsureAllRight** |   **100** | **0.1256 ns** | **0.0512 ns** | **0.1509 ns** | **0.0606 ns** |     **?** |       **?** |
|                |       |           |           |           |           |       |         |
| **EnsureAllRight** |  **1000** | **0.0000 ns** | **0.0000 ns** | **0.0000 ns** | **0.0000 ns** |     **?** |       **?** |

### Benchmarks.FluentBenchmark
|         Method | Times |     Mean |     Error |    StdDev | Ratio |
|--------------- |------ |---------:|----------:|----------:|------:|
| **EnsureAllRight** |    **10** | **7.860 ns** | **0.0603 ns** | **0.0471 ns** |  **1.00** |
|                |       |          |           |           |       |
| **EnsureAllRight** |   **100** | **7.706 ns** | **0.0565 ns** | **0.0529 ns** |  **1.00** |
|                |       |          |           |           |       |
| **EnsureAllRight** |  **1000** | **7.799 ns** | **0.1482 ns** | **0.2856 ns** |  **1.00** |
