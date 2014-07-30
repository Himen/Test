﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HR.Core.Enums;

namespace HR.Core.Models
{
    /// <summary>
    /// Opisuje dni wolne pracownika. Musi byc porownywane z WorkRegistry
    /// </summary>
    public class Vacation
    {
        public long Id { get; set; }
        public long IdPerson { get; set; }
        /// <summary>
        /// Pracodawca musi zatwierdzic urlop pracownika
        /// </summary>
        public int DataState { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        
        /// <summary>
        /// Opisuje powod: urlop, zwolnienie
        /// </summary>
        public VacationType MyProperty { get; set; }
        public string Description { get; set; }
        public virtual Document Document { get; set; }
    }
}
