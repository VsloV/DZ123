2// See https://aka.ms/new-console-template for more information

//1

const double pi = Math.PI;
Console.WriteLine("Какой радиус окружности:");
double circle = double.Parse(Console.ReadLine());
double square = pi * circle * circle;
Console.WriteLine($"Площадь круга равна:{square:F4}");

//2

Console.Write("Введите ваши ФИО: ");
string name = Console.ReadLine();
Console.Write("Ведите ваш пол:");
string paul = Console.ReadLine();
Console.Write("Ведите ваш возраст:");
int age = int.Parse(Console.ReadLine());
Console.Write("Введите ваш город:");
string city = Console.ReadLine();

Console.WriteLine($"Имя:{name}");
Console.WriteLine($"Пол:{paul}");
Console.WriteLine($"Возраст:{age}");
Console.WriteLine($"Город:{city}");

