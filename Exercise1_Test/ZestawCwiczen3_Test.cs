using System;
using System.IO;
using Exercise1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercise1_Test
{
    [TestClass]
    public class ZestawCwiczen3_Test
    {
        [TestMethod]
        public void testCwiczenie1()
        {
            int element = 1;
            ZestawCwiczen3 zc = new ZestawCwiczen3();
            int[] result = zc.cwiczenie1();
            Assert.IsNotNull( result );

            Assert.AreEqual( result.Length , 7 );
            for (int i = 0; i < result.Length; i++)
            {
                Assert.AreEqual( result[ i ], element );

                element *= 2;
            }
        }

        Random rn = new Random();

        int nextRandom()
        {
            return rn.Next(99) + 1;
        }

        int nextRandom(int maks)
        {
            return rn.Next(maks);
        }


        [TestMethod]
        public void testCwiczenie2()
        {
            using (StringWriter stringWriter = new StringWriter())
            {
                Console.SetOut(stringWriter);
                ZestawCwiczen3 zc = new ZestawCwiczen3();
                int[] tab = new int[this.nextRandom()];
                String s = "";
                for (int i = 0; i < tab.Length; i++)
                {
                    tab[i] = this.nextRandom();
                    s = tab[i] + ";" + s;
                }

                zc.cwiczenie2(tab);
                String result = stringWriter.ToString().Trim();
                Assert.AreEqual(s,result);
            }
        }

        [TestMethod]
        public void testCwiczenie3()
        {
            ZestawCwiczen3 zc = new ZestawCwiczen3();
            int[] tab = new int[this.nextRandom()];
            for (int i = 0; i < tab.Length; i++)
            {
                tab[i] = this.nextRandom();
            }

            int[] tab2 = new int[tab.Length];
            int[] tab3 = new int[tab.Length];
            int[] tab4 = new int[] {};
            for (int i = 0; i < tab.Length; i++)
            {
                tab2[i] = tab[i];
                tab3[i] = tab[i];
            }

            int indeks = this.nextRandom(tab.Length);
            tab3[indeks] = tab3[indeks] == 0 ? 1 : -tab3[indeks];
            Assert.IsTrue(zc.cwiczenie3(tab, tab2));
            Assert.IsFalse(zc.cwiczenie3(tab, tab3));
            Assert.IsFalse(zc.cwiczenie3(tab, tab4));
            Assert.IsTrue(zc.cwiczenie3(tab4, tab4));
        }
    }
}