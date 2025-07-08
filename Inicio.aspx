<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="Tarea_Calculadora_Web.Inicio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Mi Calculadora</title>
    <style>
        body{
            background-color: darkgray;
            text-align: left
            }
        h1 {
            color: black
        }
        p1 {
            color: black
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1> Calculadora</h1>
            
           


        </div>
        <p>
            <asp:Label ID="Label1" runat="server" Text="Numero 1:"></asp:Label>
            <asp:TextBox ID="Txt1" runat="server"></asp:TextBox>
            <asp:Button ID="btn_Sum" runat="server" OnClick="Button1_Click" Text="+" Width="26px" />
            <asp:Button ID="btn_Div" runat="server" Text="/" Width="27px" OnClick="btn_Div_Click" />
            <asp:Button ID="btn_poten3" runat="server" Text="a³" OnClick="btn_poten3_Click" />
        </p>
        <p>
            Numero 2:
            <asp:TextBox ID="Txt2" runat="server"></asp:TextBox>
            <asp:Button ID="btn_rest" runat="server" OnClick="btn_rest_Click" Text="-" Width="26px" />
            <asp:Button ID="btn_raiz" runat="server" Text="√" Width="26px" OnClick="btn_raiz_Click" />
            <asp:Button ID="btn_fact" runat="server" Text="!" Width="26px" OnClick="btn_fact_Click" />
            <asp:Button ID="btn_Borrar" runat="server" Text="AC" Width="71px" OnClick="btn_Borrar_Click" />
        </p>
        Resultado: <asp:TextBox ID="Txt3" runat="server"></asp:TextBox>
        <asp:Button ID="btn_Mult" runat="server" Text="*" Width="24px" OnClick="btn_Mult_Click" />
        <asp:Button ID="btn_poten2" runat="server" Text="a²" Width="31px" OnClick="btn_poten2_Click" />
        <asp:Button ID="btn_fibo" runat="server" Text="φ" Width="28px" OnClick="btn_fibo_Click" />
        <br />
        <p>
            <asp:TextBox ID="MSJS" runat="server" Height="100px" OnTextChanged="MSJS_TextChanged" Width="272px"></asp:TextBox>
        </p>
    </form>
</body>
</html>
