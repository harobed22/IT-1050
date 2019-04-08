using System;

namespace LAB_ASISIGNMENT_1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string firstName;
            string middleInitial;
            string lastName;
            string fullName;
            int age;
            bool isCitizen;
            bool canVote;
            int heightFeet;
            double heightInches;
            double totalHeightCM;

            Console.WriteLine("What is your first name?");//ask for first name
            firstName = Console.ReadLine();

            Console.WriteLine("What is your middle initial?");//ask for middle initial
            middleInitial = Console.ReadLine();

            Console.WriteLine("What is your last name?");//ask for last name
            lastName = Console.ReadLine();

            fullName = firstName + " " + middleInitial + ". " + lastName;

            Console.WriteLine("How many feet tall are you? (in whole feet, rounded down)");//ask for height feet
            heightFeet = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("How many inches tall are you after your height from feet? (in decimal)");//ask for height inches
            heightInches = Convert.ToDouble(Console.ReadLine());

            totalHeightCM = (heightFeet * 12 + heightInches) * 2.54;

            Console.WriteLine("Are you a US citizen? (yes/no)");//ask citizen
            string citString;
            citString = Console.ReadLine();

            isCitizen = false;
            if (citString == "yes")
            {
                isCitizen = true;
            }

            Console.WriteLine("How old are you?");//ask age
            age = Convert.ToInt16(Console.ReadLine());

            canVote = false;
            if (age >= 18 && isCitizen)
            {
                canVote = true;
            }

            Console.WriteLine("Your full name is: " + fullName);
            Console.WriteLine("Your total height in cm is: " + totalHeightCM);

            if (canVote)
            {
                Console.WriteLine("You can vote in US elections.");
            }
            else
            {
                Console.WriteLine("You can not vote in US elections.");
            }


        }
    }
}
