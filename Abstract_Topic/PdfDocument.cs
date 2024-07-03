using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Topic
{
    internal class PdfDocument : Document
    {
        public bool IsSigned { get; set; }
        public PdfDocument(string filePath, string title, bool isSigned) : base(filePath, title)
        {
            IsSigned = isSigned;
        }
        public void Sign()
        {
            IsSigned = true;
        }

        public override string Read()
        {
            Console.WriteLine($"Skaitom PDF {Title}");
            return "Skaitom PDF";
        }

        public override void Write(string content)
        {
            Console.WriteLine($"Rašom PDF {Title}: {content}");
        }
    }
}
