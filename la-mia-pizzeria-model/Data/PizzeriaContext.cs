using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using la_mia_pizzeria_static.Models;

public class PizzeriaContext : DbContext
{
    public PizzeriaContext(DbContextOptions<PizzeriaContext> options)
        : base(options)
    {
    }

    public DbSet<la_mia_pizzeria_static.Models.Pizza> Pizza { get; set; } = default!;
}
