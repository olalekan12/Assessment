using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assessment.Model
{
    public class State
    {
        public int Id { get; set; }
        public string StateName { get; set; }
        public List<LocalGoverment> LGA { get; set; }
    }
}
