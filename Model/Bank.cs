using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assessment.Model
{
    public class Bank
    {
        public string BankName { get; set; }
        public string BankCode { get; set; }
        public string ErrorMessage { get; set; }
        public string HassError { get; set; }
        public string TimeGenerated { get; set; }
    }
}
