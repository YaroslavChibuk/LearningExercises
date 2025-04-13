class MaxCliqueFinder
{
    private Dictionary<int, HashSet<int>> graph = new();

    public void AddEdge(int u, int v)
    {
        if (!graph.ContainsKey(u)) graph[u] = new HashSet<int>();
        if (!graph.ContainsKey(v)) graph[v] = new HashSet<int>();
        graph[u].Add(v);
        graph[v].Add(u);
    }

    public List<HashSet<int>> FindMaxCliques()
    {
        var cliques = new List<HashSet<int>>();
        var R = new HashSet<int>();
        var P = new HashSet<int>(graph.Keys);
        var X = new HashSet<int>();

        BronKerbosch(R, P, X, cliques);
        return cliques;
    }

    private void BronKerbosch(HashSet<int> R, HashSet<int> P, HashSet<int> X, List<HashSet<int>> cliques)
    {
        if (P.Count == 0 && X.Count == 0)
        {
            cliques.Add(new HashSet<int>(R));
            return;
        }

        foreach (var v in P.ToList())
        {
            var newR = new HashSet<int>(R) { v };
            var newP = new HashSet<int>(P.Intersect(graph[v]));
            var newX = new HashSet<int>(X.Intersect(graph[v]));
            BronKerbosch(newR, newP, newX, cliques);
            P.Remove(v);
            X.Add(v);
        }
    }

    public HashSet<int> GetMaximumClique()
    {
        var cliques = FindMaxCliques();
        return cliques.OrderByDescending(c => c.Count).FirstOrDefault();
    }
}
