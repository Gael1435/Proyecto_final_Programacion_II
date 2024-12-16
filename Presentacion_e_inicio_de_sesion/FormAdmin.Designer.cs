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
            ((System.ComponentModel.ISupportInitialize)imagen).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(25, 18);
            label1.Name = "label1";
            label1.Size = new Size(196, 33);
            label1.TabIndex = 0;
            label1.Text = "Administrador";
            label1.Click += label1_Click;
            // 
            // txtId
            // 
            txtId.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtId.Location = new Point(78, 137);
            txtId.Margin = new Padding(3, 2, 3, 2);
            txtId.Name = "txtId";
            txtId.PlaceholderText = "00";
            txtId.Size = new Size(118, 28);
            txtId.TabIndex = 1;
            txtId.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(61, 95);
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
            label3.Location = new Point(61, 182);
            label3.Name = "label3";
            label3.Size = new Size(91, 26);
            label3.TabIndex = 3;
            label3.Text = "Imagen";
            // 
            // txtImg
            // 
            txtImg.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtImg.Location = new Point(41, 227);
            txtImg.Margin = new Padding(3, 2, 3, 2);
            txtImg.Name = "txtImg";
            txtImg.PlaceholderText = "Imagen.png";
            txtImg.Size = new Size(195, 28);
            txtImg.TabIndex = 4;
            txtImg.TextAlign = HorizontalAlignment.Center;
            txtImg.TextChanged += txtImg_TextChanged;
            txtImg.Leave += txtImg_Leave;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(61, 268);
            label4.Name = "label4";
            label4.Size = new Size(137, 26);
            label4.TabIndex = 5;
            label4.Text = "Descripcion";
            // 
            // txtDesc
            // 
            txtDesc.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtDesc.Location = new Point(25, 309);
            txtDesc.Margin = new Padding(3, 2, 3, 2);
            txtDesc.Name = "txtDesc";
            txtDesc.PlaceholderText = "Postre";
            txtDesc.Size = new Size(232, 28);
            txtDesc.TabIndex = 6;
            txtDesc.TextAlign = HorizontalAlignment.Center;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(61, 352);
            label5.Name = "label5";
            label5.Size = new Size(80, 26);
            label5.TabIndex = 7;
            label5.Text = "Precio";
            // 
            // txtPrecio
            // 
            txtPrecio.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPrecio.Location = new Point(78, 398);
            txtPrecio.Margin = new Padding(3, 2, 3, 2);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.PlaceholderText = "$$";
            txtPrecio.Size = new Size(118, 28);
            txtPrecio.TabIndex = 8;
            txtPrecio.TextAlign = HorizontalAlignment.Center;
            // 
            // txtExist
            // 
            txtExist.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtExist.Location = new Point(78, 485);
            txtExist.Margin = new Padding(3, 2, 3, 2);
            txtExist.Name = "txtExist";
            txtExist.PlaceholderText = "00";
            txtExist.Size = new Size(118, 28);
            txtExist.TabIndex = 9;
            txtExist.TextAlign = HorizontalAlignment.Center;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(61, 442);
            label6.Name = "label6";
            label6.Size = new Size(134, 26);
            label6.TabIndex = 10;
            label6.Text = "Existencias";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Variable Text Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(760, 200);
            label7.Name = "label7";
            label7.Size = new Size(123, 32);
            label7.TabIndex = 11;
            label7.Text = "Productos";
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Segoe UI Historic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAgregar.Location = new Point(324, 486);
            btnAgregar.Margin = new Padding(3, 2, 3, 2);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(241, 34);
            btnAgregar.TabIndex = 12;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Font = new Font("Segoe UI Historic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBuscar.Location = new Point(459, 441);
            btnBuscar.Margin = new Padding(3, 2, 3, 2);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(105, 28);
            btnBuscar.TabIndex = 13;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtIdBuscar
            // 
            txtIdBuscar.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtIdBuscar.Location = new Point(377, 441);
            txtIdBuscar.Margin = new Padding(3, 2, 3, 2);
            txtIdBuscar.Name = "txtIdBuscar";
            txtIdBuscar.PlaceholderText = "00";
            txtIdBuscar.Size = new Size(64, 28);
            txtIdBuscar.TabIndex = 14;
            txtIdBuscar.TextAlign = HorizontalAlignment.Center;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(324, 441);
            label8.Name = "label8";
            label8.Size = new Size(35, 29);
            label8.TabIndex = 15;
            label8.Text = "Id";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Variable Text Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(708, 505);
            label9.Name = "label9";
            label9.Size = new Size(175, 32);
            label9.TabIndex = 16;
            label9.Text = "Ventas Totales:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(394, 126);
            label10.Name = "label10";
            label10.Size = new Size(96, 26);
            label10.TabIndex = 17;
            label10.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNombre.Location = new Point(324, 165);
            txtNombre.Margin = new Padding(3, 2, 3, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Nombre";
            txtNombre.Size = new Size(241, 28);
            txtNombre.TabIndex = 18;
            txtNombre.TextAlign = HorizontalAlignment.Center;
            txtNombre.TextChanged += txtNombre_TextChanged;
            // 
            // ventas
            // 
            ventas.AutoSize = true;
            ventas.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ventas.Location = new Point(967, 511);
            ventas.Name = "ventas";
            ventas.Size = new Size(38, 26);
            ventas.TabIndex = 21;
            ventas.Text = "$0";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Variable Text Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(633, 18);
            label11.Name = "label11";
            label11.Size = new Size(91, 32);
            label11.TabIndex = 22;
            label11.Text = "Grafica";
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Segoe UI Historic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalir.Location = new Point(1003, 9);
            btnSalir.Margin = new Padding(3, 2, 3, 2);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(108, 41);
            btnSalir.TabIndex = 23;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // listProductos
            // 
            listProductos.BackColor = SystemColors.InactiveCaption;
            listProductos.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            listProductos.Location = new Point(653, 249);
            listProductos.Margin = new Padding(3, 2, 3, 2);
            listProductos.Name = "listProductos";
            listProductos.Size = new Size(447, 245);
            listProductos.TabIndex = 24;
            listProductos.UseCompatibleStateImageBehavior = false;
            // 
            // imagen
            // 
            imagen.Image = Properties.Resources.Logo;
            imagen.Location = new Point(332, 227);
            imagen.Margin = new Padding(3, 2, 3, 2);
            imagen.Name = "imagen";
            imagen.Size = new Size(233, 199);
            imagen.TabIndex = 19;
            imagen.TabStop = false;
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
            logout.Location = new Point(878, 9);
            logout.Margin = new Padding(3, 2, 3, 2);
            logout.Name = "logout";
            logout.Size = new Size(119, 41);
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
            Tartana.Location = new Point(352, 18);
            Tartana.Name = "Tartana";
            Tartana.Size = new Size(199, 57);
            Tartana.TabIndex = 26;
            Tartana.Text = "Tartana";
            // 
            // Administrador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(1237, 606);
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
            Margin = new Padding(3, 2, 3, 2);
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
    }
}