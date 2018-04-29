using System;

namespace Module3
{
    class Program
    {
        static void Main(string[] args)
        {
            // LAB 1

            // int result = Sum(20, 40);
            // Console.WriteLine($"Calling Sum() with two arguments, result is: {result}");

            // int result3 = Sum(10, 50, 80);
            // Console.WriteLine($"Calling Sum() with three arguments, result is: {result3}");

            // double dblResult = Sum(20.5, 30.6);
            // Console.WriteLine($"Calling Sum() that takes doubles result in: {dblResult}");

            // LAB 2

            // int first = 9;
            // int second = 0;
            // Console.WriteLine("Enter your first number: ");
            // first = System.Int32.Parse(Console.ReadLine());
            // Console.WriteLine("Enter your second number: ");
            // second = System.Int32.Parse(Console.ReadLine());

            // int result = Divide(first, second);
            // Console.WriteLine($"The result of dividing {first} by {second} is {result}");

            // ASSIGNMENT

            // string studentFirstName;
            // string studentLastName;

            GetStudentInformation();
            GetTeacherInformation();
          
            try
            {
                ValidateStudentBday();
            }
            catch (NotImplementedException notImp)
            {
                Console.WriteLine(notImp.Message);
            }

        }

        // LAB 1

        // Sum() method that takes two integer arguments and sums them
        // The method returns no value which is why we use void
        // We also need to use static in the method signature because Main is static
        // and you cannot call a non-static method from a static method

            // static int Sum(int first, int second)
            // {
            //     int sum = first + second;
            //     // Console.WriteLine($"The sum of {first} and {second} is: {sum}");
            //     return sum;
            // }


        // Sum() method that takes three integer arguments and sums them
        // and then returns the value
        // This method uses the same name as the Sum() method that takes two integers
        // but the parameters here indicate the method is expecting three integers as arguments
        // The compiler knows which method to call based on the number of arguments passed in
        // static int Sum(int first, int second, int third)
        // {
        //     int sum = first + second + third;
        //     return sum;
        // }

        // static double Sum(double first, double second)
        // {
        //     double result = first + second;
        //     return result;
        // }

        // LAB 2

        // Method Divide() accepts two integer arguments and returns the result
        // of dividing first by second
        // We do no validation of the the arguments so a user may pass in a zero
        // in place of the second parameter.   This is an illegal operation in math
        // If we don't validate input or catch the error, the application will crash
        // static int Divide(int first, int second)
        // {
        //     int result = 0; // declared up here so we have access inside and out of function

        //     try
        //     {
        //         result = first / second;
        //     }
        //     catch (DivideByZeroException ex) // this block looks for DivideByZeroException and if it occurs, we dispay this mesage
        //     {
        //         Console.WriteLine("Cannot divide by zero, please provide a non-zero value for your second value");
        //     }

        //     return result;
        // }

        // ASSIGNMENT

        static void GetStudentInformation()
        {
            Console.WriteLine("Enter the student's first name: ");
            string studentFirstName = Console.ReadLine();
            Console.WriteLine("Enter the student's last name: ");
            string studentLastName = Console.ReadLine();
            Console.WriteLine("Enter your birthdate: ");
            DateTime studentBday = DateTime.Parse(Console.ReadLine());
            PrintStudentDetails(studentFirstName, studentLastName, studentBday);
        }

        static void PrintStudentDetails(string first, string last, DateTime studentBday) // string birthday)
        {
            Console.WriteLine("{0} {1} was born on {2}", first, last, studentBday); //birthday)
        }

        static void GetTeacherInformation()
        {
            Console.WriteLine("Enter the teacher's city: ");
            string teacherCity = Console.ReadLine();
            Console.WriteLine("Enter the teacher's state: ");
            string teacherState = Console.ReadLine();
            Console.WriteLine("Enter your zipcode: ");
            int teacherZipcode = System.Int32.Parse(Console.ReadLine());
            PrintTeacherDetails(teacherCity, teacherState, teacherZipcode);
        }


        static void PrintTeacherDetails(string city, string state, int zipcode) // string birthday)
        {
            Console.WriteLine("Teacher is from {0}, {1}, {2}", city, state, zipcode); //birthday)
        }

        static void ValidateStudentBday()
        {
            throw new NotImplementedException();
        }

    }
}
