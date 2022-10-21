 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Litware
{
    public class Emp
{
    int EmpNo;
    string EmpName;
    double Salary;
    double HRA;
    double TA;
    double DA;
    double PF;
    double TDS;
    double NetSalary;
    double GrossSalary;

    public void GetData()
    {
        Console.WriteLine("Enter Employee number. - ");
        EmpNo = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the Employee Name - ");
        EmpName = Console.ReadLine();
        Console.WriteLine("Enter the Employee Salary - ");
        Salary = Convert.ToDouble(Console.ReadLine());

    }
    public void Calculations()
    {
        if (Salary <= 5000)
        {
            HRA = 10 * (Salary / 100);
            TA = 5 * (Salary / 100);
            DA = 15 * (Salary / 100);

        }
        else if (Salary <= 10000)
        {
            HRA = 15 * (Salary / 100);
            TA = 10 * (Salary / 100);
            DA = 20 * (Salary / 100);
        }
        else if (Salary <= 15000)
        {
            HRA = 20 * (Salary / 100);
            TA = 15 * (Salary / 100);
            DA = 25 * (Salary / 100);
        }
        else if (Salary <= 20000)
        {
            HRA = 25 * (Salary / 100);
            TA = 20 * (Salary / 100);
            DA = 30 * (Salary / 100);
        }
        else
        {
            HRA = 30 * (Salary / 100);
            TA = 25 * (Salary / 100);
            DA = 35 * (Salary / 100);
        }

        GrossSalary = Salary + HRA + TA + DA;

    }

    public void CalculateSalary()
    {
        PF = 10 * (GrossSalary / 100);
        TDS = 18 * (GrossSalary / 100);
        NetSalary = GrossSalary - (PF + TDS);
    }

    public void ShowData()
    {
        Console.WriteLine("Employee Name - " + EmpName);
        Console.WriteLine("Employee No. - " + EmpNo);
        Console.WriteLine("Employee Salary - " + Salary);
        Console.WriteLine("Employee HRA - " + HRA);
        Console.WriteLine("Employee TA - " + TA);
        Console.WriteLine("Employee DA - " + DA);
        Console.WriteLine("Employee PF - " + PF);
        Console.WriteLine("Employee TDS - " + TDS);
        Console.WriteLine("Employee Net Salary - " + NetSalary);
        Console.WriteLine("Employee Gross Salary - " + GrossSalary);
    }
}

}
