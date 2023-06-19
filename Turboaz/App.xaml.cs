using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Turboaz.DataAccess.Abstraction;
using Turboaz.DataAccess.Concrete;
using Turboaz.Domain.Entities;
using Turboaz.Entities;

namespace Turboaz
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static IUnitOfWork DB;
        public App()
        {
            DB = new EFUnitOfWork();
            if (DB.ICityRepositery.GetAll().Count == 0)
            {
                DB.ICityRepositery.AddData(new City { CityName = "London" });
                DB.ICityRepositery.AddData(new City { CityName = "Baku" });
                DB.ICityRepositery.AddData(new City { CityName = "Antalya" });
                DB.ICityRepositery.AddData(new City { CityName = "Koln" });
            }

            if (DB.IBrandRepositery.GetAll().Count == 0)
            {
                DB.IBrandRepositery.AddData(new Brand { BrandName = "BMW" });
                DB.IBrandRepositery.AddData(new Brand { BrandName = "Mescedes" });
                DB.IBrandRepositery.AddData(new Brand { BrandName = "Lada" });
                DB.IBrandRepositery.AddData(new Brand { BrandName = "Ferrari" });
                DB.IBrandRepositery.AddData(new Brand { BrandName = "Rolls-Royce" });
                DB.IBrandRepositery.AddData(new Brand { BrandName = "Bentley" });
                DB.IBrandRepositery.AddData(new Brand { BrandName = "Porsche" });
                DB.IBrandRepositery.AddData(new Brand { BrandName = "Tesla" });
            }

            if (DB.IModelRepositery.GetAll().Count == 0)
            {
                DB.IModelRepositery.AddData(new Model { ModelName = "IX", BrandId = 1 });
                DB.IModelRepositery.AddData(new Model { ModelName = "I8", BrandId = 1 });
                DB.IModelRepositery.AddData(new Model { ModelName = "I7", BrandId = 1 });
                DB.IModelRepositery.AddData(new Model { ModelName = "I4", BrandId = 1 });
                DB.IModelRepositery.AddData(new Model { ModelName = "I3", BrandId = 1 });

                DB.IModelRepositery.AddData(new Model { ModelName = "Benz S Class 400", BrandId = 2 });
                DB.IModelRepositery.AddData(new Model { ModelName = "GLS 63 AMG", BrandId = 2 });
                DB.IModelRepositery.AddData(new Model { ModelName = "GL Brabus Widestar", BrandId = 2 });
                DB.IModelRepositery.AddData(new Model { ModelName = "S 63 AMG", BrandId = 2 });

                DB.IModelRepositery.AddData(new Model { ModelName = "XRAY", BrandId = 3 });
                DB.IModelRepositery.AddData(new Model { ModelName = "Vesta SW Cross", BrandId = 3 });
                DB.IModelRepositery.AddData(new Model { ModelName = "Vesta SW", BrandId = 3 });
                DB.IModelRepositery.AddData(new Model { ModelName = "Largus", BrandId = 3 });
                DB.IModelRepositery.AddData(new Model { ModelName = "Priora", BrandId = 3 });

                DB.IModelRepositery.AddData(new Model { ModelName = "Ferrari Purosangue", BrandId = 4 });
                DB.IModelRepositery.AddData(new Model { ModelName = "Ferrari F8 Tributo", BrandId = 4 });
                DB.IModelRepositery.AddData(new Model { ModelName = "458 Spyder", BrandId = 4 });
                DB.IModelRepositery.AddData(new Model { ModelName = "Ferrari Roma", BrandId = 4 });
                DB.IModelRepositery.AddData(new Model { ModelName = "Ferrari 812", BrandId = 4 });

                DB.IModelRepositery.AddData(new Model { ModelName = "Rolls Royce Dawn", BrandId = 5 });
                DB.IModelRepositery.AddData(new Model { ModelName = "Rolls-Royce Cullinan", BrandId = 5 });
                DB.IModelRepositery.AddData(new Model { ModelName = "Rolls Royce Wraith", BrandId = 5 });
                DB.IModelRepositery.AddData(new Model { ModelName = "Rolls-Royce Ghost", BrandId = 5 });
                DB.IModelRepositery.AddData(new Model { ModelName = "Rolls-Royce Phantom", BrandId = 5 });

                DB.IModelRepositery.AddData(new Model { ModelName = "Bentley Continental", BrandId = 6 });
                DB.IModelRepositery.AddData(new Model { ModelName = "Bentley Flying Spur", BrandId = 6 });
                DB.IModelRepositery.AddData(new Model { ModelName = "Bentley Bentayga", BrandId = 6 });
                DB.IModelRepositery.AddData(new Model { ModelName = "Bentley Bentayga EWB", BrandId = 6 });

                DB.IModelRepositery.AddData(new Model { ModelName = "Porsche 911", BrandId = 7 });
                DB.IModelRepositery.AddData(new Model { ModelName = "Porsche Macan", BrandId = 7 });
                DB.IModelRepositery.AddData(new Model { ModelName = "Porsche Panamera", BrandId = 7 });
                DB.IModelRepositery.AddData(new Model { ModelName = "Porsche 718", BrandId = 7 });
                DB.IModelRepositery.AddData(new Model { ModelName = "Porsche Cayenne Coupe", BrandId = 7 });

                DB.IModelRepositery.AddData(new Model { ModelName = "Tesla CYBERTRUCK", BrandId = 8 });
                DB.IModelRepositery.AddData(new Model { ModelName = "Tesla Model 3", BrandId = 8 });
                DB.IModelRepositery.AddData(new Model { ModelName = "Tesla Model Y", BrandId = 8 });
            }

            if (DB.IFuelTypeRepositery.GetAll().Count == 0)
            {
                DB.IFuelTypeRepositery.AddData(new FuelType { Name = "Gasoline" });
                DB.IFuelTypeRepositery.AddData(new FuelType { Name = "Diesel" });
                DB.IFuelTypeRepositery.AddData(new FuelType { Name = "Hybrid" });
                DB.IFuelTypeRepositery.AddData(new FuelType { Name = "Gas" });
                DB.IFuelTypeRepositery.AddData(new FuelType { Name = "Electron" });
            }

            if (DB.ICarsColorRepositery.GetAll().Count == 0)
            {
                DB.ICarsColorRepositery.AddData(new CarsColor { ColorName = "Black" });
                DB.ICarsColorRepositery.AddData(new CarsColor { ColorName = "Green" });
                DB.ICarsColorRepositery.AddData(new CarsColor { ColorName = "Blue" });
                DB.ICarsColorRepositery.AddData(new CarsColor { ColorName = "Red" });
                DB.ICarsColorRepositery.AddData(new CarsColor { ColorName = "White" });
                DB.ICarsColorRepositery.AddData(new CarsColor { ColorName = "Grey" });
            }


            if (DB.ICarRepositery.GetAll().Count == 0)
            {
                DB.ICarRepositery.AddData(new Car { CityId = 1, ColorId = 1, ModelId = 6, FuelTypeId = 1, Engine="2.8", Km=0.0, Price=200000M, Year=new DateTime(2021,1,1), ImagePath= "https://cdni.autocarindia.com/Utils/ImageResizer.ashx?n=https://cdni.autocarindia.com/ExtraImages/20210630112726_S_class_tracking.jpg&w=726&h=482&q=75&c=1",IsNew=true,  });
                DB.ICarRepositery.AddData(new Car { CityId = 2, ColorId = 5, ModelId = 7, FuelTypeId = 1, Engine = "3.2", Km = 0.0, Price = 150000M, Year = new DateTime(2020, 1, 1), ImagePath = "https://turbo.azstatic.com/uploads/full/2022%2F09%2F01%2F14%2F18%2F17%2F71f08c4f-aabf-4113-bc24-63af7134d5a8%2F56854_ptv6AjDCrrVXjMNJg1jejw.jpg", IsNew = true });
                DB.ICarRepositery.AddData(new Car { CityId = 3, ColorId = 6, ModelId = 8, FuelTypeId = 1, Engine = "5.5", Km = 0.0, Price = 225000M, Year = new DateTime(2023, 1, 1), ImagePath = "https://www.motortrend.com/uploads/f/52840685.jpg?fit=around%7C874:546.25", IsNew = true });
                DB.ICarRepositery.AddData(new Car { CityId = 4, ColorId = 5, ModelId = 9, FuelTypeId = 1, Engine = "3.2", Km = 30000, Price = 80000M, Year = new DateTime(2021, 1, 1), ImagePath = "https://kolesa-uploads.ru/-/07929c67-a1fa-4e2e-a50b-aa9a6ea650b6/mercedes-amg-s63e-front2-mini.jpg.webp", IsNew = false });
                DB.ICarRepositery.AddData(new Car { CityId = 1, ColorId = 6, ModelId = 5, FuelTypeId = 5, Engine = "2.3", Km = 54000, Price = 90000M, Year = new DateTime(2019, 1, 1), ImagePath = "https://soyacincau.com/wp-content/uploads/2023/01/01.-The-New-BMW-iX-xDrive50-Sport.jpg", IsNew = false });
                DB.ICarRepositery.AddData(new Car { CityId = 2, ColorId = 6, ModelId = 6, FuelTypeId = 1, Engine = "3.2", Km = 0.0, Price = 150000M, Year = new DateTime(2020, 1, 1), ImagePath = "", IsNew = true });
                DB.ICarRepositery.AddData(new Car { CityId = 3, ColorId = 1, ModelId = 7, FuelTypeId = 1, Engine = "3.2", Km = 0.0, Price = 150000M, Year = new DateTime(2020, 1, 1), ImagePath = "", IsNew = true });
                DB.ICarRepositery.AddData(new Car { CityId = 4, ColorId = 2, ModelId = 8, FuelTypeId = 1, Engine = "3.2", Km = 0.0, Price = 150000M, Year = new DateTime(2020, 1, 1), ImagePath = "", IsNew = true });
                DB.ICarRepositery.AddData(new Car { CityId = 3, ColorId = 3, ModelId = 9, FuelTypeId = 1, Engine = "3.2", Km = 0.0, Price = 150000M, Year = new DateTime(2020, 1, 1), ImagePath = "", IsNew = true });
                DB.ICarRepositery.AddData(new Car { CityId = 3, ColorId = 3, ModelId = 10, FuelTypeId = 1, Engine = "3.2", Km = 0.0, Price = 150000M, Year = new DateTime(2020, 1, 1), ImagePath = "", IsNew = true });
                DB.ICarRepositery.AddData(new Car { CityId = 3, ColorId = 3, ModelId =11, FuelTypeId = 1, Engine = "3.2", Km = 0.0, Price = 150000M, Year = new DateTime(2020, 1, 1), ImagePath = "", IsNew = true });
                DB.ICarRepositery.AddData(new Car { CityId = 3, ColorId = 3, ModelId = 12, FuelTypeId = 1, Engine = "3.2", Km = 0.0, Price = 150000M, Year = new DateTime(2020, 1, 1), ImagePath = "", IsNew = true });
                DB.ICarRepositery.AddData(new Car { CityId = 3, ColorId = 3, ModelId = 13, FuelTypeId = 1, Engine = "3.2", Km = 0.0, Price = 150000M, Year = new DateTime(2020, 1, 1), ImagePath = "", IsNew = true });
                DB.ICarRepositery.AddData(new Car { CityId = 3, ColorId = 3, ModelId = 14, FuelTypeId = 1, Engine = "3.2", Km = 0.0, Price = 150000M, Year = new DateTime(2020, 1, 1), ImagePath = "", IsNew = true });
                DB.ICarRepositery.AddData(new Car { CityId = 3, ColorId = 3, ModelId = 15, FuelTypeId = 1, Engine = "3.2", Km = 0.0, Price = 150000M, Year = new DateTime(2020, 1, 1), ImagePath = "", IsNew = true });
                DB.ICarRepositery.AddData(new Car { CityId = 3, ColorId = 3, ModelId = 16, FuelTypeId = 1, Engine = "3.2", Km = 0.0, Price = 150000M, Year = new DateTime(2020, 1, 1), ImagePath = "", IsNew = true });
                DB.ICarRepositery.AddData(new Car { CityId = 3, ColorId = 3, ModelId = 17, FuelTypeId = 1, Engine = "3.2", Km = 0.0, Price = 150000M, Year = new DateTime(2020, 1, 1), ImagePath = "", IsNew = true });
                DB.ICarRepositery.AddData(new Car { CityId = 3, ColorId = 3, ModelId = 18, FuelTypeId = 1, Engine = "3.2", Km = 0.0, Price = 150000M, Year = new DateTime(2020, 1, 1), ImagePath = "", IsNew = true });
                DB.ICarRepositery.AddData(new Car { CityId = 3, ColorId = 3, ModelId = 19, FuelTypeId = 1, Engine = "3.2", Km = 0.0, Price = 150000M, Year = new DateTime(2020, 1, 1), ImagePath = "", IsNew = true });
                DB.ICarRepositery.AddData(new Car { CityId = 3, ColorId = 3, ModelId = 20, FuelTypeId = 1, Engine = "3.2", Km = 0.0, Price = 150000M, Year = new DateTime(2020, 1, 1), ImagePath = "", IsNew = true });
                DB.ICarRepositery.AddData(new Car { CityId = 3, ColorId = 3, ModelId = 21, FuelTypeId = 1, Engine = "3.2", Km = 0.0, Price = 150000M, Year = new DateTime(2020, 1, 1), ImagePath = "", IsNew = true });
                DB.ICarRepositery.AddData(new Car { CityId = 3, ColorId = 3, ModelId = 22, FuelTypeId = 1, Engine = "3.2", Km = 0.0, Price = 150000M, Year = new DateTime(2020, 1, 1), ImagePath = "", IsNew = true });
                DB.ICarRepositery.AddData(new Car { CityId = 3, ColorId = 3, ModelId = 23, FuelTypeId = 1, Engine = "3.2", Km = 0.0, Price = 150000M, Year = new DateTime(2020, 1, 1), ImagePath = "", IsNew = true });
                DB.ICarRepositery.AddData(new Car { CityId = 3, ColorId = 3, ModelId = 24, FuelTypeId = 1, Engine = "3.2", Km = 0.0, Price = 150000M, Year = new DateTime(2020, 1, 1), ImagePath = "", IsNew = true });
                DB.ICarRepositery.AddData(new Car { CityId = 3, ColorId = 3, ModelId = 25, FuelTypeId = 1, Engine = "3.2", Km = 0.0, Price = 150000M, Year = new DateTime(2020, 1, 1), ImagePath = "", IsNew = true });
                DB.ICarRepositery.AddData(new Car { CityId = 3, ColorId = 3, ModelId = 26, FuelTypeId = 1, Engine = "3.2", Km = 0.0, Price = 150000M, Year = new DateTime(2020, 1, 1), ImagePath = "", IsNew = true });
                DB.ICarRepositery.AddData(new Car { CityId = 3, ColorId = 3, ModelId = 27, FuelTypeId = 1, Engine = "3.2", Km = 0.0, Price = 150000M, Year = new DateTime(2020, 1, 1), ImagePath = "", IsNew = true });
                DB.ICarRepositery.AddData(new Car { CityId = 3, ColorId = 3, ModelId = 28, FuelTypeId = 1, Engine = "3.2", Km = 0.0, Price = 150000M, Year = new DateTime(2020, 1, 1), ImagePath = "", IsNew = true });
                DB.ICarRepositery.AddData(new Car { CityId = 3, ColorId = 3, ModelId = 29, FuelTypeId = 1, Engine = "3.2", Km = 0.0, Price = 150000M, Year = new DateTime(2020, 1, 1), ImagePath = "", IsNew = true });
                DB.ICarRepositery.AddData(new Car { CityId = 3, ColorId = 3, ModelId = 30, FuelTypeId = 1, Engine = "3.2", Km = 0.0, Price = 150000M, Year = new DateTime(2020, 1, 1), ImagePath = "", IsNew = true });
                DB.ICarRepositery.AddData(new Car { CityId = 3, ColorId = 3, ModelId = 31, FuelTypeId = 1, Engine = "3.2", Km = 0.0, Price = 150000M, Year = new DateTime(2020, 1, 1), ImagePath = "", IsNew = true });
                DB.ICarRepositery.AddData(new Car { CityId = 3, ColorId = 3, ModelId = 32, FuelTypeId = 1, Engine = "3.2", Km = 0.0, Price = 150000M, Year = new DateTime(2020, 1, 1), ImagePath = "", IsNew = true });
                DB.ICarRepositery.AddData(new Car { CityId = 3, ColorId = 3, ModelId = 33, FuelTypeId = 1, Engine = "3.2", Km = 0.0, Price = 150000M, Year = new DateTime(2020, 1, 1), ImagePath = "", IsNew = true });
                DB.ICarRepositery.AddData(new Car { CityId = 3, ColorId = 3, ModelId = 34, FuelTypeId = 1, Engine = "3.2", Km = 0.0, Price = 150000M, Year = new DateTime(2020, 1, 1), ImagePath = "", IsNew = true });
                DB.ICarRepositery.AddData(new Car { CityId = 3, ColorId = 3, ModelId = 35, FuelTypeId = 1, Engine = "3.2", Km = 0.0, Price = 150000M, Year = new DateTime(2020, 1, 1), ImagePath = "", IsNew = true });
                DB.ICarRepositery.AddData(new Car { CityId = 3, ColorId = 3, ModelId = 36, FuelTypeId = 1, Engine = "3.2", Km = 0.0, Price = 150000M, Year = new DateTime(2020, 1, 1), ImagePath = "", IsNew = true });
            }
            
            
            if(DB.ICarsColorRepositery.GetAll().Count == 0)
            {

            }
        }
    }
}
