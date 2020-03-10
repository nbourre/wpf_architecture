using System.Collections.Generic;

namespace GameManagement.Models
{
    interface IDataService<T>
    {
        public IEnumerable<T> GetAll();
    }
}
