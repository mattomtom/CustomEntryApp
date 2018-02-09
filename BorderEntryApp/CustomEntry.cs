using System;
using Xamarin.Forms;

namespace BorderEntryApp
{
    public class CustomEntry : Entry
    {
        public bool haveBorder { get; set; }
        public Color BackgroundEntryColor { get; set; }

        public CustomEntry()
        {
        }
    }
}
