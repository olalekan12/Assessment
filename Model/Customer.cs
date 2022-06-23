using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assessment.Model
{
    public class Customer
    {
        public int Id { get; set; }
        public string PhoneNo { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public State State { get; set; }
        public LocalGoverment LGA { get; set; }
        public bool OTPVerified { get; set; } = false;
    }

    public class CustomerReg
    {        
        public string PhoneNo { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string State { get; set; }
        public string LGA { get; set; }        
    }
}
