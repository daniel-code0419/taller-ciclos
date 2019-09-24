/*
 * Created by SharpDevelop.
 * User: Daniel
 * Date: 24/09/2019
 * Time: 3:43 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace punto16
{
	class Program
	{
		public static void Main(string[] args)
		{
			int num=1,sum=0 ;
			while ( num <= 100){
				sum = sum + num;
				num++;
					
			}Console.WriteLine(sum);
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}