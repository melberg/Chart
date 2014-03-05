/****************************** Module Header ******************************\
* Module Name:    Utilities.cs
* Project:        CSASPNETChartExport
* Copyright (c) Microsoft Corporation
*
* This is a utilities Class.
* 
* This source is subject to the Microsoft Public License.
* See http://www.microsoft.com/en-us/openness/licenses.aspx#MPL.
* All other rights reserved.
* 
* THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF ANY KIND, 
* EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE IMPLIED 
* WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A PARTICULAR PURPOSE.
\*****************************************************************************/
using System.Data;
using System.Drawing;
using System.Web.UI.DataVisualization.Charting;

namespace CSASPNETChartExport
{
    public static class Utilities
    {
        /// <summary>
        /// Create a DataTable as the data source of the Chart control 
        /// </summary>
        /// <returns>DataTable</returns>
        public static DataTable CreateDataTable()
        {
            // Temp DataTable
            DataTable dt = new DataTable();

            // Add three columns to the DataTable 
            dt.Columns.Add("Date");
            dt.Columns.Add("Volume1");
            dt.Columns.Add("Volume2");

            DataRow dr;

            // Add rows to the table which contains some random data for demonstration 
            dr = dt.NewRow();
            dr["Date"] = "1";
            dr["Volume1"] = 3731;
            dr["Volume2"] = 4101;
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["Date"] = "2";
            dr["Volume1"] = 6024;
            dr["Volume2"] = 4324;
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["Date"] = "3";
            dr["Volume1"] = 4935;
            dr["Volume2"] = 2935;
            dt.Rows.Add(dr);          

            return dt;
        }

        /// <summary>
        /// Render the chart.
        /// </summary>
        /// <param name="myChart">The Chart will be bound to</param>
        public static void DisplayChart(Chart myChart)
        {
            myChart.DataSource = CreateDataTable();

            // Give two columns of data to Y-axle 
            myChart.Series[0].YValueMembers = "Volume1";
            myChart.Series[1].YValueMembers = "Volume2";

            myChart.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            myChart.ChartAreas[0].AxisY.MajorGrid.Enabled = false;

            // Set the X-axle as date value 
            myChart.Series[0].XValueMember = "Date";

            // Bind the Chart control with the setting above 
            myChart.DataBind();





            StripLine stripLine3 = new StripLine();

            // Set threshold line so that it is only shown once
            stripLine3.Interval = 0;

            // Set the threshold line to be drawn at the calculated mean of the first series
            stripLine3.IntervalOffset = 4000;//myChart.DataManipulator.Statistics.Mean(myChart.Series[0].Name);

            stripLine3.BackColor = Color.DarkGreen;
            stripLine3.StripWidth = 0.25;

            // Set text properties for the threshold line
            stripLine3.Text = "40%";
            stripLine3.ForeColor = Color.Black;

            // Add strip line to the chart
            myChart.ChartAreas[0].AxisY.StripLines.Add(stripLine3);


            StripLine stripLine4 = new StripLine();

            // Set threshold line so that it is only shown once
            stripLine4.Interval = 0;

            // Set the threshold line to be drawn at the calculated mean of the first series
            stripLine4.IntervalOffset = 2;//myChart.DataManipulator.Statistics.Mean(myChart.Series[0].Name);

            stripLine4.BackColor = Color.DarkGreen;
            stripLine4.StripWidth = 0.01;

            // Set text properties for the threshold line
            stripLine4.Text = "Mean";
            stripLine4.ForeColor = Color.Black;

            // Add strip line to the chart
            myChart.ChartAreas[0].AxisX.StripLines.Add(stripLine4);
        }



    }
}