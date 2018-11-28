using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VidasDujeDoNoveGodine
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime NovaGod = new DateTime(DateTime.Now.Year+1,1,1);
            TimeSpan Preostalo = NovaGod - DateTime.Now;

            Console.WriteLine("Do Nove Godine ostalo je {0} dana ,{1} sati ,{2} sekundi. ",Preostalo.Days,Preostalo.Hours,Preostalo.Seconds);
            
            Console.WriteLine("U danima : {0}",Preostalo.TotalDays);
            Console.WriteLine("U satima : {0}",Preostalo.TotalHours);
            Console.WriteLine("U min. : {0}",Preostalo.TotalMinutes);
            Console.WriteLine("U sek. : {0}",Preostalo.TotalSeconds);
            Console.ReadKey();
        }
    }
}
