using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turboaz.DataAccess.Abstraction
{
    public interface IRepositery<T>
    {
        T GetData(int id);
        ObservableCollection<T> GetAll();
        void AddData(T data);
        void UpdateData(T data);
        void DeleteData(int id);

    }
}
