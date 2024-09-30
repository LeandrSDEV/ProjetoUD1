using Microsoft.EntityFrameworkCore;
using ProjetoUd1.Models;

namespace ProjetoUd1.Data
{
    public class BancoContext : DbContext
    {
        public BancoContext (DbContextOptions<BancoContext> options)
            : base(options)
        {
        }

        public DbSet<DepartmentModel> Departments { get; set; }
        public DbSet<SellerModel> Seller { get; set; }
        public DbSet<SalesRecordModel> SalesRecord { get; set; }
    }
}
