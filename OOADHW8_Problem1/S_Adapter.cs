namespace OOADHW8
{
    public class S_Adapter : Shape
    {
        private Square square;

        public S_Adapter(Square square)
        {
            this.square = square;
        }


        public override double perimeter()
        {
            return square.perimeter();
        }

        public override double area()
        {
            var a = perimeter() / 4;

            return a * a;
        }
    }
}