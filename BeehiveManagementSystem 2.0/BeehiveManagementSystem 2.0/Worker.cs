using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeehiveManagementSystem
{
    class Worker : Bee
    {
        const double honeyConsumptionPerShift = .65;
        private string[] jobsICanDo;
        private int shiftsToWork;
        private int shiftsWorked;
        public Worker(string[] jobsICanDo, double weightMg)
            : base(weightMg)
        {
            this.jobsICanDo = jobsICanDo;
        }
        public int ShiftsLeft
        {
            get { return shiftsToWork - shiftsWorked; }
        }
        private string currentJob = "";
        public string CurentJob
        {
            get { return currentJob; }
        }
        public bool DoThisJob(string job, int numberOfShifts)
        {
            if (!String.IsNullOrEmpty(currentJob))
                return false;

            foreach (string iJob in jobsICanDo)
                if (iJob == job)
                {
                    currentJob = job;
                    this.shiftsToWork = numberOfShifts;
                    shiftsWorked = 0;
                    return true;
                }
                return false;
        }
        public bool DidYouFinish()
        {
            if (String.IsNullOrEmpty(currentJob))
                return false;
            shiftsWorked++;
            if (shiftsWorked > shiftsToWork)
            {
                shiftsWorked = 0;
                shiftsToWork = 0;
                currentJob = "";
                return true;
            }
            else
                return false;
        }
        public override double HoneyConsumptionRate()
        {
            double totalHoneyConsumed = base.HoneyConsumptionRate();
            totalHoneyConsumed += this.shiftsWorked * honeyConsumptionPerShift;
            return totalHoneyConsumed;
        }
    }
}
