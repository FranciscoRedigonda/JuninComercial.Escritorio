namespace JuninComercial.Escritorio.Vistas;

partial class vistalogin
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    private void InitializeComponent()
    {
        lblTitulo = new Label();
        lblUsuario = new Label();
        txtUsuario = new TextBox();
        lblPassword = new Label();
        txtPassword = new TextBox();
        btnIngresar = new Button();
        lblMensaje = new Label();
        btnCerrar = new Button();
        SuspendLayout();
        // 
        // lblTitulo
        // 
        lblTitulo.AutoSize = true;
        lblTitulo.Font = new Font("Impact", 22F, FontStyle.Italic);
        lblTitulo.ForeColor = Color.Black;
        lblTitulo.Location = new Point(165, 45);
        lblTitulo.Name = "lblTitulo";
        lblTitulo.Size = new Size(180, 37);
        lblTitulo.TabIndex = 0;
        lblTitulo.Text = "BIENVENIDOS!";
        // 
        // lblUsuario
        // 
        lblUsuario.AutoSize = true;
        lblUsuario.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
        lblUsuario.ForeColor = Color.FromArgb(225, 235, 235);
        lblUsuario.Location = new Point(90, 100);
        lblUsuario.Name = "lblUsuario";
        lblUsuario.Size = new Size(59, 17);
        lblUsuario.TabIndex = 1;
        lblUsuario.Text = "Usuario:";
        // 
        // txtUsuario
        // 
        txtUsuario.BackColor = Color.FromArgb(115, 121, 118);
        txtUsuario.BorderStyle = BorderStyle.FixedSingle;
        txtUsuario.Font = new Font("Segoe UI", 11F);
        txtUsuario.ForeColor = Color.White;
        txtUsuario.Location = new Point(90, 122);
        txtUsuario.Name = "txtUsuario";
        txtUsuario.Size = new Size(350, 27);
        txtUsuario.TabIndex = 2;
        txtUsuario.TextChanged += txtUsuario_TextChanged;
        // 
        // lblPassword
        // 
        lblPassword.AutoSize = true;
        lblPassword.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
        lblPassword.ForeColor = Color.FromArgb(225, 235, 235);
        lblPassword.Location = new Point(90, 165);
        lblPassword.Name = "lblPassword";
        lblPassword.Size = new Size(81, 17);
        lblPassword.TabIndex = 3;
        lblPassword.Text = "Contraseña:";
        // 
        // txtPassword
        // 
        txtPassword.BackColor = Color.FromArgb(115, 121, 118);
        txtPassword.BorderStyle = BorderStyle.FixedSingle;
        txtPassword.Font = new Font("Segoe UI", 11F);
        txtPassword.ForeColor = Color.White;
        txtPassword.Location = new Point(90, 187);
        txtPassword.Name = "txtPassword";
        txtPassword.Size = new Size(350, 27);
        txtPassword.TabIndex = 4;
        txtPassword.UseSystemPasswordChar = true;
        // 
        // btnIngresar
        // 
        btnIngresar.BackColor = Color.FromArgb(79, 99, 142);
        btnIngresar.Cursor = Cursors.Hand;
        btnIngresar.FlatAppearance.BorderSize = 0;
        btnIngresar.FlatStyle = FlatStyle.Flat;
        btnIngresar.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        btnIngresar.ForeColor = Color.White;
        btnIngresar.Location = new Point(90, 252);
        btnIngresar.Name = "btnIngresar";
        btnIngresar.Size = new Size(350, 38);
        btnIngresar.TabIndex = 5;
        btnIngresar.Text = "Iniciar sesión";
        btnIngresar.UseVisualStyleBackColor = false;
        btnIngresar.Click += btnIngresar_Click;
        // 
        // lblMensaje
        // 
        lblMensaje.Font = new Font("Segoe UI", 9F);
        lblMensaje.ForeColor = Color.FromArgb(170, 20, 20);
        lblMensaje.Location = new Point(90, 222);
        lblMensaje.Name = "lblMensaje";
        lblMensaje.Size = new Size(350, 22);
        lblMensaje.TabIndex = 7;
        // 
        // btnCerrar
        // 
        btnCerrar.FlatAppearance.BorderSize = 0;
        btnCerrar.FlatStyle = FlatStyle.Flat;
        btnCerrar.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        btnCerrar.ForeColor = Color.FromArgb(220, 50, 50);
        btnCerrar.Location = new Point(480, 10);
        btnCerrar.Name = "btnCerrar";
        btnCerrar.Size = new Size(35, 30);
        btnCerrar.TabIndex = 6;
        btnCerrar.Text = "✕";
        btnCerrar.UseVisualStyleBackColor = true;
        btnCerrar.Click += btnCerrar_Click;
        // 
        // vistalogin
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(104, 144, 165);
        ClientSize = new Size(530, 340);
        Controls.Add(btnCerrar);
        Controls.Add(lblMensaje);
        Controls.Add(btnIngresar);
        Controls.Add(txtPassword);
        Controls.Add(lblPassword);
        Controls.Add(txtUsuario);
        Controls.Add(lblUsuario);
        Controls.Add(lblTitulo);
        FormBorderStyle = FormBorderStyle.None;
        Name = "vistalogin";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "vistalogin";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label lblTitulo;
    private Label lblUsuario;
    private TextBox txtUsuario;
    private Label lblPassword;
    private TextBox txtPassword;
    private Button btnIngresar;
    private Label lblMensaje;
    private Button btnCerrar;
}