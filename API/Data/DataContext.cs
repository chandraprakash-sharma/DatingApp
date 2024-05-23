using System;
using Microsoft.EntityFrameworkCore;

namespace API.Data;
//derived from DbContext Class
public class DataContext : DbContext
{
    public DataContext(DbContextOptions options) : base(options)
    {
    }
    public DbSet<AppUser> Users { get; set; } //entity name is same as table name in databse
}
