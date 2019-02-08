using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise1
{
    public class ZestawPowtorzeniowy1
    {
        private const int Exit = 0;

        // Oblicz sume elementów w tablicy 'int[] tab' za pomocą dowolnej pętli
        public int Cwiczenie1(int[] tab)
        {

            int sum = 0;
            for (int i = 0; i < tab.Length; i++)
            {
                sum = tab[i] + sum;



            }
            return sum;
        }

        // dla kazdego elementu w tablicy 'int[] tab' sprawdz czy jest on liczba
        // podzielna bez reszty przez 2 i przez 3 i zwróć tablicę wartości true lub false

        //Przykład:
        // tab =        [1,    6,   9]
        //zwróc tablice [false,true,false]
        public bool[] Cwiczenie2(int[] tab)
        {
            bool[] nerf = new bool[tab.Length];

            for (int i = 0; i < tab.Length; i++)
            {
                if (tab[i] % 2 == 0 && tab[i] % 3 == 0)
                {
                    nerf[i] = true;
                }
            }
            return nerf;
        }

        //Napisz funkcje ktora przyjmuje jako parametr napis i pojedyncza litere
        //po czym oblicza ile razy ta litera wystpępuje w napisie i zwraca tę wartość
        //Wskazówka:
        //napis typu string to nic innego jak tablica znakow char[], wykorzystaj petle i warunek if :|\|
        public int Cwiczenie3(string napis, char litera)
        {
            int p = 0;
            for (int i = 0; i < napis.Length; i++)
            {
                if (napis[i] == litera)
                {

                    p++;
                }


            }
            return p;
        }

        //Trudne
        //Napisz funkcję, która zwraca najczęściej występujący znak w napisie
        //wykorzystaj funkcje, która napisales w Cwiczeniu3 :)
        public char Cwiczenie4(string napis)
        {
            int p = 0;
            char r = ' ';
            // Cwiczenie3(napis,)
            for (int i = 0; i < napis.Length; i++)
            {

                int result = Cwiczenie3(napis, napis[i]);

                if (p < result)
                {
                    r = napis[i];
                    p = result;
                }

            }


            return r;
        }


        //PRACA DOMOWA:

        // Połowa
        // Dla podanego napisu zwroc jego polowę

        // Przyklad:
        // napis = "Overwatch"
        // zwroc "Over"
        public string Cwiczenie5(string napis)
        {

            int dr = napis.Length / 2;
            string pol = "";
            for (int i = 0; i < dr; i++)
            {
                pol = pol + napis[i];

            }

            return pol;
        }

        //wpisz wszystkie elementy tablicy
        // WAŻNE !!!!!!
        //Do wypisywania uzyj Console.Write(); zamiast Console.WriteLine();
        public void Cwiczenie6(int[] tab)
        {
            for (int i = 0; i < tab.Length; i++)
            {
                Console.Write(tab[i]);

            }

        }

        //wypisz napis podany jako parametr, n razy
        // WAŻNE !!!!!!
        //Do wypisywania uzyj Console.Write(); zamiast Console.WriteLine();
        public void Cwiczenie7(string napis, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write(napis);

            }
        }


        //napisz funkcję liczącą pole trójkąta o podanym boku 'int a' i wysokosci 'int h'
        // i wypisującą wynik na ekranie
        //a nastepnie wywolaj ją dla wszystkich elementów z tablic a i h

        //Miejsce na twoja funkcję

        //Miejsce na twoją funkcję
        public void Cwiczenie8(int[] a, int[] h)
        {

        }

        //Policz tylko parzyste elementy w tablicy 'int[] tab' i zwroc wynik\
        //przyklad:
        //tab = [1,2,3,4]
        //zwroc 2+4 czyli 6

        public int Cwiczenie9(int[] tab)
        {
            int dodawanie = 0;
            for (int i = 0; i < tab.Length; i++)
            {
                if (tab[i] % 2 == 0)
                {
                    dodawanie = tab[i] + dodawanie;

                }


            }



            return dodawanie;
        }
    }
}