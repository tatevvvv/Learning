namespace OOADHW8_Problem2
{
    public interface FigureFactory
    {

        /**
         * @param size 
         * @return
         */
        public abstract PlaneFigure makePlaneFigure(double size);

        /**
         * @param size 
         * @return
         */
        public abstract SpaceFigure makeSpaceFigure(double size);

    }
}
