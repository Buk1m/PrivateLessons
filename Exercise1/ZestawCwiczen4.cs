using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    //MIEJSCE NA TWOJE KLASY







    //MIEJSCE NA TWOJE KLASY

    public class ZestawCwiczen4
    {

        /**
         * Cwiczenie 1 Tworzenie prostej klasy
         * W niniejszym ćwiczeniu należy utworzyc prostą klasę opisujaca adres danej osoby
         * Klasa ma nazywać sie 'Adres' (zgodnosc malych i wielkich liter)
         * Zlozona ma byc z publicznych pól string : miasto; string : ulica, int : numerDomu, string : kodPocztowy.
         * Aby sprawdzic poprawnosc utworzenia nalezy odkomentowac ponizsza funkcje cwiczenie1 oraz 
         * cwiczenie1Test w odpowiadajacej klasie testowej 
         */

        /*ODKOMENTUJ
            public Adres cwiczenie1(String param1, String param2, int param3, String param4){
                Adres adres = new Adres();
                adres.miasto= param1;
                adres.ulica = param2;
                adres.numerDomu = param3;
                adres.kodPocztowy = param4;
                return adres;
            }
        */

        /*
        * Cwiczenie 2 Tworzenie metody w klasie
        * W niniejszym ćwiczeniu należy utworzyć klasę Greeter
        * zawierajca metodę o nazwie Response, która zwraca zawsze string "Hello",
        * Celem strawdzenia poprawności nalezy odkomentować ponizsza funkcje cwiczenie2 oraz 
        * cwiczenie2Test w odpowiadajacej klasie testowej
        */


        /* ODKOMENTUJ
        public Greeter cwiczenie2(){
            return new Greeter();
        }
        */

        /*
        * Cwiczenie 3 Tworzenie funkcji statycznej w klasie
        W niniejszym cwiczeniu nalezy utworzyc w klasie Greeter z poprzedniego cwiczenia
        funkcje statyczna o nazwie timeApriopriateResponse o 2 parametrach 
        godzinie z przedzialu 0-23 i minutach z przedzialu 0-59. Funkcja ma zwracac 
        - "Good morning" od godziny 6:30 do 12:00
        - "Good afternoon" od godziny 12:01 do 19:30
        - "Good evening" od godziny 19:31 do 22:00
        - "Good night" od godziny 22:01 do 23:59
        - "Zzzzz" dla pozostałych konfiguracji poprawnego czasu
        - "Something is wrong" dla nieistniejących konfiguracji czasu.
        Po utworzeniu funkcji nalezy odkomentować funkcje cwiczenie3 oraz 
        cwiczenie3Test w odpowiedniej klasie testujacej
        */

        /* ODKOMENTUJ
        public String cwiczenie3(int hour, int minute){
            return Greeter.timeApriopriateResponse(hour, minute);
        }
        */
    }
}