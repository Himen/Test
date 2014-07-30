using HR.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.Core.Models
{
    public class BenefitsProfit
    {
        public long Id { get; set; }
        public long IdEmployment { get; set; }
        public int DataState { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public decimal Benefit { get; set; }
        public BenefitType BenefitType { get; set; }

    }
}
