using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewFeedbackTracking.Data
{
    public enum LevelEnum
    {
        Entry = 1,
        Associate,
        Senior
    }

    public class InterviewProfile
    {
        [Key]
        public int InterviewProfileId { get; set; }

        [ForeignKey(nameof(Company))]
        public int CompanyId { get; set; }

        public virtual Company Company { get; set; }

        public LevelEnum Level { get; set; }

        public virtual List<InterviewProfileStep> InterviewProfileSteps { get; set; } = new List<InterviewProfileStep>();
    }
}
