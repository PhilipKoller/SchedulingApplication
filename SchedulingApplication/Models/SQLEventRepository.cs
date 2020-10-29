using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchedulingApplication.Models
{
    public class SQLEventRepository : IEventRepository
    {
        private readonly AppDbContext _context;
        public SQLEventRepository(AppDbContext context)
        {
            _context = context;
        }

        public Event Add(Event addEvent)
        {
            _context.Events.Add(addEvent);
            _context.SaveChanges();
            return addEvent;
        }

        public Event Delete(int Id)
        {
            Event deleteEvent = _context.Events.Find(Id);
            if (deleteEvent != null)
            {
                _context.Events.Remove(deleteEvent);
                _context.SaveChanges();
            }
            return deleteEvent;
        }

        public IEnumerable<Event> GetAllEvents()
        {
            return _context.Events;
        }

        public Event GetEvent(int Id)
        {
            return _context.Events.Find(Id);
        }

        public Event Update(Event updateEvent)
        {
            var eEvent = _context.Events.Attach(updateEvent);
            eEvent.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            return updateEvent;
        }
    }
}
