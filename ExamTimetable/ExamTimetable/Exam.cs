using System;
using System.Collections.Generic;

namespace ExamTimetableModel
{
    public partial class Exam
    {
        public Exam()
        {
            SubjectModules = new HashSet<SubjectModules>();
        }

        public int ExamId { get; set; }
        public DateTime? ExamDate { get; set; }
        public double DurationHrs { get; set; }
        public string ExamRoom { get; set; }
        public string AdditionalInfo { get; set; }

          public virtual ICollection<SubjectModules> SubjectModules { get; set; }
    }
}
