namespace JuninComercial.Escritorio.Logica;

using JuninComercial.Escritorio.Datos;
using JuninComercial.Escritorio.Modelo;

public class ValidaUsuario
{
    private readonly loginDAO _dao = new loginDAO();
    private int _intentosRestantes = 3;

    public int IntentosRestantes => _intentosRestantes;
    public bool EstaBloqueado => _intentosRestantes <= 0;

    public Usuario IniciarSesion(string name, string password)
    {
        if (EstaBloqueado)
            throw new AVISOS("Usuario bloqueado por exceder el número máximo de intentos.");

        if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(password))
            throw new AVISOS("Completá usuario y contraseña.");

        var usuario = _dao.Autenticar(name.Trim(), password.Trim());

        if (usuario == null)
        {
            _intentosRestantes--;

            if (EstaBloqueado)
                throw new AVISOS("Usuario bloqueado por exceder el número máximo de intentos.");

            throw new AVISOS($"Usuario o contraseña incorrectos. Le quedan {_intentosRestantes} intento(s).");
        }

        _intentosRestantes = 3;
        return usuario;
    }
}