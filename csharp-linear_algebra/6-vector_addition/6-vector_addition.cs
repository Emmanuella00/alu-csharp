using System;

/// <summary>Provides vector math operations.</summary>
public class VectorMath
{
    /// <summary>Adds two vectors and returns the resulting vector.</summary>
    /// <param name="vector1">The first vector (2D or 3D).</param>
    /// <param name="vector2">The second vector (2D or 3D).</param>
    /// <returns>
    /// The resulting vector, or a vector containing -1 if either vector
    /// is not 2D or 3D, or if the vectors are not of the same size.
    /// </returns>
    public static double[] Add(double[] vector1, double[] vector2)
    {
        // Rule 1: each vector must be 2D or 3D
        if (vector1.Length != 2 && vector1.Length != 3)
            return new double[] { -1 };
        if (vector2.Length != 2 && vector2.Length != 3)
            return new double[] { -1 };

        // Rule 2: vectors must be the same size
        if (vector1.Length != vector2.Length)
            return new double[] { -1 };

        double[] result = new double[vector1.Length];
        for (int i = 0; i < vector1.Length; i++)
        {
            result[i] = vector1[i] + vector2[i];
        }
        return result;
    }
}
