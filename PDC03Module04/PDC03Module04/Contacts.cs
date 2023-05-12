using System;
using System.Collections.Generic;
using System.Text;

namespace PDC03Module04
{
    public class Contacts
    {
        public string FullName { get; set; }
        public int Age { get; set; }
        public string Occupation { get; set; }  
        public string Country { get; set; }

        public override string ToString()
        {
            return FullName;
        }

    }
}
