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
    public partial class ImageEx1 : ContentPage
    {
        int currentItem = 1;
        UriImageSource imageSource;
        public ImageEx1()
        {
            InitializeComponent();
            imageSource = new UriImageSource { Uri = new Uri($"http://lorempixel.com/1920/1080/city/{currentItem}") };
            imageSource.CachingEnabled = false;
            image.Source = imageSource;
        }

        private void Left_Clicked(object sender, EventArgs e)
        {
            if (currentItem == 1)
            {
                currentItem = 10;
                LoadImage(currentItem);
            }
            else
                LoadImage(--currentItem);
        }

        private void Right_Clicked(object sender, EventArgs e)
        {
            if (currentItem == 10)
            {
                currentItem = 1;
                LoadImage(currentItem);
            }
            else
                LoadImage(++currentItem);
        }

        public void LoadImage(int id)
        {
            image.Source = ImageSource.FromUri(new Uri($"http://lorempixel.com/1920/1080/city/{id}"));
        }
    }
}
