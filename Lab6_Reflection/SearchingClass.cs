using System;

namespace Reflection
{
	public class SearchingClass
	{
		public SearchingClass() { }//пустой конструктор
		public SearchingClass(string str) { }//конструктор на ввод  строки
		public SearchingClass(int n) { }//конструктор, обрабатывающий ввод целого числа
		public double Exponentiation(int x, int y) //возведение x в степень y
		{
			return Math.Pow(x, y);
		}

		[NewAttribute("Здесь находится атрибут для свойства 1: Prop1")]//назначение атрибута свойству
		public string Prop1//свойство 1
		{
			get { return _Prop1; }
			set { _Prop1 = value; }
		}
		private string _Prop1;


		[NewAttribute(Description = "А здесь уже атрибут для свойства 2: Prop2")]//назначение атрибута свойству
		public double Prop2 { get; private set; }//свойство 2
		public int Prop3 { get; set; }//свойство 3 без атрибута

	}
}
