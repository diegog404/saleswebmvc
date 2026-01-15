using saleswebmvccore.Data;
using saleswebmvccore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace saleswebmvccore.Services
{
    public class SellerService
    {
        private readonly saleswebmvccoreContext _context;

        public SellerService(saleswebmvccoreContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }
    }
}
