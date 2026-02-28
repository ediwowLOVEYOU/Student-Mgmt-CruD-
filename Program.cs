using System;
using System.Collections.Generic;

namespace Student_Mgmt
{
    internal class Program
    {
       

        static void Main(string[] args)
        {
            static List<string> StudentData = new List<string>();

            Console.WriteLine("Welcome to Student Management System");
            Console.WriteLine("Please select an option:");
            Console.WriteLine("1.Create Student Information");
            Console.WriteLine("2.Retrieve Student Information");
            Console.WriteLine("3.Update Studen information");
            Console.WriteLine("4.Delete Student Information");
            Console.WriteLine("5.Exit");


            Console.WriteLine("Create Student Information");
            Console.WriteLine("1.Student Name");
            Console.WriteLine("2.Student Age");
            Console.WriteLine("3.Student No");
            Console.WriteLine("4.Exit");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    CreateInfo();
                    break;
                case 2:
                    RetrieveInfo();
                    break;
                case 3:
                    UpdateInfo();
                    break;
                case 4:
                    DelInfo();
                    break;
                case 5:
                    Exit();
                    break;

            }


            static void CreateInfo() {

                StudentData Student = new StudentData();

            Console.Write("Enter Name:");
            Student.Name = Console.ReadLine();
            Console.WriteLine("Age:");
           Student.Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Student No:");
            Student.StudentNo = Convert.ToInt32(Console.ReadLine());

            StudentData.Add(Name);
                StudentData.Add(Age);
                StudentData.Add(StudentNo);
        }
        static void RetrieveInfo()  
        {
            Console.WriteLine("Student Information:");
            foreach (string Student in StudentData)
            {
                Console.WriteLine(Student);
            }
        }
        static void UpdateInfo()
        {

            if(StudentNo != StudentData)
            {
                Console.WriteLine("NOT VALID INPUT:" StudentNo);
            }
            else if (StudentNO == StudentData) {
            Console.Write("Enter Students Number");
            int StudentNo = Convert.ToInt32(Console.ReadLine());

            StudentData.Add(StudentNo);

            Console.WriteLine("Updated the Info");

        }   
        static void DelInfo()
        {



        }
        static void Exit()
        {

        }
    }
}
