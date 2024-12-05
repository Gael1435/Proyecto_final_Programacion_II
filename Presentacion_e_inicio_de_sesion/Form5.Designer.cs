namespace Presentacion_e_inicio_de_sesion
{
    partial class Form5
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
            rdCredito = new RadioButton();
            rdDebito = new RadioButton();
            groupBox1 = new GroupBox();
            lbTotal = new Label();
            rdOxxo = new RadioButton();
            rdEfectivo = new RadioButton();
            btnPago = new Button();
            gbcredito_debito = new GroupBox();
            bttarjeta = new Button();
            txtExpiracion = new TextBox();
            txtCVC = new TextBox();
            txtNombre = new TextBox();
            txtnumTarjeta = new TextBox();
            gbEfectivo = new GroupBox();
            btefectivo = new Button();
            txtPago = new TextBox();
            label1 = new Label();
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
            rdCredito.Size = new Size(178, 22);
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
            rdDebito.Size = new Size(169, 22);
            rdDebito.TabIndex = 1;
            rdDebito.TabStop = true;
            rdDebito.Text = "Tarjeta de Debito";
            rdDebito.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lbTotal);
            groupBox1.Controls.Add(rdOxxo);
            groupBox1.Controls.Add(rdEfectivo);
            groupBox1.Controls.Add(rdCredito);
            groupBox1.Controls.Add(rdDebito);
            groupBox1.Font = new Font("Showcard Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(29, 27);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(218, 230);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Metodo de pago";
            // 
            // lbTotal
            // 
            lbTotal.AutoSize = true;
            lbTotal.Location = new Point(21, 189);
            lbTotal.Name = "lbTotal";
            lbTotal.Size = new Size(58, 18);
            lbTotal.TabIndex = 3;
            lbTotal.Text = "label1";
            // 
            // rdOxxo
            // 
            rdOxxo.AutoSize = true;
            rdOxxo.Checked = true;
            rdOxxo.Location = new Point(22, 106);
            rdOxxo.Name = "rdOxxo";
            rdOxxo.Size = new Size(70, 22);
            rdOxxo.TabIndex = 3;
            rdOxxo.TabStop = true;
            rdOxxo.Text = "OXXO";
            rdOxxo.UseVisualStyleBackColor = true;
            // 
            // rdEfectivo
            // 
            rdEfectivo.AutoSize = true;
            rdEfectivo.Checked = true;
            rdEfectivo.Location = new Point(21, 78);
            rdEfectivo.Name = "rdEfectivo";
            rdEfectivo.Size = new Size(118, 22);
            rdEfectivo.TabIndex = 2;
            rdEfectivo.TabStop = true;
            rdEfectivo.Text = "En efectivo";
            rdEfectivo.UseVisualStyleBackColor = true;
            // 
            // btnPago
            // 
            btnPago.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPago.Location = new Point(50, 282);
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
            gbcredito_debito.Controls.Add(txtnumTarjeta);
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
            bttarjeta.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bttarjeta.Location = new Point(54, 246);
            bttarjeta.Name = "bttarjeta";
            bttarjeta.Size = new Size(197, 55);
            bttarjeta.TabIndex = 6;
            bttarjeta.Text = "Confirmar pago";
            bttarjeta.UseVisualStyleBackColor = true;
            bttarjeta.Click += bttarjeta_Click;
            // 
            // txtExpiracion
            // 
            txtExpiracion.Font = new Font("Book Antiqua", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtExpiracion.Location = new Point(146, 167);
            txtExpiracion.Margin = new Padding(3, 2, 3, 2);
            txtExpiracion.Name = "txtExpiracion";
            txtExpiracion.PlaceholderText = "Expíracion";
            txtExpiracion.Size = new Size(105, 30);
            txtExpiracion.TabIndex = 22;
            txtExpiracion.TextAlign = HorizontalAlignment.Center;
            // 
            // txtCVC
            // 
            txtCVC.Font = new Font("Book Antiqua", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtCVC.Location = new Point(24, 167);
            txtCVC.Margin = new Padding(3, 2, 3, 2);
            txtCVC.Name = "txtCVC";
            txtCVC.PlaceholderText = "CVC";
            txtCVC.Size = new Size(105, 30);
            txtCVC.TabIndex = 21;
            txtCVC.TextAlign = HorizontalAlignment.Center;
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Book Antiqua", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNombre.Location = new Point(24, 98);
            txtNombre.Margin = new Padding(3, 2, 3, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Nombre";
            txtNombre.Size = new Size(215, 30);
            txtNombre.TabIndex = 20;
            txtNombre.TextAlign = HorizontalAlignment.Center;
            // 
            // txtnumTarjeta
            // 
            txtnumTarjeta.Font = new Font("Book Antiqua", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtnumTarjeta.Location = new Point(24, 47);
            txtnumTarjeta.Margin = new Padding(3, 2, 3, 2);
            txtnumTarjeta.Name = "txtnumTarjeta";
            txtnumTarjeta.PlaceholderText = "Num de tarjeta";
            txtnumTarjeta.Size = new Size(215, 30);
            txtnumTarjeta.TabIndex = 19;
            txtnumTarjeta.TextAlign = HorizontalAlignment.Center;
            // 
            // gbEfectivo
            // 
            gbEfectivo.Controls.Add(btefectivo);
            gbEfectivo.Controls.Add(txtPago);
            gbEfectivo.Location = new Point(633, 38);
            gbEfectivo.Name = "gbEfectivo";
            gbEfectivo.Size = new Size(334, 380);
            gbEfectivo.TabIndex = 5;
            gbEfectivo.TabStop = false;
            gbEfectivo.Text = "Efectivo";
            gbEfectivo.Visible = false;
            // 
            // btefectivo
            // 
            btefectivo.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btefectivo.Location = new Point(48, 244);
            btefectivo.Name = "btefectivo";
            btefectivo.Size = new Size(197, 55);
            btefectivo.TabIndex = 23;
            btefectivo.Text = "Confirmar pago";
            btefectivo.UseVisualStyleBackColor = true;
            btefectivo.Click += btefectivo_Click;
            // 
            // txtPago
            // 
            txtPago.Font = new Font("Book Antiqua", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPago.Location = new Point(48, 39);
            txtPago.Margin = new Padding(3, 2, 3, 2);
            txtPago.Name = "txtPago";
            txtPago.PlaceholderText = "Con cuanto va a pagar";
            txtPago.Size = new Size(215, 30);
            txtPago.TabIndex = 20;
            txtPago.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(885, 9);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 24;
            label1.Text = "Nombre";
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1103, 647);
            Controls.Add(label1);
            Controls.Add(gbEfectivo);
            Controls.Add(gbcredito_debito);
            Controls.Add(btnPago);
            Controls.Add(groupBox1);
            Name = "Form5";
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
        private RadioButton rdOxxo;
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
    }
}