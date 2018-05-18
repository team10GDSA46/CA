<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="rohitTest.aspx.cs" Inherits="WebApplication1.rohitTest" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="ListBox1" runat="server" style="z-index: 1; left: 10px; top: 15px; position: absolute"></asp:ListBox>
        </div>
        <asp:Button ID="Button1" runat="server" style="z-index: 1; left: 44px; top: 116px; position: absolute; height: 26px;" Text="Hello" OnClick="myFunc" />
    </form>
</body>
</html>
