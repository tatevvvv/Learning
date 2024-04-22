namespace OOADHW8
{
    public class Client
    {
        private Shape shape;

        public Client()
        {

        }

        public Client(Shape shape)
        {
            this.shape = shape;
        }

        public void setShape(Shape shape)
        {
            this.shape = shape;
        }

        public double getPerimeter()
        {
            return shape.perimeter();
        }

        public double getArea()
        {
            return shape.area();
        }

    }
}
