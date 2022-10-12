<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FutureValue.aspx.cs" Inherits="MonthlyExpenditures.FutureValue" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
     <style type="text/css">  
        .auto-style1 {  
            width: 100%;  
        }  
    </style>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        &nbsp;<table style="width: 211px">
             <tr>
                    <td colspan="6" style="text-align: center; vertical-align: top">
						<asp:Label runat="server" Font-Bold="True" Font-Size="XX-Large" Font-Underline="True" Text="MONTHLY SAVINGS"></asp:Label> 
                    <td/>
                </tr>
            <tr>
                    <td colspan="5">
                    <hr/>
                    </td>
                </tr>
            <tr>
            <td style="width: 242px">
                    <asp:Label ID="Label3" runat="server" Text="Reason For Saving"
                        Width="176px"></asp:Label></td>
                <td style="width: 186px">
                    <asp:TextBox ID="txtSavings" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="width: 242px">
                    <asp:Label ID="lblRateOfInterest" runat="server" Text="Yearly Interest Rate"
                        Width="176px"></asp:Label></td>
                <td style="width: 186px">
                    <asp:TextBox ID="txtInterestRate" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="width: 242px">
                    <asp:Label ID="lblNumberOfMonths" runat="server" Text="Number of Years"></asp:Label></td>
                <td style="width: 186px">
                    <asp:TextBox ID="txtNumberOfYears" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="width: 242px">
                    <asp:Label ID="lblHowMuchPerMonth" runat="server" Text="Amount per month you can pay"
                        Width="188px"></asp:Label></td>
                <td style="width: 186px">
                    <asp:TextBox ID="txtAmountPerPeriod" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                    <td colspan="5">
                    <hr/>
                    </td>
                </tr>
            <tr>
                <td colspan="2">
                    <asp:Button ID="btnCalculate" runat="server" OnClick="btnCalculate_Click" Text="Calculate"
                        Width="360px" /></td>
            </tr>
            <tr>
                    <td colspan="5">
                    <hr/>
                    </td>
                </tr>
            <tr>
            <td style="width: 242px">
                    <asp:Label ID="Label1" runat="server" Text="Future Value"
                        Width="188px"></asp:Label></td>
                <td style="width: 186px">
                    <asp:TextBox ID="txtFutureValue" runat="server"></asp:TextBox></td>
                </tr>
            <tr>
                    <td colspan="5">
                    <hr/>
                    </td>
                </tr>
            <tr>
                <td colspan="2">
                        They amount which you Saved That Year will be &nbsp;<asp:Label ID="lblValue" runat="server"></asp:Label></td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>

