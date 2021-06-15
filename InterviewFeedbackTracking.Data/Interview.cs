using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewFeedbackTracking.Data
{
    public enum InterviewType
    {
        PhoneScreen = 1,
        TechScreen,
        CultureScreen,
        Other
    }
    public class Interview
    {
        [Key]
        public int InterviewId { get; set; }

        [ForeignKey(nameof(Company))]
        public int CompanyId { get; set; }

        public virtual Company Company { get; set; }

        public string Interviewer { get; set; }

        public Guid Interviewee { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime DateOfInterview { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public InterviewType TypeOfInterview { get; set; }

        public string Comment { get; set; }

        public int Rating { get; set; }
    }
}
