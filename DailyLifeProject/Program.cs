using System;

namespace DailyLifeProject
{
    class Program
    {
        static void Main(string[] args)
        {

            Person P1 = new Person("Ali", "TL", "03300000000");
            Person P2 = new Person("Hammad", "TM", "03310000000");
            Person P3 = new Person("Asghar", "TM", "03320000000");

            Document D1 = new Document("ABC", "XYZ");
            Document D2 = new Document("ABC1", "XYZ1");
            Document D3 = new Document("ABC12", "XYZ12");
            Document D4 = new Document("ABC123", "XYZ123");


            Event M1 = new Meeting("TS 1", P1, "Loc 1", new DateTime(2020, 07, 25, 9, 0, 0), new DateTime(2020, 07, 25, 14, 0, 0));


            Trip T1 = new Trip("BS 1", "Turkey", 1036000, new DateTime(2020, 07, 28, 9, 0, 0), new DateTime(2020, 08, 02, 16, 0, 0));

            T1.Add_Document(D1);
            T1.Add_Document(D2);
            T1.Add_Document(D3);
            T1.Add_Document(D4);


            GroupTrip GT1 = new GroupTrip("BS 2", "USA", 1834000, new DateTime(2020, 08, 03, 9, 0, 0), new DateTime(2020, 08, 22, 16, 0, 0));
            GT1.Add_Document(D3);
            GT1.Add_Document(D4);
            GT1.Add_Person(P2);
            GT1.Add_Person(P3);

            //Event Type Indexer

            Indexer<Event> Events = new Indexer<Event>();
            Events[0] = M1;
            Events[1] = T1;
            Events[2] = GT1;

            //Polymorphism

            //Events[0].Print_Details();
            //Events[1].Print_Details();
            //Events[2].Print_Details();

            //Delegate

            print eventDelegate = new print(Event.Total_Events);
            eventDelegate();


            User u1 = new User("Nabeel","nabeel@abc.com", "123123", "User-1", "03364994623");
            u1.addEvent(M1);
            u1.addEvent(T1);
            u1.addEvent(GT1);

            //Polymorphism and Lambda Expression

            u1.events.ForEach(e => e.printDetails());

        }
    }
}
