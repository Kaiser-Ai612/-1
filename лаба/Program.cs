// See https://aka.ms/new-console-template for more information
using System;
Console.WriteLine("кто вы?");
string rt = Console.ReadLine();
if ((rt == "пенсионер" || rt == "студент"))
{
    Console.WriteLine("вы трудоустроены?");
    string rq = Console.ReadLine();
    if (rq == "Нет")
    {
        Console.WriteLine("получаете кредит");
    }
    else
    {
        Console.WriteLine(" не получаете кредит");
    }
}
else
{
    Console.WriteLine(" не получаете кредит");
}