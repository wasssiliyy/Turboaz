using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turboaz.Domain.ViewModels
{
    public class CarUCViewModel:BaseViewModel
    {
		private string _carimagePath;

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
		

	}
}
