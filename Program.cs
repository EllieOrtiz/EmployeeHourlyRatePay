//Tarea 3
using System;

public class Demo
{
    public static void Main()   //Main es el responsable de pedirle al usuario los datos del empleado y luego mostrarlos
    {
        Empleado x = new Empleado();    //object of Empleado class

        Console.WriteLine();

        Console.WriteLine("Enter the following information:");
        Console.Write("Name: ");
        x.Name = Console.ReadLine();
        Console.Write("Social Security Number: ");
        x.SSN = Console.ReadLine();
        Console.Write("Hourly pay: ");
        x.HourlyRate = Double.Parse(Console.ReadLine());
        Console.Write("Worked hours: ");
        x.Hours = Double.Parse(Console.ReadLine());

        Console.WriteLine();

        Console.WriteLine("---Employee Information---");
        Console.WriteLine("Name: {0}", x.Name);
        Console.WriteLine("Social Security Number: {0}", x.SSN);
        Console.WriteLine("Hourly pay: {0}", x.HourlyRate);
        Console.WriteLine("Worked hours: {0}", x.Hours);
        Console.WriteLine("Total Pay: ${0}", x.TotalPay);
        Console.WriteLine();
    }
}

public class Empleado : Persona     //clase Empleado que hereda de clase Persona
{
    private double _hourlyRate;        //variables de la clase Empleado privadas
    private double _hours;

    public Empleado()   //metodo constructor
    {
        Console.WriteLine("Empleado Object Constructed");
    }

    ~Empleado()     //metodo destructor
    {
        Console.WriteLine("Empleado Object Destroyed");
    }

    public double HourlyRate
    {
        get { return this._hourlyRate; }
        set { this._hourlyRate = value; }
    }

    public double Hours
    {
        get { return this._hours; }
        set { this._hours = value; }
    }

    public string Name
    {
        get { return this.nombre; }
        set { this.nombre = value; }
    }

    public string SSN
    {
        get { return this.segsoc; }
        set { this.segsoc = value; }
    }

    public double TotalPay      //Propiedad para el calculo de paga * hora
    {
        get { return this._hours * this._hourlyRate; }
    }
}

public class Persona       //No tocar clase Persona
{
    protected string nombre, segsoc;

    //Constructor
    //No recibe ningún dato para crear a la persona.
    //Pone datos por defecto.
    public Persona()
    {
        nombre = "";
        segsoc = "";
        Console.WriteLine("Persona Object Costructed.");
    }

    //Destructor
    ~Persona()
    {
        Console.WriteLine("Persona Object Destroyed.");
    }
}   //no tocar clase Persona