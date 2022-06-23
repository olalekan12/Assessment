using Assessment.DbContext;
using Assessment.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assessment.Services
{
    public class Lookup : ILookup
    {
        private readonly AppDbContext _context;
        public Lookup(AppDbContext dbContext)
        {
            _context = dbContext;
        }
        public LocalGoverment GetStateWithLGA(string lga)
        {
            var states = _context.LocalGoverments.Include(x => x.State).FirstOrDefault(x => x.LGAName.Trim().ToLower() == lga.Trim().ToLower());
            return states;


        }
    }
}
