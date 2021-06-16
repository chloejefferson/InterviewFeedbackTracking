using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewFeedbackTracking.Data
{
    public enum IndustryEnum
    {
        Tech = 1,
        Financial,
        Healthcare,
        Agriculture,
        Construction,
        Other
    }
    public class Company
    {
        [Key, Required]
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

        public DateTime? ModifiedDate { get; set; }

        [Required]
        public IndustryEnum Industry { get; set; }

        public virtual List<Interview> Interviews { get; set; } = new List<Interview>();
            
        public virtual List<InterviewProfile> InterviewProfiles { get; set; } = new List<InterviewProfile>();

    }
}
