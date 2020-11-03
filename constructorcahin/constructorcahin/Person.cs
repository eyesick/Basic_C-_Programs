using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructorcahin
{
    public class Person
    {
        public int _id;
        public string _Fname;
        public string _Lname;
        




        public Person(int id)
            : this(id, "", "") { }

        public Person(int id, string Fname)
            : this(id, Fname, "") { }

        public Person(int id, string Fname, string Lname)
        {
            _id = id;
            _Fname = Fname;
            _Lname = Lname;
            
        }
              




    }
}
