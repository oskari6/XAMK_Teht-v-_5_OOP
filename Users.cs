using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using classroom;

namespace Personnel
{
    public class Users
    {
        private const string teacher = "Opettaja";
        private const string student = "Opiskelija";
        private const string user = "käyttäjä";

        Random random = new Random();
        public bool Verified {  get; set; }

        private int UserNum()
        {
            int randNum = random.Next(0, 1000);
            return (randNum);
        }

        private static Random randomString = new Random();
        public string UserPassword(int length = 7)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[randomString.Next(s.Length)]).ToArray());
        }

        public string Output(int times = 1) //creating a method, = 1 is default parameter
        {
            string message = "Hei, ";
            for (int i = 0; i < times; i++)
            {
                message += FirstName + " " + LastName;
            }
            return message;
        }

        public Users(string firstName, string lastName) //custom constructor
        {
            FirstName = firstName;
            LastName = lastName;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string UserName
        {
            get
            {
                return "Käyttäjänimesi on: " + FirstName + LastName + UserNum();
            }
        }

        public string Status(string status)
        {
            return "Stauksesi on: " + status;
        }
        
        public string Greeting(string status)
        {
            if (status == user)
            {
                return "Tervetuloa kouluun!";
            }
            else if (status == student)
            {
                return "Tervetuloa kouluun opiskelemaan!";
            }
            else if (status == teacher)
            {
                return "Tervetuloa kouluun opettamaan!";
            }
            return "wrong status input";
        }

        public void WorkHours(string status, int workDays)
        {
            if(status == student)
            {
                Console.WriteLine($"Työtuntisi ovat {workDays * 6}.");
            }
            else if(status == teacher)
            {
                Console.WriteLine($"Työtuntisi ovat {workDays * 8}.");
            }
        }

        public string WorkHours(bool eligibility = true)
        {
            if(!eligibility)
            {
                return "Sinulle ei ole annettu vielä työtunteja.";
            }
            return "Annoit väärän syötteen, vaihda statukseen jos et ole käyttäjä.";
        }
    }
}
