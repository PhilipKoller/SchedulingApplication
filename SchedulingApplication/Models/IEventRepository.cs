using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchedulingApplication.Models
{
    public interface IEventRepository
    {
        //Why this? Because an interface helps to retreive and save data
        // This also allows for dependency injection
        Event GetEvent(int Id);

        // IEnumerable will let us iterate over Users so we can make a table in the view 
        IEnumerable<Event> GetAllEvents();

        Event Add(Event addEvent);

        Event Update(Event updateEvent);

        Event Delete(int id);
    }
}
