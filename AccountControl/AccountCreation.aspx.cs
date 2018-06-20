using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AccountControl
{
	public partial class AccountCreation : System.Web.UI.Page
	{
		public static List<Role> roles;
		public static List<User> users;
		protected void Page_Load(object sender, EventArgs e)
		{
			LoadRoles();
			LoadUsers();
		}

		private void LoadUsers()
		{
			users = new List<User>()
			{
				new User()
				{
					ID=1,
					FirstName="Vyacheslav",
					LastName="Tretyak",
					Address="Kryvyi Rih",
					Email="tretyak1c@gmail.com",
					Password = "111",
					Role = roles[2],
				},
			};
		}

		private void LoadRoles()
		{
			roles = new List<Role>()
			{
				new Role("Guest"),
				new Role("Admin"),
				new Role("Programmer"),
			};
			foreach (var role in roles)
			{
				ddlRole.Items.Add(role.ToString());
			}
		}
	}
}