using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtentionMethods
{
    internal class Person(int id, string name, int age, int personalCode)
    {
        public int Id { get; set; } = id;
        public string Name { get; set; } = name;
        public int Age { get; set; } = age;
        public int PersonalCode { get; set; } = personalCode;

        //public Person(int id, string name, int age, int personalCode)
        //{
        //    Id = id;
        //    Name = name;
        //    Age = age;
        //    PersonalCode = personalCode;
        //}


    }
}
