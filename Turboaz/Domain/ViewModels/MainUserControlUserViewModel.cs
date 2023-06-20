using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Turboaz.Commands;
using Turboaz.Domain.Views.UserControls;

namespace Turboaz.Domain.ViewModels
{
    public class MainUserControlUserViewModel:BaseViewModel
    {
		public RelayCommand CarButton { get; set; }
		private decimal _price;

		public MainUserControlUserViewModel()
		{
			CarButton = new RelayCommand(obj =>
			{
				App.WrapPanel.Children.Clear();
				var carViewModel=new CarUCViewModel();
				var carView=new CarUCView();
				carView.DataContext = carViewModel;
				carViewModel.CarImagePath=ImagePath;
				App.WrapPanel.Children.Add(carView);
			});
		}
		public decimal Price
		{
			get { return _price; }
			set { _price = value; OnPropertyChanged(); }
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
			set { _engine = value;OnPropertyChanged(); }
		}
		private string _imagePath;

		public string ImagePath
		{
			get { return _imagePath; }
			set { _imagePath = value; OnPropertyChanged(); }
		}
		private int _year;

		public int Year
		{
			get { return _year; }
			set { _year = value; OnPropertyChanged(); }
		}


	}
}
