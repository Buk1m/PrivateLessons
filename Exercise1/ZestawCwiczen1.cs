namespace Exercise1
{
    public class ZestawCwiczen1
    {

        /**
         * Cwiczenie z ponizszego zestawu dotyczyc beda sterowania przebiegiem
         * programu za pomoca instrukcji sterujacych takich jak
         * if, switch, for, do-while, while, break, continue
         *  
         */

        /* liczba jest pewna liczba wczytana od uzytkownika.
             * wynik jest odpowiedzia na pytanie czy dana liczba jest liczba parzysta
             * zatem w przypadku gdy liczba jest parzysta nalezy przypisac 
             * do zmiennej wynik wartosc true, natomiast
             * gdy liczba jest nieparzysta nalezy przypisac do wynik wartosc false
             * W Cwiczeniu nalezy uzyc komeny IF
             */

        public bool cwiczenie1( int a )
        {
            int liczba = a;

            return false;
        }

        /*
        * Polecenie niemal identyczne, jednak zwrocona powinna zostac wartosc w postaci
        * ciagu string "parzysta", "nieparzysta"
        */


        public string cwiczenie2( int a )
        {
            return "";
        }

        public enum Miesiace
        {
            styczen, luty, marzec, kwiecien,
            maj, czerwiec, lipiec, sierpien,
            wrzesien, pazdziernik, listopad, grudzien
        }

        /*
        * Funkcja ma za zadanie zwracac ilosc dni w danym miesiacu, gdzie miesiac
        * jest realizowany przez typ Miesiace 
        * ! dostęp do danego miesiaca : Miesiace.styczen <--
        * dla lutego zwracamy zawsze 28, reszta wg wiedzy
        * do rozwiazania mozna wykorzystac zarowno if z else if jak i switch
        */

        public int cwiczenie3( Miesiace m )
        {

            return 0;
        }

        /*
        * W cwiczeniu przekazywana jest do rachunku tablica elementow typu double
        * program ma za zadanie obliczyc sume wszystkich elementow z tablicy
        */
        public double cwiczenie4( double[] tablica )
        {

            return 0.0;
        }
        /* DODATKOWE ! ALE SPRÓBUJ ZROBIC :)
        * zadaniem funkcji jest wypisanie do zmiennej string zawartosci tablicy w 
        * formacie [1.0;2.3;-1.3] (przykład). Uwaga na brak średnika po ostatniej wartości
        * zwrocic [] dla tablicy pustej
        */
        public string cwiczenie5( double[] tablica )
        {
            string s = "";
            return s;
        }
    }
}