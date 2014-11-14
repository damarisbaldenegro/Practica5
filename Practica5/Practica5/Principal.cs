using System;

namespace Practica5
{
	class Principal
	{

	
		public static void Main (string[] args)
		{
		
			Alumnos al = new Alumnos();
			String opcion = "";
			int registros= 0;
			
				
		
			
				Console.WriteLine("INGRESE EL NUMERO DE OPCIÓN");
				Console.WriteLine("ELIJA UNA OPCIÓN DEL MENU:");
				Console.WriteLine("1.Agregar registro en la BD.");
				Console.WriteLine("2.Consultar todos los registros.");
				Console.WriteLine("3.Salir.");
				
				int op = Int32.Parse( Console.ReadLine() );
				switch(op)
						
					{
					case 1:
						try{
						int codigo = 0;
						Console.WriteLine("dame el codigo del Alumno:");
						codigo = int.Parse( Console.ReadLine() );
						}catch (Exception e){
								Console.WriteLine("*SE PEDÍA UN VALOR NUMÉRICO.");
								Console.WriteLine(e.Message);}
							
								
						Console.WriteLine("dame el nombre del Alumno:");
						String nombre = Console.ReadLine();
						int telefono = 0;
						
						Console.WriteLine("Ingrese el TELÉFONO del Alumno:");
						telefono = Int32.Parse( Console.ReadLine() );
						
						Console.WriteLine("Ingrese el E-MAIL del Alumno:");
						String email = Console.ReadLine();
						
						al.insertarRegistroNuevo(codigo,nombre,telefono,email);
						codigo =0;
						telefono = 0;
						registros++;
						break;	
						
						
					case 2:
					/*string bdVacia = al.mostrarTodos();
						if(bdVacia || registros == 0)
							Console.WriteLine("VACÍO" + "\r\n");
						*/
						break;
					
						
					default:
						Console.WriteLine("** ESA OPCION NO ESTA EN EL MENU **");
						break;
				}
				
			Console.ReadKey(true);	
		}
	}
}



		