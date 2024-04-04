using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vozilo
{
    internal class RazredVozilo
    {
        static void Main(string[] args)
        {
        }
    }

    public class Vozilo
    {
        private double gorivo;
        private double kapaciteta;
        private double poraba;

        public Vozilo(double kapaciteta, double poraba)
        {
            if (kapaciteta <= 0)
            {
                throw new ArgumentException("Kapaciteta ne more biti manjša ali enaka 0");
            }
            else if (poraba <= 0)
            {
                throw new ArgumentException("Poraba ne more biti manjša ali enaka 0");
            }
            else
            {
                this.kapaciteta = kapaciteta;
                this.poraba = poraba;
                this.gorivo = kapaciteta;
            }

        }

        public double PreostaliKilometri
        {
            get { return gorivo / poraba * 100; }

        }

        public void Crpalka()
        {
            this.gorivo = this.kapaciteta;
        }

        public bool AliPrevozi(double[] pot)
        {
            for (int i = 1; i < pot.Length; i++)
            {
                if (pot[i - 1] == 0 && pot[i] == 0)
                {
                    throw new ArgumentException("Ne rabimo tankati dvakrat na isti crpalki");
                }
                if (pot[i] < 0)
                {
                    throw new ArgumentException("Razdalja ne more biti negativna");
                }
            }

            foreach (double d in pot)
            {
                if (d == 0) { Crpalka(); }
                if (d > PreostaliKilometri) { return false; }
                gorivo -= d * poraba / 100;
            }

            return true;

        }

        public double Gorivo
        {
            get { return gorivo; }  
        }

        public void Prevozi (double pot)
        {
            if(pot > PreostaliKilometri)
            {
                gorivo = 0;
            }
            else { gorivo -= pot * poraba / 100; }
        }
    }
}