using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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



        public MainUserControl userControl;
        public MainUserControlUserViewModel usercontrolViewModel;
        public CarUCViewModel()
        {
            backCommand = new RelayCommand(obj =>
            {
                App.WrapPanel.Children.Clear();
                unitOfWork = new EFUnitOfWork();
                for (int i = 1; i < unitOfWork.ICarRepositery.GetAll().Count; i++)
                {
                    userControl = new MainUserControl();
                    usercontrolViewModel = new MainUserControlUserViewModel();
                    var modelId = unitOfWork.ICarRepositery.GetData(i).ModelId;
                    var model = unitOfWork.IModelRepositery.GetData(modelId);
                    usercontrolViewModel.ImagePath = unitOfWork.ICarRepositery.GetData(i).ImagePath;
                    var brand = unitOfWork.IBrandRepositery.GetData(model.BrandId);
                    usercontrolViewModel.Marka = brand.BrandName + " - " + model.ModelName;
                    usercontrolViewModel.Year = unitOfWork.ICarRepositery.GetData(i).Year;
                    usercontrolViewModel.Engine = unitOfWork.ICarRepositery.GetData(i).Engine + " L";
                    usercontrolViewModel.Price = unitOfWork.ICarRepositery.GetData(i).Price;



                    userControl.DataContext = usercontrolViewModel;
                    App.WrapPanel.Children.Add(userControl);
                }
            });
        }
    }
}
