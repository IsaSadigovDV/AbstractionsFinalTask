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
    public class TeacherService : IService, ITeacherService
    {   
        private Teacher[] teachers = new Teacher[0];
        public void Create()
        {
            Teacher teacher= new Teacher();

            Console.WriteLine("Please enter teacher name");
            string name = Console.ReadLine();
            while (!name.CheckLength())
            {
                Console.WriteLine("Name is not valid! Try again!");
                name = Console.ReadLine();  
            }
            teacher.Name = name;

            Console.WriteLine("Please enter teacher surname");
            string surname = Console.ReadLine();
            while (!surname.CheckLength())
            {
                Console.WriteLine("Surname is not valid! Try again!");
                surname = Console.ReadLine();
            }
            teacher.Surname = surname;

            Console.WriteLine("Please enter teacher group number");
            string groupno = Console.ReadLine();
            while (!groupno.CheckLength())
            {
                Console.WriteLine("Group number is not valid! Try again!");
                groupno = Console.ReadLine();
            }
            teacher.GroupNo = groupno;

            Array.Resize(ref teachers, teachers.Length+1);
            teachers[teachers.Length - 1] = teacher;
        }

        public void Delete()
        {
            Console.WriteLine("Please enter id number to delete");
            int.TryParse(Console.ReadLine(), out int id);

            for (int i = 0; i < teachers.Length; i++)
            {
                if (teachers[i].Id == id)
                {
                    Teacher teacher = teachers[teachers.Length -1];
                    teachers[teachers.Length - 1] = teachers[i];
                    teachers[i] = teacher;

                    Array.Resize(ref teachers, teachers.Length - 1);
                    return;
                }
            }
            Console.WriteLine($"{id} is not found");
        }

        public void GetAll()
        {
            foreach(Teacher teacher in teachers)
            {
                Console.WriteLine(teacher);
            }
        }

        public void GetById()
        {
            Console.WriteLine("Enter Id to find a teacher");
            int id = int.Parse(Console.ReadLine());
            foreach (Teacher teacher in teachers)
            {
                if(teacher.Id == id)
                {
                    Console.WriteLine(teacher.ToString());
                    return;
                }
            }
        }

        public void Update()
        {
            Console.WriteLine("Please enter id number to delete");
            int.TryParse(Console.ReadLine(), out int id);

            for (int i = 0; i < teachers.Length; i++)
            {
                if (teachers[i].Id == id)
                {
                    Console.WriteLine("Please enter teacher name");
                    string name = Console.ReadLine();
                    while (!name.CheckLength())
                    {
                        Console.WriteLine("Name is not valid! Try again!");
                        name = Console.ReadLine();
                    }
                    teachers[i].Name = name;

                    Console.WriteLine("Please enter teacher surname");
                    string surname = Console.ReadLine();
                    while (!surname.CheckLength())
                    {
                        Console.WriteLine("Surname is not valid! Try again!");
                        surname = Console.ReadLine();
                    }
                    teachers[i].Surname = surname;

                    Console.WriteLine("Please enter teacher group number");
                    string groupno = Console.ReadLine();
                    while (!groupno.CheckLength())
                    {
                        Console.WriteLine("Group number is not valid! Try again!");
                        groupno = Console.ReadLine();
                    }
                    teachers[i].GroupNo = groupno;
                    return;
                }
            }
            Console.WriteLine($"{id} is not found");
        }

       
    }
}
