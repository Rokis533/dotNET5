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
        public override bool Equals(object? obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (obj is PersonDTO personDTO)
            {
                return Name == personDTO.Name;
            }

            return false;
        }
    }
}
