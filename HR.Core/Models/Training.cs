using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.Core.Models
{
    public class Training
    {
        public int Id { get; set; }
        public int DataState { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public DateTime DateOfPass { get; set; }

    }
}
