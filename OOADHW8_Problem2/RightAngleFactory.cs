namespace OOADHW8_Problem2
{
    public class RightAngleFactory : FigureFactory
    {

        /**
         * Default constructor
         */
        public RightAngleFactory()
        {
        }

        /**
         * @param size 
         * @return
         */
        public PlaneFigure makePlaneFigure(double size)
        {
            return new Square(size);
        }

        /**
         * @param size 
         * @return
         */
        public SpaceFigure makeSpaceFigure(double size)
        {
            return new Cube(size);
        }
    }
}
