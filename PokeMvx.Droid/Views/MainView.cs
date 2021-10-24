using System;
using Android.OS;
using MvvmCross.Platforms.Android.Views;
using PokeMvx.Core.ViewModels;
using MvvmCross.Binding.BindingContext;
using Android.App;
using MvvmCross.Platforms.Android.Presenters.Attributes;

namespace PokeMvx.Droid.Views
{
    [MvxActivityPresentation]
    [Activity]
    public class MainView : MvxActivity<MainViewViewModel>
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.main_view);

            //create date picker and bindings
            var set = this.CreateBindingSet<Views.MainView, MainViewViewModel>();
            set.Bind(SupportActionBar).For(v => v.Title).To(vm => vm.Title);           
            set.Apply();

        }
    }
}
