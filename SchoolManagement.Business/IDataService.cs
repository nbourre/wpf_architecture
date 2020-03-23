using System.Collections.Generic;

namespace SchoolManagement.Business
{
    interface IDataService<T>
    {
        public IEnumerable<T> GetAll();
    }
}
