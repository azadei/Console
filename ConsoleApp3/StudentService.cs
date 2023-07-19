using System;
using System.Collections.Generic;
using demo_1.Models;
using System.Linq;

namespace demo_1.Services
{
    public class StudentService
    {
        private List<Student> students;

        public StudentService()
        {
            students = new();
        }

        public List<Student> GetStudents()
        {
            return students;
        }

        public void AddStudent(string name, string surname, double grade)
        {
            // check name,surname for null


            // check grade for negative values

            // if invalid = exception

            var student = new Student(name, surname, grade);

            students.Add(student);
        }

        public void RemoveStudent(int id)
        {
            // check id for negative value

            // if invalid = exception

            var existingStudent = students.FirstOrDefault(x => x.Id == id);

            if (existingStudent == null) throw new Exception("Not found!");

            students = students.Where(x => x.Id != id).ToList();
        }


    }   
}
         



