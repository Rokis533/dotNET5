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
        public static T FindAndReturnIfEqual1<T>(this List<T> list, T item)
        {
            foreach (T listItem in list)
            {
                if (listItem.Equals(item))
                {
                    return listItem;
                }
            }
            return default(T);
        }
        public static T FindAndReturnIfEqual2<T>(this List<T> list, T item)
        {
            foreach (T listItem in list)
            {
                if (EqualityComparer<T>.Default.Equals(listItem, item))
                {
                    return listItem;
                }
            }
            return default; // jei sarašas tai null, jei T yra string tai null, jei yra int tai 0
        }
        public static T FindAndReturnIfEqual3<T>(this List<T> list, T item)
        {
            if (list.Contains(item))
            {
                return item;
            }

            return default(T);
        }

        public static List<string> ReadOtherLine(this FileInfo fileInfo)
        {
            var lines = new List<string>();
            using (var reader = new StreamReader(fileInfo.FullName))
            {
                string line;
                int linenumb = 0;
                while ((line = reader.ReadLine()) != null)
                {
                    if (linenumb % 2 == 0)
                    {
                        lines.Add(line);
                    }
                }
            }
            return lines;
        }
    }
}
