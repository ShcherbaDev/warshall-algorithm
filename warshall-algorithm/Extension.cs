using System.Text;

namespace WarshallAlgorithm;

public static class Extension
{
	/// <summary>
	/// Вивід двовимірного масиву як рядка.
	/// Використовується як відображення матриці суміжності графу
	/// </summary>
	public static string TwoDimensionalArrayToString(this int[,] arr)
	{
		StringBuilder stringBuilder = new StringBuilder();

		int[] rowsRange = Enumerable.Range(0, arr.GetLength(1)).ToArray();
		int[] columnsRange = Enumerable.Range(0, arr.GetLength(0)).ToArray();

		stringBuilder.AppendLine($"    {string.Join("\t", columnsRange)}");

		for (int i = 0; i < arr.GetLength(0); i++)
		{
			stringBuilder.Append($"{rowsRange[i]} | ");
			for (int j = 0; j < arr.GetLength(1); j++)
			{
				stringBuilder.Append(arr[i, j] + "\t");
			}
			stringBuilder.AppendLine();
		}

		return stringBuilder.ToString();
	}
}
