using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace Algorithms_0
{
	internal class Program
	{
		// an algorithm to find max number 
		//                ====================
		// Big O notation, represents an algorithm's worst-case complexity. It uses algebraic terms to describe
		// the complexity of an algorithm. Big O defines the runtime required to execute an algorithm
		// by identifying how the performance of your algorithm will change as the input size grows
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


		}

	}
}