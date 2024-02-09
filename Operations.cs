using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personnel
{
    public class Operations
    {
        public void DoOperation()
        {
            //koulu ohjelma
            //Students, Teachers, users
            //tervehdys viesti
            //username
            //passwords
            //what are you student, teacher etc
            //työtunnit

            //Statukset
            const string teacher = "Opettaja";
            const string student = "Opiskelija";
            const string user = "Käyttäjä";

            //First User
            Users userOne = new Users("Oskari", "Sulkakoski");
            Console.WriteLine(userOne.Output());
            Console.WriteLine(userOne.UserName);
            Console.WriteLine("Salanasi on: " + userOne.UserPassword());
            Console.WriteLine(userOne.Status(user));
            Console.WriteLine(userOne.Greeting(user));
            Console.WriteLine(userOne.WorkHours(false) + "\n");
            //Console.Write("Verifiointisi: " + Verified);

            //First Student
            Students studentOne = new Students("Opiskelija", "Yksi");
            Console.WriteLine(studentOne.Output());
            Console.WriteLine(studentOne.UserName);
            Console.WriteLine("Salanasi on: " + userOne.UserPassword());
            Console.WriteLine(studentOne.Status(student));
            Console.WriteLine(studentOne.Greeting(student));
            Console.WriteLine(studentOne.WorkHours(student, 5) + "\n");

            //First Teacher
            Teachers teacherOne = new Teachers("Opettaja", "Yksi");
            Console.WriteLine(teacherOne.Output());
            Console.WriteLine(teacherOne.UserName);
            Console.WriteLine("Salanasi on: " + userOne.UserPassword());
            Console.WriteLine(teacherOne.Status(teacher));
            Console.WriteLine(teacherOne.Greeting(teacher));
            Console.WriteLine(teacherOne.WorkHours(teacher, 6) + "\n");
            //Console.Write("Verifiointisi: " + teacherOne.Verified);
        }
    }
}
