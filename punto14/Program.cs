/*
 * Created by SharpDevelop.
 * User: Daniel
 * Date: 24/09/2019
 * Time: 3:43 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace punto14
{
	class Program
	{
		public static void Main(string[] args)
		{
			for (int i=1;i<=20;i++){
				for (int j=1;j<=i;j++){
					Console.Write(j);
				}Console.WriteLine(" ");
			}
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}