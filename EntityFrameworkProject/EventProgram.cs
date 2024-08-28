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

            var eventEntity = new Event
            {
                Name = "vardadienis",
                Date = new DateTime(2024, 08, 15),
                Place = "Kražiai",
                Type = "Katalikiška/pramoginė",
                Age = 1
            };

            

            _eventRepository.Create(eventEntity);

        }
    }
}
