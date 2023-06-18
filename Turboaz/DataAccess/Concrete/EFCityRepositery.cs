using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Turboaz.DataAccess.Abstraction;
using Turboaz.Domain.Entities;

namespace Turboaz.DataAccess.Concrete
{
    public class EFCityRepositery : ICityRepositery
    {
        private TurboContext _context;
        public EFCityRepositery()
        {
            _context = new TurboContext();
        }
        public void AddData(City data)
        {
            _context.Entry(data).State=EntityState.Added;
            _context.SaveChanges();
        }

        public void DeleteData(int id)
        {
            throw new NotImplementedException();
        }

        public ObservableCollection<City> GetAll()
        {
            throw new NotImplementedException();
        }

        public City GetData(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateData(City data)
        {
            throw new NotImplementedException();
        }
    }
}
