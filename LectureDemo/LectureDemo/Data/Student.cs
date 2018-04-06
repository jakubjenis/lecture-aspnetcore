using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace LectureDemo.Data
{
    public class Student
    {
        public int Id { get; set; }
        public string Contact { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(20)]
        public string LastName { get; set; }
        public Subject FavoriteSubject { get; set; }
    }
}