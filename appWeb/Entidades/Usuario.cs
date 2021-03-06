using System;

namespace appWeb
{
	public class Usuario
	{
	public int UsuId { get; set; }
	public string UsuTipoPersona { get; set; }
	public string UsuTipoIdentificacion{ get; set; }
	public string UsuIdentificacion { get; set; }
	public string UsuNombreCompleto { get; set; }
	public string UsuPrimerNombre { get; set; }
	public string UsuSegundoNombre { get; set; }
	public string UsuPrimerApellido { get; set; }
	public string UsuSegundoApellido { get; set; }
	public int UsuActivo { get; set; }
	public int UsuCiudad { get; set; }
	public string UsuDireccion { get; set; }
	public string UsuTelefono { get; set; }
	public double UsuIngresos { get; set; }
	public double UsuEgresos { get; set; }
	public double UsuBalance { get; set; }
	public string UsuNombreCiudad { get; set; }

	public Usuario() { }

	public Usuario(int pUsuId,string pUsuTipoPersona, string pUsuTipoIdentificacion, 
	               string pUsuIdentificacion,string pUsuNombreCompleto,string pUsuPrimerNombre,string pUsuSegundoNombre,
	               string pUsuPrimerApellido,string pUsuSegundoApellido,int pUsuActivo, int pUsuCiudad, string pUsuDireccion,
	               string pUsuTelefono,double pUsuIngresos,double pUsuEgresos,double pUsuBalance
	               )

	{

	this.UsuId = pUsuId;
	this.UsuTipoPersona = pUsuTipoPersona;
	this.UsuTipoIdentificacion = pUsuTipoIdentificacion;
	this.UsuIdentificacion = pUsuIdentificacion;
	this.UsuNombreCompleto = pUsuNombreCompleto;
	this.UsuPrimerNombre = pUsuPrimerNombre;
	this.UsuSegundoNombre = pUsuSegundoNombre;
	this.UsuPrimerApellido = pUsuPrimerApellido;
	this.UsuSegundoApellido = pUsuSegundoApellido;
	this.UsuActivo = pUsuActivo;
	this.UsuCiudad = pUsuCiudad;
	this.UsuDireccion = pUsuDireccion;
	this.UsuTelefono = pUsuTelefono;
	this.UsuIngresos = pUsuIngresos;
	this.UsuEgresos = pUsuEgresos;
	this.UsuBalance = pUsuEgresos - pUsuEgresos;
	this.UsuNombreCiudad = "_";
    }

	}
}

