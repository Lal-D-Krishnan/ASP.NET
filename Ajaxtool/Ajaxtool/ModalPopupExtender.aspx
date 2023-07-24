<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ModalPopupExtender.aspx.cs" Inherits="Ajaxtool.ModalPopupExtender" %>

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

            <asp:Panel ID="Panel1" runat="server">Hello how are you doing ?....</asp:Panel>
            <asp:Button ID="Button1" runat="server" Text="Button" />
            <cc1:ModalPopupExtender ID="ModalPopupExtender1" runat="server" TargetControlID="Button1" PopupControlID="Panel1"></cc1:ModalPopupExtender>
        </div>
    </form>
</body>
</html>
