using PlanarityTesting;

// Програма приймає 2 обов'язкові аргументи командного рядка на вхід:
// кількість вершин та щільність.
// Якщо ці аргументи не задані користувачем, то повертається помилка
if (args.Length != 2)
{
	Console.WriteLine("Невалідні аргументи: відсутні параметри кількості вершин та щільності");
	return;
}

// Обробка аргументів командного рядка та перевірка на відповідний тип даних
// ВАЖЛИВО: аргумент density треба записувати через кому, тобто 0,1 (не 0.1)
if (
	!int.TryParse(args[0], out int numberOfVertices)
	|| !float.TryParse(args[1], out float density)
)
{
	Console.WriteLine("Невалідні аргументи: не вдалося обробити параметри кількості вершин та (або) щільності");
	return;
}

Console.WriteLine($"Кількість вершин: {numberOfVertices}\nЩільність: {density} ({density * 100}%)");

Graph randomGraph = GraphGenerator.GenerateWithErdosRenyiModel(
	numberOfVertices,
	density
);

Console.WriteLine($"Кількість згенерованих ребер: {randomGraph.GetEdges().Count}");
