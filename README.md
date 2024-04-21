# Алгоритм Уоршелла (побудова матриці досяжності)

## Початок роботи

### Вимоги

- Встановлений [.NET 8.0](https://dotnet.microsoft.com/download/dotnet/8.0)

### Компіляція та запуск

Компіляція: `dotnet build`

Запуск: `dotnet run`

### Встановлення аргументів

Програма розрахована на виконання декількох експериментів в межах одного виконання програми.

Список вхідних параметрів для експериментів вказаний в [Program.cs](./warshall-algorithm/Program.cs), в елементах змінної `inputs`.

Змінна `inputs` - список з впорядкованих пар, де:

- перший елемент - кількість вершин у графі (натуральне число)
- другий елемент - щільність ребер (десятковий дріб від 0 до 1 включно)

> [!NOTE]
> Впорядковані елементи, пари яких не входять в потрібну область визначення, будь округлені до мінімального/максимального допустимого значення

Аргументи:

- `кількість вершин` - натуральне число
- `щільність` - десятковий дріб від 0 до 1 включно

> [!NOTE]
> `щільність` потребує значення, записане через кому. Наприклад: `0,1` (не `0.1`)
