﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SaveToImage.aspx.cs" Inherits="CSASPNETChartExport.SaveToImage" %>

<%@ Register Assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35"
    Namespace="System.Web.UI.DataVisualization.Charting" TagPrefix="asp" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Chart ID="myChart" runat="server" Height="400px" Width="500px" > 
            <Series> 
                <asp:Series Name="Series1" ChartType="Spline" ChartArea="ChartArea1" IsValueShownAsLabel="false" > 
                </asp:Series> 
                <asp:Series Name="Series2" ChartType="Spline" ChartArea="ChartArea1"> 
                </asp:Series> 
            </Series> 
            <ChartAreas> 
                <asp:ChartArea Name="ChartArea1"> 
                </asp:ChartArea> 
            </ChartAreas> 
        </asp:Chart> 

        <asp:Button ID="btnSave" runat="server" Text="Save to Image" 
            onclick="btnSave_Click" />  
    </div>
    </form>
</body>
</html>
