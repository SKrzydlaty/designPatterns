using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDemoExtension
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<IManuscript> documents = new List<IManuscript>();
            List<Manuscript> documents = new List<Manuscript>();

            var formatter = new StandardFormatter();
            var formatter2 = new BackwardFormatter();
            var formatter3 = new FancyFormatter();

            var faq = new FAQ(formatter);
            faq.Title = "The bridge pattern FAQ";
            faq.Questions.Add("What is it?", "A design pattern");
            faq.Questions.Add("When do we use it?", "When you need separate an abstraction form an implementation");
            documents.Add(faq);

            var book = new Book(formatter2)
            {
                Title = "Lots of patterns",
                Author = "John Sonnez",
                Text = "Blah blah blah"
            };

            documents.Add(book);

            var paper = new TempPaper(formatter3)
            {
                Class = "Design Patterns",
                Student = "Joen Noob",
                Text = "Blah blah blah...",
                References = "GOF"
            };

            documents.Add(paper);

            foreach(var doc in documents){
                doc.Print();
            }

            Console.ReadKey();
        }
    }
}
