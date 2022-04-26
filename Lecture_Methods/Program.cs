using System;

namespace Lecture_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Вызов методов
            SayHello("Nikita");

            //Если метод возвращает значение, его можно передать в другой метод
            Console.WriteLine(Multiply(5, 6));
            //Либо поместить возвращаемое значение в переменную, после чего эту переменную, например, вывести на экран
            string fullName = GetFullName("Bayborodin", "Nikita", "Evgenievich");
            Console.WriteLine(fullName);

            IsEven(5); //Метод, который возвращает значение не обязательно чему-либо присваивать
        }

        static void SayHello(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }

        //Метод, возвращающий произведение двух чисел
        static int Multiply(int firstArg, int secondArg)
        {
            int result = firstArg * secondArg;
            return result;
        }

        //Метод, возвращающий строку, содержащую переданые фамилию, имя, отчество
        static string GetFullName(string surname, string name, string middlename)
        {
            return $"{surname} {name} {middlename}";
        }

        //Метод, возвращающий true/false, в зависимости от того, четное ли value
        static bool IsEven(int value)
        {
            return value % 2 == 0;
        }

        //Домашнее задание:
        //Реализовать несколько собственных методов, вызвать их в методе Main 
        //Примеры методов:
        //Метод, вычисляющий сумму 2х чисел
        //Метод, отображающий на консоль текущую дату и время
        //Метод для вычисления квадратного корня
    }
}
