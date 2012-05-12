using System.Data.Entity;
using Jeevan.Models;

namespace Jeevan.Database
{
    public class JeevanDBContext : DbContext
    {
        public DbSet<CordBloodUnit> CordBloodUnits { get; set; }
    }
}
