using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Student information
            string firstName = "";
            string lastName = "";
            DateTime birthDate;
            string addressline = "";
            string city = "";
            string state = "";
            string zip = "";
            string country = "";

            // Teacher information
            string teacherFirstName = "";
            string teacherLastName = "";
            DateTime teacherBirthDate;
            string teacherAddressline = "";
            string teacherCity = "";
            string teacherState = "";
            string teacherZip = "";
            string teacherCountry = "";

            //UProgram information
            string programName = "";
            string departmentHead = "";
            string degrees = "";

            //Degree information
            string degreeName = "";
            string creditsRequired = "";

            // Course information
            string courseName = "";
            string credits = "";
            string DurationInWeeks;
            string teacher = "";



            // Assign some values

            // Student information
            firstName = "Jon";
            lastName = "Simpson";
            birthDate = new DateTime(1989, 4, 12);
            addressline = "118 W Smith St";
            city = "Seattle";
            state = "WA";
            zip = "98119";
            country = "US";

            // Teacher information
            teacherFirstName = "Todd";
            teacherLastName = "Pitt";
            teacherBirthDate = new DateTime(1980, 4, 12);
            addressline = "5235 22nd Ave NE";
            city = "Seattle";
            state = "WA";
            zip = "98105";
            country = "US";

            ////UProgram information
            programName = "programming";
            departmentHead = "todd";
            degrees = "phd";

            //Degree information
            degreeName = "programming";
            creditsRequired = "30";

            //Course information
            courseName = "C#";
            credits = "30";
            DurationInWeeks = "16";
            teacher = "Bryan";


            // output to the console window

            // Student information
            Console.WriteLine(firstName);
            Console.WriteLine(lastName);
            Console.WriteLine(birthDate);
            Console.WriteLine(addressline);
            Console.WriteLine(city);
            Console.WriteLine(state);
            Console.WriteLine(zip);
            Console.WriteLine(country);

            // Teacher information
            Console.WriteLine(teacherFirstName);
            Console.WriteLine(teacherLastName);
            Console.WriteLine(teacherBirthDate);
            Console.WriteLine(teacherAddressline);
            Console.WriteLine(teacherCity);
            Console.WriteLine(teacherState);
            Console.WriteLine(teacherZip);
            Console.WriteLine(teacherCountry);

            //UProgram information
            Console.WriteLine(programName);
            Console.WriteLine(departmentHead);
            Console.WriteLine(degrees);

            //Degree information
            Console.WriteLine(degreeName);
            Console.WriteLine(creditsRequired);

            // use placeholder style
            Console.WriteLine("{0} years old.", birthDate);

            // use string concatenation
            Console.WriteLine(addressline + ", " + city + ", " + country);

            // use string interpolation
            Console.WriteLine($"Born on {birthDate}");

        }
    }
}
