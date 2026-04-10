
using ModelLayers;
using PUPSIS_AppServiceLayers;
using System;
using System.Collections.Generic;
using System.Linq;
namespace Student_Mgmt
{
    internal class Program
    {

        static StudentManagerBS Manager = new StudentManagerBS();
        static bool Exits = true;
        static void Main(string[] args)
        {

            while (Exits)
            {
                Console.WriteLine(" ");
                Console.WriteLine("Welcome to Student Management System");
                Console.WriteLine("Please select an option:");
                Console.WriteLine("1.Create Student Information");
                Console.WriteLine("2.Retrieve Student Information");
                Console.WriteLine("3.Update Student information");
                Console.WriteLine("4.Delete Student Information");
                Console.WriteLine("5.Exit");
                Console.WriteLine(" ");
                Console.Write("Select a number:");
                int choice = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(" ");
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
                    Console.Write("Age:");
                    int Age = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Student No:");
                    int IDNo = Convert.ToInt32(Console.ReadLine());

                    Student_Data student = new Student_Data
                    {
                        StudentID = IDNo,
                        StudentName = Name,
                        StudentAge = Age
                    };

                    if (Manager.Adding(student))
                        Console.WriteLine("Added!");
                    else
                        Console.WriteLine("Already exists!");
                }


                static void RetrieveInfo()
                {
                    Console.WriteLine("Student Information:");


                    var students = Manager.GetAllStudents();

                    if (!students.Any())
                    {
                        Console.WriteLine("Empty Students");
                        return;
                    }
                    else
                    {
                        foreach (var student in students)
                        {
                            Console.WriteLine($"ID: {student.StudentID} Name: {student.StudentName} Age: {student.StudentAge}");
                        }

                    }
                    }

                    static void UpdateInfo()
                    {
                        Console.WriteLine("**Updating Info Section**\n");
                        Console.Write("Student No:");
                        int CIDNo = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Student Age:");
                        int CAge = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter new Name: ");
                        string newName = Console.ReadLine() ?? string.Empty; ;
                        Console.Write("Enter new Age: ");
                        int newAge = Convert.ToInt32(Console.ReadLine());

                        if (Manager.Update(CIDNo, CAge, newName, newAge))
                        
                            Console.WriteLine("Updated successfully!");
                        else
                            Console.WriteLine("Student not found!");
                        }
                    }



                }
                static void DelInfo()
                {
                    Console.WriteLine("**Delete Section**\n");

                    Console.Write("Student No:");
                    int DIDNo = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Student Age:");
                    int DAge = Convert.ToInt32(Console.ReadLine());
                    var Students = Manager.GetAllStudents();

                    if (Manager.Delete(DIDNo))
                        Console.WriteLine("Deleted!");
                    else
                        Console.WriteLine("Not found!");


                }
                static void Exit()
                {
                    Exits = false;
                    Console.WriteLine("Exit Section");
                }
            }
        }
    

