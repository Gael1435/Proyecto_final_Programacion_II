namespace Presentacion_e_inicio_de_sesion
{
    partial class formPresentacion
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            logoUAA = new PictureBox();
            lblProfesora = new Label();
            lblNombreSistema = new Label();
            lblMateria = new Label();
            lblFecha = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            lblHora = new Label();
            lblGael = new Label();
            lblBrandon = new Label();
            lblBruno = new Label();
            lblAzael = new Label();
            btnInicio = new Button();
            ((System.ComponentModel.ISupportInitialize)logoUAA).BeginInit();
            SuspendLayout();
            // 
            // logoUAA
            // 
            logoUAA.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            logoUAA.Image = Properties.Resources.uaalogo;
            logoUAA.Location = new Point(329, 112);
            logoUAA.Name = "logoUAA";
            logoUAA.Size = new Size(695, 427);
            logoUAA.SizeMode = PictureBoxSizeMode.CenterImage;
            logoUAA.TabIndex = 0;
            logoUAA.TabStop = false;
            // 
            // lblProfesora
            // 
            lblProfesora.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblProfesora.AutoSize = true;
            lblProfesora.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblProfesora.Location = new Point(549, 565);
            lblProfesora.Name = "lblProfesora";
            lblProfesora.Size = new Size(279, 24);
            lblProfesora.TabIndex = 1;
            lblProfesora.Text = "Dra. Georgina Salazar Partida";
            lblProfesora.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNombreSistema
            // 
            lblNombreSistema.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblNombreSistema.AutoSize = true;
            lblNombreSistema.Font = new Font("Times New Roman", 15.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblNombreSistema.Location = new Point(472, 588);
            lblNombreSistema.Name = "lblNombreSistema";
            lblNombreSistema.Size = new Size(458, 23);
            lblNombreSistema.TabIndex = 2;
            lblNombreSistema.Text = "Software de base de datos para pasteleria \"Tartana\"";
            lblNombreSistema.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblMateria
            // 
            lblMateria.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblMateria.AutoSize = true;
            lblMateria.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMateria.Location = new Point(580, 542);
            lblMateria.Name = "lblMateria";
            lblMateria.Size = new Size(212, 24);
            lblMateria.TabIndex = 3;
            lblMateria.Text = "PROGRAMACIÓN II ";
            lblMateria.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblFecha
            // 
            lblFecha.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Segoe UI", 9.75F, FontStyle.Underline);
            lblFecha.Location = new Point(1091, 742);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(209, 17);
            lblFecha.TabIndex = 4;
            lblFecha.Text = "Sabado, 14 de diciembre del 2024";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // lblHora
            // 
            lblHora.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblHora.AutoSize = true;
            lblHora.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHora.Location = new Point(1158, 727);
            lblHora.Name = "lblHora";
            lblHora.Size = new Size(56, 17);
            lblHora.TabIndex = 5;
            lblHora.Text = "00:00:00";
            // 
            // lblGael
            // 
            lblGael.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblGael.AutoSize = true;
            lblGael.Font = new Font("Segoe UI", 11.25F);
            lblGael.Location = new Point(213, 611);
            lblGael.Name = "lblGael";
            lblGael.Size = new Size(274, 20);
            lblGael.TabIndex = 6;
            lblGael.Text = "[508462] Gael Emiliano Nafarrate López";
            // 
            // lblBrandon
            // 
            lblBrandon.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblBrandon.AutoSize = true;
            lblBrandon.Font = new Font("Segoe UI", 11.25F);
            lblBrandon.Location = new Point(213, 631);
            lblBrandon.Name = "lblBrandon";
            lblBrandon.Size = new Size(268, 20);
            lblBrandon.TabIndex = 7;
            lblBrandon.Text = "[415730] Brandon Javier Becerra Dávila";
            // 
            // lblBruno
            // 
            lblBruno.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblBruno.AutoSize = true;
            lblBruno.Font = new Font("Segoe UI", 11.25F);
            lblBruno.Location = new Point(213, 650);
            lblBruno.Name = "lblBruno";
            lblBruno.Size = new Size(226, 20);
            lblBruno.TabIndex = 8;
            lblBruno.Text = "[301249] Bruno González castillo";
            // 
            // lblAzael
            // 
            lblAzael.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblAzael.AutoSize = true;
            lblAzael.Font = new Font("Segoe UI", 11.25F);
            lblAzael.Location = new Point(213, 670);
            lblAzael.Name = "lblAzael";
            lblAzael.Size = new Size(252, 20);
            lblAzael.TabIndex = 9;
            lblAzael.Text = "[446917] Angel Azael Fajardo Espino";
            // 
            // btnInicio
            // 
            btnInicio.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnInicio.ImageAlign = ContentAlignment.BottomCenter;
            btnInicio.Location = new Point(646, 640);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(102, 30);
            btnInicio.TabIndex = 10;
            btnInicio.Text = "INICIO";
            btnInicio.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnInicio.UseVisualStyleBackColor = true;
            btnInicio.Click += btnInicio_Click;
            // 
            // formPresentacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1312, 768);
            Controls.Add(btnInicio);
            Controls.Add(lblAzael);
            Controls.Add(lblBruno);
            Controls.Add(lblBrandon);
            Controls.Add(lblGael);
            Controls.Add(lblHora);
            Controls.Add(lblFecha);
            Controls.Add(lblMateria);
            Controls.Add(lblNombreSistema);
            Controls.Add(lblProfesora);
            Controls.Add(logoUAA);
            Name = "formPresentacion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PRESENTACION";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)logoUAA).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox logoUAA;
        private Label lblProfesora;
        private Label lblNombreSistema;
        private Label lblMateria;
        private Label lblFecha;
        private System.Windows.Forms.Timer timer1;
        private Label lblHora;
        private Label lblGael;
        private Label lblBrandon;
        private Label lblBruno;
        private Label lblAzael;
        public Button btnInicio;
    }
}
