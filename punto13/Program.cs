/*
 * Created by SharpDevelop.
 * User: Daniel
 * Date: 24/09/2019
 * Time: 3:42 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace punto13
{
	class Program
	{
		public static void Main(string[] args)
		{
			int num=1,contadorimpar=0,contadorpar=0;
			for (int i=0; i <=999; i++){
				Console.WriteLine("Digite numeros los cuales desee saber si son positivos o negativos.DIGITE 999 PARA TERMINAR");
					num = int.Parse(Console.ReadLine());
				if (num%2==0){
					contadorpar = contadorpar +1;
				}if (num%2!=0){
					contadorimpar=contadorimpar+1;
					}if (num==999){
						break;
					}
	
			}Console.WriteLine("hay " +contadorpar  +" numeros pares y hay " +(contadorimpar-1)+" numeros impares" );
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}