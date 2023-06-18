using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Turboaz.DataAccess.Abstraction;
using Turboaz.Entities;

namespace Turboaz.DataAccess.Concrete
{
    public class EFBrandRepositery : IBrandRepositery
    {
        private TurboContext _context;
        public EFBrandRepositery()
        {
            _context = new TurboContext();
        }
        public void AddData(Brand data)
        {
            _context.Entry(data).State = EntityState.Added;
            _context.SaveChanges();
        }

        public void DeleteData(int id)
        {
            throw new NotImplementedException();
        }

        public ObservableCollection<Brand> GetAll()
        {
            throw new NotImplementedException();
        }

        public Brand GetData(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateData(Brand data)
        {
            throw new NotImplementedException();
        }
    }
}
