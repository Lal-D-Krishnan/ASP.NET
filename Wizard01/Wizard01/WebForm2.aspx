<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="Wizard01.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            margin-right: 208px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Wizard ID="Wizard1" runat="server" CssClass="auto-style2" Width="253px" ActiveStepIndex="1" OnFinishButtonClick="Wizard1_FinishButtonClick" OnNextButtonClick="Wizard1_NextButtonClick">
                <WizardSteps>
                    <asp:WizardStep runat="server" title="Step 1">
                        <table class="auto-style1">
                            <tr>
                                <td>
                                    <asp:Label ID="Label1" runat="server" Text="Language"></asp:Label>
                                </td>
                                <td>
                                    <asp:CheckBox ID="CheckBox1" runat="server" Text="Java"  />
                                    &nbsp;
                                    <asp:CheckBox ID="CheckBox2" runat="server" Text="javascript" />
                                </td>
                            </tr>
                            <tr>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                        </table>
                    </asp:WizardStep>
                    <asp:WizardStep runat="server" title="Step 2">
                        <table class="auto-style1">
                            <tr>
                                <td>
                                    <asp:CheckBox ID="CheckBox3" runat="server" Text="Java" />
                                    &nbsp;
                                    <asp:CheckBox ID="CheckBox4" runat="server" Text="Javascript" />
                                    &nbsp; </td>
                                <td>&nbsp;</td>
                            </tr>
                        </table>
                    </asp:WizardStep>
                    <asp:WizardStep runat="server" Title="Step3">
                    </asp:WizardStep>
                </WizardSteps>
            </asp:Wizard>
        </div>
    </form>
</body>
</html>
