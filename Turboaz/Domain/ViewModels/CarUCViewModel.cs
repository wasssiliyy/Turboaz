using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Turboaz.Commands;
using Turboaz.DataAccess.Abstraction;
using Turboaz.DataAccess.Concrete;
using Turboaz.Domain.Views.UserControls;

namespace Turboaz.Domain.ViewModels
{
    public class CarUCViewModel : BaseViewModel
    {
        
        private string _carimagePath;
      
        public RelayCommand backCommand { get; set; }
        public string CarImagePath
        {
            get { return _carimagePath; }
            set { _carimagePath = value; OnPropertyChanged(); }
        }

        private string _city;

        public string City
        {
            get { return _city; }
            set { _city = value; OnPropertyChanged(); }
        }

        private string _model;

        public string Model
        {
            get { return _model; }
            set { _model = value; OnPropertyChanged(); }
        }

        private string _price;

        public string Price
        {
            get { return _price; }
            set { _price = value; OnPropertyChanged(); }
        }


        private string _brand;

        public string Brands
        {
            get { return _brand; }
            set { _brand = value; OnPropertyChanged(); }
        }

        private string _color;

        public string Colors
        {
            get { return _color; }
            set { _color = value; OnPropertyChanged(); }
        }

        private string _fuelType;

        public string FuelType
        {
            get { return _fuelType; }
            set { _fuelType = value; OnPropertyChanged(); }
        }

        private string _isNew;

        public string IsNew
        {
            get { return _isNew; }
            set { _isNew = value; OnPropertyChanged(); }
        }

        public CarUCViewModel()
        {
        
                ///BACK COMMAND
            backCommand = new RelayCommand(obj =>
            {
                var vm = new MainWindowViewModel();
            });
        }
    }
}
