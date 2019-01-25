using System;
using System.Collections.Generic;
using Exercise1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercise1_Test
{
    [TestClass]
    public class StringCwiczenia_Test
    {
        [TestMethod]
        public void Cwiczenie1Test()
        {
            StringCwiczenia sc = new StringCwiczenia();
            string test1 = "testtesttesttestneedletesttestresttest";
            Assert.AreEqual(true, sc.Cwiczenie1("needle", test1));
            Assert.AreEqual(true, sc.Cwiczenie1("test", test1));
            Assert.AreEqual(true, sc.Cwiczenie1("stte", test1));
            Assert.AreEqual(true, sc.Cwiczenie1("rest", test1));
            Assert.AreEqual(false, sc.Cwiczenie1("lolz", test1));
            Assert.AreEqual(false, sc.Cwiczenie1("nope", test1));
        }

        [TestMethod]
        public void Cwiczenie2Test()
        {
            StringCwiczenia sc = new StringCwiczenia();

            List<string> pliki1 = new List<string>
            {
                "prezentacja.pttx",
                "screenshot.png",
                "document.odt",
                "zdjecie.jpg",
                "muzyka.mp3",
                "fotografia.jpg",
                "film.mp4",
                "cos.png",
                "wektor.png",
                "test.png",
            };
            var result1 = sc.Cwiczenie2(pliki1, ".jpg");
            var result2 = sc.Cwiczenie2(pliki1, ".png");
            Assert.AreEqual(2, result1.Count);
            Assert.AreEqual(4, result2.Count);
        }

        [TestMethod]
        public void Cwiczenie3Test()
        {
            string napis1 = "testtestatesttes";
            string napis2 = "FranekFranekAmanekFranek";
            int expected1 = 8, expected2 = 5;
            StringCwiczenia sc = new StringCwiczenia();

            Assert.AreEqual(expected1, sc.Cwiczenie3(napis1, 'a'));
            Assert.AreEqual(expected2, sc.Cwiczenie3(napis2, 'k'));
        }

        [TestMethod]
        public void Cwiczenie4Test()
        {
            string napis1 = "aaaaaaaaaaaaaaaaaaaaaaaaaa";
            string napis2 = "bbbbbbbbbbbbbbbbbbbbbbbbbb";
            string expected1 = "aaaaaaaaaaaaaaaaaaaabbbbbbbbbbbbbbbbbbbbbbbbbbaaaaaa";
            string expected2 = "bbbbbbbbbbbbbbbbbbbbaaaaaaaaaaaaaaaaaaaaaaaaaabbbbbb";

            StringCwiczenia sc = new StringCwiczenia();
            Assert.AreEqual(expected1, sc.Cwiczenie4(napis1, napis2));
            Assert.AreEqual(expected2, sc.Cwiczenie4(napis2, napis1));
        }

        [TestMethod]
        public void Cwiczenie5Test()
        {
            string napis1 = "testtestatesttes";
            string napis2 = "FqrqanekFranekAmanekFranek";
            StringCwiczenia sc = new StringCwiczenia();

            Assert.AreEqual(13, sc.Cwiczenie5(napis1, 't'));
            Assert.AreEqual(3, sc.Cwiczenie5(napis2, 'q'));
        }
        //        public void Cwiczenie6Test()
        //        {
        //            string napis1 = "aaaaaaaaaaaaaaaaaaaaaaaaaa";
        //            string napis2 = "bbbbbbbbbbbbbbbbbbbbbbbbbb";
        //            string expected1 = "aaaaaaaaaaaaaaaaaaaabbbbbbbbbbbbbbbbbbbbbbbbbbaaaaaa";
        //            string expected2 = "bbbbbbbbbbbbbbbbbbbbaaaaaaaaaaaaaaaaaaaaaaaaaabbbbbb";
        //
        //            StringCwiczenia sc = new StringCwiczenia();
        //            Assert.AreEqual(expected1, sc.Cwiczenie4(napis1, napis2));
        //            Assert.AreEqual(expected2, sc.Cwiczenie4(napis2, napis1));
        //
        //        }

        [TestMethod]
        public void PracaDomowaTest()
        {
            StringCwiczenia sc = new StringCwiczenia();
            List<string> listaGosci1 = new List<string>
            {
                "1. Michal Kowalski 21:00",
                "2. Anna Kowalska 21:30",
                "21. Jan Kowalski 20:12",
                "41. Kamil Kowalski 22:21",
                "11. Maciej Kowalski 21:00",
                "221. Kuba Kowalski 20:21",
                "211. Kamila Kowalska 20:21",
                "10. Zaneta Kowalska 21:00"
            };
            List<string> listaGosci2 = new List<string>
            {
                "221. Michal Kowalski 22:00",
                "211. Anna Kowalska 23:21",
                "21. Jan Kowalski 20:12",
                "41. Kamil Kowalski 22:21",
                "11. Maciej Kowalski 21:00",
                "1. Maciej Kowalski 20:21",
                "2. Kamila Kowalska 21:00",
                "10. Zaneta Kowalska 21:21"
            };

            Assert.AreEqual(4, sc.PracaDomowa(listaGosci1).Count);
            Assert.AreEqual(3, sc.PracaDomowa(listaGosci2).Count);
        }

        [TestMethod]
        public void PracaDomowa2Test()
        {
            StringCwiczenia sc = new StringCwiczenia();
            string napis1 =
                "Imie:Ania;Imie:Kasia;Imie:Kamil;Imie:Wojtek;Imie:Marta;Imie:Marcel;Imie:Franek;Imie:Ola;Imie:Bartek";
            string napis2 =
                "Imie:Ania;Imie:Marta;Imie:Marcel;Imie:Franek;Imie:Ola;Imie:Bartek";
            string[] expected1 =
            {
                "Ania", "Kasia", "Kamil", "Wojtek", "Marta", "Marcel", "Franek", "Ola", "Bartek"
            };
            string[] expected2 =
            {
                "Ania", "Marta", "Marcel", "Franek", "Ola", "Bartek"
            };

            var result1 = sc.PracaDomowa2(napis1);
            var result2 = sc.PracaDomowa2(napis2);
            Assert.AreEqual(expected1.Length, result1.Length, "Nieprawidlowa ilosc elementow w tablicy");
            Assert.AreEqual(expected2.Length, result2.Length, "Nieprawidlowa ilosc elementow w tablicy");

            for (int i = 0; i < result1.Length; i++)
            {
                Assert.AreEqual(expected1[i], result1[i], "Elementy sie nie zgadzają!");
            }

            for (int i = 0; i < result2.Length; i++)
            {
                Assert.AreEqual(expected2[i], result2[i], "Elementy sie nie zgadzają!");
            }
        }
    }
}