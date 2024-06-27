namespace OPP1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("Test");
            car.Name = "Test";
            car.Model = "Test";
            car.Engine = new Engine();
            car.Engine.Liters = 5;
            car.Engine.Type = "Dysel";

            Car car2 = new Car("Test")
            {
                Model = "Test",
                Engine = new Engine
                {
                    Liters = 5,
                    Type = "Dysel"
                },
                Wheels = new List<Wheel>
                {
                    new Wheel{
                        Brand = "Michelin",
                        Size = 19,
                    },
                    new Wheel{
                        Brand = "Michelin",
                        Size = 19,
                    },
                    new Wheel{
                        Brand = "Hankook",
                        Size = 19,
                    },
                    new Wheel{
                        Brand = "Hankook",
                        Size = 19,
                    },

                }

            };

            car2.Wheels[0].Size = 20;



            Computer computer1 = new Computer();

            computer1.Name = "Samsung";
            computer1.RAM = 16;
            computer1.CPU = "Intel";
            computer1.GraphicCard = "NVIDIA Geforce 3070";
            computer1.BuildDate = new DateTime(2020, 10, 3);


            Computer computer2 = new Computer("AMD", "AMD", 8, true, "ASUS");
            Computer computer3 = new Computer("AMD", "AMD", 4, true, "ASUS1");
            Computer computer4 = new Computer("AMD", "AMD", 18, true);
            Computer computer5 = new Computer("AMD", "AMD", 16, true);
            Computer computer6 = new Computer("AMD", "AMD", 10, true, "ASUS3");

            List<Computer> computers = new List<Computer>();
            computers.Add(computer1);
            computers.Add(computer2);
            computers.Add(computer3);
            computers.Add(computer4);
            computers.Add(computer5);
            computers.Add(computer6);




            //foreach (Computer computer in computers)
            //{

            //    Console.WriteLine(computer);

            //    string isEnough = computer.IsEnoughRAM();

            //    Console.WriteLine(isEnough);
            //}
            //Console.WriteLine();

            //var multiplication = Calculate();

            //var multiplication1 = Calculate(5);

            //var multiplication2 = Calculate(5, 5);

        }


        public static List<Computer> FilterByName(string name, List<Computer> list)
        {
            List<Computer> result = new List<Computer>();
            foreach (Computer item in list)
            {
                if (item.Name.Contains(name))
                {
                    result.Add(item);
                }
            }
            return result;
        }

        public static int Calculate(int a = 2, int b = 2)
        {
            return a * b;
        }
    }
}
