<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="purchase_form.aspx.cs" Inherits="purchase_app.purchase_form" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <table>
            <tr>
                <td>
                    <b>Numéro de compte :</b>
                </td>
                <td>
                    <asp:TextBox ID="numCompte" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <b>Montant (€) :</b>
                </td>
                <td>
                    <asp:TextBox ID="amount" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <b>Type d'opération :</b>
                </td>
                <td>
                    <asp:RadioButtonList ID="choiceOperation" runat="server">
                        <asp:ListItem Selected="True" Text="Debit"></asp:ListItem>
                        <asp:ListItem Selected="False" Text="Credit"></asp:ListItem>
                    </asp:RadioButtonList>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="submitBtn" runat="server" Text="Envoyer" OnClick="submitBtn_Click" />
                </td>
                <td>
                    <asp:Label ID="resultLbl" runat="server"></asp:Label>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
