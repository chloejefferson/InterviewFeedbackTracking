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
        [Key]
        public int CompanyId { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public string Website { get; set; }

        public IndustryEnum Industry { get; set; }

        public virtual List<Interview> Interviews { get; set; } = new List<Interview>();
            
        public virtual List<InterviewProfile> InterviewProfiles { get; set; } = new List<InterviewProfile>();

        public DateTime CreatedDate { get; set; }

        public DateTime? ModifiedDate { get; set; }
    }
}
