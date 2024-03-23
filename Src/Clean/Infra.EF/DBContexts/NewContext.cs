using Domain.Entites.Cities;
using Domain.Entites.Persons;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection.Emit;
using System.Runtime.ConstrainedExecution;


namespace Infra.EF;

public class NewContext : DbContext
{
    public NewContext(DbContextOptions options) : base(options)
    {
    }

      protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

      



    }
    public DbSet<Person> Persons { get; set; }
    public DbSet<City> Citys { get; set; }

}

