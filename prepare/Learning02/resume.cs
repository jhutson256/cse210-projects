using System;

public class jph_Resume
{
    public string _jphname;

    public List<jph_Job> _jphjobs = new List<jph_Job>();

    public void Display()
    {
        Console.WriteLine($"Name: {_jphname}");
        Console.WriteLine("Jobs:");

        foreach (jph_Job job in _jphjobs)
        {
              job.Display();
        }
    }
}