namespace GeometryLibrary;
public class Triangle : IShape
{
    private double tbase;
    private double height;
    private double sideB;
    private double sideC;

        public Triangle(double m, double n, double o, double p)
        {
            this.tbase = m;
            this.height = n;
            this.sideB = o;
            this.sideC = p;
        }

        public double CalculateArea()
        {
            return ( tbase * height ) / 2;
        }

        public double CalculatePerimeter()
        {
            return tbase + sideB + sideC;
        }
}