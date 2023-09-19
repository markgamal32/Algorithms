using System;
using System.Collections;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace Algorithms_0
{
	internal class Program
	{
		// an algorithm to find max number 
		//                ====================
		/* Big O notation, represents an algorithm's worst-case complexity. It uses algebraic terms to describe
		 the complexity of an algorithm.Big O defines the runtime required to execute an algorithm
		 by identifying how the performance of your algorithm will change as the input size grows */
		static int findMaximum2(int a, int b, int c)
		{
			int max = a;

			if (b > max)
			{
				max = b;
			}

			if (c > max)
			{
				max = c;
			}

			return max;
		}
		// string validation algorithm
		static Boolean IsUpperCase(string s)
		{
			return s.All(char.IsUpper);
		}
		static Boolean IsLowerCase(string s)
		{
			return s.All(char.IsLower);
		}
		// password validation
		static Boolean IsPasswordComplex(string password)
		{
			return password.Any(char.IsUpper) && password.All(char.IsLower) && password.All(char.IsDigit);
		}
		// normalize string 
		static string NormalizeString(String input)
		{
			return input.ToLower().Trim().Replace(",", "");
		}
		// find out if a certain char exists at an even index or even location
		static Boolean IsAtEvenIndex(String s, char item)
		{
			if (String.IsNullOrEmpty(s))
			{
				return false;
			}

			for (int i = 0; i < s.Length / 2 + 1; i = i + 2)
			{
				if (s[i] == item)
				{
					return true;
				}
			}

			return false;
		}
		// Create algorithm-driven strings in C#  create new string based on input data
		// this will reverse the string 
		static String Reverse(String input)
		{
			if (string.IsNullOrEmpty(input))
			{
				return input;
			}

			StringBuilder reversed = new StringBuilder(input.Length);

			for (int i = input.Length - 1; i >= 0; i--)
			{
				reversed.Append(input[i]);
			}

			return reversed.ToString();
		}
		// convert string into an array then use built-in function to reverse
		static String Reverse2(String input)
		{
			if (string.IsNullOrEmpty(input))
			{
				return input;
			}

			char[] arr = input.ToCharArray();
			Array.Reverse(arr);
			return new String(arr);
		}
		// Linear search arrays in C#
		// the return type can be edited to return an int ( n )
		static Boolean LinearSearch(int[] input, int n)
		{
			foreach (int current in input)
			{
				if (n == current)
				{
					return true;
				}
			}

			return false;
		}
		// Binary search array in C# in case the array is sorted already --- start from middle 
		static Boolean BinarySearch1(int[] inputArray, int item)
		{
			int min = 0;
			int max = inputArray.Length - 1;

			while (min <= max)
			{
				int mid = (min + max) / 2;
				if (item == inputArray[mid])
				{
					return true;
				}
				else if (item < inputArray[mid])
				{
					max = mid - 1;
				}
				else
				{
					min = mid + 1;
				}
			}

			return false;
		}
		// Aggregate and filter arrays in C#
		// function that two arrays and create new array with even numbers
		static int[] FindEvenNums(int[] arr1, int[] arr2)
		{
			ArrayList result = new ArrayList();

			foreach (int num in arr1)
			{
				if (num % 2 == 0)
				{
					result.Add(num);
				}
			}
			foreach (int num in arr2)
			{
				if (num % 2 == 0)
				{
					result.Add(num);
				}
			}
			// converting the type to array
			return (int[])result.ToArray(typeof(int));
		}

		// Reverse an array in C#
		static int[] Reverse(int[] input)
		{
			int[] reversed = new int[input.Length];

			for (int i = 0; i < reversed.Length; i++)
			{
				reversed[i] = input[input.Length - i - 1];
			}

			return reversed;
		}

		static void ReverseInPlace(int[] input)
		{

			for (int i = 0; i < input.Length / 2; i++)
			{
				// Swap index(i) with index(input.Length - i - 1)
				int temp = input[i];
				input[i] = input[input.Length - i - 1];
				input[input.Length - i - 1] = temp;
			}
		}










		//  ***********************************************************************************************************************  //
		static void Main(string[] args)
			{
			// test findMaximum2
				Console.WriteLine(findMaximum2(1, 2, 3));
				Console.WriteLine(findMaximum2(8, 8, 1));

			// test validation
			Console.WriteLine(IsPasswordComplex("Hell0"));
			Console.WriteLine(IsPasswordComplex("Hello"));


			// test normalize string 
			Console.WriteLine(NormalizeString(" Hello There, BUDDY      "));

			// find out if a certain char exists at an even index or even location
			String input = "HeLLo";
			Console.WriteLine(IsAtEvenIndex(input, 'l'));
			Console.WriteLine(IsAtEvenIndex(input, 'T'));
			Console.WriteLine(IsAtEvenIndex(input, 'H'));
			Console.WriteLine(IsAtEvenIndex("", 'H'));
			Console.WriteLine(IsAtEvenIndex(null, 'H'));

			// test reverse function 1
			Console.WriteLine(Reverse("Hello!"));

			// test reverse function 2
			Console.WriteLine(Reverse2("Hello World"));


			//test Linear search arrays
			int[] arr = { 1, 2, 3, 4, 5, 6 };
			Console.WriteLine(LinearSearch(arr, 4));
			Console.WriteLine(LinearSearch(arr, 8));
			// using built-in way to search -- find
			int item = Array.Find(arr, element => element == 3);
			Console.WriteLine(item);
			int[] items = Array.FindAll(arr, element => element >= 5);
			Array.ForEach(items, Console.WriteLine);


			// Binary search array
			int[] arr1 = { 1, 2, 3, 4, 5, 6 };
			Console.WriteLine(BinarySearch1(arr1, 5));
			// built-in array method for binary search
			Array.BinarySearch(arr1, 5);

			// test --  function that two arrays and create new array with even numbers
			int[] arr2 = { -8, 2, 3, -9, 11, -20 };
			int[] arr3 = { 0, -2, -9, -39, 39, 10, 7 };

			int[] evenArr = FindEvenNums(arr2, arr3);
			Array.ForEach(evenArr, Console.WriteLine);


			// test  -- Reverse an array in C#
			int[] arr4 = { 1, 2, 3, 4, 5, 6 };
			Array.ForEach(Reverse(arr4), Console.WriteLine);

			ReverseInPlace(arr4);
			Array.ForEach(arr4, Console.WriteLine);











		}

	}
}