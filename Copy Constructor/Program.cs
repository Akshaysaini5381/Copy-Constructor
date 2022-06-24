using System;

namespace test_program
{

    class Employee
    {
        private int empno;
        private string empname;
        public Employee(int Empno, string Empname)
        {
            this.empno = Empno;
            this.empname = Empname;
        }
        public Employee(Employee E1)
        {
            this.empno = E1.empno;
            this.empname = E1.empname;
        }
        public void display()
        {
            Console.WriteLine("Copy Constructor :"+empno + " " + empname);
        }
    }
    class Demo
    {
        static void Main(string[] args)
        {
            Employee obj = new Employee(10, "akshay");
            // copy obj
             Employee obj2 = new Employee(obj);
            obj.display();
            obj2.display();

        }
    }
}

