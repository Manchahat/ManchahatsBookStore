using ManchahatBooks.DataAccess.Repository.IRepository;
using ManchahatsBookStore.DataAccess.Data;
using Dapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.SqlClient;

namespace ManchahatBooks.DataAccess.Repository
{
   public  class SP_Call : ISP_Call
    {
        // access the database
        private readonly ApplicationDbContext _db;
        private static string ConnectionString = ""; // needed to call the stored procedures

        // construct to open a sql connection

        public SP_Call(ApplicationDbContext db)
        {
            _db = db;
            ConnectionString = db.Database.GetDbConnection().ConnectionString;
        }

        // implements the ISP_Call interface

        public void Dispose()
        {
            _db.Dispose();
        }

        public void Execute(string procedureName, DynamicParameters param = null)
        {
            using (SqlConnection sqlCon = new SqlConnection(ConnectionString))
            {
                sqlCon.Open();
                sqlCon.Execute(procedureName, param, commandType: System.Data.CommandType.StoredProcedure);
            }
        }

        public IEnumerable<T> List<T>(string procedureName, DynamicParameters param = null)
        {
            using (SqlConnection sqlCon = new SqlConnection(ConnectionString))
            {
                sqlCon.Open();
                return sqlCon.Query<T>(procedureName, param, commandType: System.Data.CommandType.StoredProcedure);
            }
        }

        public T Single<T>(string procedurename, DynamicParameters param = null)
        {
            throw new NotImplementedException();
        }

        public T Onerecord<T>(string procedurename, DynamicParameters param = null)
        {
            throw new NotImplementedException();
        }

        public Tuple<IEnumerable<T1>, IEnumerable<T2>> List<T1, T2>(string procedurename, DynamicParameters param = null)
        {
            throw new NotImplementedException();
        }
    }
}
