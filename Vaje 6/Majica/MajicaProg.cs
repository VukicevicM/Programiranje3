using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Majica
{
    internal class MajicaProg
    {
        static void Main(string[] args)
        {
        }
    }
    public class Majica
    {
        public int velikost;
        public String barva;
        public bool kratki_rokavi;

        private int Najmanjsa = 1;
        private int Najvecja = 5;

        private List<string> Barve = new List<string> {"rdeca", "modra", "rumena", "zelena"};

        public Majica(int velikost, String barva, String dolzinaRokavov)
        {
            
            if (velikost < Najmanjsa || velikost > Najvecja)
            {
                throw new ArgumentException("To ni velikost majce");
            }
            else { this.velikost = velikost; }
            if (dolzinaRokavov != "kratki" && dolzinaRokavov != "dolgi")
            {
                throw new ArgumentException("Napačna dolžina rokavov. Dolžina rokavov mora biti 'kratki' ali 'dolgi'.");
            }
            kratki_rokavi = (dolzinaRokavov == "kratki");

            bool barvaJeDovoljena = false;
            foreach (string dovoljenaBarva in Barve)
            {
                if (dovoljenaBarva == barva)
                {
                    barvaJeDovoljena = true;
                    break;
                }
            }

            if (!barvaJeDovoljena)
            {
                throw new ArgumentException("Nedovoljena barva majice.");
            }
            else
            {
                this.barva = barva;
            }
        }

        public void DodajBarvo(String barva)
        {
            Barve.Add(barva);
        }

        public void OdvzamiBarvo(string barva)
        {
            if (!Barve.Contains(barva))
            {
                throw new ArgumentException("Barva ni med dovoljenimi.");
            }
            Barve.Remove(barva);
        }

        public void PovejBarve()
        {
            Console.WriteLine("Dovoljene barve:");
            foreach (var barva in Barve)
            {
                Console.WriteLine(barva);
            }
        }

    }
}
