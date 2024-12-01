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
            label2 = new Label();
            pnlLinea = new Panel();
            panel2 = new Panel();
            label1 = new Label();
            btnCerrar = new PictureBox();
            btnMinimizar = new PictureBox();
            button1 = new Button();
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
            txtboxUsuario.Location = new Point(323, 135);
            txtboxUsuario.Margin = new Padding(3, 4, 3, 4);
            txtboxUsuario.Name = "txtboxUsuario";
            txtboxUsuario.Size = new Size(535, 32);
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
            txtboxContra.Location = new Point(323, 231);
            txtboxContra.Margin = new Padding(3, 4, 3, 4);
            txtboxContra.Name = "txtboxContra";
            txtboxContra.Size = new Size(535, 32);
            txtboxContra.TabIndex = 2;
            txtboxContra.Text = "CONTRASEÑA";
            txtboxContra.Enter += txtboxContra_Enter;
            txtboxContra.Leave += txtboxContra_Leave;
            // 
            // btnEntrar
            // 
            btnEntrar.BackColor = Color.Gainsboro;
            btnEntrar.FlatAppearance.BorderSize = 0;
            btnEntrar.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            btnEntrar.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnEntrar.FlatStyle = FlatStyle.Flat;
            btnEntrar.Font = new Font("Yu Gothic UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEntrar.Location = new Point(323, 324);
            btnEntrar.Margin = new Padding(3, 4, 3, 4);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(535, 60);
            btnEntrar.TabIndex = 0;
            btnEntrar.Text = "ACCEDER";
            btnEntrar.UseVisualStyleBackColor = false;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Logo;
            pictureBox1.Location = new Point(33, 113);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(215, 219);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(248, 187, 208);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(286, 440);
            panel1.TabIndex = 7;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(0, 420);
            label2.Name = "label2";
            label2.Size = new Size(87, 20);
            label2.TabIndex = 11;
            label2.Text = "Tartana v0.5";
            // 
            // pnlLinea
            // 
            pnlLinea.BackColor = Color.Black;
            pnlLinea.Location = new Point(323, 168);
            pnlLinea.Margin = new Padding(3, 4, 3, 4);
            pnlLinea.Name = "pnlLinea";
            pnlLinea.Size = new Size(535, 1);
            pnlLinea.TabIndex = 8;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Location = new Point(323, 264);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(535, 1);
            panel2.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(526, 9);
            label1.Name = "label1";
            label1.Size = new Size(123, 46);
            label1.TabIndex = 10;
            label1.Text = "LOGIN";
            // 
            // btnCerrar
            // 
            btnCerrar.Image = Properties.Resources.boton_cerrar;
            btnCerrar.Location = new Point(862, 7);
            btnCerrar.Margin = new Padding(3, 4, 3, 4);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(27, 32);
            btnCerrar.SizeMode = PictureBoxSizeMode.StretchImage;
            btnCerrar.TabIndex = 11;
            btnCerrar.TabStop = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnMinimizar
            // 
            btnMinimizar.Image = (Image)resources.GetObject("btnMinimizar.Image");
            btnMinimizar.Location = new Point(827, 7);
            btnMinimizar.Margin = new Padding(3, 4, 3, 4);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(27, 32);
            btnMinimizar.SizeMode = PictureBoxSizeMode.StretchImage;
            btnMinimizar.TabIndex = 12;
            btnMinimizar.TabStop = false;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 10F);
            button1.Location = new Point(690, 64);
            button1.Name = "button1";
            button1.Size = new Size(179, 30);
            button1.TabIndex = 13;
            button1.Text = "Iniciar como usuario";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // formLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(891, 440);
            Controls.Add(button1);
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
            Margin = new Padding(3, 4, 3, 4);
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
        private Label label2;
        private PictureBox btnCerrar;
        private PictureBox btnMinimizar;
        private Button button1;
    }
}