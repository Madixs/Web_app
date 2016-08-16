using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository;
using Model;

namespace Data
{
    public static class Servis
    {
        static RepositoryDB repositor = new RepositoryDB();

        public static void SaveData(int seventID, string sfirstName, string slastName, string sphonNamber, int sroomNamber, string semail)
        {
            repositor.InputData<ModelData>("Zapis_usera", new { firstName = sfirstName, lastName = slastName, phoneNumber = sphonNamber, email = semail, roomNumber = sroomNamber, eventID = seventID });
        }

        public static List<DispalyData> DisplayAll()
        {
            List<DispalyData> listToDisplay = repositor.FillCollection<DispalyData>("SelectWydarzenia", new { });
            return listToDisplay;
            foreach(DispalyData dd in listToDisplay.)
            {

            }
            //TODO Dodać obsługę błędów
        }

        public static List<DispalyData> Display(string param)
        {
            List<DispalyData> listToDisplay = repositor.FillCollection<DispalyData>("SelectWydarzeniaFilter", new { expected = param });
            return listToDisplay;

        }
    }
}


