using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registracija
{
    internal class RegistracijaProg
    {
        static void Main(string[] args)
        {
        }
    }

    public class Registracija
    {
        private string obmocje;
        private string registracija;

        // Veljavna območja
        private static HashSet<string> veljavnaObmocja = new HashSet<string>
        {
        "LJ", "KR", "KK", "MB", "MS", "KP", "GO", "CE", "SG", "NM", "PO"
         };

        // pogoji za tablice
        private static bool VeljavnoObmocje(string obmocje)
        {
            return veljavnaObmocja.Contains(obmocje.ToUpper());
        }

        private static bool VeljavnaRegistracija(string registracija)
        {
            return registracija.Length == 5;
        }


        // Konstruktor
        public Registracija(string obmocje, string registracija)
        {
            if (!VeljavnoObmocje(obmocje))
            {
                throw new Exception("Neveljavno območje.");
            }

            if (!VeljavnaRegistracija(registracija))
            {
                throw new Exception("Neveljavna registracija.");
            }

            this.obmocje = obmocje.ToUpper(); // Pretvori v velike črke
            this.registracija = registracija.ToUpper(); // Pretvori v velike črke števila pusti na miru
        }



        // Metode Get/Set
        public string Obmocje
        {
            get { return obmocje; }
            set
            {
                if (!VeljavnoObmocje(value))
                {
                    throw new Exception("Neveljavno območje.");
                }
                obmocje = value.ToUpper();
            }
        }

        public string Registerska
        {
            get { return registracija; }
            set
            {
                if (!VeljavnaRegistracija(value))
                {
                    throw new Exception("Neveljavna registracija.");
                }
                registracija = value.ToUpper();
            }
        }


        public override string ToString()
        {
            return this.obmocje + " " + this.registracija;
        }

        // Metoda za spreminjanje veljavnih območij
        public static void SpremeniVeljavnaObmocjaOdstrani(String Obmocje)
        {
            if (veljavnaObmocja.Contains(Obmocje.ToUpper()))
            {
                veljavnaObmocja.Remove(Obmocje.ToUpper());
            }
        }

        public static void SpremeniVeljavnaObmocjaDodaj(String novaObmocja)
        {
            veljavnaObmocja.Add(novaObmocja.ToUpper());
        }
    }
}
