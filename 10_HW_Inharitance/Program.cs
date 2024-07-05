namespace _10_HW_Inharitance
{
    abstract class Geometry_Figure
    {
        public abstract double GetArea();
        public abstract double GetPerimeter();

    }

    class Triangle : Geometry_Figure
    {
        public double Side_1 {  get; set; }
        public double Side_2 { get; set; }
        public double Side_3 { get; set; }


        public Triangle() { Side_1 = 1;Side_2 = 1;Side_3 = 1; }
        public Triangle(double s1, double s2, double s3) { Side_1 = s1;Side_2 = s2;Side_3 = s3; }

        public override double GetPerimeter()
        {
            return Side_1+Side_2+Side_3;
        }
        override public double GetArea()
        {
            double p = GetPerimeter();
            return Math.Sqrt(p*(p-Side_1)*(p-Side_2)*(p-Side_3));
        }
    }

    class Rectangle : Geometry_Figure
    {
        public double Side_1 { get; set; }
        public double Side_2 { get; set; }
        public Rectangle() { Side_1 = 1; Side_2 = 1; }
        public Rectangle(double s1, double s2) { Side_1 = s1; Side_2 = s2; }
        public override double GetPerimeter()
        {
            return (Side_1 + Side_2)*2;
        }
        override public double GetArea()
        {
            return (Side_1*Side_2);
        }
    }

    class Square : Rectangle
    {
        public Square() : base() { }
        public Square(double s1, double s2) : base(s1, s2) { }
    }

    class Romb : Geometry_Figure
    {
        public double Diagonal_1 { get; set; }
        public double Diagonal_2 { get; set; }

        public Romb() { Diagonal_1 = 1; Diagonal_2 = 1; }
        public Romb(double s1, double s2) { Diagonal_1 = s1; Diagonal_2 = s2; }

        public override double GetPerimeter()
        {
            return 2* Math.Sqrt(Diagonal_1*Diagonal_1+Diagonal_2*Diagonal_2);
        }
        override public double GetArea()
        {
            return (Diagonal_1*Diagonal_2)/2;
        }
    }

    class Paralelogram : Geometry_Figure
    {
        public double Side_1 { get; set; }
        public double Side_2 { get; set; }
        public double Angle { get; set; }
        public Paralelogram() { Side_1 = 1; Side_2 = 1; Angle = 30; }
        public Paralelogram(double s1, double s2, double a) { Side_1 = s1; Side_2 = s2; Angle = a; }
        public override double GetPerimeter()
        {
            return (Side_1 + Side_2) * 2;
        }
        override public double GetArea()
        {
            return (Side_1 * Side_2)*Math.Sin(Angle);
        }
    }

    class Trapeze : Geometry_Figure
    {
        public double Side_1 { get; set; }
        public double Side_2 { get; set; }
        public double Side_3 { get; set; }
        public double Side_4 { get; set; }
        public double Heigth { get; set; }

        public Trapeze() { Side_1 = 1; Side_2 = 1; Side_3 = 1; Side_4 = 1; Heigth = 1; }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
