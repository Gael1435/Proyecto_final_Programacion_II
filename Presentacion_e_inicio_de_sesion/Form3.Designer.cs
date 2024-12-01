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
            panel1 = new Panel();
            panel5 = new Panel();
            panel4 = new Panel();
            panel3 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            panel6 = new Panel();
            button1 = new Button();
            label6 = new Label();
            panel1.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Location = new Point(3, 120);
            panel1.Name = "panel1";
            panel1.Size = new Size(813, 793);
            panel1.TabIndex = 2;
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.ButtonFace;
            panel5.Location = new Point(670, -2);
            panel5.Name = "panel5";
            panel5.Size = new Size(90, 793);
            panel5.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Gainsboro;
            panel4.Location = new Point(0, -2);
            panel4.Name = "panel4";
            panel4.Size = new Size(90, 793);
            panel4.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ButtonFace;
            panel3.Location = new Point(132, -2);
            panel3.Name = "panel3";
            panel3.Size = new Size(435, 793);
            panel3.TabIndex = 0;
            // 
            // label1
            // 
            label1.BackColor = Color.Gray;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Yu Gothic Light", 10F);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(99, 63);
            label1.Name = "label1";
            label1.Size = new Size(32, 50);
            label1.TabIndex = 3;
            label1.Text = "ID";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.BackColor = Color.Gray;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Font = new Font("Yu Gothic Light", 10F);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(5, 63);
            label2.Name = "label2";
            label2.Size = new Size(90, 50);
            label2.TabIndex = 3;
            label2.Text = "Imagen";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.BackColor = Color.Gray;
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Font = new Font("Yu Gothic Light", 10F);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(137, 63);
            label3.Name = "label3";
            label3.Size = new Size(435, 50);
            label3.TabIndex = 3;
            label3.Text = "Descripcion";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.BackColor = Color.Gray;
            label4.BorderStyle = BorderStyle.Fixed3D;
            label4.Font = new Font("Yu Gothic Light", 10F);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(578, 63);
            label4.Name = "label4";
            label4.Size = new Size(90, 50);
            label4.TabIndex = 3;
            label4.Text = "Precio";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            label4.Click += label1_Click;
            // 
            // label5
            // 
            label5.BackColor = Color.Gray;
            label5.BorderStyle = BorderStyle.Fixed3D;
            label5.Font = new Font("Yu Gothic Light", 9F);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(675, 63);
            label5.Name = "label5";
            label5.Size = new Size(90, 50);
            label5.TabIndex = 3;
            label5.Text = "Existencias";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            label5.Click += label1_Click;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Firebrick;
            panel6.Controls.Add(button1);
            panel6.Location = new Point(-5, -7);
            panel6.Name = "panel6";
            panel6.Size = new Size(1230, 64);
            panel6.TabIndex = 4;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.System;
            button1.Font = new Font("Yu Gothic Light", 12F);
            button1.Location = new Point(1105, 19);
            button1.Name = "button1";
            button1.Size = new Size(108, 29);
            button1.TabIndex = 8;
            button1.Text = "Logout";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label6
            // 
            label6.BackColor = Color.White;
            label6.BorderStyle = BorderStyle.Fixed3D;
            label6.Font = new Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ImageAlign = ContentAlignment.BottomCenter;
            label6.Location = new Point(771, 63);
            label6.Name = "label6";
            label6.Size = new Size(437, 50);
            label6.TabIndex = 5;
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1220, 1055);
            Controls.Add(label6);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(panel6);
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pantalla de compras";
            Load += Form3_Load_1;
            panel1.ResumeLayout(false);
            panel6.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Label label6;
        private Button button1;
    }
}