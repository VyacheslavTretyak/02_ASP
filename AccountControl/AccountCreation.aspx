<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AccountCreation.aspx.cs" Inherits="AccountControl.AccountCreation" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
	<title>AccountControl</title>	
	<link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.1.1/css/bootstrap.min.css" integrity="sha384-WskhaSGFgHYWDcbwN70/dfYBj47jz9qbsMId/iRN3ewGhXQFZCSftd1LZCfmhktB" crossorigin="anonymous" />
	<link href="style.css" rel="stylesheet" />
</head>
<body>
	<form id="form" runat="server">
		<div class="container">
			<div class="row">

				<h1>Create Account</h1>
				<div class="form col-lg-12">

					<div>
						<div class="fieldName">
							<asp:Label runat="server" Text="First Name"></asp:Label>
						</div>
						<asp:TextBox ID="tbFirstName" runat="server" />
						<asp:RequiredFieldValidator ID="rvFirstname" runat="server" ControlToValidate="tbFirstName" ErrorMessage="*can not by empty" ForeColor="red"></asp:RequiredFieldValidator>
					</div>
					<div>
						<div class="fieldName">
							<asp:Label runat="server" Text="Last Name"></asp:Label>
						</div>
						<asp:TextBox ID="tbLastName" runat="server" />
						<asp:RequiredFieldValidator ID="rvLastName" runat="server" ControlToValidate="tbLastName" ErrorMessage="*can not by empty" ForeColor="red"></asp:RequiredFieldValidator>
					</div>
					<div>
						<div class="fieldName">
							<asp:Label runat="server" Text="Address"></asp:Label>
						</div>
						<asp:TextBox ID="tbAddress" runat="server" />
					</div>
					<div class="space"></div>
					<div>
						<div class="fieldName">
							<asp:Label runat="server" Text="Email"></asp:Label>
						</div>
						<asp:TextBox ID="tbEmail" runat="server" />
						<asp:RequiredFieldValidator ID="rvEmail" runat="server" ControlToValidate="tbEmail" ErrorMessage="*can not by empty" ForeColor="red"></asp:RequiredFieldValidator>
						<asp:RegularExpressionValidator ID="rgvEmail" runat="server" ValidationExpression="^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?(?:\.[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?)*$"
							ControlToValidate="tbEmail" ErrorMessage="*must be valid email" ForeColor="red"></asp:RegularExpressionValidator>
					</div>
					<div>
						<div class="fieldName">
							<asp:Label runat="server" Text="Password"></asp:Label>
						</div>
						<asp:TextBox ID="tbPassword" type="password" runat="server" />
						<asp:RequiredFieldValidator ID="rvPassword" runat="server" ControlToValidate="tbPassword" ErrorMessage="*can not by empty" ForeColor="red"></asp:RequiredFieldValidator>
					</div>
					<div>
						<div class="fieldName">
							<asp:Label runat="server" Text="Confirm Password"></asp:Label>
						</div>
						<asp:TextBox ID="tbConfirmPassword" type="password" runat="server" />
						<asp:RequiredFieldValidator ID="rvConfirmPassword" runat="server" ControlToValidate="tbConfirmPassword" ErrorMessage="*can not by empty" ForeColor="red"></asp:RequiredFieldValidator>
						<asp:CompareValidator ID="cvConfirm" runat="server" ControlToValidate="tbConfirmPassword" ControlToCompare="tbPassword" ErrorMessage="*passwords do not match" ForeColor="red"></asp:CompareValidator>
					</div>
					<div>
						<div class="fieldName">
							<asp:Label runat="server" Text="Role"></asp:Label>
						</div>
						<asp:DropDownList ID="ddlRole" runat="server"></asp:DropDownList>
					</div>

				</div>
			</div>
			<div class="row">
				<div class="footer col-lg-12">
					<asp:Button ID="btnAddUser" runat="server" Text="Add User" />		
					<asp:HyperLink ID="hyperLink" NavigateUrl="~/UsersList.aspx" runat="server" ForeColor="#66ffff">Users List</asp:HyperLink>			
				</div>
			</div>
		</div>
	</form>
</body>
</html>
