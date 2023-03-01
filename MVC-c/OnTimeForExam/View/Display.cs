using OnTimeForExam.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTimeForExam.View
{
    public class Display
    {
        public int ExamHour { get; set; }
        public int ExamMinute { get; set; }
        public int ExamArrivedHour { get; set; }
        public int ExamArrivedMinute { get; set; }

        public string Result { get; set; }
        public void InPut()
        {
            Console.WriteLine("Enter exam hour");
            int examHour=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter exam minute");
            int examMinute=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter exam arrived hour");
            int examArrivedHour=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter exam arrived minute");
            int examArrivedMinute=int.Parse(Console.ReadLine());
            //CurrentExam = new Exam(examHour, examMinute, examArrivedHour, examArrivedMinute);
            
        }
        public void OutPut()
        {
            Console.WriteLine(this.Result);
        }
    }
}
