using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
using Foundation;
using UIKit;

namespace ListViewForms.iOS
{
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            global::Xamarin.Forms.Forms.Init();

            AppCenter.Start("ios=fb6a1462-bfb5-4383-b56f-13d3e8a26419;" + "uwp={Your UWP App secret here};" + "android={Your Android App secret here}", typeof(Analytics), typeof(Crashes));

            LoadApplication(new App());

            return base.FinishedLaunching(app, options);
        }
    }
}
