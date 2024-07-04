using System.Reflection.Metadata;

namespace Abstract_Topic
{
    internal class Program
    {
        static void Main(string[] args)
        {


            TxtDocument txtdocument = new TxtDocument("tekstas.txt", "TestFile");

            txtdocument.Write("Tekstas kažkas");
            Console.WriteLine();

            PdfDocument pdfDocument = new PdfDocument("saskaita.pdf", "Sąskaitą", true);

            pdfDocument.Write("saskaita pinigai pinigai ");
            Console.WriteLine();

            WordDocument wordDocument = new WordDocument("sutartis.docx", "Sutartis");

            wordDocument.Write("sutartis bauda bauda");
            wordDocument.SetTitle("Sutartis2");

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            List<Document> documents = new List<Document>();
            documents.Add(pdfDocument);
            documents.Add(wordDocument);
            documents.Add(txtdocument);

            Document document1 = new PdfDocument("laiskas.pdf", "Laiškas", true);



            foreach (var document in documents)
            {
                var content = document.Read();
                Console.WriteLine($"{document.Title}: \n {content}");
                Console.WriteLine();
                document.SetTitle("naujas");


                if (document is PdfDocument pdf)
                {
                    Console.WriteLine(pdf.IsSigned);
                    pdf.Sign();
                }
            }
        }
    }
}
