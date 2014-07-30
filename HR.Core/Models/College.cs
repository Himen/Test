using HR.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.Core.Models
{
    public class College
    {
        public int Id { get; set; }
        public int IdPerson { get; set; }
        public string Name { get; set; }
        public string FieldOfStudy { get; set; }
        public AcademicTitleType AcademicTitle { get; set; }
        public string TitleResearchSearch { get; set; }
        public string Progres { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
