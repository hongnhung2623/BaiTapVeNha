<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="web_hinh_tron.WebForm1" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Tính Toán Hình Tròn</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Tính Toán Diện Tích và Chu Vi Hình Tròn</h2>
            <asp:Label ID="lblRadius" runat="server" Text="Nhập bán kính: "></asp:Label>
            <asp:TextBox ID="txtRadius" runat="server"></asp:TextBox>
            <asp:Button ID="btnCalculate" runat="server" Text="Tính Toán" OnClick="btnCalculate_Click" />
            
            <br /><br />
            <asp:Label ID="lblResult" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html><%--  --%>