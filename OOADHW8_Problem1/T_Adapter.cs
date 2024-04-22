namespace OOADHW8
{
    public class T_Adapter : Shape
    {
        private Triangle triangle;

        public T_Adapter(Triangle triangle)
        {
            this.triangle = triangle;
        }

        // this triangle is equilateral, hence the we can find the side
        public override double perimeter()
        {
            var side = Math.Sqrt((4 * area()) / Math.Sqrt(3));

            return side * 3;
        }

        public override double area()
        {
            return triangle.area();
        }
    }
}
