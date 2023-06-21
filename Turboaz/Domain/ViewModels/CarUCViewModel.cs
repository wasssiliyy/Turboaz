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
        IUnitOfWork unitOfWork;
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

        private int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value;OnPropertyChanged(); }
        }

        private string marka;

        public string Marka
        {
            get { return marka; }
            set { marka = value; OnPropertyChanged(); }
        }

        private string _color;

        public string Colors
        {
            get { return _color; }
            set { _color = value; OnPropertyChanged(); }
        }


        public MainUserControl userControl;
        public MainUserControlUserViewModel usercontrolViewModel;
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
