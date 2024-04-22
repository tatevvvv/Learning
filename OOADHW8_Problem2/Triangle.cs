namespace OOADHW8_Problem2
{
    public class Triangle : PlaneFigure
    {
        private double a;

        public Triangle(double a)
        {
            this.a = a;
        }

        public override double area()
        {
            var s = 3 * a / 2;
            var area = Math.Sqrt(s * (s - a) * (s - a) * (s - a));

            return area;
        }

        public override double perimeter()
        {
            var side = Math.Sqrt((4 * area()) / Math.Sqrt(3));

            return side * 3;
        }
    }
}
