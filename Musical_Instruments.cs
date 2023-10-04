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
    public class Musical_Instrument//Музичний інструмент
    {
        public string Name;
        public string Description;
        public Musical_Instrument(string name, string description)
        {
            if(name == "") throw new ArgumentNullException("Музичного інструменту не існує!");
            Name = name;
            Description = description;
        }
        public virtual void Sound()
        {
            Console.WriteLine($"{Name} видає звук {Name}");
        }
        public virtual void Show() 
        {
            Console.WriteLine($"Музичний інструмент: {Name}");
        }
        public virtual void Desc()
        {
            if (Description == "")
            {
                throw new ArgumentNullException($"Немає опису {Name}");
            }
            else
            {
                Console.WriteLine($"{Name}: {Description}");
            }
        }
        public virtual void History()
        {
            Console.WriteLine($"{Name}: Історія {Name}");
        }
    }
}
