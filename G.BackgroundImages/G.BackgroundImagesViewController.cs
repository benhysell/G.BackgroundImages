using System;
using System.Drawing;

using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace G.BackgroundImages
{
	public partial class G_BackgroundImagesViewController : UIViewController
	{
		static bool UserInterfaceIdiomIsPhone {
			get { return UIDevice.CurrentDevice.UserInterfaceIdiom == UIUserInterfaceIdiom.Phone; }
		}

		public G_BackgroundImagesViewController (IntPtr handle) : base (handle)
		{
		}

		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();
			
			// Release any cached data, images, etc that aren't in use.
		}

		#region View lifecycle

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			
			// Perform any additional setup after loading the view, typically from a nib.
			var button = UIButton.FromType(UIButtonType.RoundedRect);
			button.Frame = new RectangleF(UIScreen.MainScreen.Bounds.Width / 2 - 150, UIScreen.MainScreen.Bounds.Bottom - 50, 300, 40);
			button.SetTitle("Goal Blood Pressure Authenticate", UIControlState.Normal);
			button.TouchDown += ButtonDownEvent;

			UIImage backgroundImage = null;
			if (UIScreen.MainScreen.Bounds.Height == 568)
				backgroundImage = UIImage.FromFile(@"Icons/Default-568h@2x.png");
			else if (UIScreen.MainScreen.Bounds.Height == 667)
				backgroundImage = UIImage.FromFile(@"Icons/Default-667h@2x.png");
			else
				backgroundImage = UIImage.FromBundle("BackgroundImage");
			View.BackgroundColor = UIColor.FromPatternImage(backgroundImage);
			View.Add (button);
		}

		void ButtonDownEvent (object sender, EventArgs e)
		{
			var alert = UIAlertController.Create("ß", "Kick off your authentication here", UIAlertControllerStyle.Alert);
			alert.AddAction(UIAlertAction.Create("Ok", UIAlertActionStyle.Default, null));
			PresentViewController(alert, true, null);
		}

		public override void ViewWillAppear (bool animated)
		{
			base.ViewWillAppear (animated);
		}

		public override void ViewDidAppear (bool animated)
		{
			base.ViewDidAppear (animated);
		}

		public override void ViewWillDisappear (bool animated)
		{
			base.ViewWillDisappear (animated);
		}

		public override void ViewDidDisappear (bool animated)
		{
			base.ViewDidDisappear (animated);
		}

		#endregion
	}
}

