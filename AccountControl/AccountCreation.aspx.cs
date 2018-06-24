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
		RoleRepository roleRepository = RoleRepository.Instance;
		AccountRepository accountRepository = AccountRepository.Instance;
		protected void Page_Load(object sender, EventArgs e)
		{
			LoadRoles();
			LoadUsers();			
		}
		private void LoadRoles()
		{
			if (!roleRepository.IsInit)
			{				
				roleRepository.Create(new Role("Guest"));
				roleRepository.Create(new Role("Admin"));
				roleRepository.Create(new Role("Programmer"));
				roleRepository.IsInit = true;
			}
			foreach (Role role in roleRepository.GetAll())
			{
				cbRole.Items.Add(role.Name);
			}
		}
			


		private void LoadUsers()
		{
			if(accountRepository.IsInit)
			{
				return;				
			}			
			accountRepository.Create(new User()
			{
				FirstName = "Vyacheslav",
				LastName = "Tretyak",
				Address = "Kryvyi Rih",
				Email = "tretyak1c@gmail.com",
				Password = "111",
				Role = roleRepository.Get("Programmer")
			});
			accountRepository.Create(new User()
			{
				FirstName = "Chack",
				LastName = "Norris",
				Address = "Los Angeles",
				Email = "bestofthebest@gmail.com",
				Password = "222",
				Role = roleRepository.Get("Admin")
			});
			accountRepository.Create(new User()
			{
				FirstName = "Kostya",
				LastName = "Nonamed",
				Address = "Kryvyi Rih",
				Email = "kostya@gmail.com",
				Password = "333",
				Role = roleRepository.Get("Guest")
			});
			accountRepository.IsInit = true;
		}

		

		protected void btnAddUser_Click(object sender, EventArgs e)
		{			
			if (IsValid)
			{
				accountRepository.Create(new User()
				{
					FirstName = tbFirstName.Text,
					LastName = tbLastName.Text,
					Address = tbAddress.Text,
					Email = tbEmail.Text,
					Password = string.Join(string.Empty, MD5.Create().ComputeHash(Encoding.Unicode.GetBytes(tbPassword.Text)).Select(@byte => @byte.ToString("X2"))),
					Role = roleRepository.GetAll().OfType<Role>().First(role => role.Name == cbRole.SelectedItem.Text)
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