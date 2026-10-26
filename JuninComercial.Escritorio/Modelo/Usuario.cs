namespace JuninComercial.Escritorio.Modelo;
//g datos
public class Usuario
{
    public int IdLogin { get; set; } 
    public string Name { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty; //empty para que nunca den null por si hay texto vaxio
    public string UserType { get; set; } = string.Empty; 

    public Usuario() { } //vacio para cargar propiedades dsp

    public Usuario(int idLogin, string name, string password, string userType)
    {
        IdLogin = idLogin;
        Name = name;
        Password = password;
        UserType = userType;
    }
}