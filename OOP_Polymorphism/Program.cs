using System;

namespace OOP_Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Child obj = new Child();

            Console.WriteLine("-------------------------- Runtime Polymorphism-------------------------\n");
           
            obj.FirstName = "Sudarshana";
            obj.LastName = "K";
            obj.PayStub1 = 3000;
            obj.PayStub2 = 3000;
            obj.GetEmpDetail();

            Console.WriteLine("\n\n\n\n");

            Console.WriteLine("-------------------------- Compile Time Polymorphism-------------------------\n");

            
            obj.GetNewJoineeDetails("Trilochana", "S");
            obj.GetNewJoineeDetails(4000, 4000);

            Console.ReadLine();
        }
    }
}
