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
            logoUAA.Location = new Point(376, 149);
            logoUAA.Margin = new Padding(3, 4, 3, 4);
            logoUAA.Name = "logoUAA";
            logoUAA.Size = new Size(794, 569);
            logoUAA.SizeMode = PictureBoxSizeMode.CenterImage;
            logoUAA.TabIndex = 0;
            logoUAA.TabStop = false;
            // 
            // lblProfesora
            // 
            lblProfesora.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblProfesora.AutoSize = true;
            lblProfesora.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblProfesora.Location = new Point(627, 753);
            lblProfesora.Name = "lblProfesora";
            lblProfesora.Size = new Size(368, 31);
            lblProfesora.TabIndex = 1;
            lblProfesora.Text = "Dra. Georgina Salazar Partida";
            lblProfesora.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNombreSistema
            // 
            lblNombreSistema.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblNombreSistema.AutoSize = true;
            lblNombreSistema.Font = new Font("Times New Roman", 15.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblNombreSistema.Location = new Point(539, 784);
            lblNombreSistema.Name = "lblNombreSistema";
            lblNombreSistema.Size = new Size(600, 31);
            lblNombreSistema.TabIndex = 2;
            lblNombreSistema.Text = "Software de base de datos para pasteleria \"Tartana\"";
            lblNombreSistema.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblMateria
            // 
            lblMateria.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblMateria.AutoSize = true;
            lblMateria.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMateria.Location = new Point(663, 723);
            lblMateria.Name = "lblMateria";
            lblMateria.Size = new Size(281, 31);
            lblMateria.TabIndex = 3;
            lblMateria.Text = "PROGRAMACIÓN II ";
            lblMateria.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblFecha
            // 
            lblFecha.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Segoe UI", 9.75F, FontStyle.Underline);
            lblFecha.Location = new Point(1247, 989);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(267, 23);
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
            lblHora.Location = new Point(1323, 969);
            lblHora.Name = "lblHora";
            lblHora.Size = new Size(72, 23);
            lblHora.TabIndex = 5;
            lblHora.Text = "00:00:00";
            lblHora.Click += lblHora_Click;
            // 
            // lblGael
            // 
            lblGael.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblGael.AutoSize = true;
            lblGael.Font = new Font("Segoe UI", 11.25F);
            lblGael.Location = new Point(243, 815);
            lblGael.Name = "lblGael";
            lblGael.Size = new Size(345, 25);
            lblGael.TabIndex = 6;
            lblGael.Text = "[508462] Gael Emiliano Nafarrate López";
            // 
            // lblBrandon
            // 
            lblBrandon.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblBrandon.AutoSize = true;
            lblBrandon.Font = new Font("Segoe UI", 11.25F);
            lblBrandon.Location = new Point(243, 841);
            lblBrandon.Name = "lblBrandon";
            lblBrandon.Size = new Size(340, 25);
            lblBrandon.TabIndex = 7;
            lblBrandon.Text = "[415730] Brandon Javier Becerra Dávila";
            // 
            // lblBruno
            // 
            lblBruno.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblBruno.AutoSize = true;
            lblBruno.Font = new Font("Segoe UI", 11.25F);
            lblBruno.Location = new Point(243, 867);
            lblBruno.Name = "lblBruno";
            lblBruno.Size = new Size(287, 25);
            lblBruno.TabIndex = 8;
            lblBruno.Text = "[301249] Bruno González castillo";
            // 
            // lblAzael
            // 
            lblAzael.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblAzael.AutoSize = true;
            lblAzael.Font = new Font("Segoe UI", 11.25F);
            lblAzael.Location = new Point(243, 893);
            lblAzael.Name = "lblAzael";
            lblAzael.Size = new Size(317, 25);
            lblAzael.TabIndex = 9;
            lblAzael.Text = "[446917] Angel Azael Fajardo Espino";
            // 
            // btnInicio
            // 
            btnInicio.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnInicio.ImageAlign = ContentAlignment.BottomCenter;
            btnInicio.Location = new Point(738, 853);
            btnInicio.Margin = new Padding(3, 4, 3, 4);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(117, 40);
            btnInicio.TabIndex = 10;
            btnInicio.Text = "INICIO";
            btnInicio.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnInicio.UseVisualStyleBackColor = true;
            btnInicio.Click += btnInicio_Click;
            // 
            // formPresentacion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1499, 1024);
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
            Margin = new Padding(3, 4, 3, 4);
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
