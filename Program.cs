/*
 * Создано в SharpDevelop.
 * Пользователь: 123
 * Дата: 14.06.2021
 * Время: 21:49
 * 
 * Для изменения этого шаблона используйте меню "Инструменты | Параметры | Кодирование | Стандартные заголовки".
 */
using System;

namespace pr2
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Лабораторная работа 2.Вариант 5 - Выводит сумму элементов.");
		 	Console.WriteLine("===============================");
		 	
		 	
			Console.Write("РАЗМЕР МАССИВА= " );
                var len = int.Parse(Console.ReadLine());
                var array = new int[len];
                 
                for (int i = 0; i < array.Length; i++)
                	
                {
                    Console.Write("Элемент ("+i+") = ");
                    array[i] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("===============================");
                Console.Write("СУММА ЭЛЕМЕНТОВ РАВНА = ");
                int Sum =0;
                for (int i = 0; i < array.Length; i++)
                Sum+=array[i];
                		
                		Console.WriteLine(Sum);	
                
                
                
                Console.WriteLine("===============================");
                Console.WriteLine("Для продолжения нажмите любую клавишу....");
                Console.ReadKey(true);
		}
	}
}