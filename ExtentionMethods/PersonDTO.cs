using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtentionMethods
{
    internal class PersonDTO
    {
        public string Name { get; set; }
        public int Age { get; set; }

        private string name;
        private int age;

        //public PersonDTO(string name, int age)
        //{
        //    this.name = name;

        //}

        public override string ToString()
        {
            return $"Name: {Name}, Age: {Age}";
        }
    }
}
