/*
 * Created by SharpDevelop.
 * User: Daniel
 * Date: 24/09/2019
 * Time: 3:41 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace punto8
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			int genero=0, mujeres=0, hombres=0;
			string nombre;
			double sueldo=0;
			for (int i=1; i<=10; i++){
				Console.WriteLine("Empleado " + i + " diga su nombre");
				nombre = Console.ReadLine();
				Console.WriteLine("Empleado " + i + " diga su sueldo");
				sueldo = double.Parse(Console.ReadLine());
				Console.WriteLine("Si usted es mujer digite 1 si es hombre digite 2");
				genero = int.Parse(Console.ReadLine());
				if (genero == 1 && sueldo > 500){
					mujeres = mujeres +1;
				}if(genero ==2 && sueldo <400){
					hombres = hombres +1;
					
				}
			}
				Console.WriteLine("Hay "+ mujeres+" mujeres que ganan mas de 500 pesos y hay " +hombres +" hombres que ganan menos de 400 pesos.");
				
				Console.Write("Press any key to continue . . . ");
				Console.ReadKey(true);
			}
			
			// TODO: Implement Functionality Here
			
			
		}
	}
