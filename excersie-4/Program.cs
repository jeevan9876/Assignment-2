using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace excersie_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string type;
            Console.WriteLine("Please enter type of employee");
            type = Console.ReadLine();
            employee e = new employee();
            Console.WriteLine("Please enter the firstname of employee");
            e.firstname = Console.ReadLine();
            Console.WriteLine("Please enter the lastname of employee");
            e.lastname = Console.ReadLine();
           
            if(type == "F")
            {
                fulltimeemployee fe = new fulltimeemployee();
                Console.WriteLine("Please enter the joining date of employee in yyyy/mm/dd format");
                fe.hiredate = Convert.ToDateTime(Console.ReadLine());
                Console.WriteLine("Please enter the salary per annum");
                fe.salary = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(e.firstname + " " + e.lastname + " " + " is hired on " + e.hiredate + " and annual salary is "+fe.salary);
            }
            else if(type == "C")
            {
                contractemployee ce = new contractemployee();
                Console.WriteLine("Please enter the joining date of employee in yyyy/mm/dd format");
                ce.hiredate = Convert.ToDateTime(Console.ReadLine());
                Console.WriteLine("Please enter the contract end date");
                ce.contractenddate = Convert.ToDateTime(Console.ReadLine());
                Console.WriteLine("Please enter the hourly pay");
                ce.hourlypay = Convert.ToInt32(Console.ReadLine());
                int p = ce.calculateperiod();
                Console.WriteLine(e.firstname + " " + e.lastname + " " + " is hired on " + e.hiredate + " and contract ends in " + p + " months");
            }
            else
            {
                Console.WriteLine("Please enter either F or C");
            }
            Console.ReadLine();
        }
    }

    public class employee
    {
        public string firstname;
        public string lastname;
        public DateTime hiredate;
        public string address;
    }

    public class fulltimeemployee:employee
    {
        public int salary;

    }
    public class contractemployee:employee
    {
        public int hourlypay;
        public DateTime contractenddate;
        public int calculateperiod()
        {
            int period;
            period = ((contractenddate.Year - hiredate.Year) * 12) + contractenddate.Month - hiredate.Month;
            return period;
        }
    }
}
