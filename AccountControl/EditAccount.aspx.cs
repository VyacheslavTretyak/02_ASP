using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AccountControl
{
	public partial class EditAccount : System.Web.UI.Page
	{
		public static int id = 0;
		RoleRepository roleRepository = RoleRepository.Instance;
		AccountRepository accountRepository = AccountRepository.Instance;
		private User user;
		protected void Page_Load(object sender, EventArgs e)
		{			
			LoadRoles();
			LoadData();
		}

		private void LoadData()
		{
			try
			{
				id = int.Parse(Request["id"]);				
				user = accountRepository.Get(id);
				if (!IsPostBack)
				{	
					tbFirstName.Text = user.FirstName;
					tbLastName.Text = user.LastName;
					tbAddress.Text = user.Address;
					tbEmail.Text = user.Email;
					cbRole.SelectedValue = user.Role.Name;
				}
			}
			catch (Exception)
			{
				lbError.Text = "Error parametr format.";
			}

		}

		private void LoadRoles()
		{
			foreach (Role role in roleRepository.GetAll())
			{
				cbRole.Items.Add(role.Name);
			}
		}

		protected void btnSave_Click(object sender, EventArgs e)
		{
			if (IsValid)
			{
				user.FirstName = tbFirstName.Text;				
				user.LastName = tbLastName.Text;
				user.Address = tbAddress.Text;
				user.Email = tbEmail.Text;
				user.Role = roleRepository.Get(cbRole.SelectedValue);
				Response.Redirect("~/UsersList.aspx", false);
			}
			else
			{
				lbError.Text = "Error! Check inputs values.";
			}
		}
	}
}