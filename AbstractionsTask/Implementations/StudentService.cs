using AbstractionsTask.Core.Models;
using AbstractionsTask.Helpers;
using AbstractionsTask.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionsTask.Implementations
{
    public class StudentService : IService, IStudentService
    {
        private Student[] students = new Student[0];
        public void Create()
        {

            Student student= new Student();

            Console.WriteLine("Please enter student name");
            string name = Console.ReadLine();
            while (!name.CheckLength())
            {
                Console.WriteLine("Name is not valid! Please try again!");
                name = Console.ReadLine();
            }
            student.Name = name;


            Console.WriteLine("Please enter student surname");
            string surname = Console.ReadLine();
            while(!surname.CheckLength())
            {
                Console.WriteLine("Surname is not valid! Please try again!");
                surname = Console.ReadLine();
            }
            student.Surname = surname;    

            Console.WriteLine("Please enter student group number");
            string groupno = Console.ReadLine();
            while (!groupno.CheckLength())
            {
                Console.WriteLine("Group no is not valid! Please try again!");
                groupno = Console.ReadLine();
            }
            student.GroupNo = groupno;

            Array.Resize(ref students, students.Length+1);
            students[students.Length - 1] = student;
        }

        public void Delete()
        {
            Console.WriteLine("Please enter Id number to delete");
            int.TryParse(Console.ReadLine(), out int id);

            for (int i = 0; i < students.Length; i++)
            {
                if (students[i].Id == id)
                {
                    Student student = students[students.Length - 1];
                    students[students.Length - 1] = students[i];
                    students[i] = student;
                    Array.Resize(ref students, students.Length - 1);
                    return; 
                }
              
            }
            Console.WriteLine($"{id} is not found");
            
        }

        public void GetAll()
        {
            foreach (Student student in students)
            {
                Console.WriteLine(student);
            }
        }

        public void GetById()
        {
            Console.WriteLine("Enter id to find a student");
            int id = int.Parse(Console.ReadLine()); 
            foreach (Student student in students)
            {
                if(student.Id == id)
                {
                    Console.WriteLine(student.ToString());
                    return;
                }
            }
        }

        public void Update()
        {
            Console.WriteLine("Please enter Id number to delete");
            int.TryParse(Console.ReadLine(), out int id);

            for (int i = 0; i < students.Length; i++)
            {
                if (students[i].Id == id)
                {

                    Console.WriteLine("Please enter student name");
                    string name = Console.ReadLine();
                    while (!name.CheckLength())
                    {
                        Console.WriteLine("Name is not valid! Please try again!");
                        name = Console.ReadLine();
                    }
                    students[i].Name = name;


                    Console.WriteLine("Please enter student surname");
                    string surname = Console.ReadLine();
                    while (!surname.CheckLength())
                    {
                        Console.WriteLine("Surname is not valid! Please try again!");
                        surname = Console.ReadLine();
                    }
                    students[i].Surname = surname;

                    Console.WriteLine("Please enter student group number");
                    string groupno = Console.ReadLine();
                    while (!groupno.CheckLength())
                    {
                        Console.WriteLine("Group no is not valid! Please try again!");
                        groupno = Console.ReadLine();
                    }
                    students[i].GroupNo = groupno;
                    return;
                }

            }
            Console.WriteLine($"{id} is not found");
        }

       
    }
}
