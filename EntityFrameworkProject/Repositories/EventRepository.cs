using EntityFrameworkProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkProject.Repositories
{
    internal interface IEventRepository
    {
        Event Create(Event @event);
    }

    internal class EventRepository : IEventRepository
    {
        //CRUD opertacijos
        //CRUD
        //C - Create
        //R - Read
        //U - Update
        //D - Delete

        private readonly EventsContext _context;

        public EventRepository(EventsContext context)
        {
            _context = context;
        }

        public Event Create(Event @event)
        {

            _context.Events.Add(@event);
            _context.SaveChanges();


            return @event;
        }


    }
}
