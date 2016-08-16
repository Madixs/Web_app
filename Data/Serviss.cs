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
        RepositoryDB repositor;
        public Servis()
        {
            repositor = new RepositoryDB();
        }
        public void SaveData(string seventID, string sfirstName, string slastName, int sphonNamber, int sroomNamber, string semail)
        {
            repositor.InputData<ModelData>("Zapis_usera", new { firstName = sfirstName, lastName = slastName, phoneNumber = sphonNamber, email = semail, roomNumber = sroomNamber, eventID = seventID });
        }

        public string DisplayAll()
        {
            List<DispalyData> listToDisplay = repositor.FillCollection<DispalyData>("SelectWydarzenia", new { });

            if (listToDisplay != null)
            {
                foreach (DispalyData dd in listToDisplay)
                {

                }
            }
            //TODO Dodać obsługę błędów
        }

        public List<DispalyData> Display(string param)
        {
            List<DispalyData> listToDisplay = repositor.FillCollection<DispalyData>("SelectWydarzeniaFilter", new { expected = param });
            return listToDisplay;
            
        }
    }


