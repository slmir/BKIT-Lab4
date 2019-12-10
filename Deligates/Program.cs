using System;

namespace Delegates
{
	delegate int MultiliOF(int p1, int p2);//теперь делегат доступен всем в этом пространстве имен
	class Program
	{
		//Методы, реализующие делегат (методы "типа" делегата)
		static int Multipli(int p1, int p2)
		{
			return p1 * p2;
		}
		
		//строка str - объявление происходящего действия
		static void Method_Func_MultiliOF(string str, int i1, int i2, Func<int, int, int> MultiliOF_Param)/*обобщенный делегат Func, 
			принимающий параметры типа int, int, int и возвращающий  int*/
        {
            double Result = MultiliOF_Param(i1, i2);
            Console.WriteLine(str + Result.ToString());
        }

        static void Method_MultiliOF(string str, int i1, int i2, MultiliOF MultiliOF_Param)//исользование делегата с указанием вложенного метода
        {
            double Result = MultiliOF_Param(i1, i2);
            Console.WriteLine(str + Result.ToString());
        }

        static void Main(string[] args)
        {
			Console.Title = "Мирсонов Вячеслав РТ5-31Б";
			int i1;
			int i2;
			Console.WriteLine("Введите первое число:");
			string str1 = Console.ReadLine();
			Console.WriteLine("Введите второе число:");
			string str2 = Console.ReadLine();
			i1 = Convert.ToInt32(str1);
			i2 = Convert.ToInt32(str2);

			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine("Для чисел {0} и {1}", i1, i2);
			Console.ResetColor();
			
			Method_MultiliOF("Перемножение: ", i1, i2, Multipli);
			Console.Write("\n");
			MultiliOF P1 = new MultiliOF(Multipli);
			Method_MultiliOF("Создание экземпляра делегата на основе метода: ", i1, i2, P1);
			Method_MultiliOF("Создание экземпляра делегата на основе лямбда-выражения: ", i1, i2, (x, y) => x*y );

			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine("\nИспользование обощенного делегата Func<>");
			Console.ResetColor();

			Method_Func_MultiliOF("Создание экземпляра делегата на основе метода: ", i1, i2, Multipli);
			Method_Func_MultiliOF("Создание экземпляра делегата на основе лямбда-выражения: ", i1, i2, (x, y) => x * y);
			Console.ReadLine();
        }
    }
}
