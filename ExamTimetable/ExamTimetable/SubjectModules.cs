using System;
using System.Collections.Generic;

namespace ExamTimetableModel
{
    public partial class SubjectModules
    {
        public int ModuleId { get; set; }
        public int SubjectId { get; set; }
        public int? ExamId { get; set; }

        public virtual Exam Exam { get; set; }
        public virtual Subjects Subject { get; set; }
    }
}
