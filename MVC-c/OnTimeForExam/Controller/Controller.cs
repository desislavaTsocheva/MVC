using OnTimeForExam.Model;
using OnTimeForExam.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTimeForExam.Controller
{
    public class Controller
    {
        Display newDisplay = new Display();
        public Exam CurrentExams;

        public Controller()
        {
            newDisplay.InPut();
            CurrentExams = new Exam(newDisplay.ExamHour, newDisplay.ExamMinute, newDisplay.ExamArrivedHour, newDisplay.ExamArrivedMinute);
            string resultat = CurrentExams.OutPutOnTime();
            newDisplay.Result=resultat;
            newDisplay.OutPut();
        }
    }
}
