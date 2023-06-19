using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Turboaz.DataAccess.Concrete;

namespace Turboaz.DataAccess.Abstraction
{
    public interface IUnitOfWork
    {
        IBrandRepositery IBrandRepositery { get; }
        ICarRepositery ICarRepositery { get; }
        ICarsColorRepositery ICarsColorRepositery { get; }
        ICityRepositery ICityRepositery { get; }
        IFuelRepositery IFuelTypeRepositery { get; }
        IModelRepositery IModelRepositery { get; }
        
        
    }
}
