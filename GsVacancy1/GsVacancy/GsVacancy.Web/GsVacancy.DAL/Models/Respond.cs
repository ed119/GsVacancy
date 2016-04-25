using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GsVacancy.DAL.Models
{
    public sealed class Respond
    {
        public int RespondId { get; set; }

        public string Title { get; set; }

        public string Status { get; set; }



        public int  ApplicantId { get; set; }
        public Applicant Applicant { get; set; }

        public Vacancy Vacancy { get; set; }

    }
}
