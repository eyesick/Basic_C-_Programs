using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment244
{
    public class Employee : Person, IQuittable
    {
        public int ID;

        
        public override void SayName()
        {
            Console.WriteLine("My name is");
        }
        public void Quit()
        {
            Console.WriteLine("You quit");
        }

        //public static bool operator==(Employee employee1, Employee employee2)
        //{
        //    return employee1.ID == employee2.ID;
        //}

        //public static bool operator !=(Employee employee1, Employee employee2)
        //{
        //    return employee1.ID != employee2.ID;
        //}
    }
 
}
