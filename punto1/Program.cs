/*
 * Created by SharpDevelop.
 * User: Daniel
 * Date: 24/09/2019
 * Time: 3:08 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace punto1
{
	class Program
	{
		public static void Main(string[] args)
		{
			int num, suma = 0;

        	Console.WriteLine("Digite el numero");
        	num = int.Parse(Console.ReadLine());

        	for (int i = 0; i < num; i++)
            suma = suma+ i;

       	 	Console.WriteLine("La suma de los números que anteceden son "+ suma);
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}