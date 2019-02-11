using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace XamarinExplorer.Services
{
	public class MockDataStore<TClass> : Repository<TClass>
		where TClass : class
	{
		List<TClass> items;

		public MockDataStore()
		{
			items = new List<TClass>();
		}

		public override async Task<bool> AddAsync(TClass item)
		{
			items.Add(item);

			return await Task.FromResult(true);
		}

		public override async Task<IEnumerable<TClass>> GetAsync(bool forceRefresh = false)
		{
			await Task.Delay(2000);
			return await Task.FromResult(items);
		}
	}
}