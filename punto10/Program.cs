/*
 * Created by SharpDevelop.
 * User: Daniel
 * Date: 24/09/2019
 * Time: 3:41 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace punto10
{
	class Program
	{
		public static void Main(string[] args)
		{
			double numero;
        	int cont = 0, menor = 0, mayor = 0;

        	while (cont < 10){
        	Console.Write("Ingrese numero:");
            numero = double.Parse(Console.ReadLine());
		
            if (numero > 0)
                mayor++;
            if (numero < 0)
                menor++;

            cont++;
        	}
       		 
        	Console.WriteLine("Los numeros menores a cero son "+menor);
        	Console.WriteLine("Los numeros mayores a cero son "+mayor);



			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}