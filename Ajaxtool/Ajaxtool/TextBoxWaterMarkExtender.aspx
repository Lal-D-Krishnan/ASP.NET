<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TextBoxWaterMarkExtender.aspx.cs" Inherits="Ajaxtool.WebForm1" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ScriptManager ID="ScriptManager1" runat="server">
            </asp:ScriptManager>
            <br />
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <cc1:TextBoxWatermarkExtender ID="TextBoxWatermarkExtender1" runat="server" TargetControlID="TextBox1" WatermarkText="Enter Your Name"></cc1:TextBoxWatermarkExtender>
&nbsp;</div>
    </form>
</body>
</html>
