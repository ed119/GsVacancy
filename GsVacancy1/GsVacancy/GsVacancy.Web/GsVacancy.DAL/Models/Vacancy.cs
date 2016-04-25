using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Remotion.Linq.Clauses.ResultOperators;

namespace GsVacancy.DAL.Models
{
    public sealed class Vacancy
    {
        private readonly int _serial;

        public Vacancy()
        {
           
        }

        public Vacancy(int serial, string language, string city, string status, string position, string requirements, string description)
        {
           ;
            Serial = serial;
            Language = language;
            City = city;
            Status = status;
            Position = position;
            Requirement = requirements;
            Description = description;
            CreateDateTime = DateTime.UtcNow;
        }

        public int VacancyId { get; set; }

        public int Serial { get; set; }

        public string Language { get; set; }

        public string City { get; set; }

        public string Position { get; set; }

        public string Description { get; set; }

        public string Requirement { get; set; }

        public string Status { get; set; }

        public DateTime CreateDateTime { get; private set; }


        public ICollection<Respond> Responds { get; set; }
    }
}
