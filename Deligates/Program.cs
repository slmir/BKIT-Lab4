using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
	delegate int Mydelegate(int p1, int p2);//теперь делегат доступен всем в этом пространстве имен
	class Program
	{
		static int Multipli(int p1, int p2)//метод перемноженич двух чисел типа делегата (int)
		{
			return p1 * p2;
		}
		
		//строка str - объявление происходящего действия
		static void Method_Func_Mydelegate(string str, int i1, int i2, Func<int, int, int> Mydelegate_Param)/*обобщенный делегат Func, 
			принимающий параметры типа int, int и возвращающий  int*/
        {
            int Result = Mydelegate_Param(i1, i2);
            Console.WriteLine(str + Result.ToString());
        }

        static void Method_Mydelegate(string str, int i1, int i2, Mydelegate Mydelegate_Param)//исользование делегата на основе указания вложенного метода
        {
            int Result = Mydelegate_Param(i1, i2);
            Console.WriteLine(str + Result.ToString());//вывод на новой строке объвления действия м делегаом и результата этого действия
        }

        static void Main(string[] args)
        {
			Console.Title = "Мирсонов Вячеслав РТ5-31Б";
			//объявление и ввод входных параметров делегата
			int i1;
			int i2;
			Console.WriteLine("Введите первое целое число:");
			string str1 = Console.ReadLine();
			Console.WriteLine("Введите второе целое число:");
			string str2 = Console.ReadLine();
			i1 = Convert.ToInt32(str1);
			i2 = Convert.ToInt32(str2);

			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine("\nДля чисел {0} и {1}:\n", i1, i2);
			Console.ResetColor();

			Method_Mydelegate("Метод перемножения: ", i1, i2, Multipli);//прямой вызов метода делегата
			Mydelegate P1 = new Mydelegate(Multipli);//создание экземпляра делегата
			Method_Mydelegate("Экземпляр на основе метода: ", i1, i2, P1);//работа метода на основе объявленного метода делегата
			Method_Mydelegate("Экземпляр на основе лямбда-выражения: ", i1, i2, (x, y) => x*y );//на основе лямбда-выражения

			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine("\nИспользование обощенного делегата Func<>");
			Console.ResetColor();

			Method_Func_Mydelegate("Экземпляр на основе метода: ", i1, i2, Multipli);
			Method_Func_Mydelegate("Экземпляр на основе лямбда-выражения: ", i1, i2, (x, y) => x * y);
			Console.ReadLine();
        }
    }
}
