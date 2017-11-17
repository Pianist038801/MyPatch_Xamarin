using System;
using UIKit;

[assembly: Xamarin.Forms.Dependency(typeof(MyPatch.iOS.DevInfo_iOS))]
namespace MyPatch.iOS
{
    public class DevInfo_iOS : IDevInfo
    {
        public DevInfo_iOS()
        {
        }
        public string getID()
        {
            return UIKit.UIDevice.CurrentDevice.IdentifierForVendor.AsString();
        }
    }
}