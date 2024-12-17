namespace Presentacion_e_inicio_de_sesion
{
    partial class Administrador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Administrador));
            label1 = new Label();
            txtId = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtImg = new TextBox();
            label4 = new Label();
            txtDesc = new TextBox();
            label5 = new Label();
            txtPrecio = new TextBox();
            txtExist = new TextBox();
            label6 = new Label();
            label7 = new Label();
            btnAgregar = new Button();
            btnBuscar = new Button();
            txtIdBuscar = new TextBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            txtNombre = new TextBox();
            ventas = new Label();
            label11 = new Label();
            btnSalir = new Button();
            listProductos = new ListView();
            imagen = new PictureBox();
            imageList1 = new ImageList(components);
            logout = new Button();
            Tartana = new Label();
            lblHora = new Label();
            lblFecha = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)imagen).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(32, 25);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(196, 33);
            label1.TabIndex = 0;
            label1.Text = "Administrador";
            label1.Click += label1_Click;
            // 
            // txtId
            // 
            txtId.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtId.Location = new Point(100, 192);
            txtId.Margin = new Padding(4, 3, 4, 3);
            txtId.Name = "txtId";
            txtId.PlaceholderText = "00";
            txtId.Size = new Size(151, 28);
            txtId.TabIndex = 1;
            txtId.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(78, 133);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(32, 26);
            label2.TabIndex = 2;
            label2.Text = "Id";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(78, 255);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(91, 26);
            label3.TabIndex = 3;
            label3.Text = "Imagen";
            // 
            // txtImg
            // 
            txtImg.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtImg.Location = new Point(53, 318);
            txtImg.Margin = new Padding(4, 3, 4, 3);
            txtImg.Name = "txtImg";
            txtImg.PlaceholderText = "Imagen.png";
            txtImg.Size = new Size(250, 28);
            txtImg.TabIndex = 4;
            txtImg.TextAlign = HorizontalAlignment.Center;
            txtImg.TextChanged += txtImg_TextChanged;
            txtImg.Leave += txtImg_Leave;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(78, 375);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(137, 26);
            label4.TabIndex = 5;
            label4.Text = "Descripcion";
            // 
            // txtDesc
            // 
            txtDesc.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtDesc.Location = new Point(32, 433);
            txtDesc.Margin = new Padding(4, 3, 4, 3);
            txtDesc.Name = "txtDesc";
            txtDesc.PlaceholderText = "Postre";
            txtDesc.Size = new Size(297, 28);
            txtDesc.TabIndex = 6;
            txtDesc.TextAlign = HorizontalAlignment.Center;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(78, 493);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(80, 26);
            label5.TabIndex = 7;
            label5.Text = "Precio";
            // 
            // txtPrecio
            // 
            txtPrecio.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPrecio.Location = new Point(100, 557);
            txtPrecio.Margin = new Padding(4, 3, 4, 3);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.PlaceholderText = "$$";
            txtPrecio.Size = new Size(151, 28);
            txtPrecio.TabIndex = 8;
            txtPrecio.TextAlign = HorizontalAlignment.Center;
            // 
            // txtExist
            // 
            txtExist.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtExist.Location = new Point(100, 679);
            txtExist.Margin = new Padding(4, 3, 4, 3);
            txtExist.Name = "txtExist";
            txtExist.PlaceholderText = "00";
            txtExist.Size = new Size(151, 28);
            txtExist.TabIndex = 9;
            txtExist.TextAlign = HorizontalAlignment.Center;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(78, 619);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(134, 26);
            label6.TabIndex = 10;
            label6.Text = "Existencias";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Variable Text Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(977, 280);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(123, 32);
            label7.TabIndex = 11;
            label7.Text = "Productos";
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Segoe UI Historic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAgregar.Location = new Point(417, 680);
            btnAgregar.Margin = new Padding(4, 3, 4, 3);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(310, 48);
            btnAgregar.TabIndex = 12;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Font = new Font("Segoe UI Historic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBuscar.Location = new Point(590, 617);
            btnBuscar.Margin = new Padding(4, 3, 4, 3);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(135, 39);
            btnBuscar.TabIndex = 13;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtIdBuscar
            // 
            txtIdBuscar.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtIdBuscar.Location = new Point(485, 617);
            txtIdBuscar.Margin = new Padding(4, 3, 4, 3);
            txtIdBuscar.Name = "txtIdBuscar";
            txtIdBuscar.PlaceholderText = "00";
            txtIdBuscar.Size = new Size(81, 28);
            txtIdBuscar.TabIndex = 14;
            txtIdBuscar.TextAlign = HorizontalAlignment.Center;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(417, 617);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(35, 29);
            label8.TabIndex = 15;
            label8.Text = "Id";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Variable Text Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(910, 707);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(175, 32);
            label9.TabIndex = 16;
            label9.Text = "Ventas Totales:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(507, 176);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(96, 26);
            label10.TabIndex = 17;
            label10.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNombre.Location = new Point(417, 231);
            txtNombre.Margin = new Padding(4, 3, 4, 3);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Nombre";
            txtNombre.Size = new Size(309, 28);
            txtNombre.TabIndex = 18;
            txtNombre.TextAlign = HorizontalAlignment.Center;
            txtNombre.TextChanged += txtNombre_TextChanged;
            // 
            // ventas
            // 
            ventas.AutoSize = true;
            ventas.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ventas.Location = new Point(1243, 715);
            ventas.Margin = new Padding(4, 0, 4, 0);
            ventas.Name = "ventas";
            ventas.Size = new Size(38, 26);
            ventas.TabIndex = 21;
            ventas.Text = "$0";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Variable Text Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(814, 25);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(91, 32);
            label11.TabIndex = 22;
            label11.Text = "Grafica";
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Segoe UI Historic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalir.Location = new Point(1290, 13);
            btnSalir.Margin = new Padding(4, 3, 4, 3);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(139, 57);
            btnSalir.TabIndex = 23;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // listProductos
            // 
            listProductos.BackColor = SystemColors.InactiveCaption;
            listProductos.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            listProductos.Location = new Point(840, 349);
            listProductos.Margin = new Padding(4, 3, 4, 3);
            listProductos.Name = "listProductos";
            listProductos.Size = new Size(574, 341);
            listProductos.TabIndex = 24;
            listProductos.UseCompatibleStateImageBehavior = false;
            listProductos.SelectedIndexChanged += listProductos_SelectedIndexChanged;
            // 
            // imagen
            // 
            imagen.Image = Properties.Resources.Logo;
            imagen.Location = new Point(427, 318);
            imagen.Margin = new Padding(4, 3, 4, 3);
            imagen.Name = "imagen";
            imagen.Size = new Size(300, 279);
            imagen.TabIndex = 19;
            imagen.TabStop = false;
            imagen.Click += imagen_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "Logo.png");
            imageList1.Images.SetKeyName(1, "arrozConLeche.png");
            imageList1.Images.SetKeyName(2, "brownies.png");
            imageList1.Images.SetKeyName(3, "capirotada.png");
            imageList1.Images.SetKeyName(4, "Cheesecake.png");
            imageList1.Images.SetKeyName(5, "chocoFlan.png");
            imageList1.Images.SetKeyName(6, "Croissant.png");
            imageList1.Images.SetKeyName(7, "Cupcake.png");
            imageList1.Images.SetKeyName(8, "Dona.png");
            imageList1.Images.SetKeyName(9, "Empanada.png");
            imageList1.Images.SetKeyName(10, "Galletas.png");
            imageList1.Images.SetKeyName(11, "gelatinaMosaicos.png");
            imageList1.Images.SetKeyName(12, "macarrones.png");
            imageList1.Images.SetKeyName(13, "nieve.png");
            imageList1.Images.SetKeyName(14, "panPlatano.png");
            imageList1.Images.SetKeyName(15, "pastel.png");
            imageList1.Images.SetKeyName(16, "payLimon.png");
            imageList1.Images.SetKeyName(17, "Tiramisu.png");
            // 
            // logout
            // 
            logout.Font = new Font("Segoe UI Historic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            logout.Location = new Point(1129, 13);
            logout.Margin = new Padding(4, 3, 4, 3);
            logout.Name = "logout";
            logout.Size = new Size(153, 57);
            logout.TabIndex = 25;
            logout.Text = "Logout";
            logout.UseVisualStyleBackColor = true;
            logout.Click += logout_Click;
            // 
            // Tartana
            // 
            Tartana.AutoSize = true;
            Tartana.BackColor = Color.FromArgb(255, 224, 192);
            Tartana.BorderStyle = BorderStyle.Fixed3D;
            Tartana.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Tartana.ForeColor = Color.FromArgb(128, 128, 255);
            Tartana.Location = new Point(453, 25);
            Tartana.Margin = new Padding(4, 0, 4, 0);
            Tartana.Name = "Tartana";
            Tartana.Size = new Size(199, 57);
            Tartana.TabIndex = 26;
            Tartana.Text = "Tartana";
            // 
            // lblHora
            // 
            lblHora.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblHora.AutoSize = true;
            lblHora.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHora.Location = new Point(1392, 791);
            lblHora.Margin = new Padding(4, 0, 4, 0);
            lblHora.Name = "lblHora";
            lblHora.Size = new Size(56, 17);
            lblHora.TabIndex = 28;
            lblHora.Text = "00:00:00";
            // 
            // lblFecha
            // 
            lblFecha.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Segoe UI", 9.75F, FontStyle.Underline);
            lblFecha.Location = new Point(1306, 812);
            lblFecha.Margin = new Padding(4, 0, 4, 0);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(209, 17);
            lblFecha.TabIndex = 27;
            lblFecha.Text = "Sabado, 14 de diciembre del 2024";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick_1;
            // 
            // Administrador
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1590, 848);
            Controls.Add(lblHora);
            Controls.Add(lblFecha);
            Controls.Add(Tartana);
            Controls.Add(logout);
            Controls.Add(listProductos);
            Controls.Add(btnSalir);
            Controls.Add(label11);
            Controls.Add(ventas);
            Controls.Add(imagen);
            Controls.Add(txtNombre);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(txtIdBuscar);
            Controls.Add(btnBuscar);
            Controls.Add(btnAgregar);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(txtExist);
            Controls.Add(txtPrecio);
            Controls.Add(label5);
            Controls.Add(txtDesc);
            Controls.Add(label4);
            Controls.Add(txtImg);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtId);
            Controls.Add(label1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Administrador";
            Text = "Panel de Administracion";
            Load += Form4_Load;
            ((System.ComponentModel.ISupportInitialize)imagen).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtId;
        private Label label2;
        private Label label3;
        private TextBox txtImg;
        private Label label4;
        private TextBox txtDesc;
        private Label label5;
        private TextBox txtPrecio;
        private TextBox txtExist;
        private Label label6;
        private Label label7;
        private Button btnAgregar;
        private Button btnBuscar;
        private TextBox txtIdBuscar;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox txtNombre;
        private Label ventas;
        private Label label11;
        private Button btnSalir;
        private ListView listProductos;
        private PictureBox imagen;
        private ImageList imageList1;
        private Button logout;
        private Label Tartana;
        private Label lblHora;
        private Label lblFecha;
        private System.Windows.Forms.Timer timer1;
    }
}