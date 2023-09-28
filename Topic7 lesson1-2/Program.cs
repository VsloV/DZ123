// See https://aka.ms/new-console-template for more information

//1

const double Pi = Math.PI;
Console.WriteLine("Какой радиус окружности:");
double Circle = double.Parse(Console.ReadLine());
double Square = Pi * Circle * Circle;
Console.WriteLine($"Площадь круга равна:{Square:F4}");

//2

Console.Write("Введите ваши ФИО: ");
string Name = Console.ReadLine();
Console.Write("Ведите ваш пол:");
string Paul = Console.ReadLine();
Console.Write("Ведите ваш возраст:");
int Age = int.Parse(Console.ReadLine());
Console.Write("Введите ваш город:");
string City = Console.ReadLine();

Console.WriteLine($"Имя:{Name}");
Console.WriteLine($"Пол:{Paul}");
Console.WriteLine($"Возраст:{Age}");
Console.WriteLine($"Город:{City}");

