using Microsoft.EntityFrameworkCore;
using saleswebmvccore.Data;
using saleswebmvccore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace saleswebmvccore.Services
{
    public class DepartmentService
    {
        private readonly saleswebmvccoreContext _context;

        public DepartmentService(saleswebmvccoreContext context)
        {
            _context = context;
        }

        public async Task<List<Department>> FindAllAsync()
        {
            return await _context.Department.OrderBy(x => x.Name).ToListAsync();
        }
    }
}
