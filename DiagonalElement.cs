using System;

class DiagonalElement
{
    static int productDiagonals(int[,] arr, int n)
    {
        int product = 1;
        for (int i = 0; i < n; i++) 
        {
            product = product * arr[i, i];
            
            product = product * arr[i, n - i - 1];
        }
        
        
        if (n % 2 == 1)
        {
            product = product / arr[n / 2, n / 2];
        }
        
        return product;
    }

    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the size of the matrix:");
        int n = int.Parse(Console.ReadLine());

        int[,] arr = new int[n, n];

        Console.WriteLine("Enter the elements of the matrix:");

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                arr[i, j] = int.Parse(Console.ReadLine());
            }
        }
        Console.WriteLine("Product of diagonals: " + productDiagonals(arr, n));
    }
}
