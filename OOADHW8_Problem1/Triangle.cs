namespace OOADHW8
{
    public class Triangle
    {
        private double a;

        public Triangle(double a)
        {
            this.a = a;
        }

        public double area()
        {
            var s = 3 * a / 2;
            var area = Math.Sqrt(s * (s - a) * (s - a) * (s - a));

            return area;
        }

    }
}
