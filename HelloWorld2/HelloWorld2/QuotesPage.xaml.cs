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
    public partial class QuotesPage : ContentPage
    {
        private int index = 0;
        string[] quotes =
            {
                "Quote 1",
                "Quote 2",
                "Quote 3"
            };
        public QuotesPage()
        {
            InitializeComponent();

            Device.OnPlatform(
                Android: () =>
                {
                    Padding = new Thickness(20, 30, 20, 20);
                },
                WinPhone: () =>
                {
                    Padding = new Thickness(20, 40, 20, 20);
                });
            label.Text = quotes[index];
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            index++;
            if (index == quotes.Length)
                index = 0;
            label.Text = quotes[index];            
        }
    }
}
