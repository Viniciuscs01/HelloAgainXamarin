using HelloWorld2.Models;
using HelloWorld2.Services;
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
    public partial class ListsEx1 : ContentPage
    {
        SearchService searchServ;
        SearchGroup searchGroup;
        public ListsEx1()
        {
            searchServ = new SearchService();

            InitializeComponent();            

            searchGroup = new SearchGroup("Recent Searchs", searchServ.GetSearchs());            

            listView.ItemsSource = new ObservableCollection<SearchGroup>
            {
                searchGroup
            };
        }

        private void listView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            listView.SelectedItem = null;
        }

        private void listView_ItemTapped(object sender, ItemTappedEventArgs e)
        {

        }

        private void listView_Refreshing(object sender, EventArgs e)
        {

        }

        private void Delete_Clicked(object sender, EventArgs e)
        {
            var search = (sender as MenuItem).CommandParameter as Search;

            searchGroup.Remove(search);
            searchServ.DeleteSearch(search.Id);
            

        }
    }
}
