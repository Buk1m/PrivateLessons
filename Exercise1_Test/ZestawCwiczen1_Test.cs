using System;
using Exercise1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercise1_Test
{
    [TestClass]
    public class ZestawCwiczen1_Test
    {
        [TestMethod]
        public void testCwiczenie1()
        {
            ZestawCwiczen1 zc = new ZestawCwiczen1();
            int[] values = {-10, -9, -8, -7, -6, -5, -4, -3, -2, -1, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9};
            bool[] results =
            {
                true, false, true, false, true, false, true, false, true, false,
                true, false, true, false, true, false, true, false, true, false
            };
            for (int i = -0; i < values.Length; i++)
            {
                if (results[i] != zc.cwiczenie1(values[i]))
                {
                    throw new Exception();
                }
            }
        }

        [TestMethod]
        public void testCwiczenie2()
        {
            ZestawCwiczen1 zc = new ZestawCwiczen1();

            int[] values = {17, -24, -56, 14, -2, 6, 3, 16, 0};
            String np = "nieparzysta";
            String p = "parzysta";
            String[] expResult = {np, p, p, p, p, p, np, p, p};
            for (int i = 0; i < values.Length; i++)
            {
                if (0 != expResult[i].CompareTo(zc.cwiczenie2(values[i])))
                {
                    throw new Exception();
                }
            }
        }

        [TestMethod]
        public void testCwiczenie3()
        {
            ZestawCwiczen1 zc = new ZestawCwiczen1();

            ZestawCwiczen1.Miesiace[] values =
            {
                ZestawCwiczen1.Miesiace.styczen, ZestawCwiczen1.Miesiace.luty, ZestawCwiczen1.Miesiace.marzec,
                ZestawCwiczen1.Miesiace.kwiecien,
                ZestawCwiczen1.Miesiace.maj, ZestawCwiczen1.Miesiace.czerwiec, ZestawCwiczen1.Miesiace.lipiec,
                ZestawCwiczen1.Miesiace.sierpien,
                ZestawCwiczen1.Miesiace.wrzesien, ZestawCwiczen1.Miesiace.pazdziernik,
                ZestawCwiczen1.Miesiace.listopad, ZestawCwiczen1.Miesiace.grudzien,
            };
            int[] expResult = {31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};
            for (int i = 0; i < values.Length; i++)
            {
                if (expResult[i] != zc.cwiczenie3(values[i]))
                {
                    throw new Exception();
                }
            }
        }

        [TestMethod]
        public void testCwiczenie4()
        {
            ZestawCwiczen1 zc = new ZestawCwiczen1();

            double[][] values = new double[][]
            {
                new double[] {1, 7, -11, 12},
                new double[] {1, 2, -4},
                new double[] {0},
                new double[] {-1, 1},
                new double[] {-1, 1, 2, 3, 4, -5, -2}
            };
            double[] expResult = {9, -1, 0, 0, 2};
            double temp;
            for (int i = 0; i < values.Length; i++)
            {
                temp = zc.cwiczenie4(values[i]);
                if (expResult[i] != temp)
                {
                    throw new Exception();
                }
            }
        }

        [TestMethod]
        public void testCwiczenie5()
        {
            ZestawCwiczen1 zc = new ZestawCwiczen1();

            double[][] values = new double[][]
            {
                new double[] {1, 7, -11, 12},
                new double[] {},
                new double[] {1, 2, -4},
                new double[] {0},
                new double[] {-1, 1},
                new double[] {-1, 1, 2, 3, 4, -5, -2}
            };
            String[] expResult =
            {
                "[1.0;7.0;-11.0;12.0]", "[]", "[1.0;2.0;-4.0]", "[0.0]", "[-1.0;1.0]",
                "[-1.0;1.0;2.0;3.0;4.0;-5.0;-2.0]"
            };
            String temp;
            for (int i = 0; i < values.Length; i++)
            {
                temp = zc.cwiczenie5(values[i]);
                if (expResult[i].CompareTo(temp) != 0)
                {
                    throw new Exception();
                }
            }
        }
    }
}