namespace PlanarityTesting;

public static class GraphGenerator
{
	public static Graph GenerateWithErdosRenyiModel(
		int numberOfVertices,
		float density
	)
	{
		// Валідація вхідних даних
		if (numberOfVertices <= 0)
		{
			throw new ArgumentException("Кількість вершин має бути більша за 0");
		}

		if (density > 1 || density < 0)
		{
			throw new ArgumentException("Щільність має бути в межах від 0 до 1");
		}

		// Ініціалізація графу
		Graph graph = new Graph(numberOfVertices);

		// Ініціалізація рандомайзера
		Random random = new Random();

		// Створення усіх можливих ребер
		List<Tuple<int, int>> edgeCombinations = new List<Tuple<int, int>>();
		for (int i = 0; i < graph.Vertices.Count; i++)
		{
			for (int j = i + 1; j < graph.Vertices.Count; j++)
			{
				edgeCombinations.Add(
					new Tuple<int, int>(graph.Vertices[i], graph.Vertices[j])
				);
			}
		}

		// З'єднання вершин випадковим чином
		foreach (Tuple<int, int> edge in edgeCombinations)
		{
			if (random.NextDouble() >= density) continue;
			graph.AddEdge(edge);
		}

		return graph;
	}
}
