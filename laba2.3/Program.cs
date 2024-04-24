/*  Задание 1-2
using System;
class Worker
{
    private string Name;

    public string name
    {
        get {return Name;}
        set {Name = value;}
    }
    private string Surname;

    public string surname
    {
        get { return Surname; }
        set { Surname = value; }
    }
    private int Rate;

    public int rate
    {
        get { return Rate; }
        set { Rate = value; }
    }
    private int Days;

    public int days
    {
        get { return Days; }
        set { Days = value; }
    }

    public int GetSalary(int zarplata)
    {
        zarplata = rate * days;
        return zarplata;
    }
}

class Program
{
    static void Main()
    {
        Worker worker = new Worker();
        Console.WriteLine("Введите имя и фамилию: ");
        worker.name = Console.ReadLine();
        worker.surname = Console.ReadLine();
        worker.rate = 3000;
        worker.days = Convert.ToInt32(Console.ReadLine());
        
        int zarplata = 0;
        int a = worker.GetSalary(zarplata);
        Console.WriteLine(a);
    }
}*/

/*Задание 3
using System;
class Calculation
{
    public int calculationLine { get; set; }

    public void SetCalculationLine()
    {
        calculationLine += 100;
    }

    public void SetLastSymbolCalculationLine()
    {
        calculationLine *= 10;
        calculationLine += 4;
    }

    public void GetCalculationLine()
    {
        Console.WriteLine(calculationLine);
    }

    public void GetLastSymbol()
    {
        calculationLine %= 10;
    }

    public void DeleteLastSymbol()
    {
        calculationLine /= 10;
    }
}

class Program
{
    static void Main()
    {
        Calculation calculation = new Calculation();
        calculation.calculationLine = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Измененное число: ");
        calculation.SetCalculationLine();
        calculation.GetCalculationLine();
        Console.WriteLine("Добавление символа в конец строки: ");
        calculation.SetLastSymbolCalculationLine();
        calculation.GetCalculationLine();
        Console.WriteLine("Удаление последнего символа: ");
        calculation.DeleteLastSymbol();
        calculation.GetCalculationLine();
    }
}*/
