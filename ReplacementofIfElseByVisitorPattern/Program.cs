using System;

namespace ReplacementofIfElseByVisitorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Policy[] policies =
            {
                new Policy(new Boy("Kanha","Powayan")),
                new Policy(new Girl("Reshu","Shahjahanpur")),
                new Policy(new Men("Ajit","Noida")),
                new Policy(new Women("Nidhi","Gurgaon"))
            };

            (new BillPrinter()).PrintBill(policies[0]);
            (new BillPrinter()).PrintBill(policies[1]);
            (new BillPrinter()).PrintBill(policies[2]);
            (new BillPrinter()).PrintBill(policies[3]);

            Console.ReadLine();

            Console.WriteLine((new PrimumCalcuator()).Calculate(policies[0]));
            Console.WriteLine((new PrimumCalcuator()).Calculate(policies[1]));
            Console.WriteLine((new PrimumCalcuator()).Calculate(policies[2]));
            Console.WriteLine((new PrimumCalcuator()).Calculate(policies[3]));

            Console.ReadLine();
        }



    }
}
