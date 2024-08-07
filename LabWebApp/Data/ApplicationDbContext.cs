namespace LabWebApp.Data;
using Microsoft.EntityFrameworkCore;
using LabWebApp.Models;
using System.Collections.Generic;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
    : base(options)
    {
    }

    public DbSet<Product> Products { get; set; }
}

