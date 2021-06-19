using InterviewFeedbackTracking.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewFeedbackTracking.Models.Interview
{
    public class InterviewEdit
    {
        public int InterviewId { get; set; }

        public string CompanyName { get; set; } //added company as string here instead of virtual to pull only the string value from the virtual object

        public string Interviewer { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime DateOfInterview { get; set; }

        [Required]
        public DateTime? ModifiedDate { get; set; }

        public InterviewType TypeOfInterview { get; set; }

        public LevelEnum InterviewLevel { get; set; }

        public string Comment { get; set; }

        public int Rating { get; set; }
    }
}
