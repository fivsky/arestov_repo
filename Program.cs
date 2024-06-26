﻿// Написать программу, которая из массива строк формирует массив из строк, длина которых меньше или равна трем символам

int[] Array;
Console.WriteLine("Введите массив строк через пробел");

int max_word_length = 3;

string[] arr = {"Russia", "Denmark", "Kazan"};
		
		int MAX_WORD_LENGTH = 3;
		
		string[] GetShortWordsArray(string[] array)
		{
			int length = array.Length;			
			string[] result = new string[length];
			int count = 0;
			
			for (int i = 0; i < length; i++)
			{
				if(array[i].Length <= MAX_WORD_LENGTH)
				{
					result[count] = array[i];
					count++;
				}
			}
			Array.Resize(ref result, count);
			
			return result;
		}
		
		void PrintArray(string[] array)
		{
			if(array.Length == 0)
			{
				Console.WriteLine("Array is empty");
			}
			else
			{
				Array.ForEach(array, (str) => Console.Write($"{str} "));
				Console.WriteLine();
			}
		}
		
		void PrintTask(string[] array)
		{
			Console.WriteLine("Source array:");
			PrintArray(array);
			string[] shortArray = GetShortWordsArray(array);
			Console.WriteLine($"Result array (words are less or equal than {MAX_WORD_LENGTH} symbols)");
			PrintArray(shortArray);
			Console.WriteLine();
		}
		
		PrintTask(arr1);
