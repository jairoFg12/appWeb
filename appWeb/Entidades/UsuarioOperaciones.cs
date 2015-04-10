using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace appWeb
{
	public class UsuarioOperaciones
	{
		public static int Agregar(Usuario pUsuario)
		{
			int retorno = 0;



			MySqlCommand comando = new MySqlCommand(string.Format("INSERT INTO Usuario " +
				"(UsuTipoPersona, UsuTipoIdentificacion, UsuIdentificacion," +
				" UsuNombreCompleto, UsuPrimerNombre, UsuSegundoNombre, " +
				" UsuPrimerApellido, UsuSegundoApellido, UsuActivo, " +
				" UsuCiudad, UsuDireccion, UsuTelefono, UsuIngresos, UsuEgresos) " +
			    " values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}')",
			pUsuario.UsuTipoPersona, pUsuario.UsuTipoIdentificacion,pUsuario.UsuIdentificacion,pUsuario.UsuNombreCompleto,
			pUsuario.UsuPrimerNombre,pUsuario.UsuSegundoNombre,pUsuario.UsuPrimerApellido,
			pUsuario.UsuSegundoApellido,pUsuario.UsuActivo,pUsuario.UsuCiudad,pUsuario.UsuDireccion,
			pUsuario.UsuTelefono,pUsuario.UsuIngresos,pUsuario.UsuEgresos), BDComun.ObtenerConexion());
			retorno = comando.ExecuteNonQuery();
			return  retorno;
		}

		public static List<Usuario> consultarUsuarios()
		{

			List<Usuario> usuarios = new List<Usuario>();
			MySqlCommand comando = new MySqlCommand(string.Format("SELECT * FROM Usuario"), BDComun.ObtenerConexion());
			MySqlDataReader resultado  = comando.ExecuteReader();

			while (resultado.Read()) 
			{
				Usuario pUsuario = new Usuario ();
				pUsuario.UsuId = resultado.GetInt32 (0);
				pUsuario.UsuIdentificacion = resultado.GetString (3);
				pUsuario.UsuNombreCompleto = resultado.GetString (4);
				pUsuario.UsuActivo = resultado.GetInt32 (9);
				pUsuario.UsuCiudad = resultado.GetInt32 (10);
				pUsuario.UsuDireccion = resultado.GetString (11);
				pUsuario.UsuTelefono = resultado.GetString (12);
				pUsuario.UsuIngresos = resultado.GetDouble (13);
				pUsuario.UsuEgresos = resultado.GetDouble (14);

				usuarios.Add (pUsuario);
			}

			return usuarios;
		}


	}
}

