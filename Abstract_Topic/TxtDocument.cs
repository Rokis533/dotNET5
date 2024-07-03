using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Topic
{
    internal class TxtDocument : Document
    {
        public TxtDocument(string filePath, string title) : base(filePath, title)
        {
        }

        public override string Read()
        {
            Console.WriteLine($"Skaitom TXT {Title}");

            return File.ReadAllText(FilePath);
        }

        public override void Write(string content)
        {
            //file operations
            Console.WriteLine($"Rašom TXT {Title}: {content}");
            File.WriteAllText(FilePath, content);
        }
    }
}
