using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access_Modifiers
{
    public class Animal
    {
        private int age;
        private DateTime date;
        public int Age
        {
            get
            {

                return age + 100;
            }
            set
            {
                if (0 > value)
                {
                    throw new ArgumentException("Value cannot be bellow 0");
                }
                age = value;
            }
        }
        public string Date
        {
            get
            {

                return date.ToString("yyyy-->MMMM-->dd");
            }
            set
            {
                if (DateTime.TryParse(value, out DateTime result))
                {
                    date = result;

                }
                else
                {
                    throw new ArgumentException("Cannot parse value");
                }
            }
        }
        public Animal(int age)
        {
            if (age < 0)
            {
                Age = age;
            }

            var age_value = Age;
            Console.WriteLine(age_value);
        }

        public void SetAge(int age)
        {
            if (age < 0)
            {
                Age = age;
            }
        }
    }
}
