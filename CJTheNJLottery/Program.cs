﻿using System;

namespace CJTheNJLottery
{
	class Program
	{
		enum Day { PICK_3 = 1, PICK_4, JERSEY_CASH_5, PICK_6, POWERBALL, MEGA_MILLIONS };

		/**
		 * Pick three(3) numbers between 0-9. 
		 * Pick-3 with FIREBALL drawings are held every day at approximately 12:59 pm & 7:57 pm.
		 * Purchase your Pick-3 tickets prior to 12:53 pm for the Midday drawings & 7:53 pm for the Evening drawings.
		 * Enhance your Pick-3 play with the optional FIREBALL.
		 */
		private static int[] PickThree()
		{
			Random random = new Random();
			int[] pickThree = { random.Next(0,9), random.Next(0,9), random.Next(0,9) };
			return pickThree;
		}

		/**
		 * Pick four(4) numbers between 0-9.
		 * Pick-4 with FIREBALL drawings are held every day at approximately 12:59 pm & 7:57 pm.
		 */
		private static int[] PickFour()
		{
			Random random = new Random();
			int[] pickFour = { random.Next(0,9), random.Next(0,9), random.Next(0,9), random.Next(0,9) };
			return pickFour;
		}

		/**
		 * Pick five(5) numbers between 1-43.
		 * Jersey Cash 5 drawings are held every night at approximately 7:57 pm.
		 */
		private static int[] JerseyCashFive()
		{
			Random random = new Random();
			int[] jerseyCashFive = { random.Next(1,43), random.Next(1,43), random.Next(1,43), random.Next(1, 43), random.Next(1, 43) };
			return jerseyCashFive;
		}

		/**
		 * Pick six(6) numbers between 1-49
		 * Pick-6 drawings are held every Monday & Thursday at approximately 7:57 pm.
		 */
		private static int[] PickSix()
		{
			Random random = new Random();
			int[] pickSix = { random.Next(1,49), random.Next(1,49), random.Next(1,49), random.Next(1,49), random.Next(1, 49), random.Next(1, 49) };
			return pickSix;
		}

		/**
		 * Pick five(5) numbers between 1-69 and one(1) Powerball number between 1-26.
		 * Powerball drawings are held every Wednesday & Saturday at approximately 10:59 pm.
		 */
		private static Tuple<int[], int> PowerBall()
		{
			Random random = new Random();
			int[] powerBall = { random.Next(70), random.Next(70), random.Next(70), random.Next(70), random.Next(70) };
			return new Tuple<int[], int>(powerBall, random.Next(26));
		}


		static void Main(string[] args)
		{
			Console.WriteLine("Hello C.J and welcome back. Wish you success :-)\n");
			Console.WriteLine("Please select a raffle for the foolowing:");
			Console.WriteLine("------------------------------------------\n");
			Console.WriteLine("1) PICK-3");
			Console.WriteLine("2) PICK-4");
			Console.WriteLine("3) JERSEY CASH 5");
			Console.WriteLine("4) PICK-6");
			Console.WriteLine("5) POWERBALL");
			Console.WriteLine("6) MEGA MILLIONS (not valid)");
			int raffel = 0;
			try
			{
				raffel = int.Parse(Console.ReadLine());
			}
			catch (FormatException e)
			{
				Console.WriteLine("Please select a digit");
			}
			if (raffel > 0 && raffel <= 6) {
				Console.WriteLine("---------------------------------------");
				switch (raffel)
				{
					case 1:
						foreach(int value in PickThree())
						{
							Console.Write("{0} ", value);
						}
						break;
					case 2:
						foreach (int value in PickFour())
						{
							Console.Write("{0} ", value);
						}
						break;
					case 3:
						foreach (int value in JerseyCashFive())
						{
							Console.Write("{0} ", value);
						}
						break;
					case 4:
						foreach (int value in PickSix())
						{
							Console.Write("{0} ", value);
						}
						break;
					case 5:
						foreach (int value in PowerBall().Item1)
						{
							Console.Write("{0} ", value);
						}
						Console.Write("and the extra number is "+PowerBall().Item2);
						break;
					case 6:
						Console.WriteLine("MEGA MILLIONS(Not valid)");
						break;
					default: Console.WriteLine("Not valid selection");
						break;
				}
				Console.WriteLine("\n---------------------------------------\n");
			}
			else
			{
				Console.WriteLine("Not a valid selection. Please try again.");
			}
		}
	}
}
