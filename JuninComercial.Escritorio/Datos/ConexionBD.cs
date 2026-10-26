namespace JuninComercial.Escritorio.Datos;

using System;  //l
using System.Configuration; 
using MySqlConnector; //l

public static class ConexionBD 
{
    private static string Cadena =>
        ConfigurationManager.ConnectionStrings["BaseIES"].ConnectionString; //app cadena de conexion 

    public static MySqlConnection Abrir()
    {
        var conexion = new MySqlConnection(Cadena);
        conexion.Open();
        return conexion;  //abre la conexion a MYSQL y retorna a quien llamo al metodo del dao
    }

    public static void CerrarSeguro(IDisposable recurso)
    {
        if (recurso == null) return;  //aca la cierra
        try
        {
            recurso.Dispose(); 
        }  
        catch
        {
            // Se traga para no tapar la excepción original finally
        }
    }
}