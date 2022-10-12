<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="MonthlyExpenditures.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>LOGIN USER</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td>
						<asp:Label runat="server" Text="LOGIN INFO"></asp:Label> 
                    </td>
                </tr>
                <tr>
                    <td colspan="5">
                    <hr/>
                    </td>
                </tr>
                <tr>
                    <td>
						<asp:Label runat="server" Text="USERNAME"></asp:Label>
                    </td>
                    <td colspan="2">
						<asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
                    </td>

                </tr>
                <tr>
                    <td>
						<asp:Label runat="server" Text="PASSWORD"></asp:Label>
                    </td>
                    <td colspan="2">
						<asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
                    </td>
                 <tr>
                    <td colspan="5">
                    <hr/>
                    </td>
                </tr>
                </tr>
                <tr>
                    <td>
						<asp:Button ID="BtnSubmit" runat="server" Text="SUBMIT" OnClick="BtnSubmit_Click" />
                        &nbsp; &nbsp; <asp:Button ID="BtnRegister" runat="server" Text="REGISTER" OnClick="BtnRegister_Click" />
                    </td>

                </tr>


            </table>
        </div>
    </form>
</body>
</html>
