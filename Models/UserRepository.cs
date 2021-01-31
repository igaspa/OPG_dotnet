using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPG.Models
{
    public class UserRepository : IUserRepository
    {
		private readonly AppDbContext _appDbContext;

		private User DbContext
			{
				get
				{
					var dbContext = _appDbContext.Get<User>();

					if (dbContext == null)
						throw new InvalidOperationException("Not found. This means that this repository method has been called outside of the scope of a DbContextScope. A repository must only be accessed within the scope of a DbContextScope, which takes care of creating the DbContext instances that the repositories need and making them available as ambient contexts. This is what ensures that, for any given DbContext-derived type, the same instance is used throughout the duration of a business transaction. To fix this issue, use IDbContextScopeFactory in your top-level business logic service method to create a DbContextScope that wraps the entire business transaction that your service method implements. Then access this repository within that scope. Refer to the comments in the IDbContextScope.cs file for more details.");
					else
					return dbContext;
				}
			}

			public UserRepository(AppDbContext appDbContext)
			{
				if (_appDbContext == null) throw new ArgumentNullException("_appDbContext");
				_appDbContext = appDbContext;
			}

			public User Get(Guid UserId)
			{
				return DbContext.User.Find(UserId);
			}

			public Task<User> GetAsync(Guid userId)
			{
				return DbContext.User.FindAsync(userId);
			}

			public void Add(User user)
			{
				DbContext.User.Add(user);
			}

        public void SearchProduct(int ProductId)
        {
			result = (from r in _appDbContext.Product where r.ProductId == product_id select r).FirstOrDefault();
			return (Product)result;
		}

        public void Login()
        {
            throw new NotImplementedException();
        }

        public void Rate()
        {
            throw new NotImplementedException();
        }
    }
	}

