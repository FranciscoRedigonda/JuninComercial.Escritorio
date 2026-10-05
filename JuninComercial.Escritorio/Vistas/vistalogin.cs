namespace JuninComercial.Escritorio.Vistas;

using System;
using System.Drawing;
using System.Windows.Forms;
using JuninComercial.Escritorio.Logica;
using MySqlConnector;

public partial class vistalogin : Form
{
    private readonly ValidaUsuario _validador = new ValidaUsuario(); //empieza a manejar intentos y validaciones

    public vistalogin() //
    {
        InitializeComponent();
        lblMensaje.Text = string.Empty;
    }

    private void btnIngresar_Click(object sender, EventArgs e) //intento de ingreso
    {
        try
        {
            lblMensaje.Text = string.Empty;

            var usuario = _validador.IniciarSesion(txtUsuario.Text, txtPassword.Text); //lo q escribio el usuario

            MessageBox.Show($"¡Bienvenido, {usuario.Name}!\nAcceso concedido.", "Acceso concedido", //si los datos son correctos muestra esto
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

            var menu = new MenuPrincipal();
            menu.Show();  //abre menu principal
            this.Hide();
        }
        catch (AVISOS ex) //tira los avisos si no se acabaron
        {
            lblMensaje.Text = ex.Message;

            if (_validador.EstaBloqueado) //bloquea si se acabaron
            {
                txtUsuario.Enabled = false;
                txtPassword.Enabled = false;
                btnIngresar.Enabled = false;
            }
        }
        catch (MySqlException)
        {
            MessageBox.Show("No se pudo conectar con la base de datos de la facultad.\nVerificá tu conexión a internet.", 
                            "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error); 
        }
    }

    private void btnCerrar_Click(object sender, EventArgs e)
    {
        Application.Exit();  //cierra la aplicacion por complelto
    }

    private void txtUsuario_TextChanged(object sender, EventArgs e)
    {

    }
}