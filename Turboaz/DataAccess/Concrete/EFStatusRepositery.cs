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
    public class EFStatusRepositery : IStatusRepositery
    {
        private TurboContext _context;
        public EFStatusRepositery()
        {
            _context = new TurboContext();
        }
        public void AddData(Status data)
        {
            _context.Entry(data).State = EntityState.Added;
            _context.SaveChanges();
        }

        public void DeleteData(int id)
        {
            throw new NotImplementedException();
        }

        public ObservableCollection<Status> GetAll()
        {
            throw new NotImplementedException();
        }

        public Status GetData(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateData(Status data)
        {
            throw new NotImplementedException();
        }
    }
}
