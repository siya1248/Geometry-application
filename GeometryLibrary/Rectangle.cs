namespace GeometryLibrary;
public class Rectangle : IShape
{
    private double l;
    private double b;

        public Rectangle(double length, double breadth)
        {
            this.l = length;
            this.b = breadth;
        }

        public double CalculateArea()
        {
            return l * b;
        }

        public double CalculatePerimeter()
        {
            return 2 * (l + b);
        }
}