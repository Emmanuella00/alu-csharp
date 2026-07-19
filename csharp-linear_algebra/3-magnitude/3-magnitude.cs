using System;

/// <summary>Provides vector math operations.</summary>
public class VectorMath
{
    /// <summary>Calculates the magnitude (length) of a 2D or 3D vector.</summary>
    /// <param name="vector">The vector as an array of doubles.</param>
    /// <returns>
    /// The magnitude rounded to the nearest hundredth,
    /// or -1 if the vector is not 2D or 3D.
    /// </returns>
    public static double Magnitude(double[] vector)
    {
        if (vector.Length != 2 && vector.Length != 3)
            return -1;

        double sumOfSquares = 0;
        foreach (double component in vector)
        {
            sumOfSquares += component * component;
        }

        double magnitude = Math.Sqrt(sumOfSquares);
        return Math.Round(magnitude, 2);
    }
}
