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
            _context.Entry(id).State = EntityState.Deleted;
        }

        public ObservableCollection<CarsColor> GetAll()
        {
            var data=from carColor in _context.Colors
                     select carColor;
            return new ObservableCollection<CarsColor>(data);
        }

        public CarsColor GetData(int id)
        {
            var data=_context.Colors.FirstOrDefault(c => c.Id == id);
            return data;
        }

        public void UpdateData(CarsColor data)
        {
            _context.Entry(data).State= EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
