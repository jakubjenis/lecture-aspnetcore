using System.Collections.Generic;
using System.Data.SqlClient;

namespace LectureDemo.Data
{
    public class StudentRepository
    {
        public List<Student> GetStudents()
        {
            var students = new List<Student>();
            using (var conn = new SqlConnection("Server=(localdb)\\MSSQLLocalDB;Database=LectureDemo;Trusted_Connection=True;MultipleActiveResultSets=true"))
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "select Id, FirstName, LastName from Students";
                var rdr = cmd.ExecuteReader();


                while (rdr.Read())
                {
                    students.Add(new Student
                    {
                        Id = rdr.GetInt32(0),
                        FirstName = rdr.GetString(1),
                        LastName = rdr.GetString(2),
                        FavoriteSubject = null
                    });
                }
                rdr.Close();
            }

            return students;
        }


        //public List<Student> GetStudentsByEf()
        //{
        //    var students = _lectureDbContext.Students.Where(o => o.LastName != "hrasko").ToList();
        //    return students;
        //}


        //var math = new Subject
        //{
        //    Name = "Math"
        //};

        //var english = new Subject
        //{
        //    Name = "English"
        //};

        //var students = new List<Student>
        //{
        //    new Student
        //    {
        //        FirstName = "Janko",
        //        LastName = "Hrasko",
        //        FavoriteSubject = math
        //    },
        //    new Student
        //    {
        //        FirstName = "Ferdo",
        //        LastName = "Mravec",
        //        FavoriteSubject = english
        //    }
        //};
    }
}
