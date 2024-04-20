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

	// TODO: зробити відображення через список і матрицю суміжності
}
