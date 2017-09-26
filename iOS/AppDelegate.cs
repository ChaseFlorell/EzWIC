using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using RoundedBoxView.Forms.Plugin.iOSUnified;
using UIKit;

namespace EzWIC.iOS
{
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            global::Xamarin.Forms.Forms.Init();
			XFGloss.iOS.Library.Init();
            RoundedBoxViewRenderer.Init();
			LoadApplication(new App());

            return base.FinishedLaunching(app, options);
        }
    }
}
