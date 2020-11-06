using ExamTimetableModel;
using System;
using System.Collections.Generic;
using System.Linq; 
using System.Runtime.InteropServices;

namespace ExamTimetableBusiness
{
    public class CRUDManager
    {
        public Student student { get; set;  }
        public Student SelectedStudent { get; set;  }

        public Subjects subject { get; set;  }
        public Subjects SelectedSubject { get; set;  }

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

        public void setSelectedStudent(object selectedStudent)
        {
            selectedStudent = (Student)selectedStudent; 
        }

        public void setSelectedSubject(object selectedSubject)
        {
            SelectedSubject = (Subjects)selectedSubject; 
        }

        public List<Subjects> RetrieveAllSubjects()
        {
            using (var db = new ExamTimetableContext())
            {
                return db.Subjects.ToList(); 
            }
        }

        public List<SubjectModules> RetrieveAllModules()
        {
            using (var db = new ExamTimetableContext())
            {
                return db.SubjectModules.Where(m => m.Subject == SelectedSubject).ToList();
            }
        }
        public List<Exam> RetrieveAllExam()
        {
            using (var db = new ExamTimetableContext())
            {
                return db.Exam.Where(E => E.SubjectModules == SelectedSubject).ToList(); 
            }
        }

        public void DeleteStudent()
        {
            using (var db = new ExamTimetableContext())
            {
                db.Student.RemoveRange(SelectedStudent);
                db.SaveChanges(); 
            }
        }

        public void UpdateStudent(int studentID , string firstName, string lastName, DateTime DOB, int year, string studentClass, string city)
        {
            using (var db = new ExamTimetableContext())
            {
                SelectedStudent = (Student)db.Student.Where(p => p.StudentId == studentID ).FirstOrDefault();
                SelectedStudent.StudentId = studentID;
                SelectedStudent.FirstName = firstName;
                SelectedStudent.LastName = lastName;
                SelectedStudent.DateOfBirth = DOB;
                SelectedStudent.Year = year;
                SelectedStudent.Class = studentClass;
                SelectedStudent.City = city; 
                db.SaveChanges();
            }
        }
    }
}
