<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="MultiVieweg.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:MultiView ID="MultiView1" runat="server" OnPreRender="MultiView1_PreRender" OnActiveViewChanged="MultiView1_ActiveViewChanged">
                <asp:View ID="View1" runat="server">
                    <asp:Image ID="Image1" runat="server" Height="200px" Width="546px" ImageUrl="~/NewFolder2/1653820599824.jpg" />
                </asp:View>
                <asp:View ID="View2" runat="server">
                    <asp:Image ID="Image2" runat="server" Height="117px" Width="553px" ImageUrl="~/NewFolder2/1653820599827.jpg" />
                </asp:View>
                <asp:View ID="View3" runat="server">
                    <asp:Image ID="Image3" runat="server" Height="156px" Width="558px" ImageUrl="~/NewFolder2/1653820599831.jpg" />
                </asp:View>
            </asp:MultiView>
            <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Next</asp:LinkButton>
&nbsp;
            <asp:LinkButton ID="LinkButton2" runat="server" OnClick="LinkButton2_Click">Previous</asp:LinkButton>
&nbsp;
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </div>
    </form>
</body>
</html>
