using System;
using VidasDuje_nestosKlasama.Klase;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace VidasDuje_nestosKlasama
{
    class Program
    {
        static void Main(string[] args)
        {
            Vozilo avijon = new Vozilo();

            avijon.setBrojKotaca(6);
            avijon.setLeti(true);
            avijon.setPliva(false);
            avijon.setVozi(true);
            avijon.setVrsta("Cessna");
            avijon.setOznaka("1312");

            Console.WriteLine(" Vrsta: "+ avijon.getVrsta()+ "\n Oznaka: "+ avijon.getOznaka()
                   +"\n Pliva: "+avijon.getPliva()+"\n Leti: "+ avijon.getLeti() 
                   + "\n Vozi: "+ avijon.getVozi()+"\n \n");

            Vozilo kamijon = new Vozilo(8, false, false, true, "TAM", "Yeet");

            Console.WriteLine(kamijon.ToString());



            Console.ReadKey();
        }
    }
}
