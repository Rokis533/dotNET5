using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Topic
{
    internal class WordDocument : Document
    {
        public WordDocument(string filePath, string title) : base(filePath, title)
        {
        }

        public override string Read()
        {
            Console.WriteLine($"Skaitom Word {Title}");
            return "Skaitom Word";
        }

        public override void Write(string content)
        {
            Console.WriteLine($"Rašom Word {Title}: {content}");
        }
    }
}
