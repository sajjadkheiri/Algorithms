using Algorithms.TwoSum;

var a = new TwoSum();

var res = a.Calculate(new []{2,3,5,7},9);

foreach (var i in res)
{
    Console.WriteLine("Result: {0}", i);
}