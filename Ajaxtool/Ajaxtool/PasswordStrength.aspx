<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PasswordStrength.aspx.cs" Inherits="Ajaxtool.PasswordStrength" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            <br />
            <cc1:PasswordStrength ID="PasswordStrength1" runat="server" TargetControlID="TextBox1" HelpStatusLabelID="Label1" MinimumLowerCaseCharacters="3" MinimumNumericCharacters="3" MinimumSymbolCharacters="1" MinimumUpperCaseCharacters="1" PreferredPasswordLength="8"></cc1:PasswordStrength>

        </div>
    </form>
</body>
</html>
