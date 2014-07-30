using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HR.Core.Enums;

namespace HR.Core.Models
{
    public class Employment
    {
        public long Id { get; set; }
        public long IdPerson { get; set; }
        public int DataState { get; set; }
        public string PositionCode { get; set; }
        public string OrganiziationalUnitCode { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public ContractType ContractType { get; set; }

        public EmploymentType EmploymentType { get; set; }

        /// <summary>
        /// Opisuje czy jest 1/2 i 1/3      .. etatu
        /// </summary>
        public string ContractDimmension { get; set; }

    }
}
