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
    fillMatrix(array, rows, columns);
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
    fillMatrix(array, rows, columns);
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

void fillMatrix(int[,] array, int row, int col)
{
    Random rand = new Random();

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            array[i, j] = rand.Next(1, 21);
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

// MatrixOrigNumbers();
// FindElement();
AverageNumber();