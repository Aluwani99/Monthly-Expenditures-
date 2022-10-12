<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Monthly.aspx.cs" Inherits="MonthlyExpenditures.Monthly" %>

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
            <table class="auto-style1">
                <tr>
                    <td colspan="6" style="text-align: center; vertical-align: top">
						<asp:Label runat="server" Font-Bold="True" Font-Size="XX-Large" Font-Underline="True" Text="MONTHLY INCOME MANAGMENT SYSTEM"></asp:Label> 
                    <td/>
                </tr>
                <tr>
                    <td colspan="5">
                    <hr/>
                    </td>
                </tr>
                 <tr>
                    <td colspan="5" style="text-align: center; vertical-align: top">
                        <asp:Label runat="server" Font-Bold="True" Text="GROSS MONTHLY"></asp:Label>
                    <hr/>

                    </td>
                </tr>
                <tr>
                    <td colspan="2">
						<asp:Label runat="server" Text="Gross R"></asp:Label>
                        &nbsp;
                        <asp:TextBox ID="txtGross" runat="server"></asp:TextBox>
                        &nbsp;  &nbsp;  &nbsp;  &nbsp;
                        <asp:Label runat="server" Text="Groceries R"></asp:Label>
                        &nbsp;
                        <asp:TextBox ID="txtGroceries" runat="server"></asp:TextBox> 
                         &nbsp;  &nbsp;  &nbsp;  &nbsp;
                        <asp:Label runat="server" Text="Travel  R"></asp:Label>
                        &nbsp;
                        <asp:TextBox ID="txtTravel" runat="server"></asp:TextBox>
                        &nbsp;  &nbsp;  &nbsp;  &nbsp;
                        <asp:Label runat="server" Text="Other Expense R"></asp:Label>
                        &nbsp;
                        <asp:TextBox ID="txtExpense" runat="server"></asp:TextBox>
                    </td>
                   
                </tr>
                <tr>
                     <td colspan="2">
						<asp:Label runat="server" Text="Monthly R"></asp:Label>
                        &nbsp;
                        <asp:TextBox ID="txtMonthly" runat="server"></asp:TextBox>
                        &nbsp;  &nbsp;  &nbsp;  &nbsp;
                        <asp:Label runat="server" Text="Water & light R"></asp:Label>
                        &nbsp;
                        <asp:TextBox ID="txtWater" runat="server"></asp:TextBox> 
                         &nbsp;  &nbsp;  &nbsp;  &nbsp;
                        <asp:Label runat="server" Text="Cell Phone  R"></asp:Label>
                        &nbsp;
                        <asp:TextBox ID="txtPhone" runat="server"></asp:TextBox>
                        &nbsp;  &nbsp;  &nbsp;  &nbsp;
                                             
                         <asp:Button ID="btnExpense" runat="server" Text="SAVE DATA" ForeColor="blue" OnClick="btnExpense_Click" />
                                             
                    </td>

                </tr>
                 <tr>
                    <td colspan="5">
                    <hr/>
                    </td>
                </tr>
                 <tr>
                        <td colspan="5" style="text-align: center; vertical-align: top">
                        <asp:Label runat="server" Font-Bold="True" Text="ACCOMMONDATION INFO"></asp:Label>
                    <hr/>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                     <asp:Label runat="server" Font-Bold="True" Text="RENTING INFO"></asp:Label>
                     <hr/>
                     <asp:Label runat="server" Text="Renting Amount R"></asp:Label>
                        &nbsp;
                        <asp:TextBox ID="txtRenting" runat="server"></asp:TextBox>
                        &nbsp;  &nbsp;  &nbsp;  &nbsp;
                        <asp:Button ID="BtnRenting" runat="server" Text="Capture" OnClick="BtnRenting_Click" />
           
                    </td>
                </tr>
                
                <tr>
                    <td colspan="5">
                    <hr/>
                    </td>
                </tr>
                 
                <tr>
                    <td colspan="2">
                     <asp:Label runat="server" Font-Bold="True" Text="PROPERTY INFO"></asp:Label>
                     <hr/>
                     <asp:Label runat="server" Text="Price Of Property  R"></asp:Label>
                        &nbsp;
                        <asp:TextBox ID="txtPriceHome1" runat="server"></asp:TextBox>
                        &nbsp;  &nbsp;  &nbsp;  &nbsp;
                        <asp:Label runat="server" Text="Interest Rate R"></asp:Label>
                        &nbsp;
                        <asp:TextBox ID="RateHome" runat="server"></asp:TextBox> 
                         &nbsp;  &nbsp;  &nbsp;  &nbsp;
                        <asp:Label runat="server" Text="Total Deposit  R"></asp:Label>
                        &nbsp;
                        <asp:TextBox ID="DepositHome" runat="server"></asp:TextBox>
           
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label runat="server" Text="Months To Repay R"></asp:Label>
                        <asp:TextBox ID="txtMonths" runat="server"></asp:TextBox>
                        &nbsp;  &nbsp;  &nbsp;  &nbsp;
                        <asp:Button ID="BtnHomeLoan" runat="server" Text="Home Loan Calculate" OnClick="BtnHomeLoan_Click" />
                        &nbsp; 
                        <asp:TextBox ID="txtHomeLoa" runat="server"></asp:TextBox>
                        &nbsp;  &nbsp;  &nbsp;  &nbsp;
                        </td>
                </tr>
                <tr>
                    <td colspan="5">
                    <hr/>
                    </td>
                </tr>
                <tr>
                        <td colspan="5" style="text-align: center; vertical-align: top">
                        <asp:Label runat="server" Font-Bold="True" Text="VEHICLE INFO"></asp:Label>
                    <hr/>
                    </td>
                </tr>

                <tr>
                    <td colspan="2">
                     <asp:Label runat="server" Font-Bold="True" Text="CAR INFO"></asp:Label>
                     <hr/>
                     <asp:Label runat="server" Text="Model"></asp:Label>
                        &nbsp;
                        <asp:TextBox ID="txtModel" runat="server"></asp:TextBox>
                        &nbsp;  &nbsp;  &nbsp;  &nbsp;
                        <asp:Label runat="server" Text="Deposit R"></asp:Label>
                        &nbsp;
                        <asp:TextBox ID="txtCarDeposit" runat="server"></asp:TextBox> 
                         &nbsp;  &nbsp;  &nbsp;  &nbsp;
                        <asp:Label runat="server" Text="Interest Rate  R"></asp:Label>
                        &nbsp;
                        <asp:TextBox ID="txtRateCar" runat="server"></asp:TextBox>
           
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label runat="server" Text="Insurance R"></asp:Label>
                        &nbsp;
                        <asp:TextBox ID="CarInsure" runat="server"></asp:TextBox>
                        &nbsp;  &nbsp;  &nbsp;  &nbsp;
                         <asp:Label runat="server" Text="Price R"></asp:Label>
                        &nbsp;
                        <asp:TextBox ID="txtPriceCar" runat="server"></asp:TextBox>
                         &nbsp;  &nbsp;
                        <asp:Button ID="BtnCalucate" runat="server" Text="Calculate" OnClick="BtnCalucate_Click" />
                        &nbsp; 
                        <asp:TextBox ID="txtCarCalculate" runat="server"></asp:TextBox>
                        &nbsp;  &nbsp;  &nbsp;  &nbsp;
                        </td>
                </tr>
                <tr>
                    <td colspan="5">
                    <hr/>
                    </td>
                </tr>
                <tr>
                    <td style="text-align: center">
						<asp:Button id="btnSubmit" runat="server" Text="SUBMIT" OnClick="btnSubmit_Click" />
                        &nbsp; &nbsp;
                        <asp:Button runat="server" ID="btnSaving" Text="SAVING OPTION" OnClick="btnSaving_Click" />
                         &nbsp; &nbsp;
                        <asp:Button runat="server" id="btnReset" Text="RESET" OnClick="btnReset_Click" />
                         &nbsp; &nbsp;
                        </td>

                </tr>


            </table>
        </div>
    </form>
</body>
</html>
