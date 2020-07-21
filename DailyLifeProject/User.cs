using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyLifeProject
{
    public class User : Person
    {
        public List<Event> events { get;  } 
        public User(string name, string des, string pno) : base(name, des, pno)
        {
            events = new List<Event>();
        }

        public void addEvent(Event e)
        {
            events.Add(e);
        }

    }
}
