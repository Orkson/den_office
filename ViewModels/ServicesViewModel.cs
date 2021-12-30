using den_office.Data;
using den_office.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace den_office.ViewModels
{
    public class ServicesViewModel
    {
        private static ApplicationDbContext _context;

        public ServicesViewModel(ApplicationDbContext context)
        {
            _context = context;

        }
    }
}
