using AbstractionsTask.Implementations;


StudentService studentService = new StudentService();
TeacherService teacherService = new TeacherService();

Console.WriteLine("0 - to quit");
Console.WriteLine("1 - to create a student");
Console.WriteLine("2 - to show students");
Console.WriteLine("3 - to get by Id students");
Console.WriteLine("4 - to delete a student");
Console.WriteLine("5 - to update a student");
Console.WriteLine("--------------------------");
Console.WriteLine("6 - to create a teacher");
Console.WriteLine("7 - to show teachers:");
Console.WriteLine("8 - to get by Id for teachers");
Console.WriteLine("9 - to delete a teacher");
Console.WriteLine("10- to update a teacher");

string request = Console.ReadLine();

while (request != "0")
{
    switch (request) 
    {
        case "1":
            studentService.Create(); break;
        case "2":
            studentService.GetAll(); break;
        case "3":
            studentService.GetById(); break;
        case "4":
            studentService.Delete(); break;
        case "5":
            studentService.Update(); break;
        case "6":
            teacherService.Create(); break;
        case "7":
            teacherService.GetAll(); break;
        case "8":
            teacherService.GetById(); break;
        case "9":
            teacherService.Delete(); break;
        case "10":
            teacherService.Update(); break;
    }

    Console.WriteLine("0 - to quit");
    Console.WriteLine("1 - to create a student");
    Console.WriteLine("2 - to show students");
    Console.WriteLine("3 - to get by Id students");
    Console.WriteLine("4 - to delete a student");
    Console.WriteLine("5 - to update a student");
    Console.WriteLine("--------------------------");
    Console.WriteLine("6 - to create a teacher");
    Console.WriteLine("7 - to show teachers:");
    Console.WriteLine("8 - to get by Id for teachers");
    Console.WriteLine("9 - to delete a teacher");
    Console.WriteLine("10- to update a teacher");

    request = Console.ReadLine();
}