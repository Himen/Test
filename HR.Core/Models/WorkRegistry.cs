﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.Core.Models
{
    /// <summary>
    /// Umożliwić wielokrotne wychodzenie i wchodzenie.
    /// Przemyslec nadgodziny. Uwzględnic wolne, swieta, urlopy. Kalendarz pracy.
    /// </summary>
    public class WorkRegistry
    {
        public long Id { get; set; }
        public long IdPerson { get; set; }
        public DateTime Date { get; set; }
        public DateTime? DateIn { get; set; }
        public DateTime? DateOut { get; set; }
    }
}
