﻿using System.Diagnostics;
using WarshallAlgorithm;

List<Tuple<int, float>> inputs = new List<Tuple<int, float>> {
	new (40, 0.0f),
	new (40, 0.1f),
	new (40, 0.2f),
	new (40, 0.3f),
	new (40, 0.4f),
	new (40, 0.5f),
	new (40, 0.6f),
	new (40, 0.7f),
	new (40, 0.8f),
	new (40, 0.9f),
	new (40, 1.0f),
	
	new (80, 0.0f),
	new (80, 0.1f),
	new (80, 0.2f),
	new (80, 0.3f),
	new (80, 0.4f),
	new (80, 0.5f),
	new (80, 0.6f),
	new (80, 0.7f),
	new (80, 0.8f),
	new (80, 0.9f),
	new (80, 1.0f),
	
	new (120, 0.0f),
	new (120, 0.1f),
	new (120, 0.2f),
	new (120, 0.3f),
	new (120, 0.4f),
	new (120, 0.5f),
	new (120, 0.6f),
	new (120, 0.7f),
	new (120, 0.8f),
	new (120, 0.9f),
	new (120, 1.0f),
	
	new (160, 0.0f),
	new (160, 0.1f),
	new (160, 0.2f),
	new (160, 0.3f),
	new (160, 0.4f),
	new (160, 0.5f),
	new (160, 0.6f),
	new (160, 0.7f),
	new (160, 0.8f),
	new (160, 0.9f),
	new (160, 1.0f),
	
	new (200, 0.0f),
	new (200, 0.1f),
	new (200, 0.2f),
	new (200, 0.3f),
	new (200, 0.4f),
	new (200, 0.5f),
	new (200, 0.6f),
	new (200, 0.7f),
	new (200, 0.8f),
	new (200, 0.9f),
	new (200, 1.0f)
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
