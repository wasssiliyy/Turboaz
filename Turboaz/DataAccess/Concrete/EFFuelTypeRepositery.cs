using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Data.Entity.Core.Metadata.Edm;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using Turboaz.DataAccess.Abstraction;
using Turboaz.Domain.Entities;

namespace Turboaz.DataAccess.Concrete
{
    public class EFFuelTypeRepositery : IFuelRepositery
    {
        private TurboContext _context;
        public EFFuelTypeRepositery()
        {
            _context = new TurboContext();
            _context.SaveChanges();
        }
        public void AddData(FuelType data)
        {
            _context.Entry(data).State=EntityState.Modified;
            _context.SaveChanges();
        }

        public void DeleteData(int id)
        {
           _context.Entry(id).State=EntityState.Deleted;
            _context.SaveChanges();

        }

        public ObservableCollection<FuelType> GetAll()
        {
            var data = from b in _context.FuelType
                       select b;
            return new ObservableCollection<FuelType>(data);
        }

        public FuelType GetData(int id)
        {
            var data= _context.FuelType.FirstOrDefault(i=>i.Id==id);
            return data;
        }

        public void UpdateData(FuelType data)
        {
            _context.Entry(data).State= EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
