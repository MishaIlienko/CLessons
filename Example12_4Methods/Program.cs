// Метод №1 - Void, который НЕ принимает аргументов и НЕ возвращает значения.

using System.Data;

void Method1()
{
    System.Console.WriteLine("Текст1....");
}
Method1();

// Meтод №2 - Void, который пнригимает аргументы, и НЕ возвращает значения.

void Method2(string msg)
{
    System.Console.WriteLine(msg);
}
Method2("Текст2....");
System.Console.WriteLine();

// В методе 2, также можно указывать несколько аргументов, 
//и вызывать разниыми способами (именнованными аргументами, и просто по порядку).

void Method21(string sms, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(sms);
        i++;
    }


}
Method21(sms: "Текст3", count: 3);

// Метод 3-го типа НЕ принимает аргументов и возвращает значение

int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
System.Console.WriteLine(year);

// 4-й тип метода принимает аргументы и возвращает значения

string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;
    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}
string res = Method4(text: "Текст4 ", count: 3);
System.Console.WriteLine(res);