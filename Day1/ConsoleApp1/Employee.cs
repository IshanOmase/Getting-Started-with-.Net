using HR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR
{
    internal class Employee:Person //use of inheritance
    {
        //use of getters and setters directly
        //similar to lombok in java a bit only
        public float BasicSalary { get; set; }
        public float DailyAllowance { get; set; }
        public float Deductions {  get; set; }

        public Employee() : base()
        {

        }

        public Employee(int id, string name, int age, float basicSalary, float dailyAllowance, float deductions):base(id,name,age)
        {
            BasicSalary = basicSalary;
            DailyAllowance = dailyAllowance;
            Deductions = deductions;
        }

        public float computePay()
        {
            return BasicSalary + (DailyAllowance*20) - Deductions;
        }

        public override string ToString()
        {
            return base.ToString() + " |salary: " + this.computePay();
        }


    }
}
