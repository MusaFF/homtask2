using System;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            student student = new student();
            student.Name = "Musa";
            student.SurName = "Dadashov";
            student.Age = 17;
            student.garde = 700;
            student.major = "Programmer";

            Console.WriteLine($"AD: {student.Name}\nSOYAD: {student.SurName}\nYAŞ: {student.Age}\nQiymet: {student.garde}\nIxtisas: {student.major}");

           

        }

    }
}
