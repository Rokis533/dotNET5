using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Topic
{
    internal abstract class Document
    {
        public string FilePath { get; set; }
        public string Title { get; set; }

        public Document(string filePath, string title)
        {
            FilePath = filePath;
            Title = title;
        }

        public void SetTitle(string title)
        {
            Title = title;
        }

        public abstract string Read();
        public abstract void Write(string content);

    }
}
