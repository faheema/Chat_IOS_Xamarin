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
				AuthSecret = "************",
				BasePath = "https://your_app.firebaseio.com/"
			};
			
			IFirebaseClient client = new FirebaseClient (config);

			// if you want to use a different Application Delegate class from "AppDelegate"
			// you can specify it here.
			UIApplication.Main (args, null, "AppDelegate");
		}
	}
}
