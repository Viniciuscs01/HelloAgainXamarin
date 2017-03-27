using HelloWorld2.Models;
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
    public partial class MasterContactDetailPage : ContentPage
    {
        public MasterContactDetailPage(Contact contact)
        {
            BindingContext = contact ?? throw new ArgumentNullException();

            InitializeComponent();
        }
    }
}
