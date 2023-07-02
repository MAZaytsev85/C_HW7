// Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.


int rows = Prompt("Введите количество строк ");
int columns = Prompt("Введите количество столбцов ");
int minValue = Prompt("Введите минимальное значение элементов массива ");
int maxValue = Prompt("Введите максимальное значение элементов массива ");
double[,] array = GetArray(rows, columns, minValue, maxValue);
PrintArr(array);


int Prompt(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

double[,] GetArray(int row, int column, int min, int max)
{
    double[,] result = new double[row, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            result[i, j] = Math.Round((new Random().Next(min, max) + new Random().NextDouble()), 2);
        }
    }
    return result;
}

void PrintArr(double[,] arr)
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
