<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="FormView01.WebForm3" %>

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
                    id,Name,Age,Address,Gender,Nationality,Marital_Status,English,Malayalam,Hindi,Image
                </HeaderTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label1" runat="server" Text='<%#Eval("id") %>'></asp:Label>
                    <asp:Label ID="Label2" runat="server" Text='<%#Eval("Name") %>'></asp:Label>
                    <asp:Label ID="Label3" runat="server" Text='<%#Eval("Age") %>'></asp:Label>
                    <asp:Label ID="Label4" runat="server" Text='<%#Eval("Address") %>'></asp:Label>
                    <asp:Label ID="Label5" runat="server" Text='<%#Eval("Gender") %>'></asp:Label>
                    <asp:Label ID="Label6" runat="server" Text='<%#Eval("Nationality") %>'></asp:Label>
                    <asp:Label ID="Label7" runat="server" Text='<%#Eval("Marital_Status") %>'></asp:Label>
                    <asp:CheckBox ID="CheckBox1" runat="server" Checked='<%#Eval("English") %>' Text="English"/>
                    <asp:CheckBox ID="CheckBox2" runat="server" Checked='<%#Eval("Malayalam") %>' Text="Malayalam"/>
                    <asp:CheckBox ID="CheckBox3" runat="server" Checked='<%#Eval("Hindi") %>' Text="Hindi"/>
                    <asp:Image ID="Image1" runat="server" ImageUrl='<%#"~/NewFolder1/" + Eval("Image")%>'  Height="40px" Width="40px"/>

                </ItemTemplate>
            </asp:FormView>

        </div>
    </form>
</body>
</html>
