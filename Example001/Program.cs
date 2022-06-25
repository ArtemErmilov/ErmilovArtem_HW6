/*
Задача 1: Пользователь вводит с клавиатуры M чисел.
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
-1, -7, 567, 89, 223-> 3
*/

int Prompt(string message) // Ввод числа ( функция )
{
    Console.Write(message);
    string a_String = Console.ReadLine();
    return  int.Parse(a_String);
}

int positiveNumbersQuantity(int [] array) // Функция нахождения положительных элементов массива
{
    int quan = 0;
    foreach (int element in array)
    {
        if (element>0) quan++;
    }

    return quan;
}


int amount = new Random().Next(3,10);

int[] array = new int [amount];
for (int i = 0; i < amount; i++)
{
    array[i] = Prompt( "Введите число => ");
}

Console.WriteLine($@"Вы ввели положительных чисел {positiveNumbersQuantity(array)} ");