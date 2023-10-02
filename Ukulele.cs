//Створити базовий клас «Музичний інструмент» і похідні класи: «Скрипка», «Тромбон», «Укулеле», «Віолончель».
//За допомогою конструктора, встановити назву до кожного музичного інструменту і його характеристики.
//Реалізуйте для кожного з класів методи:
//■ Sound — видає звук музичного інструменту (пишемо текстом у консоль);
//■ Show — відображає назву музичного інструменту;
//■ Desc — відображає опис музичного інструменту;
//■ History — відображає історію створення музичного інструменту.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_Homework_4_3
{
    internal class Ukulele: Musical_Instrument//Укулеле
    {
        public Ukulele(string name, string description) : base(name, description) { }
    }
}
