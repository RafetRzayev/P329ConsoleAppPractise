namespace P329ConsoleAppPractise.Models
{
    internal class Student : Person
    {
        internal Group Group { get; set; }
        internal DateTime EntryDate { get; set; }
        internal int Course { get; set; }
        internal Subject[] Subjects { get; set; }= Array.Empty<Subject>();

        public override string ToString()
        {
            string subjects = "";
            foreach (var item in Subjects)
            {
                if (item == null)
                    continue;

                subjects += item + "\n";
            }

            return $"{Id} {Firstname} {Lastname} {FatherName} {Age}\n{Group}\n{EntryDate}\n{Course}\nSubjects:\n{subjects}";
        }

        public override bool Equals(object? obj)
        {
            var student = obj as Student;
            
            return student.Id == Id;
        }
    }

    internal class Subject : Entity
    {
        internal string Name { get; set; }

        public override string ToString()
        {
            return $"{Id} {Name}";
        }
    }
}
