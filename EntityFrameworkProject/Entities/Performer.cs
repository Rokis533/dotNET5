using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkProject.Entities
{
    internal class Performer : EntityBase
    {
        public string Name { get; set; }
        public string Types { get; set; }

        public List<Event> Events { get; set; }

    }
}
