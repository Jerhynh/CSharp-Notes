using System;
using System.Collections;

namespace advancedcsharp
{
    class Program
    {
        // Hashtables - Pretty much a collection of dictionary entries.
        // Works similarly to how a dictionary works.
        // Key - Value (pair)
        // Auto - Car
        static void Main(string[] args)
        {
            Hashtable table = new();
            Student stud1 = new(1, "Maria", 98);
            Student stud2 = new(2, "Jason", 76);
            Student stud3 = new(3, "Clara", 43);
            Student stud4 = new(4, "Steve", 55);

            table.Add(stud1.Id, stud1);
            table.Add(stud2.Id, stud2);
            table.Add(stud3.Id, stud3);
            table.Add(stud4.Id, stud4);

            // Retrieve individual items from hash table.
            Student storedStudent = (Student)table[1];
            Student storedStudent1 = (Student)table[stud2.Id];
            Console.WriteLine(storedStudent.Name);
            Console.WriteLine(storedStudent1.Name);
            Console.WriteLine("Listing all students: ");
            foreach (DictionaryEntry entry in table)
            {
                var studentTemp = (Student)entry.Value;
                Console.WriteLine($"Student: {studentTemp.Name}");
            }
        }
    }

    class Student
    {
        // prop
        public int Id { get; set; }
        public string Name { get; set; }
        public float GPA { get; set; }

        // constructor
        public Student(int Id, string Name, float GPA)
        {
            this.Id = Id;
            this.Name = Name;
            this.GPA = GPA;
        }
    }
}
