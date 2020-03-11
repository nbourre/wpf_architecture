using System.Collections.Generic;

namespace SchoolManagement.Models
{
    interface IDataService<T>
    {
        public IEnumerable<T> GetAll();
    }
}
