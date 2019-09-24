/*
 * Created by SharpDevelop.
 * User: Daniel
 * Date: 24/09/2019
 * Time: 3:40 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace punto4
{
	class Program
	{
		public static void Main(string[] args)
		{
			int num,suma=0,resta=0;
			
		    for (int i = 1; i <= 10; i++){
		    Console.WriteLine("dijite un numero");
		    num=int.Parse(Console.ReadLine());
		    if(num>0){
		    	suma=num+num;
		    	
		    }else if(num<0){
		    	resta=num-num;
		  
		    }
		    } Console.WriteLine("la resta de los numeros es:"+resta);
			   Console.WriteLine("la suma de los es:"+suma);
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}