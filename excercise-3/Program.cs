using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace excercise_3
{
    class Program
    {
        static void Main(string[] args)
        {

            int x, ag;
            Console.WriteLine("Please enter the no of students ");
            x = Convert.ToInt32(Console.ReadLine());
            student[] arr = new student[x];
            ArrayList odd = new ArrayList();
            ArrayList even = new ArrayList();
            for(int i=0;i<x;i++)
            {
                arr[i] = new student();
                Console.WriteLine("Please enter the firstname");
                arr[i].firstname = Console.ReadLine();
                Console.WriteLine("Please enter the lastname");
                arr[i].lastname = Console.ReadLine();
                Console.WriteLine("Please enter the dob");
                arr[i].dob = Convert.ToDateTime(Console.ReadLine());
                arr[i].calculateage(out ag);
                if(ag % 2 == 0)
                {
                    even.Add(arr[i]);
                }
                else
                {
                    odd.Add(arr[i]);
                }
                

            }
            Hashtable std = new Hashtable();
            std.Add("odd", odd);
            std.Add("even", even);
            
            foreach(student s in odd)
            {
                Console.WriteLine(s.firstname);
            }
            Console.ReadLine();
        }

    }
    public class student
    {
        public string firstname, lastname;
        public DateTime dob;
        public string gender;
        public void calculateage(out int age)
        {
            int days;
            days = (DateTime.Now.Year * 365 + DateTime.Now.DayOfYear) - (dob.Year * 365 + DateTime.Now.DayOfYear);
            age = days / 365;
        }
    }
}
