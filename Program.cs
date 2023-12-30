namespace ConsoleApp231229_wlasneWyjatki
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "";
            double r = 0;
            Console.WriteLine("własna obsługa wyjątków");
            Console.WriteLine("\nobliczam pole kwadratu");
            Console.WriteLine("\npodaj promień");
            try
            {
                s= Console.ReadLine();
                r=Double.Parse(s);
                               
                //promień r<=0
                if (r<=0)
                {
                    throw new ArgumentOutOfRangeException("","promień nie może być ujemny");
                }


            }
            catch(ArgumentOutOfRangeException ex) { 
                Console.WriteLine(ex.Message);
            
            }

            


        }
    }
}