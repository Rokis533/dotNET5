namespace ExtentionMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string tekstas = Console.ReadLine();

            //Console.WriteLine("Ar tuščias?");
            //Console.WriteLine(tekstas.IsEmpty());

            //int number = 101;
            //Console.WriteLine($"Ar Lyginis {number}?");
            //Console.WriteLine(number.IsEven());

            //Person person = new Person()
            //{
            //    Id = 111,
            //    Name = "Rokas",
            //    Age = 1,
            //    PersonalCode = 398465645
            //};

            //PersonDTO personDTO = new PersonDTO
            //{
            //    Name = person.Name,
            //    Age = person.Age,
            //};

            //PersonDTO personDTO = person.PersonToDto();

            List<int> numbers = new List<int> { 1, 2, 5, 6, 8, 6, 5, 3, 8 };
            List<string> words = new List<string> { "Test", "Rokas", "Ka=kas" };

            List<PersonDTO> list = new List<PersonDTO> {
                new PersonDTO{ Age = 154, Name = "Rokas"},
                new PersonDTO{ Age = 4, Name = "Rokas1"},
                new PersonDTO{ Age = 4524, Name = "Rokas2"},
                new PersonDTO{ Age = 5254, Name = "Rokas3"},
            };

            numbers.PrintAllItems();

            words.PrintAllItems();

            list.PrintAllItems();


            var item = list.FindAndReturnIfEqual2(new PersonDTO { Age = 154, Name = "Rokas" });

            var file = new FileInfo("file.txt");

            file.ReadOtherLine();
        }

    }
}
