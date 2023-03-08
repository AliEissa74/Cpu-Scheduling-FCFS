using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cpu_Scheduling_Project
{
    public partial class MainForm : Form
    {
        private Data[] alldata;
        struct Data
        {
            public string Name;
            public int AT, BT, WT, start_time, finish_time,N;
        }
        public MainForm()
        {
            InitializeComponent();
            alldata = new Data[0];
            listview();
        }
        //Add columns inside listview (define columns)
        private void listview()
        {
            listView1.Clear();
            listView1.View = View.Details;
            listView1.Columns.Add("Processes", 70);
            listView1.Columns.Add("Arrival Time", 70);
            listView1.Columns.Add("Burst Time", 70);
            listView1.Columns.Add("Waiting Time", 80);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Random is working as random number generator
            Random R = new Random();
            int AT, BT;
            if (textp.Text == "" || textp.Text == "0")
                MessageBox.Show("Input Number Of Processes !");
            else
            {
                for (int i = 0; i < int.Parse(textp.Text); i++)
                {
                    Array.Resize(ref alldata, alldata.Length + 1);
                    // her we choose Min and Max range of numbers that can appear for Arrival time,Burst time
                    AT = R.Next(0, 20);         //Arrival time from 0 to 20
                    BT = R.Next(5, 40);         //Burst time from 5 to 40
                    listView1.Items.Add(alldata[alldata.GetUpperBound(0)].Name = "P" + (i + 1));
                    listView1.Items[listView1.Items.Count - 1].SubItems.Add(Convert.ToString((alldata[alldata.GetUpperBound(0)].AT = AT)));
                    listView1.Items[listView1.Items.Count - 1].SubItems.Add(Convert.ToString((alldata[alldata.GetUpperBound(0)].BT = BT)));
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonfcfs_Click(object sender, EventArgs e)
        {
            listview();
            float totalw = 0;
            float totalb = 0;
            int S;
            int WT;
            string N;

            for (int i = 0; i < alldata.Length; i++)
            {
                for (int x = 0; x < i; x++)
                {
                    if (alldata[i].AT < alldata[x].AT)
                    {
                        WT = alldata[x].AT;
                        alldata[x].AT = alldata[i].AT;
                        alldata[i].AT = WT;
                        N = alldata[x].Name;
                        alldata[x].Name = alldata[i].Name;
                        alldata[i].Name = N;
                        S = alldata[x].BT;
                        alldata[x].BT = alldata[i].BT;
                        alldata[i].BT = S;

                    }
                }
            }
            for (int j = 0; j < alldata.Length; j++)
            {
                if (j > 0)
                {
                    if (alldata[j].AT <= alldata[j - 1].finish_time)
                    {
                        alldata[j].start_time = alldata[j - 1].finish_time;
                    }
                    else
                    {
                        alldata[j].start_time = alldata[j].AT;
                    }
                }
                else
                    alldata[j].start_time = alldata[j].AT;

                alldata[j].finish_time = alldata[j].start_time + alldata[j].BT;
                alldata[j].WT = alldata[j].start_time - alldata[j].AT;
                totalw += alldata[j].WT;
                totalb += alldata[j].BT;
            }
            

            for (int r = 0; r < alldata.Length; r++)
            {
                listView1.Items.Add(alldata[r].Name);
                listView1.Items[r].SubItems.Add(alldata[r].AT.ToString());
                listView1.Items[r].SubItems.Add(alldata[r].BT.ToString());
                listView1.Items[r].SubItems.Add(alldata[r].WT.ToString());
            }

            // (get Get avg Burst time)
            textb.Text = (totalb / alldata.Length).ToString();
            // Get avg waiting time
            textw.Text = (totalw / alldata.Length).ToString();

        }
        private void buttonReset_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void textw_TextChanged(object sender, EventArgs e)
        {
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void mysign_Click(object sender, EventArgs e)
        {

        }
    }
}
