using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Polymorphism
{
    public class ParentA
    {
        public string FirstName, LastName;
        public virtual void GetEmpDetail()
        {
            Console.WriteLine(" FullName: " + FirstName + "\n LastName: " +LastName);
        }

    }
}
