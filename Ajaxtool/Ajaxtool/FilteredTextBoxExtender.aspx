<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FilteredTextBoxExtender.aspx.cs" Inherits="Ajaxtool.FilteredTextBoxExtender" %>

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
            <cc1:FilteredTextBoxExtender ID="FilteredTextBoxExtender1" runat="server" TargetControlID="TextBox1" FilterType="UppercaseLetters"></cc1:FilteredTextBoxExtender>

        </div>
    </form>
</body>
</html>
