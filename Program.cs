using System;

namespace Deliverable2_ConditionalStatement

{
    
    class Program
    {
        
        static void Main(string[] args)
        
        {
           // i use this to delcaire my variable 
            int grade;
            
            //int grade;
            //grade = 98;
            //Console.WriteLine(grade);
            
            // Ask user what grade they expect to get in ISM$300
            Console.WriteLine("What grade do you expect to receive in ISM4300?");

            // this is an if else statement that allows the user to convert their number grade into a letter grade
            grade = Convert.ToInt16(Console.ReadLine());
            
            //grade = Convert.ToChar(Console.ReadLine());
            //switch (grade)
            //grade = switch (.tostring(Console.ReadLine());

            {


                if (grade >= 98)
                {
                    //mbox("A+");
                    Console.WriteLine("A+");
                }

                else if (grade >= 92 && grade <= 97)
                {
                    Console.WriteLine("A");
                }

                else if (grade >= 90 && grade <= 91)
                {

                    Console.WriteLine("A-");
                }

                else if (grade >= 88 && grade <= 89)
                {
                    Console.WriteLine("B+");
                }

                else if (grade >= 82 && grade <= 87)
                {
                    Console.WriteLine("B");
                }

                else if (grade >= 80 && grade <= 81)
                {

                    Console.WriteLine("B-");
                }

                else if (grade >= 78 && grade <= 79)
                {
                    Console.WriteLine("C+");
                }

                else if (grade >= 72 && grade <= 77)
                {
                    Console.WriteLine("C");
                }

                else if (grade >= 70 && grade <= 71)
                {
                    Console.WriteLine("C-");
                }
                else if (grade >= 68 && grade <= 69)
                {
                    Console.WriteLine("D+");

                }

                else if (grade >= 62 && grade <= 67)
                {
                    Console.WriteLine("D");
                }
                else if (grade >= 60 && grade <= 61)
                {
                    Console.WriteLine("D-");
                }

                else if (grade <= 60)
                {
                    Console.WriteLine("F");
                }
            
            }

         
         
        }
    }
}
