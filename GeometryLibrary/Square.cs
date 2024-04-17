namespace GeometryLibrary;
public class Square : IShape
{
    private double a;

        public Square(double side)
        {
            this.a = side;
        }

        public double CalculateArea()
        {
            return a * a;
        }

        public double CalculatePerimeter()
        {
            return 4 * a;
        }
}