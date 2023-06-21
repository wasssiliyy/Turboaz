using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using Turboaz.DataAccess.Abstraction;
using Turboaz.DataAccess.Concrete;
using Turboaz.Domain.Entities;
using Turboaz.Domain.Views.UserControls;
using Turboaz.Entities;

namespace Turboaz.Domain.ViewModels
{
    public class MainWindowViewModel:BaseViewModel
    {
        public IUnitOfWork unitOfWork { get; set; }
        public MainUserControl userControl;
        public MainUserControlUserViewModel usercontrolViewModel;
        private ObservableCollection<Car> _cars;

        public ObservableCollection<Car> Cars
        {
            get { return _cars; }
            set { _cars = value; }
        }

        private ObservableCollection<Brand> _brand;

        public ObservableCollection<Brand> Brands
        {
            get { return _brand; }
            set { _brand = value; OnPropertyChanged(); }
        }

        private ObservableCollection<Model> _model;

        public ObservableCollection<Model> Models
        {
            get { return _model; }
            set { _model = value; OnPropertyChanged(); }
        }

        private ObservableCollection<City> _cities;

        public ObservableCollection<City> Cities
        {
            get { return _cities; }
            set { _cities = value; OnPropertyChanged(); }
        }

        private ObservableCollection<CarsColor> _carsColors;

        public ObservableCollection<CarsColor> Colors
        {
            get { return _carsColors; }
            set { _carsColors = value; OnPropertyChanged(); }
        }

        private ObservableCollection<FuelType> _fuelType;

        public ObservableCollection<FuelType> FuelTypes
        {
            get { return _fuelType; }
            set { _fuelType = value; OnPropertyChanged(); }
        }

        


        public MainWindowViewModel()
        {
            Brands = new ObservableCollection<Brand>(App.DB.IBrandRepositery.GetAll());
            Cars = new ObservableCollection<Car>(App.DB.ICarRepositery.GetAll());
            Models = new ObservableCollection<Model>(App.DB.IModelRepositery.GetAll());
            Colors=new ObservableCollection<CarsColor>(App.DB.ICarsColorRepositery.GetAll());
            Cities = new ObservableCollection<City>(App.DB.ICityRepositery.GetAll());
            FuelTypes = new ObservableCollection<FuelType>(App.DB.IFuelTypeRepositery.GetAll());



            App.WrapPanel.Children.Clear();
            for (int i = 0; i < Cars.Count; i++)
            {     
                userControl = new MainUserControl();
                usercontrolViewModel = new MainUserControlUserViewModel();
                usercontrolViewModel.SelectedCar = Cars[i];
                usercontrolViewModel.ImagePath = Cars[i].ImagePath;
                usercontrolViewModel.Color = Cars[i].Color.ColorName;
                
                usercontrolViewModel.Marka = Cars[i].Model.Brand.BrandName;
                usercontrolViewModel.Year = Cars[i].Year;
                usercontrolViewModel.Engine = Cars[i].Engine;
                usercontrolViewModel.Price = Cars[i].Price +" $";
                userControl.DataContext=usercontrolViewModel;
                App.WrapPanel.Children.Add(userControl);
            }
        }
    }
}
