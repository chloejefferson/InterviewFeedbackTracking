using InterviewFeedbackTracking.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewFeedbackTracking.Models.Interview
{
    public class InterviewDetail
    {
        public int InterviewId { get; set; }

        public string Company { get; set; } //added company as string here instead of virtual to pull only the string value from the virtual object

        public string Interviewer { get; set; }

        public string IntervieweeGuid { get; set; } //unsure if this should be of data type guid

        public DateTime CreatedDate { get; set; }

        public DateTime DateOfInterview { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public InterviewType TypeOfInterview { get; set; }

        public LevelEnum InterviewLevel { get; set; }

        public string Comment { get; set; }

        public int Rating { get; set; }

    }
}
