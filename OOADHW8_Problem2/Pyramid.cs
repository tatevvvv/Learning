namespace OOADHW8_Problem2
{
    public class Pyramid : SpaceFigure
    {
        private double a;

        public Pyramid(double a)
        {
            this.a = a;
        }

        public override double surface()
        {
            return Math.Sqrt(3) * a * a;
        }

        public override double volume()
        {
            return (Math.Sqrt(3) / 6) * a * a * a;
        }
    }
}
