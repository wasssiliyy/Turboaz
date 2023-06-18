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
    public class EFCarsColorRepositery : ICarsColorRepositery
    {
        private TurboContext _context;
        public EFCarsColorRepositery()
        {
            _context = new TurboContext();
            _context.SaveChanges();
        }
        public void AddData(CarsColor data)
        {
            _context.Entry(data).State = EntityState.Added;
            _context.SaveChanges();
        }

        public void DeleteData(int id)
        {
            throw new NotImplementedException();
        }

        public ObservableCollection<CarsColor> GetAll()
        {
            throw new NotImplementedException();
        }

        public CarsColor GetData(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateData(CarsColor data)
        {
            throw new NotImplementedException();
        }
    }
}
