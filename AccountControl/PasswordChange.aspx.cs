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
	public partial class PasswordChange : System.Web.UI.Page
	{
		private AccountRepository accountRepository = AccountRepository.Instance;
		protected void Page_Load(object sender, EventArgs e)
		{

		}
		protected void btnSave_Click(object sender, EventArgs e)
		{
			if (IsValid)
			{
				User user = accountRepository.Get(EditAccount.id);
				string pass = string.Join(string.Empty, MD5.Create().ComputeHash(Encoding.Unicode.GetBytes(tbOldPassword.Text)).Select(@byte => @byte.ToString("X2")));
				if(pass != user.Password)
				{
					lbError.Text = "Password wrong!";
					return;
				}
				user.Password = string.Join(string.Empty, MD5.Create().ComputeHash(Encoding.Unicode.GetBytes(tbPassword.Text)).Select(@byte => @byte.ToString("X2")));
				Response.Redirect("~/UsersList.aspx", false);
			}
			else
			{
				lbError.Text = "Error! Check inputs values.";
			}
		}
	}
}