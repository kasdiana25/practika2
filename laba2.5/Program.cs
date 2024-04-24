using System;

namespace GarageConsoleApp
{
    /// <summary>
    /// Класс Program
    /// здесь описываем логику приложения
    /// вызываем нужные методы пишем обработчики и тд
    /// </summary>
    public class Program 
    {
        public static void Main(string[] args)
        {
            // Вызовем метод для получения данных о водителях
            DatabaseRequests.GetDriverQuery();
            Console.WriteLine();
            // Добавим нового водителя в БД
            DatabaseRequests.AddDriverQuery("Денис", "Иванов", DateTime.Parse("1997.01.12"));
            // Вызовем метод для получения данных о водителях
            DatabaseRequests.GetDriverQuery();
        
            // Вызовем метод для получения данных о типах автомобилей
            DatabaseRequests.GetTypeCarQuery();
            Console.WriteLine();
            // Добавим новый тип автомобиля в БД
            DatabaseRequests.AddTypeCarQuery("Воздушный");
            // Вызовем метод для получения данных о типах автомобилей
            DatabaseRequests.GetTypeCarQuery();
            
            // Вызовем метод для получения и добавления прав водителя
            
            int driver = Convert.ToInt32(Console.ReadLine());
            DatabaseRequests.GetDriverRightsCategoryQuery(driver);
            int rightsCategory = Convert.ToInt32(Console.ReadLine());
            DatabaseRequests.GetDriverRightsCategoryQuery(driver);
            Console.WriteLine("Введите категорию прав: ");
            DatabaseRequests.AddDriverRightsCategoryQuery(driver, rightsCategory);
            
            // Вызовем метод для просмотра и добавления машин
            DatabaseRequests.GetCarQuery();
            Console.WriteLine("Введите новую машину: ");
            int idTypeCar = Convert.ToInt32(Console.ReadLine());
            string name = Console.ReadLine();
            string stateNumber = Console.ReadLine();
            int numPassengers1 = Convert.ToInt32(Console.ReadLine());
            DatabaseRequests.AddCarQuery(idTypeCar, name, stateNumber, numPassengers1);
            
            //Вызовем метод для просмотра и добавления маршрутов
            DatabaseRequests.GetRouteQuery();
            Console.WriteLine("Введите новый маршрут: ");
            int driverId = Convert.ToInt32(Console.ReadLine());
            int carId = Convert.ToInt32(Console.ReadLine()); 
            int itineraryId = Convert.ToInt32(Console.ReadLine());
            int numPassengers = Convert.ToInt32(Console.ReadLine());
            DatabaseRequests.AddRouteQuery(driverId, carId, itineraryId, numPassengers);
            
            //Вызовем метод для просмотра и добавления рейсов
            DatabaseRequests.GetRouteQuery();
            Console.WriteLine("Введите новый рейс: ");
            DatabaseRequests.AddRouteQuery(4, 2, 1, 4);
        }
    }
}

