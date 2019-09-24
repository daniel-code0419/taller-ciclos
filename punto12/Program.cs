/*
 * Created by SharpDevelop.
 * User: Daniel
 * Date: 24/09/2019
 * Time: 3:42 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace punto12
{
	class Program
	{
		public static void Main(string[] args)
		{
			float acumulador=1;
			for (int i = 10;i<=20;i++){
				acumulador = acumulador * i;
			}Console.WriteLine(acumulador);
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}