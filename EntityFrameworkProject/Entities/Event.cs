using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkProject.Entities
{
    internal class Event : EntityBase
    {

        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string Type { get; set; }
        public string Place { get; set; }
        public int Age { get; set; }


        public Guid? PerformerId { get; set; }
        public Performer? Performer { get; set; }







    }
}
