namespace OOADHW8_Problem2
{
    public class Square : PlaneFigure
    {
        private double a;

        public Square(double a)
        {
            this.a = a;
        }

        public override double perimeter()
        {
            return 4 * a;
        }

        public override double area()
        {
            return a * a;
        }

    }
}
