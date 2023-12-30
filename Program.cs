namespace ConsoleApp231229_wlasneWyjatki
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "";
            double a = 0;
            Console.WriteLine("własna obsługa wyjątków");
            Console.WriteLine("\nobliczam pole kwadratu");
            Console.WriteLine("\npodaj bok, nieujemny, mniejszy od 100");
            try
            {
                s= Console.ReadLine();
                a=Double.Parse(s);
                               
                //promień r<=0
                if (a<=0)
                {
                    throw new ArgumentOutOfRangeException("","promień nie może być ujemny");
                }

                if (a>=100) {
                    throw new ArithmeticException("liczba ponad 100");
                }

                Console.WriteLine("kwadrat o boku: " + a + " ma pole= " + (a * a));
            }
            catch(ArgumentOutOfRangeException ex) { 
                Console.WriteLine(ex.Message);            
            }
            catch (ArithmeticException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine("bład przy parsowaniu stringa do double");
            }

        }
    }
}