using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.Core.Models
{
    public class BankAccount
    {
        public long Id { get; set; }
        public int DataState { get; set; }
        public string BankName { get; set; }
        public string BankAddress { get; set; }
        public long AccountNumber { get; set; }
    }
}
