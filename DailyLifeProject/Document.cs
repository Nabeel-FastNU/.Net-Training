using System;

namespace DailyLifeProject
{
    public class Document
    {
        private string Title { get; set;}
        private string Description { get; set; }

        public Document(string name, string des)
        {
            Title = name;
            Description = des;
        }

        public void Doc_Informatiom()
        {
            Console.WriteLine("Document Title: " + Title);
            Console.WriteLine("Document Description: " + Description + '\n');
        }
    }
}
