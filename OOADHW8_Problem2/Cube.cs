namespace OOADHW8_Problem2
{
    public class Cube : SpaceFigure
    {
        private double a;

        public Cube(double a)
        {
            this.a = a;
        }

        public override double surface()
        {
            return 6 * a * a;
        }

        public override double volume()
        {
            return a * a * a;
        }
    }
}
