/*
 * Created by SharpDevelop.
 * User: Daniel
 * Date: 24/09/2019
 * Time: 3:40 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace punto5
{
	class Program
	{
		public static void Main(string[] args)
		{
			int num=0,resultado1,resultado2;
			for(int i=0;i<=10;i++){
			Console.WriteLine("dijite un numero");
			num=int.Parse(Console.ReadLine());
			}resultado1=num/3;
			resultado2=num/2;
			Console.WriteLine("el cuandarado es:" + resultado2);
			Console.WriteLine("el cubo es:" + resultado1);
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}