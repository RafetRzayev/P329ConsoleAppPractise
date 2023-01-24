using P329ConsoleAppPractise.Models;
using P329ConsoleAppPractise.Services.Contracts;
using System;

namespace P329ConsoleAppPractise.Services
{
    internal class StudentConsoleManager : ICRUDConsoleService,IPrintService
    {
        private Student[] _students = new Student[100];
        private int _currentIndex = 0;

        public void Add()
        {
            Console.WriteLine("Telebe melumatlarini doldurun:");
          
            var student = new Student
            {
                Id = (int)DateTime.Now.Ticks,
                Firstname = Console.ReadLine(),
                Lastname = Console.ReadLine()
            };

            if (_currentIndex > 99)
            {
                Console.WriteLine("Limiti kecdiniz! Sadece 100 telebe elave etmek olar");

                return;
            }

            _students[_currentIndex++]=student;
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public Entity Get()
        {
            throw new NotImplementedException();
        }

        public Entity[] GetAll()
        {
            throw new NotImplementedException();
        }

        public void Print()
        {
            foreach (var item in _students)
            {
                if (item == null)
                    continue;

                Console.WriteLine(item);
            }
        }

        public void Update()
        {
            Console.Write("Id:");
            int id = int.Parse(Console.ReadLine());

            //int index = Array.IndexOf(_students, new Student() { Id=id});
            //int index = Array.FindIndex(_students, x => x.Id == id);

            for(int i = 0; i < _students.Length; i++)
            {
                if (_students[i] == null)
                    continue;

                if (_students[i].Id == id)
                {
                    Console.WriteLine("Yeni melumatlari daxil edin");


                    _students[i].Firstname = Console.ReadLine();
                    _students[i].Lastname = Console.ReadLine();

                    return;
                }
            }
           
        }
    }
}
