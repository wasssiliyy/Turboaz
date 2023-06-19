using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Turboaz.DataAccess.Abstraction;

namespace Turboaz.DataAccess.Concrete
{
    internal class EFUnitOfWork : IUnitOfWork
    {
        public IBrandRepositery IBrandRepositery => new EFBrandRepositery();

        public ICarRepositery ICarRepositery => new EFCarRepositery();

        public ICarsColorRepositery ICarsColorRepositery => new EFCarsColorRepositery();

        public ICityRepositery ICityRepositery => new EFCityRepositery();

        public IFuelRepositery IFuelTypeRepositery => new EFFuelTypeRepositery();

        public IModelRepositery IModelRepositery => new EFModelRepositery();

        public IStatusRepositery IStatusRepositery => new EFStatusRepositery();
    }
}
