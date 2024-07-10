namespace Generics_Topic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintInfo<int>(11);
            PrintInfoOBJ(11.5);
            PrintInfo<string>("tekstas");

            var genericClass = new GenericClass<string, int>();

            genericClass.Set("Tekstas", 152);
            var val = genericClass.GetT2();

            var repoTomato = new Repository<Tomato>();

            repoTomato.Add(new Tomato());
            repoTomato.Add(new Tomato());
            repoTomato.Add(new Tomato());

            var repoCarrots = new Repository<Carrot>();


            repoCarrots.Add(new Carrot
            {
                Id = 1,
                Color = "Blue",
                Lenght = 10,
            });

            Console.WriteLine(repoCarrots.GetByIndex(0).Color);
        }

        public static void PrintInfo<T>(T obj)
        {
            Console.WriteLine(obj.GetType().Name + ": " + obj);
        }
        public static void PrintInfoOBJ(object obj)// bad example
        {
            Console.WriteLine(obj.GetType().Name + ": " + obj);
        }

    }
}
