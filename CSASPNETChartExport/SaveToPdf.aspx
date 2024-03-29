﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SaveToPdf.aspx.cs" Inherits="CSASPNETChartExport.SaveToPdf" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Chart ID="myChart" runat="server" Height="400px" Width="500px"> 
            <Series> 
                <asp:Series Name="Series1" ChartType="Column" ChartArea="ChartArea1"> 
                </asp:Series> 
                <asp:Series Name="Series2" ChartType="Column" ChartArea="ChartArea1"> 
                </asp:Series> 
            </Series> 
            <ChartAreas> 
                <asp:ChartArea Name="ChartArea1"> 
                </asp:ChartArea> 
            </ChartAreas> 
        </asp:Chart> 

        <asp:Button ID="btnSave" runat="server" Text="Save to Pdf" 
            onclick="btnSave_Click" />       
    </div>
    </form>
</body>
</html>
