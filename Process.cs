using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CpuScheduling
{
    class Process
    {
        public string name { get; set; }
        public int id { get; set; }
        public int bustTime { get; set; }
        public int rem_bustTime { get; set; }
        public int io { get; set; }
        public string status { get; set; }
        public int wt { get; set; }
        public int ct { get; set; }
        public int tat { get; set; }
        

        public Process()
        {
            status = "Ready";
        }
    }
}
