using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtentionMethods
{
    internal static class MyExtentions
    {
        public static bool IsEmpty(this string str)
        {
            return string.IsNullOrEmpty(str);
        }

        public static bool IsEven(this int number)
        {
            return number % 2 == 0;
        }

        public static PersonDTO PersonToDto(this Person person)
        {
            if (person == null)
            {
                return null;
            }

            return new PersonDTO
            {
                Name = person.Name,
                Age = person.Age,
            };
        }
        public static void PrintAllItems<T>(this List<T> items)
        {
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
        }
    }
}
