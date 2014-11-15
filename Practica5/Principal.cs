using System;

namespace Practica5
{
	class Principal
	{

	
		public static void Main (string[] args)
		{
		
			Alumnos al = new Alumnos();
			int registros= 0;
			
				
		
			
				Console.WriteLine("Elige opcion");
				Console.WriteLine("1.Agregar registro en la BD.");
				Console.WriteLine("2.Consultar todos los registros.");
				
				
				int op = Int32.Parse( Console.ReadLine() );
				switch(op)
						
					{
					case 1:
						
						int codigo = 0;
						Console.WriteLine("dame el codigo del Alumno:");
						codigo = int.Parse( Console.ReadLine() );
						
								
						Console.WriteLine("dame el nombre del Alumno:");
						String nombre = Console.ReadLine();
						int telefono = 0;
						try{
						Console.WriteLine("Ingrese el TELÉFONO del Alumno:");
						telefono = Int32.Parse( Console.ReadLine() );
						}catch (Exception e){
								Console.WriteLine("Era valor numerico");
								Console.WriteLine(e.Message);
							}
						
						
						Console.WriteLine("Ingrese el E-MAIL del Alumno:");
						String email = Console.ReadLine();
					
										
						al.insertarRegistroNuevo(codigo,nombre,telefono,email);
						codigo =0;	
						telefono = 0;
						registros++;
						break;	
						
						
					case 2:
			
					al.mostrarTodos();
				
						break;
					
						
					default:
						Console.WriteLine("Elige otra opcion");
						break;
				}
				
			Console.ReadKey(true);	
		}
	}
}



		