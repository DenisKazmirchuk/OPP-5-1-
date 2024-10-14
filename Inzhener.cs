using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class Inzhener : Persone, IWorker
{
    private double _monthlySalary;

    public Inzhener(string name, int stag_rob, double monthlySalary)
        : base(name, stag_rob)
    {
        _monthlySalary = monthlySalary;
    }

    // Реалізація методу Zarplata
    public double Zarplata()
    {
        return _monthlySalary;  // Фіксована зарплата
    }

    // Реалізація методу Role
    public string Role()
    {
        return "Інженер";
    }
}
