using Assessment.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assessment.IServices
{
    public interface ICustomerService
    {
       Task<Customer> AddCustomer(CustomerReg payload);
        Task<IEnumerable<Customer>> GetCustomers();
    }
}
