using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace HelloWorld
{
    public partial class ImagePage : ContentPage
    {
        public ImagePage()
        {
            InitializeComponent();

            //var imageSource = (ImageSource) ImageSource.FromUri(new Uri("http://lorempixel.com/1920/1080/sports/7/"));

            //var imageSource = new UriImageSource { Uri = new Uri("http://lorempixel.com/1920/1080/sports/6/") };
            //imageSource.CachingEnabled = true;
            //imageSource.CacheValidity = TimeSpan.FromHours(1);
            //image.Source = imageSource;

            //image.Source = ImageSource.FromResource("HelloWorld.images.15978112_955556287914686_4972352297386170264_n.jpg");

        }
    }
}
