using System;
using Acr.UserDialogs;
using Android.App;
using Android.Runtime;
using MvvmCross.Platforms.Android.Views;
using PokeMvx.Core;

namespace PokeMvx.Droid
{
    [Application]
    public class MainApplication : MvxAndroidApplication<Setup, App>
    {
        public MainApplication(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
        {
        }

        /// <summary>
        /// we initialize all the
        /// plugins for the entire app
        /// </summary>
        public override void OnCreate()
        {
            base.OnCreate();
            UserDialogs.Init(this);
        }
    }
}
