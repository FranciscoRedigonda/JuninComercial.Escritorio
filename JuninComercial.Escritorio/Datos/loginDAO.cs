namespace JuninComercial.Escritorio.Datos;

using MySqlConnector;
using JuninComercial.Escritorio.Modelo;

public class loginDAO
{
    public Usuario Autenticar(string name, string password)
    {
        const string sql = "SELECT id_login, name, password, user_type FROM login WHERE name = @name AND password = @password"; //consulta q busca la coincidencia entre el usuario y la clave
        //fuera del try para poder cerrarlos con el finally
        MySqlConnection con = null; 
        MySqlCommand ps = null;          //variables, si no coinciden = null
        MySqlDataReader rs = null; //recorre
         
        try
        {
            con = ConexionBD.Abrir(); //abre mysql
            ps = new MySqlCommand(sql, con); //consulta, conexion

            ps.Parameters.AddWithValue("@name", name);         //inserta lo q escribio el usuario. 
            ps.Parameters.AddWithValue("@password", password);

            rs = ps.ExecuteReader();

            if (rs.Read()) //devuelve true si coindide, false sino.
            {
                return new Usuario //si lo encontro
                {
                    IdLogin = rs.GetInt32("id_login"),
                    Name = rs.GetString("name"),
                    Password = rs.GetString("password"),
                    UserType = rs.IsDBNull(rs.GetOrdinal("user_type")) ? string.Empty : rs.GetString("user_type") //si usertype es null usa texto vacio para evitar errores
                };
            }

            return null; //si no encontro nada
        }
        catch (MySqlException)
        {
            throw;
        }
        finally //aca lo cierra para que no se arme quilombo y saturar al servidor.
        {
            ConexionBD.CerrarSeguro(rs);
            ConexionBD.CerrarSeguro(ps); //se ejecuta error o no.
            ConexionBD.CerrarSeguro(con);
        }
    }
}