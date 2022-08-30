
namespace Facturacion
{
    partial class VtaEmisionFact
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VtaEmisionFact));
            this.CmbBxEstatusMPago = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.TxtBxImporte = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.CmbBxCFDI = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.CmbBxTPago = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtBxRFC = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.CmbBxEstatus = new System.Windows.Forms.ComboBox();
            this.TxtBxTel = new System.Windows.Forms.TextBox();
            this.TxtBxDir = new System.Windows.Forms.TextBox();
            this.TxtBxFecha = new System.Windows.Forms.TextBox();
            this.TxtBxFact = new System.Windows.Forms.TextBox();
            this.TxtBxCte = new System.Windows.Forms.TextBox();
            this.TxtBxUser = new System.Windows.Forms.TextBox();
            this.BtnCanFact = new System.Windows.Forms.Button();
            this.BtnGenFact = new System.Windows.Forms.Button();
            this.BuscarUser = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // CmbBxEstatusMPago
            // 
            this.CmbBxEstatusMPago.FormattingEnabled = true;
            this.CmbBxEstatusMPago.Items.AddRange(new object[] {
            "PUE - Pago en una sola exhibición",
            "PDD - PAgo en parcialidades o diferido"});
            this.CmbBxEstatusMPago.Location = new System.Drawing.Point(335, 393);
            this.CmbBxEstatusMPago.Name = "CmbBxEstatusMPago";
            this.CmbBxEstatusMPago.Size = new System.Drawing.Size(199, 21);
            this.CmbBxEstatusMPago.TabIndex = 63;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label13.Location = new System.Drawing.Point(211, 393);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(115, 21);
            this.label13.TabIndex = 62;
            this.label13.Text = "Método Pago:";
            // 
            // TxtBxImporte
            // 
            this.TxtBxImporte.Location = new System.Drawing.Point(335, 428);
            this.TxtBxImporte.Name = "TxtBxImporte";
            this.TxtBxImporte.Size = new System.Drawing.Size(158, 20);
            this.TxtBxImporte.TabIndex = 61;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(211, 428);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 21);
            this.label10.TabIndex = 60;
            this.label10.Text = "Importe:";
            // 
            // CmbBxCFDI
            // 
            this.CmbBxCFDI.FormattingEnabled = true;
            this.CmbBxCFDI.Items.AddRange(new object[] {
            "G01 - Adquisición de mercancías",
            "G02 - Devoluciones, descuentos o bonificaciones",
            "G03 - Gastos en general",
            "I04 - Equipo de cómputo y accesorios "});
            this.CmbBxCFDI.Location = new System.Drawing.Point(335, 359);
            this.CmbBxCFDI.Name = "CmbBxCFDI";
            this.CmbBxCFDI.Size = new System.Drawing.Size(199, 21);
            this.CmbBxCFDI.TabIndex = 59;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label12.Location = new System.Drawing.Point(211, 359);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 21);
            this.label12.TabIndex = 58;
            this.label12.Text = "Uso CFDI:";
            // 
            // CmbBxTPago
            // 
            this.CmbBxTPago.FormattingEnabled = true;
            this.CmbBxTPago.Items.AddRange(new object[] {
            "01 - Efectivo",
            "02 - Cheque",
            "03 - Transferencia Electronica",
            "04 - Tarjeta de Credito",
            "28 - Tarjeta de Debito"});
            this.CmbBxTPago.Location = new System.Drawing.Point(335, 325);
            this.CmbBxTPago.Name = "CmbBxTPago";
            this.CmbBxTPago.Size = new System.Drawing.Size(158, 21);
            this.CmbBxTPago.TabIndex = 57;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(211, 325);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 21);
            this.label6.TabIndex = 56;
            this.label6.Text = "Forma de pago:";
            // 
            // TxtBxRFC
            // 
            this.TxtBxRFC.Location = new System.Drawing.Point(335, 120);
            this.TxtBxRFC.Name = "TxtBxRFC";
            this.TxtBxRFC.Size = new System.Drawing.Size(199, 20);
            this.TxtBxRFC.TabIndex = 55;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label11.Location = new System.Drawing.Point(211, 120);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 21);
            this.label11.TabIndex = 54;
            this.label11.Text = "RFC";
            // 
            // CmbBxEstatus
            // 
            this.CmbBxEstatus.FormattingEnabled = true;
            this.CmbBxEstatus.Items.AddRange(new object[] {
            "Activa",
            "Pagada",
            "Sin Pago"});
            this.CmbBxEstatus.Location = new System.Drawing.Point(335, 293);
            this.CmbBxEstatus.Name = "CmbBxEstatus";
            this.CmbBxEstatus.Size = new System.Drawing.Size(158, 21);
            this.CmbBxEstatus.TabIndex = 53;
            // 
            // TxtBxTel
            // 
            this.TxtBxTel.Location = new System.Drawing.Point(335, 256);
            this.TxtBxTel.Name = "TxtBxTel";
            this.TxtBxTel.Size = new System.Drawing.Size(199, 20);
            this.TxtBxTel.TabIndex = 52;
            // 
            // TxtBxDir
            // 
            this.TxtBxDir.Location = new System.Drawing.Point(335, 220);
            this.TxtBxDir.Name = "TxtBxDir";
            this.TxtBxDir.Size = new System.Drawing.Size(199, 20);
            this.TxtBxDir.TabIndex = 51;
            // 
            // TxtBxFecha
            // 
            this.TxtBxFecha.Location = new System.Drawing.Point(335, 187);
            this.TxtBxFecha.Name = "TxtBxFecha";
            this.TxtBxFecha.Size = new System.Drawing.Size(199, 20);
            this.TxtBxFecha.TabIndex = 50;
            // 
            // TxtBxFact
            // 
            this.TxtBxFact.Location = new System.Drawing.Point(335, 154);
            this.TxtBxFact.Name = "TxtBxFact";
            this.TxtBxFact.Size = new System.Drawing.Size(199, 20);
            this.TxtBxFact.TabIndex = 49;
            // 
            // TxtBxCte
            // 
            this.TxtBxCte.Location = new System.Drawing.Point(335, 83);
            this.TxtBxCte.Name = "TxtBxCte";
            this.TxtBxCte.Size = new System.Drawing.Size(199, 20);
            this.TxtBxCte.TabIndex = 48;
            // 
            // TxtBxUser
            // 
            this.TxtBxUser.Location = new System.Drawing.Point(335, 44);
            this.TxtBxUser.Name = "TxtBxUser";
            this.TxtBxUser.Size = new System.Drawing.Size(199, 20);
            this.TxtBxUser.TabIndex = 47;
            // 
            // BtnCanFact
            // 
            this.BtnCanFact.FlatAppearance.BorderSize = 0;
            this.BtnCanFact.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.BtnCanFact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCanFact.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCanFact.ForeColor = System.Drawing.Color.White;
            this.BtnCanFact.Image = ((System.Drawing.Image)(resources.GetObject("BtnCanFact.Image")));
            this.BtnCanFact.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCanFact.Location = new System.Drawing.Point(428, 499);
            this.BtnCanFact.Name = "BtnCanFact";
            this.BtnCanFact.Size = new System.Drawing.Size(165, 39);
            this.BtnCanFact.TabIndex = 46;
            this.BtnCanFact.Text = "Cancelar";
            this.BtnCanFact.UseVisualStyleBackColor = true;
            this.BtnCanFact.Click += new System.EventHandler(this.BtnCanFact_Click);
            // 
            // BtnGenFact
            // 
            this.BtnGenFact.FlatAppearance.BorderSize = 0;
            this.BtnGenFact.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.BtnGenFact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGenFact.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGenFact.ForeColor = System.Drawing.Color.White;
            this.BtnGenFact.Image = ((System.Drawing.Image)(resources.GetObject("BtnGenFact.Image")));
            this.BtnGenFact.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGenFact.Location = new System.Drawing.Point(215, 499);
            this.BtnGenFact.Name = "BtnGenFact";
            this.BtnGenFact.Size = new System.Drawing.Size(165, 39);
            this.BtnGenFact.TabIndex = 45;
            this.BtnGenFact.Text = "Generar";
            this.BtnGenFact.UseVisualStyleBackColor = true;
            this.BtnGenFact.Click += new System.EventHandler(this.BtnGenFact_Click);
            // 
            // BuscarUser
            // 
            this.BuscarUser.FlatAppearance.BorderSize = 0;
            this.BuscarUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Salmon;
            this.BuscarUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BuscarUser.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuscarUser.ForeColor = System.Drawing.Color.White;
            this.BuscarUser.Image = ((System.Drawing.Image)(resources.GetObject("BuscarUser.Image")));
            this.BuscarUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BuscarUser.Location = new System.Drawing.Point(566, 24);
            this.BuscarUser.Name = "BuscarUser";
            this.BuscarUser.Size = new System.Drawing.Size(125, 41);
            this.BuscarUser.TabIndex = 44;
            this.BuscarUser.Text = "Buscar";
            this.BuscarUser.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(211, 293);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 21);
            this.label9.TabIndex = 43;
            this.label9.Text = "Estatus:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(211, 256);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 21);
            this.label8.TabIndex = 42;
            this.label8.Text = "Telefono:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(211, 220);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 21);
            this.label7.TabIndex = 41;
            this.label7.Text = "Dirección:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(211, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 21);
            this.label5.TabIndex = 40;
            this.label5.Text = "Fecha:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(211, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 21);
            this.label4.TabIndex = 39;
            this.label4.Text = "N° Factura:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(211, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 21);
            this.label3.TabIndex = 38;
            this.label3.Text = "Cliente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(211, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 21);
            this.label2.TabIndex = 37;
            this.label2.Text = "Usuario:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(40, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(119, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // VtaEmisionFact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(753, 563);
            this.Controls.Add(this.CmbBxEstatusMPago);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.TxtBxImporte);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.CmbBxCFDI);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.CmbBxTPago);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtBxRFC);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.CmbBxEstatus);
            this.Controls.Add(this.TxtBxTel);
            this.Controls.Add(this.TxtBxDir);
            this.Controls.Add(this.TxtBxFecha);
            this.Controls.Add(this.TxtBxFact);
            this.Controls.Add(this.TxtBxCte);
            this.Controls.Add(this.TxtBxUser);
            this.Controls.Add(this.BtnCanFact);
            this.Controls.Add(this.BtnGenFact);
            this.Controls.Add(this.BuscarUser);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VtaEmisionFact";
            this.Text = "VtaEmisionFact";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CmbBxEstatusMPago;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox TxtBxImporte;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox CmbBxCFDI;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox CmbBxTPago;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtBxRFC;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox CmbBxEstatus;
        private System.Windows.Forms.TextBox TxtBxTel;
        private System.Windows.Forms.TextBox TxtBxDir;
        private System.Windows.Forms.TextBox TxtBxFecha;
        private System.Windows.Forms.TextBox TxtBxFact;
        private System.Windows.Forms.TextBox TxtBxCte;
        private System.Windows.Forms.TextBox TxtBxUser;
        private System.Windows.Forms.Button BtnCanFact;
        private System.Windows.Forms.Button BtnGenFact;
        private System.Windows.Forms.Button BuscarUser;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}