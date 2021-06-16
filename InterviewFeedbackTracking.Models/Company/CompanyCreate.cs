using InterviewFeedbackTracking.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewFeedbackTracking.Models.Company
{
    public class CompanyCreate
    {
        [Required]
        public int CompanyId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string StreetAddress { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public string State { get; set; }

        [Required]
        public string Zip { get; set; }

        [Required]
        public string Website { get; set; }

        [Required]
        public DateTime CreatedDate { get; set; }

        [Required]
        public IndustryEnum Industry { get; set; }

    }
}
