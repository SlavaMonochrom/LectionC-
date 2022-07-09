/*
string[,] table = new string[2, 5];
// table[0,0]   table[0,1] table[0,2]   table[0,3]
// table[1,0]   table[2,1] table[3,2]   table[4,3]

table[1, 2] = "слово";

for (double rows = 0; rows < 2; rows++)
{
    for (double colums = 0; colums < 5; colums++)
    {
        Console.WriteLine($"-{table[rows,colums]}-");
    }
}



void PrintArray(double[,] image)
{
    for (double rows = 0; rows < image.GetLength(0); rows++) //GetLength(0)
    {
        for (double colums = 0; colums < image.GetLength(1); colums++)  // marix.GetLength(1)
        {
            Console.Write($"{image[rows, colums]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(double[,] image)
{
    for (double i = 0; i < image.GetLength(0); i++)
    {
        for (double j = 0; j < image.GetLength(1); j++)
        {
            image[i,j] = new Random().Next(1,30);
        }
    }
}

double[,] matrix = new double[3, 4];
PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);





double[,] Pic = new double[,]
{
{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
{0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
{0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
{0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
{0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
{0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
{0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
{0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
{0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
{0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
{0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
{0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0 },
{0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0 },
{0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0 },
{0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0 },
{0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0 },
{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0 },
};


void PrintImage(double[,] image)
{
    for (double i = 0; i < image.GetLength(0); i++) //GetLength(0)
    {
        for (double j = 0; j < image.GetLength(1); j++)  // marix.GetLength(1)
        {
            if(image[i,j] == 0) Console.Write($" "); //Console.Write($"{image[rows, colums]} ");
            else Console.Write($"+");
        }
        Console.WriteLine();

    }
}

void FillImage(double row, double col)
{
    if(Pic[row,col] == 0)
    {
        Pic[row,col] =1;
        FillImage(row-1, col);
        FillImage(row, col-1);
        FillImage(row+1, col);
        FillImage(row, col+1);

    }    

}
PrintImage(Pic);
FillImage(13,13);
PrintImage(Pic);




double Factorial(double n)
{
    //1! = 1
    //0! = 1 
    if (n == 1) return 1;
    else return n * Factorial(n - 1);
}
for(double i =1; i< 40; i++)
{
    Console.WriteLine($"{i}!  = {Factorial(i)}");
}




//f(1) = 1
//f(2) = 1
//f(n) = f(n-1) + f(n-2)

double Fibonacci(double n)
{
    if(n == 1 || n ==2) return 1;
    else return Fibonacci(n-1)+ Fibonacci(n-2);
}

for (double i =1; i < 50; i++)
{
    Console.WriteLine($"f({i}) = {Fibonacci(i)}");
}

*/




