using System;
using System.Collections.Generic;
using System.Runtime.Remoting.Metadata.W3cXsd2001;

namespace Exercise1
{

    class Wojownik
    {
        public void Atakuj()
        {

        }
    }

    public class StringCwiczenia
    {
        //Działania na stringach


        // Cwiczenie1 - sprawdz czy podany jako parametr "igla" napis zawiera się w napisie "stogSiana"
        // do sprawdzania czy jeden napis zawiera drugi wykorzystaj metodę klasy String o nazwie "Contains"
        // metoda ta sprawdza czy jeden napis zawiera w sobie inny podany jako parametr
        // na podobnej zasadzie działa paski wyszukiwania, np jak ten w windowsie do wyszukiwania plików
        public bool Cwiczenie1(string igla, string stogSiana)
        {
            return stogSiana.Contains(igla) ;
        }

        // Ćwiczenie2 - z podanej jako parametr listy stringów "pliki", wybierz tylko te,
        // które kończą się na podane rozszerzenie np. "jpg"
        // wykorzystaj metode klasy string "EndsWith"
        public List<string> Cwiczenie2(List<string> pliki, string rozszerzenie)
        {
            List<string> vs = new List<string>(); 
            for (int i = 0; i < pliki.Count; i++)
            {
               if(pliki[i].EndsWith(rozszerzenie) == true)
                {
                    vs.Add(pliki[i]);
                }
            }
            return vs;
        }


        // Cwiczenie3 - znajdz pierwsze wystąpienie litery w napisie, wykorzystaj metode klasy String "IndexOf" 
        // metoda zwraca indeks pierwszego wystąpienia litery w napisie na rzecz którego jest wywolywana
        public int Cwiczenie3(string napis, char litera)
        {
            return napis.IndexOf(litera);
        }

        // Cwczenie4 - do napisu podanego jako parametr "napis" dodaj zawartosc napisu "dodatek" pomiedzy 20 a 21 znakiem
        // wykorzystaj do tego metode klasy String "Insert"
        public string Cwiczenie4(string napis, string dodatek)
        {


            return napis.Insert(20,dodatek);
        }

        // Cwiczenie5 - znajdz ostatnie wystąpienie podanej litery w napisie
        // wykorzystaj do tego metode LastIndexOf klasy string
        public int Cwiczenie5(string napis, char litera)
        {
            return napis.LastIndexOf(litera) ;
        }

        // Cwiczenie6 - usun z podanego napisu, "liczbaZnakowDoUsuniecia" znaków zaczynając od indeksu "poczatekUsuwania" 
        // wykorzystaj do tego metode "Remove" klasy string
        public string Cwiczenie6(string napis, int poczatekUsuwania, int liczbaZnakowDoUsuniecia)
        {
            
            return napis.Remove(poczatekUsuwania, liczbaZnakowDoUsuniecia);
        }


        // Cwiczenie7 - zamien w podanym napisie wszyskie wystąpienia napisu "doZmiany" na napis "nowy"
        // wyobraź sobie, że w nazwie projektu który ma 10000 plików jest literówka, na szczęscie jako
        // programista nie musisz zmieniać nazw ręcznie, wykorzystaj do tego metode "Replace" klasy string
        public string Cwiczenie7(string napis, string doZmiany, string nowy)
        {
            return napis.Replace(doZmiany,nowy);
        }

        // uzupełnij metode Podsumowanie tak aby z podanej tablicy nazw plików wybierała tylko nazwy spełniające warunek:
        // 1. plik zawiera w nazwie "Prezentacja"
        // 2. plik ma typ/rozszerzenie ".pttx" - czyli jest prezentacja power point
        // 3. znajdz indeks pierwszego wystąpienia znaku '_'
        // 4. dodaj po pierwszym znaku '_' aktualny rok "2019"
        // 5. usuń wszystkie ewentualne spacje ' '
        // 6. zamien wszystkie ',' na '-'
        // 7. zwróc z metody Podsumowanie listę napisów spełniających powyższe warunki
        public List<string> Podsumowanie1(List<string> nazwyPlikow)
        {
            int liczbaznakow=0;
            string plik1;
            List<string> pliki = new List<string>();
            foreach(string plik in nazwyPlikow)
            {
                if (plik.Contains("Prezentacja"))
                {
                    if (plik.EndsWith(".pttx"))
                    {
                        liczbaznakow = plik.IndexOf('_');
                       plik1=plik.Insert(liczbaznakow, "2019");
                       plik1=plik1.Replace(" ","");
                        plik1=plik1.Replace(',', '-');
                        pliki.Add(plik1);
                    }
                }
            }

            return pliki;
        }

        // Na zlocie Kowalskich który organizowałeś jeden z uczestników popełnił przestępstwo i ukradł kasetke z pieniędzmi.
        // Policja na miejscu zdarzenia odnalazła przedarte zaproszenie z widocznym nazwiskiem Kowalski i godziną 21.
        // Detektyw prosi cię  o podanie listy wszystkich uczestników przyjęcia o nazwisku "Kowalski" lub "Kowalska"
        // którzy przybyli na przyjęcie pomiedzy 21 a 22
        // uważaj, lista zawiera numery porządkowe, które najpierw trzeba usunąć
        // Format listy:
        // numer_porządkowy. Imie Nazwisko godzina
        // przykład:
        //1. Michal Kowalski 21:00
        //2. Anna Kowalska 21:30
        //21. Anna Kowalska 22:21
        //...
        // uzupełnij metode PracaDomowa tak aby z podanej listy uczestników wybierała tylko nazwy spełniające warunek:
        // 1. usun numery porządkowe
        // 2. uczestnik ma na nazwisko "Kowalski" lub "Kowalska"
        // 3. uczestnik przybył na przyjęcie po godzinie 21
        // uważaj na godziny takie jak 22:21 i numery porządkowe 21. 221. itd.
        // Czy dasz rade odnaleźć złodzieja?
        public List<string> PracaDomowa(List<string> listaGosci)
        {
            List<string> podejrzani = new List<string>();
            for(int i = 0; i < listaGosci.Count; i++)
            {
                listaGosci[i] = listaGosci[i].Remove(0,listaGosci[i].IndexOf('.'));
                listaGosci[i] = listaGosci[i].Remove(listaGosci[i].IndexOf(':'));
                if (listaGosci[i].Contains("21")&&(listaGosci[i].Contains("Kowalski") || listaGosci[i].Contains("Kowalska")))
                    
                {
                    podejrzani.Add(listaGosci[i]);

                }

            }
            
            return podejrzani;
        }


        // Cwiczenie8 - porównaj podane jako parametr znaki z pominięciem rozróżnienia wielkich i małych liter
        // wykorzystaj metode klasy string "Equals" a do zamiany liter na wielkie lub male użyj metody "ToLower" lub "ToUpper"
        public bool Cwiczenie8(string napis1, string napis2)
        {
            if (napis1.ToLower() == napis2.ToLower())
            {
                return true;
            }

                return false;
            
            
        }


        //Cwiczenie9 - Podziel podany jako parametr napis według podanego jako parametr znaku "separator"
        public string[] Cwiczenie9(string napis, char separator)
        {

            return napis.Split(separator);
        }

        // Cwiczenie 10 - z podanego jako parametr napisu wyciągnij napis zaczynający się na indeksie "poczatek" i mający długość "dlugosc"
        public string Cwiczenie10(string napis, int poczatek, int dlugosc)
        {
            
            return napis.Substring(poczatek, dlugosc);
        }


        // Otrzymałeś pojedynczy napis zawierający imiona, które zostały oddzielone od siebie średnikami:
        // Format:
        // Imie:Ania;Imie:Kasia;Imie:Kamil;Imie:Wojtek;Imie:Marta;Imie:Marcel;Imie:Franek;Imie:Ola;Imie:Bartek ...
        // Podziel je według znaku ";" i usuń część zawierającą "Imie:", tak aby zostały same imiona
        public string[] PracaDomowa2(string imiona)
        {
            imiona=imiona.Replace("Imie:", "");
            string[] imie= imiona.Split(';');


            return imiona.Split(';');
        }
    }
}