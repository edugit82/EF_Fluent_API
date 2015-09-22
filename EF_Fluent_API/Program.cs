using EF_Fluent_API.Model.Mapping.Context;
using EF_Fluent_API.Model.Entity;
using System.Data.SqlClient;
using System.Linq;
using System;
using System.Data.Entity;

namespace EF_Fluent_API
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = AppDomain.CurrentDomain.BaseDirectory.Replace(@"\bin\Debug\", "");
            AppDomain.CurrentDomain.SetData("DataDirectory", path);

            //Recria banco, em caso de mudança
            Database.SetInitializer<SchoolEntities>(new DropCreateDatabaseIfModelChanges<SchoolEntities>());

            using (var SchoolEntities = new SchoolEntities()) 
            {
                var department = new DepartmentModel()
                {
                    Name = "Departament",
                    Budget = 10000,
                    StartDate = DateTime.Now
                };

                var course = new CourseModel()
                {
                    Title = "Title",
                    Credits = 10
                };

                var instrutor = new InstructorModel()
                {
                    FirstName = "FirstName",
                    LastName = "LastName",
                    HireDate = DateTime.Now
                };

                var office = new OfficeAssignmentModel()
                {
                    Location = "São Paulo",
                    Timestamp = BitConverter.GetBytes(DateTime.Now.ToOADate())
                };

                using (var transaction = SchoolEntities.Database.BeginTransaction())
                {

                    try
                    {

                        SchoolEntities.Departments.Add(department);
                        SchoolEntities.SaveChanges();

                        course.DepartmentID = SchoolEntities.Departments.ToList().Last().DepartmentID;
                        SchoolEntities.Courses.Add(course);
                        SchoolEntities.SaveChanges();

                        SchoolEntities.Instructors.Add(instrutor);
                        SchoolEntities.SaveChanges();

                        office.InstructorID = SchoolEntities.Instructors.ToList().Last().InstructorID;
                        SchoolEntities.OfficeAssignments.Add(office);
                        SchoolEntities.SaveChanges();

                        var loffice = SchoolEntities.OfficeAssignments.ToList();
                        SchoolEntities.OfficeAssignments.RemoveRange(loffice);
                        SchoolEntities.SaveChanges();

                        var linstrutor = SchoolEntities.Instructors.ToList();
                        SchoolEntities.Instructors.RemoveRange(linstrutor);
                        SchoolEntities.SaveChanges();

                        var lcourse = SchoolEntities.Courses.ToList();
                        SchoolEntities.Courses.RemoveRange(lcourse);
                        SchoolEntities.SaveChanges();

                        var ldepart = SchoolEntities.Departments.ToList();
                        SchoolEntities.Departments.RemoveRange(ldepart);
                        SchoolEntities.SaveChanges();

                        transaction.Commit();
                    }
                    catch
                    {
                        transaction.Rollback();
                    }
                }
            }
        }
    }
}
