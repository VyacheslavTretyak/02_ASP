<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EditAccount.aspx.cs" Inherits="AccountControl.EditAccount" %>

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

				<h1>Edit Account</h1>
				<div class="form col-lg-12">

					<div>
						<div class="fieldName">
							<asp:Label runat="server" Text="First Name"></asp:Label>
						</div>
						<asp:TextBox ID="tbFirstName" runat="server" />
						<asp:RequiredFieldValidator ID="rvFirstname" runat="server" ControlToValidate="tbFirstName" ErrorMessage="can not by empty"  Text="X" ForeColor="red"></asp:RequiredFieldValidator>
					</div>
					<div>
						<div class="fieldName">
							<asp:Label runat="server" Text="Last Name"></asp:Label>
						</div>
						<asp:TextBox ID="tbLastName" runat="server" />
						<asp:RequiredFieldValidator ID="rvLastName" runat="server" ControlToValidate="tbLastName" ErrorMessage="can not by empty" Text="X" ForeColor="red"></asp:RequiredFieldValidator>
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
						<asp:RequiredFieldValidator ID="rvEmail" runat="server" ControlToValidate="tbEmail" ErrorMessage="can not by empty" Text="X" ForeColor="red"></asp:RequiredFieldValidator>
						<asp:RegularExpressionValidator ID="rgvEmail" runat="server" ValidationExpression="^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?(?:\.[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?)*$"
							ControlToValidate="tbEmail" ErrorMessage="must be valid email"  Text="X" ForeColor="red"></asp:RegularExpressionValidator>
					</div>					
						<div class="fieldName">
							<asp:HyperLink NavigateUrl="navigateurl" runat="server" Text="Change password"/>	
						</div>
					<div>
						<div class="fieldName">
							<asp:Label runat="server" Text="Role"></asp:Label>
						</div>
						<asp:DropDownList ID="cbRole" runat="server"></asp:DropDownList>
					</div>
					<div class="error">
						<asp:Label ID="lbError" runat="server" Text=""></asp:Label>
					</div>
					<asp:ValidationSummary ID="ValidationSummary" runat="server" DisplayMode="BulletList" ForeColor="Red"/>

				</div>
			</div>
			<div class="row">
				<div class="footer col-lg-12">
					<asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click" CssClass="btn"/>		
					<asp:HyperLink ID="hyperLink" NavigateUrl="~/UsersList.aspx" runat="server" ForeColor="#66ffff">Back</asp:HyperLink>			
				</div>
			</div>
		</div>
	</form>
</body>
</html>
