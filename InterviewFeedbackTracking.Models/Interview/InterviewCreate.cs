using InterviewFeedbackTracking.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewFeedbackTracking.Models.Interview
{
    public class InterviewCreate
    {
        [Required]
        public int InterviewId { get; set; }
        
        [Required]
        public int CompanyId { get; set; }

        [Required]
        public string Interviewer { get; set; }

        //should there be a field for the interviewee guid?

        [Required]
        public DateTime DateOfInterview { get; set; }

        [Required]
        public DateTime CreatedDate { get; set; }

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
