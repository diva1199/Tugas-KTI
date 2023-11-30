using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyWebApp.Models;

namespace MyWebApp.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private static List<Student> _students = new List<Student>
        {
            new Student {StudentId = 1, Name = "Diva", Email = "diva@gmail,com", BirthDate = new DateOnly (2001,08,07) },
            new Student {StudentId = 2, Name = "Carinda", Email = "carinda@gmail,com", BirthDate = new DateOnly (1998,01,06) },
            new Student {StudentId = 3, Name = "Caca", Email = "caca@gmail,com", BirthDate = new DateOnly (1996,05,09) },
            new Student {StudentId = 4, Name = "Cica", Email = "cica@gmail,com", BirthDate = new DateOnly (2003,07,15)},
            new Student {StudentId = 5, Name = "Riri", Email = "riri@gmail,com", BirthDate = new DateOnly (2004,06,09)},
            new Student {StudentId = 6, Name = "Rara", Email = "rara@gmail,com", BirthDate = new DateOnly (2001,02,12)},
            new Student {StudentId = 7, Name = "Cici", Email = "cici@gmail,com", BirthDate = new DateOnly (1996,11,05)}
            
        };
        public IEnumerable<Student> GetAll()
        {
            return _students;
        }
        public Student GetById(int id)
        {
            return _students.First(s => s.StudentId == id);
        }
    }
}