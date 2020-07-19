using HamburguersApp.Models;
using HamburguersApp.Utils.Controllers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace HamburguersApp.ViewModels
{
   public class HamburguerListViewModel:BaseViewModel
    {
        public Page Context { get; set; }

        private ObservableCollection<Hamburguer> _hamburguers = new ObservableCollection<Hamburguer>();
        public ObservableCollection<Hamburguer> Hamburguers
        {
            get
            {
                return _hamburguers;
            }
            set
            {
                _hamburguers = value;
                OnPropertyChanged();
            }
        }

        public Command FetchHamburguers
        {
            get
            {
                return new Command(async () =>
                {
                    this.IsBusy = true;
                    var controller = new HamburguerController();
                    var response = await controller.GetHamburguers();
                    Hamburguers = new ObservableCollection<Hamburguer>(response);
                    IsBusy = false;
                });
            }
        }
    }
}
