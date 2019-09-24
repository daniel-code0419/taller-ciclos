/*
 * Created by SharpDevelop.
 * User: Daniel
 * Date: 24/09/2019
 * Time: 3:36 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace punto2
{
	class Program
	{
		public static void Main(string[] args)
		{
			int num;
			Console.WriteLine("dijite un numero");
			num=int.Parse(Console.ReadLine());
			for(int i=0;i<num;i++){
				Console.WriteLine(i);
				
			
			}
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}