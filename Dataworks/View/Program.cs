using System;
using Dataworks.Model;

namespace Dataworks
{
    class Program
    {
        static void Main(string[] args)
        {
			romtoInt taskOne = new romtoInt();
			balanced taskTwo = new balanced();
			DoubleLinkedListNode<string> taskThree = new DoubleLinkedListNode<string>();
			string variant;
			while (true)
			{
				Console.WriteLine("Выберите вариант");
				Console.WriteLine("1. Перевести римское число в целое, не больше 3000");
				Console.WriteLine("2. Проверить правильность скобочной структуры");
				Console.WriteLine("3. Работа с двусвязным списком");
				variant = Console.ReadLine();
				switch (variant)
				{
					case "1":
						{
							Console.WriteLine("Введите римское число");
							string _roman = Console.ReadLine();
							int _intafter = taskOne.RomanToInt(_roman);
							Console.WriteLine(_intafter);
							break;
						}
					case "2":
						{
							Console.WriteLine("Введите скобочную структуру");
							string __bracket = Console.ReadLine();
							taskTwo.CheckBracket(__bracket);
							break;
						}
					case "3":
						{
							Console.WriteLine("Выберите что вы будете делать с двучвязным списком");
							Console.WriteLine("1. Добавить запись в список");
							Console.WriteLine("2. Добавить запись в начало");
							Console.WriteLine("3. Реверсировать список");
							Console.WriteLine("4. Вывести список");
							string _newElement;
							int i = 0;
							var variant2 = Console.ReadLine();
							switch (variant2)
							{
								case "1":
									{
										Console.WriteLine("Введите значение");
										_newElement = Console.ReadLine();
										taskThree.Add(_newElement);
										break;
									}
								case "2":
									{
										Console.WriteLine("Введите значение");
										_newElement = Console.ReadLine();
										taskThree.AddFirst(_newElement);
										break;
									}
								case "3":
									{
										taskThree.Reverse();
										break;
									}
								case "4":
									{
										foreach (var t in taskThree)
											if (i < taskThree.Count)
											{
												Console.WriteLine(t);
												i++;
											}
										break;
									}
								default:
									{
										Console.WriteLine("Введите корректное значение");
										break;
									}
							}

							break;
						}
					default:
						{
							Console.WriteLine("Введите корректное значение");
							break;
						}
				}
			}
				
		}
		
	}

}
