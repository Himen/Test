using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.Core.Models
{
    public class CoursMaterials
    {
        public long Id { get; set; }
        public string Name { get; set; }
        /// <summary>
        /// Mozna potem na enuma zmienic
        /// </summary>
        public string TypeOfCourse { get; set; } //np. Programowanie C#
        public string Description { get; set; }
        public Document Document { get; set; }
    }
}
