﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace XamarinExplorer.Services
{
	public interface IRepository<T>
		where T : class
	{
		void Add(T item);

		Task<bool> AddAsync(T item);
		Task<bool> UpdateAsync(object id, T item);
		Task<bool> DeleteAsync(object id);
		Task<T> GetAsync(string id);
		Task<IEnumerable<T>> GetAsync(bool forceRefresh = false);
	}
}
