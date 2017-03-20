using HelloWorld2.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListPage : ContentPage
    {
        private ObservableCollection<Contact> _contacts;
        public ListPage()
        {
            InitializeComponent();

            //listView.ItemsSource = new List<ContactGroup>
            //{
            //    new ContactGroup("V", "V")
            //    {
            //        new Contact {Name = "Vinícius", ImageUrl = "http://lorempixel.com/100/100/people/1"},
            //    },
            //    new ContactGroup("R", "R")
            //    {
            //        new Contact {Name = "Rebeca", ImageUrl = "http://lorempixel.com/100/100/people/2", Status="Hey, Let's talk"}
            //    }
            //};

            _contacts = new ObservableCollection<Contact>
            {
                new Contact {Name = "Vinícius", ImageUrl = "http://lorempixel.com/100/100/people/1"},
                new Contact {Name = "Rebeca", ImageUrl = "http://lorempixel.com/100/100/people/2", Status="Hey, Let's talk"}
            };

            listView.ItemsSource = GetContacts();
        }

        private void listView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            listView.SelectedItem = null;
            //var contact = e.SelectedItem as Contact;
            //DisplayAlert("Selected", contact.Name, "Ok");
        }

        private void listView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            //var contact = e.Item as Contact;
            //DisplayAlert("Tapped", contact.Name, "Ok");
        }

        private void Call_Clicked(object sender, EventArgs e)
        {
            var menuItem = sender as MenuItem;
            var contact = menuItem.CommandParameter as Contact;

            DisplayAlert("Call", contact.Name, "Ok");
        }
        private void Delete_Clicked(object sender, EventArgs e)
        {
            var contact = (sender as MenuItem).CommandParameter as Contact;
            _contacts.Remove(contact);

        }

        IEnumerable<Contact> GetContacts(string searchtext = null)
        {
            var contacts = new List<Contact>
            {
                new Contact {Name = "Victor", ImageUrl = "http://lorempixel.com/100/100/people/3"},
                new Contact {Name = "Vinícius", ImageUrl = "http://lorempixel.com/100/100/people/1"},
                new Contact {Name = "Rebeca", ImageUrl = "http://lorempixel.com/100/100/people/2", Status="Hey, Let's talk"}
            };
            if (string.IsNullOrWhiteSpace(searchtext))
            {
                return contacts;
            }

            return contacts.Where(c => c.Name.StartsWith(searchtext));
        }

        private void listView_Refreshing(object sender, EventArgs e)
        {
            listView.ItemsSource = GetContacts();
            //listView.IsRefreshing = false;
            listView.EndRefresh();
        }

        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            listView.ItemsSource = GetContacts(e.NewTextValue);
        }
    }
}
