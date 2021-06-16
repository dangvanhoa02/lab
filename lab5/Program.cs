using System;

namespace lab5
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var hightSchoolTeach = new HighSchoolTeacher()
            {
                IdentityNumber = "PD001",
                Name = "Sever Pd7",
                BaseSalary = 100,
                Level = 7,
                Bonus = 200,
                IsSenior = false,
                HightSchoolCode = "PD008"
            };
            Console.WriteLine(hightSchoolTeach.CalculateSalary());
            
            var universityTeacher = new UniversityTecher()
            {
                IdentityNumber = "PD003",
                Name ="Thien Khang",
                BaseSalary = 9000,
                Level = 8,
                Bonus = 9000,
                IsSenior = true,
                EnglishLevel =  3,
                UniversityCode = "PD007"
            };
            Console.WriteLine(universityTeacher.CalculateSalary());
        }
    }
}