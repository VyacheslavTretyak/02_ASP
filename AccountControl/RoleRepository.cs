using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AccountControl
{
	public class RoleRepository : IRepository<Role, string>
	{
		private static RoleRepository instance = null;
		public static RoleRepository Instance => instance ?? (instance = new RoleRepository());

		private List<Role> list = new List<Role>();
		private RoleRepository() { }

		public void Create(Role item) => list?.Add(item);
		

		public bool Delete(string name) => list?.Remove(Get(name)) ?? false;

		public Role Get(string name) => list?.Find(user => user.Name == name);

		public IEnumerable<Role> GetAll() => list;

		public void Update(Role item)
		{
			
		}

		public bool IsInit { get; set; } = false;
	}
}