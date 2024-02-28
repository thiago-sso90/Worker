using Dapper;
using System.Data;
using WorkerServiceTreinamento.Model;
using WorkerServiceTreinamento.Repositorio.Interface;
using WorkerServiceTreinamento.Script;
using WorkerServiceTreinamento.Service;

namespace WorkerServiceTreinamento
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;
        private readonly IdbConnection _db;


        public Worker(ILogger<Worker> logger, IdbConnection service)
        {
            _logger = logger;
            _db = service;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                _logger.LogInformation("Worker rodando em: {time}", DateTimeOffset.Now);

                try
                {
                    var querry = ScriptDate.AtualizarDatas;
                    using (IDbConnection connection = _db.ConnectionDBase)
                    {
                        var result = await connection.QueryAsync<ArquivoModel>(querry);

                        var resultado = result;
                    }
                }catch (Exception ex)
                {
                    throw ex;
                }

                await Task.Delay(TimeSpan.FromMinutes(2), stoppingToken);
            }
        }
    }
}