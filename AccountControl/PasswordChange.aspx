<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PasswordChange.aspx.cs" Inherits="AccountControl.PasswordChange" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Account Control</title>
	<link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.1.1/css/bootstrap.min.css" integrity="sha384-WskhaSGFgHYWDcbwN70/dfYBj47jz9qbsMId/iRN3ewGhXQFZCSftd1LZCfmhktB" crossorigin="anonymous" />
	<link href="style.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
         <div class="container">
			<div class="row">
				<h1>Password Change</h1>
				<div class="form col-lg-12">
					<div>
						<div class="fieldName">
							<asp:Label runat="server" Text="Password"></asp:Label>
						</div>
						<asp:TextBox ID="tbOldPassword" type="password" runat="server" />
						<asp:RequiredFieldValidator ID="rvOldPassword" runat="server" ControlToValidate="tbOldPassword" ErrorMessage="can not by empty" Text="X" ForeColor="red"></asp:RequiredFieldValidator>
					</div>
					<div>
						<div class="fieldName">
							<asp:Label runat="server" Text="Password"></asp:Label>
						</div>
						<asp:TextBox ID="tbPassword" type="password" runat="server" />
						<asp:RequiredFieldValidator ID="rvPassword" runat="server" ControlToValidate="tbPassword" ErrorMessage="can not by empty" Text="X" ForeColor="red"></asp:RequiredFieldValidator>
						<asp:CompareValidator ID="cvNotEqual" Operator="NotEqual" runat="server" ControlToValidate="tbPassword" ControlToCompare="tbOldPassword" ErrorMessage="new password must be different from old" Text="X" ForeColor="red"></asp:CompareValidator>
					</div>
					<div>
						<div class="fieldName">
							<asp:Label runat="server" Text="Confirm Password"></asp:Label>
						</div>
						<asp:TextBox ID="tbConfirmPassword" type="password" runat="server" />
						<asp:RequiredFieldValidator ID="rvConfirmPassword" runat="server" ControlToValidate="tbConfirmPassword" ErrorMessage="can not by empty" Text="X" ForeColor="red"></asp:RequiredFieldValidator>
						<asp:CompareValidator ID="cvConfirm" runat="server" ControlToValidate="tbConfirmPassword" ControlToCompare="tbPassword" ErrorMessage="passwords do not match" Text="X" ForeColor="red"></asp:CompareValidator>
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
