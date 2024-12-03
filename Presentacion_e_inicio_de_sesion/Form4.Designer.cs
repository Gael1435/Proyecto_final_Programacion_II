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
            ((System.ComponentModel.ISupportInitialize)imagen).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Yu Mincho Demibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(29, 24);
            label1.Name = "label1";
            label1.Size = new Size(240, 45);
            label1.TabIndex = 0;
            label1.Text = "Administrador";
            // 
            // txtId
            // 
            txtId.Font = new Font("Book Antiqua", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtId.Location = new Point(89, 183);
            txtId.Name = "txtId";
            txtId.PlaceholderText = "00";
            txtId.Size = new Size(134, 35);
            txtId.TabIndex = 1;
            txtId.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Book Antiqua", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(70, 127);
            label2.Name = "label2";
            label2.Size = new Size(42, 32);
            label2.TabIndex = 2;
            label2.Text = "Id";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Book Antiqua", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(70, 242);
            label3.Name = "label3";
            label3.Size = new Size(111, 32);
            label3.TabIndex = 3;
            label3.Text = "Imagen";
            // 
            // txtImg
            // 
            txtImg.Font = new Font("Book Antiqua", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtImg.Location = new Point(47, 303);
            txtImg.Name = "txtImg";
            txtImg.PlaceholderText = "Imagen.png";
            txtImg.Size = new Size(222, 35);
            txtImg.TabIndex = 4;
            txtImg.TextAlign = HorizontalAlignment.Center;
            txtImg.TextChanged += txtImg_TextChanged;
            txtImg.Leave += txtImg_Leave;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Book Antiqua", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(70, 357);
            label4.Name = "label4";
            label4.Size = new Size(166, 32);
            label4.TabIndex = 5;
            label4.Text = "Descripcion";
            // 
            // txtDesc
            // 
            txtDesc.Font = new Font("Book Antiqua", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtDesc.Location = new Point(29, 412);
            txtDesc.Name = "txtDesc";
            txtDesc.PlaceholderText = "Postre";
            txtDesc.Size = new Size(264, 35);
            txtDesc.TabIndex = 6;
            txtDesc.TextAlign = HorizontalAlignment.Center;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Book Antiqua", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(70, 469);
            label5.Name = "label5";
            label5.Size = new Size(93, 32);
            label5.TabIndex = 7;
            label5.Text = "Precio";
            // 
            // txtPrecio
            // 
            txtPrecio.Font = new Font("Book Antiqua", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPrecio.Location = new Point(89, 530);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.PlaceholderText = "$$";
            txtPrecio.Size = new Size(134, 35);
            txtPrecio.TabIndex = 8;
            txtPrecio.TextAlign = HorizontalAlignment.Center;
            // 
            // txtExist
            // 
            txtExist.Font = new Font("Book Antiqua", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtExist.Location = new Point(89, 647);
            txtExist.Name = "txtExist";
            txtExist.PlaceholderText = "00";
            txtExist.Size = new Size(134, 35);
            txtExist.TabIndex = 9;
            txtExist.TextAlign = HorizontalAlignment.Center;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Book Antiqua", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(70, 590);
            label6.Name = "label6";
            label6.Size = new Size(153, 32);
            label6.TabIndex = 10;
            label6.Text = "Existencias";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Variable Text Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(868, 266);
            label7.Name = "label7";
            label7.Size = new Size(156, 40);
            label7.TabIndex = 11;
            label7.Text = "Productos";
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Segoe UI Historic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAgregar.Location = new Point(370, 648);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(275, 46);
            btnAgregar.TabIndex = 12;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Font = new Font("Segoe UI Historic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBuscar.Location = new Point(525, 588);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(120, 38);
            btnBuscar.TabIndex = 13;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtIdBuscar
            // 
            txtIdBuscar.Font = new Font("Book Antiqua", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtIdBuscar.Location = new Point(431, 588);
            txtIdBuscar.Name = "txtIdBuscar";
            txtIdBuscar.PlaceholderText = "00";
            txtIdBuscar.Size = new Size(73, 35);
            txtIdBuscar.TabIndex = 14;
            txtIdBuscar.TextAlign = HorizontalAlignment.Center;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Book Antiqua", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(370, 588);
            label8.Name = "label8";
            label8.Size = new Size(45, 35);
            label8.TabIndex = 15;
            label8.Text = "Id";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Variable Text Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(769, 654);
            label9.Name = "label9";
            label9.Size = new Size(219, 40);
            label9.TabIndex = 16;
            label9.Text = "Ventas Totales:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Book Antiqua", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(450, 168);
            label10.Name = "label10";
            label10.Size = new Size(120, 32);
            label10.TabIndex = 17;
            label10.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Book Antiqua", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNombre.Location = new Point(370, 220);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Nombre";
            txtNombre.Size = new Size(275, 35);
            txtNombre.TabIndex = 18;
            txtNombre.TextAlign = HorizontalAlignment.Center;
            txtNombre.TextChanged += txtNombre_TextChanged;
            // 
            // ventas
            // 
            ventas.AutoSize = true;
            ventas.Font = new Font("Book Antiqua", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ventas.Location = new Point(1065, 662);
            ventas.Name = "ventas";
            ventas.Size = new Size(42, 32);
            ventas.TabIndex = 21;
            ventas.Text = "$0";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Variable Text Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(723, 24);
            label11.Name = "label11";
            label11.Size = new Size(113, 40);
            label11.TabIndex = 22;
            label11.Text = "Grafica";
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Segoe UI Historic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalir.Location = new Point(1146, 12);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(120, 38);
            btnSalir.TabIndex = 23;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // listProductos
            // 
            listProductos.BackColor = SystemColors.InactiveCaption;
            listProductos.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            listProductos.Location = new Point(696, 326);
            listProductos.Name = "listProductos";
            listProductos.Size = new Size(510, 325);
            listProductos.TabIndex = 24;
            listProductos.UseCompatibleStateImageBehavior = false;
            // 
            // imagen
            // 
            imagen.Image = Properties.Resources.Logo;
            imagen.Location = new Point(379, 303);
            imagen.Name = "imagen";
            imagen.Size = new Size(256, 256);
            imagen.TabIndex = 19;
            imagen.TabStop = false;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "LogoSmall.jpg");
            imageList1.Images.SetKeyName(1, "arrozConLeche.png");
            imageList1.Images.SetKeyName(2, "brownies.png");
            imageList1.Images.SetKeyName(3, "capirotada.png");
            imageList1.Images.SetKeyName(4, "chocoFlan.png");
            imageList1.Images.SetKeyName(5, "gelatinaMosaicos.png");
            imageList1.Images.SetKeyName(6, "macarrones.png");
            imageList1.Images.SetKeyName(7, "nieve.png");
            imageList1.Images.SetKeyName(8, "panPlatano.png");
            imageList1.Images.SetKeyName(9, "pastel.png");
            imageList1.Images.SetKeyName(10, "payLimon.png");
            // 
            // logout
            // 
            logout.Font = new Font("Segoe UI Historic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            logout.Location = new Point(1003, 12);
            logout.Name = "logout";
            logout.Size = new Size(120, 38);
            logout.TabIndex = 25;
            logout.Text = "Logout";
            logout.UseVisualStyleBackColor = true;
            logout.Click += logout_Click;
            // 
            // Administrador
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(1278, 724);
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
    }
}