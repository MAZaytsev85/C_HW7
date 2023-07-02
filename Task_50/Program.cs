// Напишите программу, которая на вход
// принимает позиции элемента в двумерном массиве, и
// возвращает значение этого элемента или же указание,
// что такого элемента нет.



int rows = 5;
int columns = 5;
int minValue = 0;
int maxValue = 100;
int firstValue = Prompt("Введите первое значение элемента массива ");
int secondValue = Prompt("Введите второе значение элемента массива ");
int[,] array = GetArray(rows, columns, minValue, maxValue);
PrintArr(array);
CheckElement(array, firstValue, secondValue);


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

void CheckElement(int[,] arr, int first, int second)
{
    bool flag = false;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (first == i && second == j)
            {
                Console.Write($"{arr[i, j]} ");
                flag = true;
            }
        }
    }
    if (flag == false)
    {
        Console.WriteLine("Указан несуществующий элемент массива");
}
}
