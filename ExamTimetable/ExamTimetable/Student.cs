using System;
using System.Collections.Generic;

namespace ExamTimetableModel
{
    public partial class Student
    {
        public Student()
        {
            Subjects = new HashSet<Subjects>();
        }

        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public int Year { get; set; }
        public string Class { get; set; }
        public string City { get; set; }

        public virtual ICollection<Subjects> Subjects { get; set; }
    }
}
