<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Calendar</title>
    <link href="main.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Assignment 2</h1>
        <h2>Calendar by Ayumi Kojima</h2>
        <asp:Calendar ID="Calendar1" runat="server" OnSelectionChanged="Calendar1_SelectionChanged"  Height="476px" Width="1100px"></asp:Calendar>
        <asp:Label ID="Label1" runat="server" Height="44px" Width="593px"></asp:Label>
    </div>
    </form>
</body>
</html>
