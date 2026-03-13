using System;
using System.Collections.Generic;
using ModelLayer;
using ServiceLayer;
namespace Student_Mgmt
{
    internal class Program
    {
        static StudentManager Manager = new StudentManager();
        static bool Exits = true;
        static void Main(string[] args)
        {
      
            while (Exits)
            {
                 
                Console.WriteLine("Welcome to Student Management System");
                Console.WriteLine("Please select an option:");
                Console.WriteLine("1.Create Student Information");
                Console.WriteLine("2.Retrieve Student Information");
                Console.WriteLine("3.Update Studen information");
                Console.WriteLine("4.Delete Student Information");
                Console.WriteLine("5.Exit");
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


                static void CreateInfo()
                {

                    Console.Write("Enter Name:");
                    string Name = Console.ReadLine() ?? string.Empty;
                    Console.WriteLine("Age:");
                    int Age = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Student No:");
                    int IDNo = Convert.ToInt32(Console.ReadLine());

                    Student_Data student = new Student_Data
                    {
                        StudentNoModel = IDNo,
                        NameModel = Name,
                        AgeModel = Age,
                    };
                    Manager.Add(student);
                    Console.WriteLine("Succes Student Added");
                }
                static void RetrieveInfo()
                {
                    Console.WriteLine("Student Information:");
                    var Students = Manager.GetAllStudents();
                    foreach (var student in Students)
                    {
                        Console.WriteLine($"ID: {student.StudentNoModel} Name: {student.NameModel} Age: {student.AgeModel}");
                    }
                }
                static void UpdateInfo()
                {

                    /* if(StudentNo != Student_Data)
                     {
                         Console.WriteLine("NOT VALID INPUT:" StudentNo);
                     }
                     else if (StudentNO == Student_Data) {
                     Console.Write("Enter Students Number");
                     int StudentNo = Convert.ToInt32(Console.ReadLine());

                     Student_Data.Add(StudentNo);
         */
                    Console.WriteLine("Updated the Info");

                }
                static void DelInfo()
                {
                    Console.WriteLine("Delete Section");


                }
                static void Exit()
                {
                   Exits = false;
                    Console.WriteLine("Exit Section");
                }
            }
        }
    }
}