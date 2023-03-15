using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			// добавление новой коллекции
			ArrayList newList1 = new ArrayList() { "Анна", 15, "Саша", 18, "Ника", 17, "Дима", 16 };
			ArrayList newList2 = new ArrayList() { "Данил", 18, "Леонид", 16, "Варвара", 14, "Дарья", 19 };

			Console.WriteLine($"Длина 1 коллекции: {newList1.Count}");
			Console.Write("1 коллекция: ");
			foreach (var item in newList1)
				Console.Write($"{item} ");
			Console.Write("\n2 коллекция: ");
			foreach (var item in newList2)
				Console.Write($"{item} ");

			Console.Write("\nВведите значение n: ");
			int n1 = 0;
			try
			{
				n1 = Convert.ToInt16(Console.ReadLine());
				if (n1 > newList1.Count || n1 < 0) throw Exception();
			}
			catch (Exception)
			{
				Console.WriteLine("Ошибка ввода данных.");
				Console.ReadKey();
				Environment.Exit(0);
			}

			// вставка
			newList1.InsertRange(n1, newList2);
			Console.WriteLine("Результат вставки: ");
			foreach (var item in newList1)
				Console.Write($"{item} ");

			// удаление
			int n = n1 / 2;
			Console.Write("\nВведите количество элементов для удаления: ");
			int k = 0;
            try
            {
				k = Convert.ToInt16(Console.ReadLine());
				if (k > newList1.Count || k < 0) throw Exception();
			}
            catch (Exception)
            {
				Console.WriteLine("Ошибка ввода данных.");
				Console.ReadKey();
				Environment.Exit(0);
			}
			newList1.RemoveRange(n, k);
			Console.WriteLine("Результат удаления: ");
			foreach (var item in newList1)
				Console.Write($"{item} ");


			Console.ReadKey();
		}

		private static Exception Exception()
		{
			throw new NotImplementedException();
		}
	}
}
