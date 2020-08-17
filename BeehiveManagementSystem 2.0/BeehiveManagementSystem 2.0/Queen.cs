using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeehiveManagementSystem
{
    class Queen : Bee
    {
        private Worker[] workers;
        private int shiftNumber = 0;
        public Queen(Worker[] workers, double weightMg)
        : base(weightMg)
        {
            this.workers = workers;
        }
        public bool AssignWork(string job, int numberOfShifts)
        {
            foreach (Worker worker in workers)
                if (worker.DoThisJob(job, numberOfShifts))
                    return true;
            return false;
        }
        public string WorkNextShift()
        {
            double totalHoneyConsumed = HoneyConsumptionRate();
            shiftNumber++;
            totalHoneyConsumed += this.HoneyConsumptionRate();
            string report = "Report for shift # " + shiftNumber + "\r\n";
            for (int i = 0; i < workers.Length; i++)
            {
                totalHoneyConsumed += workers[i].HoneyConsumptionRate();
                if (workers[i].DidYouFinish())
                    report += "Worker #" + (i + 1) + " finished the job\r\n";
                if (String.IsNullOrEmpty(workers[i].CurentJob))
                    report += "Worker #" + (i + 1) + " is not working\r\n";
                else
                    if (workers[i].ShiftsLeft > 0)
                    report += "Worker #" + (i + 1) + " is doing '" + workers[i].CurentJob + "' for " 
                        + workers[i].ShiftsLeft + " more shifts\r\n";
                    else
                    report += "Worker #" + (i + 1) + " will be done with '" + workers[i].CurentJob + " after this shift\r\n";
            }
            report += "Total honey consumed for the shift:" + totalHoneyConsumed +" units";
            return report;
        }
    }
}
