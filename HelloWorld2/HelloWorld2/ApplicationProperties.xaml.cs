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
    public partial class ApplicationProperties : ContentPage
    {
        //App app = Application.Current as App;
        public ApplicationProperties()
        {
            InitializeComponent();
            BindingContext = Application.Current;
            //title.Text = app.Title;
            //notificationEnabled.On = app.NotificationsEnabled;
        }

        //private void OnChange(object sender, EventArgs e)
        //{
        //    app.Title = title.Text;
        //    app.NotificationsEnabled = notificationEnabled.On;
        //}

        //protected protected override void OnDisappearing()
        //{
        //    base.OnDisappearing();
        //}
    }
}
