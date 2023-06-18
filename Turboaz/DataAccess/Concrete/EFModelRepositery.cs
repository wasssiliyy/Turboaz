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
            throw new NotImplementedException();
        }

        public ObservableCollection<Model> GetAll()
        {
            throw new NotImplementedException();
        }

        public Model GetData(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateData(Model data)
        {
            throw new NotImplementedException();
        }
    }
}
