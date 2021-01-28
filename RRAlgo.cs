using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace CpuScheduling
{
    class RRAlgo
    {
        DataGridView dataGridView;
        Label avgWtLabel, avgTatLabel;

        public RRAlgo(ref DataGridView DGV, ref Label total_wt, ref Label total_tat)
        {
            dataGridView = DGV;
            avgWtLabel = total_wt;
            avgTatLabel = total_tat;
        }

        public void findWaitingTime(Process[] processQueue, int quantum)
        {

            foreach (var process in processQueue)
            {
                process.rem_bustTime = process.bustTime;
                process.ct = 0;
            }

            int t = 0; // Current time 

            // Keep traversing processes in round 
            // robin manner until all of them are 
            // not done. 
            while (true)
            {
                bool done = true;

                // Traverse all processes one by 
                // one repeatedly 
                foreach (var process in processQueue)
                {
                    ioInterupt(process.io);
                    // If burst time of a process 
                    // is greater than 0 then only 
                    // need to process further 
                    if (process.rem_bustTime > 0)
                    {

                        // There is a pending process 
                        done = false;

                        if (process.rem_bustTime > quantum)
                        {
                            // Increase the value of t i.e. 
                            // shows how much time a process 
                            // has been processed 
                            t += quantum;

                            // Decrease the burst_time of  
                            // current process by quantum 
                            process.rem_bustTime -= quantum;
                            process.status = "Waiting";
                        }

                        // If burst time is smaller than 
                        // or equal to quantum. Last cycle 
                        // for this process 
                        else
                        {

                            // Increase the value of t i.e. 
                            // shows how much time a process 
                            // has been processed 
                            t = t + process.rem_bustTime;

                            // Waiting time is current 
                            // time minus time used by  
                            // this process 
                            process.wt = t - process.bustTime;

                            // As the process gets fully  
                            // executed make its remaining 
                            // burst time = 0 
                            process.rem_bustTime = 0;
                            process.ct = t;

                            process.status = "Terminated";
                        }
                    }

                    refreshGrid(dataGridView, processQueue);
                }

               

                // If all processes are done 
                if (done == true)
                    break;
            }
        }

        // Method to calculate turn around time 
        public void findTurnAroundTime(Process[] processQueue)
        {
            // calculating turnaround time by adding 
            // bt[i] + wt[i] 
            foreach (var process in processQueue)
            {
                process.tat = process.bustTime + process.wt;
                refreshGrid(dataGridView, processQueue);
            }
        }

        // Method to calculate average time 
        public void roundRobinInit(ref Process[] processQueue, int quantum)
        {
            int total_wt = 0, total_tat = 0;
            int n = processQueue.Length;

            // Function to find waiting time of 
            // all processes 
            findWaitingTime(processQueue, quantum);

            // Function to find turn around time 
            // for all processes 
            findTurnAroundTime(processQueue);

            // Display processes along with 
            // all details 


            // Calculate total waiting time and total turn 
            // around time 
            foreach (var process in processQueue)
            {
                total_wt = total_wt + process.wt;
                total_tat = total_tat + process.tat;
            }

            avgWtLabel.Text = ((float)total_wt / (float)n).ToString();
            avgTatLabel.Text = ((float)total_tat / (float)n).ToString();
        }

        public void refreshGrid(DataGridView dataGridView, Process[] processQueue)
        {
            dataGridView.Rows.Clear();
            dataGridView.Refresh();

            foreach (var process in processQueue)
            {
                string[] row = { process.id.ToString(), process.name, process.bustTime.ToString(), process.io.ToString(), process.ct.ToString(), process.wt.ToString(), process.tat.ToString(), process.status };
                dataGridView.Rows.Add(row);
            }
        }

        public void ioInterupt(int interupt)
        {
            int milliseconds = interupt * 500;
            System.Windows.Forms.Timer timer1 = new System.Windows.Forms.Timer();
            if (milliseconds == 0 || milliseconds < 0) return;
            timer1.Interval = milliseconds;
            timer1.Enabled = true;
            timer1.Start();
            timer1.Tick += (s, e) =>
            {
                timer1.Enabled = false;
                timer1.Stop();
            };
            while (timer1.Enabled)
            {
                Application.DoEvents();
            }
        }
    }
}
