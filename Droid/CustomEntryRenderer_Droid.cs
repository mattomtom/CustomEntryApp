using System;
using BorderEntryApp;
using BorderEntryApp.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(CustomEntry), typeof(CustomEntryRenderer_Droid))]
namespace BorderEntryApp.Droid
{
    public class CustomEntryRenderer_Droid : EntryRenderer
    {
        public CustomEntryRenderer_Droid()
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            Control?.SetBackgroundColor(Android.Graphics.Color.Transparent);
        }
    }
}
