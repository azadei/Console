using demo_1.Models;
using System;
using System.Linq;

namespace demo_1.Services
{
    public class MenuService
    {
        private static StudentService studentService = new StudentService();

        public static void MenuShowStudents()
        {
            var students = studentService.GetStudents();

            if(students.Count == 0)
            {
                Console.WriteLine("No students yet.");
                return;
            }

            foreach (var student in students)
            {
                Console.WriteLine($"Id: {student.Id} | Name: {student.Name} | Surname: {student.Surname} | Grade: {student.Grade}");
            }
        }

        public static void MenuAddStudent()
        {
            try
            {
                Console.WriteLine("Enter name:");
                string name = Console.ReadLine();

                Console.WriteLine("Enter surname:");
                string surname = Console.ReadLine();

                Console.WriteLine("Enter grade:");
                double grade = double.Parse(Console.ReadLine());

                studentService.AddStudent(name, surname, grade);

                Console.WriteLine("Added student successfuly!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Oops, error. {ex.Message}");
            }
        }

        public static void MenuUpdateStudent()
        {
            // userdan id isteyin

            // teze name
            // teze surname
            // teze grade


            // hemin id-da olub olmayan useri tapin

            // yoxdursa exception

            // varsa onu chixardin ve onun name-ni, surname-ni, grade-ni gonderilen deyerlere menimsedin



            Console.WriteLine("Enter Student Id:");
            int id=int.Parse(Console.ReadLine());



        }

        public static void MenuRemoveStudent()
        {
            try
            {
                Console.WriteLine("Enter student's ID:");
                int id = int.Parse(Console.ReadLine());

                studentService.RemoveStudent(id);

                Console.WriteLine("Deleted student successfuly!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Oops, error. {ex.Message}");
            }
        }

        public static void MenuFindStudentByName()
        // search by name


        // if multiple show multiple
        {
            try
            {
                Console.WriteLine("Enter student's name to search:");
                string searchName = Console.ReadLine();

                var students = studentService.GetStudents();

                var matchingStudents = students.Where(student =>
                    student.Name.Equals(searchName, StringComparison.OrdinalIgnoreCase)).ToList();

                if (matchingStudents.Count == 0)
                {
                    Console.WriteLine("No students found with the given name.");
                }
                else
                {
                    Console.WriteLine($"Found {matchingStudents.Count} student(s) with the name '{searchName}':");
                    foreach (var student in matchingStudents)
                    {
                        Console.WriteLine($"Id: {student.Id} | Name: {student.Name} | Surname: {student.Surname} | Grade: {student.Grade}");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Oops, error. {ex.Message}");
            }
        }
    }
}           
    


