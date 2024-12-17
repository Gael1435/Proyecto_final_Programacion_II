namespace Presentacion_e_inicio_de_sesion
{
    partial class FormTicket
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
            lblNombreUsuario = new Label();
            lblFechaHora = new Label();
            panelItems = new Panel();
            PbLogo = new PictureBox();
            bntConfirmar = new Button();
            panel1 = new Panel();
            panelItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PbLogo).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblNombreUsuario
            // 
            lblNombreUsuario.AutoSize = true;
            lblNombreUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombreUsuario.Location = new Point(190, 6);
            lblNombreUsuario.Margin = new Padding(4, 0, 4, 0);
            lblNombreUsuario.Name = "lblNombreUsuario";
            lblNombreUsuario.Size = new Size(69, 21);
            lblNombreUsuario.TabIndex = 0;
            lblNombreUsuario.Text = "Usuario";
            // 
            // lblFechaHora
            // 
            lblFechaHora.AutoSize = true;
            lblFechaHora.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFechaHora.Location = new Point(298, 755);
            lblFechaHora.Margin = new Padding(4, 0, 4, 0);
            lblFechaHora.Name = "lblFechaHora";
            lblFechaHora.Size = new Size(41, 17);
            lblFechaHora.TabIndex = 1;
            lblFechaHora.Text = "Fecha";
            // 
            // panelItems
            // 
            panelItems.Controls.Add(PbLogo);
            panelItems.Location = new Point(15, 38);
            panelItems.Margin = new Padding(4, 4, 4, 4);
            panelItems.Name = "panelItems";
            panelItems.Size = new Size(454, 636);
            panelItems.TabIndex = 3;
            panelItems.Paint += panelItems_Paint_1;
            // 
            // PbLogo
            // 
            PbLogo.BackColor = Color.Transparent;
            PbLogo.Image = Properties.Resources.Logo;
            PbLogo.Location = new Point(48, 176);
            PbLogo.Margin = new Padding(4, 4, 4, 4);
            PbLogo.Name = "PbLogo";
            PbLogo.Size = new Size(354, 337);
            PbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            PbLogo.TabIndex = 0;
            PbLogo.TabStop = false;
            // 
            // bntConfirmar
            // 
            bntConfirmar.Cursor = Cursors.Hand;
            bntConfirmar.FlatStyle = FlatStyle.Flat;
            bntConfirmar.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            bntConfirmar.Location = new Point(15, 704);
            bntConfirmar.Margin = new Padding(4, 4, 4, 4);
            bntConfirmar.Name = "bntConfirmar";
            bntConfirmar.Size = new Size(127, 46);
            bntConfirmar.TabIndex = 4;
            bntConfirmar.Text = "Confirmar";
            bntConfirmar.UseVisualStyleBackColor = true;
            bntConfirmar.Click += bntConfirmar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(248, 187, 208);
            panel1.Controls.Add(lblNombreUsuario);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 4, 4, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(483, 35);
            panel1.TabIndex = 5;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // FormTicket
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(483, 791);
            Controls.Add(panel1);
            Controls.Add(bntConfirmar);
            Controls.Add(panelItems);
            Controls.Add(lblFechaHora);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 4, 4, 4);
            Name = "FormTicket";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form6";
            panelItems.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PbLogo).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombreUsuario;
        private Label lblFechaHora;
        private Panel panelItems;
        private Button bntConfirmar;
        private Panel panel1;
        private PictureBox PbLogo;
    }
}