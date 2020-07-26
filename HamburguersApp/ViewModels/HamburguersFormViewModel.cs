using HamburguersApp.Models;
using HamburguersApp.Utils.Controllers;
using HamburguersApp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace HamburguersApp.ViewModels
{
    public class HamburguersFormViewModel:BaseViewModel
    {
        public Page Context { get; set; }
        private const string PlaceHolderImage = "https://raw.githubusercontent.com/Gr3gorywolf/DominioTic-Hamburguers-app/master/docs/img/icon.png";

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

        private string _imageUrl = PlaceHolderImage;
        public string ImageUrl
        {
            get
            {
                return _imageUrl;
            }
            set
            {
                _imageUrl = value;
                OnPropertyChanged();
            }
        }

        public Command InputImage
        {
            get
            {
                return new Command(async () =>
                {
                    var options = new string[] { "Desde galeria (Proximanente)", "Desde camara (Proximamente)", "Desde Url","Quitar imagen" };
                    var option = await Context.DisplayActionSheet("Desde donde proviene la imagen", "Cerrar", null, options);
                    switch (options.IndexOf(option))
                    {
                        case 2:
                            var imageUrl = await Context.DisplayPromptAsync("Cual digite la url de la imagen", "", "Ok", "Cerrar", "url de la imagen");
                            this.ImageUrl = imageUrl;
                            break;
                        case 3:
                            this.ImageUrl = PlaceHolderImage;
                            break;
                    }
                });
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
                            Name = this.Name,
                            Image = this.ImageUrl,
                            RestaurantId = 1                      
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
            this.ImageUrl = PlaceHolderImage;
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
            if (string.IsNullOrEmpty(ImageUrl))
            {
                errors.Add("El campo de la imagen del hamburguer esta vacio");
            }
            return errors;
        }


    }
}
