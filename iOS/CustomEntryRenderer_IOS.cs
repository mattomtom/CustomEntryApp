using System;
using BorderEntryApp;
using BorderEntryApp.iOS;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(CustomEntry), typeof(CustomEntryRenderer_IOS))]
namespace BorderEntryApp.iOS
{
    public class CustomEntryRenderer_IOS : EntryRenderer
    {
        public CustomEntryRenderer_IOS()
        {

        }

        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            if (Control != null)
            {
                Control.BorderStyle = UIKit.UITextBorderStyle.None;
            }
        }
    }
}
