using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HW04.Models;

namespace HW04.Data
{
    public class HW04Context : DbContext
    {
        public HW04Context (DbContextOptions<HW04Context> options)
            : base(options)
        {
        }

        public DbSet<HW04.Models.Product> Product { get; set; } = default!;
    }
}
