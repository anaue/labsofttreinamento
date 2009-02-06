<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ObjetoCadastro.aspx.cs" Inherits="Prototipo3C_Aplicacao.Paginas.ObjetoCadastro" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <br />
        <br />
        Id:
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <br />
        Nome:
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        <br />
        Cor:&nbsp;
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Enabled="False" Visible="false" ForeColor="#CC3300" 
            Text="Campo Obrigatório em Branco!"></asp:Label>
        <asp:Label ID="Label2" runat="server" Enabled="False" Visible="false" ForeColor="#CC3300" 
            Text="Erro ao tentar gravar!"></asp:Label>
        <br />
        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
            Text="Cadastrar" />
        <br />    </div>
        <br />
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" 
        SelectMethod="ObterObjetos" 
        TypeName="Prototipo3C_Negocio.Controladores.ObjetoController">
    </asp:ObjectDataSource>
        <br />
        <br />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
        CellPadding="4" DataSourceID="ObjectDataSource1" ForeColor="#333333" 
        GridLines="None" Visible="False">
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <RowStyle BackColor="#EFF3FB" />
            <Columns>
                <asp:BoundField DataField="ObjetoId" HeaderText="ObjetoId" ReadOnly="True" 
                    SortExpression="ObjetoId" />
                <asp:BoundField DataField="Nome" HeaderText="Nome" SortExpression="Nome" />
                <asp:BoundField DataField="Cor" HeaderText="Cor" SortExpression="Cor" />
            </Columns>
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <EditRowStyle BackColor="#2461BF" />
            <AlternatingRowStyle BackColor="White" />
    </asp:GridView>
        <br />
        <br />
    

    </form>
            

</body>
</html>
