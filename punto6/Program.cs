/*
 * Created by SharpDevelop.
 * User: Daniel
 * Date: 24/09/2019
 * Time: 3:41 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace punto6
{
	class Program
	{
		public static void Main(string[] args)
		{
			int num;
			double peso=0,acumuladormenos=0,acumuladormas=0;
			Console.WriteLine("dijite un numero");
			num=int.Parse(Console.ReadLine());
			for(int i=0;i<=num;i++){
			Console.WriteLine("dijite su peso");
			peso=int.Parse(Console.ReadLine());
			acumuladormas=acumuladormas+1;
			acumuladormenos=acumuladormenos+1;
			}if(peso<80){
				Console.WriteLine(acumuladormenos);
			}else{
			Console.WriteLine(acumuladormas);
			}
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}