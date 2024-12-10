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
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // panel6
            // 
            panel6.BackColor = Color.Firebrick;
            panel6.Controls.Add(button1);
            panel6.Location = new Point(-5, -7);
            panel6.Name = "panel6";
            panel6.Size = new Size(1928, 64);
            panel6.TabIndex = 4;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.System;
            button1.Font = new Font("Yu Gothic Light", 12F);
            button1.Location = new Point(1761, 19);
            button1.Name = "button1";
            button1.Size = new Size(144, 29);
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
            label6.Location = new Point(1223, 75);
            label6.Name = "label6";
            label6.Size = new Size(360, 51);
            label6.TabIndex = 5;
            label6.TextAlign = ContentAlignment.MiddleLeft;
            label6.Click += label6_Click;
            // 
            // btnComprar
            // 
            btnComprar.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnComprar.Location = new Point(1773, 697);
            btnComprar.Margin = new Padding(3, 4, 3, 4);
            btnComprar.Name = "btnComprar";
            btnComprar.Size = new Size(150, 79);
            btnComprar.TabIndex = 10;
            btnComprar.Text = "Comprar";
            btnComprar.UseVisualStyleBackColor = true;
            btnComprar.Click += btnComprar_Click;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { Productos_listas, Cantidad_lista, Costo_lista, Total_lista });
            listView1.Location = new Point(1395, 164);
            listView1.Margin = new Padding(3, 4, 3, 4);
            listView1.Name = "listView1";
            listView1.Size = new Size(557, 487);
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
            lbl_total.Location = new Point(1431, 729);
            lbl_total.Name = "lbl_total";
            lbl_total.Size = new Size(54, 28);
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
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1924, 828);
            Controls.Add(lbl_total);
            Controls.Add(listView1);
            Controls.Add(btnComprar);
            Controls.Add(label6);
            Controls.Add(panel6);
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
    }
}