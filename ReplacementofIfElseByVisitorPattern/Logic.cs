using System;
using System.Collections.Generic;
using System.Text;

namespace ReplacementofIfElseByVisitorPattern
{
    public class BillPrinter
    {
        public void PrintBill(Policy p)
        {
            p.Person.AcceptPersonVisitor(new BillPrintVistisor());
        }


    }
    public class BillPrintVistisor : IPersonVisitor
    {
        string bill;
        public void HandleBoy(Boy visit)
        {
            bill += " Hi Dude " + visit.Name;
            bill += " you Adress is " + visit.Address;
            Console.WriteLine(bill);
        }

        public void HandleGirl(Girl visit)
        {
            bill += " Hi Babes " + visit.Name;
            bill += " you Adress is " + visit.Address;
            Console.WriteLine(bill);
        }

        public void HandleMan(Men visit)
        {
            bill += " Hi Mr " + visit.Name;
            bill += " you Adress is " + visit.Address;
            Console.WriteLine(bill);
        }

        public void HandleWoman(Women visit)
        {
            bill += " Hi Mrs " + visit.Name;
            bill += " you Adress is " + visit.Address;
            Console.WriteLine(bill);
        }
    }

    public class PrimumCalcuator
    {
        public string Calculate(Policy p)
        {
            var v = new PrimumCacluatorVistor();
            p.Person.AcceptPersonVisitor(v);
            return v.name + " your primum is INR. " + v.primum;


        }
    }
    public class PrimumCacluatorVistor : IPersonVisitor
    {
        public int primum = 0;
        public string name;
        public void HandleBoy(Boy visit)
        {
            primum = 1000;
            name = "Dude " + visit.Name;
        }

        public void HandleGirl(Girl visitee)
        {
            primum = 1100;
            name = "Maám " + visitee.Name;
        }

        public void HandleMan(Men visitee)
        {
            primum = 1200;
            name = "Mr. " + visitee.Name;
        }

        public void HandleWoman(Women visitee)
        {
            primum = 1400;
            name = "Mrs. " + visitee.Name;
        }

    }
}
