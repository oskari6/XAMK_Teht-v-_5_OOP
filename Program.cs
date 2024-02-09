using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using Personnel;

namespace classroom
{
    class Project
    {
        static void Main(string[] args)
        {
            /*Toteuta VIDEOIDEN 4 ja  C#-prujun olio-ohjelmoinnin esimerkin avulla ohjelma, 
             * joka käyttää hyväkseen vähintään yhtä oliota. 
             * Olio voi olla esimerkkien tavoin joko samassa tiedostossa ja nimiavaruudessa pääohjelman kanssa, 
             * tai voit laittaa sen myös omaan tiedostoonsa ja omaan nimiavaruuteensa, 
             * jolloin se pitää linkittää using-lauseella pääohjelmaan mukaan.*/

            Operations myOperation = new Operations();
            myOperation.DoOperation();
        }
    }
}