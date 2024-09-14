using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.EntityFrameworkCore;

namespace DataBaseFirst
{
    public class AplicationDbContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder options) =>
            options.UseSqlServer("Server=HASNAA-ABDELRAH;Database=HealthApp;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=true");

    }
}
