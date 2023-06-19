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
    public class EFModelRepositery : IModelRepositery
    {
        private TurboContext _context;
        public void AddData(Model data)
        {
            _context.Entry(data).State = EntityState.Added;
            _context.SaveChanges();
        }

        public void DeleteData(int id)
        {
            _context.Entry(id).State = EntityState.Deleted;
            _context.SaveChanges();
        }

        public ObservableCollection<Model> GetAll()
        {
            var data= from m in _context.Models
                      select m;
            return new ObservableCollection<Model> (data);
        }

        public Model GetData(int id)
        {
            var data = _context.Models.FirstOrDefault(x => x.Id == id);
            return data;
        }

        public void UpdateData(Model data)
        {
            _context.Entry(data).State= EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
