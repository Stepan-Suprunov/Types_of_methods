// Методы, которые ничего не принимают и ничего не возвращаяют.

void Method1()
{
    Console.WriteLine("Автор ...");
}
Method1();


// Методы, которые ничего не возвращают, но могут принимать какие - либо аргументы.

void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2(msg: "Текст сообщения");

void Method21(string msg, int count)
{
    int i = 0;
    while (i<count)
    {
        Method2(msg);
        i++;
    }
}
Method21(msg: "Текст",count: 4);
Method21(count: 4, msg: "новый ттекст");


// Методы, которые что-либо возвращают, но ничего не принимают.

int Method3()
{
    return DateTime.Now.Year;
}

int year = Method3();
Console.WriteLine(year);


// Методы, которые что-либо принимают, и что-либо возвращают.

string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;

    while (i<count)
    {
        result = result + text;
        i++;
    }
    return result;
}

string res = Method4(10, "условный текст");
Console.WriteLine(res);