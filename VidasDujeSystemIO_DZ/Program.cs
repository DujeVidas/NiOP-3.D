using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VidasDujeSystemIO_DZ
{
    class Program
    {
        static void Main(string[] args)
        {
            //3.4.1 klasa Directory
            /*

            Console.Write("Unesite putanju direktorija: ");
            string putanja = Console.ReadLine();
            
            
            if (Directory.Exists(putanja))
            {
                Console.WriteLine("Datoteke:");
                foreach (string datoteka in Directory.GetFiles(putanja))
                {
                    Console.WriteLine(datoteka);
                }
                
               
                string putanjaPoddirektorija = putanja + "\\TEST";
                if (!Directory.Exists(putanjaPoddirektorija))
                {
                    
                    Directory.CreateDirectory(putanjaPoddirektorija);
                }
                
               
                Console.WriteLine("Poddirektoriji:");
                foreach (string poddirektorij in Directory.GetDirectories(putanja))
                {
                    Console.WriteLine(poddirektorij);
                }
                
                
                Directory.Delete(putanjaPoddirektorija);
                
                
                Console.WriteLine("Nakon brisanja direktorija TEST:");
                foreach (string poddirektorij in Directory.GetDirectories(putanja))
                {
                    Console.WriteLine(poddirektorij);
                }
            }
            else
            {
                Console.WriteLine("Putanja ne postoji na računalu!");
            }*/

            Console.WriteLine();
            //3.4.2. klasa File

            /*Console.Write("Unesite Vaše ime: ");
            string ime = Console.ReadLine();
            string datoteka2 = "ime.txt";
            
            if (File.Exists(datoteka2))
            {
                
                if (!Directory.Exists("backup"))
                {
                    Directory.CreateDirectory("backup");
                }
                File.Copy(datoteka2, "backup\\ime_"+DateTime.Now.ToString("yyyy_MM_dd_HH_mm_ss+")+ ".txt");
              
                File.Delete(datoteka2);
            }
            
            File.WriteAllText(datoteka2, ime);*/


            Console.WriteLine();
            //3.4.3 klasa Path

            Console.Write("Unesite putanju izvornog direktorija:");
            string izvorniDirektorij = Console.ReadLine();
            Console.Write("Unesite putanju ciljnog direktorija:");
            string ciljniDirektorij = Console.ReadLine();
            try
            {
               
                foreach (string datoteka3 in Directory.GetFiles(izvorniDirektorij))
                {
                    
                    string imeDatoteke = Path.GetFileName(datoteka3);

                    
                    string ciljnaDatoteka = Path.Combine(ciljniDirektorij, imeDatoteke);

                   
                    File.Copy(datoteka3, ciljnaDatoteka, true);
                }
                Console.WriteLine("Gotovo!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Greška: { 0}", ex.Message);
            }

           
            Console.Write("Unesite putanju direktorija: ");
            string putanja = Console.ReadLine();

            
            DirectoryInfo diIzvor = new DirectoryInfo(putanja);

           
            Console.WriteLine("\n-- Poddirektoriji:");
            foreach (DirectoryInfo di in diIzvor.GetDirectories())
            {
                Console.WriteLine("{ 0}\t{ 1}\t{ 2}", di.Name, di.CreationTime, di.LastAccessTime);

            }

     
            Console.WriteLine("\n-- Datoteke:");
            foreach (FileInfo fi in diIzvor.GetFiles())
            {
                Console.WriteLine("{ 0}\t{ 1}\t{ 2}", fi.Name, fi.CreationTime, fi.LastAccessTime);

            }


            Console.ReadKey();
        }
    }
}