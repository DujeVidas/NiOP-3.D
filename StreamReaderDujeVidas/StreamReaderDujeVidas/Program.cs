using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamReaderDujeVidas
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader nesto = new StreamReader(@"C:\Users\Učenik\Desktop\Yeet.txt");
            
            while(!nesto.EndOfStream)
            {
                Console.WriteLine(nesto.ReadLine());
            }

            nesto.Close();

            Console.ReadKey();
        }
    }
}
