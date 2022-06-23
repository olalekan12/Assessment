using Assessment.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assessment.IServices
{
    public interface IBankService
    {
        Task<Bank> GetBank();
    }
}
