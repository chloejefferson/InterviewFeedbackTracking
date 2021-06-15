using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewFeedbackTracking.Data
{
    public class InterviewProfileStep
    {
        [Key]
        public int InterviewProfileStepId { get; set; }

        [ForeignKey(nameof(InterviewProfile))]
        public int InterviewProfileId { get; set; }

        public virtual InterviewProfile InterviewProfile { get; set; }

        public InterviewType TypeOfInterview { get; set; }

        public string Details { get; set; }

    }
}
