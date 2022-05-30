using System;
using System.Security.Claims;
using System.ServiceModel;
using Microsoft.Extensions.Options;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Extensions.Logging;
using Shop.Infrastructure.Configuration;
using JWT.Infrastructure.Context;
using JWT.Domain.Models;
using JWT.Infrastructure.Repositories;

namespace JWT.Infrastructure.UoW
{
	/// <summary>
	/// Реализация UnitOfWork
	/// </summary>
	public class UnitOfWork
	{
		public UnitOfWork(IOptions<Settings> settings)
		{
			_settings = settings.Value;
			var options = new DbContextOptionsBuilder<UserContext>().UseSqlServer(_settings.ContextConnectionString).Options;
			_jwtContext = new UserContext(options);
		}

		public UnitOfWork(IOptions<Settings> settings, UserContext jWTContext)
		{
			_settings = settings.Value;
			_jwtContext = jWTContext;
		}

		private UserContext _jwtContext;

		private Settings _settings;

        private ItemRepository _itemRepository;
        public ItemRepository Items => _itemRepository ??= new ItemRepository(_jwtContext);

		public void MigrateContext()
		{
			_jwtContext.Database.Migrate();
		}

		private bool _disposed;

		public virtual void Dispose(bool disposing)
		{
			if (!_disposed)
			{
				if (disposing)
				{
					if (_jwtContext != null)
						_jwtContext.Dispose();

					
				}
				_disposed = true;
			}
		}

		public void Dispose()
		{
			Dispose(true);
			GC.SuppressFinalize(this);
		}
	}
}
