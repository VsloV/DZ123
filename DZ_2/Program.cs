// See https://aka.ms/new-console-template for more information
Console.WriteLine("Используя константы,напишите программу для перевода миллиметров в:A)сантиметры B)метры C)километры D)миля E)ярды");

//A
//миллиметры в сантиметры
//const float sm = 0.01f;
//Console.Write("Введите миллиметры:");
//double mm = double.Parse(Console.ReadLine());
//double res = sm * mm;
//Console.WriteLine($"{mm} миллиметры {res:F2} сантиметров");

//B
//////миллиметр в метры
//const float m = 0.001f;
//Console.WriteLine("Введите милиметры:");
//double mm = double.Parse(Console.ReadLine());
//double res = m * mm;
//Console.WriteLine($"{m} милиметров {res:F2} метров");

//C
//////миллиметры в километры 
//const float km = 0.000001f;
//Console.WriteLine("Введите милиметры:");
//double mm = double.Parse(Console.ReadLine());
//double sum = km * mm;
//Console.WriteLine($"{mm} милиметров {sum} километров");

//D
//////миллиметры в мили
//Console.WriteLine("Введите милиметры:");
//double mm = double.Parse(Console.ReadLine());
//double res = mm / 1609344;
//Console.WriteLine($"{mm} мили {res:F2} мили");

//E
//////миллиметр в ярды
const float yard = 0.0011f;
Console.Write("Введите миллиметры:");
double mm = double.Parse(Console.ReadLine());
double res = yard * mm;
Console.WriteLine($"{mm} миллиметров {res:F3} ярдов");
