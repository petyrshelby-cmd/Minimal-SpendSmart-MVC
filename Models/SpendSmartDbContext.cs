using Microsoft.EntityFrameworkCore;

namespace SpendSmart_NET8_Minimalist.Models
{
    public class SpendSmartDbContext : DbContext
    {
        public DbSet<Expense> Expenses { get; set; }

        public SpendSmartDbContext(DbContextOptions<SpendSmartDbContext> options)
            : base(options)
        {
        }
    }
}