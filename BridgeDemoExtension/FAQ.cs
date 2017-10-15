using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDemoExtension
{
    public class FAQ : Manuscript//IManuscript
    {
        public string Title { get; set; }
        public Dictionary<string, string> Questions { get; set; }

        public FAQ(IFormatter formatter) : base(formatter)
        {
            Questions = new Dictionary<string, string>();
        }

        public override void Print()
        {
            Console.WriteLine("Title: {0}", Title);
            foreach (var question in Questions)
            {
                Console.WriteLine("Question: {0}", question.Key);
                Console.WriteLine("Answer: {0}", question.Value);
            }
            Console.WriteLine();
        }
    }
}
