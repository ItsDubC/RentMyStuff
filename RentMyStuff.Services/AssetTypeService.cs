using Microsoft.EntityFrameworkCore;
using RentMyStuff.Core.Models;
using RentMyStuff.Data.Interfaces;
using RentMyStuff.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentMyStuff.Services
{
	public class AssetTypeService : IService<AssetType>
	{
		private IDbContext _context;

		public AssetTypeService(IDbContext context)
		{
			_context = context;
		}

		public AssetType Add(AssetType entity)
		{
			throw new NotImplementedException();
		}

		public Task<AssetType> AddAsync(AssetType entity)
		{
			throw new NotImplementedException();
		}

		public void Delete(AssetType entity)
		{
			throw new NotImplementedException();
		}

		public Task DeleteAsync(AssetType entity)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<AssetType> GetAll()
		{
			return _context.AssetTypes.ToList();
		}

		public async Task<IEnumerable<AssetType>> GetAllAsync()
		{
			return await _context.AssetTypes.ToListAsync();
		}

		public AssetType GetById(int id)
		{
			return _context.AssetTypes.SingleOrDefault(x => x.Id == id);
		}

		public async Task<AssetType> GetByIdAsync(int id)
		{
			return await _context.AssetTypes.SingleOrDefaultAsync(x => x.Id == id);
		}

		public AssetType Update(AssetType entity)
		{
			throw new NotImplementedException();
		}

		public Task<AssetType> UpdateAsync(AssetType entity)
		{
			throw new NotImplementedException();
		}
	}
}
