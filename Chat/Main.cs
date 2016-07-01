using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;
using FireSharp;
using FireSharp.Config;
using FireSharp.Extensions;
using FireSharp.EventStreaming;
using FireSharp.Interfaces;


namespace Chat
{
	public class Application
	{
		// This is the main entry point of the application.
		static void Main (string[] args)
		{
			IFirebaseConfig config = new FirebaseConfig {
				AuthSecret = "TsBQjlkc5JaCYuKiuAZ8jMgMz13sKix4xs7f29fx",
				BasePath = "https://faheemchat.firebaseio.com/"
			};
			IFirebaseClient client = new FirebaseClient (config);

			     

			// if you want to use a different Application Delegate class from "AppDelegate"
			// you can specify it here.
			UIApplication.Main (args, null, "AppDelegate");
		}
	}
}
