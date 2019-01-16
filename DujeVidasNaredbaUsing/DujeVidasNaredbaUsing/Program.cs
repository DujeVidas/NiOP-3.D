using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DujeVidasNaredbaUsing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesite ime: ");
            string ime = Console.ReadLine();

            Console.Write("Unesite Prezime: ");
            string prezime = Console.ReadLine();

            Console.WriteLine("\n-- Zapisujemo u datoteku...");
            using (StreamWriter nesto = new StreamWriter(@"C:\Users\Učenik\Desktop\Yeet.txt"))
            {
                nesto.WriteLine("Ime: {0}", ime);
                nesto.WriteLine("Prezime: {0}", prezime);

            }

            Console.WriteLine("\n-- Pročitano iz datoteke: ");
            using(StreamReader josnesto = new StreamReader(@"C:\Users\Učenik\Desktop\Yeet.txt"))
            {
                while(!josnesto.EndOfStream)
                {
                    Console.WriteLine(josnesto.ReadLine());
                }
            }
            Console.ReadKey();
         }
    }
}
