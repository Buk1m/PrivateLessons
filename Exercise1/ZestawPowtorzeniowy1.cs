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
            return Exit;
        }

        // dla kazdego elementu w tablicy 'int[] tab' sprawdz czy jest on liczba
        // podzielna bez reszty przez 2 i przez 3 i zwróć tablicę wartości true lub false

        //Przykład:
        // tab =        [1,    6,   9]
        //zwróc tablice [false,true,false]
        public bool[] Cwiczenie2(int[] tab)
        {
            return null;
        }

        //Napisz funkcje ktora przyjmuje jako parametr napis i pojedyncza litere
        //po czym oblicza ile razy ta litera wystpępuje w napisie i zwraca tę wartość
        //Wskazówka:
        //napis typu string to nic innego jak tablica znakow char[], wykorzystaj petle i warunek if :)
        public int Cwiczenie3(string napis, char litera)
        {
            return Exit;
        }

        //Trudne
        //Napisz funkcję, która zwraca najczęściej występujący znak w napisie
        //wykorzystaj funkcje, która napisales w Cwiczeniu3 :)
        public char Cwiczenie4(string napis)
        {
            return ' ';
        }


        //PRACA DOMOWA:

        // Połowa
        // Dla podanego napisu zwroc jego polowę
        public string Cwiczenie5(string napis)
        {
            return null;
        }

        //wpisz wszystkie elementy tablicy
        // WAŻNE !!!!!!
        //Do wypisywania uzyj Console.Write(); zamiast Console.WriteLine();
        public void Cwiczenie6(int[] tab)
        {
        
        }

        //wypisz napis podany jako parametr, n razy
        // WAŻNE !!!!!!
        //Do wypisywania uzyj Console.Write(); zamiast Console.WriteLine();
        public void Cwiczenie7(string napis, int n)
        {

        }


        //napisz funkcję liczącą pole trójkąta o podanym boku 'int a' i wysokosci 'int h'
        // i wypisującą wynik na ekranie
        //a nastepnie wywolaj ją dla wszystkich elementów z tablic a i h

        //Miejsce na twoja funkcję

        //Miejsce na twoją funkcję
        public void Cwiczenie8(int[] a, int[] h)
        {

        }

        //Policz tylko parzyste elementy w tablicy 'int[] tab' i zwroc wynik
        public int Cwiczenie9(int[] tab)
        {
            return Exit;
        }
    }
}