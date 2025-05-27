// Project: StructVsClass
// Using class vs struct in C#

// In C#, classes are reference types, while structs are value types.
// This means that when you create a class instance, it is stored on the heap, and when you create a struct instance, it is stored on the stack.
// Classes support inheritance, while structs do not.
// Classes can have destructors, while structs cannot.
// Classes can be null, while structs cannot.
// Structs are generally more efficient for small data structures, while classes are more efficient for larger data structures.
// Classes are more flexible and can be used for more complex data structures, while structs are more efficient for simple data structures.
// Classes are generally used for objects that have a lot of behavior, while structs are used for objects that are primarily data.
// Classes are generally used for objects that are expensive to create, while structs are used for objects that are inexpensive to create.
// Classes are generally used for objects that are expensive to copy, while structs are used for objects that are inexpensive to copy.
// Classes are generally used for objects that are expensive to compare, while structs are used for objects that are inexpensive to compare.
// Classes are generally used for objects that are expensive to serialize, while structs are used for objects that are inexpensive to serialize.
// Classes are generally used for objects that are expensive to deserialize, while structs are used for objects that are inexpensive to deserialize.
// Classes are generally used for objects that are expensive to marshal, while structs are used for objects that are inexpensive to marshal.

// Classes are generally used for objects that are expensive to unmarshal, while structs are used for objects that are inexpensive to unmarshal.

// Classes are generally used for objects that are expensive to clone, while structs are used for objects that are inexpensive to clone.
// Classes are generally used for objects that are expensive to copy to the heap, while structs are used for objects that are inexpensive to copy to the heap.
// Classes are generally used for objects that are expensive to copy to the stack, while structs are used for objects that are inexpensive to copy to the stack.
// Classes are generally used for objects that are expensive to copy to the CPU cache, while structs are used for objects that are inexpensive to copy to the CPU cache.



Func<int, int, int> add = (a, b) => a + b;
var v = add(1, 2);


var b = add;

int add2(int a, int b)
{
    return a + b;
}

var c = add2;



Console.WriteLine(v);

/*
int a = 40;
var res = Factorial(a);
Console.WriteLine(res);
int Factorial(int n)
{
    return n ==0 
        ? 1 
        : n * Factorial(n - 1);
}
*/

/*await Task.Run(() => Test1());
void Test1()
{
    const int iterations = 10000000;
    var watch = System.Diagnostics.Stopwatch.StartNew();
    // Using class
    var classList = new List<Point>();
    for (int i = 0; i < iterations; i++)
    {
        classList.Add(new Point(i, i));
    }

    watch.Stop();

    Console.WriteLine($"Class time: {watch.ElapsedMilliseconds} ms");
    watch.Restart();
    // Using struct
    var structList = new List<PointStruct>();
    for (int i = 0; i < iterations; i++)
    {
        structList.Add(new PointStruct(i, i));
    }

    watch.Stop();
    Console.WriteLine($"Struct time: {watch.ElapsedMilliseconds} ms");
}

class Point
{
    public int X { get; set; }
    public int Y { get; set; }
    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }
}

struct PointStruct
{
    public int X { get; set; }
    public int Y { get; set; }
    public PointStruct(int x, int y)
    {
        X = x;
        Y = y;
    }
}
*/