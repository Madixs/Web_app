using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using respository;
using model;

namespace Data
{
    public static class Servis
    {
        //TODO Przekazanie do procedury 
        //Zapisuje uczestnika na wydarzenie
        public static string Zapis(string wydarzenie, string imie, string nazwisko, int nrTelefonu, int nrPokoju)
        {
            int result = Repository.Dml<AddEvent>("", new ()); //Zwraca rezultat po dodaniu rekordu. do upewnienia czy zadziałało?

            if (result != 0)
            {
                return "Dziękujemy za zapisanie się na wydarzenie";
            }
            else
            {
                return "Błąd zapisu";
            }

        }

        //TODO Podgląd na jakie wydarzenie zostałeś zapisany po ID
        public static string PodgladZapisu(string ID)
        {
            List<AddEvent> result = Repository.FillCollection<AddEvent>("", new ());

            foreach (AddEvent r in result)
            {
                string k = " " + r;
            }
            return "Dziękujemy za zapisanie się na wydarzenie, nr zapisu:" + ID;
        }

        public static string ZmianaZapisu(string ID)
        {

            return "Dziękujemy za zapisanie się na wydarzenie, nr zapisu:" + ID;
        }
    }
}


