// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
void FillMatrix(int[,] matrix)
{
Random rnd = new Random();
for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int j = 0; j < matrix.GetLength(1); j++)
{
matrix[i, j] = rnd.Next(0, 11);
}
}
}

void PrintMatrix(int[,] matrix)
{
for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int j = 0; j < matrix.GetLength(1); j++)
{
System.Console.Write($"{matrix[i, j]} " + "\t");
}
System.Console.WriteLine();
}
}
System.Console.Write("Введите количество строкe массива: ");
int n = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите количество столбцов массива: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите строку массива: ");
int stroka = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите столбец массива: ");
int stolb = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[n, m];

if (stroka <=0 && stroka < n && stolb>=0&&stolb<n )
{
System.Console.WriteLine($"Значение в массиве = {matrix[n,m]}");
}
else 
{System.Console.WriteLine("  нет в массиве"); 
}
FillMatrix(matrix);
PrintMatrix(matrix);