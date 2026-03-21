using ModelLayer;
using ServiceLayer;
using System;
using System.Collections.Generic;
using System.Xml.Linq;
using System.Linq;
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
                Console.WriteLine(" ");
                Console.WriteLine("Welcome to Student Management System");
                Console.WriteLine("Please select an option:");
                Console.WriteLine("1.Create Student Information");
                Console.WriteLine("2.Retrieve Student Information");
                Console.WriteLine("3.Update Studen information");
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
                    bool existChecker = false;
                    var Students = Manager.GetAllStudents();
                    var existingStudent = Students.FirstOrDefault(checker => checker.StudentNoModel == IDNo);
                    {
                        if (existingStudent != null)
                        {
                            Console.WriteLine("Failed to input, Already exist Student No: " + (existingStudent.StudentNoModel));
                            existChecker = true;
                            return;
                        }
                        else if (!existChecker)
                        {
                            Student_Data student = new Student_Data
                            {
                                StudentNoModel = IDNo,
                                NameModel = Name,
                                AgeModel = Age,
                            };
                            Manager.Add(student);
                            Console.WriteLine("Succesfuly Added Student");

                        }
                    }
                }


                static void RetrieveInfo()
                {
                    Console.WriteLine("Student Information:");
                    var Students = Manager.GetAllStudents();
                    if (!Students.Any())
                    {
                        Console.WriteLine("Empty Students");
                    }
                    else
                    {
                        foreach (var student in Students)
                        {
                            Console.WriteLine($"ID: {student.StudentNoModel} Name: {student.NameModel} Age: {student.AgeModel}");
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

                    var Students = Manager.GetAllStudents();
                    var studentSearch = Students.FirstOrDefault(Search => Search.StudentNoModel == CIDNo && Search.AgeModel == CAge);

                    if (studentSearch != null)
                    {
                        Console.Write("\nEnter new Name: ");
                        studentSearch.NameModel = Console.ReadLine();

                        Console.Write("Enter new Age: ");
                        studentSearch.AgeModel = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Student updated successfully!");
                    }
                    else
                    {
                        Console.WriteLine("Try again.");
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

                var StudentDeleter = Students.FirstOrDefault(StudentD => StudentD.StudentNoModel == DIDNo || StudentD.AgeModel == DAge);
       
                    if (StudentDeleter != null)
                {
                    Manager.Delete(StudentDeleter);
                    Console.WriteLine("Succesfuly Remove");
                }
                

                }
                static void Exit()
                {
                   Exits = false;
                    Console.WriteLine("Exit Section");
                }
            }
        }
    }
