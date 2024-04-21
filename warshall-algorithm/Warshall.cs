namespace WarshallAlgorithm;

public static class Warshall
{
	/// <summary>
	/// Повернення списку із матриць, що означають перехід
	/// від матриці суміжності до матриці досяжності
	/// </summary>
	public static List<int[,]> GetReachabilityTransitionList(int[,] adjacencyMatrix)
	{
		List<int[,]> result = [adjacencyMatrix];
		int adjacencyMatrixSize = adjacencyMatrix.GetLength(0);

		for (int k = 1; k < adjacencyMatrixSize; k++)
		{
			int[,] matrix = new int[adjacencyMatrixSize, adjacencyMatrixSize];
			int[,] previousMatrix = result[k - 1];

			for (int i = 0; i < adjacencyMatrixSize; i++)
			{
				for (int j = 0; j < adjacencyMatrixSize; j++)
				{
					matrix[i, j] = previousMatrix[i, j] == 1
						|| (previousMatrix[i, k] == 1 && previousMatrix[k, j] == 1)
						? 1 : 0;
				}
			}

			result.Add(matrix);
		}

		return result;
	}
}
