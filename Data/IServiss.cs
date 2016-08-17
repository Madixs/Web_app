using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Service
{
    public interface IServiss
    {

        bool ServisSaveData(int seventID, string sfirstName, string slastName, string sphonNamber, int sroomNamber, string semail);

        List<DispalyData> ServisDisplayAll();
        List<DispalyData> ServisDisplayFilter(string param);

        List<EventChoice> ServisEventChoice();

        List<EventList> ServisEventList();

        List<RoomEmpty> ServisRoomEmpty();

    }
}
