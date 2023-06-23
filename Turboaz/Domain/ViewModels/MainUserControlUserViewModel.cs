using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Turboaz.Commands;
using Turboaz.DataAccess.Abstraction;
using Turboaz.DataAccess.Concrete;
using Turboaz.Domain.Entities;
using Turboaz.Domain.Views.UserControls;
using Turboaz.Entities;

namespace Turboaz.Domain.ViewModels
{
    public class MainUserControlUserViewModel : BaseViewModel
    {

        public RelayCommand Show { get; set; }
        public RelayCommand CarButton { get; set; }
        private Car selectedCar;

        public Car SelectedCar
        {
            get { return selectedCar; }
            set { selectedCar = value; }
        }




        public MainUserControlUserViewModel()
        {

            CarButton = new RelayCommand(obj =>
            {
                App.WrapPanel.Children.Clear();

                CarUCViewModel carUCViewModel = new CarUCViewModel();
                CarUCView carUCView = new CarUCView();
                carUCViewModel.Price = selectedCar.Price.ToString() + " $";
                carUCViewModel.Brands = selectedCar.Model.Brand.BrandName;
                carUCViewModel.CarImagePath = selectedCar.ImagePath;
                carUCViewModel.City = selectedCar.City.CityName;
                carUCViewModel.Colors = selectedCar.Color.ColorName;
                carUCViewModel.Model = selectedCar.Model.ModelName;
                var check = selectedCar.IsNew;
                carUCViewModel.IsNew = check ? "New" : "Used";
                carUCViewModel.FuelType = selectedCar.FuelType.FuelTypeName;
                carUCView.DataContext = carUCViewModel;
                App.WrapPanel.Children.Add(carUCView);
            });

            //Show = new RelayCommand(obj =>
            //{
            //    MainWindowViewModel mainWindowViewModel = new MainWindowViewModel();
            //    MainWindow mainWindowView = new MainWindow();
            //    if (mainWindowViewModel.Brands != null)
            //    {
            //        App.WrapPanel.Children.Clear();
            //        if (mainWindowViewModel.Brands.ToString() != "None")
            //        {
            //            mainWindowViewModel.Cars = 
            //        App.WrapPanel.Children.Add(mainWindowView);
            //        }
            //    }

            //    mainWindowView.DataContext = mainWindowViewModel;
            //});
        }



        private string _km;

        public string Km
        {
            get { return _km; }
            set { _km = value; OnPropertyChanged(); }
        }





        private string _price;
        public string Price
        {
            get { return _price; }
            set { _price = value; OnPropertyChanged(); }
        }


        private string _city;

        public string City
        {
            get { return _city; }
            set { _city = value; OnPropertyChanged(); }
        }


        private string _marka;

        public string Marka
        {
            get { return _marka; }
            set { _marka = value; OnPropertyChanged(); }
        }

        private string _engine;

        public string Engine
        {
            get { return _engine; }
            set { _engine = value; OnPropertyChanged(); }
        }
        private string _imagePath;

        public string ImagePath
        {
            get { return _imagePath; }
            set { _imagePath = value; OnPropertyChanged(); }
        }
        private string _year;

        public string Year
        {
            get { return _year; }
            set { _year = value; OnPropertyChanged(); }
        }

        private string _color;

        public string Color
        {
            get { return _color; }
            set { _color = value; OnPropertyChanged(); }
        }

        private string fuelType;

        public string FuelType
        {
            get { return fuelType; }
            set { fuelType = value; OnPropertyChanged(); }
        }

        private string _isNew;

        public string IsNew
        {
            get { return _isNew; }
            set { _isNew = value; OnPropertyChanged(); }
        }


    }
}
