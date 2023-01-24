using P329ConsoleAppPractise.Models;
using P329ConsoleAppPractise.Services;

namespace P329ConsoleAppPractise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Day 1
            //StudentManager studentManager = new StudentManager();
            //string command = "";

            //do
            //{
            //    Console.Write("Enter the command:");
            //    command = Console.ReadLine();

            //    Subject[] subjects = 
            //    {
            //        new Subject
            //        {
            //            Id=1,
            //            Name="Kimya"
            //        },
            //        new Subject
            //        {
            //            Id=2,
            //            Name="Mathematica"
            //        },
            //    };
            //    if (command.ToLower().Equals("add student"))
            //    {
            //        var student1 = new Student
            //        {
            //            Id = 1,
            //            Firstname = "Elvin",
            //            Lastname = "Cebrayilov",
            //            Age = 25,
            //            Course = 2,
            //            EntryDate = DateTime.Now,
            //            Group = new Group
            //            {
            //                Id = 1,
            //                Name = "P329",
            //            },
            //            Subjects = subjects
            //        };

            //        var student2 = new Student
            //        {
            //            Id = 2,
            //            Firstname = "Sahlar",
            //            Lastname = "Haciyev",
            //            Age = 24,
            //            Course = 1,
            //            EntryDate = DateTime.Now,
            //            Group = new Group
            //            {
            //                Id = 1,
            //                Name = "P329",
            //            },
            //        };

            //        studentManager.Add(student1);
            //        studentManager.Add(student2);

            //    }
            //    else if (command.ToLower().Equals("print students"))
            //    {
            //        studentManager.Print();
            //    }
            //    else if (command.ToLower().Equals("delete student"))
            //    {
            //        Console.Write("Enter the id:");
            //        var id = int.Parse(Console.ReadLine());

            //        studentManager.Delete(id);
            //    }
            //    else if(command.ToLower().Equals("update student"))
            //    {
            //        Console.Write("Enter the id:");
            //        var id = int.Parse(Console.ReadLine());

            //        var existStudent = studentManager.Get(id);

            //        if (existStudent == null)
            //            continue;

            //        Console.WriteLine(existStudent);

            //        var student2 = new Student
            //        {
            //            Id = 2,
            //            Firstname = "Sahlar",
            //            Lastname = "Haciyev",
            //            Age = 25,
            //            Course = 1,
            //            EntryDate = DateTime.Now,
            //            Group = new Group
            //            {
            //                Id = 1,
            //                Name = "P329",
            //            },
            //        };

            //        studentManager.Update(id, student2);
            //    }

            //} while (command.ToLower() != "quit");

            #endregion end of day 1

            //var studentConsoleManager = new StudentConsoleManager();
            //string command;

            //do
            //{
            //    Console.Write("Enter the command:");
            //    command = Console.ReadLine();

            //    switch (command)
            //    {
            //        case "add student":
            //            studentConsoleManager.Add();
            //            break;
            //        case "print students":
            //            studentConsoleManager.Print();
            //            break;
            //        case "update student":
            //            studentConsoleManager.Update();
            //            break;
            //        default:
            //            break;
            //    }


            //} while (!command.Equals("quit"));


            var student1 = new Student
            {
                Id = (int)DateTime.Now.Ticks,
                Firstname = "Elvin",
                Lastname = "Cebrayilov"
            };

            var student2 = new Student
            {
                Id = (int)DateTime.Now.Ticks,
                Firstname = "Irfan",
                Lastname = "Yanbuxtin"
            };

            var student3 = new Student
            {
                Id = (int)DateTime.Now.Ticks,
                Firstname = "Cahangir",
                Lastname = "Cebrayilov"
            };

            var student4 = new Student
            {
                Id = (int)DateTime.Now.Ticks,
                Firstname = "Yusif",
                Lastname = "Yanbuxtin"
            };

            Student[] students = { student1, student3 };
            Student[] students2 = {student2, student4 };
            var group1 = new Group
            {
                Name = "P329",
                Students = students
            };

            var group2 = new Group
            {
                Name = "P324",
                Students = students2
            };

            Console.WriteLine($"{student1.Firstname} {student2.Lastname}");

            for (int i = 0; i < group1.Students.Length; i++)
            {
                if (group1.Students[i].Id == student1.Id)
                {
                    Console.WriteLine($"{group1.Name}");
                }
            }

            var teacher = new Teacher();
            teacher.Groups = new Group[10];
            teacher.Groups[0] = group1;
            teacher.Groups[1] = group2;
        }
    }
}