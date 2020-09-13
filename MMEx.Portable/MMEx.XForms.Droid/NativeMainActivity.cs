using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace MMEx.XForms.Droid
{
    [Activity(Label = "MMEx.Net.Android", Icon = "@drawable/icon", MainLauncher = true,
        ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class NativeMainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            ShowTutorial();

            SetContentView(Resource.Layout.Main);

            // todo set event handlers here.
        }

        private void ShowTutorial()
        {
            StartActivity(typeof(TutorialActivity));
        }
    }
}