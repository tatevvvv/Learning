namespace OOADHW8
{
    public class Program
    {
        public static void Main()
        {
            Client client = new Client();

            //***** configuring client with Square(10) through its adapter
            client.setShape(new S_Adapter(new Square(10)));

            //client's generic beahavior
            Console.WriteLine(client.getPerimeter());
            Console.WriteLine(client.getArea());
            Console.WriteLine();

            //***** configuring client with Triangle(10) through its adapter
            client.setShape(new T_Adapter(new Triangle(10)));

            //client's generic beahavior
            Console.WriteLine(client.getPerimeter());
            Console.WriteLine(client.getArea());
            Console.WriteLine();
        }
    }
}
