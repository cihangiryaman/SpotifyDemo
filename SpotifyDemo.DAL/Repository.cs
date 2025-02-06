﻿using Microsoft.EntityFrameworkCore;
using SpotifyDemo.DAL.Abstract;
using SpotifyDemo.DAL.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyDemo.DAL
{
	public class Repository<T> : IRepository<T> where T : class, IEntity<T>, new()
	{
		protected readonly SpotifyDemoContext _context;
		protected readonly DbSet<T> _dbSet;

		public Repository(SpotifyDemoContext context)
		{
			_context = context;
			_dbSet = context.Set<T>();
		}

		public async Task<T> GetByIdAsync(int id) => await _dbSet.FindAsync(id);

		public async Task<List<T>> GetAllAsync() => await _dbSet.ToListAsync();

		public async Task<List<T>> FindAsync(Expression<Func<T, bool>> predicate) => await _dbSet.Where(predicate).ToListAsync();

		public async Task AddAsync(T entity) => await _dbSet.AddAsync(entity);

		public void Update(T entity) => _dbSet.Update(entity);

		public void Remove(T entity) => _dbSet.Remove(entity);

		public async Task<int> SaveChangesAsync() => await _context.SaveChangesAsync();
	}
}
