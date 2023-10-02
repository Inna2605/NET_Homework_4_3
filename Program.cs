//Створити базовий клас «Музичний інструмент» і похідні класи: «Скрипка», «Тромбон», «Укулеле», «Віолончель».
//За допомогою конструктора, встановити назву до кожного музичного інструменту і його характеристики.
//Реалізуйте для кожного з класів методи:
//■ Sound — видає звук музичного інструменту (пишемо текстом у консоль);
//■ Show — відображає назву музичного інструменту;
//■ Desc — відображає опис музичного інструменту;
//■ History — відображає історію створення музичного інструменту.

using NET_Homework_4_3;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;

int a = 1;
while (a != 0)
{
    Console.WriteLine("\nОберіть музичний інструмент:\n" +
        "0. Закінчення роботи;\n" +
        "1. Скрипка;\n" +
        "2. Тромбон;\n" +
        "3. Укулеле;\n" +
        "4. Віолончель.\n");
    a = Convert.ToInt32(Console.ReadLine());
    switch (a)
    {
        case 0:
            {
                break;
            }
        case 1:
            {
                Violin violin = new Violin("Скрипка", "Опис скрипки");
                violin.Show();
                violin.Sound();
                violin.Desc();
                violin.History();
                break;
            }
            case 2:
            {
                Trombone trombone = new Trombone("Тромбон", "Опис тромбона");
                trombone.Show();
                trombone.Sound();
                trombone.Desc();
                trombone.History();
                break;
            }
            case 3:
            {
                Ukulele ukulele = new Ukulele("Укулеле", "Опис укулеле");
                ukulele.Show();
                ukulele.Sound();
                ukulele.Desc(); 
                ukulele.History();
                break;
            }
            case 4:
            {
                Cello cello = new Cello("Віолончель","Опис віолончелі");
                cello.Show();
                cello.Sound();
                cello.Desc();
                cello.History();
                break;
            }
    }
}