﻿using Microsoft.EntityFrameworkCore;
using RentMyStuff.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RentMyStuff.Data.Interfaces
{
    public interface IDbContext
    {
        DbSet<AssetType> AssetTypes { get; set; }
        DbSet<Asset> Assets { get; set; }

        int SaveChanges();
        Task<int> SaveChangesAsync();
    }
}
