namespace Presentacion_e_inicio_de_sesion
{
    partial class Form3
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
            panel6 = new Panel();
            button1 = new Button();
            label6 = new Label();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // panel6
            // 
            panel6.BackColor = Color.Firebrick;
            panel6.Controls.Add(button1);
            panel6.Location = new Point(-4, -7);
            panel6.Name = "panel6";
            panel6.Size = new Size(1600, 64);
            panel6.TabIndex = 4;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.System;
            button1.Font = new Font("Yu Gothic Light", 12F);
            button1.Location = new Point(1482, 19);
            button1.Name = "button1";
            button1.Size = new Size(108, 29);
            button1.TabIndex = 8;
            button1.Text = "Logout";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label6
            // 
            label6.BackColor = Color.WhiteSmoke;
            label6.BorderStyle = BorderStyle.Fixed3D;
            label6.Font = new Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ImageAlign = ContentAlignment.BottomCenter;
            label6.Location = new Point(1223, 74);
            label6.Name = "label6";
            label6.Size = new Size(360, 50);
            label6.TabIndex = 5;
            label6.TextAlign = ContentAlignment.MiddleLeft;
            label6.Click += label6_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1595, 828);
            Controls.Add(label6);
            Controls.Add(panel6);
            Name = "Form3";
            Opacity = 0.98D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pantalla de compras";
            Load += Form3_Load_1;
            panel6.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel6;
        private Label label6;
        private Button button1;
    }
}