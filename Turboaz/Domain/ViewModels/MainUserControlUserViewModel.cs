using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Turboaz.Commands;

namespace Turboaz.Domain.ViewModels
{
    public class MainUserControlUserViewModel:BaseViewModel
    {
		public RelayCommand CarButton { get; set; }
		private decimal _price;

		public decimal PriceCommand
		{
			get { return _price; }
			set { _price = value; OnPropertyChanged(); }
		}


		private string _marka;

		public string MarkaCommand
		{
			get { return _marka; }
			set { _marka = value; OnPropertyChanged(); }
		}

		private int _engine;

		public int EngineCommand
		{
			get { return _engine; }
			set { _engine = value; }
		}

	}
}
