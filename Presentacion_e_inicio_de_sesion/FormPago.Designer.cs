namespace Presentacion_e_inicio_de_sesion
{
    partial class FormPago
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
            rdCredito = new RadioButton();
            rdDebito = new RadioButton();
            groupBox1 = new GroupBox();
            rdEfectivo = new RadioButton();
            lbTotal = new Label();
            btnPago = new Button();
            gbcredito_debito = new GroupBox();
            bttarjeta = new Button();
            txtExpiracion = new TextBox();
            txtCVC = new TextBox();
            txtNombre = new TextBox();
            gbEfectivo = new GroupBox();
            btefectivo = new Button();
            txtPago = new TextBox();
            txtnumTarjeta = new TextBox();
            label1 = new Label();
            lblProducto = new Label();
            lblTotal = new Label();
            lblPrecioUnitario = new Label();
            lblCantidad = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnMostrarTicket = new Button();
            btnRegresar = new Button();
            panel1 = new Panel();
            lblHora = new Label();
            lblFecha = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            groupBox1.SuspendLayout();
            gbcredito_debito.SuspendLayout();
            gbEfectivo.SuspendLayout();
            SuspendLayout();
            // 
            // rdCredito
            // 
            rdCredito.AutoSize = true;
            rdCredito.Checked = true;
            rdCredito.Location = new Point(22, 22);
            rdCredito.Name = "rdCredito";
            rdCredito.Size = new Size(143, 22);
            rdCredito.TabIndex = 0;
            rdCredito.TabStop = true;
            rdCredito.Text = "Tarjeta de Credito";
            rdCredito.UseVisualStyleBackColor = true;
            // 
            // rdDebito
            // 
            rdDebito.AutoSize = true;
            rdDebito.Checked = true;
            rdDebito.Location = new Point(21, 50);
            rdDebito.Name = "rdDebito";
            rdDebito.Size = new Size(138, 22);
            rdDebito.TabIndex = 1;
            rdDebito.TabStop = true;
            rdDebito.Text = "Tarjeta de Debito";
            rdDebito.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdEfectivo);
            groupBox1.Controls.Add(rdCredito);
            groupBox1.Controls.Add(rdDebito);
            groupBox1.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(29, 59);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(218, 111);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Metodo de pago";
            // 
            // rdEfectivo
            // 
            rdEfectivo.AutoSize = true;
            rdEfectivo.Checked = true;
            rdEfectivo.Location = new Point(21, 78);
            rdEfectivo.Name = "rdEfectivo";
            rdEfectivo.Size = new Size(99, 22);
            rdEfectivo.TabIndex = 2;
            rdEfectivo.TabStop = true;
            rdEfectivo.Text = "En efectivo";
            rdEfectivo.UseVisualStyleBackColor = true;
            // 
            // lbTotal
            // 
            lbTotal.AutoSize = true;
            lbTotal.Location = new Point(98, 453);
            lbTotal.Name = "lbTotal";
            lbTotal.Size = new Size(32, 15);
            lbTotal.TabIndex = 3;
            lbTotal.Text = "Total";
            // 
            // btnPago
            // 
            btnPago.Cursor = Cursors.Hand;
            btnPago.FlatStyle = FlatStyle.Flat;
            btnPago.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPago.Location = new Point(29, 181);
            btnPago.Name = "btnPago";
            btnPago.Size = new Size(197, 55);
            btnPago.TabIndex = 3;
            btnPago.Text = "Confirmar metodo de pago";
            btnPago.UseVisualStyleBackColor = true;
            btnPago.Click += btnPago_Click;
            // 
            // gbcredito_debito
            // 
            gbcredito_debito.Controls.Add(bttarjeta);
            gbcredito_debito.Controls.Add(txtExpiracion);
            gbcredito_debito.Controls.Add(txtCVC);
            gbcredito_debito.Controls.Add(txtNombre);
            gbcredito_debito.Location = new Point(272, 27);
            gbcredito_debito.Name = "gbcredito_debito";
            gbcredito_debito.Size = new Size(334, 380);
            gbcredito_debito.TabIndex = 4;
            gbcredito_debito.TabStop = false;
            gbcredito_debito.Text = "Tarjeta de credito o debito";
            gbcredito_debito.Visible = false;
            // 
            // bttarjeta
            // 
            bttarjeta.FlatStyle = FlatStyle.Flat;
            bttarjeta.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bttarjeta.Location = new Point(72, 246);
            bttarjeta.Name = "bttarjeta";
            bttarjeta.Size = new Size(197, 55);
            bttarjeta.TabIndex = 6;
            bttarjeta.Text = "Confirmar pago";
            bttarjeta.UseVisualStyleBackColor = true;
            bttarjeta.Click += bttarjeta_Click;
            // 
            // txtExpiracion
            // 
            txtExpiracion.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtExpiracion.Location = new Point(201, 181);
            txtExpiracion.Margin = new Padding(3, 2, 3, 2);
            txtExpiracion.Name = "txtExpiracion";
            txtExpiracion.PlaceholderText = "Expíracion";
            txtExpiracion.Size = new Size(105, 28);
            txtExpiracion.TabIndex = 22;
            txtExpiracion.TextAlign = HorizontalAlignment.Center;
            // 
            // txtCVC
            // 
            txtCVC.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtCVC.Location = new Point(15, 181);
            txtCVC.Margin = new Padding(3, 2, 3, 2);
            txtCVC.Name = "txtCVC";
            txtCVC.PlaceholderText = "CVC";
            txtCVC.Size = new Size(105, 28);
            txtCVC.TabIndex = 21;
            txtCVC.TextAlign = HorizontalAlignment.Center;
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNombre.Location = new Point(54, 115);
            txtNombre.Margin = new Padding(3, 2, 3, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Nombre";
            txtNombre.Size = new Size(215, 28);
            txtNombre.TabIndex = 20;
            txtNombre.TextAlign = HorizontalAlignment.Center;
            // 
            // gbEfectivo
            // 
            gbEfectivo.Controls.Add(btefectivo);
            gbEfectivo.Controls.Add(txtPago);
            gbEfectivo.Controls.Add(txtnumTarjeta);
            gbEfectivo.Location = new Point(272, 27);
            gbEfectivo.Name = "gbEfectivo";
            gbEfectivo.Size = new Size(334, 380);
            gbEfectivo.TabIndex = 5;
            gbEfectivo.TabStop = false;
            gbEfectivo.Text = "Efectivo";
            gbEfectivo.Visible = false;
            // 
            // btefectivo
            // 
            btefectivo.Cursor = Cursors.Hand;
            btefectivo.FlatStyle = FlatStyle.Flat;
            btefectivo.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btefectivo.Location = new Point(72, 246);
            btefectivo.Name = "btefectivo";
            btefectivo.Size = new Size(197, 55);
            btefectivo.TabIndex = 23;
            btefectivo.Text = "Confirmar pago";
            btefectivo.UseVisualStyleBackColor = true;
            btefectivo.Click += btefectivo_Click;
            // 
            // txtPago
            // 
            txtPago.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPago.Location = new Point(48, 39);
            txtPago.Margin = new Padding(3, 2, 3, 2);
            txtPago.Name = "txtPago";
            txtPago.PlaceholderText = "Con cuanto va a pagar";
            txtPago.Size = new Size(215, 28);
            txtPago.TabIndex = 20;
            txtPago.TextAlign = HorizontalAlignment.Center;
            // 
            // txtnumTarjeta
            // 
            txtnumTarjeta.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtnumTarjeta.Location = new Point(48, 39);
            txtnumTarjeta.Margin = new Padding(3, 2, 3, 2);
            txtnumTarjeta.Name = "txtnumTarjeta";
            txtnumTarjeta.PlaceholderText = "Num de tarjeta";
            txtnumTarjeta.Size = new Size(215, 28);
            txtnumTarjeta.TabIndex = 19;
            txtnumTarjeta.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(98, 239);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 24;
            label1.Text = "Nombre";
            // 
            // lblProducto
            // 
            lblProducto.AutoSize = true;
            lblProducto.Location = new Point(4, 295);
            lblProducto.Name = "lblProducto";
            lblProducto.Size = new Size(0, 15);
            lblProducto.TabIndex = 25;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(200, 295);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(0, 15);
            lblTotal.TabIndex = 26;
            // 
            // lblPrecioUnitario
            // 
            lblPrecioUnitario.AutoSize = true;
            lblPrecioUnitario.Location = new Point(149, 295);
            lblPrecioUnitario.Name = "lblPrecioUnitario";
            lblPrecioUnitario.Size = new Size(0, 15);
            lblPrecioUnitario.TabIndex = 27;
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Location = new Point(88, 295);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(0, 15);
            lblCantidad.TabIndex = 28;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(88, 274);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 32;
            label2.Text = "Cantidad";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(149, 274);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 31;
            label3.Text = "Unidad";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(200, 274);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 30;
            label4.Text = "Total P/U";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(4, 274);
            label5.Name = "label5";
            label5.Size = new Size(56, 15);
            label5.TabIndex = 29;
            label5.Text = "Producto";
            // 
            // btnMostrarTicket
            // 
            btnMostrarTicket.Cursor = Cursors.Hand;
            btnMostrarTicket.FlatStyle = FlatStyle.Flat;
            btnMostrarTicket.Location = new Point(272, 417);
            btnMostrarTicket.Name = "btnMostrarTicket";
            btnMostrarTicket.Size = new Size(123, 35);
            btnMostrarTicket.TabIndex = 33;
            btnMostrarTicket.Text = "Mostrar Ticket";
            btnMostrarTicket.UseVisualStyleBackColor = true;
            btnMostrarTicket.Click += btnMostrarTicket_Click_1;
            // 
            // btnRegresar
            // 
            btnRegresar.Cursor = Cursors.Hand;
            btnRegresar.FlatStyle = FlatStyle.Flat;
            btnRegresar.Location = new Point(483, 417);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(123, 35);
            btnRegresar.TabIndex = 34;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = true;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(248, 187, 208);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(625, 25);
            panel1.TabIndex = 35;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // lblHora
            // 
            lblHora.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblHora.AutoSize = true;
            lblHora.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHora.Location = new Point(411, 455);
            lblHora.Name = "lblHora";
            lblHora.Size = new Size(56, 17);
            lblHora.TabIndex = 37;
            lblHora.Text = "00:00:00";
            // 
            // lblFecha
            // 
            lblFecha.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Segoe UI", 9.75F, FontStyle.Underline);
            lblFecha.Location = new Point(344, 470);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(209, 17);
            lblFecha.TabIndex = 36;
            lblFecha.Text = "Sabado, 14 de diciembre del 2024";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // FormPago
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(625, 496);
            Controls.Add(lblHora);
            Controls.Add(lblFecha);
            Controls.Add(panel1);
            Controls.Add(btnRegresar);
            Controls.Add(btnMostrarTicket);
            Controls.Add(gbEfectivo);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(lbTotal);
            Controls.Add(lblCantidad);
            Controls.Add(lblPrecioUnitario);
            Controls.Add(lblTotal);
            Controls.Add(lblProducto);
            Controls.Add(label1);
            Controls.Add(gbcredito_debito);
            Controls.Add(btnPago);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormPago";
            StartPosition = FormStartPosition.CenterScreen;
            Tag = "";
            Text = "Formato de compra";
            Load += Form5_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            gbcredito_debito.ResumeLayout(false);
            gbcredito_debito.PerformLayout();
            gbEfectivo.ResumeLayout(false);
            gbEfectivo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton rdCredito;
        private RadioButton rdDebito;
        private GroupBox groupBox1;
        private RadioButton rdEfectivo;
        private Label lbTotal;
        private Button btnPago;
        private GroupBox gbcredito_debito;
        private GroupBox gbEfectivo;
        private Button bttarjeta;
        private TextBox txtExpiracion;
        private TextBox txtCVC;
        private TextBox txtNombre;
        private TextBox txtnumTarjeta;
        private TextBox txtPago;
        private Button btefectivo;
        private Label label1;
        private Label lblProducto;
        private Label lblTotal;
        private Label lblPrecioUnitario;
        private Label lblCantidad;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnMostrarTicket;
        private Button btnRegresar;
        private Panel panel1;
        private Label lblHora;
        private Label lblFecha;
        private System.Windows.Forms.Timer timer1;
    }
}