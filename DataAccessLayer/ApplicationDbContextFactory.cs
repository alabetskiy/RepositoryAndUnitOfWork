using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace DataAccessLayer
{
    public class ApplicationDbContextFactory : IDesignTimeDbContextFactory<DataContext>
    {
        public DataContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<DataContext>();
            builder.UseSqlServer("Server=ARTEMLABETS5772;Database=RepoPatternDemo;Trusted_Connection=True;",
                optionsBuilder => optionsBuilder.MigrationsAssembly(typeof(DataContext).GetTypeInfo().Assembly.GetName().Name));

            return new DataContext(builder.Options);
        }
    }
}
