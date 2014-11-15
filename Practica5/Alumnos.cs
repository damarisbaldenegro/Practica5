using System;
using MySql.Data.MySqlClient;

namespace Practica5
{

		public class Alumnos : MySQL
	{
		public Alumnos ()
		{
		}
		
		public void mostrarTodos(){
			this.abrirConexion();
			try{
            MySqlCommand myCommand = new MySqlCommand(this.querySelect(), 
			                                          myConnection);
		
            MySqlDataReader myReader = myCommand.ExecuteReader();	
	        while (myReader.Read()){
	            string id = myReader["id"].ToString();
	            string codigo = myReader["codigo"].ToString();
	            string nombre = myReader["nombre"].ToString();
	             string telefono = myReader["telefono"].ToString();
	              string email = myReader["email"].ToString();
	            
						
	            Console.WriteLine("ID: " + id +
				                  " Código: " + codigo   + 
				                  " Nombre: " + nombre   +
				                  " Telefono" + telefono +
				                  " Email"   + email    + "\n\n\n");
	       }
			
            myReader.Close();
			myReader = null;
            myCommand.Dispose();
			myCommand = null;
			}catch (Exception e){
				Console.WriteLine(e.Message);
			}
			this.cerrarConexion();
			
		}
		
		public void insertarRegistroNuevo(int  codigo, string nombre,int telefono, string email){
			this.abrirConexion();
			try{
			string sql = "INSERT INTO `alumno` (`codigo`, `nombre` ,`telefono`,`email`) VALUES ('" + codigo + "', '" + nombre + "','"+telefono+"','"+email+"')";
				int camposAfectados = this.ejecutarComando(sql);
			Console.WriteLine("*Registro Ingresado con exito!!!");
			}catch (Exception e){
				Console.WriteLine(e.Message);}
				this.cerrarConexion();
			
			
		}
		
		private int ejecutarComando(string sql){
			MySqlCommand myCommand = new MySqlCommand(sql,this.myConnection);
			int afectadas = myCommand.ExecuteNonQuery();
			myCommand.Dispose();
			myCommand = null;
			return afectadas;
		}
		
		private string querySelect(){
			return "SELECT * " +
	           	"FROM alumno";
		}
	}
}

		
		

