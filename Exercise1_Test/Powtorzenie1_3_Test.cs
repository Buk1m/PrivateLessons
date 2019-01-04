using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Exercise1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercise1_Test
{
    [TestClass]
    public class Powtorzenie1_3_Test
    {
        [TestMethod]
        public void Cwiczenie1Test()
        {
            Powtorzenie1_3 pow = new Powtorzenie1_3();
            List<List<int>> testTables = new List<List<int>>
            {
                new List<int> {1, 2, 3, 4, 5},
                new List<int> {0, 0, 0, 0, 0},
                new List<int> {-10, 22, 33, 44, 111, -153, 234},
                new List<int> {2, -4, 6, -8, 0},
                new List<int> {-1, -3, -5, -8},
            };
            int[] expected = {15, 0, 281, -4, -17};
            for (int i = 0; i < testTables.Count; i++)
            {
                Assert.AreEqual(expected[i], pow.Cwiczenie1(testTables[i].ToArray()));
            }
        }

        [TestMethod]
        public void Cwiczenie2Test()
        {
            Powtorzenie1_3 pow = new Powtorzenie1_3();
            List<List<int>> testTables = new List<List<int>>
            {
                new List<int> {1, 2, 3, 4, 5},
                new List<int> {0, 0, 0, 0, 0},
                new List<int> {-10, 24, 33, 42, 111, -180, 234},
                new List<int> {2, -4, 6, -8, 0},
                new List<int> {-1, -36, -5, -12},
            };
            List<List<bool>> expected = new List<List<bool>>
            {
                new List<bool> {false, false, false, false, false},
                new List<bool> {true, true, true, true, true},
                new List<bool> {false, true, false, true, false, true, true},
                new List<bool> {false, false, true, false, true},
                new List<bool> {false, true, false, true},
            };

            for (int i = 0; i < testTables.Count; i++)
            {
                var result = pow.Cwiczenie2(testTables[i].ToArray());
                for (int j = 0; j < testTables[i].Count; j++)
                {
                    Assert.AreEqual(expected[i][j], result[j],
                        "Liczba \'" + testTables[i][j] +
                        "\' nie jest podzielna przez \'2\' i \'3\' bez reszty. \n expected: " + expected[i][j] +
                        "\n actual: " + result[j]);
                }
            }
        }

        [TestMethod]
        public void Cwiczenie3Test()
        {
            Powtorzenie1_3 pow = new Powtorzenie1_3();
            string[] testStrings =
            {
                "Ala ma kota!", "Fortnite", "Boom headshot", "Kartkowka nadchodzi", "I tak nie dasz rady",
                "muahhahaha", ""
            };
            char[] testChars = {'a', 't', 'o', 'x', ' ', 'h', ' '};
            int[] expected = {3, 2, 3, 0, 4, 4, 0};
            for (int i = 0; i < testStrings.Length; i++)
            {
                var result = pow.Cwiczenie3(testStrings[i], testChars[i]);
                Assert.AreEqual(expected[i], result,
                    "Litera \'" + testChars[i] + "\' wystepuje w napisie \"" + testStrings[i] + "\" " + expected[i] +
                    " razy.\nTwoja funkcja zwrocila: " + result + ".");
            }
        }

        [TestMethod]
        public void Cwiczenie4Test()
        {
            Powtorzenie1_3 pow = new Powtorzenie1_3();
            string[] testStrings =
            {
                "Ala ma kota!", "Fortnite", "Boom headshot", "Kartkowka nadchodzi", "I tak nie dasz rady",
                "muahhahahah"
            };
            char[] expected = {'a', 't', 'o', 'a', ' ', 'h'};

            for (int i = 0; i < testStrings.Length; i++)
            {
                var result = pow.Cwiczenie4(testStrings[i]);
                Assert.AreEqual(expected[i], result);
            }
        }

        [TestMethod]
        public void Cwiczenie5Test()
        {
            Powtorzenie1_3 pow = new Powtorzenie1_3();
            string[] testStrings =
            {
                "Ala ma kota!", "Fortnite", "Boom headshot", "Kartkowka nadchodzi", "I tak nie dasz rady",
                "muahhahahah"
            };
            string[] expected = {"Ala ma", "Fort", "Boom h", "Kartkowka", "I tak nie", "muahh"};

            for (int i = 0; i < testStrings.Length; i++)
            {
                Assert.AreEqual(expected[i], pow.Cwiczenie5(testStrings[i]));
            }
        }

        [TestMethod]
        public void Cwiczenie6Test()
        {
            using (StringWriter stringWriter = new StringWriter())
            {
                Console.SetOut(stringWriter);
                Powtorzenie1_3 pow = new Powtorzenie1_3();
                List<int[]> testTables = new List<int[]>
                {
                    new[] {1, 2, 3, 4, 5},
                    new[] {0, 0, 0, 0, 0},
                    new[] {-10, 24, 33, 42, 111, -180, 234},
                    new[] {2, -4, 6, -8, 0},
                };
                string[] expected = {"12345", "00000", "-10243342111-180234", "2-46-80"};
                for (int i = 0; i < testTables.Count; i++)
                {
                    pow.Cwiczenie6(testTables[i]);
                    string result = stringWriter.ToString().Trim();

                    var sb = stringWriter.GetStringBuilder();
                    sb.Remove(0, sb.Length);

                    Assert.AreEqual(expected[i], result,
                        "Dla tablicy: [" + string.Join(",", testTables[i].Select(x => x.ToString()).ToArray()) +
                        "] oczekiwany wynik: \"" + expected[i] + "\", twoj wynik: \"" + result + "\".");
                }
            }
        }

        [TestMethod]
        public void Cwiczenie7Test()
        {
            using (StringWriter stringWriter = new StringWriter())
            {
                Console.SetOut(stringWriter);
                Powtorzenie1_3 pow = new Powtorzenie1_3();
                string[] testStrings =
                {
                    "Fortnite", "Boom", "Kartkowka", "muahhahahah"
                };
                int[] times = {2, 1, 3, 4};
                string[] expected =
                {
                    "FortniteFortnite", "Boom", "KartkowkaKartkowkaKartkowka",
                    "muahhahahahmuahhahahahmuahhahahahmuahhahahah"
                };
                for (var i = 0; i < testStrings.Length; i++)
                {
                    pow.Cwiczenie7(testStrings[i], times[i]);
                    string result = stringWriter.ToString().Trim();
                    var sb = stringWriter.GetStringBuilder();
                    sb.Remove(0, sb.Length);
                    Assert.AreEqual(expected[i], result,
                        "Dla napisu: \"" + testStrings[i] +
                        "\" oczekiwany wynik: \"" + expected[i] + "\", twoj wynik: \"" + result + "\".");
                }
            }
        }

        [TestMethod]
        public void Cwiczenie8Test()
        {
            using (StringWriter stringWriter = new StringWriter())
            {
                Console.SetOut(stringWriter);

                Powtorzenie1_3 pow = new Powtorzenie1_3();

                int[] a1 = {1, 2, 3, 4, 5};
                int[] a2 = {2, 3, 4, 5, 0};
                int[] h1 = {2, 3, 4, 5, 6};
                int[] h2 = {5, 6, 7, 8, 9};
                string expected1 = "1361015";
                string expected2 = "5914200";

                pow.Cwiczenie8(a1, h1);
                string result = stringWriter.ToString().Trim();
                Assert.AreEqual(expected1, result,
                    "Dla tablicy a: [" + string.Join(",", a1.Select(x => x.ToString()).ToArray()) +
                    "] oraz tablicy h: [" +
                    string.Join(",", h1.Select(x => x.ToString()).ToArray()) + "] oczekiwano \"" + expected1 +
                    "\", twoj wynik: \"" +
                    result + "\".");

                var sb = stringWriter.GetStringBuilder();
                sb.Remove(0, sb.Length);

                pow.Cwiczenie8(a2, h2);
                result = stringWriter.ToString().Trim();
                Assert.AreEqual(expected2, result,
                    "Dla tablicy a: [" + string.Join(",", a2.Select(x => x.ToString()).ToArray()) +
                    "] oraz tablicy h: [" +
                    string.Join(",", h2.Select(x => x.ToString()).ToArray()) + "] oczekiwano \"" + expected2 +
                    "\", twoj wynik: \"" +
                    result + "\".");
            }
        }


        [TestMethod]
        public void Cwiczenie9Test()
        {
            Powtorzenie1_3 pow = new Powtorzenie1_3();
            List<int[]> testTables = new List<int[]>
            {
                new[] {1, 2, 3, 4, 5},
                new[] {0, 0, 0, 0, 0},
                new[] {-10, 24, 33, 42, 111, -180, 234},
                new[] {2, -4, 6, -8, 1},
            };
            int[] expected = {6, 0, 110, -4};
            for (int i = 0; i < testTables.Count; i++)
            {
                var result = pow.Cwiczenie9(testTables[i]);
                Assert.AreEqual(expected[i], result,
                "Dla tablicy: [" + string.Join( ",", testTables[ i ].Select( x => x.ToString() ).ToArray() ) +
                    "] oczekiwany wynik: \"" + expected[ i ] + "\", twoj wynik: \"" + result + "\"." );

            }
        }
    }
}