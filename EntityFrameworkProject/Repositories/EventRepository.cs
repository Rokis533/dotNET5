using EntityFrameworkProject.Entities;
using Microsoft.EntityFrameworkCore;
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
        Event Update(Event @event);
        Event GetById(Guid id);
        IEnumerable<Event> GetAll();
        void Delete(Guid id);
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
        //C - Create
        public Event Create(Event @event)
        {

            _context.Events.Add(@event);
            _context.SaveChanges();


            return @event;
        }
        //R - Read
        public Event GetById(Guid id)
        {
            return _context.Events.Include(x => x.Performer).FirstOrDefault(x => x.Id == id);
        }
        //R - Read
        public IEnumerable<Event> GetAll()
        {
            return _context.Events;
        }
        //U - Update
        public Event Update(Event @event)
        {
            _context.Events.Update(@event);
            _context.SaveChanges();
            return @event;
        }
        //public Event Update(Event @event)
        //{
        //    var ev = _context.Events.Find(@event.Id);
        //    if (ev != null)
        //    {
        //        ev.Age = @event.Age;
        //        ev.Date = @event.Date;
        //    }
        //    _context.SaveChanges();

        //    return @event;
        //}


        //D - Delete
        public void Delete(Guid id)
        {
            var ev = _context.Events.Find(id);
            if (ev != null)
            {
                _context.Events.Remove(ev);
                _context.SaveChanges();
            }
        }
        //public void Delete(Event @event)
        //{
        //    if (@event != null)
        //    {
        //        _context.Events.Remove(@event);
        //        _context.SaveChanges();
        //    }
        //}
    }
}