using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using FileTracking.Abstract;
using FileTracking.Concrete;
using System.IO;
using FileTracking.Entities;

namespace FileTracking
{
    public partial class Form1 : Form
    {
        private readonly IFileLoaderService fileLoaderService;
        private readonly IFileMonitorService fileMonitorService;
        private List<string> changesDuringInterval = new List<string>();
 
        public Form1()
        {
            InitializeComponent();
            fileLoaderService = new FileLoaderService();
            fileMonitorService = new FileMonitorService(fileLoaderService, OnFileChanged, Form1.fileMon);  
        }
        private void InitializeIntervalTimer()
        {
            timer2.Interval = Convert.ToInt32(numFreq.Value * 1000);
            timer2.Tick += timer2_Tick;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtContent.Clear();
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer2.Stop();
            fileMonitorService.StopMonitoring();
        }

        private void chcRecursive_CheckedChanged(object sender, EventArgs e)
        {
            fileMonitorService.IncludeSubdirectories(chcRecursive.Checked);
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (folderB.ShowDialog() == DialogResult.OK)
            {
                txtFolderpath.Text = folderB.SelectedPath;
                fileMonitorService.SetPath(txtFolderpath.Text);
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFolderpath.Text))
            {
                MessageBox.Show("Please select a folder first.");
                return;
            }
            InitializeIntervalTimer();
            changesDuringInterval.Clear();
            fileMonitorService.StartMonitoring();
            timer2.Start();
        }

        private void txtFolderpath_TextChanged(object sender, EventArgs e)
        {
            chcRecursive.Enabled = !string.IsNullOrEmpty(txtFolderpath.Text);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            foreach (string change in changesDuringInterval)
            {
                txtContent.AppendText(change + Environment.NewLine);
            }

            changesDuringInterval.Clear();

            if (!string.IsNullOrEmpty(fileMonitorService.LastEventFileName))
            {
                var data = fileLoaderService.LoadData(fileMonitorService.LastEventFileName);
                DataTable dataTable = ConvertToDataTable(data);
                dataGridView1.DataSource = dataTable;
            }       
        }

        private void OnFileChanged(string change)
        {
            changesDuringInterval.Add(change);
        }

        private DataTable ConvertToDataTable(List<TradeData> data)
        {
            var dataTable = new DataTable();

            dataTable.Columns.Add("Date", typeof(DateTime));
            dataTable.Columns.Add("Open", typeof(decimal));
            dataTable.Columns.Add("High", typeof(decimal));
            dataTable.Columns.Add("Low", typeof(decimal));
            dataTable.Columns.Add("Close", typeof(decimal));
            dataTable.Columns.Add("Volume", typeof(int));

            foreach (var item in data)
            {
                dataTable.Rows.Add(item.Date, item.Open, item.High, item.Low, item.Close, item.Volume);
            }

            return dataTable;
        }

    }
}
