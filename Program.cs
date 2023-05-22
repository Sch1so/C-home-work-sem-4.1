// Task 1 Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

/*
int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];

    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1);

    return array;
}

void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");

        Console.WriteLine(); 
    }
    Console.WriteLine();
}

void SortirovkaStrok(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for(int q = 1; q < array.GetLength(1); q++)
            for (int j = 0; j < array.GetLength(1) - q; j++)
            {
                if(array[i,j] < array[i,j + 1])
                {
                    int temp = array[i,j];
                    array[i,j] = array[i,j + 1];
                    array[i,j + 1] = temp;
                }
            }
}


Console.Write("Введите колличество строк = ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите колличество столбцов = ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение массива = ");
int miValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение массива = ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2dArray(rows, columns, miValue, maxValue);
Show2dArray(myArray);
SortirovkaStrok(myArray);
Show2dArray(myArray);

*/

// Task 2 
// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

/*
int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];

    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1);

    return array;
}

void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");

        Console.WriteLine(); 
    }
    Console.WriteLine();
}

int[] SerchSumRows(int[,] array)
{
    int[] sumRows = new int[array.GetLength(0)];

     for(int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            sumRows[i] += array[i,j];
    
    return sumRows;
}

int SerchMinRows(int[] array)
{
    int minElement = array[0];
    int minRow = 0;

    for (int i = 0; i < array.Length; i++)
        if(array[i] < minElement)
            minRow = i;

    return minRow;    
}

Console.Write("Введите колличество строк = ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите колличество столбцов = ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение массива = ");
int miValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение массива = ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2dArray(rows, columns, miValue, maxValue);
Show2dArray(myArray);
int[] sumArray = SerchSumRows(myArray);
int minRowArray = SerchMinRows(sumArray);

Console.WriteLine($"Минимальная сумма в строке -> {minRowArray + 1} и ее сумма = {sumArray[minRowArray]}");

*/

// Task 3 
// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

/*
int[,] CreateRandom2dArray(int rows, int columns)
{
    int[,] array = new int[rows, columns];

    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(1, 9);

    return array;
}

void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");

        Console.WriteLine(); 
    }
    Console.WriteLine();
}

void ProizvedenieMatrix(int[,] proiz, int[,] matrix1, int[,] matrix2)
{
    if(matrix1.GetLength(0) == matrix2.GetLength(1))
    {
        for (int i = 0; i < matrix1.GetLength(0); i++)
            for (int j = 0; j < matrix2.GetLength(1); j++)
                for (int q = 0; q < matrix1.GetLength(1); q++)
                    proiz[i,j] = proiz[i,j] + matrix1[i,q] * matrix2[q,j];
    
    Show2dArray(proiz);
    }
    else Console.WriteLine("Умножение матриц невозможно");
}


Console.Write("Введите колличество строк первой матрицы = ");
int rows1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите колличество столбцов первой матрицы = ");
int columns1 = Convert.ToInt32(Console.ReadLine());
int[,] matrix1 = CreateRandom2dArray(rows1, columns1);

Console.Write("Введите колличество строк второй матрицы = ");
int rows2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите колличество столбцов второй матрицы  = ");
int columns2 = Convert.ToInt32(Console.ReadLine());

int[,] matrix2 = CreateRandom2dArray(rows2, columns2);

Show2dArray(matrix1);
Show2dArray(matrix2);
int[,] proiz = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
ProizvedenieMatrix(proiz, matrix1, matrix2);
*/

// Task 4 ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу,
// которая будет построчно выводить массив, добавляя индексы каждого элемента.

/*
int[,,] myArray = new int[,,] { { {15, 23}, {44, 57} },
                                 { {73, 81}, {10, 11} } };

void Show3dArray(int[,,] array)
{
    for (int q = 0; q < array.GetLength(2); q++)
    {
        Console.WriteLine("Элемента массива страницы " + q);
        for(int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
                Console.Write($"{array[q,i,j]} ({q},{i},{j})");

            Console.WriteLine(); 
        }
        Console.WriteLine();
    }
}

Show3dArray(myArray);

*/

