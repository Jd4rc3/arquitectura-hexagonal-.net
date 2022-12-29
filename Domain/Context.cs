using Domain.models;
using Microsoft.EntityFrameworkCore;

namespace Domain;

public class Context : DbContext
{
    public Context(DbContextOptions<Context> options) : base(options)
    {
    }

    public DbSet<Category> Categories { get; set; }
}