/*
 * Created by SharpDevelop.
 * User: Daniel
 * Date: 24/09/2019
 * Time: 3:41 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace punto7
{
	class Program
	{
		public static void Main(string[] args)
		{
			int num;        

            Console.Write("Ingrese un numero ");
            num = int.Parse(Console.ReadLine());

        	while (num < 1 || num > 99);
         
        	for (int i = 1; i < 11; i++)
            Console.WriteLine("{0} x {1} = {2}", num, i, num * i);
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}