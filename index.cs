using System;


namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            double allCredit = 21;//21
            double totalNumberOfCreditPoints = PromtGrades();
            double GPA = totalNumberOfCreditPoints / allCredit;
            Console.WriteLine($"Your Gpa Is:{GPA:N2}");
            Console.ReadKey();
        }
        public static double PromtGrades()
        {
            int businessCredit = 2;//2

             int dataCredit = 4;//4
             int algorithmCredit = 3;//3
             int electCreditt = 4;//4
             int peripherialsCredit = 3;//3
             int webCredit = 2;//2
             int objCredit = 3;//3
           
            double totalpoints = 0;
            Console.WriteLine("Enter Your Grade for BusinessBook");
            string Businnness = Console.ReadLine();
            //int Businnness = Convert.ToInt32(Console.ReadLine());
           // Console.WriteLine("Enter Your Credit for BusinessBook");
           // int businessCredit = Convert.ToInt32(Console.ReadLine());
            double BusinessPoints = CalculatePoints(Businnness)* businessCredit;
            totalpoints += BusinessPoints;
            Console.WriteLine("Enter Your Grade for DataCommunication");
             string DataCom = Console.ReadLine();
            //int DataCom = Convert.ToInt32(Console.ReadLine());
           // Console.WriteLine("Enter Your Credit for DataCommunication");
           // int dataCredit = Convert.ToInt32(Console.ReadLine());
            double dataPoints = CalculatePoints(DataCom)*dataCredit;
            totalpoints += dataPoints;
            Console.WriteLine("Enter Your Grade for Electronics");
             string Electronicss = Console.ReadLine();
            //int Electronicss = Convert.ToInt32(Console.ReadLine());
           // Console.WriteLine("Enter Your Credit for Electronics");
           // int electCreditt = Convert.ToInt32(Console.ReadLine());
            double ElectPoints = CalculatePoints(Electronicss)*electCreditt;
            totalpoints += ElectPoints;
            Console.WriteLine("Enter Your Grade for algorithm");
             string Algorithm = Console.ReadLine();
            // int Algorithm = Convert.ToInt32(Console.ReadLine());
           // Console.WriteLine("Enter Your Credit for Algorithm");
            //int algorithmCredit = Convert.ToInt32(Console.ReadLine());
            double AlgorithmPoints = CalculatePoints(Algorithm) * algorithmCredit;
            totalpoints +=AlgorithmPoints;
            Console.WriteLine("Enter Your Grade for peripherials");
             string Peripherialss = Console.ReadLine();
            //int Peripherialss  = Convert.ToInt32(Console.ReadLine());
           // Console.WriteLine("Enter Your Credit for Peripherials");
            //int peripherialsCredit = Convert.ToInt32(Console.ReadLine());
            double PeriPoints = CalculatePoints(Peripherialss)* peripherialsCredit;
            totalpoints += PeriPoints;
            Console.WriteLine("Enter Your Grade for webdev");
             string WebDevlop = Console.ReadLine();
            //int WebDevlop = Convert.ToInt32(Console.ReadLine());
           // Console.WriteLine("Enter Your Credit for Peripherials");
           // int webCredit = Convert.ToInt32(Console.ReadLine());
            double WebPoints = CalculatePoints(WebDevlop)*webCredit;
            totalpoints += WebPoints;
            Console.WriteLine("Enter Your Grade for objectori");
             string ObjectORiented = Console.ReadLine();
            // int ObjectORiented = Convert.ToInt32(Console.ReadLine());
           // Console.WriteLine("Enter Your Credit for Peripherials");
           // int objCredit = Convert.ToInt32(Console.ReadLine());
            double objectPoints = CalculatePoints(ObjectORiented)*objCredit;
            totalpoints += objectPoints;
            return totalpoints;
             int sumCredit = businessCredit+dataCredit+electCreditt+algorithmCredit+peripherialsCredit+webCredit+objCredit;

        }
         public static double CalculatePoints(string grade)
         {
             double gradePoints = 0;
             switch (grade.ToUpper())
             {
                 case "A+":
                     gradePoints += 4.00;
                     break;
                case "A":
                    gradePoints += 3.75;
                    break;
                case "A-":
                    gradePoints += 3.50;
                    break;
                case "B+":
                     gradePoints += 3.25;
                     break;
                case "B":
                    gradePoints += 3.00;
                    break;
                case "B-":
                    gradePoints += 2.75;
                    break;
                case "C+":
                     gradePoints += 2.50;
                     break;
                case "C":
                    gradePoints += 2.25;
                    break;
                case "D":
                     gradePoints += 2.00;
                     break;
                 case "F":
                     gradePoints += 0.00;
                     break;
                 default:
                     break;
             }
             return gradePoints;

         }
        /* public static double CalculatePoints(int grade)
         {
             double gradePoints = 0;
             if(grade<100 && grade >= 80)
             {
                 gradePoints += 4.0;
             }
        else if (grade >= 75 && grade =< 79)
             {
                 gradePoints += 3.75;
             }
        else if (grade >= 70 && grade =< 74)
            {
                gradePoints += 3.50;
            }
         else if (grade >= 65 && grade =< 69)
            {
                gradePoints += 3.50;
            }
         else if (grade >= 60 && grade =< 64)
            {
                gradePoints += 3.25;
            }
         else if (grade >= 55 && grade =< 59)
            {
                gradePoints += 3.00;
            }
             else if (grade >= 50 && grade =< 54)
            {
                gradePoints += 2.75;
            }
        else if (grade >= 45 && grade =< 49)
            {
                gradePoints += 2.50;
            }
             else if (grade < 40 && grade >= 44)
             {
                 gradePoints += 2.25;
             }
         else if (grade < 35 && grade >= 39)
             {
                 gradePoints += 2.00;
             }
             else if (grade < 33 && grade >= 0)
             {
                  gradePoints += 1.0;
                  Console.WriteLine("You Failed ,Try Next Time");

             }
             else
             {
                 Console.WriteLine("Invalid Number You Write,Plese Write The Correct Number");
             }
             return gradePoints;
         }*/
    }
}
