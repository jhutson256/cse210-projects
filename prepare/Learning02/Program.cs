using System;

class Program
{
    static void Main(string[] args)
    {
        jph_Job jph_Job1 = new jph_Job();
        jph_Job1._jphjobTitle = "Software Engineer";
        jph_Job1._jphcompany = "Microsoft";
        jph_Job1._jphstartYear = 2019;
        jph_Job1._jphendYear = 2022;

        jph_Job jph_Job2 = new jph_Job();
        jph_Job2._jphjobTitle = "CEO";
        jph_Job2._jphcompany = "Apple";
        jph_Job2._jphstartYear = 2022;
        jph_Job2._jphendYear = 2023;

        jph_Resume jph_myResume = new jph_Resume();
        jph_myResume._jphname = "Jacob Hutson";

        jph_myResume._jphjobs.Add(jph_Job1);
        jph_myResume._jphjobs.Add(jph_Job2);

        jph_myResume.Display();
    }
}