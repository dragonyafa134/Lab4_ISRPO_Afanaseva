// See https://aka.ms/new-console-template for more information
using System.Linq.Expressions;

// Console.WriteLine("Привет");
// Console.WriteLine("Афанасьева Дн");
// Console.WriteLine("ИСП 233");
// Console.WriteLine(DateTime.Now);

string Fio = "Афанасьева Дн";
string grupa = "ИСП-233";
var T = DateTime.Now;

Console.WriteLine("Выберите что хотите");
Console.WriteLine("1 — Показать ФИО\n2 — Показать группу\n3 — Показать дату\n4 — Выход");
int num = Convert.ToInt32(Console.ReadLine());
switch (num)
{
    case 1: Console.WriteLine(Fio); break;
    case 2: Console.WriteLine(grupa); break;
    case 3: Console.WriteLine(T); break;
    case 4: break;
}