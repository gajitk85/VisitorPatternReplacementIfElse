using System;
using System.Collections.Generic;
using System.Text;

namespace ReplacementofIfElseByVisitorPattern
{
   public abstract class Person
    {
        public  string Name { get; set; }
        public string Address { get; set; }
        public string Father { get; set; }
        public string Mother { get; set; }
        public Person(string name, string address)
        {
            this.Address = address;
            this.Name = name;
        }
        public abstract void AcceptPersonVisitor(IPersonVisitor visitor);

    }

    public abstract class Adult: Person
    {
        public Adult(string name, string address) : base(name, address) { }

    }

    public abstract class TeenAged : Person
    {
        public TeenAged(string name, string address) : base(name, address) { }

    }

    public  class Men : Adult
    {
        public Men(string name, string address) : base(name, address) { }

        public override void AcceptPersonVisitor(IPersonVisitor visitor)
        {
            visitor.HandleMan(this);
        }
    }

    public  class Women : Adult
    {
        public Women(string name, string address) : base(name, address) { }

        public override void AcceptPersonVisitor(IPersonVisitor visitor)
        {
            visitor.HandleWoman(this);
        }
    }

    public class Boy : TeenAged
    {
        public Boy(string name, string address) : base(name, address) { }

        public override void AcceptPersonVisitor(IPersonVisitor visitor)
        {
            visitor.HandleBoy(this);
        }
    }

    public class Girl : TeenAged
    {
        public Girl(string name, string address) : base(name, address) { }

        public override void AcceptPersonVisitor(IPersonVisitor visitor)
        {
            visitor.HandleGirl(this);
        }
    }

    public class Policy
    {
        
        public Person Person { get; }

        public Policy(Person p)
        {
            this.Person = p;
        }

    }
}
