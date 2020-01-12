using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management.Automation;

namespace SalaryPerccent
{
    [Cmdlet(VerbsCommon.Show, "MySalaryIncreasePercentage")]


    public class SalaryPerccent : PSCmdlet
    {
        [Parameter(Mandatory = true, Position = 0, HelpMessage = "Enter Previous Salary to compute Salary Hike in Percentage")]
        public double  PrevSalary { get; set; }

        [Parameter(Mandatory = true, HelpMessage = "Enter Offered/Given Salary to compute Salary Hike in Percentage")]
        public double  NewSalary { get; set; }

        protected override void ProcessRecord()
        {

            double result = (NewSalary - PrevSalary )/ PrevSalary * 100;
            var Cresult = result <= 10 ? "Your Salary Hike Sucks!! it is only " + result : result > 10 && result <= 25 ? "Your Salary Hike is Decent!!, it is " + result : result > 25 ? "Your Salary Hike is AweSome, it is " + result : "No Fun!!";
            WriteObject(Cresult);


        }

    }
}
