using System;
using Microsoft.Extensions.Logging;
using MvvmCross.Navigation;

namespace PokeMvx.Core.ViewModels
{
    public class MainViewViewModel : BaseViewModel
    {
        public MainViewViewModel(ILoggerFactory logFactory,
            IMvxNavigationService navigationService) : base(logFactory, navigationService)
        {
        }
    }
}
