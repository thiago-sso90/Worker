using WorkerServiceTreinamento;
using WorkerServiceTreinamento.Repositorio.Interface;
using WorkerServiceTreinamento.Service;

IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>
    {
        services.AddSingleton<ServiceData>();
        services.AddSingleton<IdbConnection,DbConnection>();
   
        services.AddHostedService<Worker>();
    })
    .Build();

await host.RunAsync();
