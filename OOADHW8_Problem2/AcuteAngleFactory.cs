namespace OOADHW8_Problem2
{
    public class AcuteAngleFactory : FigureFactory
    {

        /**
         * Default constructor
         */
        public AcuteAngleFactory()
        {
        }

        /**
         * @param size 
         * @return
         */
        public PlaneFigure makePlaneFigure(double size)
        {
            return new Triangle(size);
        }

        /**
         * @param size 
         * @return
         */
        public SpaceFigure makeSpaceFigure(double size)
        {
            return new Pyramid(size);
        }
    }
}
