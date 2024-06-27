using OPP1;

namespace MethodsInClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Computer computer = new Computer
            {
                Apps = new List<App>
                {
                    new App{
                        Name = "app",
                        Size = 100,
                    },
                    new App{
                        Name = "app2",
                        Size = 200,
                    },
                    new App{
                        Name = "app3",
                        Size = 600,
                    },
                    new App{
                        Name = "app4",
                        Size = 2000,
                    },
                    new App{
                        Name = "app5",
                        Size = 500,
                    }
                }
            };

            computer.PrintApps();
            Console.WriteLine("-----------------------------");
            computer.PrintApps(500);

            App app = new App();
            DoSmth(app);
        }

        public static void DoSmth(App app)
        {
            //sukuriamas
            //do smth
        }
        public static void DoSmth()
        {
            App app = new App(); //sukuriamas
            //do smth
        }
    }
}
