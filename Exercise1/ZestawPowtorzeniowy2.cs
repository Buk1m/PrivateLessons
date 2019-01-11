using System;

// ReSharper disable CommentTypo

namespace Exercise1
{
    public class ZestawPowtorzeniowy2
    {
        private const int Exit = 0;
        //Utworz tablice liczb zwierającą kolejne potęgi dwójki od 2^0 do 2^n, gdzie n jest podane jako parametr
        //Przyklad:
        // n=3
        // zwróc [1,2,4,8] czyli inaczej [2^0, 2^1, 2^2, 2^3]

        public int[] Cwiczenie1(int n)
        {
            return null;
        }

        //Funkcja Cwiczenie 2 przyjmuje jako parametr tablice liczb calkowitych
        //znajdz najmniejszy i największy element tej tablicy i zwróć je jako dwuelementową tablicę
        // tab [min, max]
        //Przykład:
        // tab = [3,2,1,6,5]
        //zwróc wynik = [1, 6]
        public int[] Cwiczenie2(int[] tab)
        {
            return null;
        }

        //Funkcja Cwiczenie3 przyjmuje jako parametr napis
        //policz ile zawiera samoglosek i spółgłosek 
        // i zwróc je w postaci tablicy dwuelementowej
        // tab[liczbaSamoglosek, liczbaSpółgłosek];
        //Przyklad:
        //napis = "Ala ma kota"
        // zwróc [5,4] poniewaz napis zawiera samogloski: A,a,a,o,a
        // oraz spółgłoski: l,m,k,t
        // załóż, że napis nie zawiera polskich znaków diakrytycznych (ą, ę ć ś, itp ...)
        // Wskazówka:
        // Pamietaj o warunku na Wielkie Litery, albo zapoznaj się z funkcją C# ToLower();
        // Spacje należy pominąć! W przypadkach testowych występują tylko litery i spacje :)
        public int[] Cwiczenie3(string napis)
        {
            return null;
        }

        // Trudne :)
        // Napisz funkcje ktora sumuje elementy tablicy pod warunkiem,
        // że znajdują się one na indeksach, które są potęgami dwójki
        // Przykład:
        // kolejne potęgi dwójki [1,2,4,8,16,...] to elementy talbicy,
        // których sumę chcemy policzyć

        //zatem jeżeli mamy talbicę o 11 elementach:
        //indeksy:0,1,2,3,4,5,6,7,8, 9,10,11 
        // tab = [1,2,3,4,5,6,7,8,9,10,11,12]

        // to chcemy zsumować tylko elementy na miejscach 1,2,4,8 zatem:
        // zwróc 2+3+5+9 czyli 19
        public int Cwiczenie4(int[] tab)
        {
            return Exit;
        }

        // Funkcja przyjmuje napis 'string imie', które zawiera Polskie imie
        // Twoim zadaniem jest określić czy jest to imie żęńskie czy męskie
        // i zwrócić znak 'm' jeśli mękie lub 'k' jeżli żeńskie
        // Wskazówka: zauważ na jakią literę kończą się Polskie imiona :)
        public char Cwiczenie5(string imie)
        {
            return (char)Exit;
        }
    }
}