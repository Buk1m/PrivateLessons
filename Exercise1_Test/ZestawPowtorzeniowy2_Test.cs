using System;
using System.Collections.Generic;
using System.Linq;
using Exercise1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercise1_Test
{
    [TestClass]
    public class ZestawPowtorzeniowy2_Test
    {
        [TestMethod]
        public void Cwiczenie1_Test()
        {
            ZestawPowtorzeniowy2 zw2 = new ZestawPowtorzeniowy2();
            int[] testCases = {0, 1, 10, 13};
            List<int[]> expected = new List<int[]>
            {
                new[] {1},
                new[] {1, 2},
                new[] {1, 2, 4, 8, 16, 32, 64, 128, 256, 512, 1024},
                new[] {1, 2, 4, 8, 16, 32, 64, 128, 256, 512, 1024, 2048, 4096, 8192},
            };
            for (int i = 0; i < testCases.Length; i++)
            {
                var result = zw2.Cwiczenie1(testCases[i]);
                Assert.IsTrue(expected[i].SequenceEqual(result),
                    $"Dla wartosci n={testCases[i]} oczekiwany wynik to " +
                    $"[{string.Join(",", expected[i].Select(x => x.ToString()).ToArray())}] " +
                    $"twoja odpowiedz to [{string.Join(",", result.Select(x => x.ToString()).ToArray())}] "
                );
            }
        }

        [TestMethod]
        public void Cwiczenie2_Test()
        {
            ZestawPowtorzeniowy2 zw2 = new ZestawPowtorzeniowy2();
            List<int[]> testTables = new List<int[]>
            {
                new[] {33, 1, 2, 3, 4, 31, 32,},
                new[] {0},
                new[] {-1, -8, -2, -3, -4, -9, -5, -6, -7},
                new[] {-100, 100, -200, 300, 20, 10}
            };
            List<int[]> expected = new List<int[]>
            {
                new[] {1, 33},
                new[] {0, 0},
                new[] {-9, -1},
                new[] {-200, 300}
            };

            for (int i = 0; i < testTables.Count; i++)
            {
                int[] result = zw2.Cwiczenie2(testTables[i]);
                Assert.AreEqual(expected[i].Length, result.Length,
                    $"Dlugość oczekiwanej tablicy to '{expected[i].Length}', twoja tablica ma dlugosc '{result.Length}'");
                for (int j = 0; j < expected[i].Length; j++)
                {
                    Assert.AreEqual(expected[i][j], result[j],
                        "Dla tablicy: [" + string.Join(",", testTables[i].Select(x => x.ToString()).ToArray()) +
                        "] oczekiwany wynik: \"[" + string.Join(",", expected[i].Select(x => x.ToString()).ToArray()) +
                        "]\", twoj wynik: \"[" + string.Join(",", result.Select(x => x.ToString()).ToArray()) + "]\".");
                }
            }
        }

        [TestMethod]
        public void Cwiczenie3_Test()
        {
            ZestawPowtorzeniowy2 zw2 = new ZestawPowtorzeniowy2();
            string[] testStrings =
            {
                "Musisz wiecej cwiczyc", "Ala ma kota", "Carpe Diem", "Subscribe to PewDiePie", "", "aeuioyAEUIOY",
                "qwrtpsdfghjklzxcvbnmQWRTPSDFGHJKLZXCVBNM"
            };
            List<int[]> expected = new List<int[]>
            {
                new[] {7, 12},
                new[] {5, 4},
                new[] {4, 5},
                new[] {9, 11},
                new[] {0, 0},
                new[] {12, 0},
                new[] {0, 40}
            };

            for (int i = 0; i < testStrings.Length; i++)
            {
                var result = zw2.Cwiczenie3(testStrings[i]);
                Assert.AreEqual(expected[i].Length, result.Length,
                    $"Dlugość oczekiwanej tablicy z wynikiem to '{expected[i].Length}', twoja tablica ma dlugosc '{result.Length}'");
                for (int j = 0; j < expected[i].Length; j++)
                {
                    Assert.AreEqual(expected[i][j], result[j],
                        "Dla napisu: \"" + testStrings[i] +
                        "\" oczekiwany wynik: \"[" + string.Join(",", expected[i].Select(x => x.ToString()).ToArray()) +
                        "]\", twoj wynik: \"[" + string.Join(",", result.Select(x => x.ToString()).ToArray()) + "]\".");
                }
            }
        }

        [TestMethod]
        public void Cwiczenie4_Test()
        {
            ZestawPowtorzeniowy2 zw2 = new ZestawPowtorzeniowy2();
            List<int> tab = new List<int>();
            for (int i = 0; i < 128; i++)
            {
                tab.Add(i);
            }

            List<int[]> testTables = new List<int[]>
            {
                new[]
                {
                    1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21,
                    22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33
                },
                tab.ToArray(),
                new[]
                {
                    0, 0, 0, 0, 0, 0, 0
                },
                new[]
                {
                    -1, -2, -3, -4, -5, -6, -7, -8, -9
                }
            };

            int[] expected = {69, 127, 0, -19};
            for (int i = 0; i < testTables.Count; i++)
            {
                int result = zw2.Cwiczenie4(testTables[i]);
                Assert.AreEqual(expected[i], result,
                    "Dla tablicy: [" + string.Join(",", testTables[i].Select(x => x.ToString()).ToArray()) +
                    "] oczekiwany wynik: \"" + expected[i] + "\", twoj wynik: \"" + result + "\".");
            }
        }

        [TestMethod]
        public void Cwiczenie5_Test()
        {
            ZestawPowtorzeniowy2 zw2 = new ZestawPowtorzeniowy2();
            List<string[]> testStrings = new List<string[]>
            {
                new[] {"Adam", "Kamil", "Kasia", "Ewa", "Wojtek"},
                new[] {"Kamila", "Franek", "Asia", "Bartek", "Iwona"},
                new[] {"Amadeusz", "Mieczyslawa", "Genowefa", "Andrzej", "Janusz"}
            };
            List<char[]> expected = new List<char[]>
            {
                new[] {'m', 'm', 'k', 'k', 'm'},
                new[] {'k', 'm', 'k', 'm', 'k'},
                new[] {'m', 'k', 'k', 'm', 'm'}
            };

            for (int i = 0; i < testStrings.Count; i++)
            {
                for (int j = 0; j < testStrings[i].Length; j++)
                {
                    var result = zw2.Cwiczenie5(testStrings[i][j]);
                    Assert.AreEqual(expected[i][j], result,
                        "Dla imienia: \"" + testStrings[i][j] +
                        "\" oczekiwany wynik: \"" + expected[i][j] + "\", twoj wynik: \"" + result + "\".");
                }
            }
        }
    }
}