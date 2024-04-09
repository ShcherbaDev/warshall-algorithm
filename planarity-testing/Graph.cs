namespace PlanarityTesting;

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
}
