using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository;
using Model;

namespace Data
{
    public class Servis
    {

        RepositoryDB repo;
        public Servis()
        {
            repo = new RepositoryDB();
        }

        public string SaveData(string eventID, string firstName, string lastName, int phonNamber, int roomNamber, string email)
        {

            //TODO Zapisuje uczestnika na wydarzenie
            AddEvent result = repo.InputData<AddEvent>("", new { }); //Zwraca rezultat po dodaniu rekordu. do upewnienia czy zadziałało?

            if (result != null)
            {
                return "Dziękujemy za zapisanie się na wydarzenie";
            }
            else
            {
                return "Błąd zapisu";
            }

        }


        public void Display()
        {
            //TODO Podgląd wszystkich danych
        }

        public void Display(string param)
        {
            //TODO Podgląd na jakie wydarzenie zostałeś zapisany dany id ID
        }

        public string Update(string eventID, string firstName, string lastName, int phonNamber, int roomNamber, string email)
        {
            //TODO Uaktualnienie danych, zwraca potwierdzenie czy się udało wykonać update
            return "";
        }
    }
}


