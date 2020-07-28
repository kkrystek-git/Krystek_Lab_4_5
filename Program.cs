using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Net.Http;

namespace Krystek_Lab_4_5
{
	class Program
	{
		static void Main(string[] args)
		{
			// Name:	Keith Krystek
			// Date:	07.27.2020
			// Class: SD1104-A - Full Stack C# Development - Sona Patel - 7 / 11 / 2020
			//
			// Assignment: Lab 4_5
			// =========================================================================
			//
			//
			// 1.Create list of scores.
			// 2.Sort scores lowest to highest and display.
			// 3.Sort scores highest to lowest and display.
			// 4.Add new score to list.
			// 5.Remove a score from list.
			//


			// 1.Create list of scores.
			List<int> mylist = new List<int>();
			mylist.Add(4400);
			mylist.Add(8900);
			mylist.Add(1200);
			mylist.Add(3700);
			mylist.Add(7200);


			// 2.Sort scores lowest to highest and display.
			Console.Write("List Sorted Lowest to Highest:\n");
			mylist.Sort();
			foreach (int score in mylist)
			{
			Console.WriteLine(score);
			};


			// 3.Sort scores highest to lowest and display.
			Console.Write("\nList Sorted Lowest to Highest:\n");
			mylist.Reverse();
			foreach (int score in mylist)
			{
			Console.WriteLine(score);
			};


			// 4.Add new score to list.
			Console.Write("\nAdding 2400 to List:\n");
			mylist.Add(2400);
			mylist.Sort();
			foreach (int score in mylist)
			{
				Console.WriteLine(score);
			};


			// 5.Remove a score from list.
			Console.Write("\nRemoving 4400 from List:\n");

			int z = 0;
			foreach (int score in mylist)
			{
				if (score == 4400)
				{
				mylist.RemoveAt(z);
				break;
				}

				z++;
				if (z > mylist.Count) {break;};
			};

			for (int i = 0; i < mylist.Count; i++)
			{
				Console.WriteLine(mylist[i].ToString());
			};



			// End

		}
	}
}
