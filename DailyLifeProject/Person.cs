using System;

namespace DailyLifeProject
{
    public class Person
    {
        private string Name { get; }
        private string Designation { get; }
        private string PhoneNo { get; }

        public Person(string name, string des, string pno)
        {
            Name = name;
            Designation = des;
            PhoneNo = pno;
        }

        public void Person_Details()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Designation: " + Designation);
            Console.WriteLine("Phone Number: " + PhoneNo);
        }
    }
}
