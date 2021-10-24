using System.Collections.Generic;
using System.Reflection;
using MvvmCross.DroidX.RecyclerView;
using MvvmCross.Platforms.Android.Core;
using PokeMvx.Core;
using Microsoft.Extensions.Logging;
using MvvmCross;
using MvvmCross.IoC;
using Serilog;
using Serilog.Extensions.Logging;
using Acr.UserDialogs;

namespace PokeMvx.Droid
{
    public class Setup : MvxAndroidSetup<App>
    {
        protected override IEnumerable<Assembly> AndroidViewAssemblies =>
            new List<Assembly>(base.AndroidViewAssemblies)
            {
                typeof(MvxRecyclerView).Assembly
            };

        protected override ILoggerProvider CreateLogProvider()
        {
            return new SerilogLoggerProvider();
        }

        protected override void InitializeFirstChance(IMvxIoCProvider iocProvider)
        {
            base.InitializeFirstChance(iocProvider);
            Mvx.IoCProvider.RegisterSingleton(UserDialogs.Instance);
        }

        protected override ILoggerFactory CreateLogFactory()
        {
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Debug()
                .WriteTo.AndroidLog()
                .CreateLogger();

            return new SerilogLoggerFactory();
        }
    }
}
