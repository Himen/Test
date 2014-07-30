using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.Core.Models
{
    public class OrganiziationalUnit
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public long IdDirector { get; set; }
}
