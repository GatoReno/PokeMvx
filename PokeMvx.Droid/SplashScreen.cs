using System;
using Android.App;
using Android.Content.PM;
using MvvmCross.Platforms.Android.Views;

namespace PokeMvx.Droid
{
    [Activity(
        Label = "@string/app_name"
        , MainLauncher = true
        , Theme = "@style/AlaskaTheme.LaunchScreen"
        , NoHistory = true
        , ScreenOrientation = ScreenOrientation.Portrait)]
    public class SplashScreen : MvxSplashScreenActivity
    {
        public SplashScreen() : base(Resource.Layout.SplashScreen)
        {
        }
    }
}
