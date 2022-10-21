using Litware;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;






internal class Program
{
    static void Main()
    {
        Emp Obj = new Emp();
        Obj.GetData();
        Obj.Calculations();
        Obj.CalculateSalary();
        Obj.ShowData();
        Console.ReadLine();


    }
}

