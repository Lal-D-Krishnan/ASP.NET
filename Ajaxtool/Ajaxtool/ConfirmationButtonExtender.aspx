<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ConfirmationButtonExtender.aspx.cs" Inherits="Ajaxtool.ConfirmationButtonExtender" %>

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
            <asp:Button ID="Button1" runat="server" Text="Button" />
            <cc1:ConfirmButtonExtender ID="ConfirmButtonExtender1" runat="server" TargetControlID="Button1" ConfirmText="Do you want to continue..."></cc1:ConfirmButtonExtender>

        </div>
    </form>
</body>
</html>
