using System;
using System.IO;
using Exercise1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercise1_Test
{
    [TestClass]
    public class ZestawCwiczen2_Test
    {
        [TestMethod]
        public void testCwiczenie1()
        {
            ZestawCwiczen2 zc = new ZestawCwiczen2();
            int[] a = {0, -1, -2, -3, 1, 2, 3, 4, 7};
            int[] b = {1, 1, 1, 0, 2, 1, 2, 0, -1};
            int[] results = {1, 0, -1, -3, 5, 3, 7, 4, 8};
            for (int i = 0; i < a.Length; i++)
            {
                Assert.AreEqual(results[i], zc.cwiczenie1(a[i], b[i]));
            }
        }

        [TestMethod]
        public void testCwiczenie2()
        {
            ZestawCwiczen2 zc = new ZestawCwiczen2();
            int[] a = {-2, -1, 0, 1, 2, 3, 4, 6, 7, 11, 12, 25, 33, 34, 97, 100, 101};
            bool[] results =
            {
                true, false, true, false, true, false, true, true, false, false, true, false, false, true, false,
                true, true
            };
            bool temp;
            for (int i = 0; i < a.Length; i++)
            {
                temp = zc.cwiczenie2(a[i]);
                Assert.AreEqual(results[i], temp);
            }
        }

        [TestMethod]
        public void testCwiczenie3()
        {
            ZestawCwiczen2 zc = new ZestawCwiczen2();
            int[] a = {-2, -1, 0, 1, 2, 3, 4};
            String[] results = {"^^", "^", "@", "*", "**", "***", "****"};
            String temp;
            for (int i = 0; i < a.Length; i++)
            {
                temp = zc.cwiczenie3(a[i]);
                Assert.AreEqual(results[i], temp);
            }
        }

        [TestMethod]
        public void testCwiczenie4()
        {
            using (StringWriter stringWriter = new StringWriter())
            {
                Console.SetOut(stringWriter);


                ZestawCwiczen2 zc = new ZestawCwiczen2();
                int[] a = {-2, -1, 0, 1, 2, 3, 4};
                String[] tekst = {"Ala", "Bela", "Celina", "Danuta", "Elzbieta", "Francesca", "Gloria"};
                String[] results =
                {
                    "", "", "", "Danuta", "ElzbietaElzbieta", "FrancescaFrancescaFrancesca", "GloriaGloriaGloriaGloria"
                };
                String temp;
                String temp2;
                for (int i = 0; i < a.Length; i++)
                {
                    zc.cwiczenie4(tekst[i], a[i]);
                    temp = stringWriter.ToString().Trim();
                    stringWriter.Flush();
                    var sb = stringWriter.GetStringBuilder();
                    sb.Remove( 0, sb.Length);
                    Console.Out.Flush();

                    temp2 = results[i];
                    Assert.AreEqual(results[i], temp);
                }
            }
        }
    }
}