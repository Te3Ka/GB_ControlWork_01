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

string[] ThreeCharArray(string[] userArray)
{
    int count = 0;
    for (int i = 0; i < userArray.Length; i++)
    {
        if (userArray[i].Length <= 3)
            count++;
    }
    Console.WriteLine($"count = {count}");
    string[] finishArray = new string[count];
    
    return finishArray;
}

string[] testArray = { "hello", "2", "world", ":-)" };
string[] testArray2 = { "1234", "1567", "-2", "computer science" };
string[] testArray3 = { "Russia", "Denmark", "Kazan" };

string[] threeCharArray = ThreeCharArray(testArray3);