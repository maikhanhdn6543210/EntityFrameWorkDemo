using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStudent
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new DataStudentsEntities();
//            try
//            {
                
//                db.Enrollments.Add(new Enrollment()
//                {
//                    EnrollmentId = 1,
//                    CourseId = 1,
//                    StudentId = 1,
//                    Grande = 2
//                });

//                db.Courses.Add(new Course()
//                {
//
//                    CourseId = 1,
//                    Title = "dotnet",
//                    Credits = 12,
//                });

//                db.Students.Add(new Student
//                {
//                    Id = 1,
//                    Lastname = "Khanh",
//                    FirstMidName = "Mai",
//                    EnrollmentDate = DateTime.Now
//                });
//
//
//                db.Students.Add(new Student
//                {
//                    Id = 2,
//                    Lastname = "Trung",
//                    FirstMidName = "Phuoc",
//                    EnrollmentDate = DateTime.Now
//                });
//
//                Console.WriteLine("Calling SaveChanges.");
//                db.SaveChanges();
//            }
//            catch (DbEntityValidationException e)
//            {
//                foreach (var eve in e.EntityValidationErrors)
//                {
//                    Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
//                        eve.Entry.Entity.GetType().Name, eve.Entry.State);
//                    foreach (var ve in eve.ValidationErrors)
//                    {
//                        Console.WriteLine("- Property: \"{0}\", Value: \"{1}\", Error: \"{2}\"",
//                            ve.PropertyName,
//                            eve.Entry.CurrentValues.GetValue<object>(ve.PropertyName),
//                            ve.ErrorMessage);
//                    }
//                }
//            }

            var students = (from student in db.Students where student.Id == 1 select student).ToArray();

            foreach (var student in students)
            {
                Console.WriteLine(student.Lastname);
            }

            Console.ReadLine();

        }
    }
}
