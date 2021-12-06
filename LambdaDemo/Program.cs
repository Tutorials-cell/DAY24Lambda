using System;
using System.Collections.Generic;
using System.Linq;

namespace LambdaDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lambada \n ");

            //List<Student> student = new List<Student>();
            //{
            //    student.Add(new Student() { StudentId = 1, StudentName = "MrHaltung", StudentAge = 23 });
            //    student.Add(new Student() { StudentId = 2, StudentName = "Dipesh", StudentAge = 23 });
            //    student.Add(new Student() { StudentId = 3, StudentName = "Tilak", StudentAge = 18 });

            //    double agest = student.Average(e => e.StudentAge);

            //    Console.WriteLine("The Average age of student is : " + agest);
            //}

            List<Person> person = new List<Person>();
            AddRecords(person);
            Retriveing_TopTwoRecords_ForAgeIs_LessThanTwenty(person);
        }

        private static void AddRecords(List<Person> person)
        {
            person.Add(new Person("32343", "MrHaltung", "Chandrapur", 24));
            person.Add(new Person("79537", "Dipesh", "Chandrapur", 23));
            person.Add(new Person("57945", "Mithilesh", "Chandrapur", 20));
            person.Add(new Person("98475", "Tilak", "Chandrapur", 18));
        }

        private static void Retriveing_TopTwoRecords_ForAgeIs_LessThanTwenty(List<Person> person)
        {
            foreach (Person per in person.FindAll(e => (e.Age < 20)).ToList())
            {
                Console.WriteLine("Name : " + per.Name + "\n Age : " + per.Age);
            }
        }
    }
}
