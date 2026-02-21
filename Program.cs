 namespace Student_Mgmt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Create Student Information");
            Console.Write("Enter Name:");
            string studentName = Console.ReadLine();
            Console.WriteLine("Age:");
            int studentAge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Birth Month");
            int studentBirthMonth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Birth Day:");
            int studentBirthDay = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Birth Year:");
            int studentBirthYear = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Student No:");
            int studentBirthStudentNo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Student Address:");
            string studentAddress = Console.ReadLine();

            Console.WriteLine(studentName);
            Console.WriteLine(studentAge);
            Console.WriteLine(studentBirthMonth);
            Console.WriteLine(studentBirthDay);
            Console.WriteLine(studentBirthYear);
            Console.WriteLine(studentBirthStudentNo);
            Console.WriteLine(studentAddress);

        }
    }
}
