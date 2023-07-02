// Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом
// столбце.

int rows = Prompt("Введите количество строк ");
int columns = Prompt("Введите количество столбцов ");
int minValue = Prompt("Введите минимальное значение элементов массива ");
int maxValue = Prompt("Введите максимальное значение элементов массива ");
int[,] array = GetArray(rows, columns, minValue, maxValue);
PrintArr(array);
CheckEvenElement(array);

int Prompt(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int[,] GetArray(int row, int column, int min, int max)
{
    int[,] result = new int[row, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            result[i, j] = new Random().Next(min, max);
        }
    }
    return result;
}

void PrintArr(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}
void CheckEvenElement(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        int count = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            count += arr[j, i];
        }
        double result = Math.Round(((double) count / arr.GetLength(0)),1);
        Console.WriteLine(result);
    }
}
