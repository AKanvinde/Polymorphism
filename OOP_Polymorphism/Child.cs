using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Polymorphism
{
    public class Child: ParentA
    {

        //-------------------------- Runtime Polymorphism-------------------------
        public int PayStub1, PayStub2;

        public override void GetEmpDetail()
        {          
            Console.WriteLine(" Employee FirstName: " + FirstName + "\n Employee LastName: " + LastName + ";\n Employee Salary " + (PayStub1+PayStub2));
        }

        //-------------------------- Compile Time Polymorphism-------------------------
        public void GetNewJoineeDetails(string FName,string LName)
        {
            Console.WriteLine(" Employee FullName: " + FName + " " + LName );
        }

        public void GetNewJoineeDetails(int Paychk1, int Paychk2)
        {
            Console.WriteLine(" Employee Salary: " + (Paychk1 + Paychk2) );
        }
    }

}


