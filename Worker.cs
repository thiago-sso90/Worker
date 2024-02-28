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
        private readonly ServiceData _serviceData;
        private readonly IdbConnection _db;


        public Worker(ILogger<Worker> logger, ServiceData serviceData)
        {
            _logger = logger;
            _serviceData = serviceData;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                _logger.LogInformation("Worker rodando em: {time}", DateTimeOffset.Now);

                try
                {
                    await _serviceData.ProcessarDadosAsync();
                
                }catch (Exception ex)
                {
                    throw ex;
                }

                await Task.Delay(TimeSpan.FromMinutes(1), stoppingToken);
            }
        }
    }
}