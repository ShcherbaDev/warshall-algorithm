using System.Diagnostics;
using WarshallAlgorithm;

List<Tuple<int, float>> inputs = new List<Tuple<int, float>>() {
	new Tuple<int, float>(5, 0.4f),
	new Tuple<int, float>(59, 0.6f),
	new Tuple<int, float>(20, 0.2f),
	new Tuple<int, float>(20, 0.33f),
};

for (int i = 0; i < inputs.Count; i++)
{
	Tuple<int, float> algorithmInput = inputs[i];
	int numberOfVertices = Math.Clamp(algorithmInput.Item1, 1, int.MaxValue);
	float density = Math.Clamp(algorithmInput.Item2, 0, 1);

	Console.WriteLine($"--------------------------");
	Console.WriteLine($"Експеримент номер {i + 1}");

	Console.WriteLine($"Кількість вершин: {numberOfVertices}\nЩільність: {density} ({Math.Round(density * 100, 2)}%)");

	// Створення графу та його матриці суміжності
	Graph randomGraph = GraphGenerator.GenerateWithErdosRenyiModel(
		numberOfVertices,
		density
	);

	Console.WriteLine($"Кількість згенерованих ребер: {randomGraph.Edges.Count}");

	int[,] adjacencyMatrix = randomGraph.GetAdjacencyMatrix();

	// Виконання алгоритму та замір часу
	var timer = new Stopwatch();
	timer.Start();

	List<int[,]> reachabilityTransitionList = Warshall.GetReachabilityTransitionList(adjacencyMatrix);

	timer.Stop();
	Console.WriteLine($"Час виконання алгоритму: {timer.Elapsed.TotalMilliseconds} мс.");

	Console.WriteLine($"Матриці досяжності: від W0 до W{reachabilityTransitionList.Count}");

	// foreach (int[,] matrix in reachabilityTransitionList)
	// {
	// 	matrix.PrintTwoDimensionalArray();
	// 	Console.WriteLine();
	// };
}
