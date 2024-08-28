using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkProject.Entities
{
    internal class Event
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public Guid Id { get; set; }

        [MaxLength(255)]
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string Type { get; set; }
        public string Place { get; set; }
        public int Age { get; set; }

        [ForeignKey(nameof(Performer))]
        public Guid? PerformerId { get; set; }
        public Performer? Performer { get; set; }







    }
}
