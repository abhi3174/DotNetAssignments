using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBasics
{
    class Office
    {
        static void Main(string[] args)
        {
            employee a = new employee("a", 1000.5m);
            employee b = new employee("b", 123000.5m);
            employee c = new employee("c", 1004340.5m);
            a.show();
            b.show();
            c.show();

        }
    }
    class employee
    {
        private static int counter=0;
        private string name;
        public string Name
        {
        get{return name;}
        set{name=value;}
        }
        private int Empno;
        private decimal basic;
        private short deptno;
        public employee()
        {
            counter = counter + 1;
            Empno = counter;
        }
        public employee(string n,decimal b)
        {
            counter = counter + 1;
            Empno = counter;
            name = n;
            basic = b;
        }
        public void show()
        {
            Console.WriteLine("Name of employee is "+name+" with EmployeeId "+Empno+" and Basic as "+ basic);
            Console.ReadLine();
        }
    }
}