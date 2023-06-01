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

System.Console.Write("Введите строкe массива: ");
int stroka = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите столбtw массива: ");
int stolb = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[5, 6];

if (stroka < matrix.GetLength(0)||stolb<matrix.GetLength(1)) System.Console.WriteLine(matrix[stroka,stolb]);
else System.Console.WriteLine($"{stroka}{stolb} такого числа нет в массиве"); 
FillMatrix(matrix);
PrintMatrix(matrix);