using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AccountControl
{
	public partial class AccountCreation : System.Web.UI.Page
	{
		public static List<Role> roles = null;
		public static List<User> users = null;
		public static int id = 1;
		protected void Page_Load(object sender, EventArgs e)
		{
			LoadRoles();
			LoadUsers();			
		}

		private void LoadUsers()
		{
			if (users == null)
			{
				users = new List<User>()
				{
					new User()
					{
						ID=id++,
						FirstName="Vyacheslav",
						LastName="Tretyak",
						Address="Kryvyi Rih",
						Email="tretyak1c@gmail.com",
						Password = "111",
						Role = roles[2],
					},
					new User()
					{
						ID=id++,
						FirstName="Chack",
						LastName="Norris",
						Address="Los Angeles",
						Email="bestofthebest@gmail.com",
						Password = "222",
						Role = roles[1],
					},
					new User()
					{
						ID=id++,
						FirstName="Kostya",
						LastName="Nonamed",
						Address="Kryvyi Rih",
						Email="kostya@gmail.com",
						Password = "333",
						Role = roles[0],
					},
				};
			}
		}

		private void LoadRoles()
		{
			if (roles == null)
			{
				roles = new List<Role>()
				{
					new Role("Guest"),
					new Role("Admin"),
					new Role("Programmer"),
				};
			}
			foreach (var role in roles)
			{
				cbRole.Items.Add(role.ToString());
			}
		}

		protected void btnAddUser_Click(object sender, EventArgs e)
		{			
			if (IsValid)
			{
				users.Add(new User()
				{
					ID = id++,
					FirstName = tbFirstName.Text,
					LastName = tbLastName.Text,
					Address = tbAddress.Text,
					Email = tbEmail.Text,
					Password = string.Join(string.Empty, MD5.Create().ComputeHash(Encoding.Unicode.GetBytes(tbPassword.Text)).Select(@byte => @byte.ToString("X2"))),
					Role = roles.OfType<Role>().First(role => role.Name == cbRole.SelectedItem.Text)
				});
				Response.Redirect("~/AccountCreation.aspx", false);
			}
			else
			{
				lbError.Text = "Error!Check inputs values.";
			}
		}
	}
}