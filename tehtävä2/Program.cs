using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*Toteuta materiaalin pohjalta yksinkertainen C#-ohjelma, 
             * joka kysyy käyttäjltä etunimen, sukunimen sekä iän. 
             * Jos käyttäjä antaa esimerkiksi seuraavat tiedot: 
            Etunimi: Matti
            Sukunimi: Meikäläinen
            Ikä: 50
            Niin ohjelma tulostaa näytölle seuraavan viestin: 
            Hei Matti Meikäläinen, olet 50 vuotias!*/

            Console.Write("Hei! Anna etunimesi: ");
            string firstName = Console.ReadLine();
            Console.Write("Hei! Anna sukunimesi: ");
            string lastName = Console.ReadLine();
            Console.Write("Anna ikäsi: ");
            int.TryParse(Console.ReadLine(), out int age);

            Console.WriteLine($"Hei {firstName} {lastName}, Olet {age} vuotias!");
        }
    }
}