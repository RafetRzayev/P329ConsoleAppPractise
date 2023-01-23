using P329ConsoleAppPractise.Models;
using P329ConsoleAppPractise.Services;

namespace P329ConsoleAppPractise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StudentManager studentManager = new StudentManager();
            string command = "";

            do
            {
                Console.Write("Enter the command:");
                command = Console.ReadLine();

                if (command.ToLower().Equals("add student"))
                {
                    var student1 = new Student
                    {
                        Id = 1,
                        Firstname = "Elvin",
                        Lastname = "Cebrayilov",
                        Age = 25,
                        Course = 2,
                        EntryDate = DateTime.Now,
                        Group = new Group
                        {
                            Id = 1,
                            Name = "P329",
                        },
                    }; 
                    var student2 = new Student
                    {
                        Id = 2,
                        Firstname = "Sahlar",
                        Lastname = "Haciyev",
                        Age = 24,
                        Course = 1,
                        EntryDate = DateTime.Now,
                        Group = new Group
                        {
                            Id = 1,
                            Name = "P329",
                        },
                    };

                    studentManager.Add(student1);
                    studentManager.Add(student2);
                  
                }
                else if (command.ToLower().Equals("print students"))
                {
                    studentManager.Print();
                }
                else if (command.ToLower().Equals("delete student"))
                {
                    Console.Write("Enter the id:");
                    var id = int.Parse(Console.ReadLine());

                    studentManager.Delete(id);
                }
                else if(command.ToLower().Equals("update student"))
                {
                    Console.Write("Enter the id:");
                    var id = int.Parse(Console.ReadLine());

                    var existStudent = studentManager.Get(id);

                    if (existStudent == null)
                        continue;

                    Console.WriteLine(existStudent);

                    var student2 = new Student
                    {
                        Id = 2,
                        Firstname = "Sahlar",
                        Lastname = "Haciyev",
                        Age = 25,
                        Course = 1,
                        EntryDate = DateTime.Now,
                        Group = new Group
                        {
                            Id = 1,
                            Name = "P329",
                        },
                    };

                    studentManager.Update(id, student2);
                }

            } while (command.ToLower() != "quit");
        }
    }
}