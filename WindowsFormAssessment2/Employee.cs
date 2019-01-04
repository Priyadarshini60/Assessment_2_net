using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormAssessment2
{
    class Employee : IEmployee
    {
        private object p1;
        private int v;
        private object p2;

        public Employee()
        {

        }

        public Employee(object p1, int v, object p2)
        {
            this.p1 = p1;
            this.v = v;
            this.p2 = p2;
        }

        public Employee(string nm,string des,int ag,int sal)
        {
            name = nm;
            design = des;
            age = ag;
            salary = sal;
        }
        public string name { get ; set ; }
        public string design { get; set; }
        public int age { get; set; }
        public int salary { get; set; }
    }
}
