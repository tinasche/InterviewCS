var someString = "this is a simple string to test with!";

Console.WriteLine(someString);

var someInts = Enumerable.Range(1, 10).ToArray<int>();
for (int i = 0; i < someInts.Length; i++)
{
    Console.WriteLine(someInts[i]);
}
