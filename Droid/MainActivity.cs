using System;
using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
[assembly: Xamarin.Forms.Dependency(typeof(AndroidDevice))]
namespace MyPatch.Droid
{
    [Activity(Label = "MyPatch.Droid", Icon = "@drawable/icon", Theme = "@style/MyTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);  

            global::Xamarin.Forms.Forms.Init(this, bundle);                

            LoadApplication(new App());
        }
    }
    public interface IDevice 
    {
        string GetIdentifier();
    }
    public class AndroidDevice : IDevice{
        public string GetIdentifier()
        {
            return Settings.Secure.GetString(FormattableString.Context.ContentResolver, Settings.Secure.AndroidId);
        }
    }
}