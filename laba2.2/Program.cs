/*Задание1
using System;
class Student
{
    public string SecondName { get; set; }
    public DateTime Birthday { get; set; }
    public string NumberGroup { get; set; }
    public int[] Grades { get; set; }

    public void ChangendSecondName(string newSecondName)
    {
        SecondName = newSecondName;
    }

    public void ChangendBirthday(DateTime newBirthday)
    {
        Birthday = newBirthday;
    }

    public void ChangendNumberGroup(string newNumberGroup)
    {
        NumberGroup = newNumberGroup;
    }

    public void Print()
    {
        Console.WriteLine("Фамилия: " + SecondName);
        Console.WriteLine("Дата рождения: " + Birthday.ToShortDateString());
        Console.WriteLine("Номер группы: " + NumberGroup);
        Console.WriteLine("Успеваемость: ");
        foreach (var n in Grades)
        {
            Console.Write(n + " ");
        }
        Console.WriteLine();
    }
}

class Program
{
    static void Main()
    {
        Student student = new Student();
        student.Grades = new int[5] { 2, 5, 3, 4, 5};
        Console.WriteLine("Введите фамилию: ");
        student.SecondName = Console.ReadLine();

        Console.WriteLine("Введите дату рождения: ");
        student.Birthday = Convert.ToDateTime(Console.ReadLine());

        student.NumberGroup = "622";
        student.Print();

        Console.WriteLine("Введите новую фамилию: ");
        string newSecondName = Console.ReadLine();
        student.ChangendSecondName(newSecondName);

        Console.WriteLine("Введите новую дату рождения: ");
        DateTime newBirthday = Convert.ToDateTime(Console.ReadLine());
        student.ChangendBirthday(newBirthday);

        Console.WriteLine("Введите новый номер группы: ");
        string newNumberGroup = Console.ReadLine();
        student.ChangendNumberGroup(newNumberGroup);
        
        student.Print();

    }
}*/

/* Задание 2
using System;

class Train
{
    public string Destination { get; set; }
    public int NumberTrain { get; set; }
    public DateTime DepartureTime { get; set; }

    public void Print()
    {
        Console.WriteLine($"Поезд {NumberTrain} отправляется в {Destination} в {DepartureTime}" );
    }
}

class Program
{
    static void Main()
    {
        Train train1 = new Train();
        train1.Destination = "Tomsk";
        train1.NumberTrain = 12;
        train1.DepartureTime = new DateTime(2024, 05, 25, 5, 30, 0);

        Train train2 = new Train();
        train2.Destination = "Novosibirsk";
        train2.NumberTrain = 22;
        train2.DepartureTime = new DateTime(2024, 05, 22, 16, 30, 0);

        Console.WriteLine("Введите номер поезда: ");
        int num = Convert.ToInt32(Console.ReadLine());
        if (num == train1.NumberTrain)
        {
            train1.Print();
        }
        else if (num == train2.NumberTrain)
        {
            train2.Print();
        }
        else
        {
            Console.WriteLine("Ошибка");
        }

    }
}*/

/* Задание 3
using System;
class Numbers
{
    public int num1 { get; set; }
    public int num2 { get; set; }

    public void Print()
    {
        Console.WriteLine(num1);
        Console.WriteLine(num2);
    }

    public void ChangendNum(int newNum1, int newNum2)
    {
        num1 = newNum1;
        num2 = newNum2;
    }

    public int SumNum()
    {
        int sum = num1 + num2;
        return sum;
    }

    public int Maxnum()
    {
        if (num1 > num2)
        {
            return num1;
        }
        else
        {
            return num2;
        }
    }
}

class Program
{
    static void Main()
    {
        Numbers nums = new Numbers();
        Console.WriteLine("Введите первое число: ");
        nums.num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите второе число: ");
        nums.num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Вывод чисел: ");
        nums.Print();

        Console.WriteLine("Сумма чисел: ");
        int sum = nums.SumNum();
        Console.WriteLine(sum);

        Console.WriteLine("Введите первое новое число: ");
        int newNum1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите новое второе число: ");
        int newNum2 = Convert.ToInt32(Console.ReadLine());
        
        nums.ChangendNum(newNum1, newNum2);

        Console.WriteLine("Наибольшее число: ");
        int max = nums.Maxnum();
        Console.WriteLine(max);
    }
}*/

/* Задание 4
using System;
using System.Threading.Channels;

class Counter
{
    public int Num { get; set; }

    public Counter(int initialization)
    {
        Num = initialization;
    }

    public void Increase()
    {
        Num++;
    }

    public void Downgrade()
    {
        Num--;
    }

    public int Print()
    {
        return Num;
    }
    
}

class Program
{
    static void Main()
    {
        Counter num1 = new Counter(52);
        Console.WriteLine("Значение первого числа: " + num1.Print());
        num1.Increase();
        num1.Increase();
        Console.WriteLine("Первое число после 2 прибавлений: " + num1.Print());
        num1.Downgrade();
        Console.WriteLine("Первое число после убавления: " + num1.Print());

        Console.WriteLine("\n Введите второе число: ");
        int initialization = Convert.ToInt32(Console.ReadLine());
        Counter num2 = new Counter(initialization);
        Console.WriteLine("Значение второго числа: " + num2.Print());
        num2.Increase();
        num2.Increase();
        Console.WriteLine("Второе число после 2 прибавлений: " + num2.Print());
        num2.Downgrade();
        Console.WriteLine("второе число после убавления: " + num2.Print());
    }
}*/

/*Задание 5
using System;
using System.Dynamic;

public class MyClass : IDisposable
{
    public int number { get; set; }
    public string text { get; set; }

    public MyClass(int num, string text1)
    {
        number = num;
        text = text1;
    }

    public MyClass()
    {
        number = 0;
        text = null;
    }

    public void Dispose()
    {
        Console.WriteLine("Объекты удалены");
    }

    public void Print()
    {
        Console.WriteLine("Цифра: " + number);
        Console.WriteLine("Текст: " + text);
    }
}

class Program
{
    static void Main()
    {
        MyClass a = new MyClass(5, "Diana");
        Console.WriteLine("Значение первого объекта: ");
        a.Print();
        a.Dispose();

        MyClass b = new MyClass();
        Console.WriteLine("Значение второго объекта: ");
        b.Print();
        b.Dispose();
    }
}*/
