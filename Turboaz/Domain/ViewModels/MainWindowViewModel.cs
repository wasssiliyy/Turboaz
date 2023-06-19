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
            //for (int i = 0; i < unitOfWork.ICarRepositery.GetAll().Count; i++)
            //{
            //    userControl.DataContext = unitOfWork.ICarRepositery.GetAll()[i];
            //}
        }
    }
}
