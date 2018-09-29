using System;
/// <summary>
/// Provides Area method.
/// </summary>
class Shape {
    /// <summary>
    /// Holding space for a non imlemented method.
    /// </summary>
    /// <returns>Nothing.</returns>
    public virtual int Area() {
        throw new NotImplementedException("Area() is not implemented");
    }
}
/// <summary>
/// Provides dimensions and methods for Rectangles. Inherits from Shape class.
/// </summary>
class Rectangle : Shape {
    //width of the rectangle.
    private int width;
    //height of the rectangle.
    private int height;
    /// <summary>
    /// Gets or sets width. If value is negative an exception is thrown.
    /// </summary>
    public int Width {
        get {
            return width;
        }
        set {
            if (value < 0) {
                throw new ArgumentException("Width must be greater than or equal to 0");
            }
            else {
                width = value;
            }
        }
    }
    /// <summary>
    /// Gets or sets height. If value is negative an exception is thrown.
    /// </summary>
    public int Height {
        get {
            return height;
        }
        set {
            if (value < 0) {
                throw new ArgumentException("Height must be greater than or equal to 0");
            }
            else {
                height = value;
            }
        }
    }
    /// <summary>
    /// Returns the area (height times the width) of the rectangle.
    /// </summary>
    /// <returns>Area of the rectangle.</returns>
    public new int Area() {
        return height * width;
    }
    /// <summary>
    /// Overrides tostring method.
    /// </summary>
    public override string ToString() {
        return string.Format("[Rectangle] {0} / {1}", width, height);
    }
}
/// <summary>
/// Provides dimensions and methods for a Square. Inherits from Rectangle class.
/// </summary>
class Square : Rectangle {
    //Length of one of the sides of the square.
    private int size;
    /// <summary>
    /// Gets or sets the size. Throws an exception of value is negative.
    /// </summary>
    public int Size {
        get {
            return size;
        }
        set {
            if (value < 0) {
                throw new ArgumentException("Size must be greater than or equal to 0");
            }
            else {
                size = Height = Width = value;
            }
        }
    }
    /// <summary>
    /// Overrides tostring method.
    /// </summary>
    /// <returns>a string.</returns>
    public override string ToString() {
        return string.Format("[Square] {0} / {0}", size);
    }
}
