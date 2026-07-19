using System;

class Program
{
    static void Main(string[] args)
    {
        double[] r1 = VectorMath.Add(new double[] {8, -11}, new double[] {-4, 9});
        Console.WriteLine(string.Join(", ", r1));  // 4, -2

        double[] r2 = VectorMath.Add(new double[] {14, -2, 0}, new double[] {-3, 23, 50});
        Console.WriteLine(string.Join(", ", r2));  // 11, 21, 50

        double[] r3 = VectorMath.Add(new double[] {1, 2}, new double[] {1, 2, 3});
        Console.WriteLine(string.Join(", ", r3));  // -1
    }
}