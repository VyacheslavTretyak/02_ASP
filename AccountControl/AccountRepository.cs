using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AccountControl
{
	public class AccountRepository : IRepository<User, int>
	{
		private static AccountRepository instance = null;
		public static AccountRepository Instance => instance ?? (instance = new AccountRepository());

		private List<User> list = new List<User>();
		private AccountRepository() {}

		public void Create(User item){
			item.ID = (list.LastOrDefault()?.ID ?? 0) + 1;
			list?.Add(item);
		}

		public bool Delete(int id) => list?.Remove(Get(id)) ?? false;

		public User Get(int id) => list?.Find(user => user.ID == id);

		public IEnumerable<User> GetAll() => list;

		public void Update(User item)
		{
			throw new NotImplementedException();
		}

		public bool IsInit { get; set; } = false;
	}
}