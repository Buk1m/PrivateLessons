using System;
using System.Collections.Generic;
using Exercise1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercise1_Test
{
    [TestClass]
    public class Sprawdzian1_Test
    {

        [TestMethod]
        public void TestZadanie1()
        {
            const string p = "parzysta", n = "nieparzysta";
            Sprawdzian1 spr = new Sprawdzian1();
            List<List<int>> testTables = new List<List<int>>
            {
                new List<int> {1, 2, 3, 4, 5},
                new List<int> {0, 0, 0, 0, 0},
                new List<int> {-10, 22, 33, 44, 111, -153, 234},
                new List<int> {2, -4, 6, -8, 0},
                new List<int> {-1, -3, -5, -8},
            };

            List<string> expected = new List<string>
                {n, p, n, p, n};

            for (int i = 0; i < testTables.Count; i++)
            {
                var actual = spr.Zadanie1(testTables[i].ToArray());
                Assert.AreEqual(expected[i], actual);
            }
        }

        [TestMethod]
        public void TestZadanie2()
        {
            Sprawdzian1 spr = new Sprawdzian1();
            var a = new List<float> {1.1f, 2.5f, 3.1f, 4, 5, 6};
            var b = new List<float> {-4.2f, -6, 2, 0, 4, 5};
            var d = new List<string> {"dodaj", "odejmij", "pomnoz", "podziel", "podziel", "modulo"};
            var expected = new List<float> {-3.1f, 8.5f, 6.2f, 0, 1.25f, 1};


            for (int i = 0; i < d.Count; i++)
            {
                var result = spr.Zadanie2(a[i], b[i], d[i]);
                if (double.IsInfinity(result))
                {
                    throw new DivideByZeroException();
                }
                Assert.AreEqual(expected[i], result);
            }
        }

        [TestMethod]
        public void TestZadanie3()
        {
            Sprawdzian1 spr = new Sprawdzian1();
            int[] tabA = { 1, -2, 3, -4, 5, -6, 7, -8 };
            int[] tabB = { 0, -2, 5, -10, 5, 100, 200, -800 };
            string expectedAB = ">=<>=<<>";
            int[] tabC = { -10, 12, 33, 45435, -2352345, 432, 200, 2137 };
            int[] tabD = { 0, -2, 33, 555510, 5, 100, 200, -800 };
            string expectedCD = "<>=<<>=>";

            Assert.AreEqual(expectedAB, spr.Zadanie3( tabA, tabB ) );
            Assert.AreEqual(expectedCD, spr.Zadanie3( tabC, tabD ) );
  
        }
        
    }
}