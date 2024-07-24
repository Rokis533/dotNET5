using InterfaceTopic.Payments;
using InterfaceTopic.Shapes;

namespace InterfaceTopic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Paypal paypal = new Paypal();
            //Swedbank swedbank = new Swedbank();
            //Visa visa = new Visa();

            //Shop shop = new Shop();

            ////shop.Buying(99, paypal);

            //while (true)
            //{
            //    Console.Clear();
            //    Console.WriteLine("Pasirinkite banka:");
            //    Console.WriteLine("1. Paypal");
            //    Console.WriteLine("2. Swedbank");
            //    Console.WriteLine("3. Visa");
            //    int choise = int.Parse(Console.ReadLine());

            //    switch (choise)
            //    {
            //        case 1:
            //            shop.Buying(99, paypal);
            //            break;
            //        case 2:
            //            shop.Buying(99, swedbank);
            //            break;
            //        case 3:
            //            shop.Buying(99, visa);
            //            break;
            //    }
            //    Console.ReadKey();
            //}


            List<IShape> shapes = new List<IShape>
            {
                new Square(5, 5),
                new Triangle(5, 9),
                new Triangle(5, 10),
                new Triangle(5, 11),
                new Square(2, 5),
            };



            shapes.ForEach(shape =>
            {
                Console.WriteLine("----------------------------");
                Console.WriteLine(shape.GetArea());
                Console.WriteLine(shape.GetPerimeter());
            });

            foreach (IShape shape in shapes)
            {
                Console.WriteLine("----------------------------");
                Console.WriteLine(shape.GetArea());
                Console.WriteLine(shape.GetPerimeter());
            }
        }
    }
}
