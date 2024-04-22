namespace OOADHW8_Problem2
{
    public class Client
    {
        /**
         * Default constructor
         */
        public Client()
        {
        }

        /**
         * 
         */
        private FigureFactory factory;

        /**
         * @param size
         */

        public void setFactory(FigureFactory factory)
        {
            this.factory = factory;
        }

        public PlaneFigure getPlaneFigure(double size)
        {
            return factory.makePlaneFigure(size);
        }

        /**
         * @param space
         */
        public SpaceFigure getSpaceFigure(double space)
        {
            return factory.makeSpaceFigure(space);
        }

    }
}
