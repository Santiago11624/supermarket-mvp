using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp.Models
{
    internal interface ICustomersRepository
    {
        void Add(CustomersModel customer);
        void Edit(CustomersModel customer);
        void Delete(int id);
        IEnumerable<CustomersModel> GetAll();
        IEnumerable<CustomersModel> GetByValue(string value); // name o id
        CustomersModel GetById(int id);
    }
}
