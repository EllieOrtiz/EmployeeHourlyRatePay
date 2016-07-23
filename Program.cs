//Tarea 3
using System;

public class Demo
{
    public static void Main()   //Main es el responsable de pedirle al usuario los datos del empleado y luego mostrarlos
    {
        Empleado x = new Empleado();    //objeto de la clase Empleado

        Console.WriteLine();

        Console.WriteLine("Entre los datos siguientes:");
        Console.Write("Nombre: ");
        x.Name = Console.ReadLine();
        Console.Write("Seguro Social: ");
        x.SSN = Console.ReadLine();
        Console.Write("Paga por hora: ");
        x.HourlyRate = Double.Parse(Console.ReadLine());
        Console.Write("Horas trabajadas: ");
        x.Hours = Double.Parse(Console.ReadLine());

        Console.WriteLine();

        Console.WriteLine("---Datos del Empleado---");
        Console.WriteLine("Nombre: {0}", x.Name);
        Console.WriteLine("Seguro Social: {0}", x.SSN);
        Console.WriteLine("Paga por hora: {0}", x.HourlyRate);
        Console.WriteLine("Horas trabajadas: {0}", x.Hours);
        Console.WriteLine("Paga: ${0}", x.TotalPay);
        Console.WriteLine();
    }
}

public class Empleado : Persona     //clase Empleado que hereda de clase Persona
{
    private double _hourlyRate;        //variables de la clase Empleado privadas
    private double _hours;

    public Empleado()   //metodo constructor
    {
        Console.WriteLine("Objeto Empleado construido");
    }

    ~Empleado()     //metodo destructor
    {
        Console.WriteLine("Objeto Empleado destruido");
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
        Console.WriteLine("Objeto Persona construido.");
    }

    //Destructor
    ~Persona()
    {
        Console.WriteLine("Objeto Persona destruido.");
    }
}   //no tocar clase Persona