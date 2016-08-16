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
    public class RepositoryDB
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
        #region Metody do wysyłania danych do serwisu

        #endregion
    }
} 


