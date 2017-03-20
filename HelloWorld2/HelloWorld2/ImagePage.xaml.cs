using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ImagePage : ContentPage
    {
        public ImagePage()
        {
            InitializeComponent();

            //var imagesource = (UriImageSource)ImageSource.FromUri(new Uri(""));
            //var imageSource = new UriImageSource { Uri = new Uri("http://lorempixel.com/1920/1080/sports/7/") };
            //imageSource.CachingEnabled = false;
            //image.Source = imageSource;
            //image.Aspect = Aspect.AspectFill;

            //image.Source = ImageSource.FromResource("HelloWorld2.Images.background.jpg");

            //btn.Image = (FileImageSource) ImageSource.FromFile(Device.OnPlatform(
            //    iOS: "clock.png",
            //    Android: "clock.png",
            //    WinPhone:"Images/clock.png"));

        }
    }
}
