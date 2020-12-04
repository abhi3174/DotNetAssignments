using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    class Day4
    {
        static void Main(string[] args)
        {
            Employee a = new Manager("Abhi",1051364.45m,"Manager");
            a.show();
            Manager b = new Manager("Abhi", 1051364.45m, "Manager");
            b.show();
        }

        abstract public class Employee
        {
            private string empName;
            protected string EmpName
            {
                set { if (value != "") {
                        this.empName = value;
                    } }
                get { return empName; }
            }


            protected decimal basic;
            public abstract decimal Basic
            {
                get;
                set;
            }
            public Employee(string a="no", decimal b=5.4564m)
            {
                this.EmpName = a;
                this.basic = b;
            }
            public  virtual void show()
            {
                Console.WriteLine("The name is-"+this.EmpName+"with employee Number"+this.Basic+".");
                Console.ReadLine();
            }
        }
        public class Manager : Employee
        {
            //public override decimal Basic { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

            public override decimal Basic
            {
                get{return this.basic;}
                set{ this.basic=Basic;}
            }
            private string empName;
            protected string EmpName
            {
                set
                {
                    if (value != "")
                    {
                        this.empName = value;
                    }
                }
                get { return empName; }
            }
            private string designation;
            protected string Designation
            {
                set
                {
                    if (value != "")
                    {
                        this.designation = value;
                    }
                }
                get { return designation; }
            }
            public Manager(string a, decimal b,string c):base(a,b)
            {
                this.EmpName = a;
                //this.basic = b;
                this.Designation = c;
            }
            public  override void show()
            {
                Console.WriteLine("The name is-" + this.EmpName + " with employee Number " + this.Basic+" with designation "+this.Designation + ".");
                Console.ReadLine();
            }
        }
    }
}
