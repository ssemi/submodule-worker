// See https://aka.ms/new-console-template for more information
using common_module;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using worker_A;

Console.WriteLine("Hello, World!");

var host = Host.CreateDefaultBuilder(args)
                .ConfigureServices((hostContext, services) =>
                {
                    var env = hostContext.HostingEnvironment;
                    var config = hostContext.Configuration;

                    services.AddTransient<IWorker, Worker>();
                    services.AddTransient<Runner>();

                })
                .Build();

var svc = ActivatorUtilities.CreateInstance<Runner>(host.Services);
_ = svc.DoAction();