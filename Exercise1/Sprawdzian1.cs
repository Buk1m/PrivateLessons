// ReSharper disable IdentifierTypo
// ReSharper disable CommentTypo

using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise1
{
    public class Sprawdzian1
    {
        private const int Exit = 0;

        // ZADANIE 1: Suma tablicy i parzystość 
        // Zakomentuj ostatnia linijke w funkcji zadanie1

        // POLECENIE:
        // Funkcja Zadanie1 przyjmuje tablicę liczb całkowitych 'int[] tablica',
        // 1. policz sumę wszystkich elementów tej tablicy
        // 2. zapisz wynik w zmiennej o nazwie suma
        // 3. sprawdz czy wyliczona suma jest liczbą parzystą
        // 4. jeśli suma jest parzysta, zwróc z funkcji Zadanie1 napis "parzysta",
        //    a jeśli nie to "nieparzysta"

        /// PRZYKLAD:
        // tablica = [1,2,3];
        // suma = 1+2+3
        // 1+2+3 = 6;
        // 6 jest parzyste
        // zwróć napis "parzysta"
        public string Zadanie1(int[] tablica)
        {
            return null;
        }

        // ZADANIE 2: Prawie dobry kalkulator
        // Zakomentuj ostatnią linijkę w funkcji zadanie2

        // POLECENIE:
        // funckja przyjmuje dwie liczby rzeczywiste 'float a, float b'
        // oraz string z nazwą operacji, który może przyjmować wartości
        // "dodaj", "odejmij", "pomnoz", "podziel", "modulo" (modulo to reszta z dzielenia)
        // zmien funkcję Zadanie2, tak aby wykonywała wybraną operacje
        // na liczbach a i b oraz zwracała jej wynik
        // jesli operacja nie moze byc wykonana zwróć wartosć 0

        // Przykład:
        // a=1, b=2, operacja="podziel"
        // c = a/b , c = 1/2 = 0.5
        // zwróc 0.5

        // Wykorzystaj instrukcje if..else lub switch case
        public float Zadanie2(float a, float b, string operacja)
        {
            return Exit;
        }

        // ZADANIE 3: Porównywanie tablic
        // Odkomentuj zakomentowaną linijkę w funkcji Zadanie3
        // Zakomentuj ostatnią linijkę w funkcji Zadanie3

        // POLECENIE:
        // funkcja Zadanie3 przyjmuje jako parametry dwie tablice liczb calkowitych
        // 'int[] A ,int[] B' o rownej liczbie elementow.
        // napisz funkcję o nazwie UtworzPorownanie(int[] A ,int[] B), 
        // która porównuje kolejne elementy tablic A i B oraz zapisuje wynik w stringu C
        // jesli element tablicy A jest mniejszy od B to string powininen zawierac "<"
        // jeżeli element tablicy A jest wiekszy od B to string powinien zawierac "<"
        // jeżeli elementy sa równe to string powinien zawierac "="
        // użyj instrukcji if lub switch


        // Przykład:
        // Dla podanych tablic tabA i tabB
        // bA = [1,2,3];
        // bB = [1,1,4];
        // string wynik -> C = "=<>"
        // ponieważ 1 jest rowne 1 -> "="
        // ponieważ 2 jest wieksze od 1 -> ">"
        // ponieważ 3 jest mniejsze od 4 -> "<"
        // razem "=<>"

        public string Zadanie3(int[] A, int[] B)
        {
            //return UtworzPorownanie(A, B);
            return null;
        }

        //Miejsce na twoją funkcje





        //Miejsce na twoją funkcje
    }
}