using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(VectorMath.Magnitude(new double[] {3, 9}));       // 9.49
        Console.WriteLine(VectorMath.Magnitude(new double[] {7, -3, -9}));  // 11.79
        Console.WriteLine(VectorMath.Magnitude(new double[] {1, 2, 3, 4})); // -1
    }
}