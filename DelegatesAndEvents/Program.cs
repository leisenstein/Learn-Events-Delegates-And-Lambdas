using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    public delegate void WorkPerformedHandler(int hours, WorkType workType);




    class Program
    {
        static void Main(string[] args)
        {
            WorkPerformedHandler del1 = new WorkPerformedHandler(WorkPerformed1);
            WorkPerformedHandler del2 = new WorkPerformedHandler(WorkPerformed2);


            del1(5, WorkType.Golf);
            del2(10, WorkType.GoToMeetings);
            DoWork(del1);

            Console.Read();
        }

        static void DoWork(WorkPerformedHandler del)
        {
            del(20, WorkType.GenerateReports);
        }


        static void WorkPerformed1(int h, WorkType w)
        {
            Console.WriteLine("WorkPerformed1 called: " + h.ToString());
        }

        static void WorkPerformed2(int h, WorkType w)
        {
            Console.WriteLine("WorkPerformed2 called: " + h.ToString());
        }
    }

    public enum WorkType
    {
        GoToMeetings,
        Golf,
        GenerateReports
    }
}
