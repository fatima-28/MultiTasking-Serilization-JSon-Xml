using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace Task2
{
    //P.S.:Komputer kodu run etmediyine gore teqribi yazmisham. Kodda sehvler
    //ola biler, Uzrlu sayin.
    class Program
    {
        static void Main(string[] args)
        {
            Student stu1 = new Student(1,"Fatime","Bayramova",19);
            Student stu2 = new Student(2, "Elnare", "Vahabova", 19);
            Student stu3 = new Student(3, "Gunay ", "Abbasova", 21);
            Student stu4 = new Student(4, "Nezaket", "Memmedova", 19);

            List<Student> students = new List<Student>();
            students.Add(stu1);
            students.Add(stu2);
            students.Add(stu3);
            students.Add(stu4);
            var json = JsonConvert.SerializeObject(students);
            Console.WriteLine(json);


            using (StreamReader streamReader = new StreamReader(@"C:\Users\fatimabayramova\Desktop\Task1,File\Task1,File\Files\json1.json"))
            {
               streamReader.ReadToEnd();
            }

            var result= JsonConvert.DeserializeObject(@"'{""Id"":1 ,""Name"":""Fatime"", ""Surename"":""Bayramova"",""Age"":19, }'");

            Console.WriteLine(result);
        }
    }

    public class Student
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Surename { get; set; }
        public int Age { get; set; }
        public Student(int id, string name, string surename, int age)
        {
            Id = id;
            Name = name;
            Surename = surename;
            Age = age;
        }
    }
}
