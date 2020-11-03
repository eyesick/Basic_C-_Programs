using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    public class Fraudexception : Exception
    {
        public Fraudexception()
            : base() { }
        public Fraudexception(string message)
            : base(message) { }
    }
}
