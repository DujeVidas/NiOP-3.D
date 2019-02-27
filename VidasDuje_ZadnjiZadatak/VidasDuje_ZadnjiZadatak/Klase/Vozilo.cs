using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VidasDuje_ZadnjiZadatak.Klase
{
    class Vozilo
    {
        string vrsta;
        double MaxV;
        int brojKotaca;


        public void setBrojKotaca(int brojKotaca)
        {
            this.brojKotaca = brojKotaca;
        }
        public int getBrojKotaca()
        {
            return this.brojKotaca;
        }
        public void setMaxV(double MaxV)
        {
            this.MaxV = MaxV;
        }
        public double getMaxV()
        {
            return this.MaxV;
        }
        public void setVrsta(string vrsta)
        {
            this.vrsta = vrsta;
        }
        public string getVrsta()
        {
            return this.vrsta;
        }

        public Vozilo(int brojKotaca, string vrsta, int MaxV)
        {
            this.brojKotaca = brojKotaca;
            this.vrsta = vrsta;
            this.MaxV = MaxV;
        }

        public Vozilo()
        {

        }
        public override string ToString()
        {

            return " Vrsta: " + vrsta  + "\n Broj Kotaca: " + brojKotaca + "\n Maksimalna brzina: " + MaxV;
        }
    }
}
