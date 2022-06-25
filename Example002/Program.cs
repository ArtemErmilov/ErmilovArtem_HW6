/*
Задача 2. Напишите программу, которая найдёт точку
пересечения двух прямых, заданных уравнениями y = k1 *
x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются
пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 =
9 -> (-0,5; -0,5)
*/


double Prompt(string message) // Ввод числа ( функция )
{
    Console.Write(message);
    string a_String = Console.ReadLine();
    return double.Parse(a_String);
}

void intersectionPoint(double b1, double k1, double b2, double k2)
{
    double x =(b2-b1)/(k1-k2);
    double y = k1*x+b1;
    
  if (k1!=k2)  Console.WriteLine($"Координаты точек пересечения 2-х линий ( {x} ; {y})");
  else Console.WriteLine(" Прямые общих точек пересечения НЕ имеют");
}

Console.WriteLine("Введите параметры 1-й линии: ");

double b1 = Prompt("b1 => ");
double k1 = Prompt("k1 => ");

Console.WriteLine("Введите параметры 2-й линии: ");

double b2 = Prompt("b2 => ");
double k2 = Prompt("k2 => ");


intersectionPoint(b1,k1,b2,k2);