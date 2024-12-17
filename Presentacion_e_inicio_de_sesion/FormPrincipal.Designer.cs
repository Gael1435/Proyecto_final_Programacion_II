namespace Presentacion_e_inicio_de_sesion
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            panel6 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            btnMinimizar = new PictureBox();
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
            lblRestricciones = new Label();
            lblHora = new Label();
            lblFecha = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).BeginInit();
            SuspendLayout();
            // 
            // panel6
            // 
            panel6.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel6.BackColor = Color.FromArgb(248, 187, 208);
            panel6.Controls.Add(pictureBox1);
            panel6.Controls.Add(label1);
            panel6.Controls.Add(btnMinimizar);
            panel6.Controls.Add(button1);
            panel6.Controls.Add(label6);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(0, 0);
            panel6.Margin = new Padding(4, 3, 4, 3);
            panel6.Name = "panel6";
            panel6.Size = new Size(1850, 67);
            panel6.TabIndex = 4;
            panel6.MouseDown += panel6_MouseDown;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Logo;
            pictureBox1.Location = new Point(690, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(87, 76);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Square721 BT", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(792, 17);
            label1.Name = "label1";
            label1.Size = new Size(161, 36);
            label1.TabIndex = 16;
            label1.Text = "Productos";
            // 
            // btnMinimizar
            // 
            btnMinimizar.BackColor = Color.White;
            btnMinimizar.Cursor = Cursors.Hand;
            btnMinimizar.Image = (Image)resources.GetObject("btnMinimizar.Image");
            btnMinimizar.Location = new Point(1561, 16);
            btnMinimizar.Margin = new Padding(4);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(31, 34);
            btnMinimizar.SizeMode = PictureBoxSizeMode.StretchImage;
            btnMinimizar.TabIndex = 15;
            btnMinimizar.TabStop = false;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Yu Gothic Light", 12F);
            button1.Location = new Point(1662, 12);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(162, 41);
            button1.TabIndex = 12;
            button1.Text = "Logout";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label6
            // 
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Yu Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ImageAlign = ContentAlignment.BottomCenter;
            label6.Location = new Point(1169, 4);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(456, 53);
            label6.TabIndex = 5;
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnComprar
            // 
            btnComprar.Cursor = Cursors.Hand;
            btnComprar.FlatStyle = FlatStyle.Flat;
            btnComprar.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnComprar.Location = new Point(1639, 651);
            btnComprar.Margin = new Padding(4);
            btnComprar.Name = "btnComprar";
            btnComprar.Size = new Size(168, 83);
            btnComprar.TabIndex = 12;
            btnComprar.Text = "Comprar";
            btnComprar.UseVisualStyleBackColor = true;
            btnComprar.Click += btnComprar_Click;
            // 
            // listView1
            // 
            listView1.BackColor = Color.WhiteSmoke;
            listView1.Columns.AddRange(new ColumnHeader[] { Productos_listas, Cantidad_lista, Costo_lista, Total_lista });
            listView1.ForeColor = Color.Black;
            listView1.Location = new Point(1185, 94);
            listView1.Margin = new Padding(4);
            listView1.Name = "listView1";
            listView1.Size = new Size(626, 511);
            listView1.TabIndex = 11;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // Productos_listas
            // 
            Productos_listas.Text = "Producto";
            Productos_listas.Width = 240;
            // 
            // Cantidad_lista
            // 
            Cantidad_lista.Text = "Cantidad";
            Cantidad_lista.Width = 120;
            // 
            // Costo_lista
            // 
            Costo_lista.Text = "Costo por unidad";
            Costo_lista.Width = 160;
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
            lbl_total.Location = new Point(1193, 684);
            lbl_total.Margin = new Padding(4, 0, 4, 0);
            lbl_total.Name = "lbl_total";
            lbl_total.Size = new Size(42, 21);
            lbl_total.TabIndex = 0;
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
            imageList1.Images.SetKeyName(13, "Logo.png");
            // 
            // button2
            // 
            button2.Cursor = Cursors.Hand;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(1421, 651);
            button2.Margin = new Padding(4);
            button2.Name = "button2";
            button2.Size = new Size(168, 83);
            button2.TabIndex = 12;
            button2.Text = "Borrar seleccion";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // lblRestricciones
            // 
            lblRestricciones.AutoSize = true;
            lblRestricciones.ForeColor = Color.Red;
            lblRestricciones.Location = new Point(1779, 921);
            lblRestricciones.Margin = new Padding(4, 0, 4, 0);
            lblRestricciones.Name = "lblRestricciones";
            lblRestricciones.Size = new Size(0, 21);
            lblRestricciones.TabIndex = 14;
            // 
            // lblHora
            // 
            lblHora.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblHora.AutoSize = true;
            lblHora.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHora.Location = new Point(1734, 782);
            lblHora.Margin = new Padding(4, 0, 4, 0);
            lblHora.Name = "lblHora";
            lblHora.Size = new Size(56, 17);
            lblHora.TabIndex = 16;
            lblHora.Text = "00:00:00";
            // 
            // lblFecha
            // 
            lblFecha.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Segoe UI", 9.75F, FontStyle.Underline);
            lblFecha.Location = new Point(1505, 782);
            lblFecha.Margin = new Padding(4, 0, 4, 0);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(209, 17);
            lblFecha.TabIndex = 15;
            lblFecha.Text = "Sabado, 14 de diciembre del 2024";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1850, 820);
            Controls.Add(listView1);
            Controls.Add(lblHora);
            Controls.Add(lblFecha);
            Controls.Add(lblRestricciones);
            Controls.Add(button2);
            Controls.Add(lbl_total);
            Controls.Add(btnComprar);
            Controls.Add(panel6);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            MinimumSize = new Size(1850, 820);
            Name = "FormPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pantalla de compras";
            Load += FormPrincipal_Load;
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).EndInit();
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
        private Label lblRestricciones;
        private PictureBox btnMinimizar;
        private Label lblHora;
        private Label lblFecha;
        private System.Windows.Forms.Timer timer1;
        private Label label1;
        private PictureBox pictureBox1;
    }
}