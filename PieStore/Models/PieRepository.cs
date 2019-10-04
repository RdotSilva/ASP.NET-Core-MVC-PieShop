using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PieStore.Models
{
    public class PieRepository : IPieRepository
    {
        private readonly AppDbContext _appDbContext;

        public PieRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

    }
}
