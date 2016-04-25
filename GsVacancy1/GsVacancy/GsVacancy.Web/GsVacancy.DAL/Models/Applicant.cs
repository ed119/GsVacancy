using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GsVacancy.DAL.Models
{
    public sealed class Applicant
    {
        public int ApplicantId { get; set; }

        public string Email { get; set; }

        public byte[] Resume { get; set; }

        
        public int RespondId { get; set; }
        public Respond Respond { get; set; }

    }
}
