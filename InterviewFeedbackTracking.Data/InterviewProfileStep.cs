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
        [Key, Required]
        public int InterviewProfileStepId { get; set; }

        [ForeignKey(nameof(InterviewProfile)), Required]
        public int InterviewProfileId { get; set; }

        public virtual InterviewProfile InterviewProfile { get; set; }

        [Required]
        public InterviewType TypeOfInterview { get; set; }

        [Required]
        public string Details { get; set; }

    }
}
