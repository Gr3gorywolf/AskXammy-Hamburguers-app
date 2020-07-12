using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HamburguersApp.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HamburguersList : ContentPage
    {
        public HamburguersList()
        {
            InitializeComponent();
        }
    }
}