using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__c_нуля
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dayOfWeek;
            Console.Write("Введите день недели на который нужно расписание: ");
            dayOfWeek = Console.ReadLine();
            if (dayOfWeek == "Понедельник")
            {
                Console.WriteLine("Сегодня понедельник");
                Console.WriteLine("Расписание на понедельник: ");
                Console.WriteLine("1.Математика");
                Console.WriteLine("2.Информатика");
                Console.WriteLine("3.Русский язык");
                Console.WriteLine("4.Обществоведение");
            }
            else
            if (dayOfWeek == "Вторник")
            {
                Console.WriteLine("Сегодня вторник");
                Console.WriteLine("Расписание на вторник: ");
                Console.WriteLine("1.Английский язык");
                Console.WriteLine("2.Физика");
                Console.WriteLine("3.Химия");
                Console.WriteLine("4.Физкультура");
                Console.WriteLine("5.Классный час");
            }
            if (dayOfWeek == "Среда")
            {
                Console.WriteLine("Сегодня среда");
                Console.WriteLine("Расписание на среду: ");
                Console.WriteLine("1.Русский язык");
                Console.WriteLine("2.Английский язык");
                Console.WriteLine("3.Физика");
                Console.WriteLine("4.Химия");
            }
            else
                if (dayOfWeek == "Четверг")
            {
                Console.WriteLine("Сегодня четверг");
                Console.WriteLine("Расписание на четверг: ");
                Console.WriteLine("1.Физкультура");
                Console.WriteLine("2.Математика");
                Console.WriteLine("3.Обществоведение");
                Console.WriteLine("4.Русская литература");
            }
            else
                if (dayOfWeek == "Пятница ")
            {
                Console.WriteLine("Сегодня пятница");
                Console.WriteLine("Расписание на пятницу: ");
                Console.WriteLine("1.Физика");
                Console.WriteLine("2.Информатика");
                Console.WriteLine("3.Английский язык");
                Console.WriteLine("4.Русский язык");
            }
            else
                if (dayOfWeek == "Суббота")
            {
                Console.WriteLine("Сегодня суббота");
                Console.WriteLine("Расписание на субботу: ");
                Console.WriteLine("Занятий нет");
            }
            else
                if (dayOfWeek == "Воскресенье")
            {
                Console.WriteLine("Сегодня воскресенье");
                Console.WriteLine("Расписание на воскресенье: ");
                Console.WriteLine("Занятий нет");
            }
            else if (dayOfWeek == "На все дни")
            {
                Console.WriteLine("На всю неделю: ");
                Console.WriteLine(" ");
                Console.WriteLine("Расписание на понедельник: ");
                Console.WriteLine("1.Математика");
                Console.WriteLine("2.Информатика");
                Console.WriteLine("3.Русский язык");
                Console.WriteLine("4.Обществоведение");
                Console.WriteLine(" ");
                Console.WriteLine("Расписание на вторник: ");
                Console.WriteLine("1.Английский язык");
                Console.WriteLine("2.Физика");
                Console.WriteLine("3.Химия");
                Console.WriteLine("4.Физкультура");
                Console.WriteLine("5.Классный час");
                Console.WriteLine(" ");
                Console.WriteLine("Расписание на среду: ");
                Console.WriteLine("1.Русский язык");
                Console.WriteLine("2.Английский язык");
                Console.WriteLine("3.Физика");
                Console.WriteLine("4.Химия");
                Console.WriteLine(" ");
                Console.WriteLine("Расписание на четверг: ");
                Console.WriteLine("1.Физкультура");
                Console.WriteLine("2.Математика");
                Console.WriteLine("3.Обществоведение");
                Console.WriteLine("4.Русская литература");
                Console.WriteLine(" ");
                Console.WriteLine("Расписание на пятницу: ");
                Console.WriteLine("1.Физика");
                Console.WriteLine("2.Информатика");
                Console.WriteLine("3.Английский язык");
                Console.WriteLine("4.Русский язык");
                Console.WriteLine(" ");
                Console.WriteLine("Расписание на субботу: ");
                Console.WriteLine("Занятий нет");
                Console.WriteLine(" ");
                Console.WriteLine("Расписание на воскресенье: ");
                Console.WriteLine("Занятий нет");
                Console.WriteLine(" ");
            }    
        }
    }
}
