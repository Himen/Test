using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.Core.Models
{
    /// <summary>
    /// To moze byc pracownik jak i rowniez kandydat
    /// </summary>
    public class Person
    {
        public long Id { get; set; }
        public long? DirectorId { get; set; }
        public int DataState { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string Street { get; set; }
        public string BuildingNumber { get; set; }
        public string ApartmentNumber { get; set; }
        public string NIP { get; set; }
        public string IDCard { get; set; }

        /// <summary>
        /// Tytuł naukowy
        /// </summary>
        public string Education { get; set; }

        /// <summary>
        /// Specializacja - np. Programista ASP. NET
        /// </summary>
        public string Profession { get; set; }

        //jeszcze relacje z innymi tabelami
    }
}
