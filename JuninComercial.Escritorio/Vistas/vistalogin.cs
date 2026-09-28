namespace JuninComercial.Escritorio.Vistas;

using System;
using System.Drawing;
using System.Windows.Forms;
using JuninComercial.Escritorio.Logica;
using MySqlConnector;

public partial class vistalogin : Form
{
    private readonly ValidaUsuario _validador = new ValidaUsuario();

    public vistalogin()
    {
        InitializeComponent();
        lblMensaje.Text = string.Empty;
    }

    private void btnIngresar_Click(object sender, EventArgs e)
    {
        try
        {
            lblMensaje.Text = string.Empty;

            var usuario = _validador.IniciarSesion(txtUsuario.Text, txtPassword.Text);

            MessageBox.Show($"¡Bienvenido, {usuario.Name}!\nAcceso concedido.", "Acceso concedido",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

            var menu = new MenuPrincipal();
            menu.Show();
            this.Hide();
        }
        catch (AVISOS ex)
        {
            lblMensaje.Text = ex.Message;

            if (_validador.EstaBloqueado)
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
        Application.Exit();
    }

    private void txtUsuario_TextChanged(object sender, EventArgs e)
    {

    }
}