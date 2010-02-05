<%@ Page Language="C#" Inherits="FamilyTree.Default" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Strict//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd">
<html>
<head>
	<title>Default</title>
</head>
<body>
	<form id="form1" runat="server">
		<asp:Button id="button1" runat="server" Text="Click me!" OnClick="button1Clicked" />
		<!--<asp:Label id="label1" runat="server" />-->
		<asp:DataGrid runat="server" id="dgPeople"
			HeaderStyle-BackColor="LightGray"
			HeaderStyle-Font-Bold="True" />
	</form>
</body>
</html>