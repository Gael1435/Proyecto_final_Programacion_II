﻿namespace Presentacion_e_inicio_de_sesion
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            panel6 = new Panel();
            button1 = new Button();
            label6 = new Label();
            btnComprar = new Button();
            listView1 = new ListView();
            Productos_listas = new ColumnHeader();
            Cantidad_lista = new ColumnHeader();
            Costo_lista = new ColumnHeader();
            Total_lista = new ColumnHeader();
            lbl_total = new Label();
            imageList1 = new ImageList(components);
            button2 = new Button();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // panel6
            // 
            panel6.BackColor = Color.Firebrick;
            panel6.Controls.Add(button1);
            panel6.Location = new Point(-4, -5);
            panel6.Margin = new Padding(3, 2, 3, 2);
            panel6.Name = "panel6";
            panel6.Size = new Size(1687, 48);
            panel6.TabIndex = 4;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.System;
            button1.Font = new Font("Yu Gothic Light", 12F);
            button1.Location = new Point(1541, 14);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(126, 22);
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
            label6.Location = new Point(1070, 56);
            label6.Name = "label6";
            label6.Size = new Size(315, 38);
            label6.TabIndex = 5;
            label6.TextAlign = ContentAlignment.MiddleLeft;
            label6.Click += label6_Click;
            // 
            // btnComprar
            // 
            btnComprar.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnComprar.Location = new Point(1551, 523);
            btnComprar.Name = "btnComprar";
            btnComprar.Size = new Size(131, 59);
            btnComprar.TabIndex = 10;
            btnComprar.Text = "Comprar";
            btnComprar.UseVisualStyleBackColor = true;
            btnComprar.Click += btnComprar_Click;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { Productos_listas, Cantidad_lista, Costo_lista, Total_lista });
            listView1.Location = new Point(1221, 123);
            listView1.Name = "listView1";
            listView1.Size = new Size(488, 366);
            listView1.TabIndex = 11;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // Productos_listas
            // 
            Productos_listas.Text = "Producto";
            Productos_listas.Width = 120;
            // 
            // Cantidad_lista
            // 
            Cantidad_lista.Text = "Cantidad";
            Cantidad_lista.Width = 120;
            // 
            // Costo_lista
            // 
            Costo_lista.Text = "Costo por unidad";
            Costo_lista.Width = 120;
            // 
            // Total_lista
            // 
            Total_lista.Text = "Total";
            Total_lista.Width = 120;
            // 
            // lbl_total
            // 
            lbl_total.AutoSize = true;
            lbl_total.BackColor = Color.RosyBrown;
            lbl_total.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_total.Location = new Point(1252, 547);
            lbl_total.Name = "lbl_total";
            lbl_total.Size = new Size(42, 21);
            lbl_total.TabIndex = 12;
            lbl_total.Text = "Total";
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "defaultImage.png");
            imageList1.Images.SetKeyName(1, "brownies.png");
            imageList1.Images.SetKeyName(2, "Cheesecake.png");
            imageList1.Images.SetKeyName(3, "Croissant.png");
            imageList1.Images.SetKeyName(4, "Cupcake.png");
            imageList1.Images.SetKeyName(5, "Dona.png");
            imageList1.Images.SetKeyName(6, "Empanada.png");
            imageList1.Images.SetKeyName(7, "Galletas.png");
            imageList1.Images.SetKeyName(8, "macarrones.png");
            imageList1.Images.SetKeyName(9, "panPlatano.png");
            imageList1.Images.SetKeyName(10, "pastel.png");
            imageList1.Images.SetKeyName(11, "payLimon.png");
            imageList1.Images.SetKeyName(12, "Tiramisu.png");
            // 
            // button2
            // 
            button2.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(1414, 523);
            button2.Name = "button2";
            button2.Size = new Size(131, 59);
            button2.TabIndex = 13;
            button2.Text = "Borrar seleccion";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1684, 621);
            Controls.Add(button2);
            Controls.Add(lbl_total);
            Controls.Add(listView1);
            Controls.Add(btnComprar);
            Controls.Add(label6);
            Controls.Add(panel6);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form3";
            Opacity = 0.98D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pantalla de compras";
            Load += Form3_Load_1;
            panel6.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel6;
        private Label label6;
        private Button button1;
        private Button btnComprar;
        private ListView listView1;
        private ColumnHeader Productos_listas;
        private ColumnHeader Cantidad_lista;
        private ColumnHeader Costo_lista;
        private ColumnHeader Total_lista;
        private Label lbl_total;
        private ImageList imageList1;
        private Button button2;
    }
}