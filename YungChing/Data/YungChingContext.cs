using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using YungChing.Models;

namespace YungChing.Data
{
    public class YungChingContext : DbContext
    {
        public YungChingContext (DbContextOptions<YungChingContext> options)
            : base(options)
        {
        }

        public DbSet<YungChing.Models.Video> Video { get; set; } = default!;
    }
}
