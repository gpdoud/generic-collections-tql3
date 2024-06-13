
using System.ComponentModel.DataAnnotations;

namespace ConsoleApp3 {

    internal class Program {
        static void Main(string[] args) {

            List<Student> students = new List<Student>();
            students.Add(new Student { Id = 1, Name = "Fred" });
            students.Add(new Student { Id = 2, Name = "Wilma" });
            students.Add(new Student { Id = 3, Name = "Barney" });

            Dictionary<int, Student> StudentDictionary = new Dictionary<int, Student>();
            foreach(var student in students) {
                StudentDictionary.Add(student.Id, student);
            }

            var Wilma = StudentDictionary[2];
            Console.WriteLine($"Id:{Wilma.Id}, Name: {Wilma.Name}");


            /*
                        List<string> strings = new List<string>();

                        strings.Add("Pink");
                        strings.Add("Red");
                        strings.Add("Magenta");
                        strings.Add("Burgundy");
                        strings.Add("Black");

                        strings.AddRange(new string[] { "Green", "Yellow" });

                        // Put your code here...
                        Console.Write("Enter a color: ");
                        var color = Console.ReadLine();

                        if(strings.Contains(color)) {
                            Console.WriteLine("Color already exists!");
                        } else {
                            strings.Add(color);
                            Console.WriteLine("Added...");
                        }

            */
        }
    }

    internal class Student {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}

