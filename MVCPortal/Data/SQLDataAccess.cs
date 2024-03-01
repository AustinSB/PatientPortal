using Dapper;
using Microsoft.Data.Sqlite;
using MVCPortal.Models;
using System.Data;

namespace MVCPortal.Data
{
    public class SQLDataAccess : ISQLDataAccess
    {
        private readonly IConfiguration _config;

        public SQLDataAccess(IConfiguration config)
        {
            _config = config;
        }

        public IDbConnection Connect()
        {
            return new SqliteConnection(_config.GetConnectionString("Default"));
        }

        public async Task<IEnumerable<T>> GetData<T>(string sql) //int id, 
        {
            using var connection = Connect();

            //var sql = $"SELECT * FROM patient WHERE id = {id}";

            //var test = connection.QueryAsync(sql);
            return await connection.QueryAsync<T>(sql);
        }

        //public async Task<IEnumerable<PatientModel>> GetPatient(int id)
        //{
        //    using var connection = new SqliteConnection(_config.GetConnectionString("Default"));
        //    connection.Open();

        //    var sql = $"SELECT * FROM patient WHERE id = {id}";

        //    return await connection.QueryFirstAsync<IEnumerable<PatientModel>>(sql);
        //}

    }
}
