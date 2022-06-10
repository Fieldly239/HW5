using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_5
{
    public class Teacher : Job
    {
        //property
        public string Name { get; set; }
        public string Occupation { get; set; }
        public decimal Salary { get; set; }
        public int Tax { get; set; }
        //constructor

        public Teacher(string name, string occupation, decimal salary, int tax)
        {
            Name = name;
            Occupation = occupation;
            Salary = salary;
            Tax = tax;
        }
        //method

        public string WhoAmI()
        {
            return $"{Name} is a {Occupation} Salary : {Salary} Tax : {Tax}";
        }

        public decimal GetTax()
        {
            return (Salary * Tax) / 100;
        }




    }
}
