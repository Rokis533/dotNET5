using Shared;

namespace Access_Modifiers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal(15);

            animal.Date = "1999-12-12";

            Console.WriteLine(animal.Date);

            animal.Age = 20; // setter
                             // animal.Age = -5; // setter
            animal.SetAge(20);
            var age_value = animal.Age; // getter

            Console.WriteLine(age_value);




            Human human = new Human();
            //jei viduje projekto klasės
            //human.Public = 0;
            ////human.Private = 0; nepasiekiam
            ////human.Protected = 0; nepasiekiam
            //human.Internal = 0;
            //human.ProtectedInternal = 0;
            ////human.PrivateProtected = 0; nepasiekiam


            //jei kito projekto klasės
            human.Public = 0;
            //human.Private = 0; nepasiekiam
            //human.Protected = 0; nepasiekiam
            //human.Internal = 0;
            //human.ProtectedInternal = 0;
            //human.PrivateProtected = 0; nepasiekiam

        }
    }
}
