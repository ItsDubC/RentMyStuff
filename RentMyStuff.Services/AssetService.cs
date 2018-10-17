using RentMyStuff.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using RentMyStuff.Core.Models;
using RentMyStuff.Data.Interfaces;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace RentMyStuff.Services
{
    public class AssetService : IService<Asset>
    {
        private IDbContext _context;

        public AssetService(IDbContext context)
        {
            _context = context;
        }

        public Asset Add(Asset entity)
        {
            _context.Assets.Add(entity);
            _context.SaveChanges();
            return entity;
        }

        public async Task<Asset> AddAsync(Asset entity)
        {
            _context.Assets.Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public void Delete(Asset entity)
        {
            _context.Assets.Remove(entity);
            _context.SaveChanges();
        }

        public Task DeleteAsync(Asset entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Asset> GetAll()
        {
            return _context.Assets.Include(x => x.AssetType).ToList();
        }

        public async Task<IEnumerable<Asset>> GetAllAsync()
        {
            return await _context.Assets.ToListAsync();
        }

        public Asset GetById(int id)
        {
            return _context.Assets.SingleOrDefault(x => x.Id == id);
        }

        public async Task<Asset> GetByIdAsync(int id)
        {
            return await _context.Assets.SingleOrDefaultAsync(x => x.Id == id);
        }

        public Asset Update(Asset entity)
        {
            _context.Assets.Update(entity);
            _context.SaveChanges();
            return entity;
        }

        public async Task<Asset> UpdateAsync(Asset entity)
        {
            _context.Assets.Update(entity);
            await _context.SaveChangesAsync();
            return entity;
        }
    }
}
