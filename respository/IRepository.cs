using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface IRepository
    {
        T FillObject<T>(string storedProcedure, object args) where T : class, new();

        List<T> FillCollection<T>(string storedProcedure, object args) where T : class, new();
 
        T FillStructur<T>(string storedProcedure, object args) where T : struct;

        T InputData<T>(string storedProcedure, object args) where T : class, new();

 
        void SaveData(int seventID, string sfirstName, string slastName, string sphonNamber, int sroomNamber, string semail);


        List<DispalyData> DisplayAll();


        List<DispalyData> Display(string param);

        List<RoomEmpty> DisplayRoomEmpty();


        List<EventList> DisplayEventList();


        List<EventChoice> DisplayEventChoice(string eventName);
        




    }
}
