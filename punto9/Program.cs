/*
 * Created by SharpDevelop.
 * User: Daniel
 * Date: 24/09/2019
 * Time: 3:41 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace punto9
{
	class Program
	{
		public static void Main(string[] args)
		{
			int i=0;
            double num,acu=0;

            while (i < 5)
            {
                Console.Write("Ingrese {0} numero:", i + 1);
                num = double.Parse(Console.ReadLine());
                acu += num;
                i++;
            }
            Console.WriteLine("El promedio de los 5 numeros es {0}", acu / 5);
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}