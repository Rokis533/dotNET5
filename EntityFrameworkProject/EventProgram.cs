using EntityFrameworkProject.Entities;
using EntityFrameworkProject.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkProject
{
    internal class EventProgram
    {
        private readonly IEventRepository _eventRepository;

        public EventProgram(IEventRepository eventRepository)
        {
            _eventRepository = eventRepository;
        }

        public void Run()
        {

            //var eventEntity = new Event
            //{
            //    Name = "vardadienis",
            //    Date = new DateTime(2024, 08, 15),
            //    Place = "Kražiai",
            //    Type = "Katalikiška/pramoginė",
            //    Age = 1
            //};

            var ev = _eventRepository.GetById(new Guid("72BD59D8-6999-4AE4-508A-08DCC7831C39"));



            if (ev != null)
            {
                var performer = new Performer
                {
                    Name = "Radzi",
                    Types = "Pramoginis"

                };

                ev.Performer = performer;

                ev.Age = 0;
                ev.Date = DateTime.Now;
                _eventRepository.Update(ev);
            }




        }
    }
}
