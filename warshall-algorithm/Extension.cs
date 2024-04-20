namespace WarshallAlgorithm;

public static class Extension
{
	/// <summary>
	/// Вивід двовимірного масиву в консоль.
	/// Використовується як відображення матриці суміжності графу
	/// </summary>
	public static void PrintTwoDimensionalArray(this int[,] arr)
	{
		int[] rowsRange = Enumerable.Range(0, arr.GetLength(1)).ToArray();
		int[] columnsRange = Enumerable.Range(0, arr.GetLength(0)).ToArray();
		Console.WriteLine($"    {string.Join("\t", columnsRange)}");
		for (int i = 0; i < arr.GetLength(0); i++)
		{
			Console.Write($"{rowsRange[i]} | ");
			for (int j = 0; j < arr.GetLength(1); j++)
			{
				Console.Write(arr[i, j] + "\t");
			}
			Console.Write("\n");
		}
	}
}
