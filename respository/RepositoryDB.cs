using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data.SqlClient;
using System.Data;
using Model;

namespace Repository
{
    public class RepositoryDB : IRepository
    {

        #region Metody do łączenia z bazą
        private static readonly string _connectionString = "Server=Tsteodserver01v;Database=testy;Integrated Security=True;";

        
        public T FillObject<T>(string storedProcedure, object args)
            where T : class, new()
        {
            T result = default(T);

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {

                var queryResult = connection.Query<T>(storedProcedure, args, commandType: CommandType.StoredProcedure);

                if (queryResult != null && queryResult.AsEnumerable().Any())
                {
                    result = queryResult.AsEnumerable().FirstOrDefault();
                }
                 
            }

            return result;
        }

        
        public List<T> FillCollection<T>(string storedProcedure, object args)
          where T : class, new()
        {
            List<T> result = new List<T>();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {

                var queryResult = connection.Query<T>(storedProcedure, args, commandType: CommandType.StoredProcedure);

                if (queryResult != null && queryResult.AsEnumerable().Any())
                {
                    result = queryResult.AsEnumerable().ToList<T>();
                }

            }

            return result;
        }

        
        public T FillStructur<T>(string storedProcedure, object args)
          where T : struct
        {
            T result = default(T);

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {

                var queryResult = connection.Query<T>(storedProcedure, args, commandType: CommandType.StoredProcedure);

                if (queryResult != null && queryResult.AsEnumerable().Any())
                {
                    result = queryResult.AsEnumerable().FirstOrDefault();
                }

            }

            return result;
        }

        
        public T InputData<T>(string storedProcedure, object args)
         where T : class, new() 
        {
            T result = default(T);

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                var queryResult = connection.Query<T>(storedProcedure, args, commandType: CommandType.StoredProcedure);

                if (queryResult != null && queryResult.AsEnumerable().Any())
                {
                    result = queryResult.AsEnumerable().FirstOrDefault();
                }

            }

            return result;
        }
        #endregion
        #region Metody obsługujące bazę
        public void SaveData(int seventID, string sfirstName, string slastName, string sphonNamber, int sroomNamber, string semail)
        {
            InputData<ModelData>("Zapis_usera", new { firstName = sfirstName, lastName = slastName, phoneNumber = sphonNamber, email = semail, roomNumber = sroomNamber, eventID = seventID });
        }

        public List<DispalyData> DisplayAll()
        {
            List<DispalyData> listToDisplay = FillCollection<DispalyData>("SelectWydarzenia", new { });
            return listToDisplay;
            
        }

        public List<DispalyData> Display(string param)
        {

            List<DispalyData> listToDisplay = FillCollection<DispalyData>("SelectWydarzeniaFilter", new { expected = param });

            return listToDisplay;

        }

        public List<RoomEmpty> DisplayRoomEmpty()
        {
            List<RoomEmpty> roomEmpty = FillCollection<RoomEmpty>("hch_kwaterunek_puste", new { });
            return roomEmpty;
        }

        public List<EventList> DisplayEventList()
        {
            List<EventList> eventList = FillCollection<EventList>("hch_event_name", new { });
            return eventList;
        }

        public List<EventChoice> DisplayEventChoice(string eventName)
        {
            List<EventChoice> eventChoice = FillCollection<EventChoice>("hch_event_name_wybor", new { nazwa = eventName });
            return eventChoice;
        }

        #endregion
        
    }
} 


