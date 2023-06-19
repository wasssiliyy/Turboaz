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
            _context.Entry(id).State=EntityState.Deleted;
            _context.SaveChanges();
        }

        public ObservableCollection<City> GetAll()
        {
            var data=from c in _context.Cities
                     select c;
            return new ObservableCollection<City>(data);
        }

        public City GetData(int id)
        {
           var data= _context.Cities.FirstOrDefault(c => c.Id==id);
            return data;
        }

        public void UpdateData(City data)
        {
            _context.Entry(data).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
