namespace JuninComercial.Escritorio.Datos;

using MySqlConnector;
using JuninComercial.Escritorio.Modelo;

public class loginDAO
{
    public Usuario Autenticar(string name, string password)
    {
        const string sql = "SELECT id_login, name, password, user_type FROM login WHERE name = @name AND password = @password";

        MySqlConnection con = null;
        MySqlCommand ps = null;
        MySqlDataReader rs = null;

        try
        {
            con = ConexionBD.Abrir();
            ps = new MySqlCommand(sql, con);

            ps.Parameters.AddWithValue("@name", name);
            ps.Parameters.AddWithValue("@password", password);

            rs = ps.ExecuteReader();

            if (rs.Read())
            {
                return new Usuario
                {
                    IdLogin = rs.GetInt32("id_login"),
                    Name = rs.GetString("name"),
                    Password = rs.GetString("password"),
                    UserType = rs.IsDBNull(rs.GetOrdinal("user_type")) ? string.Empty : rs.GetString("user_type")
                };
            }

            return null;
        }
        catch (MySqlException)
        {
            throw;
        }
        finally
        {
            ConexionBD.CerrarSeguro(rs);
            ConexionBD.CerrarSeguro(ps);
            ConexionBD.CerrarSeguro(con);
        }
    }
}