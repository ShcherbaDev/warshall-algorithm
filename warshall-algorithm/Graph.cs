namespace WarshallAlgorithm;

/// <summary>
/// Структура даних "Граф".
/// Операції над даною структурою, в контексті даного проекту,
/// відбуваються як із неорієнтованим графом.
/// </summary>
public class Graph
{
	/// <summary>
	/// Список із вершинами графу.
	/// Кожна вершина помічається числом
	/// </summary>
	public List<int> Vertices { get; private set; } = new List<int>();

	/// <summary>
	/// Список із ребрами графу
	/// </summary>
	public List<Tuple<int, int>> Edges { get; private set; } = new List<Tuple<int, int>>();

	/// <summary>
	/// Заповнення списку вершин
	/// </summary>
	public Graph(int vertices)
	{
		Vertices.AddRange(Enumerable.Range(0, vertices));
	}

	/// <summary>
	/// Додавання ребра до списку з ребрами
	/// </summary>
	/// <param name="edge">Невпорядкована пара вершин, які з'єднані ребром</param>
	public void AddEdge(Tuple<int, int> edge)
	{
		// ? Що робити із можливими кратними ребрами?

		Edges.Add(edge);
	}

	/// <summary>
	/// Повертання матриці суміжності даного графу
	/// Повертає двовимірний масив із 0 та 1, де
	/// перший вимір - рядки, другий - колонки 
	/// </summary>
	public int[,] GetAdjacencyMatrix()
	{
		int[,] matrix = new int[Vertices.Count, Vertices.Count];

		for (int i = 0; i < Vertices.Count; i++)
		{
			for (int j = 0; j < Vertices.Count; j++)
			{
				matrix[i, j] = Edges.Any(v => (v.Item1 == i && v.Item2 == j) || (v.Item1 == j && v.Item2 == i)) ? 1 : 0;
			}
		}

		return matrix;
	}
}
