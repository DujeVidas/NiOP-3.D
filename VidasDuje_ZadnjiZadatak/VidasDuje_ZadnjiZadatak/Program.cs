using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VidasDuje_ZadnjiZadatak.Klase;

namespace VidasDuje_ZadnjiZadatak
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Vozilo Motor = new Vozilo();
            Motor.setVrsta("Motor");
            Motor.setBrojKotaca(2);
            Console.Write(" \n Upisite maksimalnu brzinu Motocikla: ");
            Motor.setMaxV(Convert.ToInt32(Console.ReadLine()));

            Vozilo Auto = new Vozilo();
            Auto.setVrsta("Automobil");
            Auto.setBrojKotaca(4);
            Auto.setMaxV(Motor.getMaxV()*1.30);

            Console.WriteLine(Motor.ToString());
            Console.WriteLine(Auto.ToString());

            Console.ReadKey();
        }
    }
}
