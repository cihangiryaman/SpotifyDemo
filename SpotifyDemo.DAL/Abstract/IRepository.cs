﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyDemo.DAL.Abstract
{
	public interface IRepository<T> where T : class, IEntity<T>, new()
	{
		Task<T> GetByIdAsync(int id);
		Task<List<T>> GetAllAsync();
		Task<List<T>> FindAsync(Expression<Func<T, bool>> predicate);
		Task AddAsync(T entity);
		void Update(T entity);
		void Remove(T entity);
		Task<int> SaveChangesAsync();
	}
}
