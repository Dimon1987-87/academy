using System;
using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace Homework
{
    class Program
    {
        static void Main()
        {//PR1:  -6*x^3+5*x^2-10*x+15
            /* double x, y = 3, z = 2;
             Console.WriteLine("Введите значение X ");
             x = Convert.ToDouble(Console.ReadLine());

             double a =Math.Pow(x, y);
             double b =Math.Pow(x, z);
             double num1 = -6 * a+ 5 * b- 10 * x + 15;


             Console.WriteLine($"{num1}");*/


            //PR2: abs(x)*sin(x)
            /*double x;
            Console.WriteLine("Введите значение X");
            x = Convert.ToDouble(Console.ReadLine());
            double work = Math.Abs(x) * Math.Sin(x);
            Console.WriteLine($"abs(x)*sin(x)= {work}");*/


            //PR3: 2*pi*x  
            /* Console.WriteLine("Введите значение X");
              double x = Convert.ToDouble(Console.ReadLine());
             double circum = 2 * Math.PI * x;
             Console.WriteLine($"Длина окружности = {circum}");*/

            //PR4: max(x,y)

            /* Console.WriteLine("Введите значение X");
             double x = Convert.ToDouble(Console.ReadLine());
             Console.WriteLine("Введите значение Y");
             double y = Convert.ToDouble(Console.ReadLine());
             double max = Math.Max(x, y);
             Console.WriteLine($"Из двух чисел {x} и {y} больше - {max}");*/


            Console.WriteLine("Какое сегодня число,месяц и год ? В формате - год,месяц,число "  );
            DateTime date1=Convert.ToDateTime(Console.ReadLine()); 
            
            DateTime dateOldYear = new DateTime(2023, 1, 1);
            DateTime newYear = new DateTime(2024,1,1);  

            Console.WriteLine("До Нового года осталось - "+newYear.Subtract(date1)+" дня");
            Console.WriteLine("Прошло дней с 1 января - "+date1.Subtract(dateOldYear));










        }
    }
}