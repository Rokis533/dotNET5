using ExceptionHandeling;

namespace ExceptionHandeling
{
    internal class WriteToFile
    {
        public string Name { get; set; } = "As";
        public string Kazkas { get; set; } = "16";
        public void Write(string fileName)
        {
            string[] strings = new string[] { Name, Kazkas };
            string formatPath = $".\\..\\..\\{fileName}.txt";
            File.AppendAllLines(formatPath, strings);
        }
    }
}

internal class ReadFromFile
{
    public string[] Read(string filePath)
    {
        string formatPath = $".\\..\\..\\{filePath}.txt";
        if (File.Exists(formatPath))
        {
            return File.ReadAllLines(formatPath);

        }
        else
        {
            Console.WriteLine("File was not found.");
            return new string[0];
        }
    }
}
internal class Program
{
    static void Main(string[] args)
    {
        #region 4
        while (true)
        {
            try
            {
                var wtf = new WriteToFile();
                wtf.Write("file");
                var rff = new ReadFromFile();
                Console.WriteLine("---------------------");
                foreach (var text in rff.Read("file"))
                {
                    Console.WriteLine(text);
                }
                Console.WriteLine("---------------------");
                Console.Write("Darbas atliktas ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("sėkmingai");
                Console.ResetColor();
                Console.WriteLine(".");
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("DirectoryNotFoundException");
            }
            catch (IOException)
            {
                Console.WriteLine("IOException");
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("UnauthorizedAccessException");
            }
            catch (NotSupportedException)
            {
                Console.WriteLine("NotSupportedException");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                if (File.Exists("file"))
                {
                    Console.WriteLine("---------------------");
                    var rff = new ReadFromFile();
                    foreach (var text in rff.Read("file"))
                    {
                        Console.WriteLine(text);
                    }
                    Console.WriteLine("---------------------");
                    Console.WriteLine("Pabaiga...");
                    Console.ReadKey(true);
                }
            }
        }
        #endregion
    }

    //var input = Console.ReadLine();

    //try
    //{
    //    double result = Convert.ToDouble(input);
    //    Console.WriteLine($"Konvertuota reiksme: {result}");
    //}
    //catch (FormatException)
    //{
    //    Console.WriteLine("Neteisingas formatas. Irasykite tinkama skaiciu.");
    //}
    //catch (OverflowException)
    //{
    //    Console.WriteLine("Skaicius yra per didelis arba per mazas.");
    //}
    //catch (ArgumentNullException)
    //{
    //    Console.WriteLine("Irasyta reikssme yra null.");
    //}
    //catch (Exception ex)
    //{
    //    Console.WriteLine($"Error: {ex.Message}");
    //}
    //int fouls = 0;
    //while (true)
    //{
    //    try
    //    {
    //        Console.WriteLine($"You have {fouls} \n If you get 3 fouls you are eliminated");
    //        int a = int.Parse(Console.ReadLine());
    //        int b = int.Parse(Console.ReadLine());

    //        var division = Divide(a, b);
    //        Console.WriteLine("Answer: " + division);
    //        Console.WriteLine("Sekmingai viskas padaryta be klaidu");
    //    }
    //    catch (DivideByZeroException ex)
    //    {
    //        Console.WriteLine("Error: Negalima dalinti iš nulio");
    //    }
    //    catch (HasToBeMoreException ex)
    //    {
    //        Console.WriteLine($"Error: {ex.Message}");
    //        fouls++;
    //    }
    //    catch (Exception ex)
    //    {
    //        Console.WriteLine("Error: " + ex.Message);
    //    }
    //    finally
    //    {
    //        Console.WriteLine("Baigta");
    //    }





    /// <summary>
    /// Divides <paramref name="a"/> from <paramref name="b"/>
    /// <code>a / b = result</code>
    /// </summary>
    /// <param name="a">Dalinys</param>
    /// <param name="b">Daliklis</param>
    /// <returns>Gražina dalybos rezultatą</returns>
    /// <exception cref="HasToBeMoreException"></exception>
    /// <exception cref="DivideByZeroException"></exception>
    public static int Divide(int a, int b)
    {
        if (a < b)
        {
            throw new HasToBeMoreException("A has to be more when B");
        }
        return a / b;
    }
}

