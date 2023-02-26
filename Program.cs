/***********************/
/*****Te3Ka_PaynE*******/
/*Mnement4813@yandex.ru*/
/***********************/

/*
Написать программу, которая из имеющегося массива строк формирует массив из строк,
длина которых меньше либо равна 3 символам.

["hello", "2", "world", ":-)"] -> ["2", ":-)"]
["1234", "1567", "-2", "computer science"] -> ["-2"]
["Russia", "Denmark", "Kazan"] -> []
*/

//Метод с указанием автора
void Author()
{
    Console.WriteLine();
    Console.WriteLine("Программа создана Te3Ka_PaynE.");
    Console.WriteLine("E-mail: Mnement4813@yandex.ru");
    Console.WriteLine();
}

// Метод для ввода массива строк от пользователя
string[] UserInputArray(int num)
{
    string[] array = new string[num];
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите строку №{i}: ");
        array[i] = Console.ReadLine()!;
    }
    return array;
}

// Метод для создания нового массива из 3 и меньше символов
string[] ThreeCharArray(string[] userArray)
{
    int count = 0;
    for (int i = 0; i < userArray.Length; i++)
    {
        if (userArray[i].Length <= 3)
            count++;
    }
    string[] finishArray = new string[count];
    count = 0;
    for (int i = 0; i < userArray.Length; i++)
    {
        if (userArray[i].Length <= 3)
        {
            finishArray[count] = userArray[i];
            count++;
        }
    }    
    return finishArray;
}

Console.WriteLine("Программа запрашивает от пользователя массив строк.\n"
                + "Выводит все строки состоящие из 3 и меньше символов в новый массив.");
Console.WriteLine("Сколько будет строк в изначальном массиве?");
Console.Write(">>: ");
int.TryParse(Console.ReadLine(), out int num);
while (num <= 0)
{
    Console.WriteLine("Число меньше 1! Невозможно создать массив. Введите заново: ");
    int.TryParse(Console.ReadLine(), out num);
}
string[] userArray = UserInputArray(num);
string[] threeCharArray = ThreeCharArray(userArray);