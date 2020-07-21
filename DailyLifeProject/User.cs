using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyLifeProject
{
    public class User : Person
    {
        private string emailID { get; }
        private string password { get;  }
        public List<Event> events { get;  } 
        public User(string name, string eId, string pass, string des, string pno) : base(name, des, pno)
        {
            emailID = eId;
            password = pass;
            events = new List<Event>();
        }

        public void addEvent(Event e)
        {
            events.Add(e);
        }

    }
}
