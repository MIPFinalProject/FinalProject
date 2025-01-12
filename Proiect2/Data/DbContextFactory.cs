using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect2.Data
{
    public static class DbContextFactory
    {
        public static AppDbContext CreateDbContext()
        {
            return new AppDbContext();
        }
    }
}
