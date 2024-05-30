using System.Reflection.Metadata.Ecma335;

namespace ConsoleApp2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
          
       
            ReaderAndWriter();
            Püramiid.püramiid();
        }

        static void ReaderAndWriter()
        {
            try
            {
                using (StreamWriter kirjuta = new StreamWriter("C:/Users/opilane/Downloads/suvakas.txt", true))
                {
                    Console.WriteLine("kirjuta midagi naljakat");
                    string lugeja = Console.ReadLine();
                    if (lugeja != "")
                    {
                        kirjuta.Write(lugeja);
                        kirjuta.Close();
                    }
                    else
                    {
                        StreamWriter maja = new StreamWriter("C:/Users/opilane/vooodi/koer.txt");
                        maja.Write(lugeja);
                        maja.Close();

                        }
                    }
                using (StreamReader sr = new StreamReader("C:/Users/opilane/Downloads/suvakas.txt"))
                {
                    string lugeja = sr.ReadToEnd();
                    Console.WriteLine(lugeja);
                }
                }
            catch (Exception ex)
            {
                Console.WriteLine("woopsie mdagi valesti womp womp");
                Console.WriteLine(ex.Message);
            }
                         
        }

    }
    public class Püramiid: Program
    {
        public static void püramiid()
        {
            int i, j, rows;
            int t = 1;
            Console.WriteLine("Numbri püramiid");

            Console.WriteLine("sisesta püramiidi ridade naljakas arv");

            rows = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <= rows; i++)
            {
                for (j = 1; j <= rows - i; j++)
                {
                    Console.Write(" ");
                }
                for (j = 1; j <= 1 * i - 1; j++)
                {
                    Console.Write("{0} ", t++);
                }
                Console.Write("\n");
            }
        }
    }
}