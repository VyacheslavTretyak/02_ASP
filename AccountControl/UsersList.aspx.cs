using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AccountControl
{
	public partial class UsersList : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			LoadList();
			btnDelet.Enabled = false;
		}

		private void LoadList()
		{
			if (!IsPostBack)
			{
				foreach (User user in AccountCreation.users)
				{
					checkBoxList.Items.Add(string.Join(user.FirstName, " ", user.LastName));
				}
			}
			
		}

		protected void Delete_Click(object sender, EventArgs e)
		{
			btnDelet.ForeColor = Color.Red;
			Response.Redirect("AccountCreation.aspx");

		}

		protected void checkBoxList_SelectedIndexChanged(object sender, EventArgs e)
		{
			btnDelet.Enabled = checkBoxList.Items.OfType<ListItem>().Where(it => it.Selected).Count() == 0 ? false : true;

		}
	}
}