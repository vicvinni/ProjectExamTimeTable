using System;
using System.Collections.Generic;

namespace ExamTimetableModel
{
    public partial class Subjects
    {
        public Subjects()
        {
            SubjectModules = new HashSet<SubjectModules>();
        }

        public int SubjectId { get; set; }
        public string ModuleId { get; set; }
        public int? StudentId { get; set; }

        public virtual Student Student { get; set; }
        public virtual ICollection<SubjectModules> SubjectModules { get; set; }
    }
}
