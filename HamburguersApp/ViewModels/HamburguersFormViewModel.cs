using HamburguersApp.Models;
using HamburguersApp.Utils.Controllers;
using HamburguersApp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace HamburguersApp.ViewModels
{
    public class HamburguersFormViewModel:BaseViewModel
    {
        public Page Context { get; set; }
      

        private string _name = null;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
                OnPropertyChanged();
            }
        }

        private string _description = null;
        public string Description
        {
            get
            {
                return _description;
            }
            set
            {
                _description = value;
                OnPropertyChanged();
            }
        }

      
        public Command PostHamburguer
        {
            get
            {
                return new Command(async () =>
                {
                    var formErrors = GetFormErrors();
                    if (formErrors.Count == 0)
                    {
                        var controller = new HamburguerController();
                        this.IsBusy = true;
                        var hamburguer = await controller.PostHamburguer(new Hamburguer()
                        {
                            Description = this.Description,
                            Name = this.Name
                        });
                        this.IsBusy = false;
                        ClearForm();
                    }
                    else
                    {
                        this.Context.DisplayAlert("Error", string.Join("\n", formErrors), "Entendido");
                    }
                });
            }
        }

        private void ClearForm()
        {
            this.Name = "";
            this.Description = "";
        }

        private List<string> GetFormErrors()
        {
            List<string> errors = new List<string>();
            if (string.IsNullOrEmpty(Name))
            {
                errors.Add("El campo del nombre del hamburguer esta vacio");
            }
            if (string.IsNullOrEmpty(Description))
            {
                errors.Add("El campo de la descripcion del hamburguer esta vacio");
            }
            return errors;
        }


    }
}
