using Microsoft.VisualStudio.TestTools.UnitTesting;
using Majica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Majica.Tests
{
    [TestClass()]
    public class MajicaTests
    {
        [TestMethod()]
        public void Test1()
        {
            int velikost = 7;
            string barva = "modra";
            string niz = "dolgi";
            Assert.ThrowsException<ArgumentException>(() => new Majica(velikost, barva, niz));
        }

        [TestMethod()]
        public void Test2()
        {
            int velikost = 3;
            string barva = "modra";
            string niz = "neki";
            Assert.ThrowsException<ArgumentException>(() => new Majica(velikost, barva, niz));
        }

        [TestMethod()]
        public void Test3()
        {
            int velikost = 3;
            string barva = "neki neki";
            string niz = "dolgi";
            Assert.ThrowsException<ArgumentException>(() => new Majica(velikost, barva, niz));
        }

    }
}