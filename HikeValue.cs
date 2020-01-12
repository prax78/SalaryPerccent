using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management.Automation;

namespace HikeValue
{
    [Cmdlet(VerbsCommon.Show, "HikePercentToValue")]

    public class HikeValue:PSCmdlet
    {

        [Parameter(Mandatory =true,Position =0)]
        public double DesiredHikePercent { get; set; }
        
        [Parameter(Mandatory =true)]
        public double CurrentSalary { get; set; }


        protected override void ProcessRecord()
        {
            var getHike = CurrentSalary*DesiredHikePercent / 100;
            var result = getHike + CurrentSalary;
            WriteObject($"Your Increased Salry after a hike of {DesiredHikePercent} % Would be {result}");

        }


    }



}