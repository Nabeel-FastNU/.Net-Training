using DailyLifeProject.Extensions;
using System;
using System.Collections.Generic;

//Delegate

public delegate void print();

namespace DailyLifeProject
{
    //Abstract Class 

    public abstract class Event
    {
        //Static Member

        private static int Total_events { get;  set; }

        //Protected Members

        protected DateTime Start_dt { get; set; }
        protected DateTime End_dt { get; set; }
        protected string Location { get; set; }
        protected string Name { get; set; }


        public Event(string name, string loc, DateTime st_dt, DateTime end_dt)
        {
            Name = name;
            Location = loc;
            Start_dt = st_dt;
            End_dt = end_dt;
            Total_events += 1;
        }

        //Static Non - Argument Lambda Expression

        public static Action Total_Events = () => { Console.WriteLine("\nTotal Events: " + Total_events); };


        //Abstract Method

        public abstract void printDetails();

    }

    //Inheritance 

    public class Meeting : Event
    {
        private Person person { get; set; }

        public Meeting(string name, Person p, string loc, DateTime s_dt, DateTime e_dt) : base(name, loc, s_dt, e_dt)
        {
            person = p;
        }

        //Overridden Abstract Method

        public override void printDetails()
        {
            Console.WriteLine("\n~~~Meeting~~~\n");
            Console.WriteLine("Person Details: ");
            person.Person_Details();
            Console.WriteLine("Meeting Title: " + Name);
            Console.WriteLine("Location: " + Location);

            //DateTime Extension Method (Print_DateTime())

            Console.WriteLine("Start Time-Date: " + Start_dt.Print_DateTime());
            Console.WriteLine("End Time-Date: " + End_dt.Print_DateTime() + '\n');
        }

    }


    public class Trip : Event
    {
        private List<Document> Docs { get; set; }
        private int Trip_Expense { get; set; }

        public Trip(string name, string loc, int ex, DateTime s_dt, DateTime e_dt) : base(name, loc, s_dt, e_dt)
        {
            Docs = new List<Document>();
            Trip_Expense = ex;
        }

        public void Add_Document(Document doc)
        {
            Docs.Add(doc);
        }

        
        public override void printDetails()
        {
            Console.WriteLine("\n~~~Trip~~~\n");
            Console.WriteLine("Trip Title: " + Name);
            Console.WriteLine("Location: " + Location);
            Console.WriteLine("Start Time-Date: " + Start_dt.ToString());
            Console.WriteLine("End Time-Date: " + End_dt.ToString());
            Console.WriteLine("Trip Expense: " + Trip_Expense);
            Console.WriteLine("\nDocuments Required: \n");

            for (int i = 0; i < Docs.Count; i++)
            {
                Console.WriteLine("Document " + (i + 1) + ": ");
                Docs[i].Doc_Informatiom();
            }

        }
    }

    //Multi - Level Inheritance

    public class GroupTrip : Trip
    {
        private List<Person> persons;
        public GroupTrip(string name, string loc, int ex, DateTime s_dt, DateTime e_dt) : base(name, loc, ex, s_dt, e_dt)
        {
            persons = new List<Person>();
        }

        public void Add_Person(Person p)
        {
            persons.Add(p);
        }

        //Overridden Method

        public override void printDetails()
        {
            base.printDetails();
            Console.WriteLine("\nColleagues Details: ");
            for (int i = 0; i < persons.Count; i++)
            {
                Console.WriteLine("\nColleague: " + (i + 1));
                persons[i].Person_Details();
            }

        }

    }
}

