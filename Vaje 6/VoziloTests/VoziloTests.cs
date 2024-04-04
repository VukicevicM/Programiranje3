using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vozilo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vozilo.Tests
{
    [TestClass()]
    public class VoziloTests
    {
        [TestMethod()]
        public void Konstruktor()
        {
            double kapaciteta = 50;
            double poraba = 10;

            Vozilo vozilo = new Vozilo(kapaciteta, poraba);

            Assert.AreEqual(kapaciteta, vozilo.Gorivo);
        }

        [TestMethod()]
        public void Konstruktor2() 
        {
            double kapaciteta = -50;
            double poraba = 10;


            Assert.ThrowsException<ArgumentException>(() => new Vozilo(kapaciteta, poraba));

        }

        [TestMethod()]
        public void Konstruktor3()
        {
            double kapaciteta = 50;
            double poraba = -10;


            Assert.ThrowsException<ArgumentException>(() => new Vozilo(kapaciteta, poraba));

        }

        [TestMethod()]
        public void Prevozi() {

            double kapaciteta = 50;
            double poraba = 10;

            Vozilo vozilo = new Vozilo(kapaciteta, poraba);

            vozilo.Prevozi(100);

            Assert.IsTrue(kapaciteta > vozilo.Gorivo);
        }

        [TestMethod()]
        public void Crpalka()
        {
            double kapaciteta = 50;
            double poraba = 10;

            Vozilo vozilo = new Vozilo(kapaciteta, poraba);

            vozilo.Prevozi(15);
            vozilo.Crpalka();

            Assert.AreEqual(vozilo.Gorivo, kapaciteta);

        }

        [TestMethod()]
        public void AliPrevoziTest1()
        {
            double kapaciteta = 50;
            double poraba = 5;
            double[] pot = { 10, 20, 5 };
            Vozilo vozilo = new Vozilo(kapaciteta, poraba);

            bool uspesno = vozilo.AliPrevozi(pot);

            Assert.IsTrue(uspesno);
        }

        [TestMethod()]
        public void AliPrevoziTest2()
        {
            double kapaciteta = 5;
            double poraba = 5;
            double[] pot = { 99, 0, 100 };
            Vozilo vozilo = new Vozilo(kapaciteta, poraba);

            bool uspesno = vozilo.AliPrevozi(pot);

            Assert.IsTrue(uspesno);
        }
        [TestMethod()]
        public void AliPrevoziTest3()
        {
            double kapaciteta = 5;
            double poraba = 5;
            double[] pot = { 99, 5, 100 };
            Vozilo vozilo = new Vozilo(kapaciteta, poraba);

            bool uspesno = vozilo.AliPrevozi(pot);

            Assert.IsFalse(uspesno);
        }
    }
}