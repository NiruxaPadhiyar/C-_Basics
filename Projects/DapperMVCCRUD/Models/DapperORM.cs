using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace DapperMVCCRUD.Models
{
    public static class DapperORM
    {
        private static string connectionString = @"Data Source = DESKTOP-BLE4GH5\SQL2019TRAINING;Initial Catalog=MVCDatabase;Integrated Security=True;";

        public static void ExecuteWithoutReturn(string procedureName, DynamicParameters param)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                con.Execute(procedureName, param, commandType : CommandType.StoredProcedure);
            }
        }

        //DapperORM.ExecuteReturnScalar<int>(_,_);
        public static T ExecuteReturnScalar<T>(string procedureName, DynamicParameters param)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
               return (T) Convert.ChangeType(con.Execute(procedureName, param, commandType: CommandType.StoredProcedure),typeof(T));
            }
        }
        //DapperORM.returnList<PersonModel> <= IEnumerable<Person>
        public static IEnumerable<T> ReturnList<T>(string procedureName, DynamicParameters param)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                return con.Query<T>(procedureName, param, commandType: CommandType.StoredProcedure);
            }
        }
    }
}