using ExamTimetableModel;
using System;
using System.Linq; 
using System.Runtime.InteropServices;

namespace ExamTimetableBusiness
{
    public class CRUDManager
    {
        public Student student { get; set;  }

        public Subjects subject { get; set;  }

        public SubjectModules subjectModules { get; set;  }

        public void newStudent(string firstName, string lastName, DateTime DOB,  int year,  string studentClass , string city )
        {
            var newStudent = new Student()
            {
                FirstName = firstName,  LastName = lastName, DateOfBirth = DOB, 
                Year = year,
                Class = studentClass,
                City = city
            };
            using (var db = new ExamTimetableContext())
            {
                db.Student.Add(newStudent);
                db.SaveChanges(); 
            }
        }

        public void newExam( DateTime DateOfExam, double duration, string examRoom, string additionalInfo)
        {
            var newExam = new Exam()
            {
                ExamDate = DateOfExam, DurationHrs = duration, ExamRoom = examRoom, AdditionalInfo = additionalInfo
            };
            using (var db = new ExamTimetableContext())
            {
                db.Exam.Add(newExam);
                db.SaveChanges();
            }
        }
    }
}
