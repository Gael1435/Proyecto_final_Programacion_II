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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formLogin));
            txtboxUsuario = new TextBox();
            txtboxContra = new TextBox();
            btnEntrar = new Button();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            lblHora = new Label();
            lblFecha = new Label();
            pnlLinea = new Panel();
            panel2 = new Panel();
            label1 = new Label();
            btnCerrar = new PictureBox();
            btnMinimizar = new PictureBox();
            lblInvitado = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
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
            txtboxUsuario.Location = new Point(364, 141);
            txtboxUsuario.Margin = new Padding(4);
            txtboxUsuario.Name = "txtboxUsuario";
            txtboxUsuario.Size = new Size(602, 26);
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
            txtboxContra.Location = new Point(364, 242);
            txtboxContra.Margin = new Padding(4);
            txtboxContra.Name = "txtboxContra";
            txtboxContra.Size = new Size(602, 26);
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
            btnEntrar.Location = new Point(364, 340);
            btnEntrar.Margin = new Padding(4);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(602, 63);
            btnEntrar.TabIndex = 0;
            btnEntrar.Text = "ACCEDER";
            btnEntrar.UseVisualStyleBackColor = false;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Logo;
            pictureBox1.Location = new Point(37, 119);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(242, 230);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(248, 187, 208);
            panel1.Controls.Add(lblHora);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(lblFecha);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(321, 462);
            panel1.TabIndex = 7;
            panel1.Paint += panel1_Paint;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // lblHora
            // 
            lblHora.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblHora.AutoSize = true;
            lblHora.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHora.Location = new Point(102, 405);
            lblHora.Margin = new Padding(4, 0, 4, 0);
            lblHora.Name = "lblHora";
            lblHora.Size = new Size(56, 17);
            lblHora.TabIndex = 15;
            lblHora.Text = "00:00:00";
            // 
            // lblFecha
            // 
            lblFecha.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Segoe UI", 9.75F, FontStyle.Underline);
            lblFecha.Location = new Point(15, 426);
            lblFecha.Margin = new Padding(4, 0, 4, 0);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(209, 17);
            lblFecha.TabIndex = 14;
            lblFecha.Text = "Sabado, 14 de diciembre del 2024";
            // 
            // pnlLinea
            // 
            pnlLinea.BackColor = Color.Black;
            pnlLinea.Location = new Point(364, 176);
            pnlLinea.Margin = new Padding(4);
            pnlLinea.Name = "pnlLinea";
            pnlLinea.Size = new Size(602, 1);
            pnlLinea.TabIndex = 8;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Location = new Point(364, 277);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(602, 1);
            panel2.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(591, 10);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(98, 37);
            label1.TabIndex = 10;
            label1.Text = "LOGIN";
            // 
            // btnCerrar
            // 
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.Image = Properties.Resources.boton_cerrar;
            btnCerrar.Location = new Point(969, 7);
            btnCerrar.Margin = new Padding(4);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(31, 34);
            btnCerrar.SizeMode = PictureBoxSizeMode.StretchImage;
            btnCerrar.TabIndex = 11;
            btnCerrar.TabStop = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnMinimizar
            // 
            btnMinimizar.Cursor = Cursors.Hand;
            btnMinimizar.Image = (Image)resources.GetObject("btnMinimizar.Image");
            btnMinimizar.Location = new Point(931, 7);
            btnMinimizar.Margin = new Padding(4);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(31, 34);
            btnMinimizar.SizeMode = PictureBoxSizeMode.StretchImage;
            btnMinimizar.TabIndex = 12;
            btnMinimizar.TabStop = false;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // lblInvitado
            // 
            lblInvitado.AutoSize = true;
            lblInvitado.BackColor = Color.WhiteSmoke;
            lblInvitado.Cursor = Cursors.Hand;
            lblInvitado.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblInvitado.ForeColor = Color.Blue;
            lblInvitado.Location = new Point(591, 417);
            lblInvitado.Margin = new Padding(4, 0, 4, 0);
            lblInvitado.Name = "lblInvitado";
            lblInvitado.Size = new Size(136, 17);
            lblInvitado.TabIndex = 13;
            lblInvitado.Text = "Ingresar como Invitado";
            lblInvitado.Click += lblInvitado_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // formLogin
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1003, 462);
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
            Margin = new Padding(4);
            Name = "formLogin";
            Opacity = 0.9D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += formLogin_Load;
            MouseDown += formLogin_MouseDown;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private Label lblHora;
        private Label lblFecha;
        public System.Windows.Forms.Timer timer1;
    }
}