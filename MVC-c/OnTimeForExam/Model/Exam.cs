using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTimeForExam.Model
{
    public class Exam
    {
        private int examHour;
        private int examMinute;
        private int examArrivedHour;
        private int examArrivedMinute;

        public Exam(int examHour, int examMinute, int examArrivedHour, int examArrivedMinute)
        {
            ExamHour = examHour;
            ExamMinute = examMinute;
            ExamArrivedHour = examArrivedHour;
            ExamArrivedMinute = examArrivedMinute;
        }

        public int ExamHour
        {
            get { return examHour; }
            set
            {
                if (ExamHour < 0) { throw new ArgumentException("ëror"); }
                examHour = value; 
            }
        }
        public int ExamMinute
        {
            get { return examMinute; }
            set
            {
                if (ExamHour < 0) { throw new ArgumentException("ëror"); }
                examMinute = value;
            }
        }
        public int ExamArrivedHour
        {
            get { return examArrivedHour; }
            set 
            {if (ExamHour < 0)
                {
                    throw new ArgumentException("ëror");
                }
                examArrivedHour = value; }
        }
        public int ExamArrivedMinute
        {
            get { return examArrivedMinute; }
            set
            {
                if (ExamHour < 0) { throw new ArgumentException("ëror"); }
                examArrivedMinute = value;
            }
        }

        public string OutPutOnTime()
        {
            int timexam =( (examHour * 60) + examMinute);
            int timeArrived=((examArrivedHour*60)+ examArrivedMinute);
            int timeDifference = (timexam - timeArrived);
            string result=string.Empty;
            if (timeDifference<=-30)
            {
                result=($"Early, {timeDifference}  minutes before the start");
            }
            else if (timeDifference>30&&timeDifference<60)
            {
                result=($"On time, {timeDifference} minutes left");
            }
            else if(timeDifference>60)
            {
               result=($"Late, {timeDifference} minutes after the start.");
            }
            return result;
        }
    }
}
