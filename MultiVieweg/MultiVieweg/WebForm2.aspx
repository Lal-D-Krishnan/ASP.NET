<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="MultiVieweg.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:MultiView ID="MultiView1" runat="server">
                <asp:View ID="View1" runat="server">
                    <asp:Image ID="Image1" runat="server" Height="217px" Width="457px" ImageUrl="~/Photos/image1.jpg" ViewStateMode="Disabled" />
                </asp:View>
                <asp:View ID="View2" runat="server">
                    <asp:Image ID="Image2" runat="server" Height="229px" Width="465px" ImageUrl="~/NewFolder2/1653820599827.jpg" />
                </asp:View>
                <asp:View ID="View3" runat="server">
                    <asp:Image ID="Image3" runat="server" Height="268px" Width="471px" ImageUrl="~/Photos/image3.jpg" />
                </asp:View>
            </asp:MultiView>
        </div>
        <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Next</asp:LinkButton>
&nbsp;
        <asp:LinkButton ID="LinkButton2" runat="server" OnClick="LinkButton2_Click">Previous</asp:LinkButton>
&nbsp;
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    </form>
</body>
</html>
