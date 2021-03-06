﻿using System;
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
		RoleRepository roleRepository = RoleRepository.Instance;
		AccountRepository accountRepository = AccountRepository.Instance;
		protected void Page_Load(object sender, EventArgs e)
		{
			LoadList();
			btnDelet.Enabled = false;
		}

		private void LoadList()
		{
			if (!IsPostBack)
			{
				foreach (User user in accountRepository.GetAll())
				{
					ListItem item = new ListItem($"{user.FirstName} {user.LastName} <a href='EditAccount.aspx?id={user.ID}'>EDIT</a>?");					
					item.Value = user.ID.ToString();
					checkBoxList.Items.Add(item);
				}
			}
			
		}

		protected void Delete_Click(object sender, EventArgs e)
		{
			List<ListItem> toBeRemove = new List<ListItem>();
			for (int i = 0; i < checkBoxList.Items.Count; i++)
			{				
				if (checkBoxList.Items[i].Selected)
				{
					toBeRemove.Add(checkBoxList.Items[i]);
				}
			}
			for (int i = 0; i < toBeRemove.Count; i++)
			{
				ListItem item = toBeRemove[i];
				accountRepository.Delete(int.Parse(item.Value));			
				checkBoxList.Items.Remove(item);
			}
		}

		protected void checkBoxList_SelectedIndexChanged(object sender, EventArgs e)
		{
			btnDelet.Enabled = checkBoxList.Items.OfType<ListItem>().Where(it => it.Selected).Count() == 0 ? false : true;

		}

		protected void btnAddUser_Click(object sender, EventArgs e)
		{
			Response.Redirect("AccountCreation.aspx");
		}
	}
}