<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="MonthlyExpenditures.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>REGISTRATION USER </title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td>
						<asp:Label runat="server" Text="REGISTRATION INFO"/>
                    </td>
                </tr>
                <tr>
                    <td colspan="5">
                    <hr/>
                    </td>
                </tr>
                <tr>
                    <td>
						<asp:Label runat="server" Text="Username" />
                    </td>
                    <td colspan="2">
						<asp:TextBox id="txtUsername" runat="server" />
                         <asp:Label runat="server" Text="*" ForeColor="red" />
                    </td>

                </tr>
                <tr>
                    <td>
						<asp:Label runat="server" Text="Password" />
                    </td>
                    <td colspan="2">
						<asp:TextBox id="txtPassword" runat="server" />
                        <asp:Label runat="server" Text="*" ForeColor="red" />
                    </td>

                </tr>
                <tr>
                    <td>
						<asp:Label runat="server" Text=" Confirm Password" />
                    </td>
                    <td colspan="2">
						<asp:TextBox id="txtRePassword" runat="server" />

                    </td>

                </tr>
                <tr>
                    <td colspan="5">
                    <hr/>
                    </td>
                </tr>
                <tr>
                    <td>
                      <asp:Button id="btnRegister"  runat="server" Text="Register" OnClick="btnRegister_Click" />
                    </td>

                </tr>
                 <tr>
                    <td colspan="5">
                        <asp:Label runat="server" Text="" id="lblSuccesMessage" ForeColor="green"/>
                    </td>
                </tr>
                <tr>
                    <td colspan="5">
                        <asp:Label runat="server" Text="" id="lblErrorMessage"  ForeColor="red"/>
                    </td>
                </tr>


            </table>
        </div>
    </form>
    </body>
</html>
