namespace PlanarityTesting;

/// <summary>
/// Структура даних "Граф".
/// Операції над даною структурою, в контексті даного проекту,
/// відбуваються як із неорієнтованим графом
/// </summary>
public class Graph
{
	/// <summary>
	/// Список суміжності, що представляє собою
	/// масив фіксованої довжини, де кожен елемент - це
	/// список динамічної довжини,
	/// що містить номери вершин
	/// </summary>
	public List<int>[] AdjacencyList { get; private set; }

	/// <summary>
	/// Ініціалізація списку суміжності
	/// </summary>
	/// <param name="vertices">Кількість вершин</param>
	public Graph(int vertices)
	{
		AdjacencyList = new List<int>[vertices];

		for (int i = 0; i < vertices; i++)
		{
			AdjacencyList[i] = new List<int>();
		}
	}

	/// <summary>
	/// Додавання вершин до списку суміжності,
	/// щоб утворити ребро
	/// </summary>
	/// <param name="a">Номер першої вершини ребра</param>
	/// <param name="b">Номер другої вершини ребра</param>
	public void AddEdge(int a, int b)
	{
		AdjacencyList[a].Add(b);
		AdjacencyList[b].Add(a);
	}

	/// <summary>
	/// Отримання списку ребер графу
	/// </summary>
	public List<Tuple<int, int>> GetEdges()
	{
		List<Tuple<int, int>> edges = new List<Tuple<int, int>>();

		for (int i = 0; i < AdjacencyList.Length; i++)
		{
			for (int j = 0; j < AdjacencyList[i].Count; j++)
			{
				// При ребрі (0, 1) ігнорувати ребро (1, 0)
				if (edges.Contains(new Tuple<int, int>(AdjacencyList[i][j], i)))
				{
					continue;
				}

				edges.Add(new Tuple<int, int>(i, AdjacencyList[i][j]));
			}
		}

		return edges;
	}
}
