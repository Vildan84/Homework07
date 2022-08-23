void MatrixOrigNumbers() // Задача 47 
{
    Random rand = new Random();
    int rows = rand.Next(4, 8);
    int columns = rand.Next(4, 8);
    double[,] array = new double[rows, columns];
    FillMatrixOrigNumber(array, rows, columns);
    PrintMatrixOrigNumber(array);
}

void FindElement() // Задача 50
{
    Random rand = new Random();
    int rows = rand.Next(4, 8);
    int columns = rand.Next(4, 8);
    int[,] array = new int[rows, columns];
    fillMatrix(array, rows, columns, -9, 20);
    PrintMatrix(array);
    Console.WriteLine("Enter row number: ");
    int row = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter column number: ");
    int col = Convert.ToInt32(Console.ReadLine());    

    if (row > rows || col > columns)
    {
        Console.WriteLine("Cell is empty");
    }

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            if (i == row && j == col)
            {
                Console.WriteLine($"Result = {array[i, j]}"); 
            }
        }
    }
}

void AverageNumber() // Задача 52
{
    Random rand = new Random();
    int rows = rand.Next(4, 8);
    int columns = rand.Next(4, 8);
    int[,] array = new int[rows, columns];
    fillMatrix(array, rows, columns, 1, 10);
    PrintMatrix(array);
    double[] resArray = new double[columns];
    
    for (int j = 0; j < columns; j++)
    {
        int sum = 0;
        for (int i = 0; i < rows; i++)
        {
            sum = sum + array[i, j];
            
        }
        resArray[j] = sum / rows;
    }
    Console.WriteLine("Среднее арифметичское по столбцам");
    PrintArrayDouble(resArray);
}

void WhatBigger()
{
    int rows = 3;
    int columns = 4;
    int[,] array = new int[rows, columns];
    fillMatrix(array, rows, columns, 100, 9999);
    PrintMatrix(array);
    int[] resArray = new int[rows * columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            int sum = SumOfDigits(array[i, j]);
            int mul = MultiplyDigits(array[i, j]);
            if (sum > mul) resArray[i] = array[i, j];
        }
    }
    PrintArray(resArray);
}

void FindTheWay()
{
    int rows = 5;
    int columns = 5;
    int[,] array = new int[rows, columns];
    fillMatrix(array, rows, columns, 0, 2);
    array[0, 0] = 1;
    array[4, 4] = 1;
    PrintMatrix(array);
    Change(array, 0, 0, rows, columns);
    PrintMatrix(array);

    if (array[4, 4] == 9)
    {
        Console.WriteLine("Array has way");
    }
    else Console.WriteLine("There's NO way");  
}

void Change(int[,] arr, int i, int j, int row, int col)
{
    if (i < 0 || i >= row || j < 0 || j >= col)
    {
        return;
    }
    if (arr[i, j] != 1 )
    {
        return;
    }
    arr[i, j] = 9;

    Change(arr, i, j + 1, row, col);
    Change(arr, i - 1, j, row, col);
    Change(arr, i, j - 1, row, col);
    Change(arr, i + 1, j, row, col);
}

void MatrixMultiply()
{
    Random rand = new Random();
    int rows = rand.Next(3, 5);
    int columns = rand.Next(3, 5);
    int[,] array = new int[rows, columns];
    int[,] matrix = new int[rows, columns];
    fillMatrix(array, rows, columns, -9, 9);
    fillMatrix(matrix, rows, columns, -9, 9);
    PrintMatrix(array);
    PrintMatrix(matrix);
    int row = array.GetLength(0);
    int col = matrix.GetLength(1);
    int[,] resMatrix = new int[row, col];

    if (row == col)
    {
        for(int i = 0; i < row; i++)
        {
                        
            for(int j = 0; j < col; j++)
            {
                for (int k = 0; k < col; k++)
                {
                    resMatrix[i, j]  += array[i, k] * matrix[k, j];
                }
            }
        }
        Console.WriteLine("Result matrix: ");
        PrintMatrix(resMatrix);
    }
    else Console.WriteLine("Matrix can't multiply");
    
}

void PrintArrayDouble(double[] col)

{
    int count = col.Length;
    int position = 0;
    Console.Write("[");
    while(position < count)
    {
        Console.Write($"{Math.Round(col[position], 2)}, ");
        position++;
    }
    Console.Write("\b\b]");
    Console.WriteLine();
}

void FillMatrixOrigNumber(double[,] array, int row, int col)
{
    Random rand = new Random();

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            array[i, j] = rand.Next(-10, 21) + rand.NextDouble() * 10;
        }
    }
}

void PrintMatrixOrigNumber(double[,] matrix)
{
    int rowSize = matrix.GetLength(0);
    int colSize = matrix.GetLength(1);
    for (int i = 0; i < rowSize; i++)
    {
        Console.Write("[");
        for (int j = 0; j < colSize; j++)
        {
        Console.Write($"{Math.Round(matrix[i, j], 1)}, \t");
        }
        Console.WriteLine("\b\b]");
    }
    Console.WriteLine();
}

void fillMatrix(int[,] array, int row, int col, int start, int end)
{
    Random rand = new Random();

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            array[i, j] = rand.Next(start, end);
        }
    }
}

void fillMatrixInOrder(int[,] array, int row, int col)
{
    int k = 0;
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            array[i, j] = k;
            k++;
        }
    }
}

void PrintMatrix(int[,] matrix)
{
    int rowSize = matrix.GetLength(0);
    int colSize = matrix.GetLength(1);
    for (int i = 0; i < rowSize; i++)
    {
        Console.Write("[");
        for (int j = 0; j < colSize; j++)
        {
        Console.Write($"{matrix[i, j]}, \t");
        }
        Console.WriteLine("\b\b]");
    }
    Console.WriteLine();
}

int SumOfDigits(int number)
{
    double log = Math.Log10(number);
    double count = Math.Floor(log) + 1;
    int sum = 0;

    for (int i = 0; i < count; i++)
    {
        sum += number % 10;
        number = number / 10;
    }
    return sum;
}

int MultiplyDigits(int number)
{
    double log = Math.Log10(number);
    double count = Math.Floor(log) + 1;
    int multiply = 1;

    for (int i = 0; i < count; i++)
    {
        multiply *= number % 10;
        number = number / 10;
    }
    return multiply;
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    Console.Write("[");
    while(position < count)
    {
        Console.Write($"{col[position]},");
        position++;
    }
    Console.Write("\b]");
    Console.WriteLine();
}

// MatrixOrigNumbers();
// FindElement();
// AverageNumber();
// MatrixMultiply();
// WhatBigger();
FindTheWay();