<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Week_1___Robot.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="lbl_positie" runat="server" Text="Label"></asp:Label>
    
    </div>
        <p>
            <asp:Button ID="btn_Links" runat="server" OnClick="btn_Links_Click" Text="Links" />
            <asp:Button ID="btn_Rust" runat="server" OnClick="btn_Rust_Click" Text="Rust" />
            <asp:Button ID="btn_Rechts" runat="server" OnClick="btn_Rechts_Click" Text="Rechts" />
        </p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
