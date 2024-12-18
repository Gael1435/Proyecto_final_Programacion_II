﻿namespace Presentacion_e_inicio_de_sesion
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
            txtnumTarjeta = new TextBox();
            txtCVC = new TextBox();
            txtNombre = new TextBox();
            gbEfectivo = new GroupBox();
            btefectivo = new Button();
            txtPago = new TextBox();
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
            rdCredito.Location = new Point(28, 31);
            rdCredito.Margin = new Padding(4, 4, 4, 4);
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
            rdDebito.Location = new Point(27, 70);
            rdDebito.Margin = new Padding(4, 4, 4, 4);
            rdDebito.Name = "rdDebito";
            rdDebito.Size = new Size(138, 22);
            rdDebito.TabIndex = 1;
            rdDebito.TabStop = true;
            rdDebito.Text = "Tarjeta de Debito";
            rdDebito.UseVisualStyleBackColor = true;
            rdDebito.CheckedChanged += rdDebito_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdEfectivo);
            groupBox1.Controls.Add(rdCredito);
            groupBox1.Controls.Add(rdDebito);
            groupBox1.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(37, 83);
            groupBox1.Margin = new Padding(4, 4, 4, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 4, 4, 4);
            groupBox1.Size = new Size(280, 155);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Metodo de pago";
            // 
            // rdEfectivo
            // 
            rdEfectivo.AutoSize = true;
            rdEfectivo.Checked = true;
            rdEfectivo.Location = new Point(27, 109);
            rdEfectivo.Margin = new Padding(4, 4, 4, 4);
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
            lbTotal.Location = new Point(126, 634);
            lbTotal.Margin = new Padding(4, 0, 4, 0);
            lbTotal.Name = "lbTotal";
            lbTotal.Size = new Size(42, 21);
            lbTotal.TabIndex = 3;
            lbTotal.Text = "Total";
            // 
            // btnPago
            // 
            btnPago.Cursor = Cursors.Hand;
            btnPago.FlatStyle = FlatStyle.Flat;
            btnPago.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPago.Location = new Point(37, 253);
            btnPago.Margin = new Padding(4, 4, 4, 4);
            btnPago.Name = "btnPago";
            btnPago.Size = new Size(253, 77);
            btnPago.TabIndex = 3;
            btnPago.Text = "Confirmar metodo de pago";
            btnPago.UseVisualStyleBackColor = true;
            btnPago.Click += btnPago_Click;
            // 
            // gbcredito_debito
            // 
            gbcredito_debito.Controls.Add(bttarjeta);
            gbcredito_debito.Controls.Add(txtExpiracion);
            gbcredito_debito.Controls.Add(txtnumTarjeta);
            gbcredito_debito.Controls.Add(txtCVC);
            gbcredito_debito.Controls.Add(txtNombre);
            gbcredito_debito.Location = new Point(350, 38);
            gbcredito_debito.Margin = new Padding(4, 4, 4, 4);
            gbcredito_debito.Name = "gbcredito_debito";
            gbcredito_debito.Padding = new Padding(4, 4, 4, 4);
            gbcredito_debito.Size = new Size(429, 532);
            gbcredito_debito.TabIndex = 4;
            gbcredito_debito.TabStop = false;
            gbcredito_debito.Text = "Tarjeta de credito o debito";
            gbcredito_debito.Visible = false;
            // 
            // bttarjeta
            // 
            bttarjeta.FlatStyle = FlatStyle.Flat;
            bttarjeta.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bttarjeta.Location = new Point(93, 344);
            bttarjeta.Margin = new Padding(4, 4, 4, 4);
            bttarjeta.Name = "bttarjeta";
            bttarjeta.Size = new Size(253, 77);
            bttarjeta.TabIndex = 6;
            bttarjeta.Text = "Confirmar pago";
            bttarjeta.UseVisualStyleBackColor = true;
            bttarjeta.Click += bttarjeta_Click;
            // 
            // txtExpiracion
            // 
            txtExpiracion.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtExpiracion.Location = new Point(258, 253);
            txtExpiracion.Margin = new Padding(4, 3, 4, 3);
            txtExpiracion.Name = "txtExpiracion";
            txtExpiracion.PlaceholderText = "Expíracion";
            txtExpiracion.Size = new Size(134, 28);
            txtExpiracion.TabIndex = 22;
            txtExpiracion.TextAlign = HorizontalAlignment.Center;
            // 
            // txtnumTarjeta
            // 
            txtnumTarjeta.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtnumTarjeta.Location = new Point(69, 109);
            txtnumTarjeta.Margin = new Padding(4, 3, 4, 3);
            txtnumTarjeta.Name = "txtnumTarjeta";
            txtnumTarjeta.PlaceholderText = "Num de tarjeta";
            txtnumTarjeta.Size = new Size(275, 28);
            txtnumTarjeta.TabIndex = 19;
            txtnumTarjeta.TextAlign = HorizontalAlignment.Center;
            // 
            // txtCVC
            // 
            txtCVC.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtCVC.Location = new Point(19, 253);
            txtCVC.Margin = new Padding(4, 3, 4, 3);
            txtCVC.Name = "txtCVC";
            txtCVC.PlaceholderText = "CVC";
            txtCVC.Size = new Size(134, 28);
            txtCVC.TabIndex = 21;
            txtCVC.TextAlign = HorizontalAlignment.Center;
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNombre.Location = new Point(69, 161);
            txtNombre.Margin = new Padding(4, 3, 4, 3);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Nombre";
            txtNombre.Size = new Size(275, 28);
            txtNombre.TabIndex = 20;
            txtNombre.TextAlign = HorizontalAlignment.Center;
            // 
            // gbEfectivo
            // 
            gbEfectivo.Controls.Add(btefectivo);
            gbEfectivo.Controls.Add(txtPago);
            gbEfectivo.Location = new Point(350, 43);
            gbEfectivo.Margin = new Padding(4, 4, 4, 4);
            gbEfectivo.Name = "gbEfectivo";
            gbEfectivo.Padding = new Padding(4, 4, 4, 4);
            gbEfectivo.Size = new Size(429, 532);
            gbEfectivo.TabIndex = 5;
            gbEfectivo.TabStop = false;
            gbEfectivo.Text = "Efectivo";
            gbEfectivo.Visible = false;
            gbEfectivo.Enter += gbEfectivo_Enter;
            // 
            // btefectivo
            // 
            btefectivo.Cursor = Cursors.Hand;
            btefectivo.FlatStyle = FlatStyle.Flat;
            btefectivo.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btefectivo.Location = new Point(93, 344);
            btefectivo.Margin = new Padding(4, 4, 4, 4);
            btefectivo.Name = "btefectivo";
            btefectivo.Size = new Size(253, 77);
            btefectivo.TabIndex = 23;
            btefectivo.Text = "Confirmar pago";
            btefectivo.UseVisualStyleBackColor = true;
            btefectivo.Click += btefectivo_Click;
            // 
            // txtPago
            // 
            txtPago.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPago.Location = new Point(62, 129);
            txtPago.Margin = new Padding(4, 3, 4, 3);
            txtPago.Name = "txtPago";
            txtPago.PlaceholderText = "Con cuanto va a pagar";
            txtPago.Size = new Size(275, 28);
            txtPago.TabIndex = 20;
            txtPago.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(126, 335);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(68, 21);
            label1.TabIndex = 24;
            label1.Text = "Nombre";
            // 
            // lblProducto
            // 
            lblProducto.AutoSize = true;
            lblProducto.Location = new Point(5, 413);
            lblProducto.Margin = new Padding(4, 0, 4, 0);
            lblProducto.Name = "lblProducto";
            lblProducto.Size = new Size(0, 21);
            lblProducto.TabIndex = 25;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(257, 413);
            lblTotal.Margin = new Padding(4, 0, 4, 0);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(0, 21);
            lblTotal.TabIndex = 26;
            // 
            // lblPrecioUnitario
            // 
            lblPrecioUnitario.AutoSize = true;
            lblPrecioUnitario.Location = new Point(192, 413);
            lblPrecioUnitario.Margin = new Padding(4, 0, 4, 0);
            lblPrecioUnitario.Name = "lblPrecioUnitario";
            lblPrecioUnitario.Size = new Size(0, 21);
            lblPrecioUnitario.TabIndex = 27;
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Location = new Point(113, 413);
            lblCantidad.Margin = new Padding(4, 0, 4, 0);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(0, 21);
            lblCantidad.TabIndex = 28;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(113, 384);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(72, 21);
            label2.TabIndex = 32;
            label2.Text = "Cantidad";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(192, 384);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(60, 21);
            label3.TabIndex = 31;
            label3.Text = "Unidad";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(257, 384);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(72, 21);
            label4.TabIndex = 30;
            label4.Text = "Total P/U";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(5, 384);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(73, 21);
            label5.TabIndex = 29;
            label5.Text = "Producto";
            // 
            // btnMostrarTicket
            // 
            btnMostrarTicket.Cursor = Cursors.Hand;
            btnMostrarTicket.FlatStyle = FlatStyle.Flat;
            btnMostrarTicket.Location = new Point(350, 584);
            btnMostrarTicket.Margin = new Padding(4, 4, 4, 4);
            btnMostrarTicket.Name = "btnMostrarTicket";
            btnMostrarTicket.Size = new Size(158, 49);
            btnMostrarTicket.TabIndex = 33;
            btnMostrarTicket.Text = "Mostrar Ticket";
            btnMostrarTicket.UseVisualStyleBackColor = true;
            btnMostrarTicket.Click += btnMostrarTicket_Click_1;
            // 
            // btnRegresar
            // 
            btnRegresar.Cursor = Cursors.Hand;
            btnRegresar.FlatStyle = FlatStyle.Flat;
            btnRegresar.Location = new Point(621, 584);
            btnRegresar.Margin = new Padding(4, 4, 4, 4);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(158, 49);
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
            panel1.Margin = new Padding(4, 4, 4, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(804, 35);
            panel1.TabIndex = 35;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // lblHora
            // 
            lblHora.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblHora.AutoSize = true;
            lblHora.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHora.Location = new Point(528, 637);
            lblHora.Margin = new Padding(4, 0, 4, 0);
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
            lblFecha.Location = new Point(442, 658);
            lblFecha.Margin = new Padding(4, 0, 4, 0);
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
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(804, 694);
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
            Margin = new Padding(4, 4, 4, 4);
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