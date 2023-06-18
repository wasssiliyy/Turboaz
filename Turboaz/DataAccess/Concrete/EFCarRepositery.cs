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
        }

        public void DeleteData(int id)
        {
            throw new NotImplementedException();
        }

        public ObservableCollection<Car> GetAll()
        {
            throw new NotImplementedException();
        }

        public Car GetData(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateData(Car data)
        {
            throw new NotImplementedException();
        }
    }
}
