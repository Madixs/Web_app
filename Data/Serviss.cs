using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository;
using Model;


namespace Service
{
    public class Serviss : IServiss
    {

        private IRepository repo;
        public Serviss(IRepository r)
        {
            this.repo = r;
        }
        public List<DispalyData> ServisDisplayAll()
        {
            return repo.DisplayAll();
        }

        public bool ServisSaveData(int seventID, string sfirstName, string slastName, string sphonNamber, int sroomNamber, string semail)
        {
            repo.SaveData(seventID, sfirstName, slastName, sphonNamber, sroomNamber, semail);
            return true;
        }
        public List<DispalyData> ServisDisplayFilter(string param)
        {
            return repo.Display(param);
        }
        public List<EventChoice> ServisEventChoice()
        {
            return repo.DisplayEventChoice();

        }
        public List<EventList> ServisEventList()
        {
            return repo.DisplayEventList();
        }
        public List<RoomEmpty> ServisRoomEmpty()
        {
            return repo.DisplayRoomEmpty();
        }

    }
}


