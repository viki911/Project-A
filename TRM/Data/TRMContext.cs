using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TRM.Models;


    public class TRMContext : IdentityDbContext
    {
        public TRMContext(DbContextOptions<TRMContext> options)
            : base(options)
        {
        }
   

    public DbSet<TRM.Models.Allocate> Allocate { get; set; } = default!;
        public DbSet<TRM.Models.Employee> Employee { get; set; } = default!;

        public DbSet<TRM.Models.RouteStop> RouteStop { get; set; } = default!;

        public DbSet<TRM.Models.Vehicle> Vehicle { get; set; } = default!;
    }
