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
        [Key, Required]
        public int InterviewProfileId { get; set; }

        [ForeignKey(nameof(Company)), Required]
        public int CompanyId { get; set; }

        [Required]
        public virtual Company Company { get; set; }

        [Required]
        public LevelEnum Level { get; set; }

        public virtual List<InterviewProfileStep> InterviewProfileSteps { get; set; } = new List<InterviewProfileStep>();
    }
}
