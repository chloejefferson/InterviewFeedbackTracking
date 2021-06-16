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
        FinalScreen
    }
    public class Interview
    {
        [Key, Required]
        public int InterviewId { get; set; }

        [ForeignKey(nameof(Company)), Required]
        public int CompanyId { get; set; }

        public virtual Company Company { get; set; }

        [Required]
        public string Interviewer { get; set; }

        [Required]
        public string IntervieweeGuid { get; set; } 

        [ForeignKey("IntervieweeGuid")]
        public ApplicationUser Interviewee { get; set; }

        [Required]
        public DateTime CreatedDate { get; set; }

        [Required]
        public DateTime DateOfInterview { get; set; }

        public DateTime? ModifiedDate { get; set; }

        [Required]
        public InterviewType TypeOfInterview { get; set; }

        [Required]
        public LevelEnum InterviewLevel { get; set; }

        [Required]
        public string Comment { get; set; }

        [Required]
        public int Rating { get; set; }
    }
}
