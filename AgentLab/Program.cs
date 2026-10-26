using Akka.Hosting;
using Microsoft.Extensions.Hosting;

var builder = Host.CreateApplicationBuilder(args);

builder.Services.AddAkka("agent-system", akka =>
{
    akka.ConfigureLoggers(loggers =>
    {
        loggers.ClearLoggers();
        loggers.AddLoggerFactory();
    });
});

using var host = builder.Build();
await host.RunAsync();
