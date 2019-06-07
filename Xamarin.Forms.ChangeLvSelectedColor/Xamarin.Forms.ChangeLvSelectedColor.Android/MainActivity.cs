using System;
using Android.App;
using Android.Content.PM;
using Android.OS;

namespace Xamarin.Forms.ChangeLvSelectedColor.Droid
{
    [Activity(Label = "Xamarin.Forms.ChangeLvSelectedColor", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            AndroidEvents.OnAndroidThemeChangeNeeded += AndroidEvents_OnAndroidThemeChangeNeeded; ;
            LoadApplication(new App());
        }

        private void AndroidEvents_OnAndroidThemeChangeNeeded(object sender, int themeid)
        {
            RunOnUiThread(() => {
                SetTheme(themeid);
            });
        }

        public class AndroidEvents
        {
            public static event EventHandler<int> OnAndroidThemeChangeNeeded;

            public static void OnAndroidThemeChangeNeeded_Event(object sender, int id)
            {
                OnAndroidThemeChangeNeeded?.Invoke(sender, id);
            }
        }
    }
}