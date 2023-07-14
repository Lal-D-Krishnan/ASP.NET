<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="ListView2.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListView ID="ListView1" runat="server" DataKeyNames="id" DataSourceID="SqlDataSource1">
                <AlternatingItemTemplate>
                    <tr style="background-color: #FFFFFF;color: #284775;">
                        <td>
                            <asp:Label ID="idLabel" runat="server" Text='<%# Eval("id") %>' />
                        </td>
                        <td>
                            <asp:Label ID="NameLabel" runat="server" Text='<%# Eval("Name") %>' />
                        </td>
                        <td>
                            <asp:Label ID="AgeLabel" runat="server" Text='<%# Eval("Age") %>' />
                        </td>
                        <td>
                            <asp:Label ID="AddressLabel" runat="server" Text='<%# Eval("Address") %>' />
                        </td>
                        <td>
                            <asp:Label ID="GenderLabel" runat="server" Text='<%# Eval("Gender") %>' />
                        </td>
                        <td>
                            <asp:Label ID="NationalityLabel" runat="server" Text='<%# Eval("Nationality") %>' />
                        </td>
                        <td>
                            <asp:Label ID="Marital_StatusLabel" runat="server" Text='<%# Eval("Marital_Status") %>' />
                        </td>
                        <td>
                            <asp:CheckBox ID="EnglishCheckBox" runat="server" Checked='<%# Eval("English") %>' Enabled="false" />
                        </td>
                        <td>
                            <asp:CheckBox ID="MalayalamCheckBox" runat="server" Checked='<%# Eval("Malayalam") %>' Enabled="false" />
                        </td>
                        <td>
                            <asp:CheckBox ID="HindiCheckBox" runat="server" Checked='<%# Eval("Hindi") %>' Enabled="false" />
                        </td>
                        <td>
                            <asp:Label ID="ImageLabel" runat="server" Text='<%# Eval("Image") %>' />
                        </td>
                    </tr>
                </AlternatingItemTemplate>
                <EditItemTemplate>
                    <tr style="background-color: #999999;">
                        <td>
                            <asp:Button ID="UpdateButton" runat="server" CommandName="Update" Text="Update" />
                            <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Cancel" />
                        </td>
                        <td>
                            <asp:Label ID="idLabel1" runat="server" Text='<%# Eval("id") %>' />
                        </td>
                        <td>
                            <asp:TextBox ID="NameTextBox" runat="server" Text='<%# Bind("Name") %>' />
                        </td>
                        <td>
                            <asp:TextBox ID="AgeTextBox" runat="server" Text='<%# Bind("Age") %>' />
                        </td>
                        <td>
                            <asp:TextBox ID="AddressTextBox" runat="server" Text='<%# Bind("Address") %>' />
                        </td>
                        <td>
                            <asp:TextBox ID="GenderTextBox" runat="server" Text='<%# Bind("Gender") %>' />
                        </td>
                        <td>
                            <asp:TextBox ID="NationalityTextBox" runat="server" Text='<%# Bind("Nationality") %>' />
                        </td>
                        <td>
                            <asp:TextBox ID="Marital_StatusTextBox" runat="server" Text='<%# Bind("Marital_Status") %>' />
                        </td>
                        <td>
                            <asp:CheckBox ID="EnglishCheckBox" runat="server" Checked='<%# Bind("English") %>' />
                        </td>
                        <td>
                            <asp:CheckBox ID="MalayalamCheckBox" runat="server" Checked='<%# Bind("Malayalam") %>' />
                        </td>
                        <td>
                            <asp:CheckBox ID="HindiCheckBox" runat="server" Checked='<%# Bind("Hindi") %>' />
                        </td>
                        <td>
                            <asp:TextBox ID="ImageTextBox" runat="server" Text='<%# Bind("Image") %>' />
                        </td>
                    </tr>
                </EditItemTemplate>
                <EmptyDataTemplate>
                    <table runat="server" style="background-color: #FFFFFF;border-collapse: collapse;border-color: #999999;border-style:none;border-width:1px;">
                        <tr>
                            <td>No data was returned.</td>
                        </tr>
                    </table>
                </EmptyDataTemplate>
                <InsertItemTemplate>
                    <tr style="">
                        <td>
                            <asp:Button ID="InsertButton" runat="server" CommandName="Insert" Text="Insert" />
                            <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Clear" />
                        </td>
                        <td>&nbsp;</td>
                        <td>
                            <asp:TextBox ID="NameTextBox" runat="server" Text='<%# Bind("Name") %>' />
                        </td>
                        <td>
                            <asp:TextBox ID="AgeTextBox" runat="server" Text='<%# Bind("Age") %>' />
                        </td>
                        <td>
                            <asp:TextBox ID="AddressTextBox" runat="server" Text='<%# Bind("Address") %>' />
                        </td>
                        <td>
                            <asp:TextBox ID="GenderTextBox" runat="server" Text='<%# Bind("Gender") %>' />
                        </td>
                        <td>
                            <asp:TextBox ID="NationalityTextBox" runat="server" Text='<%# Bind("Nationality") %>' />
                        </td>
                        <td>
                            <asp:TextBox ID="Marital_StatusTextBox" runat="server" Text='<%# Bind("Marital_Status") %>' />
                        </td>
                        <td>
                            <asp:CheckBox ID="EnglishCheckBox" runat="server" Checked='<%# Bind("English") %>' />
                        </td>
                        <td>
                            <asp:CheckBox ID="MalayalamCheckBox" runat="server" Checked='<%# Bind("Malayalam") %>' />
                        </td>
                        <td>
                            <asp:CheckBox ID="HindiCheckBox" runat="server" Checked='<%# Bind("Hindi") %>' />
                        </td>
                        <td>
                            <asp:TextBox ID="ImageTextBox" runat="server" Text='<%# Bind("Image") %>' />
                        </td>
                    </tr>
                </InsertItemTemplate>
                <ItemTemplate>
                    <tr style="background-color: #E0FFFF;color: #333333;">
                        <td>
                            <asp:Label ID="idLabel" runat="server" Text='<%# Eval("id") %>' />
                        </td>
                        <td>
                            <asp:Label ID="NameLabel" runat="server" Text='<%# Eval("Name") %>' />
                        </td>
                        <td>
                            <asp:Label ID="AgeLabel" runat="server" Text='<%# Eval("Age") %>' />
                        </td>
                        <td>
                            <asp:Label ID="AddressLabel" runat="server" Text='<%# Eval("Address") %>' />
                        </td>
                        <td>
                            <asp:Label ID="GenderLabel" runat="server" Text='<%# Eval("Gender") %>' />
                        </td>
                        <td>
                            <asp:Label ID="NationalityLabel" runat="server" Text='<%# Eval("Nationality") %>' />
                        </td>
                        <td>
                            <asp:Label ID="Marital_StatusLabel" runat="server" Text='<%# Eval("Marital_Status") %>' />
                        </td>
                        <td>
                            <asp:CheckBox ID="EnglishCheckBox" runat="server" Checked='<%# Eval("English") %>' Enabled="false" />
                        </td>
                        <td>
                            <asp:CheckBox ID="MalayalamCheckBox" runat="server" Checked='<%# Eval("Malayalam") %>' Enabled="false" />
                        </td>
                        <td>
                            <asp:CheckBox ID="HindiCheckBox" runat="server" Checked='<%# Eval("Hindi") %>' Enabled="false" />
                        </td>
                        <td>
                            <asp:Label ID="ImageLabel" runat="server" Text='<%# Eval("Image") %>' />
                        </td>
                    </tr>
                </ItemTemplate>
                <LayoutTemplate>
                    <table runat="server">
                        <tr runat="server">
                            <td runat="server">
                                <table id="itemPlaceholderContainer" runat="server" border="1" style="background-color: #FFFFFF;border-collapse: collapse;border-color: #999999;border-style:none;border-width:1px;font-family: Verdana, Arial, Helvetica, sans-serif;">
                                    <tr runat="server" style="background-color: #E0FFFF;color: #333333;">
                                        <th runat="server">id</th>
                                        <th runat="server">Name</th>
                                        <th runat="server">Age</th>
                                        <th runat="server">Address</th>
                                        <th runat="server">Gender</th>
                                        <th runat="server">Nationality</th>
                                        <th runat="server">Marital_Status</th>
                                        <th runat="server">English</th>
                                        <th runat="server">Malayalam</th>
                                        <th runat="server">Hindi</th>
                                        <th runat="server">Image</th>
                                    </tr>
                                    <tr id="itemPlaceholder" runat="server">
                                    </tr>
                                </table>
                            </td>
                        </tr>
                        <tr runat="server">
                            <td runat="server" style="text-align: center;background-color: #5D7B9D;font-family: Verdana, Arial, Helvetica, sans-serif;color: #FFFFFF"></td>
                        </tr>
                    </table>
                </LayoutTemplate>
                <SelectedItemTemplate>
                    <tr style="background-color: #E2DED6;font-weight: bold;color: #333333;">
                        <td>
                            <asp:Label ID="idLabel" runat="server" Text='<%# Eval("id") %>' />
                        </td>
                        <td>
                            <asp:Label ID="NameLabel" runat="server" Text='<%# Eval("Name") %>' />
                        </td>
                        <td>
                            <asp:Label ID="AgeLabel" runat="server" Text='<%# Eval("Age") %>' />
                        </td>
                        <td>
                            <asp:Label ID="AddressLabel" runat="server" Text='<%# Eval("Address") %>' />
                        </td>
                        <td>
                            <asp:Label ID="GenderLabel" runat="server" Text='<%# Eval("Gender") %>' />
                        </td>
                        <td>
                            <asp:Label ID="NationalityLabel" runat="server" Text='<%# Eval("Nationality") %>' />
                        </td>
                        <td>
                            <asp:Label ID="Marital_StatusLabel" runat="server" Text='<%# Eval("Marital_Status") %>' />
                        </td>
                        <td>
                            <asp:CheckBox ID="EnglishCheckBox" runat="server" Checked='<%# Eval("English") %>' Enabled="false" />
                        </td>
                        <td>
                            <asp:CheckBox ID="MalayalamCheckBox" runat="server" Checked='<%# Eval("Malayalam") %>' Enabled="false" />
                        </td>
                        <td>
                            <asp:CheckBox ID="HindiCheckBox" runat="server" Checked='<%# Eval("Hindi") %>' Enabled="false" />
                        </td>
                        <td>
                            <asp:Label ID="ImageLabel" runat="server" Text='<%# Eval("Image") %>' />
                        </td>
                    </tr>
                </SelectedItemTemplate>
            </asp:ListView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:lalkrishnanConnectionString %>" SelectCommand="SELECT * FROM [Table_7]"></asp:SqlDataSource>
        </div>
    </form>
</body>
</html>
