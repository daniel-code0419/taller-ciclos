/*
 * Created by SharpDevelop.
 * User: Daniel
 * Date: 24/09/2019
 * Time: 3:37 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace punto3
{
	class Program
	{
		public static void Main(string[] args)
		{
			int sum = 0,num,num2;
			  Console.WriteLine("dijite un numero");
			  num=int.Parse(Console.ReadLine());
			   for(int i = 1; i <=num; i++){
			   Console.WriteLine("dijite un numero");
			  num2=int.Parse(Console.ReadLine());
			  	    if(i % 5 == 0){
                    sum = sum + i;
                  }
			  } Console.WriteLine("los multiplos de 5 son:"+sum);
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}