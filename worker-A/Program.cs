using common_module;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Worker_A;

Console.WriteLine("Hello, World!");

var host = Host.CreateDefaultBuilder(args)
            .ConfigureServices((hostContext, services) =>
            {
                services.AddTransient<IWorker, Worker>();
                services.AddTransient<Runner>();
            })
            .Build();

var svc = ActivatorUtilities.CreateInstance<Runner>(host.Services);
await svc.DoAction();