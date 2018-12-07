using System;
using System.Linq;
using System.Runtime.Remoting;
using Exercise1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercise1_Test
{
    [TestClass]
    public class ZestawCwiczen0_Test
    {
        [TestMethod]
        public void TestCwiczenie0()
        {
            ZestawCwiczen0 zc0 = new ZestawCwiczen0();
            try
            {
                zc0.cwiczenie1();
            }
            catch (NotImplementedException ex)
            {
                throw new InternalTestFailureException();
            }
        }

        [TestMethod]
        public void TestCwiczenie2()
        {
            ZestawCwiczen0 zc = new ZestawCwiczen0();

            double[] d = zc.cwiczenie2();
            double[] d2 = new double[] {1, -1.13, -6};

            Assert.AreEqual(d.Length, d2.Length);

            for (int i = 0; i < d.Length; i++)
            {
                Assert.AreEqual(d[i], d2[i]);
            }
        }

        [TestMethod]
        public void testCwiczenie3()
        {
            ZestawCwiczen0 zc = new ZestawCwiczen0();

            double[] d = zc.cwiczenie3();
            double[] d2 = new double[] {1, 3, 1, 3, 1, 3, 1, 3};

            Assert.AreEqual(d.Length, d2.Length);

            for (int i = 0; i < d.Length; i++)
            {
                Assert.AreEqual(d[i], d2[i]);
            }
        }

        [TestMethod]
        public void testCwiczenie4()
        {
            ZestawCwiczen0 zc = new ZestawCwiczen0();

            bool result = zc.cwiczenie4();
            if (result)
            {
                throw new AssertFailedException();
            }
        }

        [TestMethod]
        public void testCwiczenie5()
        {
            ZestawCwiczen0 zc = new ZestawCwiczen0();
            int[] result = zc.cwiczenie5();
            if (result.Length != 2)
            {
                throw new AssertFailedException();
            }
            else if (result[0] != 4)
            {
                throw new AssertFailedException();
            }
            else if (result[1] != 9)
            {
                throw new AssertFailedException();
            }
        }

        [TestMethod]
        public void testCwiczenie6()
        {
            ZestawCwiczen0 zc = new ZestawCwiczen0();

            char[] zdanie = zc.cwiczenie6();
            char[] zdanieExpected = {'a', 'l', 'a', ' ', 'm', 'a', ' ', 'k', 'o', 't', 'a'};
            Assert.AreEqual(zdanie.Length, zdanieExpected.Length);

            for (int i = 0; i < zdanie.Length; i++)
            {
                Assert.AreEqual(zdanie[i], zdanieExpected[i]);
            }
        }


        [TestMethod]
        public void testCwiczenie7()
        {
            ZestawCwiczen0 zc = new ZestawCwiczen0();
            String result = zc.cwiczenie7();
            String expResult = "Ala ma kota!";
            Assert.AreEqual(result, expResult);
        }


        [TestMethod]
        public void testCwiczenie8()
        {
            ZestawCwiczen0 zc = new ZestawCwiczen0();
            String result = zc.cwiczenie8();
            String expResult = "ALA MA KOTA!";
            Assert.AreEqual(result, expResult );
        }

        [TestMethod]
        public void testCwiczenie9()
        {
            ZestawCwiczen0 zc = new ZestawCwiczen0();

            double[] input = new double[] {4.97872, 657.1244, -189.2351, 1675.56};
            int[] result = new int[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                result[i] = zc.cwiczenie9(input[i]);
            }

            int[] expResult = new int[] {4, 657, -189, 1675};
            if (result.Length != expResult.Length)
            {
                throw new AssertFailedException();
            }
            else
            {
                for (int i = 0; i < result.Length; i++)
                {
                    if (result[i] != expResult[i])
                    {
                        throw new AssertFailedException();
                    }
                }
            }
        }

        [TestMethod]
        public void testCwiczenie10()
        {
            ZestawCwiczen0 zc = new ZestawCwiczen0();

            int[] input = new int[] {1000000, 4568, -154656, -964736, 5, -4, 6};
            short[] result = new short[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                result[i] = zc.cwiczenie10(input[i]);
            }

            short[] expResult = new short[] {16960, 4568, -23584, 18304, 5, -4, 6};
            if (result.Length != expResult.Length)
            {
                throw new AssertFailedException();
            }
            else
            {
                for (int i = 0; i < result.Length; i++)
                {
                    if (result[i] != expResult[i])
                    {
                        throw new AssertFailedException();
                    }
                }
            }
        }

        [TestMethod]
        public void testCwiczenie11()
        {
            ZestawCwiczen0 zc = new ZestawCwiczen0();

            int[] lewy = {1, 5, 6, 2};
            int[] prawy = {2, 4, 6, 7};
            int[][] expResult = new int[][]
            {
                new int[] {3, -1, 2, 0, 1},
                new int[] {9, 1, 20, 1, 1},
                new int[] {12, 0, 36, 1, 0},
                new int[] {9, -5, 14, 0, 2}
            };
            int[] result;
            for (int i = 0; i < lewy.Length; i++)
            {
                result = zc.cwiczenie11(lewy[i], prawy[i]);
                if (result.Length != expResult[i].Length)
                {
                    throw new AssertFailedException();
                }
                else
                {
                    for (int j = 0; j < result.Length; j++)
                    {
                        if (result[j] != expResult[i][j])
                        {
                            throw new AssertFailedException();
                        }
                    }
                }
            }
        }

        [TestMethod]
        public void testCwiczenie12()
        {
            ZestawCwiczen0 zc = new ZestawCwiczen0();

            bool[] lewy = {false, false, true, true};
            bool[] prawy = {false, true, false, true};
//new bool[]{and,or,xor,notLewy,notPrawy};
            bool[][] expResult = new bool[][]
            {
                new bool[] {false, false, false, true, true},
                new bool[] {false, true, true, true, false},
                new bool[] {false, true, true, false, true},
                new bool[] {true, true, false, false, false}
            };
            bool[] result;
            for (int i = 0; i < lewy.Length; i++)
            {
                result = zc.cwiczenie12(lewy[i], prawy[i]);
                if (result.Length != expResult[i].Length)
                {
                    throw new AssertFailedException();
                }
                else
                {
                    for (int j = 0; j < result.Length; j++)
                    {
                        if (result[j] != expResult[i][j])
                        {
                            throw new AssertFailedException();
                        }
                    }
                }
            }
        }

        [TestMethod]
        public void testCwiczenie13()
        {
            ZestawCwiczen0 zc = new ZestawCwiczen0();
            int[] lewy = {0, 1, -1, 2, -2, 3, 4, 5};
            int[] prawy = {1, -1, -1, 2, 3, -3, 6, 1};
//{czyRowne,czyRozne,czyMniejsze,czyWieksze,leq,geq}
            bool[][] expResult = new bool[][]
            {
                new bool[] {false, true, true, false, true, false}, //0 ? -1
                new bool[] {false, true, false, true, false, true}, // 1 ? -1
                new bool[] {true, false, false, false, true, true}, // -1 ? -1
                new bool[] {true, false, false, false, true, true}, // 2 ? 2
                new bool[] {false, true, true, false, true, false}, // -2 ? 3
                new bool[] {false, true, false, true, false, true}, // 3 ? -3
                new bool[] {false, true, true, false, true, false}, // 4 ? 6
                new bool[] {false, true, false, true, false, true} // 5 ? 1
            };
            bool[] result;
            for (int i = 0; i < lewy.Length; i++)
            {
                result = zc.cwiczenie13(lewy[i], prawy[i]);
                if (result.Length != expResult[i].Length)
                {
                    throw new AssertFailedException();
                }
                else
                {
                    for (int j = 0; j < result.Length; j++)
                    {
                        if (result[j] != expResult[i][j])
                        {
                            throw new AssertFailedException();
                        }
                    }
                }
            }
        }

        [TestMethod]
        public void testCwiczenie14()
        {
            ZestawCwiczen0 zc = new ZestawCwiczen0();
            double[] b = {213.2391, -287.32, 12, -34.67850, 0.9896, 0.98671};
            double[] c = {-17.3213, 14.9876, 124.09, -12.07, 2.01, -0.67123};
            double[] x = new double[b.Length];
            for (int i = 0; i < x.Length; i++)
            {
                x[i] = zc.cwiczenie14(b[i], c[i]);
            }

            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] + b[i] * c[i] != 0)
                {
                    throw new AssertFailedException();
                }
            }
        }

        [TestMethod]
        public void testCwiczenie15()
        {
            ZestawCwiczen0 zc = new ZestawCwiczen0();

            int[] a = {1405, 10000, -145678, 7892, 11, 0};
            short[] b = {213, -287, 12, -34, 0, 0};
            double[] c = {-17.3213, 14.9876, 124.09, -12.07, 2.01, -0.67123};
            double[] x = new double[b.Length];
            double[] result =
            {
                1405 + 213 - 17.3213,
                10000 - 287 + 14.9876,
                -145678 + 12 + 124.09,
                7892 - 34 - 12.07,
                11 + 2.01,
                -0.67123
            };
            for (int i = 0; i < x.Length; i++)
            {
                x[i] = zc.cwiczenie15(a[i], b[i], c[i]);
            }

            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] != result[i])
                {
                    throw new AssertFailedException();
                }
            }
        }
    }
}