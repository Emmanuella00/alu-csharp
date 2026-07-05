using System;

/// <summary>Represents a generic shape.</summary>
public class Shape
{
    /// <summary>Calculates the area of the shape.</summary>
    /// <returns>The area of the shape.</returns>
    /// <exception cref="NotImplementedException">
    /// Always thrown because Area() is not implemented in the base class.
    /// </exception>
    public virtual int Area()
    {
        throw new NotImplementedException("Area() is not implemented");
    }
}

/// <summary>Represents a rectangle, which is a shape.</summary>
public class Rectangle : Shape
{
    private int width;
    private int height;

    /// <summary>Gets or sets the width of the rectangle.</summary>
    /// <exception cref="ArgumentException">
    /// Thrown when the value is negative.
    /// </exception>
    public int Width
    {
        get { return width; }
        set
        {
            if (value < 0)
                throw new ArgumentException("Width must be greater than or equal to 0");
            width = value;
        }
    }

    /// <summary>Gets or sets the height of the rectangle.</summary>
    /// <exception cref="ArgumentException">
    /// Thrown when the value is negative.
    /// </exception>
    public int Height
    {
        get { return height; }
        set
        {
            if (value < 0)
                throw new ArgumentException("Height must be greater than or equal to 0");
            height = value;
        }
    }
}