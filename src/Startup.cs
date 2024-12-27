using Microsoft.Extensions.DependencyInjection;
using Soenneker.Compression.SevenZip.Registrars;
using Soenneker.Git.Util.Registrars;
using Soenneker.Runners.FFplay.Utils;
using Soenneker.Runners.FFplay.Utils.Abstract;
using Soenneker.Utils.Dotnet.NuGet.Registrars;
using Soenneker.Utils.Dotnet.Registrars;
using Soenneker.Utils.File.Download.Registrars;
using Soenneker.Utils.File.Registrars;
using Soenneker.Utils.FileSync.Registrars;
using Soenneker.Utils.HttpClientCache.Registrar;
using Soenneker.Utils.SHA3.Registrars;

namespace Soenneker.Runners.FFplay;

/// <summary>
/// Console type startup
/// </summary>
public static class Startup
{
    // This method gets called by the runtime. Use this method to add services to the container.
    public static void ConfigureServices(IServiceCollection services)
    {
        services.SetupIoC();
    }

    public static IServiceCollection SetupIoC(this IServiceCollection services)
    {
        services.AddHostedService<ConsoleHostedService>();
        services.AddSha3UtilAsScoped();
        services.AddFileUtilSyncAsScoped();
        services.AddGitUtilAsScoped();
        services.AddSevenZipCompressionUtilAsScoped();
        services.AddScoped<IFileOperationsUtil, FileOperationsUtil>();
        services.AddDotnetNuGetUtilAsScoped();
        services.AddFileDownloadUtilAsScoped();

        return services;
    }
}
