using System;
using MvvmCross.ViewModels;
using PokeMvx.Core.ViewModels;

namespace PokeMvx.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            //Mvx.IoCProvider.LazyConstructAndRegisterSingleton<IFlightScheduleService, FlightScheduleService>();
            RegisterAppStart<MainViewViewModel>();
        }
    }
}
