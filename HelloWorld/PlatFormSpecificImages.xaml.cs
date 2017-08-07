using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace HelloWorld
{
    public partial class PlatFormSpecificImages : ContentPage
    {
        public PlatFormSpecificImages()
        {
            InitializeComponent();
            //btn.Image = (FileImageSource) ImageSource.FromFile(Device.OnPlatform(
            //    iOS: "clock.png",
            //    Android: "clock.png",
            //    null
            //));
        }
    }
}
