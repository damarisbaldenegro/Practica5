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
            MySqlCommand myCommand = new MySqlCommand(this.querySelect(), 
			                                          myConnection);
		
            MySqlDataReader myReader = myCommand.ExecuteReader();	
	        while (myReader.Read()){
	            string id = myReader["id"].ToString();
	            string codigo = myReader["codigo"].ToString();
	            string nombre = myReader["nombre"].ToString();
	             string telefono = myReader["telefono"].ToString();
	              string email = myReader["e-mail"].ToString();
	              if(codigo.Length == 0 && nombre.Length == 0 && telefono.Length == 0 && email.Length == 0)
						
	            Console.WriteLine("ID: " + id +
				                  " Código: " + codigo   + 
				                  " Nombre: " + nombre   +
				                  " Telefono" + telefono +
				                  " E-mail"   + email    + "\n\n\n");
	       }
			
            myReader.Close();
			myReader = null;
            myCommand.Dispose();
			myCommand = null;
			this.cerrarConexion();
			
		}
		
		public void insertarRegistroNuevo(int  codigo, string nombre,int telefono, string email){
			this.abrirConexion();
			string sql = "INSERT INTO `alumno` (`codigo`, `nombre`,'telefono','email) VALUES ('" + codigo + "', '" + nombre + "','"+ telefono +"','"+ email +"')";
			Console.WriteLine("Registro Ingresado con exito");
			this.ejecutarComando(sql);
			
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

		
		

