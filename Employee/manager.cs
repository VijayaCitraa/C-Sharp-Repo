using System;

namespace ems
{
    public class Manager : Employee
    {
        // Property for team size
        public int Teamsize { get; set; }

        // Constructor
        public Manager(string name, string dept, int salary, int teamsize)
            : base(name, dept, salary)
        {
            Teamsize = teamsize;
        }

        // Override Display method for polymorphism
        public override string Display()
        {
            return $"Manager: {base.Display()}, Team Size: {Teamsize}";
        }
    }
}
