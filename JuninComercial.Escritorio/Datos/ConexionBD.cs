namespace JuninComercial.Escritorio.Datos;

using System;
using System.Configuration;
using MySqlConnector;

public static class ConexionBD
{
    private static string Cadena =>
        ConfigurationManager.ConnectionStrings["BaseIES"].ConnectionString;

    public static MySqlConnection Abrir()
    {
        var conexion = new MySqlConnection(Cadena);
        conexion.Open();
        return conexion;
    }

    public static void CerrarSeguro(IDisposable recurso)
    {
        if (recurso == null) return;
        try
        {
            recurso.Dispose();
        }
        catch
        {
            // Se traga para no tapar la excepción original
        }
    }
}