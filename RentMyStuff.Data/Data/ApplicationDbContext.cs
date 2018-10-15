using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RentMyStuff.Core.Models;
using RentMyStuff.Data.Interfaces;

namespace RentMyStuff.Data
{
    public class ApplicationDbContext : IdentityDbContext, IDbContext
    {
        public DbSet<AssetType> AssetTypes { get; set; }
        public DbSet<Asset> Assets { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
