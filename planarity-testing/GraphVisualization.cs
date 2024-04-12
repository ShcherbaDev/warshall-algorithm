namespace PlanarityTesting;

// TODO: реалізувати візуалізацію графу за кодом Mermaid. Якщо неможливо - знайти інший спосіб візуалізації графу
public static class GraphVisualization
{
	/// <summary>
	/// Перетворення списку ребер графу на код Mermaid (https://mermaid.js.org).
	/// Проект розрахований на роботу із неорієнтованими графами,
	/// тому код поєднує вершини лінією без стрілки
	/// </summary>
	/// <param name="graphEdges">Ребра графу</param>
	public static string GetMermaidCode(List<Tuple<int, int>> graphEdges)
	{
		string edgesStringified = string.Join(
			"\n",
			graphEdges.Select((it) => $"{it.Item1} --- {it.Item2}")
		);
		return $"flowchart TD;\n{edgesStringified}";
	}
}
