using InterviewFeedbackTracking.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewFeedbackTracking.Models.Company
{
    public class CompanyListItem
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public IndustryEnum Industry { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public string State { get; set; }

        [Required]
        public string Website { get; set; }
    }
}
