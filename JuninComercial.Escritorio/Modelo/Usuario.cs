namespace JuninComercial.Escritorio.Modelo;

public class Usuario
{
    public int IdLogin { get; set; } 
    public string Name { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
    public string UserType { get; set; } = string.Empty; 

    public Usuario() { }

    public Usuario(int idLogin, string name, string password, string userType)
    {
        IdLogin = idLogin;
        Name = name;
        Password = password;
        UserType = userType;
    }
}