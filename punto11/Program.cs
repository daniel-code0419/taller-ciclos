/*
 * Created by SharpDevelop.
 * User: Daniel
 * Date: 24/09/2019
 * Time: 3:42 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace punto11
{
	class Program
	{
		public static void Main(string[] args)
		{
			int num, contadorpar=0,contadorimpar=0,numero;
			Console.WriteLine("ingrese la cantidad de numeros ");
			num= int.Parse(Console.ReadLine());
			for (int i=1;i<=num;i++){
				Console.WriteLine("digite numero " + i );
				numero = int.Parse(Console.ReadLine());
				if (numero%2==0){
					contadorpar = contadorpar +1;
				}if (numero%2!=0){
					contadorimpar=contadorimpar+1;
				}
			}Console.WriteLine("hay " +contadorpar  +" numeros pares y hay " +contadorimpar+" numeros impares" );
			
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}