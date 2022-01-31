using System;

namespace C_Course
{
    class Program
    {
        static void Main(string[] args)
        {
            HelloWorld hello = new HelloWorld();
            hello.HelloWorldPrint();
            Challenge1 challenge = new Challenge1();
            //challenge.Survery();
            Challenge2 challenge2 = new Challenge2();
            //challenge2.Passcode();
            ForLoop forLoop = new ForLoop();
            //forLoop.ForLoopPractice();
            Challenge3 challenge3 = new Challenge3();
            //challenge3.LoopCounting();
            SchoolTracker schoolTracker = new SchoolTracker();
            //schoolTracker.SchoolTracking();
            JobCanidate job = new JobCanidate();
            //job.Program();
        }
    }
}
