using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace excercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalage, totaldays;
            student s = new student();
            s.firstname = "jeevan";
            s.lastname = "teja";
            s.dob = new DateTime(1992,1,01);
            s.calculateage(out totalage, out totaldays);
            s.gender = Enum.GetName(typeof(Gender),2);
            
                Console.WriteLine(s.firstname+" "+s.lastname+" "+s.dob+" "+totalage+" "+s.gender);
            Console.ReadLine();
        }
    }
    public enum Gender
    {
        unknown = 1,
        male = 2,
        female = 3
    }
    public class student
    {
        public string firstname;
        public string lastname;
        public DateTime dob;
        public string gender;
        public void calculateage(out int age, out int days)
        {
            
            days = (DateTime.Now.Year * 365 + DateTime.Now.DayOfYear) - (dob.Year * 365 + DateTime.Now.DayOfYear);
            age = days/365;
        }
    }
}
