using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assessment.Model
{
    public class LocalGoverment
    {
        public int Id { get; set; }
        public string LGAName { get; set; }
        public int StateId { get; set; }
        public State State { get; set; }
    }
}
