using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kosarica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kosarica.Tests
{
    [TestClass()]
    public class KosaricaTests
    {
        [TestMethod()]
        public void KosaricaTest1()
        {
            String niz = "blablabla";
            Kosarica<String> shrani = new Kosarica<String>(niz);

            Assert.AreEqual(shrani.ToString(), niz);
        }
        [TestMethod()]
        public void KosaricaTest2()
        {
            String niz = "blablabla";
            Kosarica<String> shrani = new Kosarica<String>(niz);

            Assert.AreEqual(shrani.Vsebina, niz);
        }
        [TestMethod()]
        public void KosaricaTest3()
        {
            String niz = "blablabla";
            Kosarica<String> shrani = new Kosarica<String>(niz);
            shrani.Vsebina = "abc";
            Assert.AreEqual(shrani.Vsebina, "abc");
        }
        [TestMethod]
        public void KosaricaTest_Int()
        {
            int vsebina = 42;
            Kosarica<int> kosarica = new Kosarica<int>(vsebina);
            int dejanskaVsebina = kosarica.Vsebina;
            Assert.AreEqual(vsebina, dejanskaVsebina);
        }

        [TestMethod]
        public void KosaricaTest()
        {
            double vsebina = 3.14;
            Kosarica<double> kosarica = new Kosarica<double>(vsebina);
            string nizVsebine = kosarica.ToString();
            Assert.AreEqual(vsebina.ToString(), nizVsebine);
        }


        [TestMethod]
        public void KosaricaNizStevil()
        {
            int[] vsebina = new int[] { 1, 2, 3, 4, 5 };
            Kosarica<int[]> kosarica = new Kosarica<int[]>(vsebina);
            string nizVsebine = kosarica.ToString();
            Assert.AreEqual(vsebina.ToString(), nizVsebine);
        }
    }
}