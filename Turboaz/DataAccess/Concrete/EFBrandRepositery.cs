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
            _context.Entry(id).State = EntityState.Deleted;
            _context.SaveChanges();
        }

        public ObservableCollection<Brand> GetAll()
        {
            var data = from b in _context.Brands
                       select b;
            return new ObservableCollection<Brand>(data);
        }

        public Brand GetData(int id)
        {
            var data= _context.Brands.FirstOrDefault(b => b.Id == id);
            return data;
        }

        public void UpdateData(Brand data)
        {
            _context.Entry(data).State=EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
