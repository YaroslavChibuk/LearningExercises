using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var finder = new MaxCliqueFinder();

        // Пример графа: вершины 0-5
        finder.AddEdge(0, 1);
        finder.AddEdge(0, 2);
        finder.AddEdge(1, 2);
        finder.AddEdge(1, 3);
        finder.AddEdge(2, 3);
        finder.AddEdge(3, 4);
        finder.AddEdge(4, 5);

        var maxClique = finder.GetMaximumClique();

        Console.WriteLine("Max clique is: ");
        Console.WriteLine(string.Join(", ", maxClique));
    }
}
