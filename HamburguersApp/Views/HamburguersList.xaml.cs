using HamburguersApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HamburguersApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HamburguersList : ContentPage
    {
        private static HamburguersList _instance = null;
        public HamburguersList()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            _instance = this;
            base.OnAppearing();
            ((HamburguerListViewModel)_instance.BindingContext)
                      .FetchHamburguers
                      .Execute(null);
        }
     
    }
}