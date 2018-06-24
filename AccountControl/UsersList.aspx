<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UsersList.aspx.cs" Inherits="AccountControl.UsersList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>AccountControl</title>
	<link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.1.1/css/bootstrap.min.css" integrity="sha384-WskhaSGFgHYWDcbwN70/dfYBj47jz9qbsMId/iRN3ewGhXQFZCSftd1LZCfmhktB" crossorigin="anonymous" />
	<link href="style.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
			<div class="container">
			<div class="row">
				<h1>Users List</h1>
				<div class="form col-lg-12">
					<asp:CheckBoxList ID="checkBoxList" runat="server" OnSelectedIndexChanged      ="checkBoxList_SelectedIndexChanged" AutoPostBack="true">	
						<%--place for listItems--%>
					</asp:CheckBoxList>
					<asp:Button ID="btnDelet" runat="server" Text="Delete" OnClick="Delete_Click"/>
				</div>
			</div>
			<div class="row">
				<div class="footer col-lg-12">
					<asp:Button ID="btnAddUser" runat="server" Text="Add User" OnClick="btnAddUser_Click" CssClass="btn"/>
					
				</div>
			</div>
		</div>
        </div>
    </form>
</body>
</html>
