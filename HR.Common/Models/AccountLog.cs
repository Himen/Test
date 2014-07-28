using System;
using HR.Common.Enums;

namespace HR.Common.Models
{
    public class AccountLog
    {
        public long Id { get; set; }

        /// <summary>
        /// Słowny opis co się stało. "Użytkownik Jacek próbował się zalogować"
        /// </summary>
        public string Action { get; set; }
        public ActionType ActionType { get; set; }
        public string ActionDescription { get; set; }
        public DateTime StartDate { get; set; }

        /// <summary>
        /// Mozliwe ze nie będzie potrzebne
        /// </summary>
        public DateTime? EndDate { get; set; }

#warning odniesienie do Account
    }
}
