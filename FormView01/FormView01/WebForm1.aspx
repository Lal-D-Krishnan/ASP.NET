<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="FormView01.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:FormView ID="FormView1" runat="server">
                <HeaderTemplate>
                    Name,Courses
                </HeaderTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label1" runat="server" Text='<%#Eval("Name") %>'></asp:Label>
                    <asp:CheckBox ID="CheckBox1" runat="server" Checked='<%#Eval("Java") %>' Text="Java"/>
                    <asp:CheckBox ID="CheckBox2" runat="server" Checked='<%#Eval("Asp_Net") %>' Text="Asp_Net"/>
                    <asp:CheckBox ID="CheckBox3" runat="server" Checked='<%#Eval("Python") %>' Text="Python"/>

                    <%--<asp:Image ID="Image1" runat="server" ImageUrl='<%#"~/NewFolder1/" + Eval("Image")%>' />--%>

                </ItemTemplate>
            </asp:FormView>
        </div>
    </form>
</body>
</html>
