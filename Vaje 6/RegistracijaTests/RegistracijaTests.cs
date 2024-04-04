using Microsoft.VisualStudio.TestTools.UnitTesting;
using Registracija;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registracija.Tests
{
    [TestClass()]
    public class RegistracijaTests
    {
        [TestMethod()]
        public void RegistracijaTest()
        {
            Assert.ThrowsException<Exception>(() =>
            {
                Registracija r1 = new Registracija("LJ", "7712413");
            });
        }

        [TestMethod()]
        public void TestIzObmocja()
        {
            Random random = new Random();
            string[] obmocja = { "LJ", "KR", "KK", "MB", "MS", "KP", "GO", "CE", "SG", "NM", "PO" };
            string[] tabela = new string[100];
            for (int i = 0; i < 100; i++)
            {
                string obmocje = obmocja[random.Next(obmocja.Length)];
                string registracijska = zgenerirajRegisterske(random);
                tabela[i] = obmocje + registracijska;
            }
            foreach (string ob in obmocja)
            {
                string[] nova = IzObmocja(tabela, ob);
                foreach (string s in nova)
                {
                    if (s != "0")
                    {
                        Assert.IsTrue(s.StartsWith(ob));
                    }
                }
            }
        }

        static string zgenerirajRegisterske(Random random)
        {
            string crka = "1234567890QWERTZUIOPŠĐŽASDFGHJKLČĆYXCVBNM";
            char[] reg = new char[5];
            for (int i = 0; i < 5; i++)
            {
                reg[i] = crka[random.Next(crka.Length)];
            }
            return string.Join("", reg);
        }

        public static string[] IzObmocja(string[] tabela, string obmocje)
        {
            string[] izObmocja = new string[tabela.Length];
            for (int i = 0; i < tabela.Length; i++)
            {
                string ob = tabela[i].Substring(0, 2);
                string re = tabela[i].Substring(2, 5);
                Registracija tablica = new Registracija(ob, re);
                if (tablica.Obmocje == obmocje)
                {
                    izObmocja[i] = tabela[i];
                }
                else
                {
                    izObmocja[i] = "0";
                }
            }
            return izObmocja;
        }


    }
}