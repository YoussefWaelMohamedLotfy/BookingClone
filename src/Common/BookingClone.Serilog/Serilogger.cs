using Microsoft.Extensions.Hosting;
using Serilog;

namespace BookingClone.Serilog;

public static class Serilogger
{
    public static Action<HostBuilderContext, LoggerConfiguration> Configure =>
        (context, configuration) =>
        {
            configuration
                .Enrich.FromLogContext()
                .Enrich.WithMachineName()
                .WriteTo.Console()
                .WriteTo.Debug()
                .ReadFrom.Configuration(context.Configuration);
        };
}
