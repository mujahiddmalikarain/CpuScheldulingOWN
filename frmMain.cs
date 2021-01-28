using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CpuScheduling
{
    public partial class frmMain : Form
    {
        Process p;
        LinkedList<Process> processes;
        public frmMain()
        {
            InitializeComponent();  
            processes = new LinkedList<Process>();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                p = new Process();
                p.id = Convert.ToInt32(idTextBox.Text);
                p.name = nameTextBox.Text;
                p.bustTime = Convert.ToInt32(timeTextBox.Text);
                p.io = Convert.ToInt32(ioTextBox.Text);

                string[] row = { p.id.ToString(), p.name, p.bustTime.ToString(), p.io.ToString(), "", "", "", p.status };
                dataGridView.Rows.Add(row);
                processes.AddLast(p);
            }
            catch(Exception)
            {
                MessageBox.Show("Error!");
            }
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {

        }

        private void exeBtn_Click(object sender, EventArgs e)
        {
            Process[] processQueue = processes.ToArray();

            int quantum = (int)quantumBox.Value;

            RRAlgo rrObj = new RRAlgo(ref dataGridView, ref avgWtLabel, ref avgTatLabel);

            rrObj.roundRobinInit(ref processQueue, quantum);

        }
    }
}
