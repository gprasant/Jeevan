using System.Data.Entity;
using Jeevan.Models;

namespace Jeevan.Database
{
    public class DBContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // our G
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, add the following
        // code to the Application_Start method in ylobal.asax file.
        // Note: this will destroy and re-create your database with every model change.
        // 
        // System.Data.Entity.Database.SetInitializer(new System.Data.Entity.DropCreateDatabaseIfModelChanges<Jeevan.Models.DBContext>());

        public DbSet<CordBloodUnit> CordBloodUnits { get; set; }
    }
}
