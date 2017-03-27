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
    public partial class DisplayingAlerts : ContentPage
    {
        public DisplayingAlerts()
        {
            InitializeComponent();
        }

        async void Button_Clicked(object sender, EventArgs e)
        {
            //var response = await DisplayAlert("Warning", "Are u sure?", "Yes", "No");
            //if (response)
            //    await DisplayAlert("Done", "Your response will be saved", "Ok");

            var response = await DisplayActionSheet("Title", "Cancel", "Delete", "Copy Link", "Message", "E-mail");
            await DisplayAlert("Response", response, "Ok");
        }
    }
}
