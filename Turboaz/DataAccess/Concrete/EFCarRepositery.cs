using System;
using System.CodeDom;
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
    public class EFCarRepositery : ICarRepositery
    {
        private TurboContext _context;
        public EFCarRepositery()
        {
            _context = new TurboContext();
        }
        public void AddData(Car data)
        {
            _context.Entry(data).State = EntityState.Added;
            _context.SaveChanges();
        }

        public void DeleteData(int id)
        {
            _context.Entry(id).State = EntityState.Deleted;
            _context.SaveChanges();
        }

        public ObservableCollection<Car> GetAll()
        {
            var data=from c in _context.Cars
                     select c;
            return new ObservableCollection<Car>(data);
        }

        public Car GetData(int id)
        {
            var result=_context.Cars.FirstOrDefault(c => c.Id == id);
            return result;
        }

        public void UpdateData(Car data)
        {
           _context.Entry(data).State=EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
