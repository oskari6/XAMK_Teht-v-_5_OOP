using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personnel
{
    public class Students : Users
    {
        public Students(string firstName, string lastName) : base(firstName, lastName)
        {
            
        }
    }
}
