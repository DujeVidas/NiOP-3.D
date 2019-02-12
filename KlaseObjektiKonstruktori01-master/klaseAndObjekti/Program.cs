using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using klaseAndObjekti.Klase;

namespace klaseAndObjekti
{
    class Program
    {
        static void Main(string[] args)
        {
            bool provjeraLet = false, provjeraVoz = false, provjeraPliv = false, generalProvjera = false, another=false ;
            string yeet;
            int kotaci;
            bool let=false, voz=false, pliv=false;
            string vrst, ozn;

            do
            {
                Console.WriteLine("Upsite broj kotaca vozila: ");
                kotaci = Convert.ToInt32(Console.ReadLine());


                Console.WriteLine("\nDa li vozilo leti(Da/Ne): ");

                do
                {
                    yeet = Console.ReadLine();

                    if (yeet == "Da" || yeet == "da")
                    {
                        let = true;
                        provjeraLet = true;
                    }
                    else if (yeet == "Ne" || yeet == "ne")
                    {
                        let = false;
                        provjeraLet = true;
                    }
                    else
                    {
                        Console.WriteLine("Pogresan unos.");
                    }
                } while (provjeraLet == false);


                Console.WriteLine("\nDa li vozilo Vozi(Da/Ne): ");

                do
                {
                    yeet = Console.ReadLine();

                    if (yeet == "Da" || yeet == "da")
                    {
                        voz = true;
                        provjeraVoz = true;
                    }
                    else if (yeet == "Ne" || yeet == "ne")
                    {
                        voz = false;
                        provjeraVoz = true;
                    }
                    else
                    {
                        Console.WriteLine("Pogresan unos.");
                    }
                } while (provjeraVoz == false);


                Console.WriteLine("\nDa li vozilo Pliva(Da/Ne): ");

                do
                {
                    yeet = Console.ReadLine();

                    if (yeet == "Da" || yeet == "da")
                    {
                        pliv = true;
                        provjeraPliv = true;
                    }
                    else if (yeet == "Ne" || yeet == "ne")
                    {
                        pliv = false;
                        provjeraPliv = true;
                    }
                    else
                    {
                        Console.WriteLine("Pogresan unos.");
                    }
                } while (provjeraPliv == false);


                Console.WriteLine("\nUpisite vrstu vozila :");
                vrst = Console.ReadLine();

                Console.WriteLine("\nUpisite oznaku vozila :");
                ozn = Console.ReadLine();

                Console.WriteLine("\n");

                Vozilo nesto = new Vozilo(kotaci, let, pliv, voz, vrst, ozn);

                Console.WriteLine(nesto.ToString());

                Console.WriteLine("Zelite li opet unositi podatke?(Da/Ne)");
                do
                {
                    yeet = Console.ReadLine();
                    if (yeet == "Da" || yeet == "da")
                    {                     
                        generalProvjera = true;

                    }
                    else if (yeet == "Ne" || yeet == "ne")
                    {
                        another = true;
                        generalProvjera = true;
                        
                    }
                    else
                    {
                        Console.WriteLine("Pogresan unos.");
                    }
                } while (generalProvjera == false);
            } while (another == false);
            Console.ReadKey();
        }
    }

    
}
