namespace ExceptionHandeling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            try
            {
                double result = Convert.ToDouble(input);
                Console.WriteLine($"Konvertuota reiksme: {result}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Neteisingas formatas. Irasykite tinkama skaiciu.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Skaicius yra per didelis arba per mazas.");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Irasyta reikssme yra null.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
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

            //}

        }

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
}
