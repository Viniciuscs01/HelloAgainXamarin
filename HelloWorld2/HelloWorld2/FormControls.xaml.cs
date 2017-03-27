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
    public partial class FormControls : ContentPage
    {
        public FormControls()
        {
            InitializeComponent();
            foreach (var method in GetContactMethods())
            {
                picker.Items.Add(method.Name);
            }
        }

        //private void Entry_Completed(object sender, EventArgs e)
        //{
        //    labelEntry.Text = "Completed";
        //}

        public class ContactMethod
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }
        private IList<ContactMethod> GetContactMethods()
        {
            return new List<ContactMethod>
            {
                new ContactMethod
                {
                    Id = 1, Name = "SMS"
                },
                new ContactMethod
                {
                    Id = 2,
                    Name = "Email"
                }
            };
        }

        private void Entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            labelEntry.Text = e.NewTextValue;
        }

        private void Picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = picker.Items[picker.SelectedIndex];
            DisplayAlert("Selected", item, "Ok");
        }

        //private void slider_ValueChanged(object sender, ValueChangedEventArgs e)
        //{
        //    e.OldValue
        //    e.NewValue
        //}

        //private void Switch_Toggled(object sender, ToggledEventArgs e)
        //{
        //    label.IsVisible = e.Value;
        //}
    }
}
