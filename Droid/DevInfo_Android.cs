using System;
[assembly: Xamarin.Forms.Dependency(typeof(DevInfo_Android))]
namespace MyPatch.Droid
{
    public class DevInfo_Android : IDevInfo
    {
        public DevInfo_Android()
        {
        }
        public string getID()
        {
            return Android.OS.Build.Serial;
        }
    }
}