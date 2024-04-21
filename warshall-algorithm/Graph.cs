namespace WarshallAlgorithm;

/// <summary>
/// Структура даних "Граф".
/// Операції над даною структурою, в контексті даного проекту,
/// відбуваються як із неорієнтованим незваженим графом,
/// без петель та кратних ребер
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
		// Повернення помилки, якщо здійснена спроба додати петлю або кратне ребро
		if (Edges.Any(x => (x.Item1 == edge.Item1 && x.Item2 == edge.Item2) || (x.Item1 == edge.Item2 && edge.Item2 == edge.Item1)))
		{
			throw new ArgumentException("В межах даного проєкту, граф не може бути із кратними ребрами або петлями");
		}
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
