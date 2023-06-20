using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using Turboaz.DataAccess.Abstraction;
using Turboaz.DataAccess.Concrete;
using Turboaz.Domain.Views.UserControls;

namespace Turboaz.Domain.ViewModels
{
    public class MainWindowViewModel:BaseViewModel
    {
        public IUnitOfWork unitOfWork { get; set; }
        public MainUserControl userControl;
        public MainUserControlUserViewModel usercontrolViewModel;


        public MainWindowViewModel()
        {
            unitOfWork=new EFUnitOfWork();
            for (int i = 1; i < unitOfWork.ICarRepositery.GetAll().Count; i++)
            {
                userControl = new MainUserControl();
                usercontrolViewModel = new MainUserControlUserViewModel();
                var modelId= unitOfWork.ICarRepositery.GetData(i).ModelId;
                var model = unitOfWork.IModelRepositery.GetData(modelId);
                usercontrolViewModel.ImagePath = unitOfWork.ICarRepositery.GetData(i).ImagePath;
                var brand = unitOfWork.IBrandRepositery.GetData(model.BrandId);
                usercontrolViewModel.Marka= brand.BrandName + " - "+model.ModelName;
                usercontrolViewModel.Year=unitOfWork.ICarRepositery.GetData(i).Year;
                usercontrolViewModel.Engine = unitOfWork.ICarRepositery.GetData(i).Engine+" L";
                usercontrolViewModel.Price=unitOfWork.ICarRepositery.GetData(i).Price;
               


                userControl.DataContext=usercontrolViewModel;
                App.WrapPanel.Children.Add(userControl);
            }
        }
    }
}
