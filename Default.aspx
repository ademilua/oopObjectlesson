<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="OOPClassObjectLesson1.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Image ID="Image1" runat="server" Height="200px" Width="200px" />
        <asp:Image ID="Image2" runat="server" Height="200px" Width="200px" />
        <asp:Image ID="Image3" runat="server" Height="200px" Width="200px" />
        <br />
        <br />
        <br />
        <br />
    
        <asp:Label ID="resultLabel" runat="server"></asp:Label>
    
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Spin" Width="94px" />
        <br />
        <br />
        If You Spin 3 white cars then you have access to both cars at $1000.<br />
    
    </div>
    </form>
</body>
</html>
