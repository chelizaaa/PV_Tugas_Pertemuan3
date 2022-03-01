/*
 * Created by SharpDevelop.
 * User: Lenovo
 * Date: 3/1/2022
 * Time: 9:13 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace PV_Tugas1_2
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.Write("Nama kamu siapa? ");
			
			string nama = Console.ReadLine();
			Console.WriteLine("Nama kamu " + nama);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}
