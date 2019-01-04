using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    public class ZestawCwiczen0
    {
        /**
         * Cwiczenia z ponizszego zestawu dotyczyc beda najprostszych czynnosci 
         * jezyka C# jak komentowania kodu, tworzenia zmiennych oraz nadawania im
         * okreslonej wartosci lub wykonania prostej operacji
         */

        /*
         * W tym cwiczeniu nalezy zakomentowac calosc kodu w jej wnetrzu
         */
        public void cwiczenie1()
        {
            double[] tab;
            tab = new double[] {1, 2, 3};
            double e = tab[3];
            Double[] tab2 = null;
            int a = tab2.Length;
            throw new NotImplementedException();
        }

        /*
        * W tym ćwiczeniu nalezy odkomentować calosc kodu programu, jednoczesnie
        * nalezy zakomentowac ostatnia linijke kodu
        */
        public double[] cwiczenie2()
        {
            //        double[] d = new double[]{1,4,-6};
            //        d[1]=-1.13;
            //        return d;
            return null;
        }

        /*
        * W tym zadaniu naleza zakomentowac 1 linijkę (linia 48) we wnetrzu bloku if
        * oraz odkomentowac 2 linijke w if (linia 49)
        * prosze rowniez zmienic zwracana zmienna na d;
        */
        public double[] cwiczenie3()
        {
            double[] d = new double[] {3, 3, 3, 3, 3, 3, 3, 3};
            double[] d2 = new double[] {3, 1, 3, 2, 3, 1, 3, 0};
            for (int i = 0; i < d.Length; i++)
            {
                if (i % 2 == 0)
                {
//                    d[i] *= 2;
//                    d[i]/=3;
                }
            }

            return d;
        }

        /**
         * Powyzsze cwiczenia moga wydawac sie dziwne lub glupie. Sprawdzaja jednak
         * Panstwa zdolnosc do podazania za instrukcja. W dalszej czesci cwiczen
         * wymagane od panstwa bedzie naprawienie bledow objawiajacymi sie podkresleniem
         * ze strony srodowiska Eclipse. Nie mam innej mozliwosci jak wykomentowac
         * odpowiednie linijki (inaczej programu nie mozna bedzie testowac przez 
         * zawarte bledy skladni). Wszystkie polecenia dotyczace odkomentowania lub 
         * zakomentowania poszczegolnych linijek prosze traktowac jak koniecznosc.
         */

        /**
         * TWORZENIE ZMIENNYCH TYPOW PODSTAWOWYCH
         */

        /**
         * Prosze utworzyc zmienna typu bool o nazwie zmienna4
         * i nadac jej wartosc false
         * następnie odkomentowac przedostatnia linijke (80)
         * i zakomentowac ostatnia (81)
         *  
         */
        public bool cwiczenie4()
        {
            //return zmienna4;
            return true;
        }

        /**
         * utworz zmienna typu int o nazwie zmienna5
         * przypisz jej wartosc 4
         * odkomentuj utworzenie zmiennej zmienna5_kopia 
         * i powieksz jej wartosc o 5
         * odkomentuj przedostatnia linijke (96)
         * i zakomentuj linijke (97)
         */
        public int[] cwiczenie5()
        {
            //int zmienna5_kopia = zmienna5;

            //return new int[]{zmienna5,zmienna5_kopia};
            return new int[] {-1, -1};
        }

        /**
        * Odkomentowac przedostatnia linijke kodu (107) i zakomentowac ostatnia(108)
        * utworzyc zmienne potrzebne przy tworzeniu tablicy z linijki (107) oraz zainicjowac
        * je odpowiednimi literami.
        * Zauwazyc ze nie ma potrzeby wielokrotnego tworzenia odpowiednich zmiennych
        */
        public char[] cwiczenie6()
        {
            //return new char[]{a,l,a,spacja,m,a,spacja,k,o,t,a};
            return null;
        }

        /**
        * Typ String nie jest typem podstawowym, jednak jest jednym z najczesciej
        * wykorzystywanych typow danych.
        * W cwiczeniu nalezy przypisac stringowi s ciag znakow 'Ala ma kota!'
        */
        public String cwiczenie7()
        {
            String s = "";
            return s;
        }

        /**
        * Cwiczenie podobne ale tym razem 'Ala ma kota!' ma skladac sie z samych 
        wielkich liter
        */
        public String cwiczenie8()
        {
            String s = "";
            return s;
        }

        /**
        * Pomiedzy typami podstawowymi można dokonywać jawnej konwersji
        * w programowaniu nazywa sie to CAST'em po polsku rzutem. 
        * Słowo to dobrze pasuje w kontekscie rzutu geometrycznego w matematyce.
        * składnia wyglada następujaco
        * Typ1 zmienna1 = wartosc1;
        * Typ2 zmienna2 = ( (Typ2) zmienna1 );
        * w efekcie zmienna1 bedaca typu 1 zostaje przerzutowana na typ Typ2
        * Sa 3 mozliwe sytuacje z takimi rzutowaniami
        * - prowadzace do ograniczenia
        * - na typ o podobnym rozmiarze
        * - na typ o wiekszym rozmiarze
        * dwa pierwsze wymagaja jawnego rzutowania (przykład rzutowanie liczby 
        * typu zmiennoprzecinkowego na calkowita lub rzutu na mniejsza zmienna
        */

        /**
        * Zakomentowac ostatnia linijke. Dopisac instrukcje 'return' zwracajaca 
        * przerzutowana wartosc liczby doRzutowania na typ int
        * mozna usunac rowniez zmienna doRzutowania i dokonac konwersji w jednym kroku
        */
        public int cwiczenie9(double d)
        {
            double doRzutowania = d; //zbedne, ale moze dla czesci Panstwa bedzeimy dzieki temu bedzie latwiej
            return (int)d;
        }

        /**
        * Zakomentowac ostatnia linijke. Dopisac instrukcje 'return' zwracajaca 
        * przerzutowana wartosc liczby doRzutowania na typ short
        * mozna usunac rowniez zmienna doRzutowania i dokonac konwersji w jednym kroku
        * Istotnym jest to ze ta konwersja jest stratna, co doskonalne widac 
        * przy rzutowaniu duzych liczb
        */
        public short cwiczenie10(int d)
        {
            int doRzutowania = d; //zbedne, ale moze dla czesci Panstwa bedzeimy dzieki temu bedzie latwiej 
            return 0;
        }

        /*
        * OPERATORY
        */

        /**
         * W dalszej czesci bedziemy definiowac zastosowanie operatorow dzialajacych
         * dla wiekszosci typow podstawowych.
         * W javie nie mozna definiowac nowych operatorow, choc kazdy operator jest 
         * rowniez funkcja. W efekcie operatory maja zastosowanie jedynie 
         * na bardzo podstawowym  poziomie
         */

        /*
        * OPERATORY ARYTMETYCZNE
        */

        /*
        * W tym zadaniu nalezy odkomentowac przedostnia linijke kodu, 
        * zakomentowac ostatnia, nastepnie nalezy utworzyc odpowiednie zmienne
        * wymagane w przedostatniej linijce i zainicjowac je wartosciami 
        * odpowiednich operatorow dla lewy i prawy (przyjmujemy kolejnosc zgodnosc 
        * z wykonywaniem dzialan od lewej strony)
        */
        public int[] cwiczenie11(int lewyOperand, int prawyOperand)
        {
            int lewy = lewyOperand; //zbedne, ale moze dla czesci Panstwa bedzeimy dzieki temu bedzie latwiej
            int prawy = prawyOperand;
            //return new int[]{suma,roznica,iloczyn,iloraz,modulo};
            return new int[] {0, 0, 0, 0, 0};
        }

        /*
        OPERATORY LOGICZNE
        */

        /*
        * W tym zadaniu nalezy odkomentowac przedostnia linijke kodu, 
        * zakomentowac ostatnia, nastepnie nalezy utworzyc odpowiednie zmienne
        * wymagane w przedostatniej linijce i zainicjowac je wartosciami 
        * odpowiednich operatorow dla lewy i prawy (przyjmujemy kolejnosc zgodnosc 
        * z wykonywaniem dzialan od lewej strony)
        */
        public bool[] cwiczenie12(bool lewyOperand, bool prawyOperand)
        {
            bool lewy = lewyOperand;
            bool prawy = prawyOperand;

            //return new bool[]{and,or,xor,notLewy,notPrawy};
            return new bool[] {false, false, false, false, false};
        }

        /*
        * OPERATORY RELACYJNE
        */

        /*
        * W tym zadaniu nalezy odkomentowac przedostnia linijke kodu, 
        * zakomentowac ostatnia, nastepnie nalezy utworzyc odpowiednie zmienne
        * wymagane w przedostatniej linijce i zainicjowac je wartosciami 
        * odpowiednich operatorow dla lewy i prawy (przyjmujemy kolejnosc zgodnosc 
        * z wykonywaniem dzialan od lewej strony)
        */
        public bool[] cwiczenie13(int lewyOperand, int prawyOperand)
        {
            int lewy = lewyOperand;
            int prawy = prawyOperand;

            //return new bool[]{czyRowne,czyRozne,czyMniejsze,czyWieksze,leq,geq};
            return new bool[] {false, false, false, false, false, false};
        }

        /*
        * zmodyfikowac funkcje w taki sposob aby zwracana byla wartosc rozwiazania
        * rownania postaci x + b * c = 0  -> -b*c
        */

        public double cwiczenie14(double b, double c)
        {
            return 0.0;
        }

        /*
        * zmodyfikowac funkcje w taki sposob aby zwracana byla wartosc 
        * sumy a, b oraz c w typie double
        */
        public double cwiczenie15(int a, short b, double c)
        {
            return 0.0;
        }
    }
}