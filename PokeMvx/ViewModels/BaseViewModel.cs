using System;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using MvvmCross.Commands;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;
namespace PokeMvx.Core.ViewModels
{
    public class BaseViewModel : MvxNavigationViewModel
    {
        private string _title;

        public string Title
        {
            get => _title;
            set => SetProperty(ref _title, value);
        }

        public string LogId { get; protected set; }
        public IMvxCommand BackCommand { get; private set; }

        public BaseViewModel(ILoggerFactory logFactory,
            IMvxNavigationService navigationService) : base(logFactory, navigationService)
        {
            Title = "";
            BackCommand = new MvxCommand(async () => await OnBackCommand());
        }

        protected virtual async Task OnBackCommand()
        {
            await NavigationService.Close(this);
        }
    }
}
