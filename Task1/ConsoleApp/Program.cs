using System;
using System.IO;

namespace ConsoleApp28
{
    class Program
    {
        static void Main(string[] args)
        {
            Directory.CreateDirectory(@"C/User/Users\BP201");
            File.Create(@"C/User/Users\BP201\fatime.txt");
            // File.Create(@"C/User/Users\BP201\Fatime2.txt");
            File.Delete(@"C/User/Users\BP201\Fatime2.txt");
            using (StreamWriter writer = new StreamWriter(@"C/User/Users\BP201\fatime.txt"))
            {
                writer.Write("Hello World nice to meet you!");


            }
            //OR

            //StreamWriter writer2 = new StreamWriter(@"C/User/Users\BP201\fatime.txt");
            //writer2.Write("It is the question");
            //writer2.Close();

            using (StreamReader reader = new StreamReader(@"C/User/Users\BP201\fatime.txt"))
            {
                reader.ReadToEnd();
            }


        }
    }
}
