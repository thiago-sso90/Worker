using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkerServiceTreinamento.Model;
using WorkerServiceTreinamento.Repositorio.Interface;
using WorkerServiceTreinamento.Script;

namespace WorkerServiceTreinamento.Service
{
    public class ServiceData
    {
        private readonly IdbConnection _db;

        public ServiceData(IdbConnection service)
        {
            _db = service;  
        }
        public async Task ProcessarDadosAsync()
        {
            var querry = ScriptDate.AtualizarDatas;
            using (IDbConnection connection = _db.ConnectionDBase)
            {
                var result = await connection.QueryAsync<ArquivoModel>(querry);

                var resultado = result;
              
            }
        }
    }
}
