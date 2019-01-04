using System;
using System.Linq;
using System.Reflection;
using Exercise1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercise1_Test
{
    [TestClass]
    public class ZestawCwiczen4Test
    {
//        [TestMethod]
//        public void testCwiczenie1()
//        {
//            String[] miasta = new String[] {"Lodz"};
//            String[] ulice = new String[] {"Piotrkowska"};
//            int[] numery = new int[] {1};
//            String[] kodyPocztowe = new String[] {"91-000"};
//            int[] sizes = new int[] {miasta.Length, ulice.Length, numery.Length, kodyPocztowe.Length};
//            int count = sizes.Min();
//            ZestawCwiczen4 zc = new ZestawCwiczen4();
//            Adres temp;
//            String nazwaPola;
//            for (int i = 0; i < count; i++)
//            {
//                temp = zc.cwiczenie1(miasta[i], ulice[i], numery[i], kodyPocztowe[i]);
//                String name = temp.GetType().FullName;
//                Assert.AreEqual("Exercise1.Adres", name);
//                FieldInfo[] pola = temp.GetType().GetFields();
//                string[] expected = {"miasto", "ulica", "numerDomu", "kodPocztowy"};
//                for (int j = 0; j < pola.Length; j++)
//                {
//                    Assert.AreEqual(expected[j], pola[j].Name);
//                }
//            }
//        }


//        [TestMethod]
//        public void testCwiczenie2()
//        {
//            ZestawCwiczen4 zc = new ZestawCwiczen4();
//            Greeter gr = zc.cwiczenie2();
//            Assert.AreEqual("Hello", gr.Response());
//            Assert.AreEqual("Exercise1.Greeter", gr.GetType().FullName);
//            MethodInfo[] metody = gr.GetType().GetMethods();
//            bool isPresent = false;
//            int i = 0;
//            for (; i < metody.Length; i++)
//            {
//                if ("Response" == metody[i].Name)
//                {
//                    isPresent = true;
//                    break;
//                }
//            }
//
//            if (isPresent)
//            {
//                Assert.AreEqual(0, metody[i].GetParameters().Length,
//                    $"Too many parameters! Expected 0, actual {metody[i].GetParameters().Length} ");
//            }
//            else
//            {
//                throw new AssertFailedException("Method with name \"Response\" not found.");
//            }
//        }

//        [TestMethod]
//        public void testCwiczenie3()
//        {
//            ZestawCwiczen4 zc = new ZestawCwiczen4();
//            MethodInfo[] metody = typeof(Greeter).GetMethods();
//            bool isPresent = false;
//            int i = 0;
//            for (; i < metody.Length; i++)
//            {
//                if (metody[i].Name.CompareTo("timeApriopriateResponse") == 0)
//                {
//                    Assert.IsTrue( metody[ i ].IsStatic );
//                    isPresent = true;
//                    Assert.AreEqual(2, metody[ i ].GetParameters().Length);
//                }
//            }
//
//            if (!isPresent)
//            {
//                throw new AssertFailedException( "Method with name \"timeApriopriateResponse\" not found." );
//            }
//
//            Assert.AreEqual("Zzzzz", Greeter.timeApriopriateResponse(0, 0));
//            Assert.AreEqual("Good morning", Greeter.timeApriopriateResponse(6, 35));
//            Assert.AreEqual("Good morning", Greeter.timeApriopriateResponse(11, 35));
//            Assert.AreEqual("Good afternoon", Greeter.timeApriopriateResponse(12, 01));
//            Assert.AreEqual("Good afternoon", Greeter.timeApriopriateResponse(19, 30));
//            Assert.AreEqual("Good evening", Greeter.timeApriopriateResponse(21, 00));
//            Assert.AreEqual("Something is wrong", Greeter.timeApriopriateResponse(24, 00));
//            Assert.AreEqual("Something is wrong", Greeter.timeApriopriateResponse(-1, 2));
//            Assert.AreEqual("Something is wrong", Greeter.timeApriopriateResponse(25, 10));
//        }
    }
}