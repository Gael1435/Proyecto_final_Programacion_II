namespace Presentacion_e_inicio_de_sesion
{
    partial class formLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formLogin));
            txtboxUsuario = new TextBox();
            txtboxContra = new TextBox();
            btnEntrar = new Button();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            pnlLinea = new Panel();
            panel2 = new Panel();
            label1 = new Label();
            btnCerrar = new PictureBox();
            btnMinimizar = new PictureBox();
            lblInvitado = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).BeginInit();
            SuspendLayout();
            // 
            // txtboxUsuario
            // 
            txtboxUsuario.BackColor = Color.WhiteSmoke;
            txtboxUsuario.BorderStyle = BorderStyle.None;
            txtboxUsuario.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtboxUsuario.ForeColor = Color.DimGray;
            txtboxUsuario.Location = new Point(283, 101);
            txtboxUsuario.Name = "txtboxUsuario";
            txtboxUsuario.Size = new Size(468, 26);
            txtboxUsuario.TabIndex = 1;
            txtboxUsuario.Text = "USUARIO";
            txtboxUsuario.Enter += txtboxUsuario_Enter;
            txtboxUsuario.Leave += txtboxUsuario_Leave;
            // 
            // txtboxContra
            // 
            txtboxContra.BackColor = Color.WhiteSmoke;
            txtboxContra.BorderStyle = BorderStyle.None;
            txtboxContra.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtboxContra.ForeColor = Color.DimGray;
            txtboxContra.Location = new Point(283, 173);
            txtboxContra.Name = "txtboxContra";
            txtboxContra.Size = new Size(468, 26);
            txtboxContra.TabIndex = 2;
            txtboxContra.Text = "CONTRASEÑA";
            txtboxContra.Enter += txtboxContra_Enter;
            txtboxContra.Leave += txtboxContra_Leave;
            // 
            // btnEntrar
            // 
            btnEntrar.BackColor = Color.Gainsboro;
            btnEntrar.Cursor = Cursors.Hand;
            btnEntrar.FlatAppearance.BorderSize = 0;
            btnEntrar.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            btnEntrar.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnEntrar.FlatStyle = FlatStyle.Flat;
            btnEntrar.Font = new Font("Yu Gothic UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEntrar.Location = new Point(283, 243);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(468, 45);
            btnEntrar.TabIndex = 0;
            btnEntrar.Text = "ACCEDER";
            btnEntrar.UseVisualStyleBackColor = false;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Logo;
            pictureBox1.Location = new Point(29, 85);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(188, 164);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(248, 187, 208);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 330);
            panel1.TabIndex = 7;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // pnlLinea
            // 
            pnlLinea.BackColor = Color.Black;
            pnlLinea.Location = new Point(283, 126);
            pnlLinea.Name = "pnlLinea";
            pnlLinea.Size = new Size(468, 1);
            pnlLinea.TabIndex = 8;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Location = new Point(283, 198);
            panel2.Name = "panel2";
            panel2.Size = new Size(468, 1);
            panel2.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(460, 7);
            label1.Name = "label1";
            label1.Size = new Size(98, 37);
            label1.TabIndex = 10;
            label1.Text = "LOGIN";
            // 
            // btnCerrar
            // 
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.Image = Properties.Resources.boton_cerrar;
            btnCerrar.Location = new Point(754, 5);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(24, 24);
            btnCerrar.SizeMode = PictureBoxSizeMode.StretchImage;
            btnCerrar.TabIndex = 11;
            btnCerrar.TabStop = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnMinimizar
            // 
            btnMinimizar.Cursor = Cursors.Hand;
            btnMinimizar.Image = (Image)resources.GetObject("btnMinimizar.Image");
            btnMinimizar.Location = new Point(724, 5);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(24, 24);
            btnMinimizar.SizeMode = PictureBoxSizeMode.StretchImage;
            btnMinimizar.TabIndex = 12;
            btnMinimizar.TabStop = false;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // lblInvitado
            // 
            lblInvitado.BackColor = Color.WhiteSmoke;
            lblInvitado.Cursor = Cursors.Hand;
            lblInvitado.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblInvitado.ForeColor = Color.Blue;
            lblInvitado.Location = new Point(446, 291);
            lblInvitado.Name = "lblInvitado";
            lblInvitado.Size = new Size(142, 17);
            lblInvitado.TabIndex = 13;
            lblInvitado.Text = "Ingresar como Invitado?";
            lblInvitado.Click += lblInvitado_Click;
            // 
            // formLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(780, 330);
            Controls.Add(lblInvitado);
            Controls.Add(btnMinimizar);
            Controls.Add(btnCerrar);
            Controls.Add(label1);
            Controls.Add(panel2);
            Controls.Add(pnlLinea);
            Controls.Add(btnEntrar);
            Controls.Add(panel1);
            Controls.Add(txtboxContra);
            Controls.Add(txtboxUsuario);
            FormBorderStyle = FormBorderStyle.None;
            Name = "formLogin";
            Opacity = 0.9D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += formLogin_Load;
            MouseDown += formLogin_MouseDown;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtboxUsuario;
        private TextBox txtboxContra;
        private Button btnEntrar;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Panel pnlLinea;
        private Panel panel2;
        private Label label1;
        private PictureBox btnCerrar;
        private PictureBox btnMinimizar;
        private Label lblInvitado;
    }
}