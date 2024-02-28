using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkerServiceTreinamento.Repositorio.Interface;

namespace WorkerServiceTreinamento.Service
{
    public class DbConnection : IdbConnection
    {
        public IDbConnection ConnectionDBase =>  new SqlConnection($"Server={Environment.GetEnvironmentVariable("COSMOS_HOST")};Database={Environment.GetEnvironmentVariable("COSMOS_DB")};User Id={Environment.GetEnvironmentVariable("COSMOS_USER")};Password={Environment.GetEnvironmentVariable("COSMOS_PASS")};TrustServerCertificate=True");
    }
}
