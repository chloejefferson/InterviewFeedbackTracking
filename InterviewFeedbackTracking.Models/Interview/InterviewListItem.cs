using InterviewFeedbackTracking.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewFeedbackTracking.Models.Interview
{
    public class InterviewListItem
    {
        public string CompanyName { get; set; }

        public DateTime DateOfInterview { get; set; }

        public InterviewType TypeOfInterview { get; set; }

        public string Comment { get; set; }

        public int Rating { get; set; }
    }
}
