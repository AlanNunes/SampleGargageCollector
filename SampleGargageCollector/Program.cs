using SampleGargageCollector;
using System.Diagnostics;

var watch = Stopwatch.StartNew();

var calc = new Calculator();
for (var i = 0; i < 1_000_000_000; i++)
{
    calc.Sum(10, i);
}

watch.Stop();
var coletasDeLixo = GC.CollectionCount(0) + GC.CollectionCount(1) + GC.CollectionCount(2);
Console.WriteLine($"Time: {watch.ElapsedMilliseconds} ms");
Console.WriteLine($"GC: {coletasDeLixo}");