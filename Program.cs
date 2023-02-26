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

void PrintArray(string[] printArr)
{
    Console.Write("[");
    for (int i = 0; i < printArr.Length; i++)
    {
        if (i == printArr.Length - 1)
            Console.Write($"\"{printArr[i]}\"");
        else
            Console.Write($"\"{printArr[i]}\", ");
    }
    Console.Write("]");
}

string[] testArray = { "hello", "2", "world", ":-)" };
PrintArray(testArray);